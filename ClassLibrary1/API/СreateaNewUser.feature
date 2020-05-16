Feature: СreateaNewUser
	When i click send button for post request "https://gorest.co.in/public-api/users "
	a request appears check the response body for detailed error messages

@negative
Scenario:  After processing request  response 422ok
	Given I have  prepored  post request 
	And I have a problem with data validation 
	When I press send button 
	Then the result should be add new user on the screen
	  