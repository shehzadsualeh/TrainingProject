using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.ClassesCore
{
    public class Parrot : IBird
    {
        public void Eat()
        {
            Console.WriteLine("Parrot eats Tomatoes");
        }

        public void Fly()
        {
            Console.WriteLine("Parrot fly 5M High");
        }
    }
}
