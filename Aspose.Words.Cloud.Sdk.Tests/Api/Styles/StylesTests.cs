// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StylesTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Styles
{
    using System.Collections.Generic;
    using System.IO;
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
        public void TestGetStyles()
        {
            string remoteFileName = "TestGetStyles.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetStylesRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetStyles(request);
            Assert.NotNull(actual.Styles);
            Assert.AreEqual(22, actual.Styles.Count);
            Assert.AreEqual(true, actual.Styles[0].Name.StartsWith("Default Paragraph Font"));
        }

        /// <summary>
        /// Test for getting style from document.
        /// </summary>
        [Test]
        public void TestGetStyle()
        {
            string remoteFileName = "TestGetStyle.docx";

            this.UploadFileToStorage(
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

            var actual = this.WordsApi.GetStyle(request);
            Assert.NotNull(actual.Style);
            Assert.AreEqual(true, actual.Style.Name.StartsWith("Heading 1"));
        }

        /// <summary>
        /// Test for updating style from document.
        /// </summary>
        [Test]
        public void TestUpdateStyle()
        {
            string remoteFileName = "TestUpdateStyle.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new UpdateStyleRequest(
                name: remoteFileName,
                styleUpdate: new StyleUpdate()
                {
                    Name = "My Style"
                },
                styleName: "Heading 1",
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.UpdateStyle(request);
            Assert.NotNull(actual.Style);
            Assert.AreEqual(true, actual.Style.Name.StartsWith("My Style"));
        }

        /// <summary>
        /// Test for inserting style from document.
        /// </summary>
        [Test]
        public void TestInsertStyle()
        {
            string remoteFileName = "TestInsertStyle.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new InsertStyleRequest(
                name: remoteFileName,
                styleInsert: new StyleInsert()
                {
                    StyleName = "My Style",
                    StyleType = StyleInsert.StyleTypeEnum.Paragraph
                },
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.InsertStyle(request);
            Assert.NotNull(actual.Style);
            Assert.AreEqual(true, actual.Style.Name.StartsWith("My Style"));
        }

        /// <summary>
        /// Test for coping style from document.
        /// </summary>
        [Test]
        public void TestCopyStyle()
        {
            string remoteFileName = "TestCopyStyle.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new CopyStyleRequest(
                name: remoteFileName,
                styleCopy: new StyleCopy()
                {
                    StyleName = "Heading 1"
                },
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.CopyStyle(request);
            Assert.NotNull(actual.Style);
            Assert.AreEqual(true, actual.Style.Name.StartsWith("Heading 1_0"));
        }

        /// <summary>
        /// Test for getting style from document element.
        /// </summary>
        [Test]
        public void TestGetStyleFromDocumentElement()
        {
            string remoteFileName = "TestGetStyleFromDocumentElement.docx";

            this.UploadFileToStorage(
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

            var actual = this.WordsApi.GetStyleFromDocumentElement(request);
            Assert.NotNull(actual.Style);
            Assert.AreEqual(true, actual.Style.Name.StartsWith("TOC 1"));
        }

        /// <summary>
        /// Test for applying style to document element.
        /// </summary>
        [Test]
        public void TestApplyStyleToDocumentElement()
        {
            string remoteFileName = "TestApplyStyleToDocumentElement.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new ApplyStyleToDocumentElementRequest(
                name: remoteFileName,
                styleApply: new StyleApply()
                {
                    StyleName = "Heading 1"
                },
                styledNodePath: "paragraphs/1/paragraphFormat",
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.ApplyStyleToDocumentElement(request);
        }
    }
}
