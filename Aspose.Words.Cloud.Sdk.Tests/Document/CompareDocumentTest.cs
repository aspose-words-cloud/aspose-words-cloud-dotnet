// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="CompareDocumentTest.cs">
// //   Copyright (c) 2017 Aspose.Words for Cloud
// // </copyright>
// // <summary>
// //   Permission is hereby granted, free of charge, to any person obtaining a copy
// //  of this software and associated documentation files (the "Software"), to deal
// //  in the Software without restriction, including without limitation the rights
// //  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// //  copies of the Software, and to permit persons to whom the Software is
// //  furnished to do so, subject to the following conditions:
// // 
// //  The above copyright notice and this permission notice shall be included in all
// //  copies or substantial portions of the Software.
// // 
// //  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// //  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// //  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// //  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// //  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// //  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// //  SOFTWARE.
// // </summary>
// //  --------------------------------------------------------------------------------------------------------------------
namespace Aspose.Words.Cloud.Sdk.Tests.Document
{
    using System;
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Example of document comparison
    /// </summary>
    [TestClass]
    [DeploymentItem("TestData", "TestData")]
    public class CompareDocumentTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(BaseTestDataPath, "DocumentActions/CompareDocument");

        private readonly string compareFolder = "CompareDocument/";

        /// <summary>
        /// Test for document comparison
        /// </summary>
        [TestMethod]
        public void TestCompareDocument()
        {
            var localName1 = "compareTestDoc1.doc";
            var localName2 = "compareTestDoc2.doc";
            var remoteName1 = "TestCompareDocument1.doc";
            var remoteName2 = "TestCompareDocument2.doc";
            var fullName1 = Path.Combine(this.dataFolder, remoteName1);
            var fullName2 = Path.Combine(this.dataFolder, remoteName2);
            var destFileName = Path.Combine(BaseTestOutPath, "TestCompareDocumentOut.doc");
            var compareData = new CompareData { Author = "author", ComparingWithDocument = fullName2, DateTime = new DateTime(2015, 10, 26) };

            this.StorageApi.PutCreate(fullName1, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.compareFolder) + localName1));
            this.StorageApi.PutCreate(fullName2, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.compareFolder) + localName2));

            var request = new PostCompareDocumentRequest(remoteName1, compareData, this.dataFolder, destFileName: destFileName);
            var actual = this.WordsApi.PostCompareDocument(request);

            Assert.AreEqual(200, actual.Code);
        }
    }
}