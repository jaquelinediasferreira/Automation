using Kneat.PageObjects;
using NUnit.Framework;
using SeleniumBase.SeleniumUtilities;
using System;
using TechTalk.SpecFlow;

namespace Kneat.Steps
{
    [Binding]
    public class SearchResultsLimerickSteps : BaseTest
    {
        BookingPage bookingpage = new BookingPage();

        [Given(@"user is at the home screen")]
        public void GivenUserIsAtTheHomeScreen()
        {
            bookingpage.acessHomeScreen();

        }
        
        [When(@"insert the Location")]
        public void WhenInsertTheLocation()
        {
            bookingpage.insertLocation(Datas.Location);
          
        }
        
        [When(@"inset the dates")]
        public void WhenInsetTheDates()
        {

            bookingpage.insertChechin();
            bookingpage.insertCheckout();
           
        }
        [When(@"insert Number of People, room and")]
        public void WhenInsertNumberOfPeopleRoomAnd()
        {
            bookingpage.insertPeople();
        }
        
        [When(@"click on the serach")]
        public void WhenClickOnTheSerach()
        {
            bookingpage.clickSearch();
        }
        
        [Then(@"should display a list of results in Limerick")]
        public void ThenShouldDisplayAListOfResultsInLimerick()
        {
            bookingpage.listResultLimerick();

        }
    }
}
