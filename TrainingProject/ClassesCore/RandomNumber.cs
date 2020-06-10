using System;

namespace TrainingProject.ClassesCore
{
    class RandomNumber
    {
        public static int randomNumber()
        {
            Random rnd = new Random();
            // int month = rnd.Next(1, 13);  // creates a number between 1 and 12
            // int dice = rnd.Next(1, 7);   // creates a number between 1 and 6
            int number = rnd.Next(10);     // creates a number between 0 and 51
            return number;

        }

        public static void random4DigitNumber()
        {
            Console.WriteLine(new Random().Next(1000, 9999));
        }

        public static string random10DigitNumber(int length)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
            {
                s = String.Concat(s, random.Next(10).ToString());
            }

            return s;
        }
    }
}
