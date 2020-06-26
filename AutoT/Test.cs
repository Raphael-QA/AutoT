using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoT
{
    [TestFixture]
    class Test
    {
        IWebDriver driver;
        string newemail;
        string email;
        string psw;
        string url;
        string url2;
        string falseemail;
        string falsepsw;

        [SetUp]
        public void OneTimeSetUp()
        {
            falseemail = "lololras@mail.com";
            falsepsw = "lololras";
            newemail = "asdasd@asd.as";   //Нужно поменять =(
            email = "f32cvbbvc3@qqwqw.qw";
            psw = "DD666";
            url = "http://automationpractice.com/index.php";
            url2 = "http://automationpractice.com/index.php?controller=authentication&back=my-account";
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
        }


        [Test]
        public void CheckCorrectLigin()
        {
            
            driver.Navigate().GoToUrl(url);
            MainPage mainPage = new MainPage(driver);
            CreateAcc createAcc = new CreateAcc(driver);
            
            LoginPage loginPage = mainPage.LoginBattonClick();

            loginPage.EnterNewEmail(newemail); //1

            loginPage.NewEmailClick();         //2
       
                //3

            PersonalAccaunt personal = createAcc.CreateNamPas();

            loginPage =  personal.Out();

            personal = loginPage.LogINCorrect(email, psw);
            Assert.IsTrue(personal.CheckLable());
            driver.Quit();
        }
        [Test]
        public void Check()
        {
            driver.Navigate().GoToUrl(url2);
            LoginPage loginPage = new LoginPage(driver);
            PersonalAccaunt personal = new PersonalAccaunt(driver);
            loginPage.LogINCorrect(email, psw);
            Assert.IsTrue(personal.CheckLable());
            driver.Quit();
        }
        [Test]
        public void CheckFalse()
        {
            driver.Navigate().GoToUrl(url2);
            LoginPage loginPage = new LoginPage(driver);
            PersonalAccaunt personal = new PersonalAccaunt(driver);
            loginPage.LogINCorrect(falseemail, falsepsw);
            Assert.IsFalse(personal.CheckLable());
            driver.Quit();
        }
        [Test]
        public void CheckFalseMail()
        {
            driver.Navigate().GoToUrl(url2);
            LoginPage loginPage = new LoginPage(driver);
            PersonalAccaunt personal = new PersonalAccaunt(driver);
            loginPage.LogINCorrect(falseemail, psw);
            Assert.IsFalse(personal.CheckLable());
            driver.Quit();
        }
        [Test]
        public void CheckFalsePsw()
        {
            driver.Navigate().GoToUrl(url2);
            LoginPage loginPage = new LoginPage(driver);
            PersonalAccaunt personal = new PersonalAccaunt(driver);
            loginPage.LogINCorrect(email, falsepsw);
            Assert.IsFalse(personal.CheckLable());
            driver.Quit();
        }
        [Test]
        public void CheckEmpty()
        {
            driver.Navigate().GoToUrl(url2);
            LoginPage loginPage = new LoginPage(driver);
            PersonalAccaunt personal = new PersonalAccaunt(driver);
            loginPage.LogINCorrect(" ", " ");
            Assert.IsFalse(personal.CheckLable());
            driver.Quit();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Quit();
        }


    }
}
