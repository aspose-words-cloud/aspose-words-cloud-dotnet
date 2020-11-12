// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MailMergeFiledsTests.cs">
//   Copyright (c) 2020 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.MailMerge
{
    using System.Collections.Generic;
    using System.IO;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with merge fields.
    /// </summary>
    [TestFixture]
    public class MailMergeFiledsTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentActions/MailMerge";
        private readonly string mailMergeFolder = "DocumentActions/MailMerge";

        /// <summary>
        /// Test for putting new fields.
        /// </summary>
        [Test]
        public void TestGetDocumentFieldNamesOnline()
        {
            string localDocumentFile = "SampleExecuteTemplate.docx";

            var request = new GetDocumentFieldNamesOnlineRequest(
                template: File.OpenRead(LocalTestDataFolder + mailMergeFolder + "/" + localDocumentFile),
                useNonMergeFields: true
            );

            var actual = this.WordsApi.GetDocumentFieldNamesOnline(request);
            Assert.NotNull(actual.FieldNames);
            Assert.NotNull(actual.FieldNames.Names);
            Assert.AreEqual(15, actual.FieldNames.Names.Count);
            Assert.AreEqual("TableStart:Order", actual.FieldNames.Names[0]);
        }

        /// <summary>
        /// Test for getting mailmerge fields.
        /// </summary>
        [Test]
        public void TestGetDocumentFieldNames()
        {
            string remoteFileName = "TestGetDocumentFieldNames.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "Common/test_multi_pages.docx")
            );

            var request = new GetDocumentFieldNamesRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetDocumentFieldNames(request);
            Assert.NotNull(actual.FieldNames);
            Assert.NotNull(actual.FieldNames.Names);
            Assert.AreEqual(0, actual.FieldNames.Names.Count);
        }
    }
}
