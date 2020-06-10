using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.ClassesCore
{
    public class Triangle : Shape
    {
        public override void area(int d1, int d2)
        {
            double a = 0.5 * d1 * d2;
            Console.WriteLine("This is the area of a triangle" + a);            
        }
    }
}
