﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StorageSteps.cs">
//   Copyright (c) 2019 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.BddTests.Steps.Common
{
    using System.IO;
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;
    using Aspose.Words.Cloud.Sdk.Model.Requests;

    using NUnit.Framework;

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
       
        /// <summary>
        /// Uploads specified document to storage
        /// </summary>
        /// <param name="fileName">document name</param>
        /// <param name="subfolder">subfolder to upload</param>
        [Given(@"I have uploaded document with name (.*) and subfolder is (.*) to storage")]
        public async Task GivenIHaveUploadedDocumentWithNameToStorage(string fileName, string subfolder)
        {
            var remotePath = BaseContext.RemoteBaseFolder + subfolder;
            var localPath = Path.Combine(this.context.TestDataPath, subfolder, fileName);

            using (var stream = File.OpenRead(localPath))
            {
                await this.context.WordsApi.UploadFile(new UploadFileRequest(stream, remotePath + fileName));
            }
        }

        /// <summary>
        /// Check if file with the name exists in storage and delete it if true.
        /// </summary>
        /// <param name="fileName">File name.</param>
        /// <param name="folder">Folder.</param>
        [Given(@"There is no file (.*) on storage in (.*) folder")]
        public async Task GivenThereIsNoFileInStorage(string fileName, string folder)
        {
            var remotePath = BaseContext.RemoteBaseFolder + folder + fileName;
            if (folder == "output")
            {
                remotePath = BaseContext.RemoteBaseTestOutFolder + fileName;
            }

            try
            {
                await this.context.WordsApi.DeleteFile(new DeleteFileRequest(remotePath));
            }
            catch { }
        }

        /// <summary>
        /// Checks converted document exists on storage.
        /// </summary>
        /// <param name="fileName">File name.</param>
        /// <param name="subfolder">specific subfolder</param>
        [Then(@"document (.*) is existed on storage in (.*) folder")]
        public async Task ThenDocumentIsExistedInStorage(string fileName, string subfolder)
        {
            var remotePath = BaseContext.RemoteBaseFolder + subfolder + fileName;

            if (subfolder == "output")
            {
                remotePath = BaseContext.RemoteBaseTestOutFolder + fileName;
            }

            using (var file = await this.context.WordsApi.DownloadFile(new DownloadFileRequest(remotePath)))
            {
                Assert.IsTrue(file.Length > 0, string.Format("File does not exist '{0}'", remotePath));
            }
        }
    }
}