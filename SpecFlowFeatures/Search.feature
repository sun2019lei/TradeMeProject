Feature: Search
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Search Keyword

	Given user on the https://www.seek.co.nz/ page
	And I have entered "testing" into the textbox

	When I press seek
	Then the found should be presented