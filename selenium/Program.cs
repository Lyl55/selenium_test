using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Hello!");
            Thread.Sleep(2000);

            IWebElement userName = driver.FindElement(By.Name("email"));
            IWebElement password = driver.FindElement(By.Name("pass"));
            IWebElement loginBtn = driver.FindElement(By.Name("login"));

            Data data = new Data();
            userName.SendKeys(data.userName());
            password.SendKeys(data.password());
            loginBtn.Click();
            Console.WriteLine("Info is added!");
            Thread.Sleep(2500);
            IWebElement followerLink = driver.FindElement(By.CssSelector(".x1i10hfl.xjbqb8w.x6umtig.x1b1mbwd.xaqea5y.xav7gou.x9f619.x1ypdohk.xe8uvvx.xdj266r.x11i5rnm.xat24cr.x1mh8g0r.xexx8yu.x4uap5.x18d9i69.xkhd6sd.x16tdsg8.x1hl2dhg.xggy1nq.x1o1ewxj.x3x9cwd.x1e5q0jg.x13rtm0m.x87ps6o.x1lku1pv.x1a2a7pz.x6s0dn4.x78zum5.xdt5ytf.x5yr21d.xl56j7k.x1n2onr6.xh8yej3"));

            followerLink.Click();

            
            Thread.Sleep(2500);


            
        }
    }
}
