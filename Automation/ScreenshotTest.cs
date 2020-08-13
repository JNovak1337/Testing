using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation
{
    [TestFixture,Category("Screenshot Output Test")]
    public class ScreenshotTesting
    {
        [Test]
        public void ScreenshotTest(String urlName)
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                // driver.Url = "https://www.facebook.com/";
                driver.Url = urlName;
                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
                // IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='Testicek']"));
                emailTextField.SendKeys("testovaci@email.com");
                driver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\jnovak\\Desktop\\Automation\\Automation\\Automation\\Screenshots\\Screenshot1.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if(driver!=null)
                {
                    driver.Quit();
                }
            }
        }
        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com/");
            // list.Add("https://www.youtube.com/");
            // list.Add("https://www.gmail.com/");

            return list;
        }
           // }
           // [Test]
           // [Author("JNovak", "jnovak@mujmail.com")]
           // [Description("Facebook Login Verify")]
           // public void Test2()
           // {
           // IWebDriver driver = new ChromeDriver();
           // driver.Manage().Window.Maximize();
           // driver.Url = "https://www.facebook.com/";
           // IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
           // emailTextField.SendKeys("testovaci@email.com");
           // driver.Quit();
    }
}
