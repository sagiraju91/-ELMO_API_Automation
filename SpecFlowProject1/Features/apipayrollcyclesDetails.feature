Feature: apipayrollcyclesdetails
	This covers PayrollCyclesDetails GET API valication

@mytag
Scenario: GETapipayrollcyclesDetails
	Given the PayrollCyclesDetailsAPI as
	|getPayrollCycles|
	|/payroll-cycles/82146120-82b6-11ea-bca8-020963fd5938|
	When the GET PayrollCyclesDetails is called
	Then results should have Details of PayrollCycles