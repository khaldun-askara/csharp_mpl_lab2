using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace сяп_сишарп_задание_2
{
    
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());


            Students student_list = new Students();
            student_list.AddStudent("nameOne", "famOne", "facOne");
            student_list.AddStudent("nameOne", "famTwo", "facTwo");
            student_list.AddStudent("nameTwo", "famTwo", "facTwo");
            student_list.AddStudent("nameTwo", "famThree", "facThree");
            student_list.AddStudent("nameThree", "famThree", "facThree");
            student_list.AddStudent("nameThree", "famOne", "facOne");
            Students newstudents = student_list.FindByFirstName("nameOne");
            Console.WriteLine("nameOne");
            foreach (Student a in newstudents.All_students)
                Console.WriteLine(a.First_name + " " + a.Last_name + " " + a.Faculty);

            Console.ReadKey();
        }
    }
}
