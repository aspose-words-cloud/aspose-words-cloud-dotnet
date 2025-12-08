// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TxtSaveOptionsBaseData.cs">
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
    /// Base class for save options of text formats.
    /// </summary>
    public abstract class TxtSaveOptionsBaseData : SaveOptionsData, IModel
    {
        /// <summary>
        /// Gets or sets the option that controls whether to output headers and footers when exporting in plain text format.
        /// The default value is TxtExportHeadersFootersMode.PrimaryOnly.
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
            AllAtEnd,
        }

        /// <summary>
        /// Gets or sets the character encoding to use when exporting in plain text format.
        /// </summary>
        public virtual string Encoding { get; set; }

        /// <summary>
        /// Gets or sets the option that controls whether to output headers and footers when exporting in plain text format.
        /// The default value is TxtExportHeadersFootersMode.PrimaryOnly.
        /// </summary>
        public virtual ExportHeadersFootersModeEnum? ExportHeadersFootersMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the page breaks should be preserved during export.
        /// The default value is false.
        /// </summary>
        public virtual bool? ForcePageBreaks { get; set; }

        /// <summary>
        /// Gets or sets the string to use as a paragraph break when exporting in plain text format.
        /// </summary>
        public virtual string ParagraphBreak { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TxtSaveOptionsBaseData {\n");
            sb.Append("  AllowEmbeddingPostScriptFonts: ").Append(this.AllowEmbeddingPostScriptFonts).Append("\n");
            sb.Append("  CustomTimeZoneInfoData: ").Append(this.CustomTimeZoneInfoData).Append("\n");
            sb.Append("  Dml3DEffectsRenderingMode: ").Append(this.Dml3DEffectsRenderingMode).Append("\n");
            sb.Append("  DmlEffectsRenderingMode: ").Append(this.DmlEffectsRenderingMode).Append("\n");
            sb.Append("  DmlRenderingMode: ").Append(this.DmlRenderingMode).Append("\n");
            sb.Append("  FileName: ").Append(this.FileName).Append("\n");
            sb.Append("  ImlRenderingMode: ").Append(this.ImlRenderingMode).Append("\n");
            sb.Append("  UpdateAmbiguousTextFont: ").Append(this.UpdateAmbiguousTextFont).Append("\n");
            sb.Append("  UpdateCreatedTimeProperty: ").Append(this.UpdateCreatedTimeProperty).Append("\n");
            sb.Append("  UpdateFields: ").Append(this.UpdateFields).Append("\n");
            sb.Append("  UpdateLastPrintedProperty: ").Append(this.UpdateLastPrintedProperty).Append("\n");
            sb.Append("  UpdateLastSavedTimeProperty: ").Append(this.UpdateLastSavedTimeProperty).Append("\n");
            sb.Append("  ZipOutput: ").Append(this.ZipOutput).Append("\n");
            sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
            sb.Append("  Encoding: ").Append(this.Encoding).Append("\n");
            sb.Append("  ExportHeadersFootersMode: ").Append(this.ExportHeadersFootersMode).Append("\n");
            sb.Append("  ForcePageBreaks: ").Append(this.ForcePageBreaks).Append("\n");
            sb.Append("  ParagraphBreak: ").Append(this.ParagraphBreak).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
