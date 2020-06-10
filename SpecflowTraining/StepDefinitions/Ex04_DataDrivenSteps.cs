using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowTraining.StepDefinitions
{
    [Binding]
    public class Ex04_DataDrivenSteps
    {
        int initial, noOfitems, total;

        [Given(@"I have (.*) items in the cart")]
        public void GivenIHaveItemsInTheCart(int initialvaluefromstep)
        {
            initial = initialvaluefromstep;
        }

        [When(@"I add (.*) items in the cart")]
        public void WhenIAddItemsInTheCart(int noofitemsfromstep)
        {
            noOfitems = noofitemsfromstep;
        }

        [Then(@"I have (.*) items in the cart")]
        public void ThenIHaveItemsInTheCart(int totalfromstep)
        {
            total = initial + noOfitems;
            Assert.AreEqual(totalfromstep, total);

        }
    }
}
