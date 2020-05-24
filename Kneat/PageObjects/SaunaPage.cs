using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumBase.SeleniumUtilities;

namespace Kneat.PageObjects
{
    class SaunaPage : BookingPage
    {
        
        public void resultSerach()
        {
            listResultLimerick();
        }
        public void clickSauna()
        {
            WebDriverWait wait = new WebDriverWait(DriverFactory.Driver, TimeSpan.FromSeconds(1));
            DriverFactory.Driver.FindElement(By.XPath("//div[@id='filter_popular_activities']/div[2]/a[4]/label/div")).Click();
           
        }
        public void listLimerickStrandHotel()
        {
            WebDriverWait wait = new WebDriverWait(DriverFactory.Driver, TimeSpan.FromSeconds(10));
            wait.Until((d) => d.FindElement(By.XPath("//*[@class='sr-hotel__title'][contains(text(), 'Limerick Strand Hotel')]")) != null);
            DriverFactory.Driver.ClickElement(By.XPath("//*[@class='sr-hotel__title'][contains(text(), 'Limerick Strand Hotel')]"));
            var element = DriverFactory.Driver.FindElement(By.XPath("XPath"));
            NUnit.Framework.Assert.IsTrue(element.Displayed);

        }
        public void listGeorgeLimerickHotel()
        {
            DriverFactory.Driver.ClickElement(By.XPath("//*[@class='sr-hotel__title'][contains(text(), 'George Limerick Hotel')]"));
            var element = DriverFactory.Driver.FindElement(By.XPath("XPath"));
            NUnit.Framework.Assert.IsFalse(element.Displayed);

        }
    }
}
