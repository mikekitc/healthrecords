using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Health_Records
{
    class HealthProfile
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public DateTime dateOfBirth { get; set; }
        public double height { get; set; }
        public double weight { get; set; }

        public HealthProfile(string firstName, string lastName, string gender, DateTime dateOfBirth, double height, double weight)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.height = height;
            this.weight = weight;
        }

        public int CalculateAge(DateTime dateOfBirth)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - dateOfBirth.Year;
            if (dateOfBirth.AddYears(age) > now)
                age--;
            return age;
        }

        public int MaxHeartRate()
        {
            int maxHeartRate = 220 - this.CalculateAge(dateOfBirth);
            return maxHeartRate;
        }

        public double MinTargetHeartRate()
        {
            double minTargetHeartRate = 0.5 * this.MaxHeartRate();
            return Math.Floor(minTargetHeartRate);
        }

        public double MaxTargetHeartRate()
        {
            double maxTargetHeartRate = 0.85 * this.MaxHeartRate();
            return Math.Floor(maxTargetHeartRate);
        }

        public string BMI()
        {
            double bodyMassIndex = ((weight * 703) / (height * height));
            string value;

            if (bodyMassIndex >= 30)
                value = "Obese.";
            else
                if (bodyMassIndex >= 25)
                    value = "Overweight.";
                else
                    if (bodyMassIndex >= 18.5)
                        value = "Normal.";
                    else
                        value = "Underweight.";

            return bodyMassIndex.ToString("n1") + " - " + value;
        }

        public string CalculateHeight()
        {
            double inches = height % 12;
            double feet = height / 12;
            return Math.Floor(feet) + "'" + inches + "\"";
        }
    }
}
