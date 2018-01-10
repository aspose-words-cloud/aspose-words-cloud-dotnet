// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SaveOptionsData.cs">
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
  /// base container class for save options data
  /// </summary>  
  public class SaveOptionsData 
  {                       
        /// <summary>
        /// Gets or sets a value determining how colors are rendered. { Normal | Grayscale}
        /// </summary>  
        public string ColorMode { get; set; }

        /// <summary>
        /// format of save
        /// </summary>  
        public string SaveFormat { get; set; }

        /// <summary>
        /// name of destination file
        /// </summary>  
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets a value determining how DrawingML shapes are rendered. { Fallback | DrawingML }
        /// </summary>  
        public string DmlRenderingMode { get; set; }

        /// <summary>
        /// Gets or sets a value determining how DrawingML effects are rendered. { Simplified | None | Fine }
        /// </summary>  
        public string DmlEffectsRenderingMode { get; set; }

        /// <summary>
        /// Controls zip output or not. Default value is false.
        /// </summary>  
        public bool? ZipOutput { get; set; }

        /// <summary>
        /// Gets or sets value determining whether content of  is updated before saving.
        /// </summary>  
        public bool? UpdateSdtContent { get; set; }

        /// <summary>
        /// Gets or sets a value determining if fields should be updated before saving the document to a fixed page format. Default value for this property is true
        /// </summary>  
        public bool? UpdateFields { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SaveOptionsData {\n");
          sb.Append("  ColorMode: ").Append(this.ColorMode).Append("\n");
          sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
          sb.Append("  FileName: ").Append(this.FileName).Append("\n");
          sb.Append("  DmlRenderingMode: ").Append(this.DmlRenderingMode).Append("\n");
          sb.Append("  DmlEffectsRenderingMode: ").Append(this.DmlEffectsRenderingMode).Append("\n");
          sb.Append("  ZipOutput: ").Append(this.ZipOutput).Append("\n");
          sb.Append("  UpdateSdtContent: ").Append(this.UpdateSdtContent).Append("\n");
          sb.Append("  UpdateFields: ").Append(this.UpdateFields).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
