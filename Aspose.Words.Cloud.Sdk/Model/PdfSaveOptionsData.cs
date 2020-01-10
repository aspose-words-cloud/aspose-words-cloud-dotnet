// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PdfSaveOptionsData.cs">
//   Copyright (c) 2019 Aspose.Words for Cloud
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
  /// container class for pdf save options.
  /// </summary>  
  public class PdfSaveOptionsData : FixedPageSaveOptionsData 
  {                       
        /// <summary>
        /// Gets or sets determines how bookmarks in headers/footers are exported. The default value is Aspose.Words.Saving.HeaderFooterBookmarksExportMode.All.
        /// </summary>
        /// <value>Gets or sets determines how bookmarks in headers/footers are exported. The default value is Aspose.Words.Saving.HeaderFooterBookmarksExportMode.All.</value>
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
            All            
        }

        /// <summary>
        /// Gets or sets determines how bookmarks in headers/footers are exported. The default value is Aspose.Words.Saving.HeaderFooterBookmarksExportMode.All.
        /// </summary>
        public HeaderFooterBookmarksExportModeEnum? HeaderFooterBookmarksExportMode { get; set; }

        /// <summary>
        /// Gets or sets specifies the PDF standards compliance level for output documents.
        /// </summary>  
        public string Compliance { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to convert footnote/endnote references in main text story into active hyperlinks. When clicked the hyperlink will lead to the corresponding footnote/endnote. Default is false.
        /// </summary>  
        public bool? CreateNoteHyperlinks { get; set; }

        /// <summary>
        /// Gets or sets a value determining the way CustomDocumentProperties are exported to PDF file. Default value is None.
        /// </summary>  
        public string CustomPropertiesExport { get; set; }

        /// <summary>
        /// Gets or sets specifies the details for signing the output PDF document.
        /// </summary>  
        public PdfDigitalSignatureDetailsData DigitalSignatureDetails { get; set; }

        /// <summary>
        /// Gets or sets a flag specifying whether the window’s title bar should display the document title taken from the Title entry of the document information dictionary.
        /// </summary>  
        public bool? DisplayDocTitle { get; set; }

        /// <summary>
        /// Gets or sets allows to specify downsample options.
        /// </summary>  
        public DownsampleOptionsData DownsampleOptions { get; set; }

        /// <summary>
        /// Gets or sets controls how fonts are embedded into the resulting PDF documents.
        /// </summary>  
        public bool? EmbedFullFonts { get; set; }

        /// <summary>
        /// Gets or sets specifies the details for encrypting the output PDF document.
        /// </summary>  
        public PdfEncryptionDetailsData EncryptionDetails { get; set; }

        /// <summary>
        /// Gets or sets a flag specifying whether URI should be escaped before writing.             
        /// </summary>  
        public bool? EscapeUri { get; set; }

        /// <summary>
        /// Gets or sets determines whether or not to export document structure.
        /// </summary>  
        public bool? ExportDocumentStructure { get; set; }

        /// <summary>
        /// Gets or sets specifies the font embedding mode.
        /// </summary>  
        public string FontEmbeddingMode { get; set; }

        /// <summary>
        /// Gets or sets specifies how the color space will be selected for the images in PDF document.
        /// </summary>  
        public string ImageColorSpaceExportMode { get; set; }

        /// <summary>
        /// Gets or sets specifies compression type to be used for all images in the document.
        /// </summary>  
        public string ImageCompression { get; set; }

        /// <summary>
        /// Gets or sets determines whether hyperlinks in the output Pdf document are forced to be opened in a new window (or tab) of a browser.
        /// </summary>  
        public bool? OpenHyperlinksInNewWindow { get; set; }

        /// <summary>
        /// Gets or sets allows to specify outline options.
        /// </summary>  
        public OutlineOptionsData OutlineOptions { get; set; }

        /// <summary>
        /// Gets or sets specifies how the PDF document should be displayed when opened in the PDF reader.
        /// </summary>  
        public string PageMode { get; set; }

        /// <summary>
        /// Gets or sets a value determining whether or not to preblend transparent images with black background color.
        /// </summary>  
        public bool? PreblendImages { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to preserve Microsoft Word form fields as form fields in PDF or convert them to text.
        /// </summary>  
        public bool? PreserveFormFields { get; set; }

        /// <summary>
        /// Gets or sets specifies compression type to be used for all textual content in the document.
        /// </summary>  
        public string TextCompression { get; set; }

        /// <summary>
        /// Gets or sets determines whether the document should be saved using a booklet printing layout.
        /// </summary>  
        public bool? UseBookFoldPrintingSettings { get; set; }

        /// <summary>
        /// Gets or sets determines whether or not to substitute TrueType fonts Arial, Times New Roman, Courier New and Symbol with core PDF Type 1 fonts.
        /// </summary>  
        public bool? UseCoreFonts { get; set; }

        /// <summary>
        /// Gets or sets determines what type of zoom should be applied when a document is opened with a PDF viewer.
        /// </summary>  
        public string ZoomBehavior { get; set; }

        /// <summary>
        /// Gets or sets determines zoom factor (in percentages) for a document.
        /// </summary>  
        public int? ZoomFactor { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfSaveOptionsData {\n");
          sb.Append("  Compliance: ").Append(this.Compliance).Append("\n");
          sb.Append("  CreateNoteHyperlinks: ").Append(this.CreateNoteHyperlinks).Append("\n");
          sb.Append("  CustomPropertiesExport: ").Append(this.CustomPropertiesExport).Append("\n");
          sb.Append("  DigitalSignatureDetails: ").Append(this.DigitalSignatureDetails).Append("\n");
          sb.Append("  DisplayDocTitle: ").Append(this.DisplayDocTitle).Append("\n");
          sb.Append("  DownsampleOptions: ").Append(this.DownsampleOptions).Append("\n");
          sb.Append("  EmbedFullFonts: ").Append(this.EmbedFullFonts).Append("\n");
          sb.Append("  EncryptionDetails: ").Append(this.EncryptionDetails).Append("\n");
          sb.Append("  EscapeUri: ").Append(this.EscapeUri).Append("\n");
          sb.Append("  ExportDocumentStructure: ").Append(this.ExportDocumentStructure).Append("\n");
          sb.Append("  FontEmbeddingMode: ").Append(this.FontEmbeddingMode).Append("\n");
          sb.Append("  HeaderFooterBookmarksExportMode: ").Append(this.HeaderFooterBookmarksExportMode).Append("\n");
          sb.Append("  ImageColorSpaceExportMode: ").Append(this.ImageColorSpaceExportMode).Append("\n");
          sb.Append("  ImageCompression: ").Append(this.ImageCompression).Append("\n");
          sb.Append("  OpenHyperlinksInNewWindow: ").Append(this.OpenHyperlinksInNewWindow).Append("\n");
          sb.Append("  OutlineOptions: ").Append(this.OutlineOptions).Append("\n");
          sb.Append("  PageMode: ").Append(this.PageMode).Append("\n");
          sb.Append("  PreblendImages: ").Append(this.PreblendImages).Append("\n");
          sb.Append("  PreserveFormFields: ").Append(this.PreserveFormFields).Append("\n");
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
