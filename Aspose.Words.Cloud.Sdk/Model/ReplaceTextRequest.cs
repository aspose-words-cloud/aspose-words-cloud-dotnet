// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ReplaceTextRequest.cs">
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
  /// Class for document replace text request building.
  /// </summary>  
  public class ReplaceTextRequest 
  {                       
        /// <summary>
        /// Old text value (or regex pattern ) to replace.
        /// </summary>  
        public string OldValue { get; set; }

        /// <summary>
        /// New text value to replace by.
        /// </summary>  
        public string NewValue { get; set; }

        /// <summary>
        /// Flag, true means the search is case-sensitive; false means the search is not case-sensitive.
        /// </summary>  
        public bool? IsMatchCase { get; set; }

        /// <summary>
        /// Flag, means that only whole word matched are replaced.
        /// </summary>  
        public bool? IsMatchWholeWord { get; set; }

        /// <summary>
        /// Flag, means that  contains regex expression.
        /// </summary>  
        public bool? IsOldValueRegex { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ReplaceTextRequest {\n");
          sb.Append("  OldValue: ").Append(this.OldValue).Append("\n");
          sb.Append("  NewValue: ").Append(this.NewValue).Append("\n");
          sb.Append("  IsMatchCase: ").Append(this.IsMatchCase).Append("\n");
          sb.Append("  IsMatchWholeWord: ").Append(this.IsMatchWholeWord).Append("\n");
          sb.Append("  IsOldValueRegex: ").Append(this.IsOldValueRegex).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
