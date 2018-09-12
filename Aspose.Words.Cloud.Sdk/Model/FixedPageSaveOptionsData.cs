// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FixedPageSaveOptionsData.cs">
//   Copyright (c) 2018 Aspose.Words for Cloud
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
  /// 
  /// </summary>  
  public class FixedPageSaveOptionsData : SaveOptionsData 
  {                       
        /// <summary>
        /// Gets or sets JpegQuality
        /// </summary>  
        public int? JpegQuality { get; set; }

        /// <summary>
        /// Gets or sets MetafileRenderingOptions
        /// </summary>  
        public MetafileRenderingOptionsData MetafileRenderingOptions { get; set; }

        /// <summary>
        /// Gets or sets NumeralFormat
        /// </summary>  
        public string NumeralFormat { get; set; }

        /// <summary>
        /// Gets or sets OptimizeOutput
        /// </summary>  
        public bool? OptimizeOutput { get; set; }

        /// <summary>
        /// Gets or sets PageCount
        /// </summary>  
        public int? PageCount { get; set; }

        /// <summary>
        /// Gets or sets PageIndex
        /// </summary>  
        public int? PageIndex { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FixedPageSaveOptionsData {\n");
          sb.Append("  JpegQuality: ").Append(this.JpegQuality).Append("\n");
          sb.Append("  MetafileRenderingOptions: ").Append(this.MetafileRenderingOptions).Append("\n");
          sb.Append("  NumeralFormat: ").Append(this.NumeralFormat).Append("\n");
          sb.Append("  OptimizeOutput: ").Append(this.OptimizeOutput).Append("\n");
          sb.Append("  PageCount: ").Append(this.PageCount).Append("\n");
          sb.Append("  PageIndex: ").Append(this.PageIndex).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
