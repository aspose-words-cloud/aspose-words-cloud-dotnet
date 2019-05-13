// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OdtSaveOptionsData.cs">
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
  /// container class for odt/ott save options
  /// </summary>  
  public class OdtSaveOptionsData : SaveOptionsData 
  {                       
        /// <summary>
        /// Allows to specify units of measure to apply to document content. The default value is Aspose.Words.Saving.OdtSaveMeasureUnit.Centimeters  Open Office uses centimeters when specifying lengths, widths and other measurable formatting and content properties in documents whereas MS Office uses inches.
        /// </summary>
        /// <value>Allows to specify units of measure to apply to document content. The default value is Aspose.Words.Saving.OdtSaveMeasureUnit.Centimeters  Open Office uses centimeters when specifying lengths, widths and other measurable formatting and content properties in documents whereas MS Office uses inches.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MeasureUnitEnum
        { 
            /// <summary>
            /// Enum Centimeters for "Centimeters"
            /// </summary>            
            Centimeters,
            
            /// <summary>
            /// Enum Inches for "Inches"
            /// </summary>            
            Inches            
        }

        /// <summary>
        /// Allows to specify units of measure to apply to document content. The default value is Aspose.Words.Saving.OdtSaveMeasureUnit.Centimeters  Open Office uses centimeters when specifying lengths, widths and other measurable formatting and content properties in documents whereas MS Office uses inches.
        /// </summary>
        public MeasureUnitEnum? MeasureUnit { get; set; }

        /// <summary>
        /// Specifies whether export should correspond to ODT specification 1.1 strictly
        /// </summary>  
        public bool? IsStrictSchema11 { get; set; }

        /// <summary>
        /// Specifies whether or not use pretty formats output
        /// </summary>  
        public bool? PrettyFormat { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class OdtSaveOptionsData {\n");
          sb.Append("  IsStrictSchema11: ").Append(this.IsStrictSchema11).Append("\n");
          sb.Append("  MeasureUnit: ").Append(this.MeasureUnit).Append("\n");
          sb.Append("  PrettyFormat: ").Append(this.PrettyFormat).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
