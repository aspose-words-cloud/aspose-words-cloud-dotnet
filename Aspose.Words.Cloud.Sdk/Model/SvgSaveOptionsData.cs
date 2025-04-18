// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SvgSaveOptionsData.cs">
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
    /// Container class for svg save options.
    /// </summary>
    public class SvgSaveOptionsData : FixedPageSaveOptionsData, IModel
    {
        /// <summary>
        /// Gets or sets the option that controls how text should be rendered.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextOutputModeEnum
        {
            /// <summary>
            /// Enum value "UseSvgFonts"
            /// </summary>
            UseSvgFonts,

            /// <summary>
            /// Enum value "UseTargetMachineFonts"
            /// </summary>
            UseTargetMachineFonts,

            /// <summary>
            /// Enum value "UsePlacedGlyphs"
            /// </summary>
            UsePlacedGlyphs,
        }

        /// <summary>
        /// Gets or sets a value indicating whether images should be embedded into SVG document as base64.
        /// </summary>
        public virtual bool? ExportEmbeddedImages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the output SVG should fill the available viewport area (browser window or container). When set to true width and height of output SVG are set to 100%.
        /// </summary>
        public virtual bool? FitToViewPort { get; set; }

        /// <summary>
        /// Gets or sets specifies a prefix that is prepended to all generated element IDs in the output document.
        /// Default value is null and no prefix is prepended.
        /// If the prefix is specified, it can contain only letters, digits, underscores, and hyphens,
        /// and must start with a letter.
        /// </summary>
        public virtual string IdPrefix { get; set; }

        /// <summary>
        /// Gets or sets a value in pixels per inch that limits resolution of exported raster images.
        /// If the value of this property is non-zero, it limits resolution of exported raster images.
        /// That is, higher-resolution images are resampled down to the limit and lower-resolution images are exported as is.
        /// </summary>
        public virtual int? MaxImageResolution { get; set; }

        /// <summary>
        /// Gets or sets the physical folder where resources (images) are saved when exporting.
        /// </summary>
        public virtual string ResourcesFolder { get; set; }

        /// <summary>
        /// Gets or sets the name of the folder used to construct image URIs.
        /// </summary>
        public virtual string ResourcesFolderAlias { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show or hide page stepper.
        /// </summary>
        public virtual bool? ShowPageBorder { get; set; }

        /// <summary>
        /// Gets or sets the option that controls how text should be rendered.
        /// </summary>
        public virtual TextOutputModeEnum? TextOutputMode { get; set; }

        /// <summary>
        /// Gets the format of save.
        /// </summary>
        public override string SaveFormat { get; } = "svg";


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
            sb.Append("class SvgSaveOptionsData {\n");
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
            sb.Append("  ColorMode: ").Append(this.ColorMode).Append("\n");
            sb.Append("  JpegQuality: ").Append(this.JpegQuality).Append("\n");
            sb.Append("  MetafileRenderingOptions: ").Append(this.MetafileRenderingOptions).Append("\n");
            sb.Append("  NumeralFormat: ").Append(this.NumeralFormat).Append("\n");
            sb.Append("  OptimizeOutput: ").Append(this.OptimizeOutput).Append("\n");
            sb.Append("  PageCount: ").Append(this.PageCount).Append("\n");
            sb.Append("  PageIndex: ").Append(this.PageIndex).Append("\n");
            sb.Append("  ExportEmbeddedImages: ").Append(this.ExportEmbeddedImages).Append("\n");
            sb.Append("  FitToViewPort: ").Append(this.FitToViewPort).Append("\n");
            sb.Append("  IdPrefix: ").Append(this.IdPrefix).Append("\n");
            sb.Append("  MaxImageResolution: ").Append(this.MaxImageResolution).Append("\n");
            sb.Append("  ResourcesFolder: ").Append(this.ResourcesFolder).Append("\n");
            sb.Append("  ResourcesFolderAlias: ").Append(this.ResourcesFolderAlias).Append("\n");
            sb.Append("  ShowPageBorder: ").Append(this.ShowPageBorder).Append("\n");
            sb.Append("  TextOutputMode: ").Append(this.TextOutputMode).Append("\n");
            sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
