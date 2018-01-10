// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SvgSaveOptionsData.cs">
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
  /// container class for svg save options
  /// </summary>  
  public class SvgSaveOptionsData : FixedPageSaveOptionsData 
  {                       
        /// <summary>
        /// Specified whether images should be embedded into SVG document as base64
        /// </summary>  
        public bool? ExportEmbeddedImages { get; set; }

        /// <summary>
        /// Specifies if the output SVG should fill the available viewport area (browser window or container). When set to true width and height of output SVG are set to 100%.
        /// </summary>  
        public bool? FitToViewPort { get; set; }

        /// <summary>
        /// Specifies the physical folder where resources (images) are saved when exporting
        /// </summary>  
        public string ResourcesFolder { get; set; }

        /// <summary>
        /// Specifies the name of the folder used to construct image URIs
        /// </summary>  
        public string ResourcesFolderAlias { get; set; }

        /// <summary>
        /// Show/hide page stepper
        /// </summary>  
        public bool? ShowPageBorder { get; set; }

        /// <summary>
        /// Determines how text should be rendered
        /// </summary>  
        public string TextOutputMode { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SvgSaveOptionsData {\n");
          sb.Append("  ExportEmbeddedImages: ").Append(this.ExportEmbeddedImages).Append("\n");
          sb.Append("  FitToViewPort: ").Append(this.FitToViewPort).Append("\n");
          sb.Append("  ResourcesFolder: ").Append(this.ResourcesFolder).Append("\n");
          sb.Append("  ResourcesFolderAlias: ").Append(this.ResourcesFolderAlias).Append("\n");
          sb.Append("  ShowPageBorder: ").Append(this.ShowPageBorder).Append("\n");
          sb.Append("  TextOutputMode: ").Append(this.TextOutputMode).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
