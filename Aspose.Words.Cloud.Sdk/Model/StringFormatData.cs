// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StringFormatData.cs">
//   Copyright (c) 2021 Aspose.Words for Cloud
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
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlignmentEnum
        { 
            /// <summary>
            /// Enum value "Near"
            /// </summary>
            Near,

            /// <summary>
            /// Enum value "Center"
            /// </summary>
            Center,

            /// <summary>
            /// Enum value "Far"
            /// </summary>
            Far
        }

        /// <summary>
        /// Gets or sets the System.Drawing.StringFormatFlags enumeration, that contains formatting information.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatFlagsEnum
        { 
            /// <summary>
            /// Enum value "DirectionRightToLeft"
            /// </summary>
            DirectionRightToLeft,

            /// <summary>
            /// Enum value "DirectionVertical"
            /// </summary>
            DirectionVertical,

            /// <summary>
            /// Enum value "FitBlackBox"
            /// </summary>
            FitBlackBox,

            /// <summary>
            /// Enum value "DisplayFormatControl"
            /// </summary>
            DisplayFormatControl,

            /// <summary>
            /// Enum value "NoFontFallback"
            /// </summary>
            NoFontFallback,

            /// <summary>
            /// Enum value "MeasureTrailingSpaces"
            /// </summary>
            MeasureTrailingSpaces,

            /// <summary>
            /// Enum value "NoWrap"
            /// </summary>
            NoWrap,

            /// <summary>
            /// Enum value "LineLimit"
            /// </summary>
            LineLimit,

            /// <summary>
            /// Enum value "NoClip"
            /// </summary>
            NoClip
        }

        /// <summary>
        /// Gets or sets the System.Drawing.Text.HotkeyPrefix object for this System.Drawing.StringFormat object.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HotkeyPrefixEnum
        { 
            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,

            /// <summary>
            /// Enum value "Show"
            /// </summary>
            Show,

            /// <summary>
            /// Enum value "Hide"
            /// </summary>
            Hide
        }

        /// <summary>
        /// Gets or sets the vertical alignment of the string.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LineAlignmentEnum
        { 
            /// <summary>
            /// Enum value "Near"
            /// </summary>
            Near,

            /// <summary>
            /// Enum value "Center"
            /// </summary>
            Center,

            /// <summary>
            /// Enum value "Far"
            /// </summary>
            Far
        }

        /// <summary>
        /// Gets or sets the System.Drawing.StringTrimming enumeration for this System.Drawing.StringFormat object.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TrimmingEnum
        { 
            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,

            /// <summary>
            /// Enum value "Character"
            /// </summary>
            Character,

            /// <summary>
            /// Enum value "Word"
            /// </summary>
            Word,

            /// <summary>
            /// Enum value "EllipsisCharacter"
            /// </summary>
            EllipsisCharacter,

            /// <summary>
            /// Enum value "EllipsisWord"
            /// </summary>
            EllipsisWord,

            /// <summary>
            /// Enum value "EllipsisPath"
            /// </summary>
            EllipsisPath
        }

        /// <summary>
        /// Gets or sets horizontal alignment of the string.
        /// </summary>  
        public AlignmentEnum? Alignment { get; set; }

        /// <summary>
        /// Gets or sets the System.Drawing.StringFormatFlags enumeration, that contains formatting information.
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
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
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
