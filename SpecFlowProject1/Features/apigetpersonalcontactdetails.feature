Feature: apigetpersonalcontactdetails
	This will result user contact details

@mytag
Scenario: GetUserContactDetails
	Given a working get user contact details api as
	|getUser|
	|/users/33c65058-17ac-11ed-8971-02ea2a01b072/personal-contact-details|
	When the GET Request  called for an user
	Then the result should show user contact details