// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BaseApiTest.cs">
//   Copyright (c) 2023 Aspose.Words for Cloud
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
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;

    using Aspose.Words.Cloud.Sdk;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
    /// This is a test class for TestWordsApi and is intended
    /// to contain all TestWordsApi Unit Tests
    /// </summary>
    [TestFixture]
    public class BaseApiTest : BaseTestContext
    {
        /// <summary>
        /// Initialize instance
        /// </summary>
        public BaseApiTest()
        {
        }

        /// <summary>
        /// Initialize instance
        /// </summary>
        /// <param name="config">test configuration</param>
        public BaseApiTest(Configuration config) : base(config)
        {
        }

        /// <summary>
        /// If file does not exist, 400 response should be returned with message "Error while loading file ".
        /// </summary>
        [Test]
        public async Task TestHandleErrors()
        {
            string name = "noFileWithThisName.docx";

            try
            {
                var request = new GetSectionsRequest(name);
                await this.WordsApi.GetSections(request);

                Assert.Fail("Expected exception has not been thrown");
            }
            catch (ApiException apiException)
            {
                Assert.AreEqual(404, apiException.ErrorCode);
                Assert.IsTrue(apiException.Message.StartsWith("Error while loading file 'noFileWithThisName.docx' from storage"), "Current message: " + apiException.Message);
            }
        }

        /// <summary>
        /// Check if all API methods have covered by tests
        /// </summary>
        [Test]
        public void TestApiCoverage()
        {
            var methods = typeof(WordsApi).GetMethods()
                .Where(p => p.IsPublic && p.DeclaringType != typeof(object))
                .Where(p => !(p.IsSpecialName && p.Name.StartsWith("get_")))
                .Where(p => !p.GetCustomAttributes<ObsoleteAttribute>(true).Any())
                .Select(p => p.Name)
                .ToList();
            var unitTestFolder = Path.Combine(DirectoryHelper.GetRootSdkFolder(), "Aspose.Words.Cloud.Sdk.Tests");
            var bddTestFolder = Path.Combine(DirectoryHelper.GetRootSdkFolder(), "Aspose.Words.Cloud.Sdk.BddTests");
            var unitTestFiles = DirectoryHelper.GetFilesByExtension(unitTestFolder, ".cs", SearchOption.AllDirectories).ToList();
            var bddTestFiles = DirectoryHelper.GetFilesByExtension(bddTestFolder, ".cs", SearchOption.AllDirectories).ToList();
            unitTestFiles.AddRange(bddTestFiles);
            var filesContent = unitTestFiles.Select(File.ReadAllText).ToList();
            var strBuilder = new StringBuilder();
            foreach (var methodInfo in methods)
            {
                if (filesContent.All(p => !p.Contains(methodInfo)))
                {
                    strBuilder.AppendLine($"Uncovered api method {methodInfo}");
                    Console.WriteLine($"Uncovered api method {methodInfo}");
                }
            }

            Assert.IsTrue(strBuilder.Length == 0, strBuilder.ToString());
        }

        /// <summary>
        /// Check if WordsApi throws an exception for wrong configuration parameters
        /// </summary>
        /// <param name="parameterValue">a value to test</param>
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void TestWordsApiConfigurationParameterChecks(string parameterValue)
        {
            // non-empty configuration strings
            var clientId = "clientId";
            var clientSecret = "clientSecret";

            // parameterValue is a invalid value for both clientId and clientSecret
            Assert.Throws<ArgumentException>(() => new WordsApi(clientId, parameterValue));
            Assert.Throws<ArgumentException>(() => new WordsApi(parameterValue, clientSecret));
        }

        /// <summary>
        /// Check if configuration data is used instead of raw input
        /// </summary>
        [Test]
        public void TestIfConfigurationIsUsed()
        {
            var config = new Configuration { ClientId = ClientId, ClientSecret = ClientSecret, ApiBaseUrl = BaseProductUri };
            var test = new BaseApiTest(config);

            Assert.AreEqual(test.BaseProductUri, config.ApiBaseUrl);
            Assert.AreEqual(test.ClientId, config.ClientId);
            Assert.AreEqual(test.ClientSecret, config.ClientSecret);
        }

        /// <summary>
        /// Check if password parameter works.
        /// </summary>
        [Test]
        public async Task TestGetDocumentWithPassword()
        {
            string remoteDataFolder = RemoteBaseTestDataFolder;
            string localFile = "Common/DocWithPassword.docx";
            string remoteFileName = "TestGetDocumentWithPassword.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetParagraphsRequest(
                name: remoteFileName,
                nodePath: "sections/0",
                folder: remoteDataFolder,
                password: "12345"
            );

            var actual = await this.WordsApi.GetParagraphs(request);
            Assert.AreEqual(2, actual.Paragraphs.ParagraphLinkList.Count);
        }
    }
}
