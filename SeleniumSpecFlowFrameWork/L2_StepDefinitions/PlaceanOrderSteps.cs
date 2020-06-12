using NUnit.Framework;
using SeleniumSpecFlowFrameWork.Global;
using SeleniumSpecFlowFrameWork.L3_SeleniumCode;
using TechTalk.SpecFlow;

namespace SeleniumSpecFlowFrameWork.L2_StepDefinitions
{
    [Binding]
    class PlaceanOrderSteps
    {
        ShareStateObjects sso;
        public PlaceanOrderSteps(ShareStateObjects _sso)
        {
            sso = _sso;
        }

        [Given(@"The user adds the following to the cart")]
        public void GivenTheUserAddsTheFollowingToTheCart(Table table)
        {
            for (int i = 0; i < table.RowCount; i++)
            {
                var item = table.Rows[i][0];
                var quantity = table.Rows[i][1];
                SearchPage searchPage = new SearchPage(sso);
                searchPage.AddProduct(item, quantity);
            }
        }

        [Given(@"The user navigates to shopping cart summary page")]
        public void GivenTheUserNavigatesToShoppingCartSummaryPage()
        {
            new SearchPage(sso).CartPage();
        }

        [Given(@"The user proceeds to check out on shopping cart summary page")]
        public void GivenTheUserProceedsToCheckOutOnShoppingCartSummaryPage()
        {
            new SearchPage(sso).ProceedtoCheckout();
        }

        [Given(@"The user proceeds to check out on addresses page")]
        public void GivenTheUserProceedsToCheckOutOnAddressesPage()
        {
            new SearchPage(sso).AddressPage();
        }

        [Given(@"The user agress to T and Cs")]
        public void GivenTheUserAgressToTAndCs()
        {
            new SearchPage(sso).TermsCheckbox();
        }

        [Given(@"The user proceeds to check out on shipping page")]
        public void GivenTheUserProceedsToCheckOutOnShippingPage()
        {
            new SearchPage(sso).ProcessCarrier();
        }

        [Given(@"The user selects payment method as pay by cheque")]
        public void GivenTheUserSelectsPaymentMethodAsPayByCheque()
        {
            new SearchPage(sso).PaymentMethod();
        }

        [When(@"The user confirms the order on order summary page")]
        public void WhenTheUserConfirmsTheOrderOnOrderSummaryPage()
        {
            new SearchPage(sso).ConfirmOrder();
        }

        [Then(@"The user should get a message '(.*)'")]
        public void ThenTheUserShouldGetAMessage(string p0)
        {
            var message = new SearchPage(sso).Confirmation();
            Assert.AreEqual(p0, message);
        }


    }
}

