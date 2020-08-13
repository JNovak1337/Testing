using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver; 

        [OneTimeSetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(5000);
        }

        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
