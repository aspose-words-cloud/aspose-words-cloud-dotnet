// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MetafileRenderingOptionsData.cs">
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
  /// container class for options of metafile rendering.
  /// </summary>  
  public class MetafileRenderingOptionsData 
  {                       
        /// <summary>
        /// Gets or sets determines how EMF+ Dual metafiles should be rendered.
        /// </summary>  
        public string EmfPlusDualRenderingMode { get; set; }

        /// <summary>
        /// Gets or sets a value determining whether or not the raster operations should be emulated.             
        /// </summary>  
        public bool? EmulateRasterOperations { get; set; }

        /// <summary>
        /// Gets or sets determines how metafile images should be rendered.
        /// </summary>  
        public string RenderingMode { get; set; }

        /// <summary>
        /// Gets or sets determines how WMF metafiles with embedded EMF metafiles should be rendered.
        /// </summary>  
        public bool? UseEmfEmbeddedToWmf { get; set; }

        /// <summary>
        /// Gets or sets a value determining whether or not to scale fonts in WMF metafile according to metafile size on the page. The default value is true.
        /// </summary>  
        public bool? ScaleWmfFontsToMetafileSize { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MetafileRenderingOptionsData {\n");
          sb.Append("  EmfPlusDualRenderingMode: ").Append(this.EmfPlusDualRenderingMode).Append("\n");
          sb.Append("  EmulateRasterOperations: ").Append(this.EmulateRasterOperations).Append("\n");
          sb.Append("  RenderingMode: ").Append(this.RenderingMode).Append("\n");
          sb.Append("  UseEmfEmbeddedToWmf: ").Append(this.UseEmfEmbeddedToWmf).Append("\n");
          sb.Append("  ScaleWmfFontsToMetafileSize: ").Append(this.ScaleWmfFontsToMetafileSize).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
