// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConvertDocumentRequest.cs">
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
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.ConvertDocument" /> operation.
  /// </summary>  
  public class ConvertDocumentRequest : ICanUseCustomFontsRequest, ICanSpecifyOutputFormatRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertDocumentRequest"/> class.
        /// </summary>        
        public ConvertDocumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertDocumentRequest"/> class.
        /// </summary>
        /// <param name="document">Converting document</param>
        /// <param name="format">Format to convert.</param>
        /// <param name="storage">Original document storage.</param>
        /// <param name="outPath">Path for saving operation result to the local storage.</param>
        /// <param name="fileNameFieldValue">This file name will be used when resulting document has dynamic field for document file name {filename}. If it is not set, &quot;sourceFilename&quot; will be used instead.</param>
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param>
        public ConvertDocumentRequest(System.IO.Stream document, string format, string storage = null, string outPath = null, string fileNameFieldValue = null, string fontsLocation = null)             
        {
            this.Document = document;
            this.Format = format;
            this.Storage = storage;
            this.OutPath = outPath;
            this.FileNameFieldValue = fileNameFieldValue;
            this.FontsLocation = fontsLocation;
        }

        /// <summary>
        /// Converting document
        /// </summary>  
        public System.IO.Stream Document { get; set; }

        /// <summary>
        /// Format to convert.
        /// </summary>  
        public string Format { get; set; }

        /// <summary>
        /// Original document storage.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Path for saving operation result to the local storage.
        /// </summary>  
        public string OutPath { get; set; }

        /// <summary>
        /// This file name will be used when resulting document has dynamic field for document file name {filename}. If it is not set, "sourceFilename" will be used instead.
        /// </summary>  
        public string FileNameFieldValue { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string FontsLocation { get; set; }
  }
}
