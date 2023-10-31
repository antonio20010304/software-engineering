//Математические операции
// Анализатор операций
// Список операций – любая реализация
// Метод «Решить операции в списке» - вызывает метод «Найти решение» у каждого из выражений в списке
// Операция сложения (2 параметра)
// Метод «Найти решение»
// Операция умножения (2 параметра)
// Метод «Найти решение»


internal abstract partial class Program
{
    static void Main(string[] args)
    {
        var Operations = new OpsAnalysis<IAnswer>();
        Addition addition = new Addition();
        Multiply multiply = new Multiply();
        Operations.Ops.Add(addition);
        Operations.Ops.Add(multiply);
        Operations.CountOperations(2,4);
        
    }



    public class OpsAnalysis<T> where T : IAnswer
    {
        public List<T> Ops = new List<T>();

        public void CountOperations(int a, int b)
        {
            foreach (var Op in Ops)
            { 
                Console.WriteLine(Op.ChooseAnswer(a, b));
            }   
        }
    }


    public class Addition : IAnswer
    {
       public int ChooseAnswer(int a, int b)
        {
            return a + b;
        }

    }

    public class Multiply : IAnswer
    {
        public int ChooseAnswer(int a, int b)
        {
            return a * b;
        }
        
    }

    public interface IAnswer
    {
        int ChooseAnswer(int a, int b);
    }
}
