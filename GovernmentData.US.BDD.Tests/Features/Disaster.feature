Feature: Disaster

A set of functionality that tests government disaster data services.

@disasterProperty
Scenario: A particular property is verified for disaster inclusion for a particular date
# DisasterDeclarationsSummaries?$filter=declarationDate ge '2010-01-01T04:00:00.000z' and state eq 'VA'
	Given the property is located at 5731 Da Vinci Way, Sacramento, CA 95835
	And the property is being analyzed between the dates 1/1/2024 and 2/9/2024
	When the property is verified for disaster inclusion
	Then the property is included in the disaster data
