using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Lab
{
    class Staff : Person
    {

        private string School { get; set; }
        private double Pay { get; set; }

        public Staff(string name, string address, string school, double pay): base(name, address)
        {
            School = school;
            Pay = pay;


        }

        public Staff()
        {


        }

        public override string ToString()
        {
            return $"{base.ToString()} {School} {Pay}";
        }
    }
}
