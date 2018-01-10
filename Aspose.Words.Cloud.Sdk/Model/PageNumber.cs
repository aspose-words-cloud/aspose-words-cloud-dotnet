// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PageNumber.cs">
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
  /// Class is used for insert page number request building.
  /// </summary>  
  public class PageNumber 
  {                       
        /// <summary>
        /// Page number format, e.g. \"{PAGE} of {NUMPAGES}\".
        /// </summary>  
        public string Format { get; set; }

        /// <summary>
        /// Text alignment, possible values are left, right, center or justify.
        /// </summary>  
        public string Alignment { get; set; }

        /// <summary>
        /// If true the page number is added at the top of the page, else at the bottom.
        /// </summary>  
        public bool? IsTop { get; set; }

        /// <summary>
        /// If true the page number is added on first page too.
        /// </summary>  
        public bool? SetPageNumberOnFirstPage { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PageNumber {\n");
          sb.Append("  Format: ").Append(this.Format).Append("\n");
          sb.Append("  Alignment: ").Append(this.Alignment).Append("\n");
          sb.Append("  IsTop: ").Append(this.IsTop).Append("\n");
          sb.Append("  SetPageNumberOnFirstPage: ").Append(this.SetPageNumberOnFirstPage).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
