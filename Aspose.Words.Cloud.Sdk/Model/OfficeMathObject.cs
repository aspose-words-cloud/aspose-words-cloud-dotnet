// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OfficeMathObject.cs">
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
  /// OfficeMath object.
  /// </summary>  
  public class OfficeMathObject : OfficeMathLink 
  {                       
        /// <summary>
        /// Gets/sets Office Math display format type which represents whether an equation is displayed inline with the text or displayed on its own line.
        /// </summary>
        /// <value>Gets/sets Office Math display format type which represents whether an equation is displayed inline with the text or displayed on its own line.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DisplayTypeEnum
        { 
            /// <summary>
            /// Enum Display for "Display"
            /// </summary>            
            Display,
            
            /// <summary>
            /// Enum Inline for "Inline"
            /// </summary>            
            Inline            
        }

        /// <summary>
        /// Gets/sets Office Math justification.
        /// </summary>
        /// <value>Gets/sets Office Math justification.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum JustificationEnum
        { 
            /// <summary>
            /// Enum CenterGroup for "CenterGroup"
            /// </summary>            
            CenterGroup,
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>            
            Center,
            
            /// <summary>
            /// Enum Left for "Left"
            /// </summary>            
            Left,
            
            /// <summary>
            /// Enum Right for "Right"
            /// </summary>            
            Right,
            
            /// <summary>
            /// Enum Inline for "Inline"
            /// </summary>            
            Inline            
        }

        /// <summary>
        /// Gets type Aspose.Words.Math.OfficeMath.MathObjectType of this Office Math object.
        /// </summary>
        /// <value>Gets type Aspose.Words.Math.OfficeMath.MathObjectType of this Office Math object.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MathObjectTypeEnum
        { 
            /// <summary>
            /// Enum OMath for "OMath"
            /// </summary>            
            OMath,
            
            /// <summary>
            /// Enum OMathPara for "OMathPara"
            /// </summary>            
            OMathPara,
            
            /// <summary>
            /// Enum Accent for "Accent"
            /// </summary>            
            Accent,
            
            /// <summary>
            /// Enum Bar for "Bar"
            /// </summary>            
            Bar,
            
            /// <summary>
            /// Enum BorderBox for "BorderBox"
            /// </summary>            
            BorderBox,
            
            /// <summary>
            /// Enum Box for "Box"
            /// </summary>            
            Box,
            
            /// <summary>
            /// Enum Delimiter for "Delimiter"
            /// </summary>            
            Delimiter,
            
            /// <summary>
            /// Enum Degree for "Degree"
            /// </summary>            
            Degree,
            
            /// <summary>
            /// Enum Argument for "Argument"
            /// </summary>            
            Argument,
            
            /// <summary>
            /// Enum Array for "Array"
            /// </summary>            
            Array,
            
            /// <summary>
            /// Enum Fraction for "Fraction"
            /// </summary>            
            Fraction,
            
            /// <summary>
            /// Enum Denominator for "Denominator"
            /// </summary>            
            Denominator,
            
            /// <summary>
            /// Enum Numerator for "Numerator"
            /// </summary>            
            Numerator,
            
            /// <summary>
            /// Enum Function for "Function"
            /// </summary>            
            Function,
            
            /// <summary>
            /// Enum FunctionName for "FunctionName"
            /// </summary>            
            FunctionName,
            
            /// <summary>
            /// Enum GroupCharacter for "GroupCharacter"
            /// </summary>            
            GroupCharacter,
            
            /// <summary>
            /// Enum Limit for "Limit"
            /// </summary>            
            Limit,
            
            /// <summary>
            /// Enum LowerLimit for "LowerLimit"
            /// </summary>            
            LowerLimit,
            
            /// <summary>
            /// Enum UpperLimit for "UpperLimit"
            /// </summary>            
            UpperLimit,
            
            /// <summary>
            /// Enum Matrix for "Matrix"
            /// </summary>            
            Matrix,
            
            /// <summary>
            /// Enum MatrixRow for "MatrixRow"
            /// </summary>            
            MatrixRow,
            
            /// <summary>
            /// Enum NAry for "NAry"
            /// </summary>            
            NAry,
            
            /// <summary>
            /// Enum Phantom for "Phantom"
            /// </summary>            
            Phantom,
            
            /// <summary>
            /// Enum Radical for "Radical"
            /// </summary>            
            Radical,
            
            /// <summary>
            /// Enum SubscriptPart for "SubscriptPart"
            /// </summary>            
            SubscriptPart,
            
            /// <summary>
            /// Enum SuperscriptPart for "SuperscriptPart"
            /// </summary>            
            SuperscriptPart,
            
            /// <summary>
            /// Enum PreSubSuperscript for "PreSubSuperscript"
            /// </summary>            
            PreSubSuperscript,
            
            /// <summary>
            /// Enum Subscript for "Subscript"
            /// </summary>            
            Subscript,
            
            /// <summary>
            /// Enum SubSuperscript for "SubSuperscript"
            /// </summary>            
            SubSuperscript,
            
            /// <summary>
            /// Enum Supercript for "Supercript"
            /// </summary>            
            Supercript            
        }

        /// <summary>
        /// Gets/sets Office Math display format type which represents whether an equation is displayed inline with the text or displayed on its own line.
        /// </summary>
        public DisplayTypeEnum? DisplayType { get; set; }

        /// <summary>
        /// Gets/sets Office Math justification.
        /// </summary>
        public JustificationEnum? Justification { get; set; }

        /// <summary>
        /// Gets type Aspose.Words.Math.OfficeMath.MathObjectType of this Office Math object.
        /// </summary>
        public MathObjectTypeEnum? MathObjectType { get; set; }

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
