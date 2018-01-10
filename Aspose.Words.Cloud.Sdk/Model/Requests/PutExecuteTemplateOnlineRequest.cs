// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutExecuteTemplateOnlineRequest.cs">
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
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutExecuteTemplateOnline" /> operation.
  /// </summary>  
  public class PutExecuteTemplateOnlineRequest : IPutExecuteRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutExecuteTemplateOnlineRequest"/> class.
        /// </summary>        
        public PutExecuteTemplateOnlineRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutExecuteTemplateOnlineRequest"/> class.
        /// </summary>
        /// <param name="template">File with template</param>
        /// <param name="data">File with mailmerge data</param>
        /// <param name="cleanup">Clean up options.</param>
        /// <param name="useWholeParagraphAsRegion">Gets or sets a value indicating whether paragraph with TableStart or              TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.              The default value is true.</param>
        /// <param name="withRegions">Merge with regions or not. True by default</param>
        public PutExecuteTemplateOnlineRequest(System.IO.Stream template, System.IO.Stream data, string cleanup = null, bool? useWholeParagraphAsRegion = null, bool? withRegions = null)             
        {
            this.Template = template;
            this.Data = data;
            this.Cleanup = cleanup;
            this.UseWholeParagraphAsRegion = useWholeParagraphAsRegion;
            this.WithRegions = withRegions;
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
        /// Clean up options.
        /// </summary>  
        public string Cleanup { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether paragraph with TableStart or              TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.              The default value is true.
        /// </summary>  
        public bool? UseWholeParagraphAsRegion { get; set; }

        /// <summary>
        /// Merge with regions or not. True by default
        /// </summary>  
        public bool? WithRegions { get; set; }
  }
}
