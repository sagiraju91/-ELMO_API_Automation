Feature: apigetusers
	This feature will cover Api testing

@mytag
Scenario: GetListOfUsers
	Given a working api as
	|getUsers|
	|/users|
	When the GET Request is called
	Then the result should show list of Users