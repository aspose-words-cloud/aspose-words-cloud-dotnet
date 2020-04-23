// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="StylesTests.cs">
// //   Copyright (c) 2019 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.Tests.Styles
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
    /// Range related tests
    /// </summary>
    [TestFixture]
    public class StylesTests : BaseTestContext
    {
        private readonly string localDataFolder = "DocumentElements/Styles/";
        private readonly string remoteDataFolder = Path.Combine(RemoteBaseTestDataFolder, "DocumentElements/Styles/");
        private readonly string localName = "GetStyles.docx";

        /// <summary>
        /// Test for getting styles from document.
        /// </summary>
        [Test]
        public void GetStyles()
        {
            var remoteName = "TestGetStyles.docx";
            var fullName = Path.Combine(this.remoteDataFolder, remoteName);
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.localDataFolder) + localName));

            var request = new GetStylesRequest(remoteName, folder: this.remoteDataFolder);
            var respose = this.WordsApi.GetStyles(request);
            Assert.NotNull(respose);
        }

        /// <summary>
        /// Test for getting style from document.
        /// </summary>
        [Test]
        public void GetStyle()
        {
            var remoteName = "TestGetStyle.docx";
            var fullName = Path.Combine(this.remoteDataFolder, remoteName);
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.localDataFolder) + localName));

            var request = new GetStyleRequest(remoteName, "Heading 1", folder: this.remoteDataFolder);
            var respose = this.WordsApi.GetStyle(request);
            Assert.NotNull(respose);
        }

        /// <summary>
        /// Test for updating style from document.
        /// </summary>
        [Test]
        public void UpdateStyle()
        {
            var remoteName = "TestUpdateStyle.docx";
            var fullName = Path.Combine(this.remoteDataFolder, remoteName);
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.localDataFolder) + localName));

            var data = new StyleUpdate();
            data.Name = "My Style";

            var request = new UpdateStyleRequest(remoteName, data, "Heading 1", folder: this.remoteDataFolder);
            var respose = this.WordsApi.UpdateStyle(request);
            Assert.NotNull(respose);
        }

        /// <summary>
        /// Test for inserting style from document.
        /// </summary>
        [Test]
        public void InsertStyle()
        {
            var remoteName = "TestInsertStyle.docx";
            var fullName = Path.Combine(this.remoteDataFolder, remoteName);
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.localDataFolder) + localName));

            var data = new StyleInsert();
            data.StyleName = "My Style";
            data.StyleType = StyleInsert.StyleTypeEnum.Paragraph;

            var request = new InsertStyleRequest(remoteName, data, folder: this.remoteDataFolder);
            var respose = this.WordsApi.InsertStyle(request);
            Assert.NotNull(respose);
        }

        /// <summary>
        /// Test for coping style from document.
        /// </summary>
        [Test]
        public void CopyStyle()
        {
            var remoteName = "TestCopyStyle.docx";
            var fullName = Path.Combine(this.remoteDataFolder, remoteName);
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.localDataFolder) + localName));

            var data = new StyleCopy();
            data.StyleName = "Heading 1";

            var request = new CopyStyleRequest(remoteName, data, folder: this.remoteDataFolder);
            var respose = this.WordsApi.CopyStyle(request);
            Assert.NotNull(respose);
        }

        /// <summary>
        /// Test for getting style from document element.
        /// </summary>
        [Test]
        public void GetStyleFromDocumentElement()
        {
            var remoteName = "TestGetStyleFromDocumentElement.docx";
            var fullName = Path.Combine(this.remoteDataFolder, remoteName);
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.localDataFolder) + localName));

            var request = new GetStyleFromDocumentElementRequest(remoteName, "paragraphs/1/paragraphFormat", folder: this.remoteDataFolder);
            var respose = this.WordsApi.GetStyleFromDocumentElement(request);
            Assert.NotNull(respose);
        }

        /// <summary>
        /// Test for applying style to document element.
        /// </summary>
        [Test]
        public void ApplyStyleToDocumentElement()
        {
            var remoteName = "TestApplyStyleToDocumentElement.docx";
            var fullName = Path.Combine(this.remoteDataFolder, remoteName);
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.localDataFolder) + localName));

            var data = new StyleApply();
            data.StyleName = "Heading 1";

            var request = new ApplyStyleToDocmentElementRequest(remoteName, data, "paragraphs/1/paragraphFormat", folder: this.remoteDataFolder);
            var respose = this.WordsApi.ApplyStyleToDocmentElement(request);
            Assert.NotNull(respose);
        }
    }
}
