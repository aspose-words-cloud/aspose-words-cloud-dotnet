// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FormFieldTests.cs">
//   Copyright (c) 2021 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Field
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with form field.
    /// </summary>
    [TestFixture]
    public class FormFieldTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/FormFields";
        private readonly string fieldFolder = "DocumentElements/FormFields";

        /// <summary>
        /// Test for posting form field.
        /// </summary>
        [Test]
        public async Task TestUpdateFormField()
        {
            string remoteFileName = "TestUpdateFormField.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + fieldFolder + "/FormFilled.docx")
            );

            var requestFormField = new FormFieldTextInput()
            {
                Name = "FullName",
                Enabled = true,
                CalculateOnExit = true,
                StatusText = "",
                TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular,
                TextInputDefault = "No name"
            };
            var request = new UpdateFormFieldRequest(
                name: remoteFileName,
                index: 0,
                formField: requestFormField,
                nodePath: "sections/0",
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = await this.WordsApi.UpdateFormField(request);
            Assert.NotNull(actual.FormField);
            Assert.AreEqual("FullName", actual.FormField.Name);
            Assert.AreEqual("", actual.FormField.StatusText);
        }

        /// <summary>
        /// Test for posting form field online.
        /// </summary>
        [Test]
        public async Task TestUpdateFormFieldOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + fieldFolder + "/FormFilled.docx");
            var requestFormField = new FormFieldTextInput()
            {
                Name = "FullName",
                Enabled = true,
                CalculateOnExit = true,
                StatusText = "",
                TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular,
                TextInputDefault = "No name"
            };
            var request = new UpdateFormFieldOnlineRequest(
                document: requestDocument,
                formField: requestFormField,
                index: 0,
                nodePath: "sections/0"
            );
            var actual = await this.WordsApi.UpdateFormFieldOnline(request);
        }

        /// <summary>
        /// Test for posting form field without node path.
        /// </summary>
        [Test]
        public async Task TestUpdateFormFieldWithoutNodePath()
        {
            string remoteFileName = "TestUpdateFormFieldWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + fieldFolder + "/FormFilled.docx")
            );

            var requestFormField = new FormFieldTextInput()
            {
                Name = "FullName",
                Enabled = true,
                CalculateOnExit = true,
                StatusText = "",
                TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular,
                TextInputDefault = "No name"
            };
            var request = new UpdateFormFieldRequest(
                name: remoteFileName,
                index: 0,
                formField: requestFormField,
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = await this.WordsApi.UpdateFormField(request);
            Assert.NotNull(actual.FormField);
            Assert.AreEqual("FullName", actual.FormField.Name);
            Assert.AreEqual("", actual.FormField.StatusText);
        }

        /// <summary>
        /// Test for getting form field.
        /// </summary>
        [Test]
        public async Task TestGetFormField()
        {
            string remoteFileName = "TestGetFormField.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + fieldFolder + "/FormFilled.docx")
            );

            var request = new GetFormFieldRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "sections/0",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetFormField(request);
            Assert.NotNull(actual.FormField);
            Assert.AreEqual("FullName", actual.FormField.Name);
        }

        /// <summary>
        /// Test for getting form field online.
        /// </summary>
        [Test]
        public async Task TestGetFormFieldOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + fieldFolder + "/FormFilled.docx");
            var request = new GetFormFieldOnlineRequest(
                document: requestDocument,
                index: 0,
                nodePath: "sections/0"
            );
            var actual = await this.WordsApi.GetFormFieldOnline(request);
        }

        /// <summary>
        /// Test for getting form field without node path.
        /// </summary>
        [Test]
        public async Task TestGetFormFieldWithoutNodePath()
        {
            string remoteFileName = "TestGetFormFieldWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + fieldFolder + "/FormFilled.docx")
            );

            var request = new GetFormFieldRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetFormField(request);
            Assert.NotNull(actual.FormField);
            Assert.AreEqual("FullName", actual.FormField.Name);
        }

        /// <summary>
        /// Test for getting form fields.
        /// </summary>
        [Test]
        public async Task TestGetFormFields()
        {
            string remoteFileName = "TestGetFormFields.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + fieldFolder + "/FormFilled.docx")
            );

            var request = new GetFormFieldsRequest(
                name: remoteFileName,
                nodePath: "sections/0",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetFormFields(request);
            Assert.NotNull(actual.FormFields);
            Assert.NotNull(actual.FormFields.List);
            Assert.AreEqual(5, actual.FormFields.List.Count);
            Assert.AreEqual("FullName", actual.FormFields.List[0].Name);
        }

        /// <summary>
        /// Test for getting form fields online.
        /// </summary>
        [Test]
        public async Task TestGetFormFieldsOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + fieldFolder + "/FormFilled.docx");
            var request = new GetFormFieldsOnlineRequest(
                document: requestDocument,
                nodePath: "sections/0"
            );
            var actual = await this.WordsApi.GetFormFieldsOnline(request);
        }

        /// <summary>
        /// Test for getting form fields without node path.
        /// </summary>
        [Test]
        public async Task TestGetFormFieldsWithoutNodePath()
        {
            string remoteFileName = "TestGetFormFieldsWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + fieldFolder + "/FormFilled.docx")
            );

            var request = new GetFormFieldsRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetFormFields(request);
            Assert.NotNull(actual.FormFields);
            Assert.NotNull(actual.FormFields.List);
            Assert.AreEqual(5, actual.FormFields.List.Count);
            Assert.AreEqual("FullName", actual.FormFields.List[0].Name);
        }

        /// <summary>
        /// Test for insert form field without node path.
        /// </summary>
        [Test]
        public async Task TestInsertFormField()
        {
            string remoteFileName = "TestInsertFormField.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "Common/test_multi_pages.docx")
            );

            var requestFormField = new FormFieldTextInput()
            {
                Name = "FullName",
                Enabled = true,
                CalculateOnExit = true,
                StatusText = "",
                TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular,
                TextInputDefault = "123",
                TextInputFormat = "UPPERCASE"
            };
            var request = new InsertFormFieldRequest(
                name: remoteFileName,
                formField: requestFormField,
                nodePath: "sections/0/paragraphs/0",
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = await this.WordsApi.InsertFormField(request);
            Assert.NotNull(actual.FormField);
            Assert.AreEqual("FullName", actual.FormField.Name);
            Assert.AreEqual("", actual.FormField.StatusText);
        }

        /// <summary>
        /// Test for insert form field without node path online.
        /// </summary>
        [Test]
        public async Task TestInsertFormFieldOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + fieldFolder + "/FormFilled.docx");
            var requestFormField = new FormFieldTextInput()
            {
                Name = "FullName",
                Enabled = true,
                CalculateOnExit = true,
                StatusText = "",
                TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular,
                TextInputDefault = "123",
                TextInputFormat = "UPPERCASE"
            };
            var request = new InsertFormFieldOnlineRequest(
                document: requestDocument,
                formField: requestFormField,
                nodePath: "sections/0/paragraphs/0"
            );
            var actual = await this.WordsApi.InsertFormFieldOnline(request);
        }

        /// <summary>
        /// Test for insert form field without node path.
        /// </summary>
        [Test]
        public async Task TestInsertFormFieldWithoutNodePath()
        {
            string remoteFileName = "TestInsertFormFieldWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "Common/test_multi_pages.docx")
            );

            var requestFormField = new FormFieldTextInput()
            {
                Name = "FullName",
                Enabled = true,
                CalculateOnExit = true,
                StatusText = "",
                TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular,
                TextInputDefault = "123",
                TextInputFormat = "UPPERCASE"
            };
            var request = new InsertFormFieldRequest(
                name: remoteFileName,
                formField: requestFormField,
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = await this.WordsApi.InsertFormField(request);
            Assert.NotNull(actual.FormField);
            Assert.AreEqual("FullName", actual.FormField.Name);
            Assert.AreEqual("", actual.FormField.StatusText);
        }

        /// <summary>
        /// Test for deleting form field.
        /// </summary>
        [Test]
        public async Task TestDeleteFormField()
        {
            string remoteFileName = "TestDeleteFormField.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + fieldFolder + "/FormFilled.docx")
            );

            var request = new DeleteFormFieldRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "sections/0",
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
        await this.WordsApi.DeleteFormField(request);
        }

        /// <summary>
        /// Test for deleting form field online.
        /// </summary>
        [Test]
        public async Task TestDeleteFormFieldOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + fieldFolder + "/FormFilled.docx");
            var request = new DeleteFormFieldOnlineRequest(
                document: requestDocument,
                index: 0,
                nodePath: "sections/0"
            );
            var actual = await this.WordsApi.DeleteFormFieldOnline(request);
        }

        /// <summary>
        /// Test for deleting form field without node path.
        /// </summary>
        [Test]
        public async Task TestDeleteFormFieldWithoutNodePath()
        {
            string remoteFileName = "TestDeleteFormFieldWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + fieldFolder + "/FormFilled.docx")
            );

            var request = new DeleteFormFieldRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
        await this.WordsApi.DeleteFormField(request);
        }
    }
}
