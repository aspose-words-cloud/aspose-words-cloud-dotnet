// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ClassificationTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Document
{
    using System.Collections.Generic;
    using System.IO;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to classify text.
    /// </summary>
    [TestFixture]
    public class ClassificationTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/Common";
        private readonly string localFile = "Common/test_multi_pages.docx";

        /// <summary>
        /// Test for raw text classification.
        /// </summary>
        [Test]
        public void TestClassify()
        {
            var request = new ClassifyRequest(
                text: "Try text classification",
                bestClassesCount: "3"
            );

            var actual = this.WordsApi.Classify(request);
            Assert.AreEqual(true, actual.BestClassName.StartsWith("Science"));
            Assert.NotNull(actual.BestResults);
            Assert.AreEqual(3, actual.BestResults.Count);
        }

        /// <summary>
        /// Test for document classification.
        /// </summary>
        [Test]
        public void TestClassifyDocument()
        {
            string remoteFileName = "TestClassifyDocument.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new ClassifyDocumentRequest(
                documentName: remoteFileName,
                folder: remoteDataFolder,
                bestClassesCount: "3"
            );

            var actual = this.WordsApi.ClassifyDocument(request);
            Assert.AreEqual(true, actual.BestClassName.StartsWith("Hobbies_&_Interests"));
            Assert.NotNull(actual.BestResults);
            Assert.AreEqual(3, actual.BestResults.Count);
        }
    }
}
