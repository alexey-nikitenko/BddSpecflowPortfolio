using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowNetCore.Drivers;
using SpecflowNetCore.Pages;
using TechTalk.SpecFlow;

namespace SpecflowNetCore
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly LoginPage loginPage;
        private readonly HomePage homePage;
        public LoginStepDefinitions(BrowserDriver browserDriver)
        {
            homePage = new HomePage(browserDriver.Current);
            loginPage = new LoginPage(browserDriver.Current);
        }

        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            
            homePage.GoToHomePage();
        }

        [Given(@"I click login link")]
        public void GivenIClickLoginLink()
        {
            homePage.ClickLogin();
        }

        [Given(@"I enter the following details")]
        public void GivenIEnterTheFollowingDetails(Table table)
        {
            dynamic data = table.Rows[0];
            
            loginPage.Login((string)data["UserName"], (string)data["Password"]);
        }

        [Given(@"I click login button")]
        public void GivenIClickLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then(@"I should see Employee details link")]
        public void ThenIShouldSeeEmployeeDetailsLink()
        {
            Assert.That(loginPage.IsEmployeeDetailsExist, Is.True);
        }
    }
}
