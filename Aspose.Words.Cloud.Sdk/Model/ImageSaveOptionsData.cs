// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImageSaveOptionsData.cs">
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
    /// Container abstract class for image save options.
    /// </summary>
    public abstract class ImageSaveOptionsData : FixedPageSaveOptionsData
    {
        /// <summary>
        /// Gets or sets the color mode of the image.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ImageColorModeEnum
        {
            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,

            /// <summary>
            /// Enum value "Grayscale"
            /// </summary>
            Grayscale,

            /// <summary>
            /// Enum value "BlackAndWhite"
            /// </summary>
            BlackAndWhite,
        }

        /// <summary>
        /// Gets or sets the pixel format of the image.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PixelFormatEnum
        {
            /// <summary>
            /// Enum value "Format16BppRgb555"
            /// </summary>
            Format16BppRgb555,

            /// <summary>
            /// Enum value "Format16BppRgb565"
            /// </summary>
            Format16BppRgb565,

            /// <summary>
            /// Enum value "Format16BppArgb1555"
            /// </summary>
            Format16BppArgb1555,

            /// <summary>
            /// Enum value "Format24BppRgb"
            /// </summary>
            Format24BppRgb,

            /// <summary>
            /// Enum value "Format32BppRgb"
            /// </summary>
            Format32BppRgb,

            /// <summary>
            /// Enum value "Format32BppArgb"
            /// </summary>
            Format32BppArgb,

            /// <summary>
            /// Enum value "Format32BppPArgb"
            /// </summary>
            Format32BppPArgb,

            /// <summary>
            /// Enum value "Format48BppRgb"
            /// </summary>
            Format48BppRgb,

            /// <summary>
            /// Enum value "Format64BppArgb"
            /// </summary>
            Format64BppArgb,

            /// <summary>
            /// Enum value "Format64BppPArgb"
            /// </summary>
            Format64BppPArgb,

            /// <summary>
            /// Enum value "Format1bppIndexed"
            /// </summary>
            Format1bppIndexed,
        }

        /// <summary>
        /// Gets or sets the horizontal resolution in dots per inch for the generated images.
        /// This property has effect only when saving to raster image formats.
        /// The default value is 96.
        /// </summary>
        public virtual double? HorizontalResolution { get; set; }

        /// <summary>
        /// Gets or sets the brightness level of the image.
        /// </summary>
        public virtual double? ImageBrightness { get; set; }

        /// <summary>
        /// Gets or sets the color mode of the image.
        /// </summary>
        public virtual ImageColorModeEnum? ImageColorMode { get; set; }

        /// <summary>
        /// Gets or sets the contrast level of the image.
        /// </summary>
        public virtual double? ImageContrast { get; set; }

        /// <summary>
        /// Gets or sets the background (paper) color of the image.
        /// </summary>
        public virtual string PaperColor { get; set; }

        /// <summary>
        /// Gets or sets the pixel format of the image.
        /// </summary>
        public virtual PixelFormatEnum? PixelFormat { get; set; }

        /// <summary>
        /// Gets or sets both horizontal and vertical resolution in dots per inch for the generated images.
        /// This property has effect only when saving to raster image formats.
        /// The default value is 96.
        /// </summary>
        public virtual double? Resolution { get; set; }

        /// <summary>
        /// Gets or sets the zoom factor of the image.
        /// </summary>
        public virtual double? Scale { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use anti-aliasing for rendering.
        /// </summary>
        public virtual bool? UseAntiAliasing { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use GDI+ or Aspose.Words metafile renderer when saving to EMF.
        /// </summary>
        public virtual bool? UseGdiEmfRenderer { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use high quality (i.e. slow) rendering algorithms.
        /// </summary>
        public virtual bool? UseHighQualityRendering { get; set; }

        /// <summary>
        /// Gets or sets the vertical resolution in dots per inch for the generated images.
        /// This property has effect only when saving to raster image formats.
        /// The default value is 96.
        /// </summary>
        public virtual double? VerticalResolution { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageSaveOptionsData {\n");
            sb.Append("  AllowEmbeddingPostScriptFonts: ").Append(this.AllowEmbeddingPostScriptFonts).Append("\n");
            sb.Append("  CustomTimeZoneInfoData: ").Append(this.CustomTimeZoneInfoData).Append("\n");
            sb.Append("  Dml3DEffectsRenderingMode: ").Append(this.Dml3DEffectsRenderingMode).Append("\n");
            sb.Append("  DmlEffectsRenderingMode: ").Append(this.DmlEffectsRenderingMode).Append("\n");
            sb.Append("  DmlRenderingMode: ").Append(this.DmlRenderingMode).Append("\n");
            sb.Append("  FileName: ").Append(this.FileName).Append("\n");
            sb.Append("  FlatOpcXmlMappingOnly: ").Append(this.FlatOpcXmlMappingOnly).Append("\n");
            sb.Append("  ImlRenderingMode: ").Append(this.ImlRenderingMode).Append("\n");
            sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
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
            sb.Append("  HorizontalResolution: ").Append(this.HorizontalResolution).Append("\n");
            sb.Append("  ImageBrightness: ").Append(this.ImageBrightness).Append("\n");
            sb.Append("  ImageColorMode: ").Append(this.ImageColorMode).Append("\n");
            sb.Append("  ImageContrast: ").Append(this.ImageContrast).Append("\n");
            sb.Append("  PaperColor: ").Append(this.PaperColor).Append("\n");
            sb.Append("  PixelFormat: ").Append(this.PixelFormat).Append("\n");
            sb.Append("  Resolution: ").Append(this.Resolution).Append("\n");
            sb.Append("  Scale: ").Append(this.Scale).Append("\n");
            sb.Append("  UseAntiAliasing: ").Append(this.UseAntiAliasing).Append("\n");
            sb.Append("  UseGdiEmfRenderer: ").Append(this.UseGdiEmfRenderer).Append("\n");
            sb.Append("  UseHighQualityRendering: ").Append(this.UseHighQualityRendering).Append("\n");
            sb.Append("  VerticalResolution: ").Append(this.VerticalResolution).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
