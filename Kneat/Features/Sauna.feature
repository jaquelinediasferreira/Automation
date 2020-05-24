Feature: Sauna
	

Scenario: select option sauna
	Given user is at the result search
	When the user click on the option sauna
	Then the system should display a list of results in Limerick with The Limerick Strand Hotel and should not display the George Limerick Hotel
