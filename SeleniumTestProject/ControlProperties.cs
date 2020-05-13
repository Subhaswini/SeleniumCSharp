/*using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTestProject
{
    [TestClass]
    public static class ControlProperties
    {
        public static By signupClick = By.XPath("//*[@id='ctl00_HeaderHomeNewDesign_Login1_HyperLinkRegister']");
        public static By email = By.Name("ctl00$ContentMain$TextBoxEmail");
        public static By firstName = By.Name("ctl00$ContentMain$TextBoxFirstName");
        public static By lastName = By.Name("ctl00$ContentMain$TextBoxLastName");
        public static By password = By.XPath("//*[@id='ctl00_ContentMain_TextBoxPassword']");
        public static By confirmPassword = By.Name("ctl00$ContentMain$TextBoxPasswordConfirm");
        public static By countryDropdown = By.Name("ctl00$ContentMain$DropdownListCountry");
        public static By zipCode = By.Name("ctl00$ContentMain$TextBoxZip");
        public static By city = By.Name("ctl00$ContentMain$TextBoxCity");
        public static By securityQuestion = By.Name("ctl00$ContentMain$DropdownListSecurityQuesion");
        public static By securityAnswer = By.Id("ctl00_ContentMain_TextBoxAnswer");
        public static By sendMeUpdates = By.Id("ctl00_ContentMain_CheckBoxNewsletter");
        public static By iAccept = By.Name("ctl00$ContentMain$cbxIsGDPRAccepted");
        public static By registerMe = By.XPath("//*[@id='ctl00_ContentMain_ButtonSave']");
        public static By homeClick = By.XPath("//*[@id='ctl00_HeaderNewDesign1_HeaderMenu']/div/div/ul/li[1]/a");
        public static By searchClick = By.Name("ctl00$HeaderHomeNewDesign$searchImageButton");
        public static By authorSearchClick = By.Id("tabAuthorSearch");
        public static By authorFirstName = By.Id("TextBoxFirstName");
        public static By searchBtn = By.XPath("//*[@id='ctl00_ContentMain_PanelAuthorSearch']/input[3]");
        public static By profileClick = By.XPath("//*[@id='authorSearchResult']/div/div/ul/li[1]/a/span");
        public static By articlesClick = By.XPath("//*[@id='divContributes']/ul/li[1]/a");
        public static By firstArticleClick = By.XPath("//*[@id='ctl00_ContentMain_contentBoxUL']/li[1]/div[2]/h3/a");
    }
    public class PageObjectModelMethods
    {
        IWebDriver webDriver;
        public PageObjectModelMethods(IWebDriver driver)
        {
            this.webDriver = driver;
        }

        public void SignUpClick()
        {
            webDriver.FindElement(ControlProperties.signupClick).Click();
            WaitTime();
        }

        public void EnterEmail(string userEmail)
        {
            webDriver.FindElement(ControlProperties.email).Clear();
            webDriver.FindElement(ControlProperties.email).SendKeys(userEmail);
            WaitTime();
        }

        public void FirstName(string userFirstName)
        {
            webDriver.FindElement(ControlProperties.firstName).Clear();
            webDriver.FindElement(ControlProperties.firstName).SendKeys(userFirstName);
            WaitTime();
        }

        public void LastName(string userLastName)
        {
            webDriver.FindElement(ControlProperties.lastName).Clear();
            webDriver.FindElement(ControlProperties.lastName).SendKeys(userLastName);
            WaitTime();
        }

        public void Password(string userPassword)
        {
            webDriver.FindElement(ControlProperties.password).Clear();
            webDriver.FindElement(ControlProperties.password).SendKeys(userPassword);
            WaitTime();
        }

        public void ConfirmPassword(string userConfirmPassword)
        {
            webDriver.FindElement(ControlProperties.confirmPassword).Clear();
            webDriver.FindElement(ControlProperties.confirmPassword).SendKeys(userConfirmPassword);
            WaitTime();
        }

        public void CountryDopDown(string countryName)
        {
            IWebElement countryDrop = webDriver.FindElement(ControlProperties.countryDropdown);
            countryDrop.Click();
            SelectElement select = new SelectElement(countryDrop);
            select.SelectByValue(countryName);
            WaitTime();
        }

        public void ZipCode(string userZipCode)
        {
            webDriver.FindElement(ControlProperties.zipCode).Clear();
            webDriver.FindElement(ControlProperties.zipCode).SendKeys(userZipCode);
            WaitTime();
        }

        public void City(string userCity)
        {
            webDriver.FindElement(ControlProperties.city).Clear();
            webDriver.FindElement(ControlProperties.city).SendKeys(userCity);
            WaitTime();
        }

        public void SecurityQuestion(string userSecurityQuestion)
        {
            IWebElement securityQues = webDriver.FindElement(ControlProperties.securityQuestion);
            securityQues.Click();
            Thread.Sleep(3000);
            SelectElement select = new SelectElement(securityQues);
            select.SelectByValue(userSecurityQuestion);
            WaitTime();
        }

        public void SecurityAnswer(string userSecurityAnswer)
        {
            webDriver.FindElement(ControlProperties.securityAnswer).Clear();
            webDriver.FindElement(ControlProperties.securityAnswer).SendKeys(userSecurityAnswer);
            WaitTime();
        }

        public void Captcha()
        {
            //Selenium doesn't support automation of Captcha, we need to automate it using Third party dll's.  
        }

        public void SendUpdates()
        {
            webDriver.FindElement(ControlProperties.sendMeUpdates).Click();
            WaitTime();
        }

        public void IAcceptTerms()
        {
            webDriver.FindElement(ControlProperties.iAccept).Click();
            WaitTime();
        }

        public void RegisterMe()
        {
            webDriver.FindElement(ControlProperties.registerMe).Click();
            WaitTime();
        }

        public void HomeClick()
        {
            webDriver.FindElement(ControlProperties.homeClick).Click();
            WaitTime();
        }

        public void SearchClick()
        {
            webDriver.FindElement(ControlProperties.searchClick).Click();
            WaitTime();
        }

        public void AuthorSearchClick()
        {
            webDriver.FindElement(ControlProperties.authorSearchClick).Click();
            WaitTime();
        }

        public void AuthorFirstName(string userFirstName)
        {
            webDriver.FindElement(ControlProperties.authorFirstName).Clear();
            webDriver.FindElement(ControlProperties.authorFirstName).SendKeys(userFirstName);
            WaitTime();
        }

        public void AuthorSearchButton()
        {
            webDriver.FindElement(ControlProperties.searchBtn).Click();
            Thread.Sleep(3000);
            WaitTime();
        }

        public void ProfileClick()
        {
            webDriver.FindElement(ControlProperties.profileClick).Click();
            WaitTime();
        }

        public void ArticlesClick()
        {
            webDriver.FindElement(ControlProperties.articlesClick).Click();
            WaitTime();
        }


        public void FirstArticleClick()
        {
            webDriver.FindElement(ControlProperties.firstArticleClick).Click();
            WaitTime();
        }

        public void WaitTime()
        {
            WebDriverWait webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }

        [TestClass]
        public class DriverInitialization
        {
            IWebDriver Webdriver;

            public DriverInitialization()
            {
                *//*ChromeOptions chromeOptions = new ChromeOptions();
                chromeOptions.AddArgument("disable-infobars");
                Webdriver = new ChromeDriver(@"D:\chromedriver_win32", chromeOptions);*//*
                Webdriver = new ChromeDriver();
                Webdriver.Navigate().GoToUrl("https://www.c-sharpcorner.com/");
                Webdriver.Manage().Window.Maximize();
                WebDriverWait webDriverWait = new WebDriverWait(Webdriver, TimeSpan.FromSeconds(40));
            }

            [TestMethod]
            public void UserRegisteration()
            {
                // Four User Login Data.  
                PageObjectModelMethods register = new PageObjectModelMethods(Webdriver);
                register.SignUpClick();
                register.EnterEmail("Khaja.moiz@gmail.com");
                register.FirstName("Khaja");
                register.LastName("Moizuddin");
                register.Password("1234567890");
                register.ConfirmPassword("1234567890");
                register.CountryDopDown("India");
                register.ZipCode("500076");
                register.City("Hyderabad");
                register.SecurityQuestion("2");
                register.SecurityAnswer("Valuemomentum Software Services");
                register.SendUpdates();
                register.IAcceptTerms();
                register.RegisterMe();
                register.HomeClick();
                register.SearchClick();
                register.AuthorSearchClick();
                register.AuthorFirstName("Khaja");
                register.AuthorSearchButton();
                register.ProfileClick();
                register.ArticlesClick();
                register.FirstArticleClick();
                Webdriver.Quit();
            }
        }
    }
}
*/