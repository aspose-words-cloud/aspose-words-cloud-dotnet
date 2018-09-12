// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PageSetup.cs">
//   Copyright (c) 2018 Aspose.Words for Cloud
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
  /// 
  /// </summary>  
  public class PageSetup : LinkElement 
  {                       
        /// <summary>
        /// Gets or sets BorderAppliesTo
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BorderAppliesToEnum
        { 
            /// <summary>
            /// Enum AllPages for "AllPages"
            /// </summary>            
            AllPages,
            
            /// <summary>
            /// Enum FirstPage for "FirstPage"
            /// </summary>            
            FirstPage,
            
            /// <summary>
            /// Enum OtherPages for "OtherPages"
            /// </summary>            
            OtherPages            
        }

        /// <summary>
        /// Gets or sets BorderDistanceFrom
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BorderDistanceFromEnum
        { 
            /// <summary>
            /// Enum Text for "Text"
            /// </summary>            
            Text,
            
            /// <summary>
            /// Enum PageEdge for "PageEdge"
            /// </summary>            
            PageEdge            
        }

        /// <summary>
        /// Gets or sets LineNumberRestartMode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LineNumberRestartModeEnum
        { 
            /// <summary>
            /// Enum RestartPage for "RestartPage"
            /// </summary>            
            RestartPage,
            
            /// <summary>
            /// Enum RestartSection for "RestartSection"
            /// </summary>            
            RestartSection,
            
            /// <summary>
            /// Enum Continuous for "Continuous"
            /// </summary>            
            Continuous            
        }

        /// <summary>
        /// Gets or sets Orientation
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrientationEnum
        { 
            /// <summary>
            /// Enum Portrait for "Portrait"
            /// </summary>            
            Portrait,
            
            /// <summary>
            /// Enum Landscape for "Landscape"
            /// </summary>            
            Landscape            
        }

        /// <summary>
        /// Gets or sets PageNumberStyle
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PageNumberStyleEnum
        { 
            /// <summary>
            /// Enum Arabic for "Arabic"
            /// </summary>            
            Arabic,
            
            /// <summary>
            /// Enum UppercaseRoman for "UppercaseRoman"
            /// </summary>            
            UppercaseRoman,
            
            /// <summary>
            /// Enum LowercaseRoman for "LowercaseRoman"
            /// </summary>            
            LowercaseRoman,
            
            /// <summary>
            /// Enum UppercaseLetter for "UppercaseLetter"
            /// </summary>            
            UppercaseLetter,
            
            /// <summary>
            /// Enum LowercaseLetter for "LowercaseLetter"
            /// </summary>            
            LowercaseLetter,
            
            /// <summary>
            /// Enum Ordinal for "Ordinal"
            /// </summary>            
            Ordinal,
            
            /// <summary>
            /// Enum Number for "Number"
            /// </summary>            
            Number,
            
            /// <summary>
            /// Enum OrdinalText for "OrdinalText"
            /// </summary>            
            OrdinalText,
            
            /// <summary>
            /// Enum Hex for "Hex"
            /// </summary>            
            Hex,
            
            /// <summary>
            /// Enum ChicagoManual for "ChicagoManual"
            /// </summary>            
            ChicagoManual,
            
            /// <summary>
            /// Enum Kanji for "Kanji"
            /// </summary>            
            Kanji,
            
            /// <summary>
            /// Enum KanjiDigit for "KanjiDigit"
            /// </summary>            
            KanjiDigit,
            
            /// <summary>
            /// Enum AiueoHalfWidth for "AiueoHalfWidth"
            /// </summary>            
            AiueoHalfWidth,
            
            /// <summary>
            /// Enum IrohaHalfWidth for "IrohaHalfWidth"
            /// </summary>            
            IrohaHalfWidth,
            
            /// <summary>
            /// Enum ArabicFullWidth for "ArabicFullWidth"
            /// </summary>            
            ArabicFullWidth,
            
            /// <summary>
            /// Enum ArabicHalfWidth for "ArabicHalfWidth"
            /// </summary>            
            ArabicHalfWidth,
            
            /// <summary>
            /// Enum KanjiTraditional for "KanjiTraditional"
            /// </summary>            
            KanjiTraditional,
            
            /// <summary>
            /// Enum KanjiTraditional2 for "KanjiTraditional2"
            /// </summary>            
            KanjiTraditional2,
            
            /// <summary>
            /// Enum NumberInCircle for "NumberInCircle"
            /// </summary>            
            NumberInCircle,
            
            /// <summary>
            /// Enum DecimalFullWidth for "DecimalFullWidth"
            /// </summary>            
            DecimalFullWidth,
            
            /// <summary>
            /// Enum Aiueo for "Aiueo"
            /// </summary>            
            Aiueo,
            
            /// <summary>
            /// Enum Iroha for "Iroha"
            /// </summary>            
            Iroha,
            
            /// <summary>
            /// Enum LeadingZero for "LeadingZero"
            /// </summary>            
            LeadingZero,
            
            /// <summary>
            /// Enum Bullet for "Bullet"
            /// </summary>            
            Bullet,
            
            /// <summary>
            /// Enum Ganada for "Ganada"
            /// </summary>            
            Ganada,
            
            /// <summary>
            /// Enum Chosung for "Chosung"
            /// </summary>            
            Chosung,
            
            /// <summary>
            /// Enum GB1 for "GB1"
            /// </summary>            
            GB1,
            
            /// <summary>
            /// Enum GB2 for "GB2"
            /// </summary>            
            GB2,
            
            /// <summary>
            /// Enum GB3 for "GB3"
            /// </summary>            
            GB3,
            
            /// <summary>
            /// Enum GB4 for "GB4"
            /// </summary>            
            GB4,
            
            /// <summary>
            /// Enum Zodiac1 for "Zodiac1"
            /// </summary>            
            Zodiac1,
            
            /// <summary>
            /// Enum Zodiac2 for "Zodiac2"
            /// </summary>            
            Zodiac2,
            
            /// <summary>
            /// Enum Zodiac3 for "Zodiac3"
            /// </summary>            
            Zodiac3,
            
            /// <summary>
            /// Enum TradChinNum1 for "TradChinNum1"
            /// </summary>            
            TradChinNum1,
            
            /// <summary>
            /// Enum TradChinNum2 for "TradChinNum2"
            /// </summary>            
            TradChinNum2,
            
            /// <summary>
            /// Enum TradChinNum3 for "TradChinNum3"
            /// </summary>            
            TradChinNum3,
            
            /// <summary>
            /// Enum TradChinNum4 for "TradChinNum4"
            /// </summary>            
            TradChinNum4,
            
            /// <summary>
            /// Enum SimpChinNum1 for "SimpChinNum1"
            /// </summary>            
            SimpChinNum1,
            
            /// <summary>
            /// Enum SimpChinNum2 for "SimpChinNum2"
            /// </summary>            
            SimpChinNum2,
            
            /// <summary>
            /// Enum SimpChinNum3 for "SimpChinNum3"
            /// </summary>            
            SimpChinNum3,
            
            /// <summary>
            /// Enum SimpChinNum4 for "SimpChinNum4"
            /// </summary>            
            SimpChinNum4,
            
            /// <summary>
            /// Enum HanjaRead for "HanjaRead"
            /// </summary>            
            HanjaRead,
            
            /// <summary>
            /// Enum HanjaReadDigit for "HanjaReadDigit"
            /// </summary>            
            HanjaReadDigit,
            
            /// <summary>
            /// Enum Hangul for "Hangul"
            /// </summary>            
            Hangul,
            
            /// <summary>
            /// Enum Hanja for "Hanja"
            /// </summary>            
            Hanja,
            
            /// <summary>
            /// Enum Hebrew1 for "Hebrew1"
            /// </summary>            
            Hebrew1,
            
            /// <summary>
            /// Enum Arabic1 for "Arabic1"
            /// </summary>            
            Arabic1,
            
            /// <summary>
            /// Enum Hebrew2 for "Hebrew2"
            /// </summary>            
            Hebrew2,
            
            /// <summary>
            /// Enum Arabic2 for "Arabic2"
            /// </summary>            
            Arabic2,
            
            /// <summary>
            /// Enum HindiLetter1 for "HindiLetter1"
            /// </summary>            
            HindiLetter1,
            
            /// <summary>
            /// Enum HindiLetter2 for "HindiLetter2"
            /// </summary>            
            HindiLetter2,
            
            /// <summary>
            /// Enum HindiArabic for "HindiArabic"
            /// </summary>            
            HindiArabic,
            
            /// <summary>
            /// Enum HindiCardinalText for "HindiCardinalText"
            /// </summary>            
            HindiCardinalText,
            
            /// <summary>
            /// Enum ThaiLetter for "ThaiLetter"
            /// </summary>            
            ThaiLetter,
            
            /// <summary>
            /// Enum ThaiArabic for "ThaiArabic"
            /// </summary>            
            ThaiArabic,
            
            /// <summary>
            /// Enum ThaiCardinalText for "ThaiCardinalText"
            /// </summary>            
            ThaiCardinalText,
            
            /// <summary>
            /// Enum VietCardinalText for "VietCardinalText"
            /// </summary>            
            VietCardinalText,
            
            /// <summary>
            /// Enum NumberInDash for "NumberInDash"
            /// </summary>            
            NumberInDash,
            
            /// <summary>
            /// Enum LowercaseRussian for "LowercaseRussian"
            /// </summary>            
            LowercaseRussian,
            
            /// <summary>
            /// Enum UppercaseRussian for "UppercaseRussian"
            /// </summary>            
            UppercaseRussian,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>            
            Custom            
        }

        /// <summary>
        /// Gets or sets PaperSize
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaperSizeEnum
        { 
            /// <summary>
            /// Enum A3 for "A3"
            /// </summary>            
            A3,
            
            /// <summary>
            /// Enum A4 for "A4"
            /// </summary>            
            A4,
            
            /// <summary>
            /// Enum A5 for "A5"
            /// </summary>            
            A5,
            
            /// <summary>
            /// Enum B4 for "B4"
            /// </summary>            
            B4,
            
            /// <summary>
            /// Enum B5 for "B5"
            /// </summary>            
            B5,
            
            /// <summary>
            /// Enum Executive for "Executive"
            /// </summary>            
            Executive,
            
            /// <summary>
            /// Enum Folio for "Folio"
            /// </summary>            
            Folio,
            
            /// <summary>
            /// Enum Ledger for "Ledger"
            /// </summary>            
            Ledger,
            
            /// <summary>
            /// Enum Legal for "Legal"
            /// </summary>            
            Legal,
            
            /// <summary>
            /// Enum Letter for "Letter"
            /// </summary>            
            Letter,
            
            /// <summary>
            /// Enum EnvelopeDL for "EnvelopeDL"
            /// </summary>            
            EnvelopeDL,
            
            /// <summary>
            /// Enum Quarto for "Quarto"
            /// </summary>            
            Quarto,
            
            /// <summary>
            /// Enum Statement for "Statement"
            /// </summary>            
            Statement,
            
            /// <summary>
            /// Enum Tabloid for "Tabloid"
            /// </summary>            
            Tabloid,
            
            /// <summary>
            /// Enum Paper10x14 for "Paper10x14"
            /// </summary>            
            Paper10x14,
            
            /// <summary>
            /// Enum Paper11x17 for "Paper11x17"
            /// </summary>            
            Paper11x17,
            
            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>            
            Custom            
        }

        /// <summary>
        /// Gets or sets SectionStart
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SectionStartEnum
        { 
            /// <summary>
            /// Enum Continuous for "Continuous"
            /// </summary>            
            Continuous,
            
            /// <summary>
            /// Enum NewColumn for "NewColumn"
            /// </summary>            
            NewColumn,
            
            /// <summary>
            /// Enum NewPage for "NewPage"
            /// </summary>            
            NewPage,
            
            /// <summary>
            /// Enum EvenPage for "EvenPage"
            /// </summary>            
            EvenPage,
            
            /// <summary>
            /// Enum OddPage for "OddPage"
            /// </summary>            
            OddPage            
        }

        /// <summary>
        /// Gets or sets VerticalAlignment
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VerticalAlignmentEnum
        { 
            /// <summary>
            /// Enum Top for "Top"
            /// </summary>            
            Top,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>            
            Center,
            
            /// <summary>
            /// Enum Justify for "Justify"
            /// </summary>            
            Justify,
            
            /// <summary>
            /// Enum Bottom for "Bottom"
            /// </summary>            
            Bottom            
        }

        /// <summary>
        /// Gets or sets BorderAppliesTo
        /// </summary>
        public BorderAppliesToEnum? BorderAppliesTo { get; set; }

        /// <summary>
        /// Gets or sets BorderDistanceFrom
        /// </summary>
        public BorderDistanceFromEnum? BorderDistanceFrom { get; set; }

        /// <summary>
        /// Gets or sets LineNumberRestartMode
        /// </summary>
        public LineNumberRestartModeEnum? LineNumberRestartMode { get; set; }

        /// <summary>
        /// Gets or sets Orientation
        /// </summary>
        public OrientationEnum? Orientation { get; set; }

        /// <summary>
        /// Gets or sets PageNumberStyle
        /// </summary>
        public PageNumberStyleEnum? PageNumberStyle { get; set; }

        /// <summary>
        /// Gets or sets PaperSize
        /// </summary>
        public PaperSizeEnum? PaperSize { get; set; }

        /// <summary>
        /// Gets or sets SectionStart
        /// </summary>
        public SectionStartEnum? SectionStart { get; set; }

        /// <summary>
        /// Gets or sets VerticalAlignment
        /// </summary>
        public VerticalAlignmentEnum? VerticalAlignment { get; set; }

        /// <summary>
        /// Gets or sets Bidi
        /// </summary>  
        public bool? Bidi { get; set; }

        /// <summary>
        /// Gets or sets BorderAlwaysInFront
        /// </summary>  
        public bool? BorderAlwaysInFront { get; set; }

        /// <summary>
        /// Gets or sets BottomMargin
        /// </summary>  
        public double? BottomMargin { get; set; }

        /// <summary>
        /// Gets or sets DifferentFirstPageHeaderFooter
        /// </summary>  
        public bool? DifferentFirstPageHeaderFooter { get; set; }

        /// <summary>
        /// Gets or sets FirstPageTray
        /// </summary>  
        public int? FirstPageTray { get; set; }

        /// <summary>
        /// Gets or sets FooterDistance
        /// </summary>  
        public double? FooterDistance { get; set; }

        /// <summary>
        /// Gets or sets Gutter
        /// </summary>  
        public double? Gutter { get; set; }

        /// <summary>
        /// Gets or sets HeaderDistance
        /// </summary>  
        public double? HeaderDistance { get; set; }

        /// <summary>
        /// Gets or sets LeftMargin
        /// </summary>  
        public double? LeftMargin { get; set; }

        /// <summary>
        /// Gets or sets LineNumberCountBy
        /// </summary>  
        public int? LineNumberCountBy { get; set; }

        /// <summary>
        /// Gets or sets LineNumberDistanceFromText
        /// </summary>  
        public double? LineNumberDistanceFromText { get; set; }

        /// <summary>
        /// Gets or sets LineStartingNumber
        /// </summary>  
        public int? LineStartingNumber { get; set; }

        /// <summary>
        /// Gets or sets OtherPagesTray
        /// </summary>  
        public int? OtherPagesTray { get; set; }

        /// <summary>
        /// Gets or sets PageHeight
        /// </summary>  
        public double? PageHeight { get; set; }

        /// <summary>
        /// Gets or sets PageStartingNumber
        /// </summary>  
        public int? PageStartingNumber { get; set; }

        /// <summary>
        /// Gets or sets PageWidth
        /// </summary>  
        public double? PageWidth { get; set; }

        /// <summary>
        /// Gets or sets RestartPageNumbering
        /// </summary>  
        public bool? RestartPageNumbering { get; set; }

        /// <summary>
        /// Gets or sets RightMargin
        /// </summary>  
        public double? RightMargin { get; set; }

        /// <summary>
        /// Gets or sets RtlGutter
        /// </summary>  
        public bool? RtlGutter { get; set; }

        /// <summary>
        /// Gets or sets SuppressEndnotes
        /// </summary>  
        public bool? SuppressEndnotes { get; set; }

        /// <summary>
        /// Gets or sets TopMargin
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
