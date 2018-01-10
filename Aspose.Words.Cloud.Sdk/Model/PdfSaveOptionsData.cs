// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PdfSaveOptionsData.cs">
//   Copyright (c) 2016 Aspose.Words for Cloud
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
  /// container class for pdf save options
  /// </summary>  
  public class PdfSaveOptionsData : FixedPageSaveOptionsData 
  {                       
        /// <summary>
        /// Specifies the level in the PDF document outline at which to display Word bookmarks
        /// </summary>  
        public int? BookmarksOutlineLevel { get; set; }

        /// <summary>
        /// Specifies whether to convert footnote/endnote references in main text story into active hyperlinks. When clicked the hyperlink will lead to the corresponding footnote/endnote. Default is false.
        /// </summary>  
        public bool? CreateNoteHyperlinks { get; set; }

        /// <summary>
        /// Specifies the PDF standards compliance level for output documents
        /// </summary>  
        public string Compliance { get; set; }

        /// <summary>
        /// Specifies the details for signing the output PDF document
        /// </summary>  
        public PdfDigitalSignatureDetailsData DigitalSignatureDetails { get; set; }

        /// <summary>
        /// A flag specifying whether the window’s title bar should display the document title taken from the Title entry of the document information dictionary.
        /// </summary>  
        public bool? DisplayDocTitle { get; set; }

        /// <summary>
        /// Specifies whether or not the images should be downsampled
        /// </summary>  
        public bool? DownsampleImages { get; set; }

        /// <summary>
        /// Specifies the resolution in pixels per inch to which the images should be downsampled
        /// </summary>  
        public int? DownsampleResolution { get; set; }

        /// <summary>
        /// Allows to specify downsample options.
        /// </summary>  
        public DownsampleOptionsData DownsampleOptions { get; set; }

        /// <summary>
        /// Controls how fonts are embedded into the resulting PDF documents
        /// </summary>  
        public bool? EmbedFullFonts { get; set; }

        /// <summary>
        /// Determines whether or not to embed standard windows fonts Arial and Times New Roman
        /// </summary>  
        public bool? EmbedStandardWindowsFonts { get; set; }

        /// <summary>
        /// Specifies the details for encrypting the output PDF document
        /// </summary>  
        public PdfEncryptionDetailsData EncryptionDetails { get; set; }

        /// <summary>
        /// Specifies how many levels in the PDF document outline to show expanded when the PDF file is viewed
        /// </summary>  
        public int? ExpandedOutlineLevels { get; set; }

        /// <summary>
        /// Determines whether or not to export custom properties of document as Metadata
        /// </summary>  
        public bool? ExportCustomPropertiesAsMetadata { get; set; }

        /// <summary>
        /// Determines whether or not to export document structure
        /// </summary>  
        public bool? ExportDocumentStructure { get; set; }

        /// <summary>
        /// Specifies the font embedding mode
        /// </summary>  
        public string FontEmbeddingMode { get; set; }

        /// <summary>
        /// Specifies how many levels of headings (paragraphs formatted with the Heading styles) to include in the PDF document outline
        /// </summary>  
        public int? HeadingsOutlineLevels { get; set; }

        /// <summary>
        /// Specifies compression type to be used for all images in the document
        /// </summary>  
        public string ImageCompression { get; set; }

        /// <summary>
        /// Determines whether hyperlinks in the output Pdf document are forced to be opened in a new window (or tab) of a browser
        /// </summary>  
        public bool? OpenHyperlinksInNewWindow { get; set; }

        /// <summary>
        /// Allows to specify outline options
        /// </summary>  
        public OutlineOptionsData OutlineOptions { get; set; }

        /// <summary>
        /// Specifies how the PDF document should be displayed when opened in the PDF reader
        /// </summary>  
        public string PageMode { get; set; }

        /// <summary>
        /// Specifies how the color space will be selected for the images in PDF document.
        /// </summary>  
        public string ImageColorSpaceExportMode { get; set; }

        /// <summary>
        /// Specifies whether to preserve Microsoft Word form fields as form fields in PDF or convert them to text
        /// </summary>  
        public bool? PreserveFormFields { get; set; }

        /// <summary>
        /// Specifies compression type to be used for all textual content in the document
        /// </summary>  
        public string TextCompression { get; set; }

        /// <summary>
        /// Determines whether or not to substitute TrueType fonts Arial, Times New Roman, Courier New and Symbol with core PDF Type 1 fonts
        /// </summary>  
        public bool? UseCoreFonts { get; set; }

        /// <summary>
        /// Determines whether the document should be saved using a booklet printing layout
        /// </summary>  
        public bool? UseBookFoldPrintingSettings { get; set; }

        /// <summary>
        /// Determines what type of zoom should be applied when a document is opened with a PDF viewer
        /// </summary>  
        public string ZoomBehavior { get; set; }

        /// <summary>
        /// Determines zoom factor (in percentages) for a document
        /// </summary>  
        public int? ZoomFactor { get; set; }

        /// <summary>
        /// Gets or sets a value determining the way  are exported to PDF file. Default value is .
        /// </summary>  
        public string CustomPropertiesExport { get; set; }

        /// <summary>
        /// Gets or sets a value determining whether or not to preblend transparent images with black background color.
        /// </summary>  
        public bool? PreblendImages { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfSaveOptionsData {\n");
          sb.Append("  BookmarksOutlineLevel: ").Append(this.BookmarksOutlineLevel).Append("\n");
          sb.Append("  CreateNoteHyperlinks: ").Append(this.CreateNoteHyperlinks).Append("\n");
          sb.Append("  Compliance: ").Append(this.Compliance).Append("\n");
          sb.Append("  DigitalSignatureDetails: ").Append(this.DigitalSignatureDetails).Append("\n");
          sb.Append("  DisplayDocTitle: ").Append(this.DisplayDocTitle).Append("\n");
          sb.Append("  DownsampleImages: ").Append(this.DownsampleImages).Append("\n");
          sb.Append("  DownsampleResolution: ").Append(this.DownsampleResolution).Append("\n");
          sb.Append("  DownsampleOptions: ").Append(this.DownsampleOptions).Append("\n");
          sb.Append("  EmbedFullFonts: ").Append(this.EmbedFullFonts).Append("\n");
          sb.Append("  EmbedStandardWindowsFonts: ").Append(this.EmbedStandardWindowsFonts).Append("\n");
          sb.Append("  EncryptionDetails: ").Append(this.EncryptionDetails).Append("\n");
          sb.Append("  ExpandedOutlineLevels: ").Append(this.ExpandedOutlineLevels).Append("\n");
          sb.Append("  ExportCustomPropertiesAsMetadata: ").Append(this.ExportCustomPropertiesAsMetadata).Append("\n");
          sb.Append("  ExportDocumentStructure: ").Append(this.ExportDocumentStructure).Append("\n");
          sb.Append("  FontEmbeddingMode: ").Append(this.FontEmbeddingMode).Append("\n");
          sb.Append("  HeadingsOutlineLevels: ").Append(this.HeadingsOutlineLevels).Append("\n");
          sb.Append("  ImageCompression: ").Append(this.ImageCompression).Append("\n");
          sb.Append("  OpenHyperlinksInNewWindow: ").Append(this.OpenHyperlinksInNewWindow).Append("\n");
          sb.Append("  OutlineOptions: ").Append(this.OutlineOptions).Append("\n");
          sb.Append("  PageMode: ").Append(this.PageMode).Append("\n");
          sb.Append("  ImageColorSpaceExportMode: ").Append(this.ImageColorSpaceExportMode).Append("\n");
          sb.Append("  PreserveFormFields: ").Append(this.PreserveFormFields).Append("\n");
          sb.Append("  TextCompression: ").Append(this.TextCompression).Append("\n");
          sb.Append("  UseCoreFonts: ").Append(this.UseCoreFonts).Append("\n");
          sb.Append("  UseBookFoldPrintingSettings: ").Append(this.UseBookFoldPrintingSettings).Append("\n");
          sb.Append("  ZoomBehavior: ").Append(this.ZoomBehavior).Append("\n");
          sb.Append("  ZoomFactor: ").Append(this.ZoomFactor).Append("\n");
          sb.Append("  CustomPropertiesExport: ").Append(this.CustomPropertiesExport).Append("\n");
          sb.Append("  PreblendImages: ").Append(this.PreblendImages).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
