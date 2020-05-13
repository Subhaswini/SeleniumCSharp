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

      /*  public static void Main()
        {

        }
*/
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            SeleniumSetMethods.SelectDropdown("TitleId", "Mr.", PropertyType.Id);
            SeleniumSetMethods.EnterText("Initial", "ExecuteAutomation", PropertyType.Name);
            Console.WriteLine("The value from my title is: " + SeleniumGetMethods.GetText("TitleId", PropertyType.Id));
            Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));
            SeleniumSetMethods.Click("Save", PropertyType.Name);
            Console.WriteLine("Executed tests using custom methods successfully");
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}