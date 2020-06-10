Feature: SearchProduct
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@search
Scenario Outline: Search a Product
	Given The user navigates to home page
	When The user searches for <product>
	Then The user should be able to see all results with <product> 
	Examples: 
	| product              |
	| Printed Summer Dress |