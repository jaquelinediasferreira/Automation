using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumBase.SeleniumUtilities;

namespace Kneat.PageObjects
{
    
     class FiveStarPage : BookingPage
    {
       
        public void resultSerach()
        {
            listResultLimerick();
        }
        public void clickStar()
        {
           WebDriverWait wait = new WebDriverWait(DriverFactory.Driver, TimeSpan.FromSeconds(1));
           DriverFactory.Driver.FindElement(By.LinkText("Stars")).Click();
           DriverFactory.Driver.FindElement(By.LinkText("stars [5→1]")).Click();
           DriverFactory.Driver.FindElement(By.XPath("//div[@id='filter_class']/div[2]/a[3]/label/div"));

        }
        public void selectDecreasing()
        {
          DriverFactory.Driver.FindElement(By.LinkText("stars [5→1]")).Click();
        }
        public void listHotelSavoyHotels()
        {
            WebDriverWait wait = new WebDriverWait(DriverFactory.Driver, TimeSpan.FromSeconds(10));
            wait.Until((d) => d.FindElement(By.XPath("//*[@class='sr-hotel__title'][contains(text(), 'The Savoy Hotels')]")) != null);
            DriverFactory.Driver.ClickElement(By.XPath("//*[@class='sr-hotel__title'][contains(text(), 'The Savoy Hotels')]"));
            var element = DriverFactory.Driver.FindElement(By.XPath("XPath"));
            NUnit.Framework.Assert.IsTrue(element.Displayed);

          

        }
        public void listHotelGeorgeLimerickHotel()
        {
            DriverFactory.Driver.ClickElement(By.XPath("//*[@class='sr-hotel__title'][contains(text(), 'George Limerick Hotel')]"));
            var element = DriverFactory.Driver.FindElement(By.XPath("XPath"));
            NUnit.Framework.Assert.IsFalse(element.Displayed);
        }


    }
}
