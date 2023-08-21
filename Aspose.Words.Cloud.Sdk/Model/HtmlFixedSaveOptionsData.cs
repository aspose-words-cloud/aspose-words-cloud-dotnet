// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="HtmlFixedSaveOptionsData.cs">
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
    /// Container class for fixed html save options.
    /// </summary>
    public class HtmlFixedSaveOptionsData : FixedPageSaveOptionsData
    {
        /// <summary>
        /// Gets or sets the export format of fonts.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FontFormatEnum
        {
            /// <summary>
            /// Enum value "Woff"
            /// </summary>
            Woff,

            /// <summary>
            /// Enum value "Ttf"
            /// </summary>
            Ttf,
        }

        /// <summary>
        /// Gets or sets the horizontal alignment of pages in the HTML document.
        /// The default value is HtmlFixedHorizontalPageAlignment.Center.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PageHorizontalAlignmentEnum
        {
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
        /// Gets or sets the prefix which is added to all class names in style.css file.
        /// Default value is "aw".
        /// </summary>
        public virtual string CssClassNamesPrefix { get; set; }

        /// <summary>
        /// Gets or sets the character encoding.
        /// </summary>
        public virtual string Encoding { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the CSS (Cascading Style Sheet) should be embedded into the Html document.
        /// </summary>
        public virtual bool? ExportEmbeddedCss { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether fonts should be embedded into the Html document in Base64 format.
        /// </summary>
        public virtual bool? ExportEmbeddedFonts { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether images should be embedded into the Html document in Base64 format.
        /// </summary>
        public virtual bool? ExportEmbeddedImages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether form fields are exported as interactive items (as 'input' tag) rather than converted to text or graphics.
        /// </summary>
        public virtual bool? ExportFormFields { get; set; }

        /// <summary>
        /// Gets or sets the export format of fonts.
        /// </summary>
        public virtual FontFormatEnum? FontFormat { get; set; }

        /// <summary>
        /// Gets or sets the horizontal alignment of pages in the HTML document.
        /// The default value is HtmlFixedHorizontalPageAlignment.Center.
        /// </summary>
        public virtual PageHorizontalAlignmentEnum? PageHorizontalAlignment { get; set; }

        /// <summary>
        /// Gets or sets the margin around pages in HTML document.
        /// The margins value is measured in points and should be equal to or greater than 0.
        /// Default value is 10 points.
        /// </summary>
        public virtual double? PageMargins { get; set; }

        /// <summary>
        /// Gets or sets the physical folder where resources are saved when exporting the document.
        /// </summary>
        public virtual string ResourcesFolder { get; set; }

        /// <summary>
        /// Gets or sets the name of the folder used to construct resource URIs.
        /// </summary>
        public virtual string ResourcesFolderAlias { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether "@font-face" CSS rules should be placed into a separate file "fontFaces.css" when a document is being saved with external stylesheet (that is, when Aspose.Words.Saving.HtmlFixedSaveOptions.ExportEmbeddedCss is false). The default value is false, all CSS rules are written into single file "styles.css".
        /// </summary>
        public virtual bool? SaveFontFaceCssSeparately { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show border around pages.
        /// </summary>
        public virtual bool? ShowPageBorder { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether fonts from target machine must be used to display the document. If this flag is set to true, Aspose.Words.Saving.HtmlFixedSaveOptions.FontFormat and Aspose.Words.Saving.HtmlFixedSaveOptions.ExportEmbeddedFonts properties do not have effect, also Aspose.Words.Saving.HtmlFixedSaveOptions.ResourceSavingCallback is not fired for fonts. The default value is false.
        /// </summary>
        public virtual bool? UseTargetMachineFonts { get; set; }

        /// <summary>
        /// Gets the format of save.
        /// </summary>
        public override string SaveFormat { get; } = "htmlfixed";

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HtmlFixedSaveOptionsData {\n");
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
            sb.Append("  ColorMode: ").Append(this.ColorMode).Append("\n");
            sb.Append("  JpegQuality: ").Append(this.JpegQuality).Append("\n");
            sb.Append("  MetafileRenderingOptions: ").Append(this.MetafileRenderingOptions).Append("\n");
            sb.Append("  NumeralFormat: ").Append(this.NumeralFormat).Append("\n");
            sb.Append("  OptimizeOutput: ").Append(this.OptimizeOutput).Append("\n");
            sb.Append("  PageCount: ").Append(this.PageCount).Append("\n");
            sb.Append("  PageIndex: ").Append(this.PageIndex).Append("\n");
            sb.Append("  CssClassNamesPrefix: ").Append(this.CssClassNamesPrefix).Append("\n");
            sb.Append("  Encoding: ").Append(this.Encoding).Append("\n");
            sb.Append("  ExportEmbeddedCss: ").Append(this.ExportEmbeddedCss).Append("\n");
            sb.Append("  ExportEmbeddedFonts: ").Append(this.ExportEmbeddedFonts).Append("\n");
            sb.Append("  ExportEmbeddedImages: ").Append(this.ExportEmbeddedImages).Append("\n");
            sb.Append("  ExportFormFields: ").Append(this.ExportFormFields).Append("\n");
            sb.Append("  FontFormat: ").Append(this.FontFormat).Append("\n");
            sb.Append("  PageHorizontalAlignment: ").Append(this.PageHorizontalAlignment).Append("\n");
            sb.Append("  PageMargins: ").Append(this.PageMargins).Append("\n");
            sb.Append("  ResourcesFolder: ").Append(this.ResourcesFolder).Append("\n");
            sb.Append("  ResourcesFolderAlias: ").Append(this.ResourcesFolderAlias).Append("\n");
            sb.Append("  SaveFontFaceCssSeparately: ").Append(this.SaveFontFaceCssSeparately).Append("\n");
            sb.Append("  ShowPageBorder: ").Append(this.ShowPageBorder).Append("\n");
            sb.Append("  UseTargetMachineFonts: ").Append(this.UseTargetMachineFonts).Append("\n");
            sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
