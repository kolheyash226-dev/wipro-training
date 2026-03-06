using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesExamples
{
    [Custom(InformationString ="Student Class")]
    internal class Student
    {
        [Custom(InformationString ="Student Default Constructor")]
        public Student()
        {

        }

        [Custom(InformationString = "Student Overloaded Constructor")]
        public Student(int id, string name, string description, double cgpa)
        {
            Id = id;
            Name = name;
            Description = description;
            Cgpa = cgpa;
        }


        //[Custom(InformationString ="StudentId Property")] -- error as not applicable
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Cgpa { get; set; }


        [Custom(InformationString ="Method Level")]
        public void Show()
        {
            Console.WriteLine("Student Info");
        }
    }
}
