Feature: apigetlegalentitydetails
	This feature will cover Api testing for legal entity details

@mytag
Scenario: GetListOfLegalEntityDetails
	Given a working LegalEntityDetails api as
	|getLegalEntity|
	|/legal-entities/d346aa32-1136-11ed-a3f8-0600a04d607a|
	When the GET Request is called for Legal Entity Details
	Then the result should show Details of Legal Entity 