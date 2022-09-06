// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FileReference.cs">
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
	using Newtonsoft.Json.Converters;

    /// <summary>
    /// Utility class to support multiple files uploading as online documents.
    /// </summary>
    public class FileReference : IModel
    {
		/// <summary>
        /// File source enum.
        /// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
        public enum FileSource
        {
            /// <summary>
            /// File content inside current request.
            /// </summary>
            Request,

            /// <summary>
            /// File content already uploaded to storage. Path only used.
            /// </summary>
            Storage,
        }

		/// <summary>
        /// Initializes a new instance of the <see cref="FileReference"/> class.
        /// </summary>
        /// <param name="path">Path to the file in external storage.</param>
        public FileReference(string path)
        {
            this.Source = FileSource.Storage;
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileReference"/> class.
        /// </summary>
        /// <param name="content">Content of the file.</param>
        public FileReference(Stream content)
        {
            this.Source = FileSource.Request;
            this.Document = System.Guid.NewGuid().ToString();
            this.Content = StreamHelper.ReadAsBytes(content);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileReference"/> class.
        /// </summary>
        /// <param name="content">Content of the file.</param>
        public FileReference(byte[] content)
        {
            this.Source = FileSource.Request;
            this.Document = System.Guid.NewGuid().ToString();
            this.Content = content;
        }

        /// <summary>
        /// Gets the file source.
        /// </summary>
        public FileSource Source { get; private set; }

        /// <summary>
        /// Gets the file path in external storage.
        /// </summary>
        public string Path { get; private set; }

        /// <summary>
        /// Gets the file ID inside the multipart.
        /// </summary>
        public string Document { get; private set; }

        /// <summary>
        /// Gets the file content.
        /// </summary>
        [JsonIgnore]
        public byte[] Content { get; private set; }

        /// <summary>
        /// Gets all files content properties.
        /// </summary>
        /// <returns>The http request instance.</returns>
        public IEnumerable<FileReference> GetFileReferences()
        {
            return new FileReference[] { this };
        }
    }
}
