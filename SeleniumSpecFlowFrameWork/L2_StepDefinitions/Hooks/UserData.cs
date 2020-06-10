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
    class UserData
    {
        public static Dictionary<string, string> UserDataInfo;
        
        [BeforeTestRun]
        public static void LoadUserData()
        {
            string fname = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/../../Environment/NewUser.txt";
            UserDataInfo = Utils.LoadData(fname);
        }
    }
}
