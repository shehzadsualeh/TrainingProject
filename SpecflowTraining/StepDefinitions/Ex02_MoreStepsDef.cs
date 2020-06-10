using System;
using TechTalk.SpecFlow;

namespace SpecFlowTraining.StepDefinitions
{
    [Binding]
    public class Ex02_MoreStepsDef
    {
        [Given(@"I click on Forget Password")]
        public void GivenIClickOnForgetPassword()
        {
            Console.WriteLine("Click on forget password");
        }

        [When(@"I enter my Email")]
        public void WhenIEnterMyEmail()
        {
            Console.WriteLine("Enter email");
        }

        [When(@"I click Submit")]
        public void WhenIClickSubmit()
        {
            Console.WriteLine("I click submit");
        }

        [Then(@"I should get an email")]
        [Then(@"I should receive an email")]
        public void ThenIShouldGetAnEmail_()
        {
            Console.WriteLine("I get email.");
        }

        //https://regexone.com/
        [Then(@"I add (\d+) items? in the cart")] // ?is used for optional
                                                  // [Then(@"I add (\d+) items? in the cart")]
                                                  //  [Then(@"I add (.*) items in the cart")]
        public void ThenIAddItemsInTheCart(int num)
        {
            Console.WriteLine("The added items are " + num);
        }

        // [Then(@"I Select from (.*) section")]
        [Then(@"I Select from (Mens|Womens|Kids) section")]

        public void ThenISelectFromMensSection(string catName)
        {
            Console.WriteLine("Selected category : " + catName);
        }

        [Then(@"I select the size '(.*)'")]
        public void ThenISelectTheSize(string size)
        {
            Console.WriteLine("size selected " + size);
        }


        [Then(@"This is a sample doc string")]
        public void ThenThisIsASampleDocString(string multilineText)
        {
            Console.WriteLine("validate" + multilineText);
        }


        [Then(@"I choose the following and add to the basket")]
        public void ThenIChooseTheFollowingAndAddToTheBasket(Table table)
        {

            Console.WriteLine(table.Rows[0][0]); //hard coded
            Console.WriteLine(table.Rows[0][1]);
            Console.WriteLine(table.Rows[0][2]);
            //logic to handle the details...

            Console.WriteLine(table.Rows[1][0]); //hard coded
            Console.WriteLine(table.Rows[1][1]);
            Console.WriteLine(table.Rows[1][2]);

            Console.WriteLine(table.Rows[2][0]); //hard coded
            Console.WriteLine(table.Rows[2][1]);
            Console.WriteLine(table.Rows[2][2]);


            Console.WriteLine("This is the dtynamic way ....");
            for (int i = 0; i < table.RowCount; i++)
            {
                var itemCode = table.Rows[i][0];
                //Console.WriteLine(itemCode);

                var itemName = table.Rows[i][1];
                //Console.WriteLine(itemName);

                var quantity = table.Rows[i][2];
                //Console.WriteLine(quantity);

                // Logic to search the item withname/code then add the qty
                AddItem(itemName, quantity);

            }



        }

        public void AddItem(string itemname, string qty)
        {
            Console.WriteLine("you are on PDP page");
            Console.WriteLine("Click on the item with name " + itemname);
            Console.WriteLine("Add Qty " + qty);
            Console.WriteLine("Click on basket");

        }

        [Then(@"I choose '(.*)' with qauntity (.*) and add to basket")]
        public void ThenIChooseWithQauntityAndAddToBasket(string p0, int p1)
        {
            Console.WriteLine("you are on PDP page");
            Console.WriteLine("Click on the item with name " + p0);
            Console.WriteLine("Add Qty " + p1);
            Console.WriteLine("Click on basket");

        }


    }
}