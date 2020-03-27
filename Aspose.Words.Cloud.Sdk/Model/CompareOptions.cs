// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CompareOptions.cs">
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
  /// Container class for compare documents options.
  /// </summary>  
  public class CompareOptions 
  {                       
        /// <summary>
        /// Gets or sets specifies which document shall be used as a target during comparison.             
        /// </summary>
        /// <value>Gets or sets specifies which document shall be used as a target during comparison.             </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TargetEnum
        { 
            /// <summary>
            /// Enum value "Current"
            /// </summary>
            Current,
            
            /// <summary>
            /// Enum value "New"
            /// </summary>
            New            
        }

        /// <summary>
        /// Gets or sets specifies which document shall be used as a target during comparison.             
        /// </summary>
        public TargetEnum? Target { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether true indicates that documents comparison is case insensitive. By default comparison is case sensitive.             
        /// </summary>  
        public bool? IgnoreCaseChanges { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether specifies whether to compare the differences in data contained in tables. By default tables are not ignored.             
        /// </summary>  
        public bool? IgnoreTables { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether specifies whether to compare differences in fields. By default fields are not ignored.             
        /// </summary>  
        public bool? IgnoreFields { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether specifies whether to compare differences in footnotes and endnotes. By default footnotes are not ignored.             
        /// </summary>  
        public bool? IgnoreFootnotes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether specifies whether to compare differences in comments. By default comments are not ignored.             
        /// </summary>  
        public bool? IgnoreComments { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether specifies whether to compare differences in the data contained within text boxes. By default textboxes are not ignored.             
        /// </summary>  
        public bool? IgnoreTextboxes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether true indicates that formatting is ignored. By default document formatting is not ignored.             
        /// </summary>  
        public bool? IgnoreFormatting { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether true indicates that headers and footers content is ignored. By default headers and footers are not ignored.             
        /// </summary>  
        public bool? IgnoreHeadersAndFooters { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CompareOptions {\n");
          sb.Append("  IgnoreCaseChanges: ").Append(this.IgnoreCaseChanges).Append("\n");
          sb.Append("  IgnoreTables: ").Append(this.IgnoreTables).Append("\n");
          sb.Append("  IgnoreFields: ").Append(this.IgnoreFields).Append("\n");
          sb.Append("  IgnoreFootnotes: ").Append(this.IgnoreFootnotes).Append("\n");
          sb.Append("  IgnoreComments: ").Append(this.IgnoreComments).Append("\n");
          sb.Append("  IgnoreTextboxes: ").Append(this.IgnoreTextboxes).Append("\n");
          sb.Append("  IgnoreFormatting: ").Append(this.IgnoreFormatting).Append("\n");
          sb.Append("  IgnoreHeadersAndFooters: ").Append(this.IgnoreHeadersAndFooters).Append("\n");
          sb.Append("  Target: ").Append(this.Target).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
