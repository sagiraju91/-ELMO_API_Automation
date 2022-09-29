Feature: deactivateuser
	This is used to deactivate an User

@mytag
Scenario: DeactivateUser
	Given  deactivate user api as
	|deactivateUser|
	|/users/33c65058-17ac-11ed-8971-02ea2a01b072/deactivate|
	When the POST method called
	Then the user shoud be deactivated

