// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ParagraphFormat.cs">
//   Copyright (c) 2022 Aspose.Words for Cloud
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
    /// Paragraph format element.
    /// </summary>
    public class ParagraphFormat : ParagraphFormatBase
    {
        /// <summary>
        /// Gets or sets a value indicating whether the paragraph style is one of the built-in Heading styles.
        /// </summary>
        public virtual bool? IsHeading { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the paragraph is an item in a bulleted or numbered list.
        /// </summary>
        public virtual bool? IsListItem { get; set; }



        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParagraphFormat {\n");
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
            sb.Append("  Shading: ").Append(this.Shading).Append("\n");
            sb.Append("  SpaceAfter: ").Append(this.SpaceAfter).Append("\n");
            sb.Append("  SpaceAfterAuto: ").Append(this.SpaceAfterAuto).Append("\n");
            sb.Append("  SpaceBefore: ").Append(this.SpaceBefore).Append("\n");
            sb.Append("  SpaceBeforeAuto: ").Append(this.SpaceBeforeAuto).Append("\n");
            sb.Append("  StyleIdentifier: ").Append(this.StyleIdentifier).Append("\n");
            sb.Append("  StyleName: ").Append(this.StyleName).Append("\n");
            sb.Append("  SuppressAutoHyphens: ").Append(this.SuppressAutoHyphens).Append("\n");
            sb.Append("  SuppressLineNumbers: ").Append(this.SuppressLineNumbers).Append("\n");
            sb.Append("  WidowControl: ").Append(this.WidowControl).Append("\n");
            sb.Append("  IsHeading: ").Append(this.IsHeading).Append("\n");
            sb.Append("  IsListItem: ").Append(this.IsListItem).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
