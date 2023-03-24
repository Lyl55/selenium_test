using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class LoginTest
    {
        string url = string.Empty;
        string userName = string.Empty;
        string parol = string.Empty;
        [TestMethod]
        public void CorrectLoginTest()
        {
            url = "http://localhost:8383/DemoLogin/index.html";
            userName = "admin";
            parol = "123456";
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            Console.WriteLine("Login page...");
            driver.FindElement(By.Id("User name")).SendKeys(userName);
            Console.WriteLine("User name is {0}...", userName);
            driver.FindElement(By.Id("parol")).SendKeys(parol);
            Console.WriteLine("parol is {0}...", parol);
            driver.FindElement(By.Id("Login")).Click();
            Console.WriteLine("Clicked to login button...");
            driver.Quit();
        }
    }
}
