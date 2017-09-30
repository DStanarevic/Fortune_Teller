using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller
{
    
    class Program
    {

        static void Main(string[] args)
        {

            //Declaring my variables.
            int retiringIn;
            int age;
            int month;
            int sibling;
            double money;
            string vacationHome;
            string transportMethod;
            
            //Gathering information.
            //First Namewith Quit
            Console.WriteLine("You are wandering through the desert and come across a lamp,\nyou clean off the dirt and a Jinn appears. \n\nThe Jinn asks you for your name.");
            string firstName = Console.ReadLine().Trim();
            if (firstName.ToLower() == "quit")
            {
                Console.WriteLine($"{firstName} nobody likes a quitter.");
                Environment.Exit(0);
            }

            //Last Name with Quit
            Console.WriteLine("The Jinn asks you for your family name.");
            string lastName = Console.ReadLine().Trim();
            if (lastName.ToLower() == "quit")
            {
                Console.WriteLine($"{firstName} nobody likes a quitter.");
                Environment.Exit(0);
            }

            //Age with Quit.
            Console.WriteLine("The Jinn asks how many years you have lived.");
            string ageInput = Console.ReadLine();
            if (ageInput.ToLower() == "quit")
            {
                Console.WriteLine($"{firstName} nobody likes a quitter.");
                Environment.Exit(0);
            }
            age = int.Parse(ageInput);

            //Month with Quit.
            Console.WriteLine("The Jinn asks for the month that you were born in.");
            string monthInput = Console.ReadLine();
            if (monthInput.ToLower() == "quit")
            {
                Console.WriteLine($"{firstName} nobody likes a quitter.");
                Environment.Exit(0);
            }
            month = int.Parse(monthInput);

            //Favorite color with Quit.
            Console.WriteLine("The Jinn asks you for your favorite color.");
            string color = Console.ReadLine().ToLower();
            if (color.ToLower() == "quit")
            {
                Console.WriteLine($"{firstName} nobody likes a quitter.");
                Environment.Exit(0);
            }
            //Helping with the colors.
            if (color == "help")
            {
                Console.WriteLine("The Jinn let's you choose between Red, Orange, Yellow, Green, Blue, Indigo and Violet.");
                color = Console.ReadLine().ToLower();
            }

            //Siblings with Quit.
            Console.WriteLine("The Jinn asks how many siblings you have.");
            string siblingInput = Console.ReadLine();
            if (siblingInput.ToLower() == "quit")
            {
                Console.WriteLine($"{firstName} nobody likes a quitter.");
                Environment.Exit(0);
            }
            sibling = int.Parse(siblingInput);

            //Retirement calculation.
            if (age % 2 == 0)
            {
                retiringIn = 5;
            }
            else
            {
                retiringIn = 10;
            }

            //VacationHome
            if (sibling == 0)
            {
                vacationHome = "near the sea";
            }

            else if (sibling == 1)
            {
                vacationHome = "in the mountains";
            }
            else if (sibling == 2)
            {
                vacationHome = "in the country side";
            }
            else if (sibling >= 3)
            {
                vacationHome = "somewhere in a large city";
            }
            else
            {
                vacationHome = "somewhere cold";
            }

            //Transportation
            if (color.ToLower() == "red")
            {
                transportMethod = "horse";
            }
            else if (color.ToLower() == "car")
            {
                transportMethod = "sail boat";
            }
            else if (color.ToLower() == "magic carpet")
            {
                transportMethod = "motorcycle";
            }
            else if (color.ToLower() == "green")
            {
                transportMethod = "private plane";
            }
            else if (color.ToLower() == "blue")
            {
                transportMethod = "segway";
            }
            else if (color.ToLower() == "indigo")
            {
                transportMethod = "bicycle";
            }
            else if (color.ToLower() == "violet")
            {
                transportMethod = "motor home";
            }
            else
            {
                transportMethod = "tricycle";
            } 

            //Savings
            switch (month)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    money = 10000.00;
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                    money = 100000.00;
                    break;
                case 9:
                case 10:
                case 11:
                case 12:
                    money = 1000000.00;
                    break;
                default:
                    money = 0.00;
                    break;
            }

            //Output
            Console.WriteLine("The Jinn looks over and starts to speak.");
            Console.WriteLine($"\n\"{firstName} {lastName} will go into retirement in {retiringIn} years of time with the ${money} that you have saved. You will have a second home {vacationHome}\nwith a {transportMethod} to use as you please.\"");
            }
    }
}

