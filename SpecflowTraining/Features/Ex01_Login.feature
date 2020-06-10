@sprint1 @login
Feature: Ex01_Login
	In order to do shopping
	As a prime customer
	I should be able to login

# This is a Comment

 @story325 @regession @smoke @abdul 
Scenario: Login with valid credentials
	Given I navigate to Login Page
	When I enter valid credentials and submit
	Then I should be successfully logged in

 @smoke @defect876
Scenario: Login with invalid credentials
	Given I navigate to Login Page
	When I enter invalid credentials and submit
	Then I should be NOT be logged in