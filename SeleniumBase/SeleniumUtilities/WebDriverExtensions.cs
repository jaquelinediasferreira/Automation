using System;
using OpenQA.Selenium;

namespace SeleniumBase.SeleniumUtilities
{
    public static class WebDriverExtensions
    {
    public static void LoadPage(this IWebDriver webDriver,
        TimeSpan timeToWait, string url)
    {
        webDriver.Manage().Timeouts().PageLoad = timeToWait;
        webDriver.Navigate().GoToUrl(url);
    }

    public static string GetText(this IWebDriver webDriver, By by)
    {
        IWebElement webElement = webDriver.FindElement(by);
        return webElement.Text;
    }

    public static void SetText(this IWebDriver webDriver,
        By by, string text)
    {
        IWebElement webElement = webDriver.FindElement(by);
        webElement.SendKeys(text);
    }

    public static void Submit(this IWebDriver webDriver, By by)
    {
        IWebElement webElement = webDriver.FindElement(by);
        webElement.Submit();
    }

    public static void ClickElement(this IWebDriver webDriver, By by)
    {
        IWebElement webElement = webDriver.FindElement(by);
        webElement.Click();
    }

    public static void SetTab(this IWebDriver webDriver, By by)
    {
        IWebElement webElement = webDriver.FindElement(by);
        webElement.SendKeys(Keys.Tab);
    }
        public static void SetDown(this IWebDriver webDriver, By by)
        {
            IWebElement webElement = webDriver.FindElement(by);
            webElement.SendKeys(Keys.Down);
        }
        public static void SetEnter(this IWebDriver webDriver, By by)
        {
            IWebElement webElement = webDriver.FindElement(by);
            webElement.SendKeys(Keys.Enter);
        }
    }
    
}