using System;

namespace TrainingProject.ClassesCore
{
    public class ExceptionDemo
    {
        public static void EDemo()

        {
            string[] weekdays = new string[] { "MON", "TUE", "WED", "THU", "FRI" };

            try
            {
                Console.WriteLine(weekdays[0]);
                Console.WriteLine("Line after exception");
            }

            catch (Exception e)
            {
                Console.WriteLine("inside catch block");
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("This code is executed no matter the exception is thrown or not");
            }
        }
    }
}
