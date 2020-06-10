using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.ClassesCore
{
    public class DictionaryDemo
    {
        public static void Demo()
        {
            Dictionary<string, int> d = new Dictionary<string, int>();

            d.Add("soccer", 1);
            d.Add("cricket", 2);
            d.Add("tennis", 3);
            d.Add("rugby", 4);

            // get keys
            var val = d.Keys.ToList();

            // sort
            val.Sort();

            // displaying sorted keys
            foreach (var key in val)
            {
                Console.WriteLine(key);
            }

        }

    }
}
