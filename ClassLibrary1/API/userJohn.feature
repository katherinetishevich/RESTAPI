Feature: userJohn
When i click send button for  get request "https://gorest.co.in/public-api/users?first_name=john"
Request status "200ok" information is displayed
I don't have list all users with first_name contains john

@negarive
Scenario: After processing request  response 200ok,list all users with first_name contains john not dispalayed
	Given I have invalid request
	And I have answer 200 ok
	When I press send button 
	Then the result should be list all users with first_name contains john on the screen
	  