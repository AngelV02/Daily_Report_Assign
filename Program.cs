using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print program header
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine();

            // Prompt and save user input
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("What course are you on? ");
            string course = Console.ReadLine();

            Console.Write("What page number? ");
            int pageNumber = int.Parse(Console.ReadLine());

            Console.Write("Do you need help with anything? Please answer 'true' or 'false': ");
            bool needHelp = bool.Parse(Console.ReadLine());

            Console.Write("Were there any positive experiences you’d like to share? Please give specifics: ");
            string positiveExperiences = Console.ReadLine();

            Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
            string feedback = Console.ReadLine();

            // Declare a variable to store the study hours
            double studyHours;

            // Declare a variable to track the validity of the study hours
            bool isValidStudyHours;
            do

            {
                Console.Write("How many hours did you study today? ");

                // Read the user input as a string
                string studyHoursInput = Console.ReadLine();

                isValidStudyHours = double.TryParse(studyHoursInput, out studyHours);
                // parse the input string as a double value
                // 
                if (!isValidStudyHours)
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                    // Display an error message if the input is not a valid numeric value
                }
            } while (!isValidStudyHours);
            // Repeat the loop until a valid numeric value is entered for study hours


            // Print thank you message
            Console.WriteLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            // Wait for user input to exit the program
            Console.ReadLine();

        }
    }
}
