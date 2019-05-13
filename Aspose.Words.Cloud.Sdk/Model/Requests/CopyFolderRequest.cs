// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CopyFolderRequest.cs">
//   Copyright (c) 2019 Aspose.Words for Cloud
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
namespace Aspose.Words.Cloud.Sdk.Model.Requests 
{
  using Aspose.Words.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.CopyFolder" /> operation.
  /// </summary>  
  public class CopyFolderRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFolderRequest"/> class.
        /// </summary>        
        public CopyFolderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFolderRequest"/> class.
        /// </summary>
        /// <param name="destPath">Destination folder path e.g. &#39;/dst&#39;</param>
        /// <param name="srcPath">Source folder path e.g. /Folder1</param>
        /// <param name="srcStorageName">Source storage name</param>
        /// <param name="destStorageName">Destination storage name</param>
        public CopyFolderRequest(string destPath, string srcPath, string srcStorageName = null, string destStorageName = null)             
        {
            this.DestPath = destPath;
            this.SrcPath = srcPath;
            this.SrcStorageName = srcStorageName;
            this.DestStorageName = destStorageName;
        }

        /// <summary>
        /// Destination folder path e.g. '/dst'
        /// </summary>  
        public string DestPath { get; set; }

        /// <summary>
        /// Source folder path e.g. /Folder1
        /// </summary>  
        public string SrcPath { get; set; }

        /// <summary>
        /// Source storage name
        /// </summary>  
        public string SrcStorageName { get; set; }

        /// <summary>
        /// Destination storage name
        /// </summary>  
        public string DestStorageName { get; set; }
  }
}
