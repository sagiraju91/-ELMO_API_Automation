Feature: apigetdepartments
	This feature will cover Api testing

@mytag
Scenario: GetListOfDepartments
	Given working api as
	|getDepartments|
	|/departments|
	When GET Request called
	Then the result should show list of Departments