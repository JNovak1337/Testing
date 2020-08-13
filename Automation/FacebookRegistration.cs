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
using System;

namespace Automation
{
    // Facebook Registration (testing purposes only)

    [TestFixture]
    public class FacebookRegistration
    {
        public IWebDriver driver; 

        [Test,Category("Facebook Registration Test")]
        public void RegistrationTest() 
        {
          // Sign Up information

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
            driver.FindElement(By.Id("u_0_2")).Click();
            Thread.Sleep(1200);
            driver.FindElement(By.Name("firstname")).SendKeys("Jan");
            driver.FindElement(By.Name("lastname")).SendKeys("Novák");
            driver.FindElement(By.Name("reg_email__")).SendKeys("jan_novak@email.cz");
            Thread.Sleep(500);
            driver.FindElement(By.Name("reg_email_confirmation__")).SendKeys("jan_novak@email.cz");
            driver.FindElement(By.Name("reg_passwd__")).SendKeys("heslo123");

          // Date of Birth

            IWebElement dayselect = driver.FindElement(By.Id("day"));
            SelectElement element = new SelectElement(dayselect);
            element.SelectByIndex(16);

            IWebElement monthselect = driver.FindElement(By.Id("month"));
            SelectElement element2 = new SelectElement(monthselect);
            element2.SelectByIndex(5);

            IWebElement yearselect = driver.FindElement(By.Name("birthday_year"));
            SelectElement element3 = new SelectElement(yearselect);
            element3.SelectByText("1996");
            Thread.Sleep(500);

          // Gender Select

            driver.FindElement(By.XPath("id(//label[text() = 'Custom']/@for)")).Click();

          // Additional Settings

            IWebElement pronounselect = driver.FindElement(By.Name("preferred_pronoun"));
            SelectElement element4 = new SelectElement(pronounselect);
            element4.SelectByIndex(1);

            driver.FindElement(By.Name("custom_gender")).SendKeys("Tvoje Máma");

          // Registration Finish (Do not finish the registraion since Facebook will block the account instanly)

            // driver.FindElement(By.Name("websubmit")).Click();
        }
    }
}
