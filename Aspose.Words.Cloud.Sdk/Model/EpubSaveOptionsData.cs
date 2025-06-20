// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EpubSaveOptionsData.cs">
//   Copyright (c) 2025 Aspose.Words for Cloud
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
    /// Container class for epub save options.
    /// </summary>
    public class EpubSaveOptionsData : HtmlSaveOptionsData, IModel
    {
        /// <summary>
        /// Gets or sets the maximum level of headings populated to the navigation map when exporting.
        /// </summary>
        public virtual int? NavigationMapLevel { get; set; }

        /// <summary>
        /// Gets the format of save.
        /// </summary>
        public override string SaveFormat { get; } = "epub";


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
            sb.Append("class EpubSaveOptionsData {\n");
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
            sb.Append("  NavigationMapLevel: ").Append(this.NavigationMapLevel).Append("\n");
            sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
