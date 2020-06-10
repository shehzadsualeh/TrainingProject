using SeleniumSpecFlowFrameWork.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumSpecFlowFrameWork.L2_StepDefinitions.Hooks
{
    [Binding]
    class DataHooks
    {
        public static Dictionary<string, string> EnvData;
        
        [BeforeTestRun]
        public static void LoadEnvironmentData()
        {
            // string fpath = @"C:\Users\ABRAKH\source\repos\TrainingProject\SeleniumSpecFlowFrameWork\Environment\TestStaging.txt";
            string fname = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/../../Environment/TestStaging.txt";
            EnvData = Utils.LoadData(fname);
        }
  
    }
}
