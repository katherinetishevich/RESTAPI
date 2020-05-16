Feature: OverviewInformation
	When i click send button for head request "https://gorest.co.in/public-api/users" nothing is output

@negative
Scenario: Empty query result field
	Given I have empty request body field
	And I have empty server response
	When I press send button
	Then the result should be 200ok on the screen
