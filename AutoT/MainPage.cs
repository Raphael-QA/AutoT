using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoT
{
    class MainPage
    {
       private IWebDriver _driver;
        By _loginLink = By.ClassName("login");
        public MainPage(IWebDriver driver)
        {
            _driver = driver;
            if(_driver.Url != "http://automationpractice.com/index.php")
            {
                throw new InvalidOperationException("This is not");
            }
        }
        public LoginPage LoginBattonClick()
        {
            _driver.FindElement(_loginLink).Click();
            return new LoginPage(_driver);
        }
    }
}
