// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FixedPageSaveOptionsData.cs">
//   Copyright (c) 2023 Aspose.Words for Cloud
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
    /// Contains common options that can be specified when saving a document into fixed page formats (PDF, XPS, images etc).
    /// </summary>
    public abstract class FixedPageSaveOptionsData : SaveOptionsData
    {
        /// <summary>
        /// Gets or sets the value determining how colors are rendered.
        /// { Normal | Grayscale}.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ColorModeEnum
        {
            /// <summary>
            /// Enum value "Normal"
            /// </summary>
            Normal,

            /// <summary>
            /// Enum value "Grayscale"
            /// </summary>
            Grayscale,
        }

        /// <summary>
        /// Gets or sets the symbol set, that is used to represent numbers while rendering to fixed page formats.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NumeralFormatEnum
        {
            /// <summary>
            /// Enum value "European"
            /// </summary>
            European,

            /// <summary>
            /// Enum value "ArabicIndic"
            /// </summary>
            ArabicIndic,

            /// <summary>
            /// Enum value "EasternArabicIndic"
            /// </summary>
            EasternArabicIndic,

            /// <summary>
            /// Enum value "Context"
            /// </summary>
            Context,

            /// <summary>
            /// Enum value "System"
            /// </summary>
            System,
        }

        /// <summary>
        /// Gets or sets the value determining how colors are rendered.
        /// { Normal | Grayscale}.
        /// </summary>
        public virtual ColorModeEnum? ColorMode { get; set; }

        /// <summary>
        /// Gets or sets the quality of the JPEG images inside PDF document.
        /// </summary>
        public virtual int? JpegQuality { get; set; }

        /// <summary>
        /// Gets or sets the metafile rendering options.
        /// </summary>
        public virtual MetafileRenderingOptionsData MetafileRenderingOptions { get; set; }

        /// <summary>
        /// Gets or sets the symbol set, that is used to represent numbers while rendering to fixed page formats.
        /// </summary>
        public virtual NumeralFormatEnum? NumeralFormat { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether it is required to optimize output of XPS.
        /// If this flag is set redundant nested canvases and empty canvases are removed, also neighbor glyphs with the same formatting are concatenated.
        /// Note: The accuracy of the content display may be affected if this property is set to true.. The default value is false.
        /// </summary>
        public virtual bool? OptimizeOutput { get; set; }

        /// <summary>
        /// Gets or sets the number of pages to render.
        /// </summary>
        public virtual int? PageCount { get; set; }

        /// <summary>
        /// Gets or sets the 0-based index of the first page to render.
        /// </summary>
        public virtual int? PageIndex { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FixedPageSaveOptionsData {\n");
            sb.Append("  AllowEmbeddingPostScriptFonts: ").Append(this.AllowEmbeddingPostScriptFonts).Append("\n");
            sb.Append("  CustomTimeZoneInfoData: ").Append(this.CustomTimeZoneInfoData).Append("\n");
            sb.Append("  Dml3DEffectsRenderingMode: ").Append(this.Dml3DEffectsRenderingMode).Append("\n");
            sb.Append("  DmlEffectsRenderingMode: ").Append(this.DmlEffectsRenderingMode).Append("\n");
            sb.Append("  DmlRenderingMode: ").Append(this.DmlRenderingMode).Append("\n");
            sb.Append("  FileName: ").Append(this.FileName).Append("\n");
            sb.Append("  ImlRenderingMode: ").Append(this.ImlRenderingMode).Append("\n");
            sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
            sb.Append("  UpdateCreatedTimeProperty: ").Append(this.UpdateCreatedTimeProperty).Append("\n");
            sb.Append("  UpdateFields: ").Append(this.UpdateFields).Append("\n");
            sb.Append("  UpdateLastPrintedProperty: ").Append(this.UpdateLastPrintedProperty).Append("\n");
            sb.Append("  UpdateLastSavedTimeProperty: ").Append(this.UpdateLastSavedTimeProperty).Append("\n");
            sb.Append("  UpdateSdtContent: ").Append(this.UpdateSdtContent).Append("\n");
            sb.Append("  ZipOutput: ").Append(this.ZipOutput).Append("\n");
            sb.Append("  ColorMode: ").Append(this.ColorMode).Append("\n");
            sb.Append("  JpegQuality: ").Append(this.JpegQuality).Append("\n");
            sb.Append("  MetafileRenderingOptions: ").Append(this.MetafileRenderingOptions).Append("\n");
            sb.Append("  NumeralFormat: ").Append(this.NumeralFormat).Append("\n");
            sb.Append("  OptimizeOutput: ").Append(this.OptimizeOutput).Append("\n");
            sb.Append("  PageCount: ").Append(this.PageCount).Append("\n");
            sb.Append("  PageIndex: ").Append(this.PageIndex).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
