using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisTestavimas
{
     class WebDriverTest

    {
        [Test]

        public static void ChromeTest()
        {
            IWebDriver chromeDriver = new ChromeDriver();
            chromeDriver.Url = "https://login.yahoo.com/";
            chromeDriver.Manage().Window.Maximize();
            //IWebElement emailInsertField = edgeDriver.FindElement(By.Id ("login-username"));
            IWebElement emailInsertField = chromeDriver.FindElement(By.CssSelector("#login-username"));
            emailInsertField.SendKeys("Vaidas Volungevicius");

            //edgeDriver.Quit();
        }
        [Test]

        public static void TestSeleniumPage()
        {
            IWebDriver chromeDriver = new ChromeDriver();
            chromeDriver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
            chromeDriver.Manage().Window.Maximize();

            IWebElement inputField = chromeDriver.FindElement(By.Id("user-message"));
            inputField.SendKeys("Antradienis");

            IWebElement button = chromeDriver.FindElement(By.CssSelector("#get-input > button"));
            button.Click();

            IWebElement resultElement = chromeDriver.FindElement(By.Id("display"));
            Assert.AreEqual("Antradienis", resultElement.Text, "Text is not the same");
            chromeDriver.Quit();
        }

    }
}
