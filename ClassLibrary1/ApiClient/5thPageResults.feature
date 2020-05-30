Feature:  5thPageResults
	When i click send button for  get request 
	displays an array with 5th page results 

Scenario: Output array with  5th page results users
	Given I have prepored  get request
	And I have an array with user data on 5th page
	When I press send button 
	Then the result should be 200ok on the screen
