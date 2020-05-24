using Kneat.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace Kneat.Steps
{
    [Binding]
    public class SaunaSteps
    {
        SaunaPage saunapage = new SaunaPage();

        [Given(@"user is at the result search")]
        public void GivenUserIsAtTheResultSearch()
        {
            saunapage.resultSerach();
        }
        
        [When(@"the user click on the option sauna")]
        public void WhenTheUserClickOnTheOptionSauna()
        {
            saunapage.clickSauna();
        }
        
        [Then(@"the system should display a list of results in Limerick with The Limerick Strand Hotel and should not display the George Limerick Hotel")]
        public void ThenTheSystemShouldDisplayAListOfResultsInLimerickWithTheLimerickStrandHotelAndShouldNotDisplayTheGeorgeLimerickHotel()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
