using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Employee
{
    public class CommissionEmployee : Employee
    {
        private double grossSales;
        private double commissionRate;
        public double GrossSales
        {
            get { return grossSales; }
            set {
                if (value >= 0.0)
                    grossSales = value;
                else
                    Console.WriteLine("Gross sales must be >= 0.0");
            } 
        }

        public double CommissionRate
        {
            get { return commissionRate; }
            set {
                if (value > 0.0 && value < 1.0)
                {
                    commissionRate = value;
                }
                else
                {
                    throw new Exception("Commission Rate sales must be >= 0.0");
      
                }
            }
        }
        public override double Earnings()
        {
            return commissionRate * grossSales;
        }

        public override void Print()
        {
            Console.WriteLine($"salaried employee: {firstName} {lastName}");
            base.Print();
            Console.WriteLine($"gross Sales {grossSales}");
            Console.WriteLine($"commission rate {commissionRate}");
        }

        public void setGlossSales(double sales)
        {
            if (sales >= 0.0)
                grossSales = sales;
            else
                throw new Exception(message: "Gross sales must be >= 0.0");
        }

        public void setCommissionRate(double rate)
        {
            if(rate > 0.0 && rate < 1.0)
            {
                commissionRate = rate;
            }
            else
            {
                throw new Exception(message: "Commission Rate sales must be >= 0.0");
            }
        }
    }
}
