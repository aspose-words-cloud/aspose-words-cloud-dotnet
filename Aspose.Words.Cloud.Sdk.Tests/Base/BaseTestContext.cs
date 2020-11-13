// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BaseTestContext.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Base
{
    using System;
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model.Requests;

    using Newtonsoft.Json;

    /// <summary>
    /// Base class for all tests
    /// </summary>
    public abstract class BaseTestContext
    {        
        protected static readonly string LocalTestDataFolder = DirectoryHelper.GetRootSdkFolder() + "/TestData/";
        private readonly Configuration config;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseTestContext"/> class.
        /// </summary>
        protected BaseTestContext()
        {
            // To run tests with your own credentials please substitute code bellow with this one
            // this.keys = new Keys { ClientId = "your client id", ClientSecret = "your client secret" };
            var keys = this.GetConfig();

            this.config = new Configuration { ClientId = keys.ClientId, ClientSecret = keys.ClientSecret, ApiBaseUrl = keys.BaseUrl, };
            this.WordsApi = new WordsApi(this.config);
        }

        protected Keys GetConfig()
        {
            var serverCreds = Path.Combine(DirectoryHelper.GetRootSdkFolder(), "Settings", "servercreds.json");
            var keys = JsonConvert.DeserializeObject<Keys>(File.ReadAllText(serverCreds));
            if (keys == null)
            {
                throw new FileNotFoundException("servercreds.json doesn't contain ClientSecret and ClientId");
            }

            return keys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseTestContext"/> class.
        /// </summary>
        /// <param name="configuration">test configuration</param>
        protected BaseTestContext(Configuration configuration)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException("configuration");
            }

            this.config = configuration;
            this.WordsApi = new WordsApi(this.config);
        }

        /// <summary>
        /// Base path to test data
        /// </summary>
        protected static string RemoteBaseTestDataFolder
        {
            get
            {
                return "Temp/SdkTests/NET/TestData";
            }
        }

        /// <summary>
        /// Base path to output data
        /// </summary>
        protected static string BaseTestOutPath
        {
            get
            {
                return "TestOut/NET";
            }
        }

        /// <summary>
        /// Random guid
        /// </summary>
        protected static string CreateRandomGuid
        {
            get
            {
                return System.Guid.NewGuid().ToString();
            }
        }

        /// <summary>
        /// Returns common folder with source test files
        /// </summary>
        protected static string CommonFolder
        {
            get
            {
                return "Common/";
            }
        }

        /// <summary>
        /// Words API
        /// </summary>
        protected WordsApi WordsApi { get; set; }

        /// <summary>
        /// ClientId
        /// </summary>
        protected string ClientId
        {
            get
            {
                return this.config.ClientId;
            }
        }

        /// <summary>
        /// ClientId
        /// </summary>
        protected string ClientSecret
        {
            get
            {
                return this.config.ClientSecret;
            }
        }

        /// <summary>
        /// Base Url for tests
        /// </summary>
        protected string BaseProductUri
        {
            get
            {
                return this.config.ApiBaseUrl;
            }
        }

        /// <summary>
        /// Returns test data path
        /// </summary>
        /// <param name="subfolder">subfolder for specific tests</param>
        /// <returns>test data path</returns>
        protected static string GetDataDir(string subfolder = null)
        {
            return Path.Combine(LocalTestDataFolder, string.IsNullOrEmpty(subfolder) ? string.Empty : subfolder);
        }

        /// <summary>
        /// Uploads file to storage.
        /// </summary>
        /// <param name="path">Path in storage.</param>
        /// <param name="versionId">Api version.</param>
        /// <param name="storage">Storage.</param>
        /// <param name="fileContent">File content.</param>
        protected void UploadFileToStorage(string path, string versionId, string storage, byte[] fileContent)
        {
            using (var ms = new MemoryStream(fileContent))
            {
                var request = new UploadFileRequest(ms, path);
                this.WordsApi.UploadFile(request);
            }
        }

        protected class Keys
        {
            public string ClientId { get; set; }

            public string ClientSecret { get; set; }

            public string BaseUrl { get; set; }
        }
    }
}
