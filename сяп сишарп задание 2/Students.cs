using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace сяп_сишарп_задание_2
{
    //если имя не соответствует требованиям "буквы латиница и кириллицы + "-"
    class UrNameIsSh : Exception
    {
        private string message = @"Поле содержит посторонние элементы.
Допустимы буквы латиницы, кириллицы и тире.";
        public override string Message { get => message; }

        public UrNameIsSh() { }
        public UrNameIsSh(string message)
        {
            this.message = message;
        }
    }
    delegate bool BySomething(Student student, string str);

    class NameConversion
    {
        //допустим, что в имени допускаются все буквы кириллицы и латиницы, а также "-" для имён типа Хмм-даже-не-знаю
        private static bool IsNormalChar(char a)
        {
            return a >= 'А' && a <= 'Я' || a >= 'а' && a <= 'я' || a >= 'A' && a <= 'Z' || a >= 'a' && a <= 'z' || a == '-';
        }
        private static bool IsNormalName(string name)
        {
            foreach (char a in name)
                if (!IsNormalChar(a))
                    return false;
            return true;
        }
        // уменьшениеее
        private static char ToLower(char a)
        {
            if (a >= 'А' && a <= 'Я')
                a = (char)(a - 'А' + 'а');
            else if (a >= 'A' && a <= 'Z')
                a = (char)(a - 'A' + 'a');
            return a;
        }
        // объясни свою маленькость — я потат
        private static char ToHigher(char a)
        {
            if (a >= 'a' && a <= 'z')
                a = (char)(a - 'a' + 'A');
            else if (a >= 'а' && a <= 'я')
                a = (char)(a - 'а' + 'А');
            return a;
        }
        // делает первую и после '-' заглавными, остальные маленькими
        public static string FirstCapitalOthersNot(string word)
        {
            //проверка корректности строки
            if (word == "") return "";
            if (!IsNormalName(word))
                throw new UrNameIsSh();

            string temp = "";
            temp += ToHigher(word[0]);
            for (int i = 1; i < word.Length; i++)
            {
                temp += ToLower(word[i]);
                // когда мы встречаем тире, следующий символ должен быть заглавным, но если пользователь долб... не очень умный, и ввёл тире в конце, то ничего не просиходит
                if (word[i] == '-' && i != word.Length - 1)
                    temp += ToHigher(word[++i]);
            }
            return temp;
        }
    }
    [Serializable]
    [XmlInclude(typeof(Master))]
    [XmlInclude(typeof(Bachelor))]
    public class Student
    {
        public string first_name;
        public string last_name;
        public string faculty;

        public string First_name { get => first_name; }
        public string Last_name { get => last_name; }
        public string Faculty { get => faculty; }

        public Student() { }

        public Student(string first_name, string last_name, string faculty)
        {
            this.first_name = NameConversion.FirstCapitalOthersNot(first_name);
            this.last_name = NameConversion.FirstCapitalOthersNot(last_name);
            this.faculty = NameConversion.FirstCapitalOthersNot(faculty);
        }

        public virtual void ChangeInfo (string first_name, string last_name, string faculty)
        {
            this.first_name = NameConversion.FirstCapitalOthersNot(first_name);
            this.last_name = NameConversion.FirstCapitalOthersNot(last_name);
            this.faculty = NameConversion.FirstCapitalOthersNot(faculty);
        }

    }

    public class Bachelor : Student
    {
        public Bachelor() { }

        public Bachelor(string first_name, string last_name, string faculty) : base(first_name, last_name, faculty)
        {

        }

        public new void ChangeInfo(string first_name, string last_name, string faculty)
        {
            base.ChangeInfo(first_name, last_name, faculty);
        }
    }

    public class Master : Student
    {
        public string degree_info = "";
        public Master() { }
        public Master(string first_name, string last_name, string faculty, string degree_info) : base(first_name, last_name, faculty)
        {
            this.degree_info = degree_info;
        }

        public void ChangeInfo(string first_name, string last_name, string faculty, string degree_info)
        {
            base.ChangeInfo(first_name, last_name, faculty);
            this.degree_info = degree_info;
        }
    }



    class Students
    {
        protected List<Student> all_students = new List<Student>();
        private int? curr_student = null;

        public List<Student> All_students { get => all_students; }
        public int? Curr_student { get => curr_student; }

        public Students() { }
        public Students(List<Student> all_students)
        {
            foreach (Student a in all_students)
                this.all_students.Add(a);
            curr_student = 0;
        }
        public void AddStudent(Student new_student)
        {
            all_students.Add(new_student);
            if (curr_student.HasValue)
                curr_student++;
            else curr_student = 0;
        }
        public void AddStudent(string first_name, string last_name, string faculty)
        {
            Bachelor new_student = new Bachelor(first_name, last_name, faculty);
            AddStudent(new_student);
        }

        public void AddStudent(string first_name, string last_name, string faculty, string degree_info)
        {
            Master new_student = new Master(first_name, last_name, faculty, degree_info);
            AddStudent(new_student);
        }

        public static bool ByFirstName(Student student, string str)
        {
            return student.First_name == NameConversion.FirstCapitalOthersNot(str);
        }
        public static bool ByLastName(Student student, string str)
        {
            return student.Last_name == NameConversion.FirstCapitalOthersNot(str);
        }
        public static bool ByFaculty(Student student, string str)
        {
            return student.Faculty == NameConversion.FirstCapitalOthersNot(str);
        }
        public static bool All(Student student, string str)
        {
            return true;
        }
        
        public Student Next(BySomething filter, string str)
        {
            if (curr_student == all_students.Count - 1)
                return null;
            curr_student++;
            if (filter(all_students[curr_student.Value], str))
                return all_students[curr_student.Value];
            else return Next(filter, str);
        }

        public Student Prev(BySomething filter, string str)
        {
            if (curr_student == 0)
                return null;
            curr_student--;
            if (filter(all_students[curr_student.Value], str))
                return all_students[curr_student.Value];
            else return Prev(filter, str);
        }

        public void DeleteCurrStudent()
        {
            if (!curr_student.HasValue)
                return;
            else all_students.RemoveAt(curr_student.Value);
            if (curr_student == all_students.Count)
                curr_student--;
            if (all_students.Count == 0)
                curr_student = null;
        }

        public void Clean()
        {
            all_students.RemoveAll(n => true);
            curr_student = null;
        }

    }
}
