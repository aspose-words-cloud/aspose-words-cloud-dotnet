// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="LoadWebDocumentTest.cs">
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
// // --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Words.Cloud.Sdk.Tests.Document
{
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Example of how to load web document
    /// </summary>
    [TestClass]
    public class LoadWebDocumentTest : BaseTestContext
    {
        /// <summary>
        /// Test for loading web document
        /// </summary>
        [TestMethod]
        public void TestPostLoadWebDocument()
        {
            var body = new LoadWebDocumentData();
            var saveOptions = new SaveOptionsData
                               {
                                   FileName = "google.doc",
                                   SaveFormat = "doc",
                                   ColorMode = "1",
                                   DmlEffectsRenderingMode = "1",
                                   DmlRenderingMode = "1",
                                   UpdateSdtContent = false,
                                   ZipOutput = false
                               };

            body.LoadingDocumentUrl = "http://google.com";
            body.SaveOptions = saveOptions;

            var request = new PostLoadWebDocumentRequest(body);
            var actual = this.WordsApi.PostLoadWebDocument(request);

            Assert.AreEqual(200, actual.Code);
        }
    }
}