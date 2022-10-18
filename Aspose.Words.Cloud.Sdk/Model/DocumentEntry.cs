// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DocumentEntry.cs">
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
    public class DocumentEntry : BaseEntry, IFileReference
    {
        /// <summary>
        /// Gets or sets document password encrypted on API public key. The default value is null (the document has no password).
        /// </summary>
        public virtual string EncryptedPassword { get; set; }

        /// <summary>
        /// Gets or sets the option that controls formatting will be used: appended or destination document. Can be KeepSourceFormatting or UseDestinationStyles.
        /// </summary>
        public virtual string ImportFormatMode { get; set; }

        /// <summary>
        /// Collect all files content properties.
        /// </summary>
        /// <param name="resultFileReferences">File references collection used to append new references from current model.</param>
        public override void CollectFileReferences(ref List<FileReference> resultFileReferences)
        {
            base.CollectFileReferences(ref resultFileReferences);
        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentEntry {\n");
            sb.Append("  FileReference: ").Append(this.FileReference).Append("\n");
            sb.Append("  EncryptedPassword: ").Append(this.EncryptedPassword).Append("\n");
            sb.Append("  ImportFormatMode: ").Append(this.ImportFormatMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
