// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MarkdownSaveOptionsData.cs">
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
    /// Container class for markdown save options.
    /// </summary>
    public class MarkdownSaveOptionsData : TxtSaveOptionsBaseData
    {
        /// <summary>
        /// Gets or sets the value, that specifies how to align contents in tables when exporting into the Markdown format.
        /// The default value is Auto.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TableContentAlignmentEnum
        {
            /// <summary>
            /// Enum value "Auto"
            /// </summary>
            Auto,

            /// <summary>
            /// Enum value "Left"
            /// </summary>
            Left,

            /// <summary>
            /// Enum value "Center"
            /// </summary>
            Center,

            /// <summary>
            /// Enum value "Right"
            /// </summary>
            Right,
        }

        /// <summary>
        /// Gets the format of save.
        /// </summary>
        public override string SaveFormat { get; } = "md";

        /// <summary>
        /// Gets or sets the value, that specifies how to align contents in tables when exporting into the Markdown format.
        /// The default value is Auto.
        /// </summary>
        public virtual TableContentAlignmentEnum? TableContentAlignment { get; set; }


        /// <summary>
        /// Collect all files content properties.
        /// </summary>
        /// <returns>The http request instance.</returns>
        public override void CollectFileReferences(List<FileReference> resultFileReferences)
        {
            base.CollectFileReferences(resultFileReferences);
        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarkdownSaveOptionsData {\n");
            sb.Append("  AllowEmbeddingPostScriptFonts: ").Append(this.AllowEmbeddingPostScriptFonts).Append("\n");
            sb.Append("  CustomTimeZoneInfoData: ").Append(this.CustomTimeZoneInfoData).Append("\n");
            sb.Append("  Dml3DEffectsRenderingMode: ").Append(this.Dml3DEffectsRenderingMode).Append("\n");
            sb.Append("  DmlEffectsRenderingMode: ").Append(this.DmlEffectsRenderingMode).Append("\n");
            sb.Append("  DmlRenderingMode: ").Append(this.DmlRenderingMode).Append("\n");
            sb.Append("  FileName: ").Append(this.FileName).Append("\n");
            sb.Append("  FlatOpcXmlMappingOnly: ").Append(this.FlatOpcXmlMappingOnly).Append("\n");
            sb.Append("  ImlRenderingMode: ").Append(this.ImlRenderingMode).Append("\n");
            sb.Append("  UpdateCreatedTimeProperty: ").Append(this.UpdateCreatedTimeProperty).Append("\n");
            sb.Append("  UpdateFields: ").Append(this.UpdateFields).Append("\n");
            sb.Append("  UpdateLastPrintedProperty: ").Append(this.UpdateLastPrintedProperty).Append("\n");
            sb.Append("  UpdateLastSavedTimeProperty: ").Append(this.UpdateLastSavedTimeProperty).Append("\n");
            sb.Append("  UpdateSdtContent: ").Append(this.UpdateSdtContent).Append("\n");
            sb.Append("  ZipOutput: ").Append(this.ZipOutput).Append("\n");
            sb.Append("  Encoding: ").Append(this.Encoding).Append("\n");
            sb.Append("  ExportHeadersFootersMode: ").Append(this.ExportHeadersFootersMode).Append("\n");
            sb.Append("  ForcePageBreaks: ").Append(this.ForcePageBreaks).Append("\n");
            sb.Append("  ParagraphBreak: ").Append(this.ParagraphBreak).Append("\n");
            sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
            sb.Append("  TableContentAlignment: ").Append(this.TableContentAlignment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
