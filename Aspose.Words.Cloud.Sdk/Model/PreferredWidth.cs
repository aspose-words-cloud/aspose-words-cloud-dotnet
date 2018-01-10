// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PreferredWidth.cs">
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
  /// Preferred width.
  /// </summary>  
  public class PreferredWidth 
  {                       
        /// <summary>
        /// Gets the unit of measure used for this preferred width value.
        /// </summary>
        /// <value>Gets the unit of measure used for this preferred width value.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        { 
            /// <summary>
            /// Enum Auto for "Auto"
            /// </summary>            
            Auto,
            
            /// <summary>
            /// Enum Percent for "Percent"
            /// </summary>            
            Percent,
            
            /// <summary>
            /// Enum Points for "Points"
            /// </summary>            
            Points            
        }

        /// <summary>
        /// Gets the unit of measure used for this preferred width value.
        /// </summary>
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Gets or sets the preferred width value. The unit of measure is specified in the  property.
        /// </summary>  
        public double? Value { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PreferredWidth {\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  Value: ").Append(this.Value).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
