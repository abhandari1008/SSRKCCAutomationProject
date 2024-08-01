Feature: Donate Page

These tests will test all functionality on donate page

@tag1
Scenario: Make a donation
	Given I am on the donate page
	When I enter the standard details for Rishi Bhandari donation
	Then the paypal page loads
