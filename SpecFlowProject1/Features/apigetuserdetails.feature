Feature: apigetuserdetails
	This will result user details

@mytag
Scenario: GetUser
	Given a working get user api as
	|getUser|
	|/users/33c65058-17ac-11ed-8971-02ea2a01b072|
	When the GET Request is called for an user
	Then the result should show user details