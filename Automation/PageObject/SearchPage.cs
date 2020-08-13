using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
// using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

namespace Automation.PageObject
{
    public class SearchPage
    {
        IWebDriver driver;
        public SearchPage (IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }
        [FindsBy(How=How.Name,Using = "search")]
        public IWebElement SearchText { get; set; }

        [FindsBy(How=How.CssSelector,Using = "#search-icon-legacy")]
        public IWebElement SearchButton { get; set; }

        public ResultPage NavigateToResultPage()
        {
            SearchText.SendKeys("jaysergg");
            SearchButton.Click();
            return new ResultPage(driver);
        }
    }
}
