// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SaveOptionsData.cs">
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
    /// base container class for save options data.
    /// </summary>
    public class SaveOptionsData
    {
        /// <summary>
        /// Gets or sets the value determining how 3D effects are rendered.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Dml3DEffectsRenderingModeEnum
        {
            /// <summary>
            /// Enum value "Basic"
            /// </summary>
            Basic,

            /// <summary>
            /// Enum value "Advanced"
            /// </summary>
            Advanced,
        }

        /// <summary>
        /// Gets or sets a boolean value indicating whether to allow embedding fonts with PostScript outlines when embedding TrueType fonts in a document upon it is saved. The default value is false..
        /// </summary>
        public virtual bool? AllowEmbeddingPostScriptFonts { get; set; }

        /// <summary>
        /// Gets or sets CustomTimeZoneInfo.
        /// </summary>
        public virtual TimeZoneInfoData CustomTimeZoneInfoData { get; set; }

        /// <summary>
        /// Gets or sets the value determining how 3D effects are rendered.
        /// </summary>
        public virtual Dml3DEffectsRenderingModeEnum? Dml3DEffectsRenderingMode { get; set; }

        /// <summary>
        /// Gets or sets the value determining how DrawingML effects are rendered.
        /// { Simplified | None | Fine }.
        /// </summary>
        public virtual string DmlEffectsRenderingMode { get; set; }

        /// <summary>
        /// Gets or sets the option that controls how DrawingML shapes are rendered.
        /// </summary>
        public virtual string DmlRenderingMode { get; set; }

        /// <summary>
        /// Gets or sets the name of destination file.
        /// </summary>
        public virtual string FileName { get; set; }

        /// <summary>
        /// Gets or sets value determining which document formats are allowed to be mapped by Aspose.Words.Markup.StructuredDocumentTag.XmlMapping.
        /// By default only Aspose.Words.LoadFormat.FlatOpc document format is allowed to be mapped.
        /// </summary>
        public virtual bool? FlatOpcXmlMappingOnly { get; set; }

        /// <summary>
        /// Gets or sets the value determining how ink (InkML) objects are rendered.
        /// </summary>
        public virtual string ImlRenderingMode { get; set; }

        /// <summary>
        /// Gets the format of save.
        /// </summary>
        public virtual string SaveFormat { get; }

        /// <summary>
        /// Gets or sets a value determining whether the Aspose.Words.Properties.BuiltInDocumentProperties.CreatedTime property is updated before saving.
        /// Default value is false.
        /// </summary>
        public virtual bool? UpdateCreatedTimeProperty { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether fields should be updated before saving the document to a fixed page format. The default value is true.
        /// </summary>
        public virtual bool? UpdateFields { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the Aspose.Words.Properties.BuiltInDocumentProperties.LastPrinted property is updated before saving.
        /// </summary>
        public virtual bool? UpdateLastPrintedProperty { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the Aspose.Words.Properties.BuiltInDocumentProperties.LastSavedTime property is updated before saving.
        /// </summary>
        public virtual bool? UpdateLastSavedTimeProperty { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether content of StructuredDocumentTag is updated before saving.
        /// </summary>
        public virtual bool? UpdateSdtContent { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to zip output or not.
        /// The default value is false.
        /// </summary>
        public virtual bool? ZipOutput { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveOptionsData {\n");
            sb.Append("  AllowEmbeddingPostScriptFonts: ").Append(this.AllowEmbeddingPostScriptFonts).Append("\n");
            sb.Append("  CustomTimeZoneInfoData: ").Append(this.CustomTimeZoneInfoData).Append("\n");
            sb.Append("  Dml3DEffectsRenderingMode: ").Append(this.Dml3DEffectsRenderingMode).Append("\n");
            sb.Append("  DmlEffectsRenderingMode: ").Append(this.DmlEffectsRenderingMode).Append("\n");
            sb.Append("  DmlRenderingMode: ").Append(this.DmlRenderingMode).Append("\n");
            sb.Append("  FileName: ").Append(this.FileName).Append("\n");
            sb.Append("  FlatOpcXmlMappingOnly: ").Append(this.FlatOpcXmlMappingOnly).Append("\n");
            sb.Append("  ImlRenderingMode: ").Append(this.ImlRenderingMode).Append("\n");
            sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
            sb.Append("  UpdateCreatedTimeProperty: ").Append(this.UpdateCreatedTimeProperty).Append("\n");
            sb.Append("  UpdateFields: ").Append(this.UpdateFields).Append("\n");
            sb.Append("  UpdateLastPrintedProperty: ").Append(this.UpdateLastPrintedProperty).Append("\n");
            sb.Append("  UpdateLastSavedTimeProperty: ").Append(this.UpdateLastSavedTimeProperty).Append("\n");
            sb.Append("  UpdateSdtContent: ").Append(this.UpdateSdtContent).Append("\n");
            sb.Append("  ZipOutput: ").Append(this.ZipOutput).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
