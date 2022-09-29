Feature: apilocations
	This covers Location GET API valication

@mytag
Scenario: GETapilocations
	Given the locationsAPI as
	|getLocs|
	|/locations|
	When the GET Locations is called
	Then results shouls have list of locations