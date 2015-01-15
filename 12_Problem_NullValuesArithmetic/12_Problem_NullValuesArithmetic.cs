using System;

    class NullValuesArithmetic
    {
        static void Main()
        {
            int? a = null;
            double? b = null;
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 10;
            b = 12.5;
            Console.WriteLine("New Value(integer): {0}", a);
            Console.WriteLine("New Value(double): {0}", b);
        }
    }

