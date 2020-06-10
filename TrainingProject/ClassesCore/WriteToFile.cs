using System;
using System.IO;

namespace TrainingProject.ClassesCore
{
    class WriteToFile
    {
        public static void writeToFile()
        {
            string path = @"C:\Users\ShehzadAli\Desktop\Name.txt";

            string text = "My name is Shehzad";
            File.WriteAllText(path, text);

            Console.WriteLine("text written");
        }
    }
}
