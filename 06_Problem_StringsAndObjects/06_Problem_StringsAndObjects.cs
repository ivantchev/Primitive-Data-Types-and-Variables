using System;

    class StringAndObjects
    {
        static void Main()
        {
            string a = "Hello";
            string b = "World";
            object sumAB = (a +" "+ b);
            string c = (string)sumAB;
            Console.WriteLine(c);
        }
    }

