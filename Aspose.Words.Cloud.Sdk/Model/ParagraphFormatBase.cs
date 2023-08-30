// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ParagraphFormatBase.cs">
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
    /// Paragraph format element base class.
    /// </summary>
    public class ParagraphFormatBase : LinkElement, IModel
    {
        /// <summary>
        /// Gets or sets text alignment for the paragraph.
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

            /// <summary>
            /// Enum value "Justify"
            /// </summary>
            Justify,

            /// <summary>
            /// Enum value "Distributed"
            /// </summary>
            Distributed,

            /// <summary>
            /// Enum value "ArabicMediumKashida"
            /// </summary>
            ArabicMediumKashida,

            /// <summary>
            /// Enum value "ArabicHighKashida"
            /// </summary>
            ArabicHighKashida,

            /// <summary>
            /// Enum value "ArabicLowKashida"
            /// </summary>
            ArabicLowKashida,

            /// <summary>
            /// Enum value "ThaiDistributed"
            /// </summary>
            ThaiDistributed,

            /// <summary>
            /// Enum value "MathElementCenterAsGroup"
            /// </summary>
            MathElementCenterAsGroup,
        }

        /// <summary>
        /// Gets or sets the position for a drop cap text.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DropCapPositionEnum
        {
            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,

            /// <summary>
            /// Enum value "Normal"
            /// </summary>
            Normal,

            /// <summary>
            /// Enum value "Margin"
            /// </summary>
            Margin,
        }

        /// <summary>
        /// Gets or sets the line spacing for the paragraph.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LineSpacingRuleEnum
        {
            /// <summary>
            /// Enum value "AtLeast"
            /// </summary>
            AtLeast,

            /// <summary>
            /// Enum value "Exactly"
            /// </summary>
            Exactly,

            /// <summary>
            /// Enum value "Multiple"
            /// </summary>
            Multiple,
        }

        /// <summary>
        /// Gets or sets the outline level of the paragraph in the document.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OutlineLevelEnum
        {
            /// <summary>
            /// Enum value "Level1"
            /// </summary>
            Level1,

            /// <summary>
            /// Enum value "Level2"
            /// </summary>
            Level2,

            /// <summary>
            /// Enum value "Level3"
            /// </summary>
            Level3,

            /// <summary>
            /// Enum value "Level4"
            /// </summary>
            Level4,

            /// <summary>
            /// Enum value "Level5"
            /// </summary>
            Level5,

            /// <summary>
            /// Enum value "Level6"
            /// </summary>
            Level6,

            /// <summary>
            /// Enum value "Level7"
            /// </summary>
            Level7,

            /// <summary>
            /// Enum value "Level8"
            /// </summary>
            Level8,

            /// <summary>
            /// Enum value "Level9"
            /// </summary>
            Level9,

            /// <summary>
            /// Enum value "BodyText"
            /// </summary>
            BodyText,
        }

        /// <summary>
        /// Gets or sets the locale independent style identifier of the paragraph style applied to this formatting.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StyleIdentifierEnum
        {
            /// <summary>
            /// Enum value "Normal"
            /// </summary>
            Normal,

            /// <summary>
            /// Enum value "Heading1"
            /// </summary>
            Heading1,

            /// <summary>
            /// Enum value "Heading2"
            /// </summary>
            Heading2,

            /// <summary>
            /// Enum value "Heading3"
            /// </summary>
            Heading3,

            /// <summary>
            /// Enum value "Heading4"
            /// </summary>
            Heading4,

            /// <summary>
            /// Enum value "Heading5"
            /// </summary>
            Heading5,

            /// <summary>
            /// Enum value "Heading6"
            /// </summary>
            Heading6,

            /// <summary>
            /// Enum value "Heading7"
            /// </summary>
            Heading7,

            /// <summary>
            /// Enum value "Heading8"
            /// </summary>
            Heading8,

            /// <summary>
            /// Enum value "Heading9"
            /// </summary>
            Heading9,

            /// <summary>
            /// Enum value "Index1"
            /// </summary>
            Index1,

            /// <summary>
            /// Enum value "Index2"
            /// </summary>
            Index2,

            /// <summary>
            /// Enum value "Index3"
            /// </summary>
            Index3,

            /// <summary>
            /// Enum value "Index4"
            /// </summary>
            Index4,

            /// <summary>
            /// Enum value "Index5"
            /// </summary>
            Index5,

            /// <summary>
            /// Enum value "Index6"
            /// </summary>
            Index6,

            /// <summary>
            /// Enum value "Index7"
            /// </summary>
            Index7,

            /// <summary>
            /// Enum value "Index8"
            /// </summary>
            Index8,

            /// <summary>
            /// Enum value "Index9"
            /// </summary>
            Index9,

            /// <summary>
            /// Enum value "Toc1"
            /// </summary>
            Toc1,

            /// <summary>
            /// Enum value "Toc2"
            /// </summary>
            Toc2,

            /// <summary>
            /// Enum value "Toc3"
            /// </summary>
            Toc3,

            /// <summary>
            /// Enum value "Toc4"
            /// </summary>
            Toc4,

            /// <summary>
            /// Enum value "Toc5"
            /// </summary>
            Toc5,

            /// <summary>
            /// Enum value "Toc6"
            /// </summary>
            Toc6,

            /// <summary>
            /// Enum value "Toc7"
            /// </summary>
            Toc7,

            /// <summary>
            /// Enum value "Toc8"
            /// </summary>
            Toc8,

            /// <summary>
            /// Enum value "Toc9"
            /// </summary>
            Toc9,

            /// <summary>
            /// Enum value "NormalIndent"
            /// </summary>
            NormalIndent,

            /// <summary>
            /// Enum value "FootnoteText"
            /// </summary>
            FootnoteText,

            /// <summary>
            /// Enum value "CommentText"
            /// </summary>
            CommentText,

            /// <summary>
            /// Enum value "Header"
            /// </summary>
            Header,

            /// <summary>
            /// Enum value "Footer"
            /// </summary>
            Footer,

            /// <summary>
            /// Enum value "IndexHeading"
            /// </summary>
            IndexHeading,

            /// <summary>
            /// Enum value "Caption"
            /// </summary>
            Caption,

            /// <summary>
            /// Enum value "TableOfFigures"
            /// </summary>
            TableOfFigures,

            /// <summary>
            /// Enum value "EnvelopeAddress"
            /// </summary>
            EnvelopeAddress,

            /// <summary>
            /// Enum value "EnvelopeReturn"
            /// </summary>
            EnvelopeReturn,

            /// <summary>
            /// Enum value "FootnoteReference"
            /// </summary>
            FootnoteReference,

            /// <summary>
            /// Enum value "CommentReference"
            /// </summary>
            CommentReference,

            /// <summary>
            /// Enum value "LineNumber"
            /// </summary>
            LineNumber,

            /// <summary>
            /// Enum value "PageNumber"
            /// </summary>
            PageNumber,

            /// <summary>
            /// Enum value "EndnoteReference"
            /// </summary>
            EndnoteReference,

            /// <summary>
            /// Enum value "EndnoteText"
            /// </summary>
            EndnoteText,

            /// <summary>
            /// Enum value "TableOfAuthorities"
            /// </summary>
            TableOfAuthorities,

            /// <summary>
            /// Enum value "Macro"
            /// </summary>
            Macro,

            /// <summary>
            /// Enum value "ToaHeading"
            /// </summary>
            ToaHeading,

            /// <summary>
            /// Enum value "List"
            /// </summary>
            List,

            /// <summary>
            /// Enum value "ListBullet"
            /// </summary>
            ListBullet,

            /// <summary>
            /// Enum value "ListNumber"
            /// </summary>
            ListNumber,

            /// <summary>
            /// Enum value "List2"
            /// </summary>
            List2,

            /// <summary>
            /// Enum value "List3"
            /// </summary>
            List3,

            /// <summary>
            /// Enum value "List4"
            /// </summary>
            List4,

            /// <summary>
            /// Enum value "List5"
            /// </summary>
            List5,

            /// <summary>
            /// Enum value "ListBullet2"
            /// </summary>
            ListBullet2,

            /// <summary>
            /// Enum value "ListBullet3"
            /// </summary>
            ListBullet3,

            /// <summary>
            /// Enum value "ListBullet4"
            /// </summary>
            ListBullet4,

            /// <summary>
            /// Enum value "ListBullet5"
            /// </summary>
            ListBullet5,

            /// <summary>
            /// Enum value "ListNumber2"
            /// </summary>
            ListNumber2,

            /// <summary>
            /// Enum value "ListNumber3"
            /// </summary>
            ListNumber3,

            /// <summary>
            /// Enum value "ListNumber4"
            /// </summary>
            ListNumber4,

            /// <summary>
            /// Enum value "ListNumber5"
            /// </summary>
            ListNumber5,

            /// <summary>
            /// Enum value "Title"
            /// </summary>
            Title,

            /// <summary>
            /// Enum value "Closing"
            /// </summary>
            Closing,

            /// <summary>
            /// Enum value "Signature"
            /// </summary>
            Signature,

            /// <summary>
            /// Enum value "DefaultParagraphFont"
            /// </summary>
            DefaultParagraphFont,

            /// <summary>
            /// Enum value "BodyText"
            /// </summary>
            BodyText,

            /// <summary>
            /// Enum value "BodyTextInd"
            /// </summary>
            BodyTextInd,

            /// <summary>
            /// Enum value "ListContinue"
            /// </summary>
            ListContinue,

            /// <summary>
            /// Enum value "ListContinue2"
            /// </summary>
            ListContinue2,

            /// <summary>
            /// Enum value "ListContinue3"
            /// </summary>
            ListContinue3,

            /// <summary>
            /// Enum value "ListContinue4"
            /// </summary>
            ListContinue4,

            /// <summary>
            /// Enum value "ListContinue5"
            /// </summary>
            ListContinue5,

            /// <summary>
            /// Enum value "MessageHeader"
            /// </summary>
            MessageHeader,

            /// <summary>
            /// Enum value "Subtitle"
            /// </summary>
            Subtitle,

            /// <summary>
            /// Enum value "Salutation"
            /// </summary>
            Salutation,

            /// <summary>
            /// Enum value "Date"
            /// </summary>
            Date,

            /// <summary>
            /// Enum value "BodyText1I"
            /// </summary>
            BodyText1I,

            /// <summary>
            /// Enum value "BodyText1I2"
            /// </summary>
            BodyText1I2,

            /// <summary>
            /// Enum value "NoteHeading"
            /// </summary>
            NoteHeading,

            /// <summary>
            /// Enum value "BodyText2"
            /// </summary>
            BodyText2,

            /// <summary>
            /// Enum value "BodyText3"
            /// </summary>
            BodyText3,

            /// <summary>
            /// Enum value "BodyTextInd2"
            /// </summary>
            BodyTextInd2,

            /// <summary>
            /// Enum value "BodyTextInd3"
            /// </summary>
            BodyTextInd3,

            /// <summary>
            /// Enum value "BlockText"
            /// </summary>
            BlockText,

            /// <summary>
            /// Enum value "Hyperlink"
            /// </summary>
            Hyperlink,

            /// <summary>
            /// Enum value "FollowedHyperlink"
            /// </summary>
            FollowedHyperlink,

            /// <summary>
            /// Enum value "Strong"
            /// </summary>
            Strong,

            /// <summary>
            /// Enum value "Emphasis"
            /// </summary>
            Emphasis,

            /// <summary>
            /// Enum value "DocumentMap"
            /// </summary>
            DocumentMap,

            /// <summary>
            /// Enum value "PlainText"
            /// </summary>
            PlainText,

            /// <summary>
            /// Enum value "EmailSignature"
            /// </summary>
            EmailSignature,

            /// <summary>
            /// Enum value "HtmlTopOfForm"
            /// </summary>
            HtmlTopOfForm,

            /// <summary>
            /// Enum value "HtmlBottomOfForm"
            /// </summary>
            HtmlBottomOfForm,

            /// <summary>
            /// Enum value "NormalWeb"
            /// </summary>
            NormalWeb,

            /// <summary>
            /// Enum value "HtmlAcronym"
            /// </summary>
            HtmlAcronym,

            /// <summary>
            /// Enum value "HtmlAddress"
            /// </summary>
            HtmlAddress,

            /// <summary>
            /// Enum value "HtmlCite"
            /// </summary>
            HtmlCite,

            /// <summary>
            /// Enum value "HtmlCode"
            /// </summary>
            HtmlCode,

            /// <summary>
            /// Enum value "HtmlDefinition"
            /// </summary>
            HtmlDefinition,

            /// <summary>
            /// Enum value "HtmlKeyboard"
            /// </summary>
            HtmlKeyboard,

            /// <summary>
            /// Enum value "HtmlPreformatted"
            /// </summary>
            HtmlPreformatted,

            /// <summary>
            /// Enum value "HtmlSample"
            /// </summary>
            HtmlSample,

            /// <summary>
            /// Enum value "HtmlTypewriter"
            /// </summary>
            HtmlTypewriter,

            /// <summary>
            /// Enum value "HtmlVariable"
            /// </summary>
            HtmlVariable,

            /// <summary>
            /// Enum value "TableNormal"
            /// </summary>
            TableNormal,

            /// <summary>
            /// Enum value "CommentSubject"
            /// </summary>
            CommentSubject,

            /// <summary>
            /// Enum value "NoList"
            /// </summary>
            NoList,

            /// <summary>
            /// Enum value "OutlineList1"
            /// </summary>
            OutlineList1,

            /// <summary>
            /// Enum value "OutlineList2"
            /// </summary>
            OutlineList2,

            /// <summary>
            /// Enum value "OutlineList3"
            /// </summary>
            OutlineList3,

            /// <summary>
            /// Enum value "TableSimple1"
            /// </summary>
            TableSimple1,

            /// <summary>
            /// Enum value "TableSimple2"
            /// </summary>
            TableSimple2,

            /// <summary>
            /// Enum value "TableSimple3"
            /// </summary>
            TableSimple3,

            /// <summary>
            /// Enum value "TableClassic1"
            /// </summary>
            TableClassic1,

            /// <summary>
            /// Enum value "TableClassic2"
            /// </summary>
            TableClassic2,

            /// <summary>
            /// Enum value "TableClassic3"
            /// </summary>
            TableClassic3,

            /// <summary>
            /// Enum value "TableClassic4"
            /// </summary>
            TableClassic4,

            /// <summary>
            /// Enum value "TableColorful1"
            /// </summary>
            TableColorful1,

            /// <summary>
            /// Enum value "TableColorful2"
            /// </summary>
            TableColorful2,

            /// <summary>
            /// Enum value "TableColorful3"
            /// </summary>
            TableColorful3,

            /// <summary>
            /// Enum value "TableColumns1"
            /// </summary>
            TableColumns1,

            /// <summary>
            /// Enum value "TableColumns2"
            /// </summary>
            TableColumns2,

            /// <summary>
            /// Enum value "TableColumns3"
            /// </summary>
            TableColumns3,

            /// <summary>
            /// Enum value "TableColumns4"
            /// </summary>
            TableColumns4,

            /// <summary>
            /// Enum value "TableColumns5"
            /// </summary>
            TableColumns5,

            /// <summary>
            /// Enum value "TableGrid1"
            /// </summary>
            TableGrid1,

            /// <summary>
            /// Enum value "TableGrid2"
            /// </summary>
            TableGrid2,

            /// <summary>
            /// Enum value "TableGrid3"
            /// </summary>
            TableGrid3,

            /// <summary>
            /// Enum value "TableGrid4"
            /// </summary>
            TableGrid4,

            /// <summary>
            /// Enum value "TableGrid5"
            /// </summary>
            TableGrid5,

            /// <summary>
            /// Enum value "TableGrid6"
            /// </summary>
            TableGrid6,

            /// <summary>
            /// Enum value "TableGrid7"
            /// </summary>
            TableGrid7,

            /// <summary>
            /// Enum value "TableGrid8"
            /// </summary>
            TableGrid8,

            /// <summary>
            /// Enum value "TableList1"
            /// </summary>
            TableList1,

            /// <summary>
            /// Enum value "TableList2"
            /// </summary>
            TableList2,

            /// <summary>
            /// Enum value "TableList3"
            /// </summary>
            TableList3,

            /// <summary>
            /// Enum value "TableList4"
            /// </summary>
            TableList4,

            /// <summary>
            /// Enum value "TableList5"
            /// </summary>
            TableList5,

            /// <summary>
            /// Enum value "TableList6"
            /// </summary>
            TableList6,

            /// <summary>
            /// Enum value "TableList7"
            /// </summary>
            TableList7,

            /// <summary>
            /// Enum value "TableList8"
            /// </summary>
            TableList8,

            /// <summary>
            /// Enum value "Table3DEffects1"
            /// </summary>
            Table3DEffects1,

            /// <summary>
            /// Enum value "Table3DEffects2"
            /// </summary>
            Table3DEffects2,

            /// <summary>
            /// Enum value "Table3DEffects3"
            /// </summary>
            Table3DEffects3,

            /// <summary>
            /// Enum value "TableContemporary"
            /// </summary>
            TableContemporary,

            /// <summary>
            /// Enum value "TableElegant"
            /// </summary>
            TableElegant,

            /// <summary>
            /// Enum value "TableProfessional"
            /// </summary>
            TableProfessional,

            /// <summary>
            /// Enum value "TableSubtle1"
            /// </summary>
            TableSubtle1,

            /// <summary>
            /// Enum value "TableSubtle2"
            /// </summary>
            TableSubtle2,

            /// <summary>
            /// Enum value "TableWeb1"
            /// </summary>
            TableWeb1,

            /// <summary>
            /// Enum value "TableWeb2"
            /// </summary>
            TableWeb2,

            /// <summary>
            /// Enum value "TableWeb3"
            /// </summary>
            TableWeb3,

            /// <summary>
            /// Enum value "BalloonText"
            /// </summary>
            BalloonText,

            /// <summary>
            /// Enum value "TableGrid"
            /// </summary>
            TableGrid,

            /// <summary>
            /// Enum value "TableTheme"
            /// </summary>
            TableTheme,

            /// <summary>
            /// Enum value "PlaceholderText"
            /// </summary>
            PlaceholderText,

            /// <summary>
            /// Enum value "NoSpacing"
            /// </summary>
            NoSpacing,

            /// <summary>
            /// Enum value "LightShading"
            /// </summary>
            LightShading,

            /// <summary>
            /// Enum value "LightList"
            /// </summary>
            LightList,

            /// <summary>
            /// Enum value "LightGrid"
            /// </summary>
            LightGrid,

            /// <summary>
            /// Enum value "MediumShading1"
            /// </summary>
            MediumShading1,

            /// <summary>
            /// Enum value "MediumShading2"
            /// </summary>
            MediumShading2,

            /// <summary>
            /// Enum value "MediumList1"
            /// </summary>
            MediumList1,

            /// <summary>
            /// Enum value "MediumList2"
            /// </summary>
            MediumList2,

            /// <summary>
            /// Enum value "MediumGrid1"
            /// </summary>
            MediumGrid1,

            /// <summary>
            /// Enum value "MediumGrid2"
            /// </summary>
            MediumGrid2,

            /// <summary>
            /// Enum value "MediumGrid3"
            /// </summary>
            MediumGrid3,

            /// <summary>
            /// Enum value "DarkList"
            /// </summary>
            DarkList,

            /// <summary>
            /// Enum value "ColorfulShading"
            /// </summary>
            ColorfulShading,

            /// <summary>
            /// Enum value "ColorfulList"
            /// </summary>
            ColorfulList,

            /// <summary>
            /// Enum value "ColorfulGrid"
            /// </summary>
            ColorfulGrid,

            /// <summary>
            /// Enum value "LightShadingAccent1"
            /// </summary>
            LightShadingAccent1,

            /// <summary>
            /// Enum value "LightListAccent1"
            /// </summary>
            LightListAccent1,

            /// <summary>
            /// Enum value "LightGridAccent1"
            /// </summary>
            LightGridAccent1,

            /// <summary>
            /// Enum value "MediumShading1Accent1"
            /// </summary>
            MediumShading1Accent1,

            /// <summary>
            /// Enum value "MediumShading2Accent1"
            /// </summary>
            MediumShading2Accent1,

            /// <summary>
            /// Enum value "MediumList1Accent1"
            /// </summary>
            MediumList1Accent1,

            /// <summary>
            /// Enum value "Revision"
            /// </summary>
            Revision,

            /// <summary>
            /// Enum value "ListParagraph"
            /// </summary>
            ListParagraph,

            /// <summary>
            /// Enum value "Quote"
            /// </summary>
            Quote,

            /// <summary>
            /// Enum value "IntenseQuote"
            /// </summary>
            IntenseQuote,

            /// <summary>
            /// Enum value "MediumList2Accent1"
            /// </summary>
            MediumList2Accent1,

            /// <summary>
            /// Enum value "MediumGrid1Accent1"
            /// </summary>
            MediumGrid1Accent1,

            /// <summary>
            /// Enum value "MediumGrid2Accent1"
            /// </summary>
            MediumGrid2Accent1,

            /// <summary>
            /// Enum value "MediumGrid3Accent1"
            /// </summary>
            MediumGrid3Accent1,

            /// <summary>
            /// Enum value "DarkListAccent1"
            /// </summary>
            DarkListAccent1,

            /// <summary>
            /// Enum value "ColorfulShadingAccent1"
            /// </summary>
            ColorfulShadingAccent1,

            /// <summary>
            /// Enum value "ColorfulListAccent1"
            /// </summary>
            ColorfulListAccent1,

            /// <summary>
            /// Enum value "ColorfulGridAccent1"
            /// </summary>
            ColorfulGridAccent1,

            /// <summary>
            /// Enum value "LightShadingAccent2"
            /// </summary>
            LightShadingAccent2,

            /// <summary>
            /// Enum value "LightListAccent2"
            /// </summary>
            LightListAccent2,

            /// <summary>
            /// Enum value "LightGridAccent2"
            /// </summary>
            LightGridAccent2,

            /// <summary>
            /// Enum value "MediumShading1Accent2"
            /// </summary>
            MediumShading1Accent2,

            /// <summary>
            /// Enum value "MediumShading2Accent2"
            /// </summary>
            MediumShading2Accent2,

            /// <summary>
            /// Enum value "MediumList1Accent2"
            /// </summary>
            MediumList1Accent2,

            /// <summary>
            /// Enum value "MediumList2Accent2"
            /// </summary>
            MediumList2Accent2,

            /// <summary>
            /// Enum value "MediumGrid1Accent2"
            /// </summary>
            MediumGrid1Accent2,

            /// <summary>
            /// Enum value "MediumGrid2Accent2"
            /// </summary>
            MediumGrid2Accent2,

            /// <summary>
            /// Enum value "MediumGrid3Accent2"
            /// </summary>
            MediumGrid3Accent2,

            /// <summary>
            /// Enum value "DarkListAccent2"
            /// </summary>
            DarkListAccent2,

            /// <summary>
            /// Enum value "ColorfulShadingAccent2"
            /// </summary>
            ColorfulShadingAccent2,

            /// <summary>
            /// Enum value "ColorfulListAccent2"
            /// </summary>
            ColorfulListAccent2,

            /// <summary>
            /// Enum value "ColorfulGridAccent2"
            /// </summary>
            ColorfulGridAccent2,

            /// <summary>
            /// Enum value "LightShadingAccent3"
            /// </summary>
            LightShadingAccent3,

            /// <summary>
            /// Enum value "LightListAccent3"
            /// </summary>
            LightListAccent3,

            /// <summary>
            /// Enum value "LightGridAccent3"
            /// </summary>
            LightGridAccent3,

            /// <summary>
            /// Enum value "MediumShading1Accent3"
            /// </summary>
            MediumShading1Accent3,

            /// <summary>
            /// Enum value "MediumShading2Accent3"
            /// </summary>
            MediumShading2Accent3,

            /// <summary>
            /// Enum value "MediumList1Accent3"
            /// </summary>
            MediumList1Accent3,

            /// <summary>
            /// Enum value "MediumList2Accent3"
            /// </summary>
            MediumList2Accent3,

            /// <summary>
            /// Enum value "MediumGrid1Accent3"
            /// </summary>
            MediumGrid1Accent3,

            /// <summary>
            /// Enum value "MediumGrid2Accent3"
            /// </summary>
            MediumGrid2Accent3,

            /// <summary>
            /// Enum value "MediumGrid3Accent3"
            /// </summary>
            MediumGrid3Accent3,

            /// <summary>
            /// Enum value "DarkListAccent3"
            /// </summary>
            DarkListAccent3,

            /// <summary>
            /// Enum value "ColorfulShadingAccent3"
            /// </summary>
            ColorfulShadingAccent3,

            /// <summary>
            /// Enum value "ColorfulListAccent3"
            /// </summary>
            ColorfulListAccent3,

            /// <summary>
            /// Enum value "ColorfulGridAccent3"
            /// </summary>
            ColorfulGridAccent3,

            /// <summary>
            /// Enum value "LightShadingAccent4"
            /// </summary>
            LightShadingAccent4,

            /// <summary>
            /// Enum value "LightListAccent4"
            /// </summary>
            LightListAccent4,

            /// <summary>
            /// Enum value "LightGridAccent4"
            /// </summary>
            LightGridAccent4,

            /// <summary>
            /// Enum value "MediumShading1Accent4"
            /// </summary>
            MediumShading1Accent4,

            /// <summary>
            /// Enum value "MediumShading2Accent4"
            /// </summary>
            MediumShading2Accent4,

            /// <summary>
            /// Enum value "MediumList1Accent4"
            /// </summary>
            MediumList1Accent4,

            /// <summary>
            /// Enum value "MediumList2Accent4"
            /// </summary>
            MediumList2Accent4,

            /// <summary>
            /// Enum value "MediumGrid1Accent4"
            /// </summary>
            MediumGrid1Accent4,

            /// <summary>
            /// Enum value "MediumGrid2Accent4"
            /// </summary>
            MediumGrid2Accent4,

            /// <summary>
            /// Enum value "MediumGrid3Accent4"
            /// </summary>
            MediumGrid3Accent4,

            /// <summary>
            /// Enum value "DarkListAccent4"
            /// </summary>
            DarkListAccent4,

            /// <summary>
            /// Enum value "ColorfulShadingAccent4"
            /// </summary>
            ColorfulShadingAccent4,

            /// <summary>
            /// Enum value "ColorfulListAccent4"
            /// </summary>
            ColorfulListAccent4,

            /// <summary>
            /// Enum value "ColorfulGridAccent4"
            /// </summary>
            ColorfulGridAccent4,

            /// <summary>
            /// Enum value "LightShadingAccent5"
            /// </summary>
            LightShadingAccent5,

            /// <summary>
            /// Enum value "LightListAccent5"
            /// </summary>
            LightListAccent5,

            /// <summary>
            /// Enum value "LightGridAccent5"
            /// </summary>
            LightGridAccent5,

            /// <summary>
            /// Enum value "MediumShading1Accent5"
            /// </summary>
            MediumShading1Accent5,

            /// <summary>
            /// Enum value "MediumShading2Accent5"
            /// </summary>
            MediumShading2Accent5,

            /// <summary>
            /// Enum value "MediumList1Accent5"
            /// </summary>
            MediumList1Accent5,

            /// <summary>
            /// Enum value "MediumList2Accent5"
            /// </summary>
            MediumList2Accent5,

            /// <summary>
            /// Enum value "MediumGrid1Accent5"
            /// </summary>
            MediumGrid1Accent5,

            /// <summary>
            /// Enum value "MediumGrid2Accent5"
            /// </summary>
            MediumGrid2Accent5,

            /// <summary>
            /// Enum value "MediumGrid3Accent5"
            /// </summary>
            MediumGrid3Accent5,

            /// <summary>
            /// Enum value "DarkListAccent5"
            /// </summary>
            DarkListAccent5,

            /// <summary>
            /// Enum value "ColorfulShadingAccent5"
            /// </summary>
            ColorfulShadingAccent5,

            /// <summary>
            /// Enum value "ColorfulListAccent5"
            /// </summary>
            ColorfulListAccent5,

            /// <summary>
            /// Enum value "ColorfulGridAccent5"
            /// </summary>
            ColorfulGridAccent5,

            /// <summary>
            /// Enum value "LightShadingAccent6"
            /// </summary>
            LightShadingAccent6,

            /// <summary>
            /// Enum value "LightListAccent6"
            /// </summary>
            LightListAccent6,

            /// <summary>
            /// Enum value "LightGridAccent6"
            /// </summary>
            LightGridAccent6,

            /// <summary>
            /// Enum value "MediumShading1Accent6"
            /// </summary>
            MediumShading1Accent6,

            /// <summary>
            /// Enum value "MediumShading2Accent6"
            /// </summary>
            MediumShading2Accent6,

            /// <summary>
            /// Enum value "MediumList1Accent6"
            /// </summary>
            MediumList1Accent6,

            /// <summary>
            /// Enum value "MediumList2Accent6"
            /// </summary>
            MediumList2Accent6,

            /// <summary>
            /// Enum value "MediumGrid1Accent6"
            /// </summary>
            MediumGrid1Accent6,

            /// <summary>
            /// Enum value "MediumGrid2Accent6"
            /// </summary>
            MediumGrid2Accent6,

            /// <summary>
            /// Enum value "MediumGrid3Accent6"
            /// </summary>
            MediumGrid3Accent6,

            /// <summary>
            /// Enum value "DarkListAccent6"
            /// </summary>
            DarkListAccent6,

            /// <summary>
            /// Enum value "ColorfulShadingAccent6"
            /// </summary>
            ColorfulShadingAccent6,

            /// <summary>
            /// Enum value "ColorfulListAccent6"
            /// </summary>
            ColorfulListAccent6,

            /// <summary>
            /// Enum value "ColorfulGridAccent6"
            /// </summary>
            ColorfulGridAccent6,

            /// <summary>
            /// Enum value "SubtleEmphasis"
            /// </summary>
            SubtleEmphasis,

            /// <summary>
            /// Enum value "IntenseEmphasis"
            /// </summary>
            IntenseEmphasis,

            /// <summary>
            /// Enum value "SubtleReference"
            /// </summary>
            SubtleReference,

            /// <summary>
            /// Enum value "IntenseReference"
            /// </summary>
            IntenseReference,

            /// <summary>
            /// Enum value "BookTitle"
            /// </summary>
            BookTitle,

            /// <summary>
            /// Enum value "Bibliography"
            /// </summary>
            Bibliography,

            /// <summary>
            /// Enum value "TocHeading"
            /// </summary>
            TocHeading,

            /// <summary>
            /// Enum value "PlainTable1"
            /// </summary>
            PlainTable1,

            /// <summary>
            /// Enum value "PlainTable2"
            /// </summary>
            PlainTable2,

            /// <summary>
            /// Enum value "PlainTable3"
            /// </summary>
            PlainTable3,

            /// <summary>
            /// Enum value "PlainTable4"
            /// </summary>
            PlainTable4,

            /// <summary>
            /// Enum value "PlainTable5"
            /// </summary>
            PlainTable5,

            /// <summary>
            /// Enum value "TableGridLight"
            /// </summary>
            TableGridLight,

            /// <summary>
            /// Enum value "GridTable1Light"
            /// </summary>
            GridTable1Light,

            /// <summary>
            /// Enum value "GridTable2"
            /// </summary>
            GridTable2,

            /// <summary>
            /// Enum value "GridTable3"
            /// </summary>
            GridTable3,

            /// <summary>
            /// Enum value "GridTable4"
            /// </summary>
            GridTable4,

            /// <summary>
            /// Enum value "GridTable5Dark"
            /// </summary>
            GridTable5Dark,

            /// <summary>
            /// Enum value "GridTable6Colorful"
            /// </summary>
            GridTable6Colorful,

            /// <summary>
            /// Enum value "GridTable7Colorful"
            /// </summary>
            GridTable7Colorful,

            /// <summary>
            /// Enum value "GridTable1LightAccent1"
            /// </summary>
            GridTable1LightAccent1,

            /// <summary>
            /// Enum value "GridTable2Accent1"
            /// </summary>
            GridTable2Accent1,

            /// <summary>
            /// Enum value "GridTable3Accent1"
            /// </summary>
            GridTable3Accent1,

            /// <summary>
            /// Enum value "GridTable4Accent1"
            /// </summary>
            GridTable4Accent1,

            /// <summary>
            /// Enum value "GridTable5DarkAccent1"
            /// </summary>
            GridTable5DarkAccent1,

            /// <summary>
            /// Enum value "GridTable6ColorfulAccent1"
            /// </summary>
            GridTable6ColorfulAccent1,

            /// <summary>
            /// Enum value "GridTable7ColorfulAccent1"
            /// </summary>
            GridTable7ColorfulAccent1,

            /// <summary>
            /// Enum value "GridTable1LightAccent2"
            /// </summary>
            GridTable1LightAccent2,

            /// <summary>
            /// Enum value "GridTable2Accent2"
            /// </summary>
            GridTable2Accent2,

            /// <summary>
            /// Enum value "GridTable3Accent2"
            /// </summary>
            GridTable3Accent2,

            /// <summary>
            /// Enum value "GridTable4Accent2"
            /// </summary>
            GridTable4Accent2,

            /// <summary>
            /// Enum value "GridTable5DarkAccent2"
            /// </summary>
            GridTable5DarkAccent2,

            /// <summary>
            /// Enum value "GridTable6ColorfulAccent2"
            /// </summary>
            GridTable6ColorfulAccent2,

            /// <summary>
            /// Enum value "GridTable7ColorfulAccent2"
            /// </summary>
            GridTable7ColorfulAccent2,

            /// <summary>
            /// Enum value "GridTable1LightAccent3"
            /// </summary>
            GridTable1LightAccent3,

            /// <summary>
            /// Enum value "GridTable2Accent3"
            /// </summary>
            GridTable2Accent3,

            /// <summary>
            /// Enum value "GridTable3Accent3"
            /// </summary>
            GridTable3Accent3,

            /// <summary>
            /// Enum value "GridTable4Accent3"
            /// </summary>
            GridTable4Accent3,

            /// <summary>
            /// Enum value "GridTable5DarkAccent3"
            /// </summary>
            GridTable5DarkAccent3,

            /// <summary>
            /// Enum value "GridTable6ColorfulAccent3"
            /// </summary>
            GridTable6ColorfulAccent3,

            /// <summary>
            /// Enum value "GridTable7ColorfulAccent3"
            /// </summary>
            GridTable7ColorfulAccent3,

            /// <summary>
            /// Enum value "GridTable1LightAccent4"
            /// </summary>
            GridTable1LightAccent4,

            /// <summary>
            /// Enum value "GridTable2Accent4"
            /// </summary>
            GridTable2Accent4,

            /// <summary>
            /// Enum value "GridTable3Accent4"
            /// </summary>
            GridTable3Accent4,

            /// <summary>
            /// Enum value "GridTable4Accent4"
            /// </summary>
            GridTable4Accent4,

            /// <summary>
            /// Enum value "GridTable5DarkAccent4"
            /// </summary>
            GridTable5DarkAccent4,

            /// <summary>
            /// Enum value "GridTable6ColorfulAccent4"
            /// </summary>
            GridTable6ColorfulAccent4,

            /// <summary>
            /// Enum value "GridTable7ColorfulAccent4"
            /// </summary>
            GridTable7ColorfulAccent4,

            /// <summary>
            /// Enum value "GridTable1LightAccent5"
            /// </summary>
            GridTable1LightAccent5,

            /// <summary>
            /// Enum value "GridTable2Accent5"
            /// </summary>
            GridTable2Accent5,

            /// <summary>
            /// Enum value "GridTable3Accent5"
            /// </summary>
            GridTable3Accent5,

            /// <summary>
            /// Enum value "GridTable4Accent5"
            /// </summary>
            GridTable4Accent5,

            /// <summary>
            /// Enum value "GridTable5DarkAccent5"
            /// </summary>
            GridTable5DarkAccent5,

            /// <summary>
            /// Enum value "GridTable6ColorfulAccent5"
            /// </summary>
            GridTable6ColorfulAccent5,

            /// <summary>
            /// Enum value "GridTable7ColorfulAccent5"
            /// </summary>
            GridTable7ColorfulAccent5,

            /// <summary>
            /// Enum value "GridTable1LightAccent6"
            /// </summary>
            GridTable1LightAccent6,

            /// <summary>
            /// Enum value "GridTable2Accent6"
            /// </summary>
            GridTable2Accent6,

            /// <summary>
            /// Enum value "GridTable3Accent6"
            /// </summary>
            GridTable3Accent6,

            /// <summary>
            /// Enum value "GridTable4Accent6"
            /// </summary>
            GridTable4Accent6,

            /// <summary>
            /// Enum value "GridTable5DarkAccent6"
            /// </summary>
            GridTable5DarkAccent6,

            /// <summary>
            /// Enum value "GridTable6ColorfulAccent6"
            /// </summary>
            GridTable6ColorfulAccent6,

            /// <summary>
            /// Enum value "GridTable7ColorfulAccent6"
            /// </summary>
            GridTable7ColorfulAccent6,

            /// <summary>
            /// Enum value "ListTable1Light"
            /// </summary>
            ListTable1Light,

            /// <summary>
            /// Enum value "ListTable2"
            /// </summary>
            ListTable2,

            /// <summary>
            /// Enum value "ListTable3"
            /// </summary>
            ListTable3,

            /// <summary>
            /// Enum value "ListTable4"
            /// </summary>
            ListTable4,

            /// <summary>
            /// Enum value "ListTable5Dark"
            /// </summary>
            ListTable5Dark,

            /// <summary>
            /// Enum value "ListTable6Colorful"
            /// </summary>
            ListTable6Colorful,

            /// <summary>
            /// Enum value "ListTable7Colorful"
            /// </summary>
            ListTable7Colorful,

            /// <summary>
            /// Enum value "ListTable1LightAccent1"
            /// </summary>
            ListTable1LightAccent1,

            /// <summary>
            /// Enum value "ListTable2Accent1"
            /// </summary>
            ListTable2Accent1,

            /// <summary>
            /// Enum value "ListTable3Accent1"
            /// </summary>
            ListTable3Accent1,

            /// <summary>
            /// Enum value "ListTable4Accent1"
            /// </summary>
            ListTable4Accent1,

            /// <summary>
            /// Enum value "ListTable5DarkAccent1"
            /// </summary>
            ListTable5DarkAccent1,

            /// <summary>
            /// Enum value "ListTable6ColorfulAccent1"
            /// </summary>
            ListTable6ColorfulAccent1,

            /// <summary>
            /// Enum value "ListTable7ColorfulAccent1"
            /// </summary>
            ListTable7ColorfulAccent1,

            /// <summary>
            /// Enum value "ListTable1LightAccent2"
            /// </summary>
            ListTable1LightAccent2,

            /// <summary>
            /// Enum value "ListTable2Accent2"
            /// </summary>
            ListTable2Accent2,

            /// <summary>
            /// Enum value "ListTable3Accent2"
            /// </summary>
            ListTable3Accent2,

            /// <summary>
            /// Enum value "ListTable4Accent2"
            /// </summary>
            ListTable4Accent2,

            /// <summary>
            /// Enum value "ListTable5DarkAccent2"
            /// </summary>
            ListTable5DarkAccent2,

            /// <summary>
            /// Enum value "ListTable6ColorfulAccent2"
            /// </summary>
            ListTable6ColorfulAccent2,

            /// <summary>
            /// Enum value "ListTable7ColorfulAccent2"
            /// </summary>
            ListTable7ColorfulAccent2,

            /// <summary>
            /// Enum value "ListTable1LightAccent3"
            /// </summary>
            ListTable1LightAccent3,

            /// <summary>
            /// Enum value "ListTable2Accent3"
            /// </summary>
            ListTable2Accent3,

            /// <summary>
            /// Enum value "ListTable3Accent3"
            /// </summary>
            ListTable3Accent3,

            /// <summary>
            /// Enum value "ListTable4Accent3"
            /// </summary>
            ListTable4Accent3,

            /// <summary>
            /// Enum value "ListTable5DarkAccent3"
            /// </summary>
            ListTable5DarkAccent3,

            /// <summary>
            /// Enum value "ListTable6ColorfulAccent3"
            /// </summary>
            ListTable6ColorfulAccent3,

            /// <summary>
            /// Enum value "ListTable7ColorfulAccent3"
            /// </summary>
            ListTable7ColorfulAccent3,

            /// <summary>
            /// Enum value "ListTable1LightAccent4"
            /// </summary>
            ListTable1LightAccent4,

            /// <summary>
            /// Enum value "ListTable2Accent4"
            /// </summary>
            ListTable2Accent4,

            /// <summary>
            /// Enum value "ListTable3Accent4"
            /// </summary>
            ListTable3Accent4,

            /// <summary>
            /// Enum value "ListTable4Accent4"
            /// </summary>
            ListTable4Accent4,

            /// <summary>
            /// Enum value "ListTable5DarkAccent4"
            /// </summary>
            ListTable5DarkAccent4,

            /// <summary>
            /// Enum value "ListTable6ColorfulAccent4"
            /// </summary>
            ListTable6ColorfulAccent4,

            /// <summary>
            /// Enum value "ListTable7ColorfulAccent4"
            /// </summary>
            ListTable7ColorfulAccent4,

            /// <summary>
            /// Enum value "ListTable1LightAccent5"
            /// </summary>
            ListTable1LightAccent5,

            /// <summary>
            /// Enum value "ListTable2Accent5"
            /// </summary>
            ListTable2Accent5,

            /// <summary>
            /// Enum value "ListTable3Accent5"
            /// </summary>
            ListTable3Accent5,

            /// <summary>
            /// Enum value "ListTable4Accent5"
            /// </summary>
            ListTable4Accent5,

            /// <summary>
            /// Enum value "ListTable5DarkAccent5"
            /// </summary>
            ListTable5DarkAccent5,

            /// <summary>
            /// Enum value "ListTable6ColorfulAccent5"
            /// </summary>
            ListTable6ColorfulAccent5,

            /// <summary>
            /// Enum value "ListTable7ColorfulAccent5"
            /// </summary>
            ListTable7ColorfulAccent5,

            /// <summary>
            /// Enum value "ListTable1LightAccent6"
            /// </summary>
            ListTable1LightAccent6,

            /// <summary>
            /// Enum value "ListTable2Accent6"
            /// </summary>
            ListTable2Accent6,

            /// <summary>
            /// Enum value "ListTable3Accent6"
            /// </summary>
            ListTable3Accent6,

            /// <summary>
            /// Enum value "ListTable4Accent6"
            /// </summary>
            ListTable4Accent6,

            /// <summary>
            /// Enum value "ListTable5DarkAccent6"
            /// </summary>
            ListTable5DarkAccent6,

            /// <summary>
            /// Enum value "ListTable6ColorfulAccent6"
            /// </summary>
            ListTable6ColorfulAccent6,

            /// <summary>
            /// Enum value "ListTable7ColorfulAccent6"
            /// </summary>
            ListTable7ColorfulAccent6,

            /// <summary>
            /// Enum value "SmartLink"
            /// </summary>
            SmartLink,

            /// <summary>
            /// Enum value "Mention"
            /// </summary>
            Mention,

            /// <summary>
            /// Enum value "SmartHyperlink"
            /// </summary>
            SmartHyperlink,

            /// <summary>
            /// Enum value "Hashtag"
            /// </summary>
            Hashtag,

            /// <summary>
            /// Enum value "UnresolvedMention"
            /// </summary>
            UnresolvedMention,

            /// <summary>
            /// Enum value "User"
            /// </summary>
            User,

            /// <summary>
            /// Enum value "Nil"
            /// </summary>
            Nil,
        }

        /// <summary>
        /// Gets or sets a value indicating whether inter-character spacing is automatically adjusted between regions of Latin text and regions of East Asian text in the current paragraph.
        /// </summary>
        public virtual bool? AddSpaceBetweenFarEastAndAlpha { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether inter-character spacing is automatically adjusted between regions of numbers and regions of East Asian text in the current paragraph.
        /// </summary>
        public virtual bool? AddSpaceBetweenFarEastAndDigit { get; set; }

        /// <summary>
        /// Gets or sets text alignment for the paragraph.
        /// </summary>
        public virtual AlignmentEnum? Alignment { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is a right-to-left paragraph.
        /// </summary>
        public virtual bool? Bidi { get; set; }

        /// <summary>
        /// Gets or sets the position for a drop cap text.
        /// </summary>
        public virtual DropCapPositionEnum? DropCapPosition { get; set; }

        /// <summary>
        /// Gets or sets the value (in points) for a first line or hanging indent.
        /// Use a positive value to set a first-line indent, and use a negative value to set a hanging indent.
        /// </summary>
        public virtual double? FirstLineIndent { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether all lines in the paragraph are to remain on the same page.
        /// </summary>
        public virtual bool? KeepTogether { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the paragraph is to remains on the same page as the paragraph that follows it.
        /// </summary>
        public virtual bool? KeepWithNext { get; set; }

        /// <summary>
        /// Gets or sets the value (in points), that represents the left indent for paragraph.
        /// </summary>
        public virtual double? LeftIndent { get; set; }

        /// <summary>
        /// Gets or sets the line spacing (in points) for the paragraph.
        /// </summary>
        public virtual double? LineSpacing { get; set; }

        /// <summary>
        /// Gets or sets the line spacing for the paragraph.
        /// </summary>
        public virtual LineSpacingRuleEnum? LineSpacingRule { get; set; }

        /// <summary>
        /// Gets or sets the number of lines of the paragraph text used to calculate the drop cap height.
        /// </summary>
        public virtual int? LinesToDrop { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether SpaceBefore and SpaceAfter will be ignored between the paragraphs of the same style.
        /// </summary>
        public virtual bool? NoSpaceBetweenParagraphsOfSameStyle { get; set; }

        /// <summary>
        /// Gets or sets the outline level of the paragraph in the document.
        /// </summary>
        public virtual OutlineLevelEnum? OutlineLevel { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a page break is forced before the paragraph.
        /// </summary>
        public virtual bool? PageBreakBefore { get; set; }

        /// <summary>
        /// Gets or sets the value (in points) that represents the right indent for paragraph.
        /// </summary>
        public virtual double? RightIndent { get; set; }

        /// <summary>
        /// Gets or sets the amount of spacing (in points) after the paragraph.
        /// </summary>
        public virtual double? SpaceAfter { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the amount of spacing after the paragraph is set automatically.
        /// </summary>
        public virtual bool? SpaceAfterAuto { get; set; }

        /// <summary>
        /// Gets or sets the amount of spacing (in points) before the paragraph.
        /// </summary>
        public virtual double? SpaceBefore { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the amount of spacing before the paragraph is set automatically.
        /// </summary>
        public virtual bool? SpaceBeforeAuto { get; set; }

        /// <summary>
        /// Gets or sets the locale independent style identifier of the paragraph style applied to this formatting.
        /// </summary>
        public virtual StyleIdentifierEnum? StyleIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the name of the paragraph style applied to this formatting.
        /// </summary>
        public virtual string StyleName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the current paragraph should be exempted from any hyphenation which is applied in the document settings.
        /// </summary>
        public virtual bool? SuppressAutoHyphens { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the current paragraph's lines should be exempted from line numbering which is applied in the parent section.
        /// </summary>
        public virtual bool? SuppressLineNumbers { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the first and last lines in the paragraph are to remain on the same page as the rest of the paragraph.
        /// </summary>
        public virtual bool? WidowControl { get; set; }

        /// <summary>
        /// Gets or sets the Shading object, that refers to the shading formatting for the paragraph.
        /// </summary>
        public virtual Shading Shading { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParagraphFormatBase {\n");
            sb.Append("  Link: ").Append(this.Link).Append("\n");
            sb.Append("  AddSpaceBetweenFarEastAndAlpha: ").Append(this.AddSpaceBetweenFarEastAndAlpha).Append("\n");
            sb.Append("  AddSpaceBetweenFarEastAndDigit: ").Append(this.AddSpaceBetweenFarEastAndDigit).Append("\n");
            sb.Append("  Alignment: ").Append(this.Alignment).Append("\n");
            sb.Append("  Bidi: ").Append(this.Bidi).Append("\n");
            sb.Append("  DropCapPosition: ").Append(this.DropCapPosition).Append("\n");
            sb.Append("  FirstLineIndent: ").Append(this.FirstLineIndent).Append("\n");
            sb.Append("  KeepTogether: ").Append(this.KeepTogether).Append("\n");
            sb.Append("  KeepWithNext: ").Append(this.KeepWithNext).Append("\n");
            sb.Append("  LeftIndent: ").Append(this.LeftIndent).Append("\n");
            sb.Append("  LineSpacing: ").Append(this.LineSpacing).Append("\n");
            sb.Append("  LineSpacingRule: ").Append(this.LineSpacingRule).Append("\n");
            sb.Append("  LinesToDrop: ").Append(this.LinesToDrop).Append("\n");
            sb.Append("  NoSpaceBetweenParagraphsOfSameStyle: ").Append(this.NoSpaceBetweenParagraphsOfSameStyle).Append("\n");
            sb.Append("  OutlineLevel: ").Append(this.OutlineLevel).Append("\n");
            sb.Append("  PageBreakBefore: ").Append(this.PageBreakBefore).Append("\n");
            sb.Append("  RightIndent: ").Append(this.RightIndent).Append("\n");
            sb.Append("  SpaceAfter: ").Append(this.SpaceAfter).Append("\n");
            sb.Append("  SpaceAfterAuto: ").Append(this.SpaceAfterAuto).Append("\n");
            sb.Append("  SpaceBefore: ").Append(this.SpaceBefore).Append("\n");
            sb.Append("  SpaceBeforeAuto: ").Append(this.SpaceBeforeAuto).Append("\n");
            sb.Append("  StyleIdentifier: ").Append(this.StyleIdentifier).Append("\n");
            sb.Append("  StyleName: ").Append(this.StyleName).Append("\n");
            sb.Append("  SuppressAutoHyphens: ").Append(this.SuppressAutoHyphens).Append("\n");
            sb.Append("  SuppressLineNumbers: ").Append(this.SuppressLineNumbers).Append("\n");
            sb.Append("  WidowControl: ").Append(this.WidowControl).Append("\n");
            sb.Append("  Shading: ").Append(this.Shading).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
