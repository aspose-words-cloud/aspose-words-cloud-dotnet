// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StorageSteps.cs">
//   Copyright (c) 2017 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.BddTests.Base.Steps
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;
    using Aspose.Words.Cloud.Sdk.Model.Requests;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TechTalk.SpecFlow;

    /// <summary>
    /// Steps for working with storage.
    /// </summary>
    [Binding]
    public class StorageSteps
    {
        private readonly BaseContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageSteps"/> class.
        /// </summary>
        /// <param name="context">Conversion context</param>
        protected StorageSteps(BaseContext context)
        {
            this.context = context;
        }

        private PostDocumentSaveAsRequest Request
        {
            get { return ScenarioContext.Current["Request"] as PostDocumentSaveAsRequest; }
        }

        /// <summary>
        /// Uploads specified document to storage
        /// </summary>
        /// <param name="fileName">document name</param>
        /// <param name="subfolder">subfolder to upload</param>
        [Given(@"I have uploaded document with name (.*) and subfoler is (.*) to storage")]
        public void GivenIHaveUploadedDocumentWithNameToStorage(string fileName, string subfolder)
        {
            this.context.TestSubFolderInStorage = subfolder;
            this.context.StorageApi.PutCreate(
               this.context.TestFolderInStorage + fileName,
               null,
               null,
               File.ReadAllBytes(Path.Combine(this.context.TestDataPath, fileName)));
        }

        /// <summary>
        /// Check if file with the name exists in storage and delete it if true.
        /// </summary>
        /// <param name="fileName">File name.</param>
        [Given(@"There is no file (.*) on storage")]
        public void GivenThereIsNoFileInStorage(string fileName)
        {
            this.context.StorageApi.DeleteFile(this.context.TestFolderInStorage + fileName, null, null);
        }

        /// <summary>
        /// Checks converted document exists on storage.
        /// </summary>
        /// <param name="fileName">File name.</param>
        /// <param name="subfolder">specific subfolder</param>
        [Then(@"document (.*) is existed on storage in subfolder (.*)")]
        public void ThenDocumentIsExistedInStorage(string fileName, string subfolder)
        {
            this.context.TestSubFolderInStorage = subfolder;
            Assert.IsTrue(this.context.FileWithNameExists(fileName), "Error while saving file to storage");
        }

        /// <summary>
        /// Downloads saved to storage document
        /// </summary>
        [Then(@"document from storage is downloadble")]
        public void ThenDocumentFromStorageIsDownloadble()
        {
            var resp = this.context.StorageApi
                .GetDownload(Path.Combine(this.context.TestFolderInStorage, this.Request.SaveOptionsData.FileName), null, null);
            this.context.Response = new MemoryStream(resp.ResponseStream);
        }
    }
}