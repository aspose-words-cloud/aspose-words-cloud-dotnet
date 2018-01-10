// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FormFieldCheckbox.cs">
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
  /// FormField checkbox element
  /// </summary>  
  public class FormFieldCheckbox : FormField 
  {                       
        /// <summary>
        /// Gets or sets the boolean value that indicates whether the size of the textbox is automatic or specified explicitly.
        /// </summary>  
        public bool? IsCheckBoxExactSize { get; set; }

        /// <summary>
        /// Gets or sets the size of the checkbox in points. Has effect only when  is true.
        /// </summary>  
        public double? CheckBoxSize { get; set; }

        /// <summary>
        /// Gets or sets the checked status of the check box form field.
        /// </summary>  
        public bool? _Checked { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FormFieldCheckbox {\n");
          sb.Append("  IsCheckBoxExactSize: ").Append(this.IsCheckBoxExactSize).Append("\n");
          sb.Append("  CheckBoxSize: ").Append(this.CheckBoxSize).Append("\n");
          sb.Append("  _Checked: ").Append(this._Checked).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
