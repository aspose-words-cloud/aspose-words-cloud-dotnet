// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OnlineDocumentEntry.cs">
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
    using System;  
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Represents a document which will be appended to the original resource document.
    /// </summary>
    public class OnlineDocumentEntry : BaseDocumentEntry
    {
        /// <summary>
        /// Gets or sets the path to document to append at the server.
        /// </summary>
        public virtual FileContent File { get; set; }


        /// <summary>
        /// Gets all file content properties.
        /// </summary>
        /// <returns>The http request instance.</returns>
        public override IEnumerable<FileContent> GetFileContent()
        {
            var result = new List<FileContent>();
            result.AddRange(base.GetFileContent());
            if (this.File != null){
                result.AddRange(this.File.GetFileContent());
            }

            return result;
        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnlineDocumentEntry {\n");
            sb.Append("  EncryptedPassword: ").Append(this.EncryptedPassword).Append("\n");
            sb.Append("  ImportFormatMode: ").Append(this.ImportFormatMode).Append("\n");
            sb.Append("  File: ").Append(this.File).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
