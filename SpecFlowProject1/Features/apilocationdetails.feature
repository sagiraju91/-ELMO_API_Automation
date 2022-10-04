Feature: apilocationdetails
	This covers Location GET API valication

@mytag
Scenario: GETapilocationDetails
	Given locationsAPI as
	|getLocs|
	|/locations/e4926d9e-0e16-11ed-bb27-0a0dcb939cfa|
	When GET LocationDetails is called
	Then results shouls have Details of location