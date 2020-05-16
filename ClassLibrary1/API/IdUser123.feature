Feature: IdUser123
	When i click send button for  get request "https://gorest.co.in/public-api/users/123" 
	displays an array with user 123 


@negative
Scenario: After processing request  response 404,user with id 123 not dispalayed
	Given I requested a resource that does not exist
	And I have 404 answer
	When I press send button 
	Then the result should be 200ok  and array with user 123  on the screen
