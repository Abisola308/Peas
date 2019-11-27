Feature: Registration
	


Scenario: Verify that a user would be able to register
	Given that Giftrete is up and running
	And a user clicks on sign in link
	When a user clicks on sign in tab
	When a user enters an emailAddress with ogunnaikebisola@yahoo.com
	And a user enters passWord in the password field with Nigeria2014
	And a user clicks on sign in button
	Then Ogunnaike Abisola should be registerd successfully
