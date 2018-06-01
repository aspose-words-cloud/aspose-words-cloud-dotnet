// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BaseContext.cs">
//   Copyright (c) 2018 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.BddTests.Base.Context
{
    using System.IO;

    using Aspose.Storage.Cloud.Sdk.Api;
    using Aspose.Storage.Cloud.Sdk.Model.Requests;

    using Newtonsoft.Json;

    /// <summary>
    /// Base context for all tests.
    /// </summary>
    public class BaseContext
    {
        public const string RemoteBaseFolder = "Temp/SdkTests/net/";
        public const string RemoteBaseTestOutFolder = RemoteBaseFolder + "TestOut/";
        private readonly Keys keys;

        private string testFolder;        

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseContext"/>.
        /// </summary>
        protected BaseContext()
        {
            // To run tests with your own credentials please substitute code bellow with this one
            // this.keys = new Keys { AppKey = "your app key", AppSid = "your app sid" };
            var serverCreds = Path.Combine(Directory.GetParent(this.TestDataPath).FullName, "Settings", "servercreds.json");
            this.keys = JsonConvert.DeserializeObject<Keys>(File.ReadAllText(serverCreds));
            if (this.keys == null)
            {
                throw new FileNotFoundException("servercreds.json doesn't contain AppKey and AppSid");
            }

            this.WordsApi = new WordsApi(new Configuration { AppKey = this.AppKey, AppSid = this.AppSid, ApiBaseUrl = this.BaseProductUri, DebugMode = true });            
            this.StorageApi = new StorageApi(new Storage.Cloud.Sdk.Configuration { AppKey = this.AppKey, AppSid = this.AppSid, ApiBaseUrl = this.BaseProductUri, DebugMode = true });
        }

        /// <summary>
        /// Storage API
        /// </summary>
        public StorageApi StorageApi { get; set; }

        /// <summary>
        /// Words API
        /// </summary>
        public WordsApi WordsApi { get; set; }

        /// <summary>
        /// Response.
        /// </summary>
        public object Response { get; set; }        

        /// <summary>
        /// Get path to test data
        /// </summary>
        public string TestDataPath
        {
            get
            {
                return this.testFolder ?? (this.testFolder = DirectoryHelper.GetTestDataPath());
            }
        }
       
        /// <summary>
        /// AppSid
        /// </summary>
        private string AppSid
        {
            get
            {
                return this.keys.AppSid;
            }
        }

        /// <summary>
        /// AppSid
        /// </summary>
        private string AppKey
        {
            get
            {
                return this.keys.AppKey;
            }
        }

        /// <summary>
        /// Base Url for tests
        /// </summary>
        private string BaseProductUri
        {
            get
            {
                return this.keys.BaseUrl;
            }
        }

        /// <summary>
        /// Is document with this name exist
        /// </summary>
        /// <param name="name">document name</param>
        /// <returns>is exist</returns>
        public bool FileWithNameExists(string name)
        {
            var isExists = this.StorageApi.GetIsExist(new GetIsExistRequest(name));
            if (isExists != null && isExists.FileExist != null)
            {
                return isExists.FileExist.IsExist.GetValueOrDefault();
            }

            return false;
        }

        private class Keys
        {
            public string AppSid { get; set; }

            public string AppKey { get; set; }

            public string BaseUrl { get; set; }
        }
    }
}