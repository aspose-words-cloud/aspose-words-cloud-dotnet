// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PdfSaveOptionsData.cs">
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
    /// Container class for pdf save options.
    /// </summary>
    public class PdfSaveOptionsData : FixedPageSaveOptionsData
    {
        /// <summary>
        /// Gets or sets the PDF standards compliance level for output documents.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ComplianceEnum
        {
            /// <summary>
            /// Enum value "Pdf17"
            /// </summary>
            Pdf17,

            /// <summary>
            /// Enum value "Pdf20"
            /// </summary>
            Pdf20,

            /// <summary>
            /// Enum value "PdfA1a"
            /// </summary>
            PdfA1a,

            /// <summary>
            /// Enum value "PdfA1b"
            /// </summary>
            PdfA1b,

            /// <summary>
            /// Enum value "PdfA2a"
            /// </summary>
            PdfA2a,

            /// <summary>
            /// Enum value "PdfA2u"
            /// </summary>
            PdfA2u,

            /// <summary>
            /// Enum value "PdfA4"
            /// </summary>
            PdfA4,

            /// <summary>
            /// Enum value "PdfUa1"
            /// </summary>
            PdfUa1,
        }

        /// <summary>
        /// Gets or sets the option that controls the way CustomDocumentProperties are exported to PDF file.
        /// The default value is None.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CustomPropertiesExportEnum
        {
            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,

            /// <summary>
            /// Enum value "Standard"
            /// </summary>
            Standard,

            /// <summary>
            /// Enum value "Metadata"
            /// </summary>
            Metadata,
        }

        /// <summary>
        /// Gets or sets the font embedding mode.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FontEmbeddingModeEnum
        {
            /// <summary>
            /// Enum value "EmbedAll"
            /// </summary>
            EmbedAll,

            /// <summary>
            /// Enum value "EmbedNonstandard"
            /// </summary>
            EmbedNonstandard,

            /// <summary>
            /// Enum value "EmbedNone"
            /// </summary>
            EmbedNone,
        }

        /// <summary>
        /// Gets or sets the option that controls how bookmarks in headers/footers are exported.
        /// The default value is Aspose.Words.Saving.HeaderFooterBookmarksExportMode.All.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HeaderFooterBookmarksExportModeEnum
        {
            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,

            /// <summary>
            /// Enum value "First"
            /// </summary>
            First,

            /// <summary>
            /// Enum value "All"
            /// </summary>
            All,
        }

        /// <summary>
        /// Gets or sets the option that controls how the color space will be selected for the images in PDF document.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ImageColorSpaceExportModeEnum
        {
            /// <summary>
            /// Enum value "Auto"
            /// </summary>
            Auto,

            /// <summary>
            /// Enum value "SimpleCmyk"
            /// </summary>
            SimpleCmyk,
        }

        /// <summary>
        /// Gets or sets the option that controls how the PDF document should be displayed when opened in the PDF reader.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PageModeEnum
        {
            /// <summary>
            /// Enum value "UseNone"
            /// </summary>
            UseNone,

            /// <summary>
            /// Enum value "UseOutlines"
            /// </summary>
            UseOutlines,

            /// <summary>
            /// Enum value "UseThumbs"
            /// </summary>
            UseThumbs,

            /// <summary>
            /// Enum value "FullScreen"
            /// </summary>
            FullScreen,

            /// <summary>
            /// Enum value "UseOC"
            /// </summary>
            UseOC,

            /// <summary>
            /// Enum value "UseAttachments"
            /// </summary>
            UseAttachments,
        }

        /// <summary>
        /// Gets or sets the compression type to be used for all textual content in the document.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextCompressionEnum
        {
            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,

            /// <summary>
            /// Enum value "Flate"
            /// </summary>
            Flate,
        }

        /// <summary>
        /// Gets or sets the option that controls what type of zoom should be applied when a document is opened with a PDF viewer.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ZoomBehaviorEnum
        {
            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,

            /// <summary>
            /// Enum value "ZoomFactor"
            /// </summary>
            ZoomFactor,

            /// <summary>
            /// Enum value "FitPage"
            /// </summary>
            FitPage,

            /// <summary>
            /// Enum value "FitWidth"
            /// </summary>
            FitWidth,

            /// <summary>
            /// Enum value "FitHeight"
            /// </summary>
            FitHeight,

            /// <summary>
            /// Enum value "FitBox"
            /// </summary>
            FitBox,
        }

        /// <summary>
        /// Gets or sets the PDF standards compliance level for output documents.
        /// </summary>
        public virtual ComplianceEnum? Compliance { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to convert footnote/endnote references in main text story into active hyperlinks.
        /// When clicked the hyperlink will lead to the corresponding footnote/endnote.
        /// The default value is false.
        /// </summary>
        public virtual bool? CreateNoteHyperlinks { get; set; }

        /// <summary>
        /// Gets or sets the option that controls the way CustomDocumentProperties are exported to PDF file.
        /// The default value is None.
        /// </summary>
        public virtual CustomPropertiesExportEnum? CustomPropertiesExport { get; set; }

        /// <summary>
        /// Gets or sets the details for signing the output PDF document.
        /// </summary>
        public virtual PdfDigitalSignatureDetailsData DigitalSignatureDetails { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the window’s title bar should display the document title taken from the Title entry of the document information dictionary.
        /// </summary>
        public virtual bool? DisplayDocTitle { get; set; }

        /// <summary>
        /// Gets or sets the downsample options.
        /// </summary>
        public virtual DownsampleOptionsData DownsampleOptions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether fonts are embedded into the resulting PDF documents.
        /// </summary>
        public virtual bool? EmbedFullFonts { get; set; }

        /// <summary>
        /// Gets or sets the details for encrypting the output PDF document.
        /// </summary>
        public virtual PdfEncryptionDetailsData EncryptionDetails { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to export document structure.
        /// </summary>
        public virtual bool? ExportDocumentStructure { get; set; }

        /// <summary>
        /// Gets or sets a value determining whether or not to create a "Span" tag in the document structure to export the text language.
        /// </summary>
        public virtual bool? ExportLanguageToSpanTag { get; set; }

        /// <summary>
        /// Gets or sets the font embedding mode.
        /// </summary>
        public virtual FontEmbeddingModeEnum? FontEmbeddingMode { get; set; }

        /// <summary>
        /// Gets or sets the option that controls how bookmarks in headers/footers are exported.
        /// The default value is Aspose.Words.Saving.HeaderFooterBookmarksExportMode.All.
        /// </summary>
        public virtual HeaderFooterBookmarksExportModeEnum? HeaderFooterBookmarksExportMode { get; set; }

        /// <summary>
        /// Gets or sets the option that controls how the color space will be selected for the images in PDF document.
        /// </summary>
        public virtual ImageColorSpaceExportModeEnum? ImageColorSpaceExportMode { get; set; }

        /// <summary>
        /// Gets or sets the compression type to be used for all images in the document.
        /// </summary>
        public virtual string ImageCompression { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether image interpolation shall be performed by a conforming reader. When false is specified, the flag is not written to the output document and the default behavior of reader is used instead.
        /// </summary>
        public virtual bool? InterpolateImages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether hyperlinks in the output Pdf document are forced to be opened in a new window (or tab) of a browser.
        /// </summary>
        public virtual bool? OpenHyperlinksInNewWindow { get; set; }

        /// <summary>
        /// Gets or sets the outline options.
        /// </summary>
        public virtual OutlineOptionsData OutlineOptions { get; set; }

        /// <summary>
        /// Gets or sets the option that controls how the PDF document should be displayed when opened in the PDF reader.
        /// </summary>
        public virtual PageModeEnum? PageMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to preblend transparent images with black background color.
        /// </summary>
        public virtual bool? PreblendImages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to preserve Microsoft Word form fields as form fields in PDF or convert them to text.
        /// </summary>
        public virtual bool? PreserveFormFields { get; set; }

        /// <summary>
        /// Gets the format of save.
        /// </summary>
        public override string SaveFormat { get; } = "pdf";

        /// <summary>
        /// Gets or sets the compression type to be used for all textual content in the document.
        /// </summary>
        public virtual TextCompressionEnum? TextCompression { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the document should be saved using a booklet printing layout.
        /// </summary>
        public virtual bool? UseBookFoldPrintingSettings { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to substitute TrueType fonts Arial, Times New Roman, Courier New and Symbol with core PDF Type 1 fonts.
        /// </summary>
        public virtual bool? UseCoreFonts { get; set; }

        /// <summary>
        /// Gets or sets the option that controls what type of zoom should be applied when a document is opened with a PDF viewer.
        /// </summary>
        public virtual ZoomBehaviorEnum? ZoomBehavior { get; set; }

        /// <summary>
        /// Gets or sets the zoom factor (in percentages) for a document.
        /// </summary>
        public virtual int? ZoomFactor { get; set; }


        /// <summary>
        /// Collect all files content properties.
        /// </summary>
        /// <returns>The http request instance.</returns>
        public override void CollectFileReferences(List<FileReference> resultFileReferences)
        {
            base.CollectFileReferences(resultFileReferences);
            if (this.DigitalSignatureDetails != null)
            {
                this.DigitalSignatureDetails.CollectFileReferences(resultFileReferences);
            }


            if (this.DownsampleOptions != null)
            {
                this.DownsampleOptions.CollectFileReferences(resultFileReferences);
            }


            if (this.EncryptionDetails != null)
            {
                this.EncryptionDetails.CollectFileReferences(resultFileReferences);
            }









            if (this.OutlineOptions != null)
            {
                this.OutlineOptions.CollectFileReferences(resultFileReferences);
            }










        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PdfSaveOptionsData {\n");
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
            sb.Append("  ColorMode: ").Append(this.ColorMode).Append("\n");
            sb.Append("  JpegQuality: ").Append(this.JpegQuality).Append("\n");
            sb.Append("  MetafileRenderingOptions: ").Append(this.MetafileRenderingOptions).Append("\n");
            sb.Append("  NumeralFormat: ").Append(this.NumeralFormat).Append("\n");
            sb.Append("  OptimizeOutput: ").Append(this.OptimizeOutput).Append("\n");
            sb.Append("  PageCount: ").Append(this.PageCount).Append("\n");
            sb.Append("  PageIndex: ").Append(this.PageIndex).Append("\n");
            sb.Append("  Compliance: ").Append(this.Compliance).Append("\n");
            sb.Append("  CreateNoteHyperlinks: ").Append(this.CreateNoteHyperlinks).Append("\n");
            sb.Append("  CustomPropertiesExport: ").Append(this.CustomPropertiesExport).Append("\n");
            sb.Append("  DigitalSignatureDetails: ").Append(this.DigitalSignatureDetails).Append("\n");
            sb.Append("  DisplayDocTitle: ").Append(this.DisplayDocTitle).Append("\n");
            sb.Append("  DownsampleOptions: ").Append(this.DownsampleOptions).Append("\n");
            sb.Append("  EmbedFullFonts: ").Append(this.EmbedFullFonts).Append("\n");
            sb.Append("  EncryptionDetails: ").Append(this.EncryptionDetails).Append("\n");
            sb.Append("  ExportDocumentStructure: ").Append(this.ExportDocumentStructure).Append("\n");
            sb.Append("  ExportLanguageToSpanTag: ").Append(this.ExportLanguageToSpanTag).Append("\n");
            sb.Append("  FontEmbeddingMode: ").Append(this.FontEmbeddingMode).Append("\n");
            sb.Append("  HeaderFooterBookmarksExportMode: ").Append(this.HeaderFooterBookmarksExportMode).Append("\n");
            sb.Append("  ImageColorSpaceExportMode: ").Append(this.ImageColorSpaceExportMode).Append("\n");
            sb.Append("  ImageCompression: ").Append(this.ImageCompression).Append("\n");
            sb.Append("  InterpolateImages: ").Append(this.InterpolateImages).Append("\n");
            sb.Append("  OpenHyperlinksInNewWindow: ").Append(this.OpenHyperlinksInNewWindow).Append("\n");
            sb.Append("  OutlineOptions: ").Append(this.OutlineOptions).Append("\n");
            sb.Append("  PageMode: ").Append(this.PageMode).Append("\n");
            sb.Append("  PreblendImages: ").Append(this.PreblendImages).Append("\n");
            sb.Append("  PreserveFormFields: ").Append(this.PreserveFormFields).Append("\n");
            sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
            sb.Append("  TextCompression: ").Append(this.TextCompression).Append("\n");
            sb.Append("  UseBookFoldPrintingSettings: ").Append(this.UseBookFoldPrintingSettings).Append("\n");
            sb.Append("  UseCoreFonts: ").Append(this.UseCoreFonts).Append("\n");
            sb.Append("  ZoomBehavior: ").Append(this.ZoomBehavior).Append("\n");
            sb.Append("  ZoomFactor: ").Append(this.ZoomFactor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
