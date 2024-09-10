using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class SalariedEmployee : Employee
    {
        private double weeklySalary;
        public double WeeklySalary
        {
            get { return weeklySalary; }
            set { weeklySalary = value; }
        }

        public override double Earnings()
        {
            return weeklySalary;
        }

        public override void Print()
        {
            Console.WriteLine($"salaried employee: {firstName} {lastName}");
            base.Print();
            Console.WriteLine($"weekly salary {weeklySalary}");
        }

        public void setSalary(double salary)
        {
            if (salary >= 0)
                weeklySalary = salary;
            else
                throw new Exception(message: "Weekly salary must be >= 0.0");
        }

    }
}
