Feature: apigetlegalentity
	This feature will cover Api testing for legal entity

@mytag
Scenario: GetListOfLegalEntity
	Given a working LegalEntity api as
	|getLegalEntity|
	|/legal-entities|
	When the GET Request is called for Legal Entity
	Then the result should show list of Legal Entities