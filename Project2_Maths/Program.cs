namespace Project2_Maths
{
    public class Program
    {
        static void Main(string[] args)
        {
            double a = 5;
            double b = 3;

            Console.WriteLine($"Welcome to the Maths Program!");
            Console.WriteLine($"Addition: {Maths.Add(a, b)}");
            Console.WriteLine($"Subtraction: {Maths.Subtract(a, b)}");
            Console.WriteLine($"Multiplication: {Maths.Multiply(a, b)}");
            Console.WriteLine($"Division: {Maths.Divide(a, b)}");


        }
    }
}
