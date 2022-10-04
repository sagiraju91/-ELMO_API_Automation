Feature: apileavetypeDetails
	This covers Leave-Types Details GET API valication

@mytag
Scenario: GETapileavetypesdetails
	Given the LeaveTypesDetailsAPI as
	|getLeaveTypes|
	|/leave-types/0609057f-5937-11eb-a2d3-0ab07bdabd6c|
	When the GET Leave Types Details is called
	Then results shoulds have Details of LeaveTypes