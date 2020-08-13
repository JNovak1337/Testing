using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace Automation
{
    [TestFixture]
    public class Reporting
    {
        ExtentReports extent = null;

        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\jnovak\Desktop\Automation\Automation\Automation\ExtentReports\Reporting.html");
            extent.AttachReporter(htmlReporter);

        }
        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }

        [Test]
        public void HTMLReport()
        {
            IWebDriver driver = null;
            ExtentTest test = null;
            try

            {
                test = extent.CreateTest("Test1").Info("Test Started");
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                test.Log(Status.Info,"Chrome Browser launched");

                driver.Url = "https://www.facebook.com/";
                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
                emailTextField.SendKeys("testovaci@email.com");
                test.Log(Status.Info, "Email id entered");
                driver.Quit();
                test.Log(Status.Pass, "Test Passed");
                
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
        }
    }
}

