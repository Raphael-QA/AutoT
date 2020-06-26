using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoT
{
    class LoginPage
    {
        private IWebDriver _driver;
        private  By _newemailInput = By.Id("email_create");
        private  By _newemailClicl = By.XPath("//*[@id='SubmitCreate']");
        private  By _emailInput = By.Id("email");
        private  By _passwordInput = By.Id("passwd");
        private  By _LoginButton = By.Id("SubmitLogin");
        private  By _AlertLabel = By.XPath("//div[@id='center_column']/div[@class='alert alert-danger']");

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            if (_driver.FindElements(By.ClassName("page-heading")).Count != 1)
            {
                throw new InvalidOperationException("This is not Login Page area");
            }
        }
        public LoginPage EnterNewEmail(string email)
        {
            _driver.FindElement(_newemailInput).SendKeys(email);
            return this;
        }
        public LoginPage NewEmailClick()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            IWebElement link1 = wait.Until(ExpectedConditions.ElementExists(_newemailClicl));
            link1.Click();
            return new LoginPage(_driver);
        }
        private LoginPage EnterEmail(string email)
        {
            _driver.FindElement(_emailInput).SendKeys(email);
            return this;
        }
        private LoginPage EnterPasswor(string psw)
        {
            _driver.FindElement(_passwordInput).SendKeys(psw);
            return this;
        }
        private void SignInClick()
        {
            _driver.FindElement(_LoginButton).Click();
            
        }
        public PersonalAccaunt LogINCorrect(string email, string psw)
        {
            EnterEmail(email);
            EnterPasswor(psw);
            SignInClick();
            return new PersonalAccaunt(_driver);
        }
        public LoginPage LogINUnCorrect(string email, string psw)
        {
            EnterEmail(email);
            EnterPasswor(psw);
            SignInClick();
            if(_driver.FindElements(_AlertLabel).Count != 1)
            {
                throw new InvalidOperationException("Not find Alert Label");
            }
            return this;
        }

    }
}
