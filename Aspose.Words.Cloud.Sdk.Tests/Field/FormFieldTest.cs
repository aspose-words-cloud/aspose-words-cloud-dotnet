// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="FormFieldTest.cs">
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
// //  --------------------------------------------------------------------------------------------------------------------
namespace Aspose.Words.Cloud.Sdk.Tests.Field
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with form field
    /// </summary>
    [TestFixture]
    public class FormFieldTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(RemoteBaseTestDataFolder, "DocumentElements/FormFields");

        private readonly string fieldFolder = "DocumentElements/FormFields/";

        /// <summary>
        /// Test for posting form field
        /// </summary>
        [Test]
        public void TestUpdateFormField()
        {
            var localName = "FormFilled.docx";
            var remoteName = "TestPostFormField.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var formfieldIndex = 0;
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);

            FormFieldTextInput body = new FormFieldTextInput
                                          {
                                              Name = "FullName",
                                              Enabled = true,
                                              CalculateOnExit = true,
                                              StatusText = string.Empty,
                                              TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular,
                                              TextInputDefault = string.Empty
                                          };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.fieldFolder) + localName));

            var request = new UpdateFormFieldRequest(remoteName, body, formfieldIndex, "sections/0", this.dataFolder, destFileName: destFileName);

            FormFieldResponse actual = this.WordsApi.UpdateFormField(request);
            
            Assert.AreEqual("FullName", actual.FormField.Name);
            Assert.AreEqual(true, actual.FormField.Enabled);

            var formFieldTextInput = actual.FormField as FormFieldTextInput;
            Assert.IsTrue(formFieldTextInput != null, 
                "Incorrect type of formfield: {0} instead of {1}", 
                actual.FormField.GetType(), 
                typeof(FormFieldTextInput));
            Assert.AreEqual(FormFieldTextInput.TextInputTypeEnum.Regular, formFieldTextInput.TextInputType);
        }

        /// <summary>
        /// Test for getting form field
        /// </summary>
        [Test]
        public void TestGetFormField()
        {
            var localName = "FormFilled.docx";
            var remoteName = "TestGetFormField.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            int formfieldIndex = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.fieldFolder) + localName));

            var request = new GetFormFieldRequest(remoteName, formfieldIndex, "sections/0", this.dataFolder);
            FormFieldResponse actual = this.WordsApi.GetFormField(request);
        }

        /// <summary>
        ///  Test for getting form fields
        /// </summary>        
        [Test]
        public void TestGetFormFields()
        {
            var localName = "FormFilled.docx";
            var remoteName = "TestGetFormFields.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.fieldFolder) + localName));

            var request = new GetFormFieldsRequest(remoteName, "sections/0", this.dataFolder);
            FormFieldsResponse actual = this.WordsApi.GetFormFields(request);
        }

        /// <summary>
        /// Test for insert form field
        /// </summary>
        [Test]
        public void TestInsertFormField()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestPutFormField.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);

            var body = new FormFieldTextInput
                           {
                               Name = "FullName",
                               Enabled = true,
                               CalculateOnExit = true,
                               StatusText = string.Empty,
                               TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular,
                               TextInputDefault = "123",
                               TextInputFormat = "UPPERCASE"
                           };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new InsertFormFieldRequest(remoteName, body, "sections/0/paragraphs/0", this.dataFolder, destFileName: destFileName);
            var actual = this.WordsApi.InsertFormField(request);
        }

        /// <summary>
        /// Test for deleting form field
        /// </summary>
        [Test]
        public void TestDeleteFormField()
        {
            var localName = "FormFilled.docx";
            var remoteName = "TestDeleteFormField.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var formfieldIndex = 0;
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.fieldFolder) + localName));

            var request = new DeleteFormFieldRequest(remoteName, formfieldIndex, "sections/0", this.dataFolder, destFileName: destFileName);
            this.WordsApi.DeleteFormField(request);
        }
    }
}