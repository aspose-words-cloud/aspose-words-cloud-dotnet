// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OfficeMathObject.cs">
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
  /// OfficeMath object.
  /// </summary>  
  public class OfficeMathObject : OfficeMathLink 
  {                       
        /// <summary>
        /// Gets or sets /sets Office Math display format type which represents whether an equation is displayed inline with the text or displayed on its own line.
        /// </summary>
        /// <value>Gets or sets /sets Office Math display format type which represents whether an equation is displayed inline with the text or displayed on its own line.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DisplayTypeEnum
        { 
            /// <summary>
            /// Enum value "Display"
            /// </summary>
            Display,
            
            /// <summary>
            /// Enum value "Inline"
            /// </summary>
            Inline            
        }

        /// <summary>
        /// Gets or sets /sets Office Math justification.
        /// </summary>
        /// <value>Gets or sets /sets Office Math justification.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum JustificationEnum
        { 
            /// <summary>
            /// Enum value "CenterGroup"
            /// </summary>
            CenterGroup,
            
            /// <summary>
            /// Enum value "Default"
            /// </summary>
            Default,
            
            /// <summary>
            /// Enum value "Center"
            /// </summary>
            Center,
            
            /// <summary>
            /// Enum value "Left"
            /// </summary>
            Left,
            
            /// <summary>
            /// Enum value "Right"
            /// </summary>
            Right,
            
            /// <summary>
            /// Enum value "Inline"
            /// </summary>
            Inline            
        }

        /// <summary>
        /// Gets or sets type Aspose.Words.Math.OfficeMath.MathObjectType of this Office Math object.
        /// </summary>
        /// <value>Gets or sets type Aspose.Words.Math.OfficeMath.MathObjectType of this Office Math object.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MathObjectTypeEnum
        { 
            /// <summary>
            /// Enum value "OMath"
            /// </summary>
            OMath,
            
            /// <summary>
            /// Enum value "OMathPara"
            /// </summary>
            OMathPara,
            
            /// <summary>
            /// Enum value "Accent"
            /// </summary>
            Accent,
            
            /// <summary>
            /// Enum value "Bar"
            /// </summary>
            Bar,
            
            /// <summary>
            /// Enum value "BorderBox"
            /// </summary>
            BorderBox,
            
            /// <summary>
            /// Enum value "Box"
            /// </summary>
            Box,
            
            /// <summary>
            /// Enum value "Delimiter"
            /// </summary>
            Delimiter,
            
            /// <summary>
            /// Enum value "Degree"
            /// </summary>
            Degree,
            
            /// <summary>
            /// Enum value "Argument"
            /// </summary>
            Argument,
            
            /// <summary>
            /// Enum value "Array"
            /// </summary>
            Array,
            
            /// <summary>
            /// Enum value "Fraction"
            /// </summary>
            Fraction,
            
            /// <summary>
            /// Enum value "Denominator"
            /// </summary>
            Denominator,
            
            /// <summary>
            /// Enum value "Numerator"
            /// </summary>
            Numerator,
            
            /// <summary>
            /// Enum value "Function"
            /// </summary>
            Function,
            
            /// <summary>
            /// Enum value "FunctionName"
            /// </summary>
            FunctionName,
            
            /// <summary>
            /// Enum value "GroupCharacter"
            /// </summary>
            GroupCharacter,
            
            /// <summary>
            /// Enum value "Limit"
            /// </summary>
            Limit,
            
            /// <summary>
            /// Enum value "LowerLimit"
            /// </summary>
            LowerLimit,
            
            /// <summary>
            /// Enum value "UpperLimit"
            /// </summary>
            UpperLimit,
            
            /// <summary>
            /// Enum value "Matrix"
            /// </summary>
            Matrix,
            
            /// <summary>
            /// Enum value "MatrixRow"
            /// </summary>
            MatrixRow,
            
            /// <summary>
            /// Enum value "NAry"
            /// </summary>
            NAry,
            
            /// <summary>
            /// Enum value "Phantom"
            /// </summary>
            Phantom,
            
            /// <summary>
            /// Enum value "Radical"
            /// </summary>
            Radical,
            
            /// <summary>
            /// Enum value "SubscriptPart"
            /// </summary>
            SubscriptPart,
            
            /// <summary>
            /// Enum value "SuperscriptPart"
            /// </summary>
            SuperscriptPart,
            
            /// <summary>
            /// Enum value "PreSubSuperscript"
            /// </summary>
            PreSubSuperscript,
            
            /// <summary>
            /// Enum value "Subscript"
            /// </summary>
            Subscript,
            
            /// <summary>
            /// Enum value "SubSuperscript"
            /// </summary>
            SubSuperscript,
            
            /// <summary>
            /// Enum value "Supercript"
            /// </summary>
            Supercript            
        }

        /// <summary>
        /// Gets or sets /sets Office Math display format type which represents whether an equation is displayed inline with the text or displayed on its own line.
        /// </summary>
        public DisplayTypeEnum? DisplayType { get; set; }

        /// <summary>
        /// Gets or sets /sets Office Math justification.
        /// </summary>
        public JustificationEnum? Justification { get; set; }

        /// <summary>
        /// Gets or sets type Aspose.Words.Math.OfficeMath.MathObjectType of this Office Math object.
        /// </summary>
        public MathObjectTypeEnum? MathObjectType { get; set; }

        /// <summary>
        /// Gets or sets content of footnote.
        /// </summary>  
        public StoryChildNodes Content { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class OfficeMathObject {\n");
          sb.Append("  Content: ").Append(this.Content).Append("\n");
          sb.Append("  DisplayType: ").Append(this.DisplayType).Append("\n");
          sb.Append("  Justification: ").Append(this.Justification).Append("\n");
          sb.Append("  MathObjectType: ").Append(this.MathObjectType).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
