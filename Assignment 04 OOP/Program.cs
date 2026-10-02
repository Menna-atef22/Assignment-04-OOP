namespace Assignment_04_OOP
{
    public class Program
    {

        //Task 3:Three ways to validate input: TryParse, Parse (try/catch), Convert (try/catch)
        static int ReadWithTryParse(string label)
        {
            int value;
            Console.Write($"{label} (TryParse): ");
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write($"{label} (TryParse): ");
            }
            return value;
        }


        static int ReadWithParse(string label)
        {
            while (true)
            {
                Console.Write($"{label} (Parse): ");
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Input cannot be null.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Input is out of range. Please enter a valid integer.");
                }
            }
        }

        static int ReadWithConvert(string label)
        {
            while (true)
            {
                Console.Write($"{label} (Convert): ");
                try { return Convert.ToInt32(Console.ReadLine()); }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Input is out of range. Please enter a valid integer.");
                }
            }
        }


        static void Main(string[] args)
        {

            //Task 2
            Point3D P = new Point3D(10, 10, 10);
            Console.WriteLine(P.ToString());

            //Task 3 
            Console.WriteLine("\n--- Enter coordinates for P1 ---");
            Point3D P1 = new Point3D(ReadWithTryParse("X"), ReadWithParse("Y"), ReadWithConvert("Z"));
            Console.WriteLine("\n--- Enter coordinates for P2 ---");
            Point3D P2 = new Point3D(ReadWithTryParse("X"), ReadWithParse("Y"), ReadWithConvert("Z"));

            Console.WriteLine("\nP1 -> " + P1);
            Console.WriteLine("P2 -> " + P2);


            //Task 4
            // == compares references by default, so P1 and P2 are false even if their coordinates are identical.
            Console.WriteLine("\n P1==P2: " + (P1 == P2));


            //Task 5 

            Point3D[] points =
            {
                new Point3D(3, 2, 1),
                new Point3D(1, 5, 4),
                new Point3D(2, 3, 6),
                new Point3D(4, 1, 5),
                P1,P2
            };

            Console.WriteLine("\n--- Points before sorting ---");
            foreach (Point3D p in points)
            {
                Console.WriteLine(p);
            }

            Array.Sort(points);

            Console.WriteLine("\n--- Points after sorting ---");
            foreach (Point3D p in points)
            {
                Console.WriteLine(p);
            }


            //Task 6
            Point3D copy = (Point3D)P1.Clone();
            Console.WriteLine("\n P1:   " + P1);
            Console.WriteLine("Copy: " + copy);

        }

    }
}
