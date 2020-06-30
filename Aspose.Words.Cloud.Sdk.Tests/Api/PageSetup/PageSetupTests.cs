// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PageSetupTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.PageSetup
{
    using System.Collections.Generic;
    using System.IO;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with macros.
    /// </summary>
    [TestFixture]
    public class PageSetupTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/PageSetup";
        private readonly string localFile = "Common/test_multi_pages.docx";
        private readonly string localTextFile = "DocumentElements/Text/SampleWordDocument.docx";

        /// <summary>
        /// Test for getting page settings.
        /// </summary>
        [Test]
        public void TestGetSectionPageSetup()
        {
            string remoteFileName = "TestGetSectionPageSetup.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetSectionPageSetupRequest(
                name: remoteFileName,
                sectionIndex: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetSectionPageSetup(request);
        }

        /// <summary>
        /// Test for updating page settings.
        /// </summary>
        [Test]
        public void TestUpdateSectionPageSetup()
        {
            string remoteFileName = "TestUpdateSectionPageSetup.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new UpdateSectionPageSetupRequest(
                name: remoteFileName,
                sectionIndex: 0,
                pageSetup: new PageSetup()
                {
                    RtlGutter = true,
                    LeftMargin = 10f,
                    Orientation = PageSetup.OrientationEnum.Landscape,
                    PaperSize = PageSetup.PaperSizeEnum.A5
                },
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.UpdateSectionPageSetup(request);
        }

        /// <summary>
        /// Test for page rendering.
        /// </summary>
        [Test]
        public void TestGetRenderPage()
        {
            string remoteFileName = "TestGetRenderPage.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localTextFile)
            );

            var request = new RenderPageRequest(
                name: remoteFileName,
                pageIndex: 1,
                format: "bmp",
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.RenderPage(request);
        }
    }
}
