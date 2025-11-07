using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor();
            Professor professor1 = new Professor() { Name = "Usha sri", Course = "Biology"};
            professor.Name = "Monika";
            professor.ShowName();
            professor.Course = "AWS";
            professor.ShowCourse();
            professor.ConductResearch();
            Console.ReadLine();
        }
    }
}
