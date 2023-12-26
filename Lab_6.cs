class Program
{
    static void Main(string[] args)
    {
        LoyaltyProgram loyaltyProgram = new LoyaltyProgram();
        loyaltyProgram.AddEmployee(new Employee(2)); 
        loyaltyProgram.AddEmployee(new Employee(3));

        loyaltyProgram.CalculateEmployeeLoyaltyPoints(); // начисление баллов лояльности для каждого сотрудника
    }
    
    public interface IEmployee
    {
        int CalculateLoyaltyPoints();
    }
    
    public class Employee : IEmployee
    {
        private int years;
    
        public Employee(int years)
        {
            this.years = years;
        }
    
        public int CalculateLoyaltyPoints()
        {
            if (years == 1)
            {
                return 10;
            }
            else if (years == 2)
            {
                return 20;
            }
            else if (years >= 3)
            {
                return 50;
            }
            else
            {
                return 0;
            }
        }
    }
    
    //реализация компоновщика
    public class LoyaltyProgram
    {
        private List<IEmployee> employees = new List<IEmployee>();
    
        public void AddEmployee(IEmployee employee)
        {
            employees.Add(employee);
        }
    
        public void CalculateEmployeeLoyaltyPoints()
        {
            foreach (var employee in employees)
            {
                int points = employee.CalculateLoyaltyPoints();
                Console.WriteLine("Employee loyalty points: " + points);
            }
        }
    }
}
