Feature: Disaster

A set of functionality that tests government disaster data services.

@disasterProperty
Scenario: A particular property is verified for disaster inclusion
	Given the property is located at 5731 Da Vinci Way, Sacramento, CA 95835
	When the property is verified for disaster inclusion
	Then the property is included in the disaster data
