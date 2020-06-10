using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSpecFlowFrameWork.Utilities
{
    class Utils
    {
        public static Dictionary<string, string> LoadData(string fname)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            var report = File.ReadAllLines(fname);
            foreach (string line in report)
            {
                string[] keyvalue = line.Split('=');
                if (keyvalue.Length == 2)
                {
                    result.Add(keyvalue[0].Trim(), keyvalue[1].Trim());
                }
            }
            return result;
        }

        public static string GetRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max).ToString();
        }

    }
}
