Feature: activateuser
	This is used to activate an User

@mytag
Scenario: ActivateUser
	Given  activate user api as
	|activateUser|
	|/users/33c65058-17ac-11ed-8971-02ea2a01b072/activate|
	When the POST method is called
	Then the user shoud be activated

