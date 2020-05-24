using OpenQA.Selenium;
using SeleniumBase.SeleniumUtilities;
using System;
using OpenQA.Selenium.Support.UI;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;

namespace Kneat.PageObjects
{
    class BookingPage : BaseTest

    {
        public void acessHomeScreen()
        {

           DriverFactory.Driver.LoadPage(TimeSpan.FromSeconds(60), "https://www.booking.com/");

        }
        public string checkLogo()
        {
            WebDriverWait wait = new WebDriverWait(DriverFactory.Driver, TimeSpan.FromSeconds(1));
            wait.Until((d) => d.FindElement(By.Id("logo_no_globe_new_logo")).Displayed);
            return DriverFactory.Driver.GetText(By.Id("logo_no_globe_new_logo[contains(text(), 'Booking.com')]"));
        }
        public void insertLocation(string location)
        {
            WebDriverWait wait = new WebDriverWait(DriverFactory.Driver, TimeSpan.FromSeconds(1));
            wait.Until((d) => d.FindElement(By.Name("ss")).Displayed);
       
            DriverFactory.Driver.SetText(By.Name("ss"), location.ToString());
            DriverFactory.Driver.SetDown(By.Name("ss"));
        
            Thread.Sleep(500);
            WebDriverWait wait1 = new WebDriverWait(DriverFactory.Driver, TimeSpan.FromSeconds(1));
            
            wait.Until((d) => d.FindElement(By.ClassName("search_hl_name")).Displayed);
            DriverFactory.Driver.FindElement(By.ClassName("search_hl_name")).Click();
            //search_hl_name

            DriverFactory.Driver.SetTab(By.Name("ss"));


        }
        public void insertChechin()
        {
            DriverFactory.Driver.FindElement(By.CssSelector(".xp__dates__checkin")).Click();
           
            Thread.Sleep(500);
           

            DriverFactory.Driver.FindElement(By.XPath("//*[@id='frm']/div[1]/div[2]/div[2]/div/div/div[2]")).Click();
            DriverFactory.Driver.FindElement(By.XPath("//*[@id='frm']/div[1]/div[2]/div[2]/div/div/div[2]")).Click();
            DriverFactory.Driver.FindElement(By.XPath("//*[@id='frm']/div[1]/div[2]/div[2]/div/div/div[2]")).Click();
       
           
            DriverFactory.Driver.FindElement(By.XPath("//*[@id='frm']/div[1]/div[2]/div[2]/div/div/div[3]/div[2]/table/tbody/tr[5]/td[2]/span")).Click();
           
        }
        public void insertCheckout()
        {
            DriverFactory.Driver.FindElement(By.XPath("//*[@id='frm']/div[1]/div[2]/div[2]/div/div/div[3]/div[2]/table/tbody/tr[5]/td[3]/span")).Click();
        }
        public void insertPeople()
        {
            //DriverFactory.Driver.FindElement(By.Id("group_adults")).Click();
           // DriverFactory.Driver.FindElement(By.Id("group_adults")).Clear();


           // DriverFactory.Driver.FindElement(By.Id("group_adults")).SendKeys("3");
            //DriverFactory.Driver.FindElement(By.Id("no_rooms")).SendKeys("2");

        }
        public void clickSearch()
        {
            DriverFactory.Driver.FindElement(By.ClassName("sb-searchbox__button")).Click();

        }
        public void listResultLimerick()
        {
            DriverFactory.Driver.FindElement(By.XPath("//form[@id='frm']/div/div[4]/div[2]/button/span,''"));
            DriverFactory.Driver.ClickElement(By.XPath("//*[@class='sr_header--title'][contains(text(), 'Limerick: 31 acomodações encontradas')]"));
        }
    }
        
}



