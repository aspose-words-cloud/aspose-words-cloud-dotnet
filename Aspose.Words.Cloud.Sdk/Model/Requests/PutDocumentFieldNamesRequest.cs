// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutDocumentFieldNamesRequest.cs">
//   Copyright (c) 2017 Aspose.Words for Cloud
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
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutDocumentFieldNames" /> operation.
  /// </summary>  
  public class PutDocumentFieldNamesRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutDocumentFieldNamesRequest"/> class.
        /// </summary>        
        public PutDocumentFieldNamesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutDocumentFieldNamesRequest"/> class.
        /// </summary>
        /// <param name="template">File with template</param>
        /// <param name="useNonMergeFields">Use non merge fields or not.</param>
        public PutDocumentFieldNamesRequest(System.IO.Stream template, bool? useNonMergeFields = null)             
        {
            this.Template = template;
            this.UseNonMergeFields = useNonMergeFields;
        }

        /// <summary>
        /// File with template
        /// </summary>  
        public System.IO.Stream Template { get; set; }

        /// <summary>
        /// Use non merge fields or not.
        /// </summary>  
        public bool? UseNonMergeFields { get; set; }
  }
}
