Feature: IdUser123Update
When i click send button for putch request "https://gorest.co.in/public-api/users/123" 
	displays update an array with user 123 

@negative
Scenario: After processing request  response 404,update user with id 123 not dispalayed
	Given I have requested a resource that does not exist
	And I have 405 answer  
	When I press send button 
	Then the result should be 200ok and update array with user 123 on the screen
