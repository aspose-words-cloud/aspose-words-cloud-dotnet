Feature: Stored document conversion with return result in response
	In order to reuse document content for various purposes (such as read-only PDF distribution)
	A user should be able to convert Word document to different formats

@ConversionOfStoredDoc
Scenario Outline: Conversion of stored document
	Given I have uploaded document with name <DocName> and subfoler is Conversion to storage
	And I have specified format <DestFormat> document to be converted
	And I have specified document name <DocName> in URL
	When I execute conversion from storage (GET document with format)
	Then document is returned as an attachment
	And attachment's format is <DestFormat>

	Examples: 
	| DocName           | DestFormat |
	| TableDocument.doc | pdf        |
	| test_doc.docx     | pdf        |
	| test_doc.docx     | png        |
	| test_doc.docx     | html       |
	| TableDocument.doc | html       |
	| TableDocument.doc | txt        |
	| TableDocument.doc | htmlfixed  |	


@ConversionOfStoredDoc
Scenario Outline: Conversion of stored document and save to storage
	Given I have uploaded document with name <DocName> and subfoler is Conversion to storage
	And I have specified format <DestFormat> document to be converted
	And I have specified output path <OutPath>
	And I have specified document name <DocName> in URL
	When I execute conversion from storage (GET document with format)
	Then converted document downloads from storage

	Examples: 
	| DocName           | DestFormat | OutPath                                  |
	| TableDocument.doc | pdf        | out/getalternate/TableDocument.pdf       |
	| test_doc.docx     | pdf        | out/getalternate/test_doc.pdf            |
	| test_doc.docx     | png        | out/getalternate/test_doc.png            |
	| test_doc.docx     | html       | out/getalternate/test_doc.html           |
	| TableDocument.doc | html       | out/getalternate/TableDocument.html      |
	| TableDocument.doc | txt        | out/getalternate/TableDocument.txt       |
	| TableDocument.doc | htmlfixed  | out/getalternate/TableDocument.htmlfixed |