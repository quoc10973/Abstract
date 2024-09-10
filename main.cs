using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class main
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                // create derived-class objects using object initializers
                var salariedEmployee = new SalariedEmployee
                {
                    firstName = "John",
                    lastName = "Smith",
                    socialSecurityNumber = "111-11-1111",
                    WeeklySalary = 800
                };

                var commissionEmployee = new CommissionEmployee
                {
                    firstName = "Sue",
                    lastName = "Jones",
                    socialSecurityNumber = "333-33-3333",
                    GrossSales = 10000,
                    CommissionRate = 0.06
                };

                var basePlusCommissionEmployee = new BasePlusCommissionEmployee
                {
                    firstName = "Bob",
                    lastName = "Lewis",
                    socialSecurityNumber = "444-44-4444",
                    GrossSales = 5000,
                    CommissionRate = 0.04,
                    BaseSalary = 300
                };
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }

            Console.WriteLine("Employees processed individually using static binding:\n");

            // output each Employee's information and earnings using static binding
            salariedEmployee.Print();
            Console.WriteLine("\n");

            // create list of base-class references (in C#, no need for pointers)
            List<Employee> employees = new List<Employee>
            {
                salariedEmployee,
                commissionEmployee,
                basePlusCommissionEmployee
            };

            Console.WriteLine("Employees processed polymorphically via dynamic binding:\n");

            // call virtualViaPointer to print each Employee's information
            Console.WriteLine("Virtual function calls made off base-class references:\n");
            foreach (var employee in employees)
            {
                VirtualViaPointer(employee);
            }

            // call virtualViaReference to print each Employee's information
            Console.WriteLine("Virtual function calls made off base-class references:\n");
            foreach (var employee in employees)
            {
                VirtualViaReference(employee);
            }
        }

        static void VirtualViaPointer(Employee baseClassPtr)
        {
            baseClassPtr.Print();
            Console.WriteLine($"earned ${baseClassPtr.Earnings():F2}\n");
        }

        static void VirtualViaReference(Employee baseClassRef)
        {
            baseClassRef.Print();
            Console.WriteLine($"earned ${baseClassRef.Earnings():F2}\n");
        }
        
    }
    }
