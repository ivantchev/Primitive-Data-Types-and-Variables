using System;

    class BooleanVariable
    {
        static void Main()
        {
            var random = new Random();
            int convert= random.Next(0,2);
            bool isFemale;
            if (convert == 0)
            {
                isFemale = false;
            }
            else
            {

                isFemale = true;
            }

            Console.WriteLine("Am I a female? : {0}",isFemale.ToString());
            Console.ReadLine();
        }
    }

