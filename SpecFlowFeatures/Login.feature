Feature: Login
	 In order to test login function

@mytag
Scenario Outline: Test Login
	Given user on the https://www.seek.co.nz/sign-in page

	
	When I typed the <username>
	And I entered the <password>
	And Login button
	Then The title sun was presented after login 

Scenarios:
	| username                  | password   |
	| lsun145@aucklanduni.ac.nz	| 8362i8366Q |
	| 695159623@qq.com          | 87973jidsf |