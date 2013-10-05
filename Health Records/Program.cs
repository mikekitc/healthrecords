using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Health_Records
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Gender: ");
            string gender = Console.ReadLine();
            Console.Write("Birthdate (MM-DD-YYYY): ");
            DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Height (in inches): ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Weight (in pounds): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            HealthProfile healthProfile = new HealthProfile(firstName, lastName, gender, dateOfBirth, height, weight);

            Console.Clear();

            Console.WriteLine("USER INFORMATION\n------------------------");
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Date of birth: " + dateOfBirth.Day + "/" + dateOfBirth.Month + "/" + dateOfBirth.Year);
            Console.WriteLine("Height: " + healthProfile.CalculateHeight());
            Console.WriteLine("Weight: " + weight + " lbs.");
            Console.WriteLine();
            Console.WriteLine("HEALTH PROFILE\n------------------------");
            Console.WriteLine("Age: " + healthProfile.CalculateAge(dateOfBirth));
            Console.WriteLine("BMI: " + healthProfile.BMI());
            Console.WriteLine("Maximum heart rate: " + healthProfile.MaxHeartRate() + " beats per minute.");
            Console.WriteLine("Target heart rate: " + healthProfile.MinTargetHeartRate() + "-" + healthProfile.MaxTargetHeartRate() + " beats per minute.");
            Console.WriteLine();
            Console.WriteLine("BMI VALUES");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("| Underweight: less than 18.5     |");
            Console.WriteLine("| Normal: between 18.5 and 24.9   |");
            Console.WriteLine("| Overweight: between 25 and 29.9 |");
            Console.WriteLine("| Obese: 30 or greater            |");
            Console.WriteLine("-----------------------------------");

            Console.ReadKey();
        }
    }
}
