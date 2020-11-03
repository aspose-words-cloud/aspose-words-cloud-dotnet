// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MathObjectTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.MathObject
{
    using System.Collections.Generic;
    using System.IO;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with MathObjects.
    /// </summary>
    [TestFixture]
    public class MathObjectTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/MathObjects";
        private readonly string localFile = "DocumentElements/MathObjects/MathObjects.docx";

        /// <summary>
        /// Test for getting mathObjects.
        /// </summary>
        [Test]
        public void TestGetOfficeMathObjects()
        {
            string remoteFileName = "TestGetOfficeMathObjects.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetOfficeMathObjectsRequest(
                name: remoteFileName,
                nodePath: "",
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetOfficeMathObjects(request);
            Assert.NotNull(actual.OfficeMathObjects);
            Assert.NotNull(actual.OfficeMathObjects.List);
            Assert.AreEqual(16, actual.OfficeMathObjects.List.Count);
            Assert.AreEqual("0.0.0.0", actual.OfficeMathObjects.List[0].NodeId);
        }

        /// <summary>
        /// Test for getting mathObjects without node path.
        /// </summary>
        [Test]
        public void TestGetOfficeMathObjectsWithoutNodePath()
        {
            string remoteFileName = "TestGetOfficeMathObjectsWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetOfficeMathObjectsRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetOfficeMathObjects(request);
            Assert.NotNull(actual.OfficeMathObjects);
            Assert.NotNull(actual.OfficeMathObjects.List);
            Assert.AreEqual(16, actual.OfficeMathObjects.List.Count);
            Assert.AreEqual("0.0.0.0", actual.OfficeMathObjects.List[0].NodeId);
        }

        /// <summary>
        /// Test for getting mathObject.
        /// </summary>
        [Test]
        public void TestGetOfficeMathObject()
        {
            string remoteFileName = "TestGetOfficeMathObject.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetOfficeMathObjectRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "",
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetOfficeMathObject(request);
            Assert.NotNull(actual.OfficeMathObject);
            Assert.AreEqual("0.0.0.0", actual.OfficeMathObject.NodeId);
        }

        /// <summary>
        /// Test for getting mathObject without node path.
        /// </summary>
        [Test]
        public void TestGetOfficeMathObjectWithoutNodePath()
        {
            string remoteFileName = "TestGetOfficeMathObjectWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetOfficeMathObjectRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetOfficeMathObject(request);
            Assert.NotNull(actual.OfficeMathObject);
            Assert.AreEqual("0.0.0.0", actual.OfficeMathObject.NodeId);
        }

        /// <summary>
        /// Test for rendering mathObject.
        /// </summary>
        [Test]
        public void TestRenderMathObject()
        {
            string remoteFileName = "TestRenderMathObject.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new RenderMathObjectRequest(
                name: remoteFileName,
                format: "png",
                index: 0,
                nodePath: "",
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.RenderMathObject(request);
        }

        /// <summary>
        /// Test for rendering mathObject without node path.
        /// </summary>
        [Test]
        public void TestRenderMathObjectWithoutNodePath()
        {
            string remoteFileName = "TestRenderMathObjectWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new RenderMathObjectRequest(
                name: remoteFileName,
                format: "png",
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.RenderMathObject(request);
        }

        /// <summary>
        /// Test for deleting mathObject.
        /// </summary>
        [Test]
        public void TestDeleteOfficeMathObject()
        {
            string remoteFileName = "TestDeleteOfficeMathObject.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteOfficeMathObjectRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "",
                folder: remoteDataFolder
            );

            this.WordsApi.DeleteOfficeMathObject(request);
        }

        /// <summary>
        /// Test for deleting mathObject without node path.
        /// </summary>
        [Test]
        public void TestDeleteOfficeMathObjectWithoutNodePath()
        {
            string remoteFileName = "TestDeleteOfficeMathObjectWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteOfficeMathObjectRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );

            this.WordsApi.DeleteOfficeMathObject(request);
        }
    }
}
