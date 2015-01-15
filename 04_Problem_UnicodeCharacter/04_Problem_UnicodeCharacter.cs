using System;

    class UnicodeCharacter
    {
        static void Main()
        {
            char a= '\u002A';
            Console.WriteLine(@"
            {0}

          {0}   {0} 

         {0}     {0}

         {0} {0} {0} {0}",a);
        }
    }

