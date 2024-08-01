Feature:Donate Page Tests

check that when you go to the donate page you can fill in details and 
click the donate button and paypal will load

@tag1
Scenario: Donate
	Given I am on the donate page
	When I fill in the standard details and click on the donate button
	Then Paypal page will load 


