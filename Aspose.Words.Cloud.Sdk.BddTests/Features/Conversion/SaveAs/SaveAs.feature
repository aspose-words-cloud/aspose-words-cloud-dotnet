Feature: Stored document conversion with save result to storage
	In order to reuse document content for various purposes (such as read-only PDF distribution)
	A user should be able to convert Word document to different formats

@StoredDocConversionWithStorage
Scenario Outline: Convert document form storage and save to storage
	Given I have uploaded document with name <DocName> and subfoler is Conversion to storage
	And I have specified save format <DestFormat> document to be converted
	And I have specified document name <DocName> in URL
	And I have specified destFileName <OutPath>
	When I execute conversion from storage (POST SaveAs)
	Then document <OutPath> is existed on storage in subfolder Conversion
	And document from storage is downloadble
	
	Examples: 
	| DocName                  | DestFormat | OutPath                                     |
	| TableDocument.doc        | pdf        | out/saveus/TableDocumentPdf.pdf             |
	| test_doc.docx            | pdf        | out/saveus/test_docPdf.pdf                  |
	| test_doc.docx            | png        | out/saveus/test_docPng.pdf                  |
	| test_doc.docx            | html       | out/saveus/test_docHtml.html                |
	| TableDocument.doc        | html       | out/saveus/TableDocumentHtml.html           |
	| TableDocument.doc        | txt        | out/saveus/TableDocumentTxt.txt             |
	| TableDocument.doc        | htmlfixed  | out/saveus/TableDocumentHtmlfixed.htmlfixed |
	| TestEncodingDocument.txt | doc        | out/saveus/TableDocumentDoc.doc             |


@StoredDocConversionWithStorage
Scenario Outline: Convert document with specified encoding form storage and save to storage
	Given I have uploaded document with name <DocName> and subfoler is Conversion to storage
	And I have specified save format <DestFormat> document to be converted
	And I have specified document name <DocName> in URL
	And I have specified destFileName <OutPath>
	And I have specified encoding <LoadEncoding>
	When I execute conversion from storage (POST SaveAs)
	Then document <OutPath> is existed on storage in subfolder Conversion
	And document from storage is downloadble
	And symbols are encoded properly
	
	Examples: 
	| DocName                  | DestFormat | OutPath                         | LoadEncoding |
	| TestEncodingDocument.txt | doc        | out/saveus/TableDocumentDoc.doc | utf-16       |

@ConversionPdfToWord
Scenario Outline: Convert pdf document to word and save to storage
	Given I have uploaded document with name <DocName> and subfoler is Conversion to storage
	And I have specified save format <DestFormat> document to be converted
	And I have specified document name <DocName> in URL
	And I have specified destFileName <OutPath>
	When I execute conversion from storage (POST SaveAs)
	Then document <OutPath> is existed on storage in subfolder Conversion

	Examples: 
	| DocName                  | DestFormat | OutPath                                  |
	| awesome_table_in_pdf.pdf | docx       | out/saveus/awesome_table_in_pdfDocx.docx |
	| Delivery.pdf             | docx       | out/saveus/DeliveryDocx.docx             |
	| 45.pdf                   | docx       | out/saveus/45Docx.docx                   |