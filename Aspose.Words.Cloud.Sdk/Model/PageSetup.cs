// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PageSetup.cs">
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
  /// Represents the page setup properties of a section.             
  /// </summary>  
  public class PageSetup : LinkElement 
  {                       
        /// <summary>
        /// Gets or sets specifies which pages the page border is printed on.             
        /// </summary>
        /// <value>Gets or sets specifies which pages the page border is printed on.             </value>
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
            OtherPages            
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the specified page border is measured from the edge of the page or from the text it surrounds.             
        /// </summary>
        /// <value>Gets or sets a value that indicates whether the specified page border is measured from the edge of the page or from the text it surrounds.             </value>
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
            PageEdge            
        }

        /// <summary>
        /// Gets or sets the way line numbering runs  that is, whether it starts over at the beginning of a new page or section or runs continuously.             
        /// </summary>
        /// <value>Gets or sets the way line numbering runs  that is, whether it starts over at the beginning of a new page or section or runs continuously.             </value>
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
            Continuous            
        }

        /// <summary>
        /// Gets or sets returns or sets the orientation of the page.             
        /// </summary>
        /// <value>Gets or sets returns or sets the orientation of the page.             </value>
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
            Landscape            
        }

        /// <summary>
        /// Gets or sets the page number format.             
        /// </summary>
        /// <value>Gets or sets the page number format.             </value>
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
            Custom            
        }

        /// <summary>
        /// Gets or sets returns or sets the paper size.             
        /// </summary>
        /// <value>Gets or sets returns or sets the paper size.             </value>
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
            /// Enum value "Custom"
            /// </summary>
            Custom            
        }

        /// <summary>
        /// Gets or sets returns or sets the type of section break for the specified object.             
        /// </summary>
        /// <value>Gets or sets returns or sets the type of section break for the specified object.             </value>
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
            OddPage            
        }

        /// <summary>
        /// Gets or sets returns or sets the vertical alignment of text on each page in a document or section.             
        /// </summary>
        /// <value>Gets or sets returns or sets the vertical alignment of text on each page in a document or section.             </value>
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
            Bottom            
        }

        /// <summary>
        /// Gets or sets specifies which pages the page border is printed on.             
        /// </summary>
        public BorderAppliesToEnum? BorderAppliesTo { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether the specified page border is measured from the edge of the page or from the text it surrounds.             
        /// </summary>
        public BorderDistanceFromEnum? BorderDistanceFrom { get; set; }

        /// <summary>
        /// Gets or sets the way line numbering runs  that is, whether it starts over at the beginning of a new page or section or runs continuously.             
        /// </summary>
        public LineNumberRestartModeEnum? LineNumberRestartMode { get; set; }

        /// <summary>
        /// Gets or sets returns or sets the orientation of the page.             
        /// </summary>
        public OrientationEnum? Orientation { get; set; }

        /// <summary>
        /// Gets or sets the page number format.             
        /// </summary>
        public PageNumberStyleEnum? PageNumberStyle { get; set; }

        /// <summary>
        /// Gets or sets returns or sets the paper size.             
        /// </summary>
        public PaperSizeEnum? PaperSize { get; set; }

        /// <summary>
        /// Gets or sets returns or sets the type of section break for the specified object.             
        /// </summary>
        public SectionStartEnum? SectionStart { get; set; }

        /// <summary>
        /// Gets or sets returns or sets the vertical alignment of text on each page in a document or section.             
        /// </summary>
        public VerticalAlignmentEnum? VerticalAlignment { get; set; }

        /// <summary>
        /// Gets or sets specifies that this section contains bidirectional (complex scripts) text.             
        /// </summary>  
        public bool? Bidi { get; set; }

        /// <summary>
        /// Gets or sets specifies where the page border is positioned relative to intersecting texts and objects.             
        /// </summary>  
        public bool? BorderAlwaysInFront { get; set; }

        /// <summary>
        /// Gets or sets returns or sets the distance (in points) between the bottom edge of the page and the bottom boundary of the body text.             
        /// </summary>  
        public double? BottomMargin { get; set; }

        /// <summary>
        /// Gets or sets true if a different header or footer is used on the first page.             
        /// </summary>  
        public bool? DifferentFirstPageHeaderFooter { get; set; }

        /// <summary>
        /// Gets or sets the paper tray (bin) to use for the first page of a section. The value is implementation (printer) specific.             
        /// </summary>  
        public int? FirstPageTray { get; set; }

        /// <summary>
        /// Gets or sets returns or sets the distance (in points) between the footer and the bottom of the page.             
        /// </summary>  
        public double? FooterDistance { get; set; }

        /// <summary>
        /// Gets or sets the amount of extra space added to the margin for document binding.             
        /// </summary>  
        public double? Gutter { get; set; }

        /// <summary>
        /// Gets or sets returns or sets the distance (in points) between the header and the top of the page.             
        /// </summary>  
        public double? HeaderDistance { get; set; }

        /// <summary>
        /// Gets or sets returns or sets the distance (in points) between the left edge of the page and the left boundary of the body text.             
        /// </summary>  
        public double? LeftMargin { get; set; }

        /// <summary>
        /// Gets or sets returns or sets the numeric increment for line numbers.             
        /// </summary>  
        public int? LineNumberCountBy { get; set; }

        /// <summary>
        /// Gets or sets distance between the right edge of line numbers and the left edge of the document.             
        /// </summary>  
        public double? LineNumberDistanceFromText { get; set; }

        /// <summary>
        /// Gets or sets the starting line number.             
        /// </summary>  
        public int? LineStartingNumber { get; set; }

        /// <summary>
        /// Gets or sets the paper tray (bin) to be used for all but the first page of a section. The value is implementation (printer) specific.             
        /// </summary>  
        public int? OtherPagesTray { get; set; }

        /// <summary>
        /// Gets or sets returns or sets the height of the page in points.             
        /// </summary>  
        public double? PageHeight { get; set; }

        /// <summary>
        /// Gets or sets the starting page number of the section.             
        /// </summary>  
        public int? PageStartingNumber { get; set; }

        /// <summary>
        /// Gets or sets returns or sets the width of the page in points.             
        /// </summary>  
        public double? PageWidth { get; set; }

        /// <summary>
        /// Gets or sets true if page numbering restarts at the beginning of the section.             
        /// </summary>  
        public bool? RestartPageNumbering { get; set; }

        /// <summary>
        /// Gets or sets returns or sets the distance (in points) between the right edge of the page and the right boundary of the body text.             
        /// </summary>  
        public double? RightMargin { get; set; }

        /// <summary>
        /// Gets or sets whether Microsoft Word uses gutters for the section based on a right-to-left language or a left-to-right language.             
        /// </summary>  
        public bool? RtlGutter { get; set; }

        /// <summary>
        /// Gets or sets true if endnotes are printed at the end of the next section that doesn't suppress endnotes.                 Suppressed endnotes are printed before the endnotes in that section.             
        /// </summary>  
        public bool? SuppressEndnotes { get; set; }

        /// <summary>
        /// Gets or sets returns or sets the distance (in points) between the top edge of the page and the top boundary of the body text.             
        /// </summary>  
        public double? TopMargin { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PageSetup {\n");
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
