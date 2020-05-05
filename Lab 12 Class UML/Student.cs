using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12_Class_UML
{
    class Student : Person
    {
        public string Program { get; set; }
        public int Year { get; set; }

        public double Fee { get; set; }

        public Student ()
        {

        }

        public Student (string Name, string Address, string Program, int Year, double Fee) : base(Name, Address)
        {
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;
        }
        public override string ToString()
        {
            return $"Student: {Name}, Address: {Address}, Program: {Program}, Year: {Year}, Fee: {Fee}";
        }
    }
}
