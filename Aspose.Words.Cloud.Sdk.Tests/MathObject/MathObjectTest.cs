// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="MathObjectTest.cs">
// //   Copyright (c) 2018 Aspose.Words for Cloud
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
namespace Aspose.Words.Cloud.Sdk.Tests.MathObject
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with MathObjects
    /// </summary>
    [TestFixture]
    public class MathObjectTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(RemoteBaseTestDataFolder, "DocumentElements/MathObjects");

        private readonly string mathObjectFolder = "DocumentElements/MathObjects/";

        /// <summary>
        /// Test for getting mathObjects
        /// </summary>
        [Test]
        public void TestGetOfficeMathObjects()
        {
            var localName = "MathObjects.docx";
            var remoteName = "TestGetOfficeMathObjects.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.mathObjectFolder) + localName));

            var request = new GetOfficeMathObjectsRequest(remoteName, this.dataFolder);
            var actual = this.WordsApi.GetOfficeMathObjects(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for getting mathObject
        /// </summary>
        [Test]
        public void TestGetOfficeMathObject()
        {
            var localName = "MathObjects.docx";
            var remoteName = "TestGetOfficeMathObject.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.mathObjectFolder) + localName));

            var request = new GetOfficeMathObjectRequest(remoteName, index, this.dataFolder);
            var actual = this.WordsApi.GetOfficeMathObject(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for rendering mathObject
        /// </summary>
        [Test]
        public void TestRenderMathObject()
        {
            var localName = "MathObjects.docx";
            var remoteName = "TestRenderMathObject.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.mathObjectFolder) + localName));

            var request = new RenderMathObjectRequest(remoteName, "png", index, this.dataFolder);
            var actual = this.WordsApi.RenderMathObject(request);

            Assert.IsTrue(actual.Length > 0, "Error has occurred while mathObject rendering");
        }

        /// <summary>
        /// Test for deleting mathObject
        /// </summary>
        [Test]
        public void TestDeleteMathObject()
        {
            var localName = "MathObjects.docx";
            var remoteName = "TestDeleteMathObject.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.mathObjectFolder) + localName));

            var request = new DeleteOfficeMathObjectRequest(remoteName, index, this.dataFolder);
            var actual = this.WordsApi.DeleteOfficeMathObject(request);

            Assert.AreEqual(200, actual.Code);
        }
    }
}