// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RunTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Run
{
    using System.Collections.Generic;
    using System.IO;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with runs.
    /// </summary>
    [TestFixture]
    public class RunTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/Runs";
        private readonly string localFile = "DocumentElements/Runs/Run.doc";

        /// <summary>
        /// Test for updating run.
        /// </summary>
        [Test]
        public void TestUpdateRun()
        {
            string remoteFileName = "TestUpdateRun.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new UpdateRunRequest(
                name: remoteFileName,
                paragraphPath: "paragraphs/1",
                index: 0,
                run: new RunUpdate()
                {
                    Text = "run with text"
                },
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.UpdateRun(request);
            Assert.NotNull(actual.Run);
            Assert.AreEqual("run with text", actual.Run.Text);
        }

        /// <summary>
        /// Test for updating run online.
        /// </summary>
        [Test]
        public void TestUpdateRunOnline()
        {
            using var documentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new UpdateRunOnlineRequest(
                document: documentStream,
                paragraphPath: "paragraphs/1",
                run: new RunUpdate()
                {
                    Text = "run with text"
                },
                index: 0
            );
            var actual = this.WordsApi.UpdateRunOnline(request);
        }

        /// <summary>
        /// Test for adding run.
        /// </summary>
        [Test]
        public void TestInsertRun()
        {
            string remoteFileName = "TestInsertRun.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new InsertRunRequest(
                name: remoteFileName,
                paragraphPath: "paragraphs/1",
                run: new RunInsert()
                {
                    Text = "run with text"
                },
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.InsertRun(request);
            Assert.NotNull(actual.Run);
            Assert.AreEqual("run with text", actual.Run.Text);
            Assert.AreEqual("0.0.1.3", actual.Run.NodeId);
        }

        /// <summary>
        /// Test for adding run online.
        /// </summary>
        [Test]
        public void TestInsertRunOnline()
        {
            using var documentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new InsertRunOnlineRequest(
                document: documentStream,
                paragraphPath: "paragraphs/1",
                run: new RunInsert()
                {
                    Text = "run with text"
                }
            );
            var actual = this.WordsApi.InsertRunOnline(request);
        }

        /// <summary>
        /// Test for deleting run.
        /// </summary>
        [Test]
        public void TestDeleteRun()
        {
            string remoteFileName = "TestDeleteRun.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteRunRequest(
                name: remoteFileName,
                paragraphPath: "paragraphs/1",
                index: 0,
                folder: remoteDataFolder
            );
        this.WordsApi.DeleteRun(request);
        }

        /// <summary>
        /// Test for deleting run online.
        /// </summary>
        [Test]
        public void TestDeleteRunOnline()
        {
            using var documentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteRunOnlineRequest(
                document: documentStream,
                paragraphPath: "paragraphs/1",
                index: 0
            );
            var actual = this.WordsApi.DeleteRunOnline(request);
        }
    }
}
