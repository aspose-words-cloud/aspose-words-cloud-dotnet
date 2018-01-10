// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TableProperties.cs">
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
  /// Represents the table properties.             
  /// </summary>  
  public class TableProperties : LinkElement 
  {                       
        /// <summary>
        /// Specifies how an inline table is aligned in the document.
        /// </summary>
        /// <value>Specifies how an inline table is aligned in the document.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlignmentEnum
        { 
            /// <summary>
            /// Enum Left for "Left"
            /// </summary>            
            Left,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>            
            Center,
            
            /// <summary>
            /// Enum Right for "Right"
            /// </summary>            
            Right            
        }

        /// <summary>
        /// Gets or sets the locale independent style identifier of the table style applied to this table.
        /// </summary>
        /// <value>Gets or sets the locale independent style identifier of the table style applied to this table.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StyleIdentifierEnum
        { 
            /// <summary>
            /// Enum Normal for "Normal"
            /// </summary>            
            Normal,
            
            /// <summary>
            /// Enum Heading1 for "Heading1"
            /// </summary>            
            Heading1,
            
            /// <summary>
            /// Enum Heading2 for "Heading2"
            /// </summary>            
            Heading2,
            
            /// <summary>
            /// Enum Heading3 for "Heading3"
            /// </summary>            
            Heading3,
            
            /// <summary>
            /// Enum Heading4 for "Heading4"
            /// </summary>            
            Heading4,
            
            /// <summary>
            /// Enum Heading5 for "Heading5"
            /// </summary>            
            Heading5,
            
            /// <summary>
            /// Enum Heading6 for "Heading6"
            /// </summary>            
            Heading6,
            
            /// <summary>
            /// Enum Heading7 for "Heading7"
            /// </summary>            
            Heading7,
            
            /// <summary>
            /// Enum Heading8 for "Heading8"
            /// </summary>            
            Heading8,
            
            /// <summary>
            /// Enum Heading9 for "Heading9"
            /// </summary>            
            Heading9,
            
            /// <summary>
            /// Enum Index1 for "Index1"
            /// </summary>            
            Index1,
            
            /// <summary>
            /// Enum Index2 for "Index2"
            /// </summary>            
            Index2,
            
            /// <summary>
            /// Enum Index3 for "Index3"
            /// </summary>            
            Index3,
            
            /// <summary>
            /// Enum Index4 for "Index4"
            /// </summary>            
            Index4,
            
            /// <summary>
            /// Enum Index5 for "Index5"
            /// </summary>            
            Index5,
            
            /// <summary>
            /// Enum Index6 for "Index6"
            /// </summary>            
            Index6,
            
            /// <summary>
            /// Enum Index7 for "Index7"
            /// </summary>            
            Index7,
            
            /// <summary>
            /// Enum Index8 for "Index8"
            /// </summary>            
            Index8,
            
            /// <summary>
            /// Enum Index9 for "Index9"
            /// </summary>            
            Index9,
            
            /// <summary>
            /// Enum Toc1 for "Toc1"
            /// </summary>            
            Toc1,
            
            /// <summary>
            /// Enum Toc2 for "Toc2"
            /// </summary>            
            Toc2,
            
            /// <summary>
            /// Enum Toc3 for "Toc3"
            /// </summary>            
            Toc3,
            
            /// <summary>
            /// Enum Toc4 for "Toc4"
            /// </summary>            
            Toc4,
            
            /// <summary>
            /// Enum Toc5 for "Toc5"
            /// </summary>            
            Toc5,
            
            /// <summary>
            /// Enum Toc6 for "Toc6"
            /// </summary>            
            Toc6,
            
            /// <summary>
            /// Enum Toc7 for "Toc7"
            /// </summary>            
            Toc7,
            
            /// <summary>
            /// Enum Toc8 for "Toc8"
            /// </summary>            
            Toc8,
            
            /// <summary>
            /// Enum Toc9 for "Toc9"
            /// </summary>            
            Toc9,
            
            /// <summary>
            /// Enum NormalIndent for "NormalIndent"
            /// </summary>            
            NormalIndent,
            
            /// <summary>
            /// Enum FootnoteText for "FootnoteText"
            /// </summary>            
            FootnoteText,
            
            /// <summary>
            /// Enum CommentText for "CommentText"
            /// </summary>            
            CommentText,
            
            /// <summary>
            /// Enum Header for "Header"
            /// </summary>            
            Header,
            
            /// <summary>
            /// Enum Footer for "Footer"
            /// </summary>            
            Footer,
            
            /// <summary>
            /// Enum IndexHeading for "IndexHeading"
            /// </summary>            
            IndexHeading,
            
            /// <summary>
            /// Enum Caption for "Caption"
            /// </summary>            
            Caption,
            
            /// <summary>
            /// Enum TableOfFigures for "TableOfFigures"
            /// </summary>            
            TableOfFigures,
            
            /// <summary>
            /// Enum EnvelopeAddress for "EnvelopeAddress"
            /// </summary>            
            EnvelopeAddress,
            
            /// <summary>
            /// Enum EnvelopeReturn for "EnvelopeReturn"
            /// </summary>            
            EnvelopeReturn,
            
            /// <summary>
            /// Enum FootnoteReference for "FootnoteReference"
            /// </summary>            
            FootnoteReference,
            
            /// <summary>
            /// Enum CommentReference for "CommentReference"
            /// </summary>            
            CommentReference,
            
            /// <summary>
            /// Enum LineNumber for "LineNumber"
            /// </summary>            
            LineNumber,
            
            /// <summary>
            /// Enum PageNumber for "PageNumber"
            /// </summary>            
            PageNumber,
            
            /// <summary>
            /// Enum EndnoteReference for "EndnoteReference"
            /// </summary>            
            EndnoteReference,
            
            /// <summary>
            /// Enum EndnoteText for "EndnoteText"
            /// </summary>            
            EndnoteText,
            
            /// <summary>
            /// Enum TableOfAuthorities for "TableOfAuthorities"
            /// </summary>            
            TableOfAuthorities,
            
            /// <summary>
            /// Enum Macro for "Macro"
            /// </summary>            
            Macro,
            
            /// <summary>
            /// Enum ToaHeading for "ToaHeading"
            /// </summary>            
            ToaHeading,
            
            /// <summary>
            /// Enum List for "List"
            /// </summary>            
            List,
            
            /// <summary>
            /// Enum ListBullet for "ListBullet"
            /// </summary>            
            ListBullet,
            
            /// <summary>
            /// Enum ListNumber for "ListNumber"
            /// </summary>            
            ListNumber,
            
            /// <summary>
            /// Enum List2 for "List2"
            /// </summary>            
            List2,
            
            /// <summary>
            /// Enum List3 for "List3"
            /// </summary>            
            List3,
            
            /// <summary>
            /// Enum List4 for "List4"
            /// </summary>            
            List4,
            
            /// <summary>
            /// Enum List5 for "List5"
            /// </summary>            
            List5,
            
            /// <summary>
            /// Enum ListBullet2 for "ListBullet2"
            /// </summary>            
            ListBullet2,
            
            /// <summary>
            /// Enum ListBullet3 for "ListBullet3"
            /// </summary>            
            ListBullet3,
            
            /// <summary>
            /// Enum ListBullet4 for "ListBullet4"
            /// </summary>            
            ListBullet4,
            
            /// <summary>
            /// Enum ListBullet5 for "ListBullet5"
            /// </summary>            
            ListBullet5,
            
            /// <summary>
            /// Enum ListNumber2 for "ListNumber2"
            /// </summary>            
            ListNumber2,
            
            /// <summary>
            /// Enum ListNumber3 for "ListNumber3"
            /// </summary>            
            ListNumber3,
            
            /// <summary>
            /// Enum ListNumber4 for "ListNumber4"
            /// </summary>            
            ListNumber4,
            
            /// <summary>
            /// Enum ListNumber5 for "ListNumber5"
            /// </summary>            
            ListNumber5,
            
            /// <summary>
            /// Enum Title for "Title"
            /// </summary>            
            Title,
            
            /// <summary>
            /// Enum Closing for "Closing"
            /// </summary>            
            Closing,
            
            /// <summary>
            /// Enum Signature for "Signature"
            /// </summary>            
            Signature,
            
            /// <summary>
            /// Enum DefaultParagraphFont for "DefaultParagraphFont"
            /// </summary>            
            DefaultParagraphFont,
            
            /// <summary>
            /// Enum BodyText for "BodyText"
            /// </summary>            
            BodyText,
            
            /// <summary>
            /// Enum BodyTextInd for "BodyTextInd"
            /// </summary>            
            BodyTextInd,
            
            /// <summary>
            /// Enum ListContinue for "ListContinue"
            /// </summary>            
            ListContinue,
            
            /// <summary>
            /// Enum ListContinue2 for "ListContinue2"
            /// </summary>            
            ListContinue2,
            
            /// <summary>
            /// Enum ListContinue3 for "ListContinue3"
            /// </summary>            
            ListContinue3,
            
            /// <summary>
            /// Enum ListContinue4 for "ListContinue4"
            /// </summary>            
            ListContinue4,
            
            /// <summary>
            /// Enum ListContinue5 for "ListContinue5"
            /// </summary>            
            ListContinue5,
            
            /// <summary>
            /// Enum MessageHeader for "MessageHeader"
            /// </summary>            
            MessageHeader,
            
            /// <summary>
            /// Enum Subtitle for "Subtitle"
            /// </summary>            
            Subtitle,
            
            /// <summary>
            /// Enum Salutation for "Salutation"
            /// </summary>            
            Salutation,
            
            /// <summary>
            /// Enum Date for "Date"
            /// </summary>            
            Date,
            
            /// <summary>
            /// Enum BodyText1I for "BodyText1I"
            /// </summary>            
            BodyText1I,
            
            /// <summary>
            /// Enum BodyText1I2 for "BodyText1I2"
            /// </summary>            
            BodyText1I2,
            
            /// <summary>
            /// Enum NoteHeading for "NoteHeading"
            /// </summary>            
            NoteHeading,
            
            /// <summary>
            /// Enum BodyText2 for "BodyText2"
            /// </summary>            
            BodyText2,
            
            /// <summary>
            /// Enum BodyText3 for "BodyText3"
            /// </summary>            
            BodyText3,
            
            /// <summary>
            /// Enum BodyTextInd2 for "BodyTextInd2"
            /// </summary>            
            BodyTextInd2,
            
            /// <summary>
            /// Enum BodyTextInd3 for "BodyTextInd3"
            /// </summary>            
            BodyTextInd3,
            
            /// <summary>
            /// Enum BlockText for "BlockText"
            /// </summary>            
            BlockText,
            
            /// <summary>
            /// Enum Hyperlink for "Hyperlink"
            /// </summary>            
            Hyperlink,
            
            /// <summary>
            /// Enum FollowedHyperlink for "FollowedHyperlink"
            /// </summary>            
            FollowedHyperlink,
            
            /// <summary>
            /// Enum Strong for "Strong"
            /// </summary>            
            Strong,
            
            /// <summary>
            /// Enum Emphasis for "Emphasis"
            /// </summary>            
            Emphasis,
            
            /// <summary>
            /// Enum DocumentMap for "DocumentMap"
            /// </summary>            
            DocumentMap,
            
            /// <summary>
            /// Enum PlainText for "PlainText"
            /// </summary>            
            PlainText,
            
            /// <summary>
            /// Enum EmailSignature for "EmailSignature"
            /// </summary>            
            EmailSignature,
            
            /// <summary>
            /// Enum HtmlTopOfForm for "HtmlTopOfForm"
            /// </summary>            
            HtmlTopOfForm,
            
            /// <summary>
            /// Enum HtmlBottomOfForm for "HtmlBottomOfForm"
            /// </summary>            
            HtmlBottomOfForm,
            
            /// <summary>
            /// Enum NormalWeb for "NormalWeb"
            /// </summary>            
            NormalWeb,
            
            /// <summary>
            /// Enum HtmlAcronym for "HtmlAcronym"
            /// </summary>            
            HtmlAcronym,
            
            /// <summary>
            /// Enum HtmlAddress for "HtmlAddress"
            /// </summary>            
            HtmlAddress,
            
            /// <summary>
            /// Enum HtmlCite for "HtmlCite"
            /// </summary>            
            HtmlCite,
            
            /// <summary>
            /// Enum HtmlCode for "HtmlCode"
            /// </summary>            
            HtmlCode,
            
            /// <summary>
            /// Enum HtmlDefinition for "HtmlDefinition"
            /// </summary>            
            HtmlDefinition,
            
            /// <summary>
            /// Enum HtmlKeyboard for "HtmlKeyboard"
            /// </summary>            
            HtmlKeyboard,
            
            /// <summary>
            /// Enum HtmlPreformatted for "HtmlPreformatted"
            /// </summary>            
            HtmlPreformatted,
            
            /// <summary>
            /// Enum HtmlSample for "HtmlSample"
            /// </summary>            
            HtmlSample,
            
            /// <summary>
            /// Enum HtmlTypewriter for "HtmlTypewriter"
            /// </summary>            
            HtmlTypewriter,
            
            /// <summary>
            /// Enum HtmlVariable for "HtmlVariable"
            /// </summary>            
            HtmlVariable,
            
            /// <summary>
            /// Enum TableNormal for "TableNormal"
            /// </summary>            
            TableNormal,
            
            /// <summary>
            /// Enum CommentSubject for "CommentSubject"
            /// </summary>            
            CommentSubject,
            
            /// <summary>
            /// Enum NoList for "NoList"
            /// </summary>            
            NoList,
            
            /// <summary>
            /// Enum OutlineList1 for "OutlineList1"
            /// </summary>            
            OutlineList1,
            
            /// <summary>
            /// Enum OutlineList2 for "OutlineList2"
            /// </summary>            
            OutlineList2,
            
            /// <summary>
            /// Enum OutlineList3 for "OutlineList3"
            /// </summary>            
            OutlineList3,
            
            /// <summary>
            /// Enum TableSimple1 for "TableSimple1"
            /// </summary>            
            TableSimple1,
            
            /// <summary>
            /// Enum TableSimple2 for "TableSimple2"
            /// </summary>            
            TableSimple2,
            
            /// <summary>
            /// Enum TableSimple3 for "TableSimple3"
            /// </summary>            
            TableSimple3,
            
            /// <summary>
            /// Enum TableClassic1 for "TableClassic1"
            /// </summary>            
            TableClassic1,
            
            /// <summary>
            /// Enum TableClassic2 for "TableClassic2"
            /// </summary>            
            TableClassic2,
            
            /// <summary>
            /// Enum TableClassic3 for "TableClassic3"
            /// </summary>            
            TableClassic3,
            
            /// <summary>
            /// Enum TableClassic4 for "TableClassic4"
            /// </summary>            
            TableClassic4,
            
            /// <summary>
            /// Enum TableColorful1 for "TableColorful1"
            /// </summary>            
            TableColorful1,
            
            /// <summary>
            /// Enum TableColorful2 for "TableColorful2"
            /// </summary>            
            TableColorful2,
            
            /// <summary>
            /// Enum TableColorful3 for "TableColorful3"
            /// </summary>            
            TableColorful3,
            
            /// <summary>
            /// Enum TableColumns1 for "TableColumns1"
            /// </summary>            
            TableColumns1,
            
            /// <summary>
            /// Enum TableColumns2 for "TableColumns2"
            /// </summary>            
            TableColumns2,
            
            /// <summary>
            /// Enum TableColumns3 for "TableColumns3"
            /// </summary>            
            TableColumns3,
            
            /// <summary>
            /// Enum TableColumns4 for "TableColumns4"
            /// </summary>            
            TableColumns4,
            
            /// <summary>
            /// Enum TableColumns5 for "TableColumns5"
            /// </summary>            
            TableColumns5,
            
            /// <summary>
            /// Enum TableGrid1 for "TableGrid1"
            /// </summary>            
            TableGrid1,
            
            /// <summary>
            /// Enum TableGrid2 for "TableGrid2"
            /// </summary>            
            TableGrid2,
            
            /// <summary>
            /// Enum TableGrid3 for "TableGrid3"
            /// </summary>            
            TableGrid3,
            
            /// <summary>
            /// Enum TableGrid4 for "TableGrid4"
            /// </summary>            
            TableGrid4,
            
            /// <summary>
            /// Enum TableGrid5 for "TableGrid5"
            /// </summary>            
            TableGrid5,
            
            /// <summary>
            /// Enum TableGrid6 for "TableGrid6"
            /// </summary>            
            TableGrid6,
            
            /// <summary>
            /// Enum TableGrid7 for "TableGrid7"
            /// </summary>            
            TableGrid7,
            
            /// <summary>
            /// Enum TableGrid8 for "TableGrid8"
            /// </summary>            
            TableGrid8,
            
            /// <summary>
            /// Enum TableList1 for "TableList1"
            /// </summary>            
            TableList1,
            
            /// <summary>
            /// Enum TableList2 for "TableList2"
            /// </summary>            
            TableList2,
            
            /// <summary>
            /// Enum TableList3 for "TableList3"
            /// </summary>            
            TableList3,
            
            /// <summary>
            /// Enum TableList4 for "TableList4"
            /// </summary>            
            TableList4,
            
            /// <summary>
            /// Enum TableList5 for "TableList5"
            /// </summary>            
            TableList5,
            
            /// <summary>
            /// Enum TableList6 for "TableList6"
            /// </summary>            
            TableList6,
            
            /// <summary>
            /// Enum TableList7 for "TableList7"
            /// </summary>            
            TableList7,
            
            /// <summary>
            /// Enum TableList8 for "TableList8"
            /// </summary>            
            TableList8,
            
            /// <summary>
            /// Enum Table3DEffects1 for "Table3DEffects1"
            /// </summary>            
            Table3DEffects1,
            
            /// <summary>
            /// Enum Table3DEffects2 for "Table3DEffects2"
            /// </summary>            
            Table3DEffects2,
            
            /// <summary>
            /// Enum Table3DEffects3 for "Table3DEffects3"
            /// </summary>            
            Table3DEffects3,
            
            /// <summary>
            /// Enum TableContemporary for "TableContemporary"
            /// </summary>            
            TableContemporary,
            
            /// <summary>
            /// Enum TableElegant for "TableElegant"
            /// </summary>            
            TableElegant,
            
            /// <summary>
            /// Enum TableProfessional for "TableProfessional"
            /// </summary>            
            TableProfessional,
            
            /// <summary>
            /// Enum TableSubtle1 for "TableSubtle1"
            /// </summary>            
            TableSubtle1,
            
            /// <summary>
            /// Enum TableSubtle2 for "TableSubtle2"
            /// </summary>            
            TableSubtle2,
            
            /// <summary>
            /// Enum TableWeb1 for "TableWeb1"
            /// </summary>            
            TableWeb1,
            
            /// <summary>
            /// Enum TableWeb2 for "TableWeb2"
            /// </summary>            
            TableWeb2,
            
            /// <summary>
            /// Enum TableWeb3 for "TableWeb3"
            /// </summary>            
            TableWeb3,
            
            /// <summary>
            /// Enum BalloonText for "BalloonText"
            /// </summary>            
            BalloonText,
            
            /// <summary>
            /// Enum TableGrid for "TableGrid"
            /// </summary>            
            TableGrid,
            
            /// <summary>
            /// Enum TableTheme for "TableTheme"
            /// </summary>            
            TableTheme,
            
            /// <summary>
            /// Enum PlaceholderText for "PlaceholderText"
            /// </summary>            
            PlaceholderText,
            
            /// <summary>
            /// Enum NoSpacing for "NoSpacing"
            /// </summary>            
            NoSpacing,
            
            /// <summary>
            /// Enum LightShading for "LightShading"
            /// </summary>            
            LightShading,
            
            /// <summary>
            /// Enum LightList for "LightList"
            /// </summary>            
            LightList,
            
            /// <summary>
            /// Enum LightGrid for "LightGrid"
            /// </summary>            
            LightGrid,
            
            /// <summary>
            /// Enum MediumShading1 for "MediumShading1"
            /// </summary>            
            MediumShading1,
            
            /// <summary>
            /// Enum MediumShading2 for "MediumShading2"
            /// </summary>            
            MediumShading2,
            
            /// <summary>
            /// Enum MediumList1 for "MediumList1"
            /// </summary>            
            MediumList1,
            
            /// <summary>
            /// Enum MediumList2 for "MediumList2"
            /// </summary>            
            MediumList2,
            
            /// <summary>
            /// Enum MediumGrid1 for "MediumGrid1"
            /// </summary>            
            MediumGrid1,
            
            /// <summary>
            /// Enum MediumGrid2 for "MediumGrid2"
            /// </summary>            
            MediumGrid2,
            
            /// <summary>
            /// Enum MediumGrid3 for "MediumGrid3"
            /// </summary>            
            MediumGrid3,
            
            /// <summary>
            /// Enum DarkList for "DarkList"
            /// </summary>            
            DarkList,
            
            /// <summary>
            /// Enum ColorfulShading for "ColorfulShading"
            /// </summary>            
            ColorfulShading,
            
            /// <summary>
            /// Enum ColorfulList for "ColorfulList"
            /// </summary>            
            ColorfulList,
            
            /// <summary>
            /// Enum ColorfulGrid for "ColorfulGrid"
            /// </summary>            
            ColorfulGrid,
            
            /// <summary>
            /// Enum LightShadingAccent1 for "LightShadingAccent1"
            /// </summary>            
            LightShadingAccent1,
            
            /// <summary>
            /// Enum LightListAccent1 for "LightListAccent1"
            /// </summary>            
            LightListAccent1,
            
            /// <summary>
            /// Enum LightGridAccent1 for "LightGridAccent1"
            /// </summary>            
            LightGridAccent1,
            
            /// <summary>
            /// Enum MediumShading1Accent1 for "MediumShading1Accent1"
            /// </summary>            
            MediumShading1Accent1,
            
            /// <summary>
            /// Enum MediumShading2Accent1 for "MediumShading2Accent1"
            /// </summary>            
            MediumShading2Accent1,
            
            /// <summary>
            /// Enum MediumList1Accent1 for "MediumList1Accent1"
            /// </summary>            
            MediumList1Accent1,
            
            /// <summary>
            /// Enum Revision for "Revision"
            /// </summary>            
            Revision,
            
            /// <summary>
            /// Enum ListParagraph for "ListParagraph"
            /// </summary>            
            ListParagraph,
            
            /// <summary>
            /// Enum Quote for "Quote"
            /// </summary>            
            Quote,
            
            /// <summary>
            /// Enum IntenseQuote for "IntenseQuote"
            /// </summary>            
            IntenseQuote,
            
            /// <summary>
            /// Enum MediumList2Accent1 for "MediumList2Accent1"
            /// </summary>            
            MediumList2Accent1,
            
            /// <summary>
            /// Enum MediumGrid1Accent1 for "MediumGrid1Accent1"
            /// </summary>            
            MediumGrid1Accent1,
            
            /// <summary>
            /// Enum MediumGrid2Accent1 for "MediumGrid2Accent1"
            /// </summary>            
            MediumGrid2Accent1,
            
            /// <summary>
            /// Enum MediumGrid3Accent1 for "MediumGrid3Accent1"
            /// </summary>            
            MediumGrid3Accent1,
            
            /// <summary>
            /// Enum DarkListAccent1 for "DarkListAccent1"
            /// </summary>            
            DarkListAccent1,
            
            /// <summary>
            /// Enum ColorfulShadingAccent1 for "ColorfulShadingAccent1"
            /// </summary>            
            ColorfulShadingAccent1,
            
            /// <summary>
            /// Enum ColorfulListAccent1 for "ColorfulListAccent1"
            /// </summary>            
            ColorfulListAccent1,
            
            /// <summary>
            /// Enum ColorfulGridAccent1 for "ColorfulGridAccent1"
            /// </summary>            
            ColorfulGridAccent1,
            
            /// <summary>
            /// Enum LightShadingAccent2 for "LightShadingAccent2"
            /// </summary>            
            LightShadingAccent2,
            
            /// <summary>
            /// Enum LightListAccent2 for "LightListAccent2"
            /// </summary>            
            LightListAccent2,
            
            /// <summary>
            /// Enum LightGridAccent2 for "LightGridAccent2"
            /// </summary>            
            LightGridAccent2,
            
            /// <summary>
            /// Enum MediumShading1Accent2 for "MediumShading1Accent2"
            /// </summary>            
            MediumShading1Accent2,
            
            /// <summary>
            /// Enum MediumShading2Accent2 for "MediumShading2Accent2"
            /// </summary>            
            MediumShading2Accent2,
            
            /// <summary>
            /// Enum MediumList1Accent2 for "MediumList1Accent2"
            /// </summary>            
            MediumList1Accent2,
            
            /// <summary>
            /// Enum MediumList2Accent2 for "MediumList2Accent2"
            /// </summary>            
            MediumList2Accent2,
            
            /// <summary>
            /// Enum MediumGrid1Accent2 for "MediumGrid1Accent2"
            /// </summary>            
            MediumGrid1Accent2,
            
            /// <summary>
            /// Enum MediumGrid2Accent2 for "MediumGrid2Accent2"
            /// </summary>            
            MediumGrid2Accent2,
            
            /// <summary>
            /// Enum MediumGrid3Accent2 for "MediumGrid3Accent2"
            /// </summary>            
            MediumGrid3Accent2,
            
            /// <summary>
            /// Enum DarkListAccent2 for "DarkListAccent2"
            /// </summary>            
            DarkListAccent2,
            
            /// <summary>
            /// Enum ColorfulShadingAccent2 for "ColorfulShadingAccent2"
            /// </summary>            
            ColorfulShadingAccent2,
            
            /// <summary>
            /// Enum ColorfulListAccent2 for "ColorfulListAccent2"
            /// </summary>            
            ColorfulListAccent2,
            
            /// <summary>
            /// Enum ColorfulGridAccent2 for "ColorfulGridAccent2"
            /// </summary>            
            ColorfulGridAccent2,
            
            /// <summary>
            /// Enum LightShadingAccent3 for "LightShadingAccent3"
            /// </summary>            
            LightShadingAccent3,
            
            /// <summary>
            /// Enum LightListAccent3 for "LightListAccent3"
            /// </summary>            
            LightListAccent3,
            
            /// <summary>
            /// Enum LightGridAccent3 for "LightGridAccent3"
            /// </summary>            
            LightGridAccent3,
            
            /// <summary>
            /// Enum MediumShading1Accent3 for "MediumShading1Accent3"
            /// </summary>            
            MediumShading1Accent3,
            
            /// <summary>
            /// Enum MediumShading2Accent3 for "MediumShading2Accent3"
            /// </summary>            
            MediumShading2Accent3,
            
            /// <summary>
            /// Enum MediumList1Accent3 for "MediumList1Accent3"
            /// </summary>            
            MediumList1Accent3,
            
            /// <summary>
            /// Enum MediumList2Accent3 for "MediumList2Accent3"
            /// </summary>            
            MediumList2Accent3,
            
            /// <summary>
            /// Enum MediumGrid1Accent3 for "MediumGrid1Accent3"
            /// </summary>            
            MediumGrid1Accent3,
            
            /// <summary>
            /// Enum MediumGrid2Accent3 for "MediumGrid2Accent3"
            /// </summary>            
            MediumGrid2Accent3,
            
            /// <summary>
            /// Enum MediumGrid3Accent3 for "MediumGrid3Accent3"
            /// </summary>            
            MediumGrid3Accent3,
            
            /// <summary>
            /// Enum DarkListAccent3 for "DarkListAccent3"
            /// </summary>            
            DarkListAccent3,
            
            /// <summary>
            /// Enum ColorfulShadingAccent3 for "ColorfulShadingAccent3"
            /// </summary>            
            ColorfulShadingAccent3,
            
            /// <summary>
            /// Enum ColorfulListAccent3 for "ColorfulListAccent3"
            /// </summary>            
            ColorfulListAccent3,
            
            /// <summary>
            /// Enum ColorfulGridAccent3 for "ColorfulGridAccent3"
            /// </summary>            
            ColorfulGridAccent3,
            
            /// <summary>
            /// Enum LightShadingAccent4 for "LightShadingAccent4"
            /// </summary>            
            LightShadingAccent4,
            
            /// <summary>
            /// Enum LightListAccent4 for "LightListAccent4"
            /// </summary>            
            LightListAccent4,
            
            /// <summary>
            /// Enum LightGridAccent4 for "LightGridAccent4"
            /// </summary>            
            LightGridAccent4,
            
            /// <summary>
            /// Enum MediumShading1Accent4 for "MediumShading1Accent4"
            /// </summary>            
            MediumShading1Accent4,
            
            /// <summary>
            /// Enum MediumShading2Accent4 for "MediumShading2Accent4"
            /// </summary>            
            MediumShading2Accent4,
            
            /// <summary>
            /// Enum MediumList1Accent4 for "MediumList1Accent4"
            /// </summary>            
            MediumList1Accent4,
            
            /// <summary>
            /// Enum MediumList2Accent4 for "MediumList2Accent4"
            /// </summary>            
            MediumList2Accent4,
            
            /// <summary>
            /// Enum MediumGrid1Accent4 for "MediumGrid1Accent4"
            /// </summary>            
            MediumGrid1Accent4,
            
            /// <summary>
            /// Enum MediumGrid2Accent4 for "MediumGrid2Accent4"
            /// </summary>            
            MediumGrid2Accent4,
            
            /// <summary>
            /// Enum MediumGrid3Accent4 for "MediumGrid3Accent4"
            /// </summary>            
            MediumGrid3Accent4,
            
            /// <summary>
            /// Enum DarkListAccent4 for "DarkListAccent4"
            /// </summary>            
            DarkListAccent4,
            
            /// <summary>
            /// Enum ColorfulShadingAccent4 for "ColorfulShadingAccent4"
            /// </summary>            
            ColorfulShadingAccent4,
            
            /// <summary>
            /// Enum ColorfulListAccent4 for "ColorfulListAccent4"
            /// </summary>            
            ColorfulListAccent4,
            
            /// <summary>
            /// Enum ColorfulGridAccent4 for "ColorfulGridAccent4"
            /// </summary>            
            ColorfulGridAccent4,
            
            /// <summary>
            /// Enum LightShadingAccent5 for "LightShadingAccent5"
            /// </summary>            
            LightShadingAccent5,
            
            /// <summary>
            /// Enum LightListAccent5 for "LightListAccent5"
            /// </summary>            
            LightListAccent5,
            
            /// <summary>
            /// Enum LightGridAccent5 for "LightGridAccent5"
            /// </summary>            
            LightGridAccent5,
            
            /// <summary>
            /// Enum MediumShading1Accent5 for "MediumShading1Accent5"
            /// </summary>            
            MediumShading1Accent5,
            
            /// <summary>
            /// Enum MediumShading2Accent5 for "MediumShading2Accent5"
            /// </summary>            
            MediumShading2Accent5,
            
            /// <summary>
            /// Enum MediumList1Accent5 for "MediumList1Accent5"
            /// </summary>            
            MediumList1Accent5,
            
            /// <summary>
            /// Enum MediumList2Accent5 for "MediumList2Accent5"
            /// </summary>            
            MediumList2Accent5,
            
            /// <summary>
            /// Enum MediumGrid1Accent5 for "MediumGrid1Accent5"
            /// </summary>            
            MediumGrid1Accent5,
            
            /// <summary>
            /// Enum MediumGrid2Accent5 for "MediumGrid2Accent5"
            /// </summary>            
            MediumGrid2Accent5,
            
            /// <summary>
            /// Enum MediumGrid3Accent5 for "MediumGrid3Accent5"
            /// </summary>            
            MediumGrid3Accent5,
            
            /// <summary>
            /// Enum DarkListAccent5 for "DarkListAccent5"
            /// </summary>            
            DarkListAccent5,
            
            /// <summary>
            /// Enum ColorfulShadingAccent5 for "ColorfulShadingAccent5"
            /// </summary>            
            ColorfulShadingAccent5,
            
            /// <summary>
            /// Enum ColorfulListAccent5 for "ColorfulListAccent5"
            /// </summary>            
            ColorfulListAccent5,
            
            /// <summary>
            /// Enum ColorfulGridAccent5 for "ColorfulGridAccent5"
            /// </summary>            
            ColorfulGridAccent5,
            
            /// <summary>
            /// Enum LightShadingAccent6 for "LightShadingAccent6"
            /// </summary>            
            LightShadingAccent6,
            
            /// <summary>
            /// Enum LightListAccent6 for "LightListAccent6"
            /// </summary>            
            LightListAccent6,
            
            /// <summary>
            /// Enum LightGridAccent6 for "LightGridAccent6"
            /// </summary>            
            LightGridAccent6,
            
            /// <summary>
            /// Enum MediumShading1Accent6 for "MediumShading1Accent6"
            /// </summary>            
            MediumShading1Accent6,
            
            /// <summary>
            /// Enum MediumShading2Accent6 for "MediumShading2Accent6"
            /// </summary>            
            MediumShading2Accent6,
            
            /// <summary>
            /// Enum MediumList1Accent6 for "MediumList1Accent6"
            /// </summary>            
            MediumList1Accent6,
            
            /// <summary>
            /// Enum MediumList2Accent6 for "MediumList2Accent6"
            /// </summary>            
            MediumList2Accent6,
            
            /// <summary>
            /// Enum MediumGrid1Accent6 for "MediumGrid1Accent6"
            /// </summary>            
            MediumGrid1Accent6,
            
            /// <summary>
            /// Enum MediumGrid2Accent6 for "MediumGrid2Accent6"
            /// </summary>            
            MediumGrid2Accent6,
            
            /// <summary>
            /// Enum MediumGrid3Accent6 for "MediumGrid3Accent6"
            /// </summary>            
            MediumGrid3Accent6,
            
            /// <summary>
            /// Enum DarkListAccent6 for "DarkListAccent6"
            /// </summary>            
            DarkListAccent6,
            
            /// <summary>
            /// Enum ColorfulShadingAccent6 for "ColorfulShadingAccent6"
            /// </summary>            
            ColorfulShadingAccent6,
            
            /// <summary>
            /// Enum ColorfulListAccent6 for "ColorfulListAccent6"
            /// </summary>            
            ColorfulListAccent6,
            
            /// <summary>
            /// Enum ColorfulGridAccent6 for "ColorfulGridAccent6"
            /// </summary>            
            ColorfulGridAccent6,
            
            /// <summary>
            /// Enum SubtleEmphasis for "SubtleEmphasis"
            /// </summary>            
            SubtleEmphasis,
            
            /// <summary>
            /// Enum IntenseEmphasis for "IntenseEmphasis"
            /// </summary>            
            IntenseEmphasis,
            
            /// <summary>
            /// Enum SubtleReference for "SubtleReference"
            /// </summary>            
            SubtleReference,
            
            /// <summary>
            /// Enum IntenseReference for "IntenseReference"
            /// </summary>            
            IntenseReference,
            
            /// <summary>
            /// Enum BookTitle for "BookTitle"
            /// </summary>            
            BookTitle,
            
            /// <summary>
            /// Enum Bibliography for "Bibliography"
            /// </summary>            
            Bibliography,
            
            /// <summary>
            /// Enum TocHeading for "TocHeading"
            /// </summary>            
            TocHeading,
            
            /// <summary>
            /// Enum PlainTable1 for "PlainTable1"
            /// </summary>            
            PlainTable1,
            
            /// <summary>
            /// Enum PlainTable2 for "PlainTable2"
            /// </summary>            
            PlainTable2,
            
            /// <summary>
            /// Enum PlainTable3 for "PlainTable3"
            /// </summary>            
            PlainTable3,
            
            /// <summary>
            /// Enum PlainTable4 for "PlainTable4"
            /// </summary>            
            PlainTable4,
            
            /// <summary>
            /// Enum PlainTable5 for "PlainTable5"
            /// </summary>            
            PlainTable5,
            
            /// <summary>
            /// Enum TableGridLight for "TableGridLight"
            /// </summary>            
            TableGridLight,
            
            /// <summary>
            /// Enum GridTable1Light for "GridTable1Light"
            /// </summary>            
            GridTable1Light,
            
            /// <summary>
            /// Enum GridTable2 for "GridTable2"
            /// </summary>            
            GridTable2,
            
            /// <summary>
            /// Enum GridTable3 for "GridTable3"
            /// </summary>            
            GridTable3,
            
            /// <summary>
            /// Enum GridTable4 for "GridTable4"
            /// </summary>            
            GridTable4,
            
            /// <summary>
            /// Enum GridTable5Dark for "GridTable5Dark"
            /// </summary>            
            GridTable5Dark,
            
            /// <summary>
            /// Enum GridTable6Colorful for "GridTable6Colorful"
            /// </summary>            
            GridTable6Colorful,
            
            /// <summary>
            /// Enum GridTable7Colorful for "GridTable7Colorful"
            /// </summary>            
            GridTable7Colorful,
            
            /// <summary>
            /// Enum GridTable1LightAccent1 for "GridTable1LightAccent1"
            /// </summary>            
            GridTable1LightAccent1,
            
            /// <summary>
            /// Enum GridTable2Accent1 for "GridTable2Accent1"
            /// </summary>            
            GridTable2Accent1,
            
            /// <summary>
            /// Enum GridTable3Accent1 for "GridTable3Accent1"
            /// </summary>            
            GridTable3Accent1,
            
            /// <summary>
            /// Enum GridTable4Accent1 for "GridTable4Accent1"
            /// </summary>            
            GridTable4Accent1,
            
            /// <summary>
            /// Enum GridTable5DarkAccent1 for "GridTable5DarkAccent1"
            /// </summary>            
            GridTable5DarkAccent1,
            
            /// <summary>
            /// Enum GridTable6ColorfulAccent1 for "GridTable6ColorfulAccent1"
            /// </summary>            
            GridTable6ColorfulAccent1,
            
            /// <summary>
            /// Enum GridTable7ColorfulAccent1 for "GridTable7ColorfulAccent1"
            /// </summary>            
            GridTable7ColorfulAccent1,
            
            /// <summary>
            /// Enum GridTable1LightAccent2 for "GridTable1LightAccent2"
            /// </summary>            
            GridTable1LightAccent2,
            
            /// <summary>
            /// Enum GridTable2Accent2 for "GridTable2Accent2"
            /// </summary>            
            GridTable2Accent2,
            
            /// <summary>
            /// Enum GridTable3Accent2 for "GridTable3Accent2"
            /// </summary>            
            GridTable3Accent2,
            
            /// <summary>
            /// Enum GridTable4Accent2 for "GridTable4Accent2"
            /// </summary>            
            GridTable4Accent2,
            
            /// <summary>
            /// Enum GridTable5DarkAccent2 for "GridTable5DarkAccent2"
            /// </summary>            
            GridTable5DarkAccent2,
            
            /// <summary>
            /// Enum GridTable6ColorfulAccent2 for "GridTable6ColorfulAccent2"
            /// </summary>            
            GridTable6ColorfulAccent2,
            
            /// <summary>
            /// Enum GridTable7ColorfulAccent2 for "GridTable7ColorfulAccent2"
            /// </summary>            
            GridTable7ColorfulAccent2,
            
            /// <summary>
            /// Enum GridTable1LightAccent3 for "GridTable1LightAccent3"
            /// </summary>            
            GridTable1LightAccent3,
            
            /// <summary>
            /// Enum GridTable2Accent3 for "GridTable2Accent3"
            /// </summary>            
            GridTable2Accent3,
            
            /// <summary>
            /// Enum GridTable3Accent3 for "GridTable3Accent3"
            /// </summary>            
            GridTable3Accent3,
            
            /// <summary>
            /// Enum GridTable4Accent3 for "GridTable4Accent3"
            /// </summary>            
            GridTable4Accent3,
            
            /// <summary>
            /// Enum GridTable5DarkAccent3 for "GridTable5DarkAccent3"
            /// </summary>            
            GridTable5DarkAccent3,
            
            /// <summary>
            /// Enum GridTable6ColorfulAccent3 for "GridTable6ColorfulAccent3"
            /// </summary>            
            GridTable6ColorfulAccent3,
            
            /// <summary>
            /// Enum GridTable7ColorfulAccent3 for "GridTable7ColorfulAccent3"
            /// </summary>            
            GridTable7ColorfulAccent3,
            
            /// <summary>
            /// Enum GridTable1LightAccent4 for "GridTable1LightAccent4"
            /// </summary>            
            GridTable1LightAccent4,
            
            /// <summary>
            /// Enum GridTable2Accent4 for "GridTable2Accent4"
            /// </summary>            
            GridTable2Accent4,
            
            /// <summary>
            /// Enum GridTable3Accent4 for "GridTable3Accent4"
            /// </summary>            
            GridTable3Accent4,
            
            /// <summary>
            /// Enum GridTable4Accent4 for "GridTable4Accent4"
            /// </summary>            
            GridTable4Accent4,
            
            /// <summary>
            /// Enum GridTable5DarkAccent4 for "GridTable5DarkAccent4"
            /// </summary>            
            GridTable5DarkAccent4,
            
            /// <summary>
            /// Enum GridTable6ColorfulAccent4 for "GridTable6ColorfulAccent4"
            /// </summary>            
            GridTable6ColorfulAccent4,
            
            /// <summary>
            /// Enum GridTable7ColorfulAccent4 for "GridTable7ColorfulAccent4"
            /// </summary>            
            GridTable7ColorfulAccent4,
            
            /// <summary>
            /// Enum GridTable1LightAccent5 for "GridTable1LightAccent5"
            /// </summary>            
            GridTable1LightAccent5,
            
            /// <summary>
            /// Enum GridTable2Accent5 for "GridTable2Accent5"
            /// </summary>            
            GridTable2Accent5,
            
            /// <summary>
            /// Enum GridTable3Accent5 for "GridTable3Accent5"
            /// </summary>            
            GridTable3Accent5,
            
            /// <summary>
            /// Enum GridTable4Accent5 for "GridTable4Accent5"
            /// </summary>            
            GridTable4Accent5,
            
            /// <summary>
            /// Enum GridTable5DarkAccent5 for "GridTable5DarkAccent5"
            /// </summary>            
            GridTable5DarkAccent5,
            
            /// <summary>
            /// Enum GridTable6ColorfulAccent5 for "GridTable6ColorfulAccent5"
            /// </summary>            
            GridTable6ColorfulAccent5,
            
            /// <summary>
            /// Enum GridTable7ColorfulAccent5 for "GridTable7ColorfulAccent5"
            /// </summary>            
            GridTable7ColorfulAccent5,
            
            /// <summary>
            /// Enum GridTable1LightAccent6 for "GridTable1LightAccent6"
            /// </summary>            
            GridTable1LightAccent6,
            
            /// <summary>
            /// Enum GridTable2Accent6 for "GridTable2Accent6"
            /// </summary>            
            GridTable2Accent6,
            
            /// <summary>
            /// Enum GridTable3Accent6 for "GridTable3Accent6"
            /// </summary>            
            GridTable3Accent6,
            
            /// <summary>
            /// Enum GridTable4Accent6 for "GridTable4Accent6"
            /// </summary>            
            GridTable4Accent6,
            
            /// <summary>
            /// Enum GridTable5DarkAccent6 for "GridTable5DarkAccent6"
            /// </summary>            
            GridTable5DarkAccent6,
            
            /// <summary>
            /// Enum GridTable6ColorfulAccent6 for "GridTable6ColorfulAccent6"
            /// </summary>            
            GridTable6ColorfulAccent6,
            
            /// <summary>
            /// Enum GridTable7ColorfulAccent6 for "GridTable7ColorfulAccent6"
            /// </summary>            
            GridTable7ColorfulAccent6,
            
            /// <summary>
            /// Enum ListTable1Light for "ListTable1Light"
            /// </summary>            
            ListTable1Light,
            
            /// <summary>
            /// Enum ListTable2 for "ListTable2"
            /// </summary>            
            ListTable2,
            
            /// <summary>
            /// Enum ListTable3 for "ListTable3"
            /// </summary>            
            ListTable3,
            
            /// <summary>
            /// Enum ListTable4 for "ListTable4"
            /// </summary>            
            ListTable4,
            
            /// <summary>
            /// Enum ListTable5Dark for "ListTable5Dark"
            /// </summary>            
            ListTable5Dark,
            
            /// <summary>
            /// Enum ListTable6Colorful for "ListTable6Colorful"
            /// </summary>            
            ListTable6Colorful,
            
            /// <summary>
            /// Enum ListTable7Colorful for "ListTable7Colorful"
            /// </summary>            
            ListTable7Colorful,
            
            /// <summary>
            /// Enum ListTable1LightAccent1 for "ListTable1LightAccent1"
            /// </summary>            
            ListTable1LightAccent1,
            
            /// <summary>
            /// Enum ListTable2Accent1 for "ListTable2Accent1"
            /// </summary>            
            ListTable2Accent1,
            
            /// <summary>
            /// Enum ListTable3Accent1 for "ListTable3Accent1"
            /// </summary>            
            ListTable3Accent1,
            
            /// <summary>
            /// Enum ListTable4Accent1 for "ListTable4Accent1"
            /// </summary>            
            ListTable4Accent1,
            
            /// <summary>
            /// Enum ListTable5DarkAccent1 for "ListTable5DarkAccent1"
            /// </summary>            
            ListTable5DarkAccent1,
            
            /// <summary>
            /// Enum ListTable6ColorfulAccent1 for "ListTable6ColorfulAccent1"
            /// </summary>            
            ListTable6ColorfulAccent1,
            
            /// <summary>
            /// Enum ListTable7ColorfulAccent1 for "ListTable7ColorfulAccent1"
            /// </summary>            
            ListTable7ColorfulAccent1,
            
            /// <summary>
            /// Enum ListTable1LightAccent2 for "ListTable1LightAccent2"
            /// </summary>            
            ListTable1LightAccent2,
            
            /// <summary>
            /// Enum ListTable2Accent2 for "ListTable2Accent2"
            /// </summary>            
            ListTable2Accent2,
            
            /// <summary>
            /// Enum ListTable3Accent2 for "ListTable3Accent2"
            /// </summary>            
            ListTable3Accent2,
            
            /// <summary>
            /// Enum ListTable4Accent2 for "ListTable4Accent2"
            /// </summary>            
            ListTable4Accent2,
            
            /// <summary>
            /// Enum ListTable5DarkAccent2 for "ListTable5DarkAccent2"
            /// </summary>            
            ListTable5DarkAccent2,
            
            /// <summary>
            /// Enum ListTable6ColorfulAccent2 for "ListTable6ColorfulAccent2"
            /// </summary>            
            ListTable6ColorfulAccent2,
            
            /// <summary>
            /// Enum ListTable7ColorfulAccent2 for "ListTable7ColorfulAccent2"
            /// </summary>            
            ListTable7ColorfulAccent2,
            
            /// <summary>
            /// Enum ListTable1LightAccent3 for "ListTable1LightAccent3"
            /// </summary>            
            ListTable1LightAccent3,
            
            /// <summary>
            /// Enum ListTable2Accent3 for "ListTable2Accent3"
            /// </summary>            
            ListTable2Accent3,
            
            /// <summary>
            /// Enum ListTable3Accent3 for "ListTable3Accent3"
            /// </summary>            
            ListTable3Accent3,
            
            /// <summary>
            /// Enum ListTable4Accent3 for "ListTable4Accent3"
            /// </summary>            
            ListTable4Accent3,
            
            /// <summary>
            /// Enum ListTable5DarkAccent3 for "ListTable5DarkAccent3"
            /// </summary>            
            ListTable5DarkAccent3,
            
            /// <summary>
            /// Enum ListTable6ColorfulAccent3 for "ListTable6ColorfulAccent3"
            /// </summary>            
            ListTable6ColorfulAccent3,
            
            /// <summary>
            /// Enum ListTable7ColorfulAccent3 for "ListTable7ColorfulAccent3"
            /// </summary>            
            ListTable7ColorfulAccent3,
            
            /// <summary>
            /// Enum ListTable1LightAccent4 for "ListTable1LightAccent4"
            /// </summary>            
            ListTable1LightAccent4,
            
            /// <summary>
            /// Enum ListTable2Accent4 for "ListTable2Accent4"
            /// </summary>            
            ListTable2Accent4,
            
            /// <summary>
            /// Enum ListTable3Accent4 for "ListTable3Accent4"
            /// </summary>            
            ListTable3Accent4,
            
            /// <summary>
            /// Enum ListTable4Accent4 for "ListTable4Accent4"
            /// </summary>            
            ListTable4Accent4,
            
            /// <summary>
            /// Enum ListTable5DarkAccent4 for "ListTable5DarkAccent4"
            /// </summary>            
            ListTable5DarkAccent4,
            
            /// <summary>
            /// Enum ListTable6ColorfulAccent4 for "ListTable6ColorfulAccent4"
            /// </summary>            
            ListTable6ColorfulAccent4,
            
            /// <summary>
            /// Enum ListTable7ColorfulAccent4 for "ListTable7ColorfulAccent4"
            /// </summary>            
            ListTable7ColorfulAccent4,
            
            /// <summary>
            /// Enum ListTable1LightAccent5 for "ListTable1LightAccent5"
            /// </summary>            
            ListTable1LightAccent5,
            
            /// <summary>
            /// Enum ListTable2Accent5 for "ListTable2Accent5"
            /// </summary>            
            ListTable2Accent5,
            
            /// <summary>
            /// Enum ListTable3Accent5 for "ListTable3Accent5"
            /// </summary>            
            ListTable3Accent5,
            
            /// <summary>
            /// Enum ListTable4Accent5 for "ListTable4Accent5"
            /// </summary>            
            ListTable4Accent5,
            
            /// <summary>
            /// Enum ListTable5DarkAccent5 for "ListTable5DarkAccent5"
            /// </summary>            
            ListTable5DarkAccent5,
            
            /// <summary>
            /// Enum ListTable6ColorfulAccent5 for "ListTable6ColorfulAccent5"
            /// </summary>            
            ListTable6ColorfulAccent5,
            
            /// <summary>
            /// Enum ListTable7ColorfulAccent5 for "ListTable7ColorfulAccent5"
            /// </summary>            
            ListTable7ColorfulAccent5,
            
            /// <summary>
            /// Enum ListTable1LightAccent6 for "ListTable1LightAccent6"
            /// </summary>            
            ListTable1LightAccent6,
            
            /// <summary>
            /// Enum ListTable2Accent6 for "ListTable2Accent6"
            /// </summary>            
            ListTable2Accent6,
            
            /// <summary>
            /// Enum ListTable3Accent6 for "ListTable3Accent6"
            /// </summary>            
            ListTable3Accent6,
            
            /// <summary>
            /// Enum ListTable4Accent6 for "ListTable4Accent6"
            /// </summary>            
            ListTable4Accent6,
            
            /// <summary>
            /// Enum ListTable5DarkAccent6 for "ListTable5DarkAccent6"
            /// </summary>            
            ListTable5DarkAccent6,
            
            /// <summary>
            /// Enum ListTable6ColorfulAccent6 for "ListTable6ColorfulAccent6"
            /// </summary>            
            ListTable6ColorfulAccent6,
            
            /// <summary>
            /// Enum ListTable7ColorfulAccent6 for "ListTable7ColorfulAccent6"
            /// </summary>            
            ListTable7ColorfulAccent6,
            
            /// <summary>
            /// Enum User for "User"
            /// </summary>            
            User,
            
            /// <summary>
            /// Enum Nil for "Nil"
            /// </summary>            
            Nil            
        }

        /// <summary>
        /// Gets or sets bit flags that specify how a table style is applied to this table.
        /// </summary>
        /// <value>Gets or sets bit flags that specify how a table style is applied to this table.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StyleOptionsEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum FirstRow for "FirstRow"
            /// </summary>            
            FirstRow,
            
            /// <summary>
            /// Enum LastRow for "LastRow"
            /// </summary>            
            LastRow,
            
            /// <summary>
            /// Enum FirstColumn for "FirstColumn"
            /// </summary>            
            FirstColumn,
            
            /// <summary>
            /// Enum LastColumn for "LastColumn"
            /// </summary>            
            LastColumn,
            
            /// <summary>
            /// Enum RowBands for "RowBands"
            /// </summary>            
            RowBands,
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum ColumnBands for "ColumnBands"
            /// </summary>            
            ColumnBands,
            
            /// <summary>
            /// Enum Default2003 for "Default2003"
            /// </summary>            
            Default2003            
        }

        /// <summary>
        /// Get or sets TextWrapping  for table.
        /// </summary>
        /// <value>Get or sets TextWrapping  for table.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextWrappingEnum
        { 
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Around for "Around"
            /// </summary>            
            Around            
        }

        /// <summary>
        /// Specifies how an inline table is aligned in the document.
        /// </summary>
        public AlignmentEnum? Alignment { get; set; }

        /// <summary>
        /// Gets or sets the locale independent style identifier of the table style applied to this table.
        /// </summary>
        public StyleIdentifierEnum? StyleIdentifier { get; set; }

        /// <summary>
        /// Gets or sets bit flags that specify how a table style is applied to this table.
        /// </summary>
        public StyleOptionsEnum? StyleOptions { get; set; }

        /// <summary>
        /// Get or sets TextWrapping  for table.
        /// </summary>
        public TextWrappingEnum? TextWrapping { get; set; }

        /// <summary>
        /// Allows Microsoft Word and Aspose.Words to automatically resize cells in a table to fit their contents.
        /// </summary>  
        public bool? AllowAutoFit { get; set; }

        /// <summary>
        /// Gets or sets whether this is a right-to-left table.
        /// </summary>  
        public bool? Bidi { get; set; }

        /// <summary>
        /// Gets or sets the amount of space (in points) to add below the contents of cells.
        /// </summary>  
        public double? BottomPadding { get; set; }

        /// <summary>
        /// Gets or sets the amount of space (in points) between the cells.
        /// </summary>  
        public double? CellSpacing { get; set; }

        /// <summary>
        /// Gets or sets the value that represents the left indent of the table.
        /// </summary>  
        public double? LeftIndent { get; set; }

        /// <summary>
        /// Gets or sets the amount of space (in points) to add to the left of the contents of cells.
        /// </summary>  
        public double? LeftPadding { get; set; }

        /// <summary>
        /// Gets or sets the table preferred width.  Preferred width can be specified as a percentage, number of points or a special \"auto\" value.
        /// </summary>  
        public PreferredWidth PreferredWidth { get; set; }

        /// <summary>
        /// Gets or sets the amount of space (in points) to add to the right of the contents of cells.
        /// </summary>  
        public double? RightPadding { get; set; }

        /// <summary>
        /// Gets or sets the name of the table style applied to this table.
        /// </summary>  
        public string StyleName { get; set; }

        /// <summary>
        /// Gets or sets the amount of space (in points) to add above the contents of cells.
        /// </summary>  
        public double? TopPadding { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TableProperties {\n");
          sb.Append("  Alignment: ").Append(this.Alignment).Append("\n");
          sb.Append("  AllowAutoFit: ").Append(this.AllowAutoFit).Append("\n");
          sb.Append("  Bidi: ").Append(this.Bidi).Append("\n");
          sb.Append("  BottomPadding: ").Append(this.BottomPadding).Append("\n");
          sb.Append("  CellSpacing: ").Append(this.CellSpacing).Append("\n");
          sb.Append("  LeftIndent: ").Append(this.LeftIndent).Append("\n");
          sb.Append("  LeftPadding: ").Append(this.LeftPadding).Append("\n");
          sb.Append("  PreferredWidth: ").Append(this.PreferredWidth).Append("\n");
          sb.Append("  RightPadding: ").Append(this.RightPadding).Append("\n");
          sb.Append("  StyleIdentifier: ").Append(this.StyleIdentifier).Append("\n");
          sb.Append("  StyleName: ").Append(this.StyleName).Append("\n");
          sb.Append("  StyleOptions: ").Append(this.StyleOptions).Append("\n");
          sb.Append("  TextWrapping: ").Append(this.TextWrapping).Append("\n");
          sb.Append("  TopPadding: ").Append(this.TopPadding).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
