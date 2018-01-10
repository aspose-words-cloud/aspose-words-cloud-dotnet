// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DownsampleOptionsData.cs">
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
  /// Container class for Downsample options
  /// </summary>  
  public class DownsampleOptionsData 
  {                       
        /// <summary>
        /// Specifies whether images should be downsampled.
        /// </summary>  
        public bool? DownsampleImages { get; set; }

        /// <summary>
        /// Specifies the resolution in pixels per inch which the images should be downsampled to.
        /// </summary>  
        public int? Resolution { get; set; }

        /// <summary>
        /// Specifies the threshold resolution in pixels per inch. If resolution of an image in the document is less than threshold value,  the downsampling algorithm will not be applied. A value of 0 means the threshold check is not used and all images that can be reduced in size are downsampled.
        /// </summary>  
        public int? ResolutionThreshold { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DownsampleOptionsData {\n");
          sb.Append("  DownsampleImages: ").Append(this.DownsampleImages).Append("\n");
          sb.Append("  Resolution: ").Append(this.Resolution).Append("\n");
          sb.Append("  ResolutionThreshold: ").Append(this.ResolutionThreshold).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
