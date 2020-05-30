Feature: SupportedVerbsofeEndPoint
	When i click send button for  options request  displays supported verbs of endpoint

@positive
Scenario: Output supported verbs of endpoint
	Given I have prepored  optoins request 
	And  I have answer 200ok
	When I press send button
	Then the result should be 200ok on the screen
	  