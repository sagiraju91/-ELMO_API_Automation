Feature: Home Page
	To verify User Home Page
@mytag
Scenario Outline: User Home Page
	Given the Application as
	| Browser    |
	| <Browsers> |
	When Click on Signin link from HomePage
	Then User Login Page should be displayed

	Examples:
	|Browsers|
	|chrome|
	|edge|
