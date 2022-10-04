Feature: apipositiondetails
	This covers Positions GET API validation

@mytag
Scenario: GETapipositiondetails
	Given the PositionDetailsAPI as
	|getPositions|
	|/positions/367a93fc-0e17-11ed-af90-02f37fe20b40|
	When the GET PositionDetails is called
	Then results shouls have Details of Position