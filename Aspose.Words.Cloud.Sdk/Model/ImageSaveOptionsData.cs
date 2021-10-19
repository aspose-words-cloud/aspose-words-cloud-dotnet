// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImageSaveOptionsData.cs">
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
    /// Container abstract class for image save options.
    /// </summary>
    public class ImageSaveOptionsData : FixedPageSaveOptionsData
    {
        /// <summary>
        /// Gets or sets the horizontal resolution in dots per inch for the generated images.
        /// This property has effect only when saving to raster image formats.
        /// The default value is 96.
        /// </summary>  
        public double? HorizontalResolution { get; set; }

        /// <summary>
        /// Gets or sets the brightness level of the image.
        /// </summary>  
        public double? ImageBrightness { get; set; }

        /// <summary>
        /// Gets or sets the color mode of the image.
        /// </summary>  
        public string ImageColorMode { get; set; }

        /// <summary>
        /// Gets or sets the contrast level of the image.
        /// </summary>  
        public double? ImageContrast { get; set; }

        /// <summary>
        /// Gets or sets the background (paper) color of the image.
        /// </summary>  
        public string PaperColor { get; set; }

        /// <summary>
        /// Gets or sets the pixel format of the image.
        /// </summary>  
        public string PixelFormat { get; set; }

        /// <summary>
        /// Gets or sets both horizontal and vertical resolution in dots per inch for the generated images.
        /// This property has effect only when saving to raster image formats.
        /// The default value is 96.
        /// </summary>  
        public double? Resolution { get; set; }

        /// <summary>
        /// Gets or sets the zoom factor of the image.
        /// </summary>  
        public double? Scale { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use anti-aliasing for rendering.
        /// </summary>  
        public bool? UseAntiAliasing { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use GDI+ or Aspose.Words metafile renderer when saving to EMF.
        /// </summary>  
        public bool? UseGdiEmfRenderer { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use high quality (i.e. slow) rendering algorithms.
        /// </summary>  
        public bool? UseHighQualityRendering { get; set; }

        /// <summary>
        /// Gets or sets the vertical resolution in dots per inch for the generated images.
        /// This property has effect only when saving to raster image formats.
        /// The default value is 96.
        /// </summary>  
        public double? VerticalResolution { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class ImageSaveOptionsData {\n");
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
