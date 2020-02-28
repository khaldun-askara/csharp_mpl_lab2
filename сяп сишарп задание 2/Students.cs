using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сяп_сишарп_задание_2
{
    //если имя не соответствует требованиям "буквы латиница и кириллицы + "-"
    class UrNameIsSh : Exception
    {
        private string message = @"Имя содержит посторонние элементы.
Допустимы буквы латиницы, кириллицы и тире.";
        public override string Message { get => message; }

        public UrNameIsSh() { }
        public UrNameIsSh(string message)
        {
            this.message = message;
        }
    }
    class Student
    {
        protected string first_name;
        protected string last_name;
        protected string faculty;

        public string First_name { get => first_name; }
        public string Last_name { get => last_name; }
        public string Faculty { get => faculty; }

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

        public Student(string first_name, string last_name, string faculty)
        {
            this.first_name = FirstCapitalOthersNot(first_name);
            this.last_name = FirstCapitalOthersNot(last_name);
            this.faculty = FirstCapitalOthersNot(faculty);
        }

        public virtual void ChangeInfo (string first_name, string last_name, string faculty)
        {
            this.first_name = FirstCapitalOthersNot(first_name);
            this.last_name = FirstCapitalOthersNot(last_name);
            this.faculty = FirstCapitalOthersNot(faculty);
        }
    }

    class Bachelor : Student
    {

        public Bachelor(string first_name, string last_name, string faculty) : base(first_name, last_name, faculty)
        {

        }

        public void ChangeInfo(string first_name, string last_name, string faculty)
        {
            base.ChangeInfo(first_name, last_name, faculty);
        }
    }

    class Master : Student
    {
        protected string degree_info;
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
        protected int? curr_student = null;

        internal List<Student> All_students { get => all_students; }

        public Students() { }
        public Students (List<Student> all_students)
        {
            foreach (Student a in all_students)
                this.all_students.Add(a);
        }
        public void AddStudent(Student new_student)
        {
            all_students.Add(new_student);
        }
        public void AddStudent(string first_name, string last_name, string faculty)
        {
            Student new_student = new Student(first_name, last_name, faculty);
            AddStudent(new_student);
        }

        public Students FindByFirstName (string str)
        {
            return new Students(all_students.Where(n => n.First_name == Student.FirstCapitalOthersNot(str)).ToList());
        }

        public Students FindByLastName(string str)
        {
            return new Students(all_students.Where(n => n.Last_name == Student.FirstCapitalOthersNot(str)).ToList());
        }

        public Students FindByFaculty(string str)
        {
            return new Students(all_students.Where(n => n.Faculty == Student.FirstCapitalOthersNot(str)).ToList());
        }

        public void DeleteCurrStudent()
        {
            if (!curr_student.HasValue)
                return;
            else all_students.RemoveAt(curr_student.Value);
        }

    }
}
