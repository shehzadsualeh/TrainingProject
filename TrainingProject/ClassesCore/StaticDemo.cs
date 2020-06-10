using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.ClassesCore
{
    public class StaticDemo
    {
        public static int i = 10;
        public int j = 10;

        public static void SMethod()
        {
            Console.WriteLine("This is a static method");
        }

        public void NSDemo()
        {
            i = 1000;
            SMethod();
        }

    }
}
