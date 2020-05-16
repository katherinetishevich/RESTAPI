Feature: SupportedVerbsofeEndPointUser123
When i click send button for  options request "https://gorest.co.in/public-api/users" displays supported verbs of endpoint

@positive
Scenario: Output supported verbs of endpoint for user with id 123
	Given I have prepored  optoins request
	And I have answer 200ok
	When I press send button
	Then the result should be 200ok on the screen
