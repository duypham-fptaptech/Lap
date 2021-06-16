using System;

namespace Lap5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var highSchoolTeacher = new HighSchoolTeacher()
            {
                IdentityNumber = "ID001",
                Name = "Spring Hero",
                BaseSalary = 100,
                Level = 1,
                Bonus = 100,
                IsSenior = false,
                HighSchoolCode = "HS001"
            };
            Console.WriteLine(highSchoolTeacher.CalculateSalary());
            var universityTeacher = new UniversityTeacher()
            {
                IdentityNumber = "ID001",
                Name = "Du",
                BaseSalary = 60000,
                Level = 1,
                Bonus = 1000,
                IsSenior = true,
                EnglishLevel = 2,
                UniversityCode = "HS002"
            };
            Console.WriteLine(universityTeacher.CalculateSalary());
        }
    }
}
