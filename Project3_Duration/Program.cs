namespace Project3_Duration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());      

            D1 = new Duration(3600);
            Console.WriteLine(D1.ToString());     

            Duration D2 = new Duration(7800);
            Console.WriteLine(D2.ToString());     

            Duration D3 = new Duration(666);
            Console.WriteLine(D3.ToString());


            Console.WriteLine("\n--- Equals / GetHashCode ---");
            Duration A = new Duration(0, 11, 6);
            Console.WriteLine("A.Equals(D3): " + A.Equals(D3));
            Console.WriteLine("Same hash code: " + (A.GetHashCode() == D3.GetHashCode()));

            // operator overloading
            D1 = new Duration(3600);    // 1h
            D2 = new Duration(7800);    // 2h 10m

            D3 = D1 + D2;
            Console.WriteLine(D3);

            D3 = D1 + 7800;
            Console.WriteLine(D3);

            D3 = 666 + D3;
            Console.WriteLine(D3);

            D3 = ++D1;
            Console.WriteLine(D3);

            D3 = --D2;
            Console.WriteLine(D3);

            D1 = D1 - D2;
            Console.WriteLine(D1);

            D1 = new Duration(3600);    
            D2 = new Duration(7800);

            if (D1 > D2) Console.WriteLine("D1 > D2");
            if (D1 <= D2) Console.WriteLine("D1 <= D2");
            if (D1) Console.WriteLine("D1 is not zero");

            DateTime Obj = (DateTime)D1;
            Console.WriteLine(Obj);

            Console.ReadKey();
        }
    }
}
    }
}
