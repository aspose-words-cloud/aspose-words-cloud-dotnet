// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MetafileRenderingOptionsData.cs">
//   Copyright (c) 2023 Aspose.Words for Cloud
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
    /// Container class for options of metafile rendering.
    /// </summary>
    public class MetafileRenderingOptionsData : IModel
    {
        /// <summary>
        /// Gets or sets the option that controls how EMF+ Dual metafiles should be rendered.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EmfPlusDualRenderingModeEnum
        {
            /// <summary>
            /// Enum value "EmfPlusWithFallback"
            /// </summary>
            EmfPlusWithFallback,

            /// <summary>
            /// Enum value "EmfPlus"
            /// </summary>
            EmfPlus,

            /// <summary>
            /// Enum value "Emf"
            /// </summary>
            Emf,
        }

        /// <summary>
        /// Gets or sets the option that controls how metafile images should be rendered.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RenderingModeEnum
        {
            /// <summary>
            /// Enum value "VectorWithFallback"
            /// </summary>
            VectorWithFallback,

            /// <summary>
            /// Enum value "Vector"
            /// </summary>
            Vector,

            /// <summary>
            /// Enum value "Bitmap"
            /// </summary>
            Bitmap,
        }

        /// <summary>
        /// Gets or sets the option that controls how EMF+ Dual metafiles should be rendered.
        /// </summary>
        public virtual EmfPlusDualRenderingModeEnum? EmfPlusDualRenderingMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the raster operations should be emulated.
        /// Specific raster operations could be used in metafiles. They can not be rendered directly to vector graphics. Emulating raster operations requires partial rasterization of the resulting vector graphics which may affect the metafile rendering performance. When this value is set to true, Aspose.Words emulates the raster operations. The resulting output maybe partially rasterized and performance might be slower. When this value is set to false, Aspose.Words does not emulate the raster operations. When Aspose.Words encounters a raster operation in a metafile it fallbacks to rendering the metafile into a bitmap by using the operating system. This option is used only when metafile is rendered as vector graphics. The default value is true.
        /// </summary>
        public virtual bool? EmulateRasterOperations { get; set; }

        /// <summary>
        /// Gets or sets a value determining whether metafile rendering emulates the display of the metafile according to the size on page
        /// or the display of the metafile in its default size.
        /// </summary>
        public virtual bool? EmulateRenderingToSizeOnPage { get; set; }

        /// <summary>
        /// Gets or sets the resolution in pixels per inch for the emulation of metafile rendering to the size on page.
        /// This option is used only when EmulateRenderingToSizeOnPage is set to true.The default value is 96. This is a default display resolution. I.e. metafile rendering will emulate the display of
        /// the metafile in MS Word with a 100% zoom factor.
        /// </summary>
        public virtual int? EmulateRenderingToSizeOnPageResolution { get; set; }

        /// <summary>
        /// Gets or sets the option that controls how metafile images should be rendered.
        /// </summary>
        public virtual RenderingModeEnum? RenderingMode { get; set; }

        /// <summary>
        /// Gets or sets the flag, that controls how WMF metafiles with embedded EMF metafiles should be rendered.
        /// </summary>
        public virtual bool? UseEmfEmbeddedToWmf { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public virtual void Validate()
        {
        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetafileRenderingOptionsData {\n");
            sb.Append("  EmfPlusDualRenderingMode: ").Append(this.EmfPlusDualRenderingMode).Append("\n");
            sb.Append("  EmulateRasterOperations: ").Append(this.EmulateRasterOperations).Append("\n");
            sb.Append("  EmulateRenderingToSizeOnPage: ").Append(this.EmulateRenderingToSizeOnPage).Append("\n");
            sb.Append("  EmulateRenderingToSizeOnPageResolution: ").Append(this.EmulateRenderingToSizeOnPageResolution).Append("\n");
            sb.Append("  RenderingMode: ").Append(this.RenderingMode).Append("\n");
            sb.Append("  UseEmfEmbeddedToWmf: ").Append(this.UseEmfEmbeddedToWmf).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
