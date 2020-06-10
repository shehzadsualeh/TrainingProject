using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TrainingProject.ClassesCore
{
    class CurrentWorkingDirectory
    {
        public static void currentWorkingDirectory()
        {
            string text = Directory.GetCurrentDirectory();
            Console.WriteLine(text);
        }

    }
}
