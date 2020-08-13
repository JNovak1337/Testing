// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Automation.BaseClass;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using Automation.Utilities;

namespace Automation
{
    // Properties > AssemblyInfo 
    // Change the value of LevelOfParallelism
    // to test 
    // different amount of browsers at once


    [TestFixture]
    public class ParallelTest
    {
        public IWebDriver driver;

        [Test,Category("Parallel Browsers")]
        public void ChromeBrowser01() 
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("testovaci@email.com");
            Driver.Close();
        }
        [Test,Category("Parallel Browsers")]
        public void ChromeBrowser02()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("testovaci@email.com");
            Driver.Close();
        }
        [Test,Category("Parallel Browsers")]
        public void ChromeBrowser03()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("testovaci@email.com");
            Driver.Close();
        }
        [Test,Category("Parallel Browsers")]
        public void ChromeBrowser04()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("testovaci@email.com");
            Driver.Close();
        }
        [Test,Category("Parallel Browsers")]
        public void ChromeBrowser05()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("testovaci@email.com");
            Driver.Close();

        }
        [Test,Category("Parallel Browsers")]
        public void ChromeBrowser06()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("testovaci@email.com");
            Driver.Close();
        }
        [Test,Category("Parallel Browsers")]
        public void ChromeBrowser07()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("testovaci@email.com");
            Driver.Close();
        }
        [Test,Category("Parallel Browsers")]
        public void ChromeBrowser08()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("testovaci@email.com");
            Driver.Close();
        }
        [Test,Category("Parallel Browsers")]
        public void ChromeBrowser09()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("testovaci@email.com");
            Driver.Close();
        }
        [Test,Category("Parallel Browsers")]
        public void ChromeBrowser10()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("testovaci@email.com");
            Driver.Close();
        }
    }
}
