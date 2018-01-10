Feature: PutExecuteTemplate execute template without saving
	In order to create personalized documents a user
	should be able to perform mail merge

@PutExecuteTemplate
Scenario Outline: Execute Template
	Given I have specified a template file <TemplateName> with mustache syntax
	And I have specified a data file <Body>
	When I execute template online
	Then document with merged values should be created

	Examples: 
	| TemplateName                      | Body                             |
	| TestExecuteTemplate.doc           | TestExecuteTemplateData.txt      |
	| TestExecuteTemplateTextFormat.doc | TestDataWithTextInHtmlFormat.xml |

@PutExecuteTemplate
Scenario Outline: Execute Template With Images
	Given I have specified a template file <TemplateName> with mustache syntax
	And I have specified a data file <Body>
	When I execute template online
	Then document with merged values should be created
	And image should be rendered

	Examples: 
	| TemplateName                      | Body                         |
	| TestExecuteTemplateWithImages.doc | TestDataWithRemoteImages.xml |

@PutExecuteTemplate
Scenario Outline: Execute Template With Cleanup Options
	Given I have specified a template file <TemplateName> with mustache syntax
	And I have specified a data file <Body>
	And I have specified a cleanup option <Cleanup>
	When I execute template online
	Then document with merged values should be created
	And unused option is cleaned up

	Examples: 
	| TemplateName                        | Body                       | Cleanup         |
	| TestMailMergeWithCleanupOptions.doc | TestCleanupOptionsData.xml | UnusedRegions   |
	| TestMailMergeWithCleanupOptions.doc | TestCleanupOptionsData.xml | UnusedFields    |
	| TestMailMergeWithCleanupOptions.doc | TestCleanupOptionsData.xml | EmptyParagraphs |
