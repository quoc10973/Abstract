namespace Employee
{
    public abstract class Employee
    {
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? socialSecurityNumber { get; set; }

        public abstract double Earnings();

        public virtual void Print()
        {
            Console.WriteLine($"{firstName} {lastName} \n social security number: {socialSecurityNumber}");
        }

    }
}
