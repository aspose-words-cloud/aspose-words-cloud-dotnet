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
        public void TestUpdateFormField()
        {
            string remoteFileName = "TestUpdateFormField.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + fieldFolder + "/FormFilled.docx")
            );

            var request = new UpdateFormFieldRequest(
                name: remoteFileName,
                index: 0,
                formField: new FormFieldTextInput()
                {
                    Name = "FullName",
                    Enabled = true,
                    CalculateOnExit = true,
                    StatusText = "",
                    TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular,
                    TextInputDefault = "No name"
                },
                nodePath: "sections/0",
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = this.WordsApi.UpdateFormField(request);
            Assert.NotNull(actual.FormField);
            Assert.AreEqual("FullName", actual.FormField.Name);
            Assert.AreEqual("", actual.FormField.StatusText);
        }

        /// <summary>
        /// Test for posting form field online.
        /// </summary>
        [Test]
        public void TestUpdateFormFieldOnline()
        {
            using var documentStream = File.OpenRead(LocalTestDataFolder + fieldFolder + "/FormFilled.docx");
            var request = new UpdateFormFieldOnlineRequest(
                document: documentStream,
                formField: new FormFieldTextInput()
                {
                    Name = "FullName",
                    Enabled = true,
                    CalculateOnExit = true,
                    StatusText = "",
                    TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular,
                    TextInputDefault = "No name"
                },
                index: 0,
                nodePath: "sections/0"
            );
            var actual = this.WordsApi.UpdateFormFieldOnline(request);
        }

        /// <summary>
        /// Test for posting form field without node path.
        /// </summary>
        [Test]
        public void TestUpdateFormFieldWithoutNodePath()
        {
            string remoteFileName = "TestUpdateFormFieldWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + fieldFolder + "/FormFilled.docx")
            );

            var request = new UpdateFormFieldRequest(
                name: remoteFileName,
                index: 0,
                formField: new FormFieldTextInput()
                {
                    Name = "FullName",
                    Enabled = true,
                    CalculateOnExit = true,
                    StatusText = "",
                    TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular,
                    TextInputDefault = "No name"
                },
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = this.WordsApi.UpdateFormField(request);
            Assert.NotNull(actual.FormField);
            Assert.AreEqual("FullName", actual.FormField.Name);
            Assert.AreEqual("", actual.FormField.StatusText);
        }

        /// <summary>
        /// Test for getting form field.
        /// </summary>
        [Test]
        public void TestGetFormField()
        {
            string remoteFileName = "TestGetFormField.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.GetFormField(request);
            Assert.NotNull(actual.FormField);
            Assert.AreEqual("FullName", actual.FormField.Name);
        }

        /// <summary>
        /// Test for getting form field online.
        /// </summary>
        [Test]
        public void TestGetFormFieldOnline()
        {
            using var documentStream = File.OpenRead(LocalTestDataFolder + fieldFolder + "/FormFilled.docx");
            var request = new GetFormFieldOnlineRequest(
                document: documentStream,
                index: 0,
                nodePath: "sections/0"
            );
            var actual = this.WordsApi.GetFormFieldOnline(request);
        }

        /// <summary>
        /// Test for getting form field without node path.
        /// </summary>
        [Test]
        public void TestGetFormFieldWithoutNodePath()
        {
            string remoteFileName = "TestGetFormFieldWithoutNodePath.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.GetFormField(request);
            Assert.NotNull(actual.FormField);
            Assert.AreEqual("FullName", actual.FormField.Name);
        }

        /// <summary>
        /// Test for getting form fields.
        /// </summary>
        [Test]
        public void TestGetFormFields()
        {
            string remoteFileName = "TestGetFormFields.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.GetFormFields(request);
            Assert.NotNull(actual.FormFields);
            Assert.NotNull(actual.FormFields.List);
            Assert.AreEqual(5, actual.FormFields.List.Count);
            Assert.AreEqual("FullName", actual.FormFields.List[0].Name);
        }

        /// <summary>
        /// Test for getting form fields online.
        /// </summary>
        [Test]
        public void TestGetFormFieldsOnline()
        {
            using var documentStream = File.OpenRead(LocalTestDataFolder + fieldFolder + "/FormFilled.docx");
            var request = new GetFormFieldsOnlineRequest(
                document: documentStream,
                nodePath: "sections/0"
            );
            var actual = this.WordsApi.GetFormFieldsOnline(request);
        }

        /// <summary>
        /// Test for getting form fields without node path.
        /// </summary>
        [Test]
        public void TestGetFormFieldsWithoutNodePath()
        {
            string remoteFileName = "TestGetFormFieldsWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + fieldFolder + "/FormFilled.docx")
            );

            var request = new GetFormFieldsRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.GetFormFields(request);
            Assert.NotNull(actual.FormFields);
            Assert.NotNull(actual.FormFields.List);
            Assert.AreEqual(5, actual.FormFields.List.Count);
            Assert.AreEqual("FullName", actual.FormFields.List[0].Name);
        }

        /// <summary>
        /// Test for insert form field without node path.
        /// </summary>
        [Test]
        public void TestInsertFormField()
        {
            string remoteFileName = "TestInsertFormField.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "Common/test_multi_pages.docx")
            );

            var request = new InsertFormFieldRequest(
                name: remoteFileName,
                formField: new FormFieldTextInput()
                {
                    Name = "FullName",
                    Enabled = true,
                    CalculateOnExit = true,
                    StatusText = "",
                    TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular,
                    TextInputDefault = "123",
                    TextInputFormat = "UPPERCASE"
                },
                nodePath: "sections/0/paragraphs/0",
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = this.WordsApi.InsertFormField(request);
            Assert.NotNull(actual.FormField);
            Assert.AreEqual("FullName", actual.FormField.Name);
            Assert.AreEqual("", actual.FormField.StatusText);
        }

        /// <summary>
        /// Test for insert form field without node path online.
        /// </summary>
        [Test]
        public void TestInsertFormFieldOnline()
        {
            using var documentStream = File.OpenRead(LocalTestDataFolder + fieldFolder + "/FormFilled.docx");
            var request = new InsertFormFieldOnlineRequest(
                document: documentStream,
                formField: new FormFieldTextInput()
                {
                    Name = "FullName",
                    Enabled = true,
                    CalculateOnExit = true,
                    StatusText = "",
                    TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular,
                    TextInputDefault = "123",
                    TextInputFormat = "UPPERCASE"
                },
                nodePath: "sections/0/paragraphs/0"
            );
            var actual = this.WordsApi.InsertFormFieldOnline(request);
        }

        /// <summary>
        /// Test for insert form field without node path.
        /// </summary>
        [Test]
        public void TestInsertFormFieldWithoutNodePath()
        {
            string remoteFileName = "TestInsertFormFieldWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "Common/test_multi_pages.docx")
            );

            var request = new InsertFormFieldRequest(
                name: remoteFileName,
                formField: new FormFieldTextInput()
                {
                    Name = "FullName",
                    Enabled = true,
                    CalculateOnExit = true,
                    StatusText = "",
                    TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular,
                    TextInputDefault = "123",
                    TextInputFormat = "UPPERCASE"
                },
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = this.WordsApi.InsertFormField(request);
            Assert.NotNull(actual.FormField);
            Assert.AreEqual("FullName", actual.FormField.Name);
            Assert.AreEqual("", actual.FormField.StatusText);
        }

        /// <summary>
        /// Test for deleting form field.
        /// </summary>
        [Test]
        public void TestDeleteFormField()
        {
            string remoteFileName = "TestDeleteFormField.docx";

            this.UploadFileToStorage(
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
        this.WordsApi.DeleteFormField(request);
        }

        /// <summary>
        /// Test for deleting form field online.
        /// </summary>
        [Test]
        public void TestDeleteFormFieldOnline()
        {
            using var documentStream = File.OpenRead(LocalTestDataFolder + fieldFolder + "/FormFilled.docx");
            var request = new DeleteFormFieldOnlineRequest(
                document: documentStream,
                index: 0,
                nodePath: "sections/0"
            );
            var actual = this.WordsApi.DeleteFormFieldOnline(request);
        }

        /// <summary>
        /// Test for deleting form field without node path.
        /// </summary>
        [Test]
        public void TestDeleteFormFieldWithoutNodePath()
        {
            string remoteFileName = "TestDeleteFormFieldWithoutNodePath.docx";

            this.UploadFileToStorage(
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
        this.WordsApi.DeleteFormField(request);
        }
    }
}
