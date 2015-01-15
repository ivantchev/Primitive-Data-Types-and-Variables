using System;

    class ComparingFloats
    {
        static void Main()
        {
            Console.WriteLine("Enter the first floating number: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second floating number: ");
            double b = double.Parse(Console.ReadLine());

            double difference = Math.Abs(a - b);
            double eps = 0.000001;
            if (difference>eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }

