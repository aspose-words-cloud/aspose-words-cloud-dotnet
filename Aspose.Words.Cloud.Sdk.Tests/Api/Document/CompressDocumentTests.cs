// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CompressDocumentTests.cs">
//   Copyright (c) 2022 Aspose.Words for Cloud
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
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to compress document for reduce document size.
    /// </summary>
    [TestFixture]
    public class CompressDocumentTests : BaseTestContext
    {
        private readonly string remoteFolder = RemoteBaseTestDataFolder + "/DocumentActions/CompressDocument";
        private readonly string localFolder = "DocumentActions/CompressDocument";

        /// <summary>
        /// Test for compression document.
        /// </summary>
        [Test]
        public async Task TestCompressDocument()
        {
            string localName = "TestCompress.docx";
            string remoteName = "TestCompress.docx";

            await this.UploadFileToStorage(
                remoteFolder + "/" + remoteName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFolder + "/" + localName)
            );

            var requestCompressOptions = new CompressOptions()
            {
            };
            var request = new CompressDocumentRequest(
                name: remoteName,
                compressOptions: requestCompressOptions,
                folder: remoteFolder
            );
            var actual = await this.WordsApi.CompressDocument(request);
            Assert.NotNull(actual.Document);
        }

        /// <summary>
        /// Test for compression document online.
        /// </summary>
        [Test]
        public async Task TestCompressDocumentOnline()
        {
            string localName = "TestCompress.docx";

            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFolder + "/" + localName);
            var requestCompressOptions = new CompressOptions()
            {
            };
            var request = new CompressDocumentOnlineRequest(
                document: requestDocument,
                compressOptions: requestCompressOptions
            );
            var actual = await this.WordsApi.CompressDocumentOnline(request);
        }
    }
}
