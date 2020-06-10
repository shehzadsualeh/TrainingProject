Feature: E01_Login
	In order to use the ecomm site
	As a existing user
	I want to logib to do some shopping

@login
Scenario: Valid Login
	Given I navigate to the authentication page
	When I provide valid credentials and submit
	Then I should be on my accounts page

@InvalidLogIn
Scenario: InValid LogIn
	Given I navigate to the authentication page
	When I provide invalid credentials and submit
	Then I should get an authentication failed error
