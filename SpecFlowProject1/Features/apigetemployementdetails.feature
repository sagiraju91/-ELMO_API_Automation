Feature: apigetemployementdetails
	This will result employement details

@mytag
Scenario: GetEmployementDetailsSteps
	Given a working get employement details api as
	|getEmployement|
	|/users/33c65058-17ac-11ed-8971-02ea2a01b072|
	When the GET Request is called for an employement
	Then the result should show employement details