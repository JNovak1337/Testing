using Automation.BaseClass;
using Automation.PageObject;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation.TestScripts
{
    [TestFixture]
    public class Module1 : BaseTest
    {
        [Test,Category("NOT_FINISHED")]
        public void YTChannelSelect()
        {
            var SearchPage = new SearchPage(driver);
            var ResultPage = SearchPage.NavigateToResultPage();
            ResultPage.NavigateToChannel();

            Thread.Sleep(5000);
        }
    }
}
