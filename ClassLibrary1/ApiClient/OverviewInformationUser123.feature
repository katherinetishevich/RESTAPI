Feature: OverviewInformationUser123
	When i click send button for head request  nothing is output
	And i don't have overview information about user with id 123

@negative
Scenario: Empty query result field
	Given I have empty request body field
	And I have empty server response
	When I press send button
	Then the result should be 200ok on the screen
	  