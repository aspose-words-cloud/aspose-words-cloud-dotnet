// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="HeaderFooterLink.cs">
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
  /// HeaderFooter link element
  /// </summary>  
  public class HeaderFooterLink : LinkElement 
  {                       
        /// <summary>
        /// Paragraph&#39;s text
        /// </summary>
        /// <value>Paragraph&#39;s text</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        { 
            /// <summary>
            /// Enum HeaderEven for "HeaderEven"
            /// </summary>            
            HeaderEven,
            
            /// <summary>
            /// Enum HeaderPrimary for "HeaderPrimary"
            /// </summary>            
            HeaderPrimary,
            
            /// <summary>
            /// Enum FooterEven for "FooterEven"
            /// </summary>            
            FooterEven,
            
            /// <summary>
            /// Enum FooterPrimary for "FooterPrimary"
            /// </summary>            
            FooterPrimary,
            
            /// <summary>
            /// Enum HeaderFirst for "HeaderFirst"
            /// </summary>            
            HeaderFirst,
            
            /// <summary>
            /// Enum FooterFirst for "FooterFirst"
            /// </summary>            
            FooterFirst            
        }

        /// <summary>
        /// Paragraph&#39;s text
        /// </summary>
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class HeaderFooterLink {\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
