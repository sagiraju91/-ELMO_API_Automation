Feature: Login Test
	To verify User Login functionakity
@mytag
Scenario: Login with vaid UserCredentials
	Given the Application open
	When Click on Signin link from HomePage
	And I enter user Credentials as 
	| username | password |
	| parida2021uk@gmail.com |Password@123  |
	And I click on Login Button
	Then the User should be logged in successfully
