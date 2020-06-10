Feature: AddProductToCart
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


@addtocart @cart
Scenario Outline: Add Product To Cart
	Given The user navigates to the home page
	And The user adds <item> from the popular section 
	And The user continues the shopping 
	When The user navigates to the shopping cart summary page 
	Then The user should see the <item> and its <price>

	Examples: 
    | item                        | price  |
    | Blouse                      | $27.00 |
    | Faded Short Sleeve T-shirts | $16.51 |