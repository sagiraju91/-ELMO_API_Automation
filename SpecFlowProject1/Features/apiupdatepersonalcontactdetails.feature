Feature: apiupdatepersonalcontactdetails
	This will result updated user contact details

@mytag
Scenario: UpdateUserContactDetails
	Given a working update user contact details api as
	|putUser|
	|/users/eb5490d6-12f2-11ed-9353-024d2e4942a6/personal-contact-details|
	When the PUT Request  called for an user
	Then the result should show updated user contact details