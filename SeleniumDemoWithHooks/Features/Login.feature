Feature: Login Test
	To verify User Login functionakity
@mytag
Scenario: Login with vaid UserCredentials
	Given the Application open as
	When I enter user Credentials as 
	| username | password |
	| admin |admin  |
	And I click on Login Button
	Then the User should be logged in successfully

	
