Feature: apigetdepartmentdetails
	This feature will cover Api testing

@mytag
Scenario: GetListOfDepartmentDetails
	Given the working api as
	|getDepartments|
	|/departments/0dcae4ac-0e17-11ed-a658-066dc767596e|
	When the GET Request called
	Then the result should show details of Department