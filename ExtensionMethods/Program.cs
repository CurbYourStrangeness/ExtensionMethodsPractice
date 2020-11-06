using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel pers = new PersonModel();

            pers.fName = "What is your first name?".RequestString();

            pers.lName = "What is your last name?".RequestString();

            pers.Age = ConsoleHelper.RequestInt("What is your age?", 0, 999999999);

            Console.WriteLine($"{pers.fName}, {pers.lName}, {pers.Age}");

            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string fName { get; set; }

        public string lName { get; set; }

        public int Age { get; set; }

        public int ChildrenNum { get; set; }

    }
}
