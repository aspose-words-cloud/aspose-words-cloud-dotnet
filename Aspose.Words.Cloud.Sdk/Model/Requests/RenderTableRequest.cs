// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RenderTableRequest.cs">
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
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.RenderTable" /> operation.
  /// </summary>  
  public class RenderTableRequest : IWordDocumentRequest, ICanUseCustomFontsRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderTableRequest"/> class.
        /// </summary>        
        public RenderTableRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderTableRequest"/> class.
        /// </summary>
        /// <param name="name">The file name.</param>
        /// <param name="format">The destination format.</param>
        /// <param name="index">Object&#39;s index</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        /// <param name="nodePath">Path to node, which contains tables.</param>
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param>
        public RenderTableRequest(string name, string format, int? index, string folder = null, string storage = null, string loadEncoding = null, string password = null, string nodePath = null, string fontsLocation = null)             
        {
            this.Name = name;
            this.Format = format;
            this.Index = index;
            this.Folder = folder;
            this.Storage = storage;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.NodePath = nodePath;
            this.FontsLocation = fontsLocation;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The destination format.
        /// </summary>  
        public string Format { get; set; }

        /// <summary>
        /// Object's index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Path to node, which contains tables.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string FontsLocation { get; set; }
  }
}
