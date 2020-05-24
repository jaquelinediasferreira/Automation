using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SeleniumBase.SeleniumUtilities
{
    [TestFixture]
    public class BaseTest
    {
        [BeforeScenario]
        public void startBrowser()
        {
            DriverFactory.CreateDriver(Enum.Browser.CHROME);
        }

        [AfterScenario]
        public void quitDriver()
        {
           DriverFactory.Close();
       }
    }
}

