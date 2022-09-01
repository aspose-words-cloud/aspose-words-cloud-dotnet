// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FileContent.cs">
//   Copyright (c) 2022 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.Model
{
    using System.IO;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Utility class to support multiple files uploading as online documents.
    /// </summary>
    public class FileContent : IModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileContent"/> class.
        /// </summary>
        /// <param name="filename">Name of the file.</param>
        /// <param name="content">Content of the file.</param>
        public FileContent(string filename, Stream content)
        {
            this.Filename = filename;
            this.Id = System.Guid.NewGuid().ToString();
            this.Content = StreamHelper.ReadAsBytes(content);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileContent"/> class.
        /// </summary>
        /// <param name="filename">Name of the file.</param>
        /// <param name="content">Content of the file.</param>
        public FileContent(string filename, byte[] content)
        {
            this.Filename = filename;
            this.Id = System.Guid.NewGuid().ToString();
            this.Content = content;
        }

        /// <summary>
        /// Gets the file name.
        /// </summary>
        public string Filename { get; private set; }

        /// <summary>
        /// Gets the file ID inside the multipart.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the file content.
        /// </summary>
        [JsonIgnore]
        public byte[] Content { get; private set; }

        /// <summary>
        /// Gets all file content properties.
        /// </summary>
        /// <returns>The http request instance.</returns>
        public IEnumerable<FileContent> GetFileContent()
        {
            return new FileContent[] { this };
        }
    }
}
