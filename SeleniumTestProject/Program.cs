using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;


namespace SeleniumTestProject
{
    class Program
    {
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/Login.html");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            LoginPageObject pageLogin = new LoginPageObject();
            HomePageObject pagehome = pageLogin.Login("execute", "automation");
            pagehome.FillUserForm("Corametla", "Subhaswini", "Jayaanandh");
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}