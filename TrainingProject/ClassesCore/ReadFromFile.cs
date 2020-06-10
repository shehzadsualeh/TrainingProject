using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.ClassesCore
{
    class ReadFromFile
    {

        public static void readFromFile()
        {
            // The files used in this example are created in the topic
            // How to: Write to a Text File. You can change the path and
            // file name to substitute text files of your own.

            // Example #1
            // Read the file as one string.
            string text = System.IO.File.ReadAllText(@"C:\Users\ShehzadAli\Desktop\Name.txt");

            // Display the file contents to the console. Variable text is a string.
            System.Console.WriteLine(text);

            // Keep the console window open in debug mode.
            // Console.WriteLine("Press any key to exit.");
            // System.Console.ReadKey();            
        }      
    }
}