// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AcceptAllRevisionsExample.cs">
//   Copyright (c) 2025 Aspose.Words for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Aspose.Words.Cloud.Sdk;
using Aspose.Words.Cloud.Sdk.Model;
using Aspose.Words.Cloud.Sdk.Model.Requests;
using NUnit.Framework;

[TestFixture]
public partial class ExampleTests
{
    [Test]
    public async Task ExampleAcceptAllRevisions()
    {
        var wordsApi = new WordsApi(config);
        var fileName = "test_doc.docx";

        // Upload original document to cloud storage.
        using var myVar1 = File.OpenRead(fileName);
        var myVar2 = fileName;
        var uploadFileRequest = new UploadFileRequest(myVar1, myVar2);
        await wordsApi.UploadFile(uploadFileRequest);

        // Calls AcceptAllRevisions method for document in cloud.
        var myVar3 = fileName;
        var request = new AcceptAllRevisionsRequest(myVar3);
        await wordsApi.AcceptAllRevisions(request);
    }
}