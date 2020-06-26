using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoT
{
    class Program
    {
        static void Main(string[] args)
        {





















            


            IWebDriver driver = new ChromeDriver();
        
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            driver.FindElement(By.Id("email_create")).SendKeys("qsqsqsq@aas.as");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement linkToHF2 = wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='SubmitCreate']")));
            linkToHF2.Click();
            driver.FindElement( By.XPath("//*[@id='SubmitCreate']"));
            driver.FindElement(By.Id("SubmitCreate"));

            IWebElement linkToHF3 = wait.Until(ExpectedConditions.ElementExists(By.Id("id_gender2")));
            linkToHF3.Click();

            driver.FindElement(By.Id("customer_firstname")).SendKeys("qqaqwasdcsdfas");




            //Console.WriteLine("_____________");
            // Console.WriteLine(driver.Manage().Timeouts().PageLoad);
            // Console.WriteLine("_____________");
            // driver.Manage().Window.Maximize();
            // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            // //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            // driver.Navigate().GoToUrl("https://www.igromania.ru/");
            // driver.FindElement(By.XPath("//a[text() = 'Игры' and @class = 'hmenu']")).Click();
            // IWebElement linkToHF2 = wait.Until(ExpectedConditions.ElementExists(By.XPath("//a[@href= '/game/1986/Half-Life_2.html' and @style]")));
            // linkToHF2.Click();
            //// driver.FindElement(By.XPath("//a[@href= '/game/1986/Half-Life_2.html' and @style]")).Click();
        }
    }
}
