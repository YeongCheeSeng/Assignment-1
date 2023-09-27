using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        public class student
        {
            string name;
            string id;
            public student()
            {
                Console.Write("Student's Name: ");
                name = Console.ReadLine();
                Console.Write("Student's ID: ");
                id = Console.ReadLine();
            }
            public void PrintStudent()
            {
                Console.WriteLine(id + "   -   " + name);
            }
        }
        
        
        static void Main(string[] args)
        {
            student StudentInfo = new student();
            StudentInfo.PrintStudent();
        }
    }
}
