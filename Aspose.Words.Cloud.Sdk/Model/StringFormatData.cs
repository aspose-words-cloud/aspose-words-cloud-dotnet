// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StringFormatData.cs">
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
  /// Allows to specify System.Drawing.StringFormat options.
  /// </summary>  
  public class StringFormatData 
  {                       
        /// <summary>
        /// Gets or sets horizontal alignment of the string.
        /// </summary>
        /// <value>Gets or sets horizontal alignment of the string.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlignmentEnum
        { 
            /// <summary>
            /// Enum Near for "Near"
            /// </summary>            
            Near,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>            
            Center,
            
            /// <summary>
            /// Enum Far for "Far"
            /// </summary>            
            Far            
        }

        /// <summary>
        /// Gets or sets a System.Drawing.StringFormatFlags enumeration that contains formatting information.
        /// </summary>
        /// <value>Gets or sets a System.Drawing.StringFormatFlags enumeration that contains formatting information.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatFlagsEnum
        { 
            /// <summary>
            /// Enum DirectionRightToLeft for "DirectionRightToLeft"
            /// </summary>            
            DirectionRightToLeft,
            
            /// <summary>
            /// Enum DirectionVertical for "DirectionVertical"
            /// </summary>            
            DirectionVertical,
            
            /// <summary>
            /// Enum FitBlackBox for "FitBlackBox"
            /// </summary>            
            FitBlackBox,
            
            /// <summary>
            /// Enum DisplayFormatControl for "DisplayFormatControl"
            /// </summary>            
            DisplayFormatControl,
            
            /// <summary>
            /// Enum NoFontFallback for "NoFontFallback"
            /// </summary>            
            NoFontFallback,
            
            /// <summary>
            /// Enum MeasureTrailingSpaces for "MeasureTrailingSpaces"
            /// </summary>            
            MeasureTrailingSpaces,
            
            /// <summary>
            /// Enum NoWrap for "NoWrap"
            /// </summary>            
            NoWrap,
            
            /// <summary>
            /// Enum LineLimit for "LineLimit"
            /// </summary>            
            LineLimit,
            
            /// <summary>
            /// Enum NoClip for "NoClip"
            /// </summary>            
            NoClip            
        }

        /// <summary>
        /// Gets or sets the System.Drawing.Text.HotkeyPrefix object for this System.Drawing.StringFormat object.
        /// </summary>
        /// <value>Gets or sets the System.Drawing.Text.HotkeyPrefix object for this System.Drawing.StringFormat object.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HotkeyPrefixEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Show for "Show"
            /// </summary>            
            Show,
            
            /// <summary>
            /// Enum Hide for "Hide"
            /// </summary>            
            Hide            
        }

        /// <summary>
        /// Gets or sets the vertical alignment of the string.
        /// </summary>
        /// <value>Gets or sets the vertical alignment of the string.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LineAlignmentEnum
        { 
            /// <summary>
            /// Enum Near for "Near"
            /// </summary>            
            Near,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>            
            Center,
            
            /// <summary>
            /// Enum Far for "Far"
            /// </summary>            
            Far            
        }

        /// <summary>
        /// Gets or sets the System.Drawing.StringTrimming enumeration for this System.Drawing.StringFormat object.
        /// </summary>
        /// <value>Gets or sets the System.Drawing.StringTrimming enumeration for this System.Drawing.StringFormat object.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TrimmingEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Character for "Character"
            /// </summary>            
            Character,
            
            /// <summary>
            /// Enum Word for "Word"
            /// </summary>            
            Word,
            
            /// <summary>
            /// Enum EllipsisCharacter for "EllipsisCharacter"
            /// </summary>            
            EllipsisCharacter,
            
            /// <summary>
            /// Enum EllipsisWord for "EllipsisWord"
            /// </summary>            
            EllipsisWord,
            
            /// <summary>
            /// Enum EllipsisPath for "EllipsisPath"
            /// </summary>            
            EllipsisPath            
        }

        /// <summary>
        /// Gets or sets horizontal alignment of the string.
        /// </summary>
        public AlignmentEnum? Alignment { get; set; }

        /// <summary>
        /// Gets or sets a System.Drawing.StringFormatFlags enumeration that contains formatting information.
        /// </summary>
        public FormatFlagsEnum? FormatFlags { get; set; }

        /// <summary>
        /// Gets or sets the System.Drawing.Text.HotkeyPrefix object for this System.Drawing.StringFormat object.
        /// </summary>
        public HotkeyPrefixEnum? HotkeyPrefix { get; set; }

        /// <summary>
        /// Gets or sets the vertical alignment of the string.
        /// </summary>
        public LineAlignmentEnum? LineAlignment { get; set; }

        /// <summary>
        /// Gets or sets the System.Drawing.StringTrimming enumeration for this System.Drawing.StringFormat object.
        /// </summary>
        public TrimmingEnum? Trimming { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class StringFormatData {\n");
          sb.Append("  Alignment: ").Append(this.Alignment).Append("\n");
          sb.Append("  FormatFlags: ").Append(this.FormatFlags).Append("\n");
          sb.Append("  HotkeyPrefix: ").Append(this.HotkeyPrefix).Append("\n");
          sb.Append("  LineAlignment: ").Append(this.LineAlignment).Append("\n");
          sb.Append("  Trimming: ").Append(this.Trimming).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
