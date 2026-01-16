// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StylesTests.cs">
//   Copyright (c) 2026 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Styles
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with styles.
    /// </summary>
    [TestFixture]
    public class StylesTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/Styles";
        private readonly string localFile = "DocumentElements/Styles/GetStyles.docx";

        /// <summary>
        /// Test for getting styles from document.
        /// </summary>
        [Test]
        public async Task TestGetStyles()
        {
            string remoteFileName = "TestGetStyles.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetStylesRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetStyles(request);
            Assert.NotNull(actual.Styles);
            Assert.AreEqual(22, actual.Styles.Count);
            Assert.AreEqual("Default Paragraph Font", actual.Styles[0].Name);
        }

        /// <summary>
        /// Test for getting styles from document online.
        /// </summary>
        [Test]
        public async Task TestGetStylesOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetStylesOnlineRequest(
                document: requestDocument
            );
            var actual = await this.WordsApi.GetStylesOnline(request);
        }

        /// <summary>
        /// Test for getting style from document.
        /// </summary>
        [Test]
        public async Task TestGetStyle()
        {
            string remoteFileName = "TestGetStyle.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetStyleRequest(
                name: remoteFileName,
                styleName: "Heading 1",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetStyle(request);
            Assert.NotNull(actual.Style);
            Assert.AreEqual("Heading 1", actual.Style.Name);
        }

        /// <summary>
        /// Test for getting style from document online.
        /// </summary>
        [Test]
        public async Task TestGetStyleOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetStyleOnlineRequest(
                document: requestDocument,
                styleName: "Heading 1"
            );
            var actual = await this.WordsApi.GetStyleOnline(request);
        }

        /// <summary>
        /// Test for updating style from document.
        /// </summary>
        [Test]
        public async Task TestUpdateStyle()
        {
            string remoteFileName = "TestUpdateStyle.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestStyleUpdate = new StyleUpdate()
            {
                Name = "My Style"
            };
            var request = new UpdateStyleRequest(
                name: remoteFileName,
                styleName: "Heading 1",
                styleUpdate: requestStyleUpdate,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.UpdateStyle(request);
            Assert.NotNull(actual.Style);
            Assert.AreEqual("My Style", actual.Style.Name);
        }

        /// <summary>
        /// Test for updating style from document online.
        /// </summary>
        [Test]
        public async Task TestUpdateStyleOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestStyleUpdate = new StyleUpdate()
            {
                Name = "My Style"
            };
            var request = new UpdateStyleOnlineRequest(
                document: requestDocument,
                styleName: "Heading 1",
                styleUpdate: requestStyleUpdate
            );
            var actual = await this.WordsApi.UpdateStyleOnline(request);
        }

        /// <summary>
        /// Test for inserting style from document.
        /// </summary>
        [Test]
        public async Task TestInsertStyle()
        {
            string remoteFileName = "TestInsertStyle.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestStyleInsert = new StyleInsert()
            {
                StyleName = "My Style",
                StyleType = StyleInsert.StyleTypeEnum.Paragraph
            };
            var request = new InsertStyleRequest(
                name: remoteFileName,
                styleInsert: requestStyleInsert,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.InsertStyle(request);
            Assert.NotNull(actual.Style);
            Assert.AreEqual("My Style", actual.Style.Name);
        }

        /// <summary>
        /// Test for inserting style from document online.
        /// </summary>
        [Test]
        public async Task TestInsertStyleOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestStyleInsert = new StyleInsert()
            {
                StyleName = "My Style",
                StyleType = StyleInsert.StyleTypeEnum.Paragraph
            };
            var request = new InsertStyleOnlineRequest(
                document: requestDocument,
                styleInsert: requestStyleInsert
            );
            var actual = await this.WordsApi.InsertStyleOnline(request);
        }

        /// <summary>
        /// Test for coping style from document.
        /// </summary>
        [Test]
        public async Task TestCopyStyle()
        {
            string remoteFileName = "TestCopyStyle.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestStyleCopy = new StyleCopy()
            {
                StyleName = "Heading 1"
            };
            var request = new CopyStyleRequest(
                name: remoteFileName,
                styleCopy: requestStyleCopy,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.CopyStyle(request);
            Assert.NotNull(actual.Style);
            Assert.AreEqual("Heading 1_0", actual.Style.Name);
        }

        /// <summary>
        /// Test for coping style from document online.
        /// </summary>
        [Test]
        public async Task TestCopyStyleOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestStyleCopy = new StyleCopy()
            {
                StyleName = "Heading 1"
            };
            var request = new CopyStyleOnlineRequest(
                document: requestDocument,
                styleCopy: requestStyleCopy
            );
            var actual = await this.WordsApi.CopyStyleOnline(request);
        }

        /// <summary>
        /// Test for getting style from document element.
        /// </summary>
        [Test]
        public async Task TestGetStyleFromDocumentElement()
        {
            string remoteFileName = "TestGetStyleFromDocumentElement.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetStyleFromDocumentElementRequest(
                name: remoteFileName,
                styledNodePath: "paragraphs/1/paragraphFormat",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetStyleFromDocumentElement(request);
            Assert.NotNull(actual.Style);
            Assert.AreEqual("TOC 1", actual.Style.Name);
        }

        /// <summary>
        /// Test for getting style from document element online.
        /// </summary>
        [Test]
        public async Task TestGetStyleFromDocumentElementOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetStyleFromDocumentElementOnlineRequest(
                document: requestDocument,
                styledNodePath: "paragraphs/1/paragraphFormat"
            );
            var actual = await this.WordsApi.GetStyleFromDocumentElementOnline(request);
        }

        /// <summary>
        /// Test for applying style to document element.
        /// </summary>
        [Test]
        public async Task TestApplyStyleToDocumentElement()
        {
            string remoteFileName = "TestApplyStyleToDocumentElement.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestStyleApply = new StyleApply()
            {
                StyleName = "Heading 1"
            };
            var request = new ApplyStyleToDocumentElementRequest(
                name: remoteFileName,
                styledNodePath: "paragraphs/1/paragraphFormat",
                styleApply: requestStyleApply,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.ApplyStyleToDocumentElement(request);
        }

        /// <summary>
        /// Test for applying style to document element online.
        /// </summary>
        [Test]
        public async Task TestApplyStyleToDocumentElementOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestStyleApply = new StyleApply()
            {
                StyleName = "Heading 1"
            };
            var request = new ApplyStyleToDocumentElementOnlineRequest(
                document: requestDocument,
                styledNodePath: "paragraphs/1/paragraphFormat",
                styleApply: requestStyleApply
            );
            var actual = await this.WordsApi.ApplyStyleToDocumentElementOnline(request);
        }

        /// <summary>
        /// Test for copying styles from a template.
        /// </summary>
        [Test]
        public async Task TestCopyStylesFromTemplate()
        {
            string remoteFileName = "TestCopyStylesFromTemplate.docx";
            string templateFolder = "DocumentElements/Styles";
            string templateName = "StyleTemplate.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );
            await this.UploadFileToStorage(
                remoteDataFolder + "/" + templateName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + templateFolder + "/" + templateName)
            );

            var request = new CopyStylesFromTemplateRequest(
                name: remoteFileName,
                templateName: templateName,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.CopyStylesFromTemplate(request);
        }
    }
}
