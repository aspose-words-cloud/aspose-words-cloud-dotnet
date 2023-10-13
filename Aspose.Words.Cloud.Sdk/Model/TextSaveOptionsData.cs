// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TextSaveOptionsData.cs">
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
    /// Container class for text save options.
    /// </summary>
    public class TextSaveOptionsData : TxtSaveOptionsBaseData, IModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether to add bi-directional marks before each BiDi run when exporting in plain text format.
        /// The default value is true.
        /// </summary>
        public virtual bool? AddBidiMarks { get; set; }

        /// <summary>
        /// Gets or sets an integer value that specifies the maximum number of characters per one line.
        /// The default value is 0, that means no limit.
        /// </summary>
        public virtual int? MaxCharactersPerLine { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the program should attempt to preserve layout of tables when saving in the plain text format.
        /// </summary>
        public virtual bool? PreserveTableLayout { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the program should simplify list labels in case of complex label formatting not being adequately represented by plain text.
        /// </summary>
        public virtual bool? SimplifyListLabels { get; set; }

        /// <summary>
        /// Gets the format of save.
        /// </summary>
        public override string SaveFormat { get; } = "txt";


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (this.MaxCharactersPerLine == null)
            {
                throw new ArgumentException("Property MaxCharactersPerLine in TextSaveOptionsData is required.");
            }

        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextSaveOptionsData {\n");
            sb.Append("  AllowEmbeddingPostScriptFonts: ").Append(this.AllowEmbeddingPostScriptFonts).Append("\n");
            sb.Append("  CustomTimeZoneInfoData: ").Append(this.CustomTimeZoneInfoData).Append("\n");
            sb.Append("  Dml3DEffectsRenderingMode: ").Append(this.Dml3DEffectsRenderingMode).Append("\n");
            sb.Append("  DmlEffectsRenderingMode: ").Append(this.DmlEffectsRenderingMode).Append("\n");
            sb.Append("  DmlRenderingMode: ").Append(this.DmlRenderingMode).Append("\n");
            sb.Append("  FileName: ").Append(this.FileName).Append("\n");
            sb.Append("  ImlRenderingMode: ").Append(this.ImlRenderingMode).Append("\n");
            sb.Append("  UpdateCreatedTimeProperty: ").Append(this.UpdateCreatedTimeProperty).Append("\n");
            sb.Append("  UpdateFields: ").Append(this.UpdateFields).Append("\n");
            sb.Append("  UpdateLastPrintedProperty: ").Append(this.UpdateLastPrintedProperty).Append("\n");
            sb.Append("  UpdateLastSavedTimeProperty: ").Append(this.UpdateLastSavedTimeProperty).Append("\n");
            sb.Append("  ZipOutput: ").Append(this.ZipOutput).Append("\n");
            sb.Append("  Encoding: ").Append(this.Encoding).Append("\n");
            sb.Append("  ExportHeadersFootersMode: ").Append(this.ExportHeadersFootersMode).Append("\n");
            sb.Append("  ForcePageBreaks: ").Append(this.ForcePageBreaks).Append("\n");
            sb.Append("  ParagraphBreak: ").Append(this.ParagraphBreak).Append("\n");
            sb.Append("  AddBidiMarks: ").Append(this.AddBidiMarks).Append("\n");
            sb.Append("  MaxCharactersPerLine: ").Append(this.MaxCharactersPerLine).Append("\n");
            sb.Append("  PreserveTableLayout: ").Append(this.PreserveTableLayout).Append("\n");
            sb.Append("  SimplifyListLabels: ").Append(this.SimplifyListLabels).Append("\n");
            sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
