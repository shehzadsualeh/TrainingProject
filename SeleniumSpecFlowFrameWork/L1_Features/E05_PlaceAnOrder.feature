Feature: PlaceAnOrder
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given I navigate to the authentication page
	When I provide valid credentials and submit
	Then I should be on my accounts page


@order @placeorder
Scenario: Place an Order
	Given The user navigates to home page
	And The user adds the following to the cart
	| item                        | quantity |
	| Blouse                      | 3        |
	| Faded Short Sleeve T-shirts | 2        |
	And The user navigates to shopping cart summary page 
	And The user proceeds to check out on shopping cart summary page
	And The user proceeds to check out on addresses page
	And The user agress to T and Cs  
	And The user proceeds to check out on shipping page
	And The user selects payment method as pay by cheque
	When The user confirms the order on order summary page
	Then The user should get a message 'Your order on My Store is complete.'
