// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RenderParagraphRequest.cs">
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
namespace Aspose.Words.Cloud.Sdk.Model.Requests 
{
  using Aspose.Words.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.RenderParagraph" /> operation.
  /// </summary>  
  public class RenderParagraphRequest : IWordDocumentRequest, ICanUseCustomFontsRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderParagraphRequest"/> class.
        /// </summary>        
        public RenderParagraphRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderParagraphRequest"/> class.
        /// </summary>
        /// <param name="format">The destination format.</param>
        /// <param name="index">Object&#39;s index</param>
        /// <param name="name">The file name.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="nodePath">Path to node, which contains paragraphs.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        public RenderParagraphRequest(string format, int? index, string name, string folder = null, string fontsLocation = null, string loadEncoding = null, string nodePath = null, string password = null, string storage = null)             
        {
            this.Format = format;
            this.Index = index;
            this.Name = name;
            this.Folder = folder;
            this.FontsLocation = fontsLocation;
            this.LoadEncoding = loadEncoding;
            this.NodePath = nodePath;
            this.Password = password;
            this.Storage = storage;
        }

        /// <summary>
        /// The destination format.
        /// </summary>  
        public string Format { get; set; }

        /// <summary>
        /// Object's index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string FontsLocation { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Path to node, which contains paragraphs.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }
  }
}