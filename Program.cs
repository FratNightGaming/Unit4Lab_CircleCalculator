using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

namespace CircleObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input;

            int circlesCreated = 0;
            
            Console.WriteLine("Welcome to \"Circle Calculator\"!");
        
            while (true)
            {
                Console.WriteLine("Please enter a radius:");

                while (true)
                {
                    try
                    {
                        input = double.Parse(Console.ReadLine());
                        break;
                    }

                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Please enter a numeric value. Try again:");
                    }
                }

                Circle c1 = new Circle(input);
                c1.CalculateCircumference();
                c1.CalculateArea();
                circlesCreated++;

                Console.WriteLine($"Radius of circle - {input}\nCircumference of circle - {c1.CalculateFormattedCircumference()}\nArea of circle - {c1.CalculateFormattedArea()}");

                if (!Continue())
                {
                    Console.WriteLine($"Exiting Program. Goodbye!\nYou created {circlesCreated} circles");
                    break;
                }
            }
        }

        public static bool Continue()
        {
            Console.WriteLine("Would you like to roll again Y/N");

            string input = Console.ReadLine().Trim().ToUpper();

            if (input == "Y" || input == "YES")
            {
                return true;
            }
            else if (input == "N" || input == "NO")
            {
                Console.WriteLine("\nThanks for playing and have a great day!");
                return false;
            }
            else
            {
                Console.WriteLine($"\n\"{input}\" is an invalid command. Try again.");
                return Continue();
            }
        }
    }
}
/*What will the application do?
The application prompts the user to enter a radius; the user may enter a decimal number.
The application displays an error if the user enters invalid data and asks the user again for a radius.
When the user enters valid data, the application calculates the area and circumference of the circle and rounds to the nearest 2 decimal places and prints out both.
The application asks the user whether they want to do another.
The application displays a “goodbye” message that also indicates the number of circles the user built when the user chooses not to continue.

Build Specifications:
Create a class named Circle to store the data about this circle. This class should contain these constructors and methods:
public Circle(double radius)
public double CalculateCircumference()
public string CalculateFormattedCircumference()
public double CalculateArea()
public string CalculateFormattedArea()
private string FormatNumber(double x)
Define a member called radius. This member should be private. 
Define a property to get access to the class member : Radius
For the value of pi, use the PI constant of the System.Math class.
Get the user input, create a Circle object, and display the circumference and area.

Hints:
Don’t mess up the formulas for circumference or area of a circle!

Extra Challenges:
Create a class named Validator and use its static methods to validate the data in this application.*/
