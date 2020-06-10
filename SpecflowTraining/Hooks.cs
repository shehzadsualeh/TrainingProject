using System;
using TechTalk.SpecFlow;

namespace SpecFlowTraining.StepDefinitions
{
    [Binding]
    public class Hooks
    {

        [BeforeScenario(Order = 20)]
        public void OpenBrowser()
        {
            Console.WriteLine("Open browser");

        }


        [BeforeScenario("@datadriven")]
        public void loadData()
        {
            Console.WriteLine("should only load data for data driven");

        }


        [BeforeScenario("@john", Order = 10)]
        public void loadjohnsdata()
        {
            Console.WriteLine("load johns data");
        }

        [AfterScenario]
        public void TearDown()
        {
            Console.WriteLine("Close browser");
        }

        [AfterStep]
        public void Afterstep()
        {
            Console.WriteLine("take screenshot of this step");
        }

        [BeforeStep]
        public void beforestep()
        {
            Console.WriteLine("this is before step **** Logic...");
        }

    }
}
