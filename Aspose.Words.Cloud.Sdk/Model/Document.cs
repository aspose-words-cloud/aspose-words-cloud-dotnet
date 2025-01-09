// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Document.cs">
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
    /// Represents Words document DTO.
    /// </summary>
    public class Document : IModel
    {
        /// <summary>
        /// Gets or sets the original format of the document.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceFormatEnum
        {
            /// <summary>
            /// Enum value "Unknown"
            /// </summary>
            Unknown,

            /// <summary>
            /// Enum value "Doc"
            /// </summary>
            Doc,

            /// <summary>
            /// Enum value "Dot"
            /// </summary>
            Dot,

            /// <summary>
            /// Enum value "DocPreWord60"
            /// </summary>
            DocPreWord60,

            /// <summary>
            /// Enum value "Docx"
            /// </summary>
            Docx,

            /// <summary>
            /// Enum value "Docm"
            /// </summary>
            Docm,

            /// <summary>
            /// Enum value "Dotx"
            /// </summary>
            Dotx,

            /// <summary>
            /// Enum value "Dotm"
            /// </summary>
            Dotm,

            /// <summary>
            /// Enum value "FlatOpc"
            /// </summary>
            FlatOpc,

            /// <summary>
            /// Enum value "Rtf"
            /// </summary>
            Rtf,

            /// <summary>
            /// Enum value "WordML"
            /// </summary>
            WordML,

            /// <summary>
            /// Enum value "Html"
            /// </summary>
            Html,

            /// <summary>
            /// Enum value "Mhtml"
            /// </summary>
            Mhtml,

            /// <summary>
            /// Enum value "Epub"
            /// </summary>
            Epub,

            /// <summary>
            /// Enum value "Text"
            /// </summary>
            Text,

            /// <summary>
            /// Enum value "Odt"
            /// </summary>
            Odt,

            /// <summary>
            /// Enum value "Ott"
            /// </summary>
            Ott,

            /// <summary>
            /// Enum value "Pdf"
            /// </summary>
            Pdf,

            /// <summary>
            /// Enum value "Xps"
            /// </summary>
            Xps,

            /// <summary>
            /// Enum value "Tiff"
            /// </summary>
            Tiff,

            /// <summary>
            /// Enum value "Svg"
            /// </summary>
            Svg,

            /// <summary>
            /// Enum value "Azw3"
            /// </summary>
            Azw3,
        }

        /// <summary>
        /// Gets or sets the list of links that originate from this document.
        /// </summary>
        public virtual List<Link> Links { get; set; }

        /// <summary>
        /// Gets or sets the document properties.
        /// </summary>
        public virtual DocumentProperties DocumentProperties { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        public virtual string FileName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the document is encrypted and requires a password to open.
        /// </summary>
        public virtual bool? IsEncrypted { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the document contains a digital signature. This property merely informs that a digital signature is present on a document, but it does not specify whether the signature is valid or not.
        /// </summary>
        public virtual bool? IsSigned { get; set; }

        /// <summary>
        /// Gets or sets the original format of the document.
        /// </summary>
        public virtual SourceFormatEnum? SourceFormat { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public virtual void Validate()
        {
            if (this.IsEncrypted == null)
            {
                throw new ArgumentException("Property IsEncrypted in Document is required.");
            }
            if (this.IsSigned == null)
            {
                throw new ArgumentException("Property IsSigned in Document is required.");
            }
            if (this.SourceFormat == null)
            {
                throw new ArgumentException("Property SourceFormat in Document is required.");
            }

            if (this.Links != null)
            {
                foreach (var elementLinks in this.Links)
                {
                    elementLinks?.Validate();
                }
            }



            this.DocumentProperties?.Validate();





        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Document {\n");
            sb.Append("  Links: ").Append(this.Links).Append("\n");
            sb.Append("  DocumentProperties: ").Append(this.DocumentProperties).Append("\n");
            sb.Append("  FileName: ").Append(this.FileName).Append("\n");
            sb.Append("  IsEncrypted: ").Append(this.IsEncrypted).Append("\n");
            sb.Append("  IsSigned: ").Append(this.IsSigned).Append("\n");
            sb.Append("  SourceFormat: ").Append(this.SourceFormat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
