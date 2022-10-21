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
     class NamuDarbai1
    {
        [Test]

        public static void Testas2plus2()
        {
            IWebDriver chromeDriver = new ChromeDriver();
            chromeDriver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
            chromeDriver.Manage().Window.Maximize();

            IWebElement inputField1 = chromeDriver.FindElement(By.Id("sum1"));
            inputField1.SendKeys("2");
            IWebElement inputField2 = chromeDriver.FindElement(By.Id("sum2"));
            inputField2.SendKeys("2");  
            IWebElement button = chromeDriver.FindElement(By.CssSelector("#gettotal > button"));
            button.Click();

            IWebElement result = chromeDriver.FindElement(By.Id("displayvalue"));
            Assert.AreEqual("4", result.Text, "Are not equal");
            //edgeDriver.Quit();


        }
        [Test]

        public static void TestasMinus5Plus3()
        {
            IWebDriver chromeDriver = new ChromeDriver();
            chromeDriver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
            chromeDriver.Manage().Window.Maximize();

            IWebElement inputField1 = chromeDriver.FindElement(By.Id("sum1"));
            inputField1.SendKeys("-5");
            IWebElement inputField2 = chromeDriver.FindElement(By.Id("sum2"));
            inputField2.SendKeys("3");
            IWebElement button = chromeDriver.FindElement(By.CssSelector("#gettotal > button"));
            button.Click();

            IWebElement result = chromeDriver.FindElement(By.Id("displayvalue"));
            Assert.AreEqual("-2", result.Text, "Are not equal");
            //edgeDriver.Quit();
        }
        [Test]

        public static void TestasAplusB()
        {
            IWebDriver chromeDriver = new ChromeDriver();
            chromeDriver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
            chromeDriver.Manage().Window.Maximize();

            IWebElement inputField1 = chromeDriver.FindElement(By.Id("sum1"));
            inputField1.SendKeys("a");
            IWebElement inputField2 = chromeDriver.FindElement(By.Id("sum2"));
            inputField2.SendKeys("b");
            IWebElement button = chromeDriver.FindElement(By.CssSelector("#gettotal > button"));
            button.Click();

            IWebElement result = chromeDriver.FindElement(By.Id("displayvalue"));
            Assert.AreEqual("ab", result.Text, "Are not equal");
            //edgeDriver.Quit();
        }
        }
    }
