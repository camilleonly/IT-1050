using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARE VARIABLES

            string firstName;
            string middleInitial;
            string lastName;
            string fullName;

            int age;
            int heightFeet;

            bool isCitizen = false;
            bool canVote = false;

            double heightInches;
            double totalHeightCM;

            // MAIN BODY

            System.Console.WriteLine("What is your first name? ");
            firstName = System.Console.ReadLine();

            System.Console.WriteLine("What is your middle initial? ");
            middleInitial = System.Console.ReadLine();

            System.Console.WriteLine("What is your Last Name? ");
            lastName = System.Console.ReadLine();

            fullName = firstName + " " + middleInitial + ". " + lastName;

            System.Console.WriteLine("What is your base height in feet? ");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many inches beyond your base height are you? ");
            heightInches = double.Parse(System.Console.ReadLine());

            totalHeightCM = (((heightFeet * 12) + heightInches) * 2.54);

            System.Console.WriteLine("What is your age in years? ");
            age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Type the word true if you are a US citizen and type the word false if you are not. ");
            isCitizen = bool.Parse(System.Console.ReadLine());
          
            if (isCitizen && age > 17)
                canVote = true;

            System.Console.WriteLine("Your name is " + fullName + ".");
            System.Console.WriteLine("Your height is " + totalHeightCM + " centimeters.");
            System.Console.WriteLine("You are eligible to vote is a " + canVote + " statement.");

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();

        }

    }
}
