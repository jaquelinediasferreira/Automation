using SeleniumBase.Enum;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;

namespace SeleniumBase.SeleniumUtilities

{
    public class DriverFactory
    {
        private static IWebDriver _driver;
        public static IWebDriver Driver { get { return _driver; } set => _driver = value; }
        public static void CreateDriver(Browser name)
        {
            string driverLocation = System.AppDomain.CurrentDomain.BaseDirectory.Replace("\\Kneat\\Kneat\\SeleniumBase\\bin\\Debug", "");
            switch (name)
            {
                case Browser.IE:
                    InternetExplorerOptions ieOption = new InternetExplorerOptions
                    {
                        IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                        RequireWindowFocus = true,
                        IgnoreZoomLevel = true,
                        UnhandledPromptBehavior = UnhandledPromptBehavior.Accept,
                        EnablePersistentHover = true,
                        EnableNativeEvents = false,
                        EnsureCleanSession = true
                    };
                    _driver = new InternetExplorerDriver(driverLocation, ieOption);
                    _driver.Manage().Window.Maximize();
                    break;

                case Browser.FIREFOX:
                    FirefoxOptions firefoxOptions = new FirefoxOptions();
                    firefoxOptions.AddArgument("start-maximized");
                    _driver = new FirefoxDriver(driverLocation, firefoxOptions);
                    break;

                case Browser.EDGE:
                    _driver = new EdgeDriver(driverLocation);
                    _driver.Manage().Window.Maximize();
                    break;

                case Browser.CHROME:
                    ChromeOptions ChromeOption = new ChromeOptions();
                    ChromeOption.AddArgument("start-maximized");
                    _driver = new ChromeDriver(driverLocation, ChromeOption);
                    break;
            }
        }

        public static int FindElements(By by)
        {
            throw new NotImplementedException();
        }

        public static void Close()
        {
            Driver.Quit();
            Driver.Dispose();
            Driver = null;
        }
    }
}
