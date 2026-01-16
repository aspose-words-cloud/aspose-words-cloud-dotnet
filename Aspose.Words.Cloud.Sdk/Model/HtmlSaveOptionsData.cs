// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="HtmlSaveOptionsData.cs">
//   Copyright (c) 2026 Aspose.Words for Cloud
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
    /// Container class for html save options.
    /// </summary>
    public class HtmlSaveOptionsData : SaveOptionsData, IModel
    {
        /// <summary>
        /// Gets or sets the option that controls how the CSS styles are exported.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CssStyleSheetTypeEnum
        {
            /// <summary>
            /// Enum value "Inline"
            /// </summary>
            Inline,

            /// <summary>
            /// Enum value "Embedded"
            /// </summary>
            Embedded,

            /// <summary>
            /// Enum value "External"
            /// </summary>
            External,
        }

        /// <summary>
        /// Gets or sets the option that controls how the document should be split when saving.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DocumentSplitCriteriaEnum
        {
            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,

            /// <summary>
            /// Enum value "PageBreak"
            /// </summary>
            PageBreak,

            /// <summary>
            /// Enum value "ColumnBreak"
            /// </summary>
            ColumnBreak,

            /// <summary>
            /// Enum value "SectionBreak"
            /// </summary>
            SectionBreak,

            /// <summary>
            /// Enum value "HeadingParagraph"
            /// </summary>
            HeadingParagraph,
        }

        /// <summary>
        /// Gets or sets the option that controls how headers and footers are exported.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExportHeadersFootersModeEnum
        {
            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,

            /// <summary>
            /// Enum value "PerSection"
            /// </summary>
            PerSection,

            /// <summary>
            /// Enum value "FirstSectionHeaderLastSectionFooter"
            /// </summary>
            FirstSectionHeaderLastSectionFooter,

            /// <summary>
            /// Enum value "FirstPageHeaderFooterPerSection"
            /// </summary>
            FirstPageHeaderFooterPerSection,
        }

        /// <summary>
        /// Gets or sets the option that controls how list labels are exported.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExportListLabelsEnum
        {
            /// <summary>
            /// Enum value "Auto"
            /// </summary>
            Auto,

            /// <summary>
            /// Enum value "AsInlineText"
            /// </summary>
            AsInlineText,

            /// <summary>
            /// Enum value "ByHtmlTags"
            /// </summary>
            ByHtmlTags,
        }

        /// <summary>
        /// Gets or sets the version of HTML standard, that should be used when saving the document to HTML or MHTML.
        /// The default value is Aspose.Words.Saving.HtmlVersion.Xhtml.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HtmlVersionEnum
        {
            /// <summary>
            /// Enum value "Xhtml"
            /// </summary>
            Xhtml,

            /// <summary>
            /// Enum value "Html5"
            /// </summary>
            Html5,
        }

        /// <summary>
        /// Gets or sets the options, that controls in what format metafiles are saved when exporting to HTML, MHTML, or EPUB.
        /// The default value is Aspose.Words.Saving.HtmlMetafileFormat.Png, meaning that metafiles are rendered to raster PNG images.
        /// Metafiles are not natively displayed by HTML browsers. By default, Aspose.Words converts WMF and EMF images into PNG files when exporting to HTML.Other options are to convert metafiles to SVG images or to export them as is without conversion.
        /// Some image transforms, in particular image cropping, will not be applied to metafile images if they are exported to HTML without conversion.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MetafileFormatEnum
        {
            /// <summary>
            /// Enum value "Png"
            /// </summary>
            Png,

            /// <summary>
            /// Enum value "Svg"
            /// </summary>
            Svg,

            /// <summary>
            /// Enum value "EmfOrWmf"
            /// </summary>
            EmfOrWmf,
        }

        /// <summary>
        /// Gets or sets the option that controls how OfficeMath objects are exported to HTML, MHTML or EPUB. The default value is HtmlOfficeMathOutputMode.Image.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OfficeMathOutputModeEnum
        {
            /// <summary>
            /// Enum value "Image"
            /// </summary>
            Image,

            /// <summary>
            /// Enum value "MathML"
            /// </summary>
            MathML,

            /// <summary>
            /// Enum value "Text"
            /// </summary>
            Text,
        }

        /// <summary>
        /// Gets or sets the option that controls how table, row and cell widths are exported.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TableWidthOutputModeEnum
        {
            /// <summary>
            /// Enum value "All"
            /// </summary>
            All,

            /// <summary>
            /// Enum value "RelativeOnly"
            /// </summary>
            RelativeOnly,

            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,
        }

        /// <summary>
        /// Gets or sets a value indicating whether negative left and right indents of paragraphs are allowed (not normalized).
        /// </summary>
        public virtual bool? AllowNegativeIndent { get; set; }

        /// <summary>
        /// Gets or sets the prefix which is added to all CSS class names. The default value is an empty string and generated CSS class names have no common prefix.
        /// If this value is not empty, all CSS classes generated by Aspose.Words will start with the specified prefix.This might be useful, for example, if you add custom CSS to generated documents and want to prevent class name conflicts.
        /// If the value is not null or empty, it must be a valid CSS identifier.
        /// </summary>
        public virtual string CssClassNamePrefix { get; set; }

        /// <summary>
        /// Gets or sets the name of the CSS file written when the document is exported to HTML.
        /// </summary>
        public virtual string CssStyleSheetFileName { get; set; }

        /// <summary>
        /// Gets or sets the option that controls how the CSS styles are exported.
        /// </summary>
        public virtual CssStyleSheetTypeEnum? CssStyleSheetType { get; set; }

        /// <summary>
        /// Gets or sets the option that controls how the document should be split when saving.
        /// </summary>
        public virtual DocumentSplitCriteriaEnum? DocumentSplitCriteria { get; set; }

        /// <summary>
        /// Gets or sets the maximum level of headings at which to split the document.
        /// </summary>
        public virtual int? DocumentSplitHeadingLevel { get; set; }

        /// <summary>
        /// Gets or sets the character encoding to use when exporting.
        /// </summary>
        public virtual string Encoding { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to export built-in and custom document properties.
        /// </summary>
        public virtual bool? ExportDocumentProperties { get; set; }

        /// <summary>
        /// Gets or sets the flag, that controls how drop-down form fields are saved to HTML.
        /// The default value is false.
        /// When set to true, exports drop-down form fields as normal text.
        /// When false, exports drop-down form fields as SELECT element in HTML.
        /// </summary>
        public virtual bool? ExportDropDownFormFieldAsText { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether font resources should be exported.
        /// </summary>
        public virtual bool? ExportFontResources { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether fonts resources should be embedded to HTML in Base64 encoding. The default value is false.
        /// </summary>
        public virtual bool? ExportFontsAsBase64 { get; set; }

        /// <summary>
        /// Gets or sets the option that controls how headers and footers are exported.
        /// </summary>
        public virtual ExportHeadersFootersModeEnum? ExportHeadersFootersMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether images are saved in Base64 format.
        /// </summary>
        public virtual bool? ExportImagesAsBase64 { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether language information is exported.
        /// </summary>
        public virtual bool? ExportLanguageInformation { get; set; }

        /// <summary>
        /// Gets or sets the option that controls how list labels are exported.
        /// </summary>
        public virtual ExportListLabelsEnum? ExportListLabels { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the original URL should be used as the URL of the linked images.
        /// The default value is false.
        /// If value is set to true - ResourceFolder value is used as the URL of linked images and linked images are not loaded into document's folder or ImagesFolder.If value is set to false - linked images are loaded into document's folder or ImagesFolder and URL of each linked image is constructed depending on document's folder, ImagesFolder and ImagesFolderAlias properties.
        /// </summary>
        public virtual bool? ExportOriginalUrlForLinkedImages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether page margins are exported to HTML, MHTML or EPUB.
        /// The default value is false.
        /// Aspose.Words does not show the area of page margins by default. If any elements are completely or partially clipped by the document edge the displayed area can be extended with this option.
        /// </summary>
        public virtual bool? ExportPageMargins { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether page setup is exported.
        /// </summary>
        public virtual bool? ExportPageSetup { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether font sizes should be output in relative units when saving.
        /// </summary>
        public virtual bool? ExportRelativeFontSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to write the roundtrip information when saving to HTML. The default value is true.
        /// Saving of the roundtrip information allows to restore document properties such as tab stops, comments, headers and footers during the HTML documents loading back into a Document object.When true, the roundtrip information is exported as -aw-* CSS properties of the corresponding HTML elements.When false, causes no roundtrip information to be output into produced files.
        /// </summary>
        public virtual bool? ExportRoundtripInformation { get; set; }

        /// <summary>
        /// Gets or sets the flag, that controls how text input form fields are saved.
        /// </summary>
        public virtual bool? ExportTextInputFormFieldAsText { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to write page numbers to table of contents when saving.
        /// </summary>
        public virtual bool? ExportTocPageNumbers { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to write the DOCTYPE declaration when saving.
        /// </summary>
        public virtual bool? ExportXhtmlTransitional { get; set; }

        /// <summary>
        /// Gets or sets the option that controls which font resources need subsetting when saving.
        /// </summary>
        public virtual int? FontResourcesSubsettingSizeThreshold { get; set; }

        /// <summary>
        /// Gets or sets the physical folder where fonts are saved when exporting a document.
        /// </summary>
        public virtual string FontsFolder { get; set; }

        /// <summary>
        /// Gets or sets the name of the folder used to construct font URIs.
        /// </summary>
        public virtual string FontsFolderAlias { get; set; }

        /// <summary>
        /// Gets or sets the version of HTML standard, that should be used when saving the document to HTML or MHTML.
        /// The default value is Aspose.Words.Saving.HtmlVersion.Xhtml.
        /// </summary>
        public virtual HtmlVersionEnum? HtmlVersion { get; set; }

        /// <summary>
        /// Gets or sets the output resolution for images when exporting.
        /// </summary>
        public virtual int? ImageResolution { get; set; }

        /// <summary>
        /// Gets or sets the physical folder where images are saved when exporting a document.
        /// </summary>
        public virtual string ImagesFolder { get; set; }

        /// <summary>
        /// Gets or sets the name of the folder used to construct image URIs.
        /// </summary>
        public virtual string ImagesFolderAlias { get; set; }

        /// <summary>
        /// Gets or sets the options, that controls in what format metafiles are saved when exporting to HTML, MHTML, or EPUB.
        /// The default value is Aspose.Words.Saving.HtmlMetafileFormat.Png, meaning that metafiles are rendered to raster PNG images.
        /// Metafiles are not natively displayed by HTML browsers. By default, Aspose.Words converts WMF and EMF images into PNG files when exporting to HTML.Other options are to convert metafiles to SVG images or to export them as is without conversion.
        /// Some image transforms, in particular image cropping, will not be applied to metafile images if they are exported to HTML without conversion.
        /// </summary>
        public virtual MetafileFormatEnum? MetafileFormat { get; set; }

        /// <summary>
        /// Gets or sets the option that controls how OfficeMath objects are exported to HTML, MHTML or EPUB. The default value is HtmlOfficeMathOutputMode.Image.
        /// </summary>
        public virtual OfficeMathOutputModeEnum? OfficeMathOutputMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use pretty formats output.
        /// </summary>
        public virtual bool? PrettyFormat { get; set; }

        /// <summary>
        /// Gets or sets the flag that indicates whether JavaScript will be removed from links.
        /// Default is false.
        /// If this option is enabled, all links containing JavaScript (e.g., links with "javascript:" in the href attribute)
        /// will be replaced with "javascript:void(0)". This can help prevent potential security risks, such as XSS attacks.
        /// </summary>
        public virtual bool? RemoveJavaScriptFromLinks { get; set; }

        /// <summary>
        /// Gets or sets the flag that indicates whether backslash characters should be replaced with yen signs.
        /// The default value is false.
        /// By default, Aspose.Words mimics MS Word's behavior and doesn't replace backslash characters with yen signs in
        /// generated HTML documents. However, previous versions of Aspose.Words performed such replacements in certain
        /// scenarios. This flag enables backward compatibility with previous versions of Aspose.Words.
        /// </summary>
        public virtual bool? ReplaceBackslashWithYenSign { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether font family names used in the document are resolved and substituted according to FontSettings when being written into HTML-based formats.
        /// The default value is false.
        /// </summary>
        public virtual bool? ResolveFontNames { get; set; }

        /// <summary>
        /// Gets or sets the physical folder where all resources like images, fonts, and external CSS are saved when a document is exported to HTML. The default value is an empty string.
        /// </summary>
        public virtual string ResourceFolder { get; set; }

        /// <summary>
        /// Gets or sets the name of the folder used to construct URIs of all resources written into HTML document. The default value is an empty string.
        /// </summary>
        public virtual string ResourceFolderAlias { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether images are scaled by Aspose.Words to the bounding shape size when exporting.
        /// </summary>
        public virtual bool? ScaleImageToShapeSize { get; set; }

        /// <summary>
        /// Gets or sets the option that controls how table, row and cell widths are exported.
        /// </summary>
        public virtual TableWidthOutputModeEnum? TableWidthOutputMode { get; set; }

        /// <summary>
        /// Gets the format of save.
        /// </summary>
        public override string SaveFormat { get; } = "html";


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
            sb.Append("class HtmlSaveOptionsData {\n");
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
            sb.Append("  AllowNegativeIndent: ").Append(this.AllowNegativeIndent).Append("\n");
            sb.Append("  CssClassNamePrefix: ").Append(this.CssClassNamePrefix).Append("\n");
            sb.Append("  CssStyleSheetFileName: ").Append(this.CssStyleSheetFileName).Append("\n");
            sb.Append("  CssStyleSheetType: ").Append(this.CssStyleSheetType).Append("\n");
            sb.Append("  DocumentSplitCriteria: ").Append(this.DocumentSplitCriteria).Append("\n");
            sb.Append("  DocumentSplitHeadingLevel: ").Append(this.DocumentSplitHeadingLevel).Append("\n");
            sb.Append("  Encoding: ").Append(this.Encoding).Append("\n");
            sb.Append("  ExportDocumentProperties: ").Append(this.ExportDocumentProperties).Append("\n");
            sb.Append("  ExportDropDownFormFieldAsText: ").Append(this.ExportDropDownFormFieldAsText).Append("\n");
            sb.Append("  ExportFontResources: ").Append(this.ExportFontResources).Append("\n");
            sb.Append("  ExportFontsAsBase64: ").Append(this.ExportFontsAsBase64).Append("\n");
            sb.Append("  ExportHeadersFootersMode: ").Append(this.ExportHeadersFootersMode).Append("\n");
            sb.Append("  ExportImagesAsBase64: ").Append(this.ExportImagesAsBase64).Append("\n");
            sb.Append("  ExportLanguageInformation: ").Append(this.ExportLanguageInformation).Append("\n");
            sb.Append("  ExportListLabels: ").Append(this.ExportListLabels).Append("\n");
            sb.Append("  ExportOriginalUrlForLinkedImages: ").Append(this.ExportOriginalUrlForLinkedImages).Append("\n");
            sb.Append("  ExportPageMargins: ").Append(this.ExportPageMargins).Append("\n");
            sb.Append("  ExportPageSetup: ").Append(this.ExportPageSetup).Append("\n");
            sb.Append("  ExportRelativeFontSize: ").Append(this.ExportRelativeFontSize).Append("\n");
            sb.Append("  ExportRoundtripInformation: ").Append(this.ExportRoundtripInformation).Append("\n");
            sb.Append("  ExportTextInputFormFieldAsText: ").Append(this.ExportTextInputFormFieldAsText).Append("\n");
            sb.Append("  ExportTocPageNumbers: ").Append(this.ExportTocPageNumbers).Append("\n");
            sb.Append("  ExportXhtmlTransitional: ").Append(this.ExportXhtmlTransitional).Append("\n");
            sb.Append("  FontResourcesSubsettingSizeThreshold: ").Append(this.FontResourcesSubsettingSizeThreshold).Append("\n");
            sb.Append("  FontsFolder: ").Append(this.FontsFolder).Append("\n");
            sb.Append("  FontsFolderAlias: ").Append(this.FontsFolderAlias).Append("\n");
            sb.Append("  HtmlVersion: ").Append(this.HtmlVersion).Append("\n");
            sb.Append("  ImageResolution: ").Append(this.ImageResolution).Append("\n");
            sb.Append("  ImagesFolder: ").Append(this.ImagesFolder).Append("\n");
            sb.Append("  ImagesFolderAlias: ").Append(this.ImagesFolderAlias).Append("\n");
            sb.Append("  MetafileFormat: ").Append(this.MetafileFormat).Append("\n");
            sb.Append("  OfficeMathOutputMode: ").Append(this.OfficeMathOutputMode).Append("\n");
            sb.Append("  PrettyFormat: ").Append(this.PrettyFormat).Append("\n");
            sb.Append("  RemoveJavaScriptFromLinks: ").Append(this.RemoveJavaScriptFromLinks).Append("\n");
            sb.Append("  ReplaceBackslashWithYenSign: ").Append(this.ReplaceBackslashWithYenSign).Append("\n");
            sb.Append("  ResolveFontNames: ").Append(this.ResolveFontNames).Append("\n");
            sb.Append("  ResourceFolder: ").Append(this.ResourceFolder).Append("\n");
            sb.Append("  ResourceFolderAlias: ").Append(this.ResourceFolderAlias).Append("\n");
            sb.Append("  ScaleImageToShapeSize: ").Append(this.ScaleImageToShapeSize).Append("\n");
            sb.Append("  TableWidthOutputMode: ").Append(this.TableWidthOutputMode).Append("\n");
            sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
