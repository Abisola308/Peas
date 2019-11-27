using System;
using TechTalk.SpecFlow;
using Insurance.Pages;
using Insurance.Hooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Insurance.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        private RegistrationPage registrationPage;
        private Context context;

        public RegistrationSteps(RegistrationPage _registrationPage, Context _context)
        {
            registrationPage = _registrationPage;
            context = _context;
        }

        [Given(@"that Giftrete is up and running")]
        public void GivenThatGiftreteIsUpAndRunning()
        {
            context.LunchAnApplication();
        }
        
        [Given(@"a user clicks on sign in link")]
        public void GivenAUserClicksOnSignInLink()
        {
            registrationPage.ClickSignInLink();
        }

        [When(@"a user clicks on sign in tab")]
        public void WhenAUserClicksOnSignInTab()
        {
            registrationPage.ClickSignTab();
        }


        [When(@"a user enters an emailAddress with (.*)")]
        public void WhenAUserEntersAnEmailAddressWithBisolaogunnaikeYahoo_Com(string emailAddress)
        {
            registrationPage.EnterEmailAddress(emailAddress);
        }
        
        [When(@"a user enters passWord in the password field with (.*)")]
        public void WhenAUserEntersPassWordInThePasswordFieldWithNigeria(string passWord)
        {
            registrationPage.EnterPassWord(passWord);
        }
        
        [When(@"a user clicks on sign in button")]
        public void WhenAUserClicksOnSignInButton()
        {
            registrationPage.ClickSignInButton();
        }
        
        [Then(@"(.*) should be registerd successfully")]
        public void ThenAUserShouldBeRegisterdSuccessfully(string expectedUsername)
        {
            string actualUsername = registrationPage.VerifyLoginName();
            Assert.IsTrue(actualUsername.Contains(expectedUsername));
        }

        [AfterScenario]
        public void CloseApplication()
        {
            context.CloseAnApplication();
        }
    }
}
