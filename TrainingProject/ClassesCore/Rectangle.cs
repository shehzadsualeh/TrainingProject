using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.ClassesCore
{
    public class Rectangle : Shape
    {
        public override void area(int d1, int d2)
        {
            int a = d1 * d2;
            Console.WriteLine("The area of Rectangle is : " +a);
        }
    }
}
