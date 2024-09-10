using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        private double baseSalary;
        public double BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }

        public double earnings()
        {
            return baseSalary + base.Earnings();
        }
    public void print()
        {
            Console.WriteLine($"base-salaried ");
            base.Print();
            Console.WriteLine($"base salary : {baseSalary}");
        }
    }
}
