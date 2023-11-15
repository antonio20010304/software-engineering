public class MyException : Exception
{
    public MyException(string message): base(message)
    {
        
    }
}

public class Trygon
{
    public Trygon(double a,double b,double c)
    {
        if (a > b + c || b > a + c || c > a + b)
        {
            throw new MyException("THIS IS NOT A TRYGON");
        }
        else
        {
            Console.WriteLine($"Perimeter equals {a+b+c}");
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
         double a = Convert.ToDouble(Console.ReadLine());
         double b = Convert.ToDouble(Console.ReadLine());
         double c = Convert.ToDouble(Console.ReadLine());
         try
         {
             Trygon trygon1 = new Trygon(a, b, c);
         }
         catch
         {
             Console.WriteLine("THIS IS NOT A TRYGON");
         }
         finally
         {
             Console.WriteLine("Работа закончена");
         }
    }
    
}
