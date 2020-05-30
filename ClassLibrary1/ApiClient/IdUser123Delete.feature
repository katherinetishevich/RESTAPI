Feature: IdUser123Delete
	When i click send button for putch request 
	delete an array with user 123 

@negative
Scenario: After processing request  response 404,user with id 123 not dispalayed and not delete
	Given I have requested a resource that does not exist
	And  I have 405 answer
	When I press send button    
	Then the result should be 200ok and delete array with user 123 on the screen
