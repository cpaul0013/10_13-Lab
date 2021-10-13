using System;
using System.Collections.Generic;

namespace UML_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff staff = new Staff("James Jameson", "123 Elm Street", "Education", 55000);
            Staff staffb = new Staff("Paul Paulson", "456 Fake Street", "Business", 60000);
            Student studenta = new Student("John Johnson", "876 Rose Trail", "Economics", 1, 8000);
            Student studentb = new Student("Ann Anderson", "3456 Sunflower Lane", "Computer Science", 2, 7000);
            Student studentc = new Student("William Willson", "123 Mystery Street", "Art", 3, 7000);
            List<Person> Directory = new List<Person>();
            Directory.Add(staff);
            Directory.Add(staffb);
            Directory.Add(studenta);
            Directory.Add(studentb);
            Directory.Add(studentc);




            foreach (Person p in Directory)
            {
                Console.WriteLine($"{p.ToString()} \n");
            }
           
            
            
            while(true)
            {
                AddToList(Directory);

                // This is to check to see if the name is added correctly
                Console.WriteLine("Here is the updated directory \n");
                foreach (Person p in Directory)
                {
                    Console.WriteLine($"{p.ToString()} \n");
                }

                if (KeepGoing() == false)
                {
                    break;
                }





            }

        }


        public static bool KeepGoing()
        {
            bool keepgoing = true;
            bool result = true;
            while (keepgoing)
            {
                Console.WriteLine("Would you like to add someone to the list? Y / N");
                string response = Console.ReadLine().ToLower().Trim();
                if (response == "y" || response == "yes")
                {
                    keepgoing = false;
                    result = true;
                }

                else if (response == "n" || response == "no")
                {

                    keepgoing = false;
                    result = false;

                }

                else
                {
                    Console.WriteLine("That was not a valid answer");
                }

            }

            return result;

        }
        public static string CheckInput()
        {

            string result = "";
            while (result == "")
            {
                Console.WriteLine("Which would you like to add? Student / Staff");
                string response = Console.ReadLine().ToLower().Trim();
                if (response == "student")
                {

                    result = "student";
                }

                else if (response == "staff")
                {

                    result = "staff";

                }

                else
                {
                    Console.WriteLine("That was not a valid answer");
                }

            }

            return result;

        }


        public static void AddToList(List<Person> people)
        {
            string name = "";
            string address = "";
            string school = "";
            double pay = 0;
            string program = "";
            int year = 0;
            double fee = 0;
            string choice = "";
           
           
                choice = CheckInput();


            


            if (choice == "staff")
            {
                Console.WriteLine("\nPlease enter the person's name: ");
                name = Console.ReadLine();

                Console.WriteLine("\nPlease enter the person's address: ");
                address = Console.ReadLine();

                Console.WriteLine("\nPlease enter the person's school: ");
                school = Console.ReadLine();

                while (true)
                {
                    try
                    {
                        Console.WriteLine("\nPlease enter the person's pay: ");
                        pay = double.Parse(Console.ReadLine());
                        break;
                    }

                    catch
                    {
                        Console.WriteLine("\nPlease enter a valid number");

                    }
                }

                Staff newStaff = new Staff(name, address, school, pay);
                people.Add(newStaff);
            }

            else if(choice == "student")
            {
                Console.WriteLine("\nPlease enter the person's name: ");
                name = Console.ReadLine();

                Console.WriteLine("\nPlease enter the person's address: ");
                address = Console.ReadLine();

                Console.WriteLine("\nPlease enter the person's program");
                program = Console.ReadLine();

                while (true)
                {
                    try
                    {
                        Console.WriteLine("\nPlease enter the person's year: ");
                        year = int.Parse(Console.ReadLine());
                        break;
                    }

                    catch
                    {
                        Console.WriteLine("\nPlease enter a valid number");

                    }
                }

                while (true)
                {
                    try
                    {
                        Console.WriteLine("\nPlease enter the person's fee: ");
                        fee = double.Parse(Console.ReadLine());
                        break;
                    }

                    catch
                    {
                        Console.WriteLine("\nPlease enter a valid number");

                    }
                }

                Student newStudent = new Student(name, address, program, year,fee);
                people.Add(newStudent);

            }
        }
    }
}
