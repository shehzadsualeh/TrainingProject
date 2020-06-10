Feature: Ex02_MoreSteps
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag @cart @sprint2
Scenario: Practising more steps diffrent variety
	Given I navigate to Login Page
	And I click on Forget Password
	When I enter my Email
	And I click Submit
	Then I should receive an email
	And I add 3 items in the cart
	#And I add abc items in the cart
	And I Select from Kids section
	And I select the size 'Med'
	And I add 1 item in the cart 
	And This is a sample doc string
	"""
	Thanks for contacting abrakh academy
	we appreciate your business
	Thank you
	visit again
	"""
	And I choose the following and add to the basket
	| ItemCode | ItemName      | Quantity |
	| IT01     | T-Shirt       | 3        |
	| IT02     | Evening Dress | 1        |
	| IT03     | Winter Coat   | 2        |

#	And I choose 'Tshirt' with qauntity 3 and add to basket
#	And I choose 'Evening Dress' with qauntity 1 and add to basket
#	And I choose 'Winter' with qauntity 2 and add to basket