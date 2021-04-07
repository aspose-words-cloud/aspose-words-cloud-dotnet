// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TxtSaveOptionsBaseData.cs">
//   Copyright (c) 2021 Aspose.Words for Cloud
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
    /// Base class for save options of text formats.
    /// </summary>
    public class TxtSaveOptionsBaseData : SaveOptionsData
    {
        /// <summary>
        /// Gets or sets the option that controls whether to output headers and footers when exporting in plain text format.
        /// default value is TxtExportHeadersFootersMode.PrimaryOnly.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExportHeadersFootersModeEnum
        { 
            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,

            /// <summary>
            /// Enum value "PrimaryOnly"
            /// </summary>
            PrimaryOnly,

            /// <summary>
            /// Enum value "AllAtEnd"
            /// </summary>
            AllAtEnd
        }

        /// <summary>
        /// Gets or sets the character encoding to use when exporting in plain text format.
        /// </summary>  
        public string Encoding { get; set; }

        /// <summary>
        /// Gets or sets the option that controls whether to output headers and footers when exporting in plain text format.
        /// default value is TxtExportHeadersFootersMode.PrimaryOnly.
        /// </summary>  
        public ExportHeadersFootersModeEnum? ExportHeadersFootersMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the page breaks should be preserved during export.
        /// The default value is false.
        /// </summary>  
        public bool? ForcePageBreaks { get; set; }

        /// <summary>
        /// Gets or sets the string to use as a paragraph break when exporting in plain text format.
        /// </summary>  
        public string ParagraphBreak { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class TxtSaveOptionsBaseData {\n");
            sb.Append("  Encoding: ").Append(this.Encoding).Append("\n");
            sb.Append("  ExportHeadersFootersMode: ").Append(this.ExportHeadersFootersMode).Append("\n");
            sb.Append("  ForcePageBreaks: ").Append(this.ForcePageBreaks).Append("\n");
            sb.Append("  ParagraphBreak: ").Append(this.ParagraphBreak).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
