// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="RunTest.cs">
// //   Copyright (c) 2017 Aspose.Words for Cloud
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
namespace Aspose.Words.Cloud.Sdk.Tests.Run
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Example of how to work with runs
    /// </summary>
    [TestClass]
    [DeploymentItem("TestData", "TestData")]
    public class RunTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(BaseTestDataPath, "DocumentElements/Run");

        private readonly string runFolder = "Run/";

        /// <summary>
        /// Test for updating run
        /// </summary>
        [TestMethod]
        public void TestPostRun()
        {
            var localName = "Run.doc";
            var remoteName = "TestPostRun.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var run = new Run { Text = "run with text" };

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.runFolder) + localName));

            var request = new PostRunRequest(remoteName, run, "paragraphs/1", 0, this.dataFolder);
            var actual = this.WordsApi.PostRun(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for adding run
        /// </summary>
        [TestMethod]
        public void TestPutRun()
        {
            var localName = "Run.doc";
            var remoteName = "TestPostRun.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var run = new Run { Text = "run with text" };

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.runFolder) + localName));

            var request = new PutRunRequest(remoteName, "paragraphs/1", run, this.dataFolder);
            var actual = this.WordsApi.PutRun(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for deleting run
        /// </summary>
        [TestMethod]
        public void TestDeleteRun()
        {
            var localName = "Run.doc";
            var remoteName = "TestDeleteRun.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.runFolder) + localName));

            var request = new DeleteRunRequest(remoteName, "paragraphs/1", index, this.dataFolder);
            var actual = this.WordsApi.DeleteRun(request);

            Assert.AreEqual(200, actual.Code);
        }
    }
}