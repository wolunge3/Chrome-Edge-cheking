using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V104.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisTestavimas
{
   class CheckBoxDemo
    {
        private static IWebDriver chromeDriver;
        [OneTimeSetUp]

        public static void OneTimeSetUp()
        {
            chromeDriver = new ChromeDriver();
            chromeDriver.Url = "https://demo.seleniumeasy.com/basic-checkbox-demo.html";
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            //edgeDriver.Quit();
        }
        [Test]

        public static void OneCheckBoxTest()
        {
           //IWebElement oneCheckBox = edgeDriver.FindElement(By.Id("isAgeSelected"));
           //IWebElement oneCheckBox = edgeDriver.FindElement(By.CssSelector("#isAgeSelected"));         
           //IWebElement oneCheckBox = edgeDriver.FindElement(By.ClassName("cb1-element"));
             IWebElement oneCheckBox = chromeDriver.FindElement(By.CssSelector(".cb1-element"));



            if (!oneCheckBox.Selected)
            {
                oneCheckBox.Click();
            }
        ;

            IWebElement resultElement = chromeDriver.FindElement(By.Id("txtAge"));
            Assert.AreEqual("Success - Check box is checked", resultElement.Text, "Result text is wrong");
        }
        [Test]
        public static void CheckBoxesTest()
        {
            IReadOnlyCollection<IWebElement> checkBoxesCollection = chromeDriver.FindElements(By.CssSelector(".cb1-element"));

            foreach (IWebElement checkbox in checkBoxesCollection)
            {
                if (!checkbox.Selected)
                {
                    checkbox.Click();

                }
            }
            //IWebElement button = edgeDriver.FindElement(By.Id("check1"));
            IWebElement button = chromeDriver.FindElement(By.CssSelector("#check1"));
            Assert.IsTrue("Uncheck All".Equals(button.GetAttribute("value")), "Button value is not correct");
        }
        [Test]
        public static void checkBoxesUncheckAll()
        {
            IReadOnlyCollection<IWebElement> checkBoxesCollection 
            = chromeDriver.FindElements(By.CssSelector(".cb1-element"));
            foreach (IWebElement checkbox in checkBoxesCollection)
            {
                if (!checkbox.Selected)
                {
                    checkbox.Click();
                }
            }
            IWebElement button = chromeDriver.FindElement(By.Id("check1"));
            button.Click();

            int countNoSelected = 0;
            foreach(IWebElement checkbox in checkBoxesCollection)
            {
                if(!checkbox.Selected)
                {
                    countNoSelected++;
                }
            }
            Assert.AreEqual(checkBoxesCollection.Count, countNoSelected, "Atleast one checkbox is selected");
            Assert.AreEqual("Check All", button.GetAttribute("value"), "Button value is wrong");
            }
    }
}
