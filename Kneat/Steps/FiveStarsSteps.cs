using Kneat.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace Kneat.Steps
{
    [Binding]
    public class FiveStarsSteps
    {
        FiveStarPage filterfiveftarpage = new FiveStarPage();

        [When(@"the user click on the option (.*) stars")]
        public void WhenTheUserClickOnTheOptionStars(int p0)
        {
            filterfiveftarpage.resultSerach();
            filterfiveftarpage.clickStar();
            filterfiveftarpage.selectDecreasing();
        }
        
        [Then(@"the system should display a list of results in Limerick with The Savoy Hotel and should not display the George Limerick Hotel for stars")]
        public void ThenTheSystemShouldDisplayAListOfResultsInLimerickWithTheSavoyHotelAndShouldNotDisplayTheGeorgeLimerickHotelForStars()
        {
            filterfiveftarpage.listHotelSavoyHotels();
        }
    }
}
