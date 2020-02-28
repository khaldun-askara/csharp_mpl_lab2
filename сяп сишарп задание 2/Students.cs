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
        private string first_name;
        private string last_name;
        private string faculty;

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
    }
    class Students
    {
        List<Student> all_students = new List<Student>();

        public void AddStudent(Student new_student)
        {
            all_students.Add(new_student);
        }
        public void AddStudent(string first_name, string last_name, string faculty)
        {
            Student new_student = new Student(first_name, last_name, faculty);
            AddStudent(new_student);
        }

    }
}
