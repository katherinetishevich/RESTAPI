Feature: listusers
	When i click send button for  get request "https://gorest.co.in/public-api/users" displays an array with users data

@positive
Scenario: Output array with  all users
	Given I have prepored  get request 
	And I have an array with registered user data
	When I press send button 
	Then the result should be 200 ok on the screen

