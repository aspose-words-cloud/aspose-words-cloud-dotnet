// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="HtmlFixedSaveOptionsData.cs">
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
    /// Container class for fixed html save options.
    /// </summary>
    public class HtmlFixedSaveOptionsData : FixedPageSaveOptionsData
    {
        /// <summary>
        /// Gets or sets the prefix which is added to all class names in style.css file.
        /// Default value is "aw".
        /// </summary>  
        public string CssClassNamesPrefix { get; set; }

        /// <summary>
        /// Gets or sets the character encoding.
        /// </summary>  
        public string Encoding { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the CSS (Cascading Style Sheet) should be embedded into the Html document.
        /// </summary>  
        public bool? ExportEmbeddedCss { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether fonts should be embedded into the Html document in Base64 format.
        /// </summary>  
        public bool? ExportEmbeddedFonts { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether images should be embedded into the Html document in Base64 format.
        /// </summary>  
        public bool? ExportEmbeddedImages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether form fields are exported as interactive items (as 'input' tag) rather than converted to text or graphics.
        /// </summary>  
        public bool? ExportFormFields { get; set; }

        /// <summary>
        /// Gets or sets the export format of fonts.
        /// </summary>  
        public string FontFormat { get; set; }

        /// <summary>
        /// Gets or sets the horizontal alignment of pages in the HTML document.
        /// The default value is HtmlFixedHorizontalPageAlignment.Center.
        /// </summary>  
        public string PageHorizontalAlignment { get; set; }

        /// <summary>
        /// Gets or sets the margin around pages in HTML document.
        /// The margins value is measured in points and should be equal to or greater than 0.
        /// Default value is 10 points.
        /// </summary>  
        public double? PageMargins { get; set; }

        /// <summary>
        /// Gets or sets the physical folder where resources are saved when exporting the document.
        /// </summary>  
        public string ResourcesFolder { get; set; }

        /// <summary>
        /// Gets or sets the name of the folder used to construct resource URIs.
        /// </summary>  
        public string ResourcesFolderAlias { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether "@font-face" CSS rules should be placed into a separate file "fontFaces.css" when a document is being saved with external stylesheet (that is, when Aspose.Words.Saving.HtmlFixedSaveOptions.ExportEmbeddedCss is false). The default value is false, all CSS rules are written into single file "styles.css".
        /// </summary>  
        public bool? SaveFontFaceCssSeparately { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show border around pages.
        /// </summary>  
        public bool? ShowPageBorder { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether fonts from target machine must be used to display the document. If this flag is set to true, Aspose.Words.Saving.HtmlFixedSaveOptions.FontFormat and Aspose.Words.Saving.HtmlFixedSaveOptions.ExportEmbeddedFonts properties do not have effect, also Aspose.Words.Saving.HtmlFixedSaveOptions.ResourceSavingCallback is not fired for fonts. The default value is false.
        /// </summary>  
        public bool? UseTargetMachineFonts { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class HtmlFixedSaveOptionsData {\n");
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
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
