public class Program{ 
    public static void Main()
{
    Employee employee1 = new Employee { Name = "Ivan Zorin", ID = "123456" };
    Employee employee2 = new Employee { Name = "Sergey Isakov", ID = "789012" };

    Student student1 = new Student { Name = "Anton Zaychenko", ID = "00123" };
    Student student2 = new Student { Name = "Vladimir Susov", ID = "00456" };

    University[] people = { employee1, employee2, student1, student2 };

    var typepips = people.GroupBy(p => p.GetType().Name);

    foreach (var group in typepips)
    {
        Console.WriteLine($"Number of {group.Key}s: {group.Count()}");
    }
}
}
public abstract class University
{
    public string? Name { get; set; }
    public string? ID { get; set; }
}

public class Employee : University{}

public class Student : University{}






