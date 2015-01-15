using System;

    class PrintTheASCIITable
    {
        static void Main()
        {
            for (int i = 0; i < 256; i++)
            {
                char symbol = (char)i;
                Console.Write(symbol + "  ");
            }

        }
    }

