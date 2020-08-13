using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
// using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

namespace Automation.PageObject
{
    public class ResultPage
    {
        IWebDriver driver;
        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "jaystergg")]
        public IWebElement ChannelNameLinkText { get; set; }

        public void NavigateToChannel()
        {
            Thread.Sleep(3000);
            ChannelNameLinkText.Click();
        }
    }
}
