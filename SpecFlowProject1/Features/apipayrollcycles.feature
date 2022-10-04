Feature: apipayrollcycles
	This covers PayrollCycles GET API valication

@mytag
Scenario: GETapipayrollcycles
	Given the PayrollCyclesAPI as
	|getPayrollCycles|
	|/payroll-cycles|
	When the GET PayrollCycles is called
	Then results should have list of PayrollCycles