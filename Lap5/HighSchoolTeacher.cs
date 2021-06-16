namespace Lap5
{
    public class HighSchoolTeacher: AbstractTeacher
    {
        public string HighSchoolCode { get; set; }
        
        public override double CalculateSalary()
        {
            if (Bonus > 10000)
            {
                throw new AmountExeption("Bonus is more than 10000", Name);
            }

            var Salary = BaseSalary * Level + Bonus;
            if (IsSenior && Salary < 60000)
            {
                throw new AmountExeption("Senior Lecture gets less than 60000 salary", Name);
            }
            return Salary;
        }
    }
}