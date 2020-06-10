@background @payment @sprint3
Feature: Ex03_Background
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Background: for payment 
	Given I login to EcommSite
	And I add item to basket
	And I check out

	@john
Scenario: Payment with Credit Card
	When I pay by Credit Card
	Then order should be successful


Scenario: Payment with Debit Card
	When I pay by Debit Card
	Then order should be successful

Scenario: Payment with Cheque
	When I pay by Cheque
	Then order should be successful
