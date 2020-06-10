@datadriven @table
Feature: Ex04_DataDriven
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers
#Scenario Outline and Scenario Template are same.
Scenario Template: Add two numbers data driven
	Given I have <Initial> items in the cart
	When I add <NoOfItems> items in the cart
	Then I have <Total> items in the cart

	Examples:
		| Initial | NoOfItems | Total |
		| 5       | 2         | 7     |
		| 3       | 4         | 7     |
		| 4       | 1         | 100   |