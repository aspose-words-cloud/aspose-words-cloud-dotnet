using System;
using System.IO;
using Aspose.Words.Cloud.Sdk;
using Aspose.Words.Cloud.Sdk.Model;
using Aspose.Words.Cloud.Sdk.Model.Requests;

var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var fileName  = "test_doc.docx";

// Upload original document to cloud storage.
using var requestFileContentStream = File.OpenRead(fileName);
var uploadFileRequest = new UploadFileRequest(requestFileContentStream, fileName);
wordsApi.UploadFile(uploadFileRequest);

// Calls AcceptAllRevisions method for document in cloud.
var request = new AcceptAllRevisionsRequest(fileName);
wordsApi.AcceptAllRevisions(request);