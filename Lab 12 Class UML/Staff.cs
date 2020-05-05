using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12_Class_UML
{
    class Staff : Person
    {
        public string School { get; set; }
        public double Pay { get; set; }

        public Staff()
        {

        }

      public Staff(string Name, string Address, string School, double Pay) : base (Name, Address)
        {
            this.School = School;
            this.Pay = Pay;
        }

        public override string ToString()
        {
            return $"Staff: {Name} Address: {Address} School: {School} Pay: {Pay}";
        }
    }
}
