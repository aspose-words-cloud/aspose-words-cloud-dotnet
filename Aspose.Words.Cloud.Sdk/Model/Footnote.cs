// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Footnote.cs">
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
  /// Footnote.
  /// </summary>  
  public class Footnote : FootnoteLink 
  {                       
        /// <summary>
        /// Returns a value that specifies whether this is a footnote or endnote.
        /// </summary>
        /// <value>Returns a value that specifies whether this is a footnote or endnote.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FootnoteTypeEnum
        { 
            /// <summary>
            /// Enum Footnote for "Footnote"
            /// </summary>            
            Footnote,
            
            /// <summary>
            /// Enum Endnote for "Endnote"
            /// </summary>            
            Endnote            
        }

        /// <summary>
        /// Returns a value that specifies whether this is a footnote or endnote.
        /// </summary>
        public FootnoteTypeEnum? FootnoteType { get; set; }

        /// <summary>
        /// Link to comment range start node.
        /// </summary>  
        public DocumentPosition Position { get; set; }

        /// <summary>
        /// Gets/sets custom reference mark to be used for this footnote. Default value is , meaning auto-numbered footnotes are used.
        /// </summary>  
        public string ReferenceMark { get; set; }

        /// <summary>
        /// This is a convenience property that allows to easily get or set text of the footnote.
        /// </summary>  
        public string Text { get; set; }

        /// <summary>
        /// Content of footnote.
        /// </summary>  
        public StoryChildNodes Content { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Footnote {\n");
          sb.Append("  Position: ").Append(this.Position).Append("\n");
          sb.Append("  FootnoteType: ").Append(this.FootnoteType).Append("\n");
          sb.Append("  ReferenceMark: ").Append(this.ReferenceMark).Append("\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  Content: ").Append(this.Content).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
