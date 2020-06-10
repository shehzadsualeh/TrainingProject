Feature: RegisterNewUser
	In order use the website
	As a new user john
	I want to register myself

# here use the tag john to load the data from a external source. 
#Persona example. here John is the character or Persona

	@john @newuser @register
	Scenario: Register A New User
	Given I navigate to the authentication page
	And The user provides email ID to create an account 
	When The user provides the required information and submits for registration 
	Then The user should be able to register successfully 