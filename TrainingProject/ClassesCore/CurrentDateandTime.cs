using System;

namespace TrainingProject.ClassesCore
{
    public class CurrentDateandTime
    {
        public static string currentDateTime()
        {
            //DateTime now = DateTime.Now;
            //DateTime utc = DateTime.UtcNow;

            //Console.WriteLine($"UTC time {utc:HH:mm:ss}");
            //Console.WriteLine($"Local time {now:HH:mm:ss}");

            //string assignment = DateTime.Now.ToString("ddMMyyyy HHmmss");
            return DateTime.Now.ToString("ddMMyyyy HHmmss");
            // Console.WriteLine(DateTime.Now.ToString("ddMMyyyy HHmmss"));
        }

        public static DateTime randomDate()
        {


            return DateTime.Now.AddDays(new Random().Next(30)); //.ToString("dd/MM/yyyy");


            // int seed = (int)DateTime.Now.Ticks;            
            // int days = seed % 30;
            // return (DateTime.Now.AddDays(days).ToString("dd/MM/yyyy"));
            
        }
    }
}
