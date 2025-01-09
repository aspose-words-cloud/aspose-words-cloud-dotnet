// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ReadmeTest.cs">
//   Copyright (c) 2025 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.Tests
{
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class ReadmeTest : BaseTestContext
    {
        /// <summary>
        /// Test for getting headers and footers
        /// </summary>
        [Test]
        public async Task TestReadmeCode()
        {
            var localName = "test_multi_pages.docx";
            var pathToDocFile = BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName;

            var currenConfig = BaseTestContext.GetConfig();
            var clientSecret = currenConfig.ClientSecret;
            var clientId = currenConfig.ClientId;
            var baseUrl = currenConfig.BaseUrl;

            // Start README example
            var config = new Configuration
            {
                ClientId = clientId,
                ClientSecret = clientSecret,
                ApiBaseUrl = baseUrl,
            };

            var wordsApi = new WordsApi(config);

            using (var inputStream = new FileStream(pathToDocFile, FileMode.Open))
            {
                var uploadFileRequest = new UploadFileRequest(inputStream, "fileStoredInCloud.doc");
                await wordsApi.UploadFile(uploadFileRequest);
            }

            var saveOptionsData = new PdfSaveOptionsData { FileName = "destStoredInCloud.pdf" };
            var request = new SaveAsRequest("fileStoredInCloud.doc", saveOptionsData);
            await wordsApi.SaveAs(request);

            // End README example

            WriteCodeToReadme();
        }

        private void WriteCodeToReadme()
        {
            const string startPatern = @"^\s*// Start README example\s*$";
            const string endPattern = @"^\s*// End README example\s*$";

            var sourcePath = Path.Combine(DirectoryHelper.GetRootSdkFolder(), "Aspose.Words.Cloud.Sdk.Tests/ReadmeTest.cs");
            var readmePath = Path.Combine(DirectoryHelper.GetRootSdkFolder(), "README.md");

            // read code
            var codeLines = File.ReadAllLines(sourcePath);
            var readmeCode = new List<string>();
            var skipMode = true;
            for(int i=0; i < codeLines.Length; i++)
            {
                if(skipMode)
                {
                    skipMode = !Regex.IsMatch(codeLines[i], startPatern);
                }

                if(!skipMode)
                {
                    readmeCode.Add(codeLines[i]);
                    skipMode = Regex.IsMatch(codeLines[i], endPattern);                 
                }
            }

            if(readmeCode.Count < 2)
            {
                throw new Exception("Code has not found in ReadMeTest.cs");
            }

            // remove the previous code from readme
            var readmeLines = File.ReadAllLines(readmePath).ToList();
            skipMode = true;
            int insertPosition = -1;
            for (int i = 0; i < readmeLines.Count; i++)
            {
                if (skipMode)
                {
                    skipMode = !Regex.IsMatch(readmeLines[i], startPatern);

                    if(!skipMode)
                    {
                        insertPosition = i;
                    }
                }

                if (!skipMode)
                {
                    var line = readmeLines[i];
                    readmeLines.RemoveAt(i--);
                    skipMode = Regex.IsMatch(line, endPattern);
                }
            }

            if (insertPosition == -1)
            {
                throw new Exception("An insert position has not found in readme.md");
            }

            // update readme
            readmeLines.InsertRange(insertPosition, readmeCode);
            File.WriteAllLines(readmePath, readmeLines);
        }
    }
}
