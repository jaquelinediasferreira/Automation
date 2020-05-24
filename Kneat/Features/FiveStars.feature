Feature: FiveStars

Scenario: select options 5 star 
	Given user is at the result search
	When the user click on the option 5 stars
	Then the system should display a list of results in Limerick with The Savoy Hotel and should not display the George Limerick Hotel for stars
