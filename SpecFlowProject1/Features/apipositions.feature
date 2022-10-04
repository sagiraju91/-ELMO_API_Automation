Feature: apipositions
	This covers Positions GET API valication

@mytag
Scenario: GETapipositions
	Given the PositionsAPI as
	|getPositions|
	|/positions|
	When the GET Positions is called
	Then results shouls have list of Positions