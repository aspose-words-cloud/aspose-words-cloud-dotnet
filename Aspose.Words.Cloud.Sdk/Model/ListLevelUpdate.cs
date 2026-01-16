// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ListLevelUpdate.cs">
//   Copyright (c) 2026 Aspose.Words for Cloud
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
    /// Represents a document list levels.
    /// </summary>
    public class ListLevelUpdate : IModel
    {
        /// <summary>
        /// Gets or sets the number style for this list level.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NumberStyleEnum
        {
            /// <summary>
            /// Enum value "Arabic"
            /// </summary>
            Arabic,

            /// <summary>
            /// Enum value "UppercaseRoman"
            /// </summary>
            UppercaseRoman,

            /// <summary>
            /// Enum value "LowercaseRoman"
            /// </summary>
            LowercaseRoman,

            /// <summary>
            /// Enum value "UppercaseLetter"
            /// </summary>
            UppercaseLetter,

            /// <summary>
            /// Enum value "LowercaseLetter"
            /// </summary>
            LowercaseLetter,

            /// <summary>
            /// Enum value "Ordinal"
            /// </summary>
            Ordinal,

            /// <summary>
            /// Enum value "Number"
            /// </summary>
            Number,

            /// <summary>
            /// Enum value "OrdinalText"
            /// </summary>
            OrdinalText,

            /// <summary>
            /// Enum value "Hex"
            /// </summary>
            Hex,

            /// <summary>
            /// Enum value "ChicagoManual"
            /// </summary>
            ChicagoManual,

            /// <summary>
            /// Enum value "Kanji"
            /// </summary>
            Kanji,

            /// <summary>
            /// Enum value "KanjiDigit"
            /// </summary>
            KanjiDigit,

            /// <summary>
            /// Enum value "AiueoHalfWidth"
            /// </summary>
            AiueoHalfWidth,

            /// <summary>
            /// Enum value "IrohaHalfWidth"
            /// </summary>
            IrohaHalfWidth,

            /// <summary>
            /// Enum value "ArabicFullWidth"
            /// </summary>
            ArabicFullWidth,

            /// <summary>
            /// Enum value "ArabicHalfWidth"
            /// </summary>
            ArabicHalfWidth,

            /// <summary>
            /// Enum value "KanjiTraditional"
            /// </summary>
            KanjiTraditional,

            /// <summary>
            /// Enum value "KanjiTraditional2"
            /// </summary>
            KanjiTraditional2,

            /// <summary>
            /// Enum value "NumberInCircle"
            /// </summary>
            NumberInCircle,

            /// <summary>
            /// Enum value "DecimalFullWidth"
            /// </summary>
            DecimalFullWidth,

            /// <summary>
            /// Enum value "Aiueo"
            /// </summary>
            Aiueo,

            /// <summary>
            /// Enum value "Iroha"
            /// </summary>
            Iroha,

            /// <summary>
            /// Enum value "LeadingZero"
            /// </summary>
            LeadingZero,

            /// <summary>
            /// Enum value "Bullet"
            /// </summary>
            Bullet,

            /// <summary>
            /// Enum value "Ganada"
            /// </summary>
            Ganada,

            /// <summary>
            /// Enum value "Chosung"
            /// </summary>
            Chosung,

            /// <summary>
            /// Enum value "GB1"
            /// </summary>
            GB1,

            /// <summary>
            /// Enum value "GB2"
            /// </summary>
            GB2,

            /// <summary>
            /// Enum value "GB3"
            /// </summary>
            GB3,

            /// <summary>
            /// Enum value "GB4"
            /// </summary>
            GB4,

            /// <summary>
            /// Enum value "Zodiac1"
            /// </summary>
            Zodiac1,

            /// <summary>
            /// Enum value "Zodiac2"
            /// </summary>
            Zodiac2,

            /// <summary>
            /// Enum value "Zodiac3"
            /// </summary>
            Zodiac3,

            /// <summary>
            /// Enum value "TradChinNum1"
            /// </summary>
            TradChinNum1,

            /// <summary>
            /// Enum value "TradChinNum2"
            /// </summary>
            TradChinNum2,

            /// <summary>
            /// Enum value "TradChinNum3"
            /// </summary>
            TradChinNum3,

            /// <summary>
            /// Enum value "TradChinNum4"
            /// </summary>
            TradChinNum4,

            /// <summary>
            /// Enum value "SimpChinNum1"
            /// </summary>
            SimpChinNum1,

            /// <summary>
            /// Enum value "SimpChinNum2"
            /// </summary>
            SimpChinNum2,

            /// <summary>
            /// Enum value "SimpChinNum3"
            /// </summary>
            SimpChinNum3,

            /// <summary>
            /// Enum value "SimpChinNum4"
            /// </summary>
            SimpChinNum4,

            /// <summary>
            /// Enum value "HanjaRead"
            /// </summary>
            HanjaRead,

            /// <summary>
            /// Enum value "HanjaReadDigit"
            /// </summary>
            HanjaReadDigit,

            /// <summary>
            /// Enum value "Hangul"
            /// </summary>
            Hangul,

            /// <summary>
            /// Enum value "Hanja"
            /// </summary>
            Hanja,

            /// <summary>
            /// Enum value "Hebrew1"
            /// </summary>
            Hebrew1,

            /// <summary>
            /// Enum value "Arabic1"
            /// </summary>
            Arabic1,

            /// <summary>
            /// Enum value "Hebrew2"
            /// </summary>
            Hebrew2,

            /// <summary>
            /// Enum value "Arabic2"
            /// </summary>
            Arabic2,

            /// <summary>
            /// Enum value "HindiLetter1"
            /// </summary>
            HindiLetter1,

            /// <summary>
            /// Enum value "HindiLetter2"
            /// </summary>
            HindiLetter2,

            /// <summary>
            /// Enum value "HindiArabic"
            /// </summary>
            HindiArabic,

            /// <summary>
            /// Enum value "HindiCardinalText"
            /// </summary>
            HindiCardinalText,

            /// <summary>
            /// Enum value "ThaiLetter"
            /// </summary>
            ThaiLetter,

            /// <summary>
            /// Enum value "ThaiArabic"
            /// </summary>
            ThaiArabic,

            /// <summary>
            /// Enum value "ThaiCardinalText"
            /// </summary>
            ThaiCardinalText,

            /// <summary>
            /// Enum value "VietCardinalText"
            /// </summary>
            VietCardinalText,

            /// <summary>
            /// Enum value "NumberInDash"
            /// </summary>
            NumberInDash,

            /// <summary>
            /// Enum value "LowercaseRussian"
            /// </summary>
            LowercaseRussian,

            /// <summary>
            /// Enum value "UppercaseRussian"
            /// </summary>
            UppercaseRussian,

            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,

            /// <summary>
            /// Enum value "Custom"
            /// </summary>
            Custom,
        }

        /// <summary>
        /// Gets or sets the justification of the actual number of the list item.
        /// The list label is justified relative to the Aspose.Words.Lists.ListLevel.NumberPosition
        /// property.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlignmentEnum
        {
            /// <summary>
            /// Enum value "Left"
            /// </summary>
            Left,

            /// <summary>
            /// Enum value "Center"
            /// </summary>
            Center,

            /// <summary>
            /// Enum value "Right"
            /// </summary>
            Right,
        }

        /// <summary>
        /// Gets or sets the character to be inserted after the number for the list level.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TrailingCharacterEnum
        {
            /// <summary>
            /// Enum value "Tab"
            /// </summary>
            Tab,

            /// <summary>
            /// Enum value "Space"
            /// </summary>
            Space,

            /// <summary>
            /// Enum value "Nothing"
            /// </summary>
            Nothing,
        }

        /// <summary>
        /// Gets or sets the starting number for this list level.
        /// The default value is 1.
        /// </summary>
        public virtual int? StartAt { get; set; }

        /// <summary>
        /// Gets or sets the number style for this list level.
        /// </summary>
        public virtual NumberStyleEnum? NumberStyle { get; set; }

        /// <summary>
        /// Gets or sets the number format for the list level.
        /// Among normal text characters, the string can contain placeholder characters \\x0000 to \\x0008 representing the numbers from the corresponding list levels. For example, the string "\\x0000.\\x0001)" will generate a list label that looks something like "1.5)". The number "1" is the current number from the 1st list level, the number "5" is the current number from the 2nd list level. Null is not allowed, but an empty string meaning no number is valid.
        /// </summary>
        public virtual string NumberFormat { get; set; }

        /// <summary>
        /// Gets or sets the justification of the actual number of the list item.
        /// The list label is justified relative to the Aspose.Words.Lists.ListLevel.NumberPosition
        /// property.
        /// </summary>
        public virtual AlignmentEnum? Alignment { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the level turns all inherited numbers to Arabic, false if it preserves their number style.
        /// </summary>
        public virtual bool? IsLegal { get; set; }

        /// <summary>
        /// Gets or sets the list level that must appear before the specified list level restarts numbering.
        /// The value of -1 means the numbering will continue.
        /// </summary>
        public virtual int? RestartAfterLevel { get; set; }

        /// <summary>
        /// Gets or sets the character to be inserted after the number for the list level.
        /// </summary>
        public virtual TrailingCharacterEnum? TrailingCharacter { get; set; }

        /// <summary>
        /// Gets or sets the tab position (in points) for the list level.
        /// Has effect only when Aspose.Words.Lists.ListLevel.TrailingCharacter is a tab.
        /// Aspose.Words.Lists.ListLevel.NumberPosition Aspose.Words.Lists.ListLevel.TextPosition.
        /// </summary>
        public virtual double? TabPosition { get; set; }

        /// <summary>
        /// Gets or sets the position (in points) of the number or bullet for the list level.
        /// Aspose.Words.Lists.ListLevel.NumberPosition corresponds to LeftIndent plus FirstLineIndent of the paragraph. Aspose.Words.Lists.ListLevel.TextPosition Aspose.Words.Lists.ListLevel.TabPosition.
        /// </summary>
        public virtual double? NumberPosition { get; set; }

        /// <summary>
        /// Gets or sets the position (in points) for the second line of wrapping text for the list level.
        /// Aspose.Words.Lists.ListLevel.TextPosition corresponds to LeftIndent of the paragraph.
        /// Aspose.Words.Lists.ListLevel.NumberPosition Aspose.Words.Lists.ListLevel.TabPosition.
        /// </summary>
        public virtual double? TextPosition { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public virtual void Validate()
        {
        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListLevelUpdate {\n");
            sb.Append("  StartAt: ").Append(this.StartAt).Append("\n");
            sb.Append("  NumberStyle: ").Append(this.NumberStyle).Append("\n");
            sb.Append("  NumberFormat: ").Append(this.NumberFormat).Append("\n");
            sb.Append("  Alignment: ").Append(this.Alignment).Append("\n");
            sb.Append("  IsLegal: ").Append(this.IsLegal).Append("\n");
            sb.Append("  RestartAfterLevel: ").Append(this.RestartAfterLevel).Append("\n");
            sb.Append("  TrailingCharacter: ").Append(this.TrailingCharacter).Append("\n");
            sb.Append("  TabPosition: ").Append(this.TabPosition).Append("\n");
            sb.Append("  NumberPosition: ").Append(this.NumberPosition).Append("\n");
            sb.Append("  TextPosition: ").Append(this.TextPosition).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
