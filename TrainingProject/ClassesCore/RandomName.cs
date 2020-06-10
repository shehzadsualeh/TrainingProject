using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.ClassesCore
{
    class RandomName
    {
        public static string randomName()
        {
            var names = new List<string> { "Shehzad", "Faizan", "Raheem", "Neaz", "A", "B", "C" };
            var random = new Random();
            int number = random.Next(names.Count);
            var firstItem = names.ElementAt(number);
            return firstItem;           
        }
    }
}
