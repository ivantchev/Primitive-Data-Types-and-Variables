using System;

    class ExchangeVariablesValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before conversion: ");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

            int oldA = a;
            a = b;
            b = oldA;
            Console.WriteLine("\nAfter conversion: ");
            Console.WriteLine("a = {0}",a);
            Console.WriteLine("b = {0}", b);
        }
    }

