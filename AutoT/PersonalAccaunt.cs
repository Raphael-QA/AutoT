using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoT
{
    class PersonalAccaunt
    {
        private IWebDriver _driver;

        public PersonalAccaunt(IWebDriver driver)
        {
            _driver = driver;
            //if (_driver.FindElements(By.XPath("//h1[text() = 'My account']")).Count != 1)
            //{
            //    throw new InvalidOperationException("This is not My Account");
            //}
        }
        public LoginPage Out()
        {
            _driver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[2]/a")).Click();
            return new LoginPage(_driver);
        }
        public bool CheckLable()
        {
            if (_driver.FindElements(By.XPath("//h1[text() = 'My account']")).Count != 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
