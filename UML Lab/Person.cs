using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Lab
{
    class Person
    {
        private string Name { get; set; }
        private string Address { get; set; }



        public string GetName()
        {

            return Name;


        }

        public string GetAddress()
        {
            return Address;

        }
        public Person (string name, string address)
        {
            Name = name;
            Address = address;

        }
        public Person()
        {


        }

        public override string ToString()
        {
            return $"Person {Name} {Address}";
        }
    }
}
