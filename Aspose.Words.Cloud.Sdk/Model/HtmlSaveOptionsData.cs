// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="HtmlSaveOptionsData.cs">
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
  /// container class for html save options
  /// </summary>  
  public class HtmlSaveOptionsData : SaveOptionsData 
  {                       
        /// <summary>
        /// Specifies version of HTML standard that should be used when saving the document to HTML or MHTML.   Default value is Aspose.Words.Saving.HtmlVersion.Xhtml.
        /// </summary>
        /// <value>Specifies version of HTML standard that should be used when saving the document to HTML or MHTML.   Default value is Aspose.Words.Saving.HtmlVersion.Xhtml.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HtmlVersionEnum
        { 
            /// <summary>
            /// Enum Xhtml for "Xhtml"
            /// </summary>            
            Xhtml,
            
            /// <summary>
            /// Enum Html5 for "Html5"
            /// </summary>            
            Html5            
        }

        /// <summary>
        /// Controls how OfficeMath objects are exported to HTML, MHTML or EPUB.  Default value is HtmlOfficeMathOutputMode.Image.
        /// </summary>
        /// <value>Controls how OfficeMath objects are exported to HTML, MHTML or EPUB.  Default value is HtmlOfficeMathOutputMode.Image.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OfficeMathOutputModeEnum
        { 
            /// <summary>
            /// Enum Image for "Image"
            /// </summary>            
            Image,
            
            /// <summary>
            /// Enum MathML for "MathML"
            /// </summary>            
            MathML,
            
            /// <summary>
            /// Enum Text for "Text"
            /// </summary>            
            Text            
        }

        /// <summary>
        /// Specifies version of HTML standard that should be used when saving the document to HTML or MHTML.   Default value is Aspose.Words.Saving.HtmlVersion.Xhtml.
        /// </summary>
        public HtmlVersionEnum? HtmlVersion { get; set; }

        /// <summary>
        /// Controls how OfficeMath objects are exported to HTML, MHTML or EPUB.  Default value is HtmlOfficeMathOutputMode.Image.
        /// </summary>
        public OfficeMathOutputModeEnum? OfficeMathOutputMode { get; set; }

        /// <summary>
        /// Specifies whether or not use pretty formats output
        /// </summary>  
        public bool? PrettyFormat { get; set; }

        /// <summary>
        /// Specifies whether negative left and right indents of paragraphs are allowed (not normalized)
        /// </summary>  
        public bool? AllowNegativeIndent { get; set; }

        /// <summary>
        /// Specifies the name of the CSS file written when the document is exported to HTML
        /// </summary>  
        public string CssStyleSheetFileName { get; set; }

        /// <summary>
        /// Specifies how CSS styles are exported
        /// </summary>  
        public string CssStyleSheetType { get; set; }

        /// <summary>
        /// Specifies how the document should be split when saving
        /// </summary>  
        public string DocumentSplitCriteria { get; set; }

        /// <summary>
        /// Specifies the maximum level of headings at which to split the document
        /// </summary>  
        public int? DocumentSplitHeadingLevel { get; set; }

        /// <summary>
        /// Specifies the encoding to use when exporting
        /// </summary>  
        public string Encoding { get; set; }

        /// <summary>
        /// Specifies whether to export built-in and custom document properties
        /// </summary>  
        public bool? ExportDocumentProperties { get; set; }

        /// <summary>
        /// Specifies whether fonts resources should be embedded to HTML in Base64 encoding.  Default is false.
        /// </summary>  
        public bool? ExportFontsAsBase64 { get; set; }

        /// <summary>
        /// Specifies whether font resources should be exported
        /// </summary>  
        public bool? ExportFontResources { get; set; }

        /// <summary>
        /// Specifies how headers and footers are output
        /// </summary>  
        public string ExportHeadersFootersMode { get; set; }

        /// <summary>
        /// Specifies whether images are saved in Base64 format
        /// </summary>  
        public bool? ExportImagesAsBase64 { get; set; }

        /// <summary>
        /// Specifies whether language information is exported
        /// </summary>  
        public bool? ExportLanguageInformation { get; set; }

        /// <summary>
        /// Controls how list labels are output
        /// </summary>  
        public string ExportListLabels { get; set; }

        /// <summary>
        /// Specifies whether to convert metafiles into raster images when exporting
        /// </summary>  
        public bool? ExportMetafileAsRaster { get; set; }

        /// <summary>
        /// Specifies whether original URL should be used as the URL of the linked images. Default value is false.
        /// </summary>  
        public bool? ExportOriginalUrlForLinkedImages { get; set; }

        /// <summary>
        /// Specifies whether page margins is exported to HTML, MHTML or EPUB. Default is false.
        /// </summary>  
        public bool? ExportPageMargins { get; set; }

        /// <summary>
        /// Specifies whether page setup is exported
        /// </summary>  
        public bool? ExportPageSetup { get; set; }

        /// <summary>
        /// Specifies whether font sizes should be output in relative units when saving
        /// </summary>  
        public bool? ExportRelativeFontSize { get; set; }

        /// <summary>
        /// Specifies whether to write the roundtrip information when saving to HTML Default value is true.
        /// </summary>  
        public bool? ExportRoundtripInformation { get; set; }

        /// <summary>
        /// Controls how textboxes represented by Aspose.Words.Drawing.Shape are saved to HTML, MHTML or EPUB. Default value is false.    When set to true, exports textboxes as inline \"svg\" elements. When false, exports as \"image\" elements.
        /// </summary>  
        public bool? ExportTextBoxAsSvg { get; set; }

        /// <summary>
        /// Controls how text input form fields are saved
        /// </summary>  
        public bool? ExportTextInputFormFieldAsText { get; set; }

        /// <summary>
        /// Specifies whether to write page numbers to table of contents when saving
        /// </summary>  
        public bool? ExportTocPageNumbers { get; set; }

        /// <summary>
        /// Specifies whether to write the DOCTYPE declaration when saving
        /// </summary>  
        public bool? ExportXhtmlTransitional { get; set; }

        /// <summary>
        /// Specifies the physical folder where fonts are saved when exporting a document
        /// </summary>  
        public string FontsFolder { get; set; }

        /// <summary>
        /// Specifies the name of the folder used to construct font URIs
        /// </summary>  
        public string FontsFolderAlias { get; set; }

        /// <summary>
        /// Controls which font resources need subsetting when saving
        /// </summary>  
        public int? FontResourcesSubsettingSizeThreshold { get; set; }

        /// <summary>
        /// Specifies the physical folder where images are saved when exporting a document
        /// </summary>  
        public string ImagesFolder { get; set; }

        /// <summary>
        /// Specifies the name of the folder used to construct image URIs
        /// </summary>  
        public string ImagesFolderAlias { get; set; }

        /// <summary>
        /// Specifies the output resolution for images when exporting
        /// </summary>  
        public int? ImageResolution { get; set; }

        /// <summary>
        /// Specifies a physical folder where all resources like images, fonts, and external CSS are saved when a document is exported to HTML. Default is an empty string.
        /// </summary>  
        public string ResourceFolder { get; set; }

        /// <summary>
        /// Specifies the name of the folder used to construct URIs of all resources written into an HTML document.  Default is an empty string.
        /// </summary>  
        public string ResourceFolderAlias { get; set; }

        /// <summary>
        /// Specifies whether images are scaled by Aspose.Words to the bounding shape size when exporting
        /// </summary>  
        public bool? ScaleImageToShapeSize { get; set; }

        /// <summary>
        /// Controls how table, row and cell widths are exported
        /// </summary>  
        public string TableWidthOutputMode { get; set; }

        /// <summary>
        /// Controls how drop-down form fields are saved to HTML. Default value is false.
        /// </summary>  
        public bool? ExportDropDownFormFieldAsText { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class HtmlSaveOptionsData {\n");
          sb.Append("  PrettyFormat: ").Append(this.PrettyFormat).Append("\n");
          sb.Append("  AllowNegativeIndent: ").Append(this.AllowNegativeIndent).Append("\n");
          sb.Append("  CssStyleSheetFileName: ").Append(this.CssStyleSheetFileName).Append("\n");
          sb.Append("  CssStyleSheetType: ").Append(this.CssStyleSheetType).Append("\n");
          sb.Append("  DocumentSplitCriteria: ").Append(this.DocumentSplitCriteria).Append("\n");
          sb.Append("  DocumentSplitHeadingLevel: ").Append(this.DocumentSplitHeadingLevel).Append("\n");
          sb.Append("  Encoding: ").Append(this.Encoding).Append("\n");
          sb.Append("  ExportDocumentProperties: ").Append(this.ExportDocumentProperties).Append("\n");
          sb.Append("  ExportFontsAsBase64: ").Append(this.ExportFontsAsBase64).Append("\n");
          sb.Append("  ExportFontResources: ").Append(this.ExportFontResources).Append("\n");
          sb.Append("  ExportHeadersFootersMode: ").Append(this.ExportHeadersFootersMode).Append("\n");
          sb.Append("  ExportImagesAsBase64: ").Append(this.ExportImagesAsBase64).Append("\n");
          sb.Append("  ExportLanguageInformation: ").Append(this.ExportLanguageInformation).Append("\n");
          sb.Append("  ExportListLabels: ").Append(this.ExportListLabels).Append("\n");
          sb.Append("  ExportMetafileAsRaster: ").Append(this.ExportMetafileAsRaster).Append("\n");
          sb.Append("  ExportOriginalUrlForLinkedImages: ").Append(this.ExportOriginalUrlForLinkedImages).Append("\n");
          sb.Append("  ExportPageMargins: ").Append(this.ExportPageMargins).Append("\n");
          sb.Append("  ExportPageSetup: ").Append(this.ExportPageSetup).Append("\n");
          sb.Append("  ExportRelativeFontSize: ").Append(this.ExportRelativeFontSize).Append("\n");
          sb.Append("  ExportRoundtripInformation: ").Append(this.ExportRoundtripInformation).Append("\n");
          sb.Append("  ExportTextBoxAsSvg: ").Append(this.ExportTextBoxAsSvg).Append("\n");
          sb.Append("  ExportTextInputFormFieldAsText: ").Append(this.ExportTextInputFormFieldAsText).Append("\n");
          sb.Append("  ExportTocPageNumbers: ").Append(this.ExportTocPageNumbers).Append("\n");
          sb.Append("  ExportXhtmlTransitional: ").Append(this.ExportXhtmlTransitional).Append("\n");
          sb.Append("  FontsFolder: ").Append(this.FontsFolder).Append("\n");
          sb.Append("  FontsFolderAlias: ").Append(this.FontsFolderAlias).Append("\n");
          sb.Append("  FontResourcesSubsettingSizeThreshold: ").Append(this.FontResourcesSubsettingSizeThreshold).Append("\n");
          sb.Append("  HtmlVersion: ").Append(this.HtmlVersion).Append("\n");
          sb.Append("  ImagesFolder: ").Append(this.ImagesFolder).Append("\n");
          sb.Append("  ImagesFolderAlias: ").Append(this.ImagesFolderAlias).Append("\n");
          sb.Append("  ImageResolution: ").Append(this.ImageResolution).Append("\n");
          sb.Append("  OfficeMathOutputMode: ").Append(this.OfficeMathOutputMode).Append("\n");
          sb.Append("  ResourceFolder: ").Append(this.ResourceFolder).Append("\n");
          sb.Append("  ResourceFolderAlias: ").Append(this.ResourceFolderAlias).Append("\n");
          sb.Append("  ScaleImageToShapeSize: ").Append(this.ScaleImageToShapeSize).Append("\n");
          sb.Append("  TableWidthOutputMode: ").Append(this.TableWidthOutputMode).Append("\n");
          sb.Append("  ExportDropDownFormFieldAsText: ").Append(this.ExportDropDownFormFieldAsText).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
