using System;


namespace myConsoleProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
            string anyHelp = Console.ReadLine();
            if (anyHelp == "true")
                 {
                    Console.WriteLine("Please reach out to your instructor.");
                 }
            else if (anyHelp == "false")
                {
                    Console.WriteLine("Sounds Good");
                }
            else
            {
                Console.WriteLine("Please answer true or false");
            }
            string posExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int studyHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            string thanks = Console.ReadLine();
        }
    }
}
