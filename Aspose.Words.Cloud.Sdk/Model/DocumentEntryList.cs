// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DocumentEntryList.cs">
//   Copyright (c) 2025 Aspose.Words for Cloud
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
    /// Represents a list of documents which will be appended to the original resource document.
    /// </summary>
    public class DocumentEntryList : BaseEntryList, IFileReference, IModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether to append all documents to the same section.
        /// </summary>
        public virtual bool? AppendAllEntriesToOneSection { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to apply headers and footers from base document to appending documents. The default value is true.
        /// </summary>
        public virtual bool? ApplyBaseDocumentHeadersAndFootersToAppendingDocuments { get; set; }

        /// <summary>
        /// Gets or sets the list of documents.
        /// </summary>
        public virtual List<DocumentEntry> DocumentEntries { get; set; }

        /// <summary>
        /// Collect all files content properties.
        /// </summary>
        /// <param name="resultFileReferences">File references collection used to append new references from current model.</param>
        public override void CollectFileReferences(ref List<FileReference> resultFileReferences)
        {
            base.CollectFileReferences(ref resultFileReferences);
            if (this.DocumentEntries != null)
            {
                foreach (var element in this.DocumentEntries)
                {
                    element.CollectFileReferences(ref resultFileReferences);
                }
            }

        }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (this.DocumentEntries == null)
            {
                throw new ArgumentException("Property DocumentEntries in DocumentEntryList is required.");
            }

            if (this.DocumentEntries != null)
            {
                foreach (var elementDocumentEntries in this.DocumentEntries)
                {
                    elementDocumentEntries?.Validate();
                }
            }

        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentEntryList {\n");
            sb.Append("  AppendAllEntriesToOneSection: ").Append(this.AppendAllEntriesToOneSection).Append("\n");
            sb.Append("  ApplyBaseDocumentHeadersAndFootersToAppendingDocuments: ").Append(this.ApplyBaseDocumentHeadersAndFootersToAppendingDocuments).Append("\n");
            sb.Append("  DocumentEntries: ").Append(this.DocumentEntries).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
