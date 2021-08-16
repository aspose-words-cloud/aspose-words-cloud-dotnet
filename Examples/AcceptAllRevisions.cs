using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Words.Cloud.Sdk;
using Aspose.Words.Cloud.Sdk.Model;
using Aspose.Words.Cloud.Sdk.Model.Requests;

var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var fileName  = "test_doc.docx";

// Upload original document to cloud storage.
using var myVar1 = File.OpenRead(fileName);
var myVar2 = fileName;
var uploadFileRequest = new UploadFileRequest(myVar1, myVar2);
wordsApi.UploadFile(uploadFileRequest);

// Calls AcceptAllRevisions method for document in cloud.
var myVar3 = fileName;
var request = new AcceptAllRevisionsRequest(myVar3);
wordsApi.AcceptAllRevisions(request);