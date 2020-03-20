// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ExecuteMailMergeOnlineRequest.cs">
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
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.ExecuteMailMergeOnline" /> operation.
  /// </summary>  
  public class ExecuteMailMergeOnlineRequest : IPutExecuteRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteMailMergeOnlineRequest"/> class.
        /// </summary>        
        public ExecuteMailMergeOnlineRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteMailMergeOnlineRequest"/> class.
        /// </summary>
        /// <param name="template">File with template</param>
        /// <param name="data">File with mailmerge data</param>
        /// <param name="withRegions">With regions flag.</param>
        /// <param name="cleanup">Clean up options.</param>
        /// <param name="documentFileName">This file name will be used when resulting document has dynamic field for document file name {filename}. If it is not setted, &quot;template&quot; will be used instead. </param>
        public ExecuteMailMergeOnlineRequest(System.IO.Stream template, System.IO.Stream data, bool? withRegions = null, string cleanup = null, string documentFileName = null)             
        {
            this.Template = template;
            this.Data = data;
            this.WithRegions = withRegions;
            this.Cleanup = cleanup;
            this.DocumentFileName = documentFileName;
        }

        /// <summary>
        /// File with template
        /// </summary>  
        public System.IO.Stream Template { get; set; }

        /// <summary>
        /// File with mailmerge data
        /// </summary>  
        public System.IO.Stream Data { get; set; }

        /// <summary>
        /// With regions flag.
        /// </summary>  
        public bool? WithRegions { get; set; }

        /// <summary>
        /// Clean up options.
        /// </summary>  
        public string Cleanup { get; set; }

        /// <summary>
        /// This file name will be used when resulting document has dynamic field for document file name {filename}. If it is not setted, "template" will be used instead. 
        /// </summary>  
        public string DocumentFileName { get; set; }
  }
}
