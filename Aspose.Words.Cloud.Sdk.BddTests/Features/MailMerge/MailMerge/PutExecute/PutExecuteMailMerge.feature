Feature: PutExecuteMailMerge
	In order to create personalized documents a user
	should be able to perform mail merge

@PutExecuteMailMerge
Scenario Outline: Execute Mail Merge With Data File
	Given I have specified a template file <TemplateName> with mustache syntax
	And I have specified a data file <Body>
	When I execute mail merge online
	Then document with merged values should be created

	Examples: 
	| TemplateName            | Body                        |
	| TestExecuteTemplate.doc | TestExecuteTemplateData.txt |
