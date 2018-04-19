// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="BaseTestContext.cs">
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
// // --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Words.Cloud.Sdk.Tests.Base
{
    using System.IO;
    using System.Linq;

    using Com.Aspose.Storage.Api;

    using Newtonsoft.Json;

    /// <summary>
    /// Base class for all tests
    /// </summary>
    public abstract class BaseTestContext
    {        
        protected static readonly string LocalTestDataFolder = GetTestDataPath();
        private Keys keys;        

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseTestContext"/> class.
        /// </summary>
        protected BaseTestContext()
        {
            // To run tests with your own credentials please substitute code bellow with this one
            // this.keys = new Keys { AppKey = "your app key", AppSid = "your app sid" };
            var serverCreds = Path.Combine(Directory.GetParent(GetTestDataPath()).FullName, "Settings", "servercreds.json");
            this.keys = JsonConvert.DeserializeObject<Keys>(File.ReadAllText(serverCreds));
            if (this.keys == null)
            {
                throw new FileNotFoundException("servercreds.json doesn't contain AppKey and AppSid");
            }

            var configuration = new Configuration { ApiBaseUrl = this.keys.BaseUrl, AppKey = this.keys.AppKey, AppSid = this.keys.AppSid };
            this.WordsApi = new WordsApi(configuration);
            this.StorageApi = new StorageApi(this.keys.AppKey, this.keys.AppSid, this.keys.BaseUrl + "/v1.1");
        }

        /// <summary>
        /// Base path to test data        
        /// </summary>
        protected static string RemoteBaseTestDataFolder
        {
            get
            {
                return "Temp/SdkTests/TestData";
            }
        }

        /// <summary>
        /// Base path to output data
        /// </summary>
        protected static string BaseTestOutPath
        {
            get
            {
                return "TestOut";
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
        /// Storage API
        /// </summary>
        protected StorageApi StorageApi { get; set; }

        /// <summary>
        /// Words API
        /// </summary>
        protected WordsApi WordsApi { get; set; }

        /// <summary>
        /// AppSid
        /// </summary>
        protected string AppSid
        {
            get
            {
                return this.keys.AppSid;
            }
        }

        /// <summary>
        /// AppSid
        /// </summary>
        protected string AppKey
        {
            get
            {
                return this.keys.AppKey;
            }
        }

        /// <summary>
        /// Base Url for tests
        /// </summary>
        protected string BaseProductUri
        {
            get
            {
                return this.keys.BaseUrl;
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
        /// Returns path to folder with test data
        /// </summary>
        /// <param name="parentDir">parent directory</param>
        /// <returns>path to test data folder</returns>
        private static string GetTestDataPath(string parentDir = null)
        {
            var info = Directory.GetParent(parentDir ?? Directory.GetCurrentDirectory());
            if (info != null)
            {
                var dataFolderExists = info.GetDirectories("TestData");
                if (dataFolderExists.Any())
                {
                    return Path.Combine(info.FullName, "TestData");
                }

                return GetTestDataPath(info.FullName);
            }

            return Path.Combine(parentDir ?? string.Empty, "TestData");
        }

        private class Keys
        {
            public string AppSid { get; set; }

            public string AppKey { get; set; }

            public string BaseUrl { get; set; }
        }
    }
}