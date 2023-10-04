// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PageSetup.cs">
//   Copyright (c) 2023 Aspose.Words for Cloud
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
    /// Represents the page setup properties of a section.
    /// PageSetup object contains all the page setup attributes of a section (left margin, bottom margin, paper size, and so on) as properties.
    /// </summary>
    public class PageSetup : LinkElement, IModel
    {
        /// <summary>
        /// Gets or sets the option that controls which pages the page border is printed on.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BorderAppliesToEnum
        {
            /// <summary>
            /// Enum value "AllPages"
            /// </summary>
            AllPages,

            /// <summary>
            /// Enum value "FirstPage"
            /// </summary>
            FirstPage,

            /// <summary>
            /// Enum value "OtherPages"
            /// </summary>
            OtherPages,
        }

        /// <summary>
        /// Gets or sets the value, that indicates whether the specified page border is measured from the edge of the page or from the text it surrounds.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BorderDistanceFromEnum
        {
            /// <summary>
            /// Enum value "Text"
            /// </summary>
            Text,

            /// <summary>
            /// Enum value "PageEdge"
            /// </summary>
            PageEdge,
        }

        /// <summary>
        /// Gets or sets the way line numbering runs  that is, whether it starts over at the beginning of a new page or section or runs continuously.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LineNumberRestartModeEnum
        {
            /// <summary>
            /// Enum value "RestartPage"
            /// </summary>
            RestartPage,

            /// <summary>
            /// Enum value "RestartSection"
            /// </summary>
            RestartSection,

            /// <summary>
            /// Enum value "Continuous"
            /// </summary>
            Continuous,
        }

        /// <summary>
        /// Gets or sets the orientation of the page.
        /// Changing Orientation swaps PageWidth and PageHeight.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrientationEnum
        {
            /// <summary>
            /// Enum value "Portrait"
            /// </summary>
            Portrait,

            /// <summary>
            /// Enum value "Landscape"
            /// </summary>
            Landscape,
        }

        /// <summary>
        /// Gets or sets the page number format.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PageNumberStyleEnum
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
        /// Gets or sets the paper size.
        /// Setting this property updates PageWidth and PageHeight values. Setting this value to Custom does not change existing values.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaperSizeEnum
        {
            /// <summary>
            /// Enum value "A3"
            /// </summary>
            A3,

            /// <summary>
            /// Enum value "A4"
            /// </summary>
            A4,

            /// <summary>
            /// Enum value "A5"
            /// </summary>
            A5,

            /// <summary>
            /// Enum value "B4"
            /// </summary>
            B4,

            /// <summary>
            /// Enum value "B5"
            /// </summary>
            B5,

            /// <summary>
            /// Enum value "Executive"
            /// </summary>
            Executive,

            /// <summary>
            /// Enum value "Folio"
            /// </summary>
            Folio,

            /// <summary>
            /// Enum value "Ledger"
            /// </summary>
            Ledger,

            /// <summary>
            /// Enum value "Legal"
            /// </summary>
            Legal,

            /// <summary>
            /// Enum value "Letter"
            /// </summary>
            Letter,

            /// <summary>
            /// Enum value "EnvelopeDL"
            /// </summary>
            EnvelopeDL,

            /// <summary>
            /// Enum value "Quarto"
            /// </summary>
            Quarto,

            /// <summary>
            /// Enum value "Statement"
            /// </summary>
            Statement,

            /// <summary>
            /// Enum value "Tabloid"
            /// </summary>
            Tabloid,

            /// <summary>
            /// Enum value "Paper10x14"
            /// </summary>
            Paper10x14,

            /// <summary>
            /// Enum value "Paper11x17"
            /// </summary>
            Paper11x17,

            /// <summary>
            /// Enum value "Number10Envelope"
            /// </summary>
            Number10Envelope,

            /// <summary>
            /// Enum value "Custom"
            /// </summary>
            Custom,
        }

        /// <summary>
        /// Gets or sets the type of section break for the specified object.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SectionStartEnum
        {
            /// <summary>
            /// Enum value "Continuous"
            /// </summary>
            Continuous,

            /// <summary>
            /// Enum value "NewColumn"
            /// </summary>
            NewColumn,

            /// <summary>
            /// Enum value "NewPage"
            /// </summary>
            NewPage,

            /// <summary>
            /// Enum value "EvenPage"
            /// </summary>
            EvenPage,

            /// <summary>
            /// Enum value "OddPage"
            /// </summary>
            OddPage,
        }

        /// <summary>
        /// Gets or sets the vertical alignment of text on each page in the document.or section.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VerticalAlignmentEnum
        {
            /// <summary>
            /// Enum value "Top"
            /// </summary>
            Top,

            /// <summary>
            /// Enum value "Center"
            /// </summary>
            Center,

            /// <summary>
            /// Enum value "Justify"
            /// </summary>
            Justify,

            /// <summary>
            /// Enum value "Bottom"
            /// </summary>
            Bottom,
        }

        /// <summary>
        /// Gets or sets a value indicating whether this section contains bidirectional (complex scripts) text.
        /// When true, the columns in this section are laid out from right to left.
        /// </summary>
        public virtual bool? Bidi { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the page border is positioned relative to intersecting texts and objects.
        /// </summary>
        public virtual bool? BorderAlwaysInFront { get; set; }

        /// <summary>
        /// Gets or sets the option that controls which pages the page border is printed on.
        /// </summary>
        public virtual BorderAppliesToEnum? BorderAppliesTo { get; set; }

        /// <summary>
        /// Gets or sets the value, that indicates whether the specified page border is measured from the edge of the page or from the text it surrounds.
        /// </summary>
        public virtual BorderDistanceFromEnum? BorderDistanceFrom { get; set; }

        /// <summary>
        /// Gets or sets the distance (in points) between the bottom edge of the page and the bottom boundary of the body text.
        /// </summary>
        public virtual double? BottomMargin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a different header or footer is used on the first page.
        /// </summary>
        public virtual bool? DifferentFirstPageHeaderFooter { get; set; }

        /// <summary>
        /// Gets or sets the paper tray (bin) to use for the first page of a section.
        /// The value is implementation (printer) specific.
        /// </summary>
        public virtual int? FirstPageTray { get; set; }

        /// <summary>
        /// Gets or sets the distance (in points) between the footer and the bottom of the page.
        /// </summary>
        public virtual double? FooterDistance { get; set; }

        /// <summary>
        /// Gets or sets the amount of extra space added to the margin for document binding.
        /// </summary>
        public virtual double? Gutter { get; set; }

        /// <summary>
        /// Gets or sets the distance (in points) between the header and the top of the page.
        /// </summary>
        public virtual double? HeaderDistance { get; set; }

        /// <summary>
        /// Gets or sets the distance (in points) between the left edge of the page and the left boundary of the body text.
        /// </summary>
        public virtual double? LeftMargin { get; set; }

        /// <summary>
        /// Gets or sets the numeric increment for line numbers.
        /// </summary>
        public virtual int? LineNumberCountBy { get; set; }

        /// <summary>
        /// Gets or sets the distance between the right edge of line numbers and the left edge of the document.
        /// Set this property to zero for automatic distance between the line numbers and text of the document.
        /// </summary>
        public virtual double? LineNumberDistanceFromText { get; set; }

        /// <summary>
        /// Gets or sets the way line numbering runs  that is, whether it starts over at the beginning of a new page or section or runs continuously.
        /// </summary>
        public virtual LineNumberRestartModeEnum? LineNumberRestartMode { get; set; }

        /// <summary>
        /// Gets or sets the starting line number.
        /// </summary>
        public virtual int? LineStartingNumber { get; set; }

        /// <summary>
        /// Gets or sets the orientation of the page.
        /// Changing Orientation swaps PageWidth and PageHeight.
        /// </summary>
        public virtual OrientationEnum? Orientation { get; set; }

        /// <summary>
        /// Gets or sets the paper tray (bin) to be used for all but the first page of a section.
        /// The value is implementation (printer) specific.
        /// </summary>
        public virtual int? OtherPagesTray { get; set; }

        /// <summary>
        /// Gets or sets the height of the page in points.
        /// </summary>
        public virtual double? PageHeight { get; set; }

        /// <summary>
        /// Gets or sets the page number format.
        /// </summary>
        public virtual PageNumberStyleEnum? PageNumberStyle { get; set; }

        /// <summary>
        /// Gets or sets the starting page number of the section.
        /// The RestartPageNumbering property, if set to false, will override the PageStartingNumber property so that page numbering can continue from the previous section.
        /// </summary>
        public virtual int? PageStartingNumber { get; set; }

        /// <summary>
        /// Gets or sets the width of the page in points.
        /// </summary>
        public virtual double? PageWidth { get; set; }

        /// <summary>
        /// Gets or sets the paper size.
        /// Setting this property updates PageWidth and PageHeight values. Setting this value to Custom does not change existing values.
        /// </summary>
        public virtual PaperSizeEnum? PaperSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether page numbering restarts at the beginning of the section.
        /// If set to false, the RestartPageNumbering property will override the PageStartingNumber property so that page numbering can continue from the previous section.
        /// </summary>
        public virtual bool? RestartPageNumbering { get; set; }

        /// <summary>
        /// Gets or sets the distance (in points) between the right edge of the page and the right boundary of the body text.
        /// </summary>
        public virtual double? RightMargin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Microsoft Word uses gutters for the section based on a right-to-left language or a left-to-right language.
        /// </summary>
        public virtual bool? RtlGutter { get; set; }

        /// <summary>
        /// Gets or sets the type of section break for the specified object.
        /// </summary>
        public virtual SectionStartEnum? SectionStart { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether endnotes are printed at the end of the next section that doesn't suppress endnotes. Suppressed endnotes are printed before the endnotes in that section.
        /// </summary>
        public virtual bool? SuppressEndnotes { get; set; }

        /// <summary>
        /// Gets or sets the distance (in points) between the top edge of the page and the top boundary of the body text.
        /// </summary>
        public virtual double? TopMargin { get; set; }

        /// <summary>
        /// Gets or sets the vertical alignment of text on each page in the document.or section.
        /// </summary>
        public virtual VerticalAlignmentEnum? VerticalAlignment { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageSetup {\n");
            sb.Append("  Link: ").Append(this.Link).Append("\n");
            sb.Append("  Bidi: ").Append(this.Bidi).Append("\n");
            sb.Append("  BorderAlwaysInFront: ").Append(this.BorderAlwaysInFront).Append("\n");
            sb.Append("  BorderAppliesTo: ").Append(this.BorderAppliesTo).Append("\n");
            sb.Append("  BorderDistanceFrom: ").Append(this.BorderDistanceFrom).Append("\n");
            sb.Append("  BottomMargin: ").Append(this.BottomMargin).Append("\n");
            sb.Append("  DifferentFirstPageHeaderFooter: ").Append(this.DifferentFirstPageHeaderFooter).Append("\n");
            sb.Append("  FirstPageTray: ").Append(this.FirstPageTray).Append("\n");
            sb.Append("  FooterDistance: ").Append(this.FooterDistance).Append("\n");
            sb.Append("  Gutter: ").Append(this.Gutter).Append("\n");
            sb.Append("  HeaderDistance: ").Append(this.HeaderDistance).Append("\n");
            sb.Append("  LeftMargin: ").Append(this.LeftMargin).Append("\n");
            sb.Append("  LineNumberCountBy: ").Append(this.LineNumberCountBy).Append("\n");
            sb.Append("  LineNumberDistanceFromText: ").Append(this.LineNumberDistanceFromText).Append("\n");
            sb.Append("  LineNumberRestartMode: ").Append(this.LineNumberRestartMode).Append("\n");
            sb.Append("  LineStartingNumber: ").Append(this.LineStartingNumber).Append("\n");
            sb.Append("  Orientation: ").Append(this.Orientation).Append("\n");
            sb.Append("  OtherPagesTray: ").Append(this.OtherPagesTray).Append("\n");
            sb.Append("  PageHeight: ").Append(this.PageHeight).Append("\n");
            sb.Append("  PageNumberStyle: ").Append(this.PageNumberStyle).Append("\n");
            sb.Append("  PageStartingNumber: ").Append(this.PageStartingNumber).Append("\n");
            sb.Append("  PageWidth: ").Append(this.PageWidth).Append("\n");
            sb.Append("  PaperSize: ").Append(this.PaperSize).Append("\n");
            sb.Append("  RestartPageNumbering: ").Append(this.RestartPageNumbering).Append("\n");
            sb.Append("  RightMargin: ").Append(this.RightMargin).Append("\n");
            sb.Append("  RtlGutter: ").Append(this.RtlGutter).Append("\n");
            sb.Append("  SectionStart: ").Append(this.SectionStart).Append("\n");
            sb.Append("  SuppressEndnotes: ").Append(this.SuppressEndnotes).Append("\n");
            sb.Append("  TopMargin: ").Append(this.TopMargin).Append("\n");
            sb.Append("  VerticalAlignment: ").Append(this.VerticalAlignment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
