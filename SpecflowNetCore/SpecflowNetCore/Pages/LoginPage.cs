using OpenQA.Selenium;

namespace SpecflowNetCore.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _webDriver;

        public LoginPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }


        public IWebElement TxtUserName => _webDriver.FindElement(By.Name("UserName"));
        public IWebElement TxtPassword => _webDriver.FindElement(By.Name("Password"));
        public IWebElement BtnLogin => _webDriver.FindElement(By.CssSelector("btn btn-default"));
        public IWebElement LnkEmloyeeDetails => _webDriver.FindElement(By.CssSelector("btn btn-default"));


        
        public void Login(string userName, string password)
        {
            TxtUserName.SendKeys(userName);
            TxtPassword.SendKeys(password);
        }

        public bool IsEmployeeDetailsExist() => LnkEmloyeeDetails.Displayed;


    }
}
