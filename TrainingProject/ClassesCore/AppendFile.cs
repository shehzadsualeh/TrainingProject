using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.ClassesCore
{
    public class AppendFile
    {
        public static void appendFile(string text)
        {
           File.AppendAllText(@"C:\Users\ShehzadAli\Desktop\Name.txt", Environment.NewLine + text);
        }
    }
}
