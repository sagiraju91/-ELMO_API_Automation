Feature: apileavetypes
	This covers Leave-Types GET API valication

@mytag
Scenario: GETapileavetypes
	Given the LeaveTypesAPI as
	|getLeaveTypes|
	|/leave-types|
	When the GET Leave Types is called
	Then results shouls have list of LeaveTypes