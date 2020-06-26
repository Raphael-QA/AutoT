using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoT
{
    class CreateAcc
    {
        private IWebDriver _driver;
        
        By _loginLink = By.ClassName("login");
        private By _gender = By.Id("id_gender1");
        private By _firstname = By.Id("customer_firstname");
        private By _lastname = By.Id("customer_lastname");
        private By _passwd = By.Id("passwd");
        private By _days = By.Id("days");
        private By _months = By.Id("months");
        private By _years = By.Id("years");
        private By _company = By.Id("company");
        private By _address = By.Id("address1");
        private By _city = By.Id("city");
        private By _state = By.Id("id_state");
        private By _postcode = By.Id("postcode");
        private By _other = By.Id("other");
        private By _phone = By.Id("phone");
        private By _phone_mobile = By.Id("phone_mobile");
        private By _alias = By.Id("alias");
        private By _submitAccount = By.Id("submitAccount");
   

        public CreateAcc(IWebDriver driver)
        {
            _driver = driver;
            //if (_driver.Url != "http://automationpractice.com/index.php")
            //{
            //    throw new InvalidOperationException("This is not");
            //}

        }
        public CreateAcc LoginBattonClick()
        {
            _driver.FindElement(_loginLink).Click();
            return new CreateAcc(_driver);
        }
     
        public PersonalAccaunt CreateNamPas()
        {
            
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement link2 = wait.Until(ExpectedConditions.ElementExists(By.Id("id_gender2")));
            link2.Click();
            _driver.FindElement(_gender).Click();
            _driver.FindElement(_firstname).SendKeys("Donald");
            _driver.FindElement(_lastname).SendKeys("Duck");
            _driver.FindElement(_passwd).SendKeys("DD666");

            IWebElement selectDay = _driver.FindElement(_days);
            SelectElement selectD = new SelectElement(selectDay);
            selectD.SelectByValue("13");
            IWebElement selectMonth = _driver.FindElement(_months);
            SelectElement selectM = new SelectElement(selectMonth);
            selectM.SelectByValue("6");
            IWebElement selectYear = _driver.FindElement(_years);
            SelectElement selectY = new SelectElement(selectYear);            
            selectY.SelectByValue("1966");


            _driver.FindElement(_company).SendKeys("Umbrella");
            _driver.FindElement(_address).SendKeys("1125 16th Street, NW, Washington D.C.");
            _driver.FindElement(_city).SendKeys("Hell");

            IWebElement selectState = _driver.FindElement(_state);
            SelectElement selectST = new SelectElement(selectState);  
            selectST.SelectByValue("43");

            _driver.FindElement(_postcode).SendKeys("66666");
            _driver.FindElement(_other).SendKeys("la la la la la la la la la la la ola la la la la la la o la la la ");
         
            _driver.FindElement(_phone).SendKeys("+(666) 666 666");
            _driver.FindElement(_phone_mobile).SendKeys("+(6) 666 666 66 66");

            _driver.FindElement(_alias).Clear();
            _driver.FindElement(_alias).SendKeys("SatanDuck");
            _driver.FindElement(_submitAccount).Click();
            return new PersonalAccaunt(_driver);
        }
   
    }
}
