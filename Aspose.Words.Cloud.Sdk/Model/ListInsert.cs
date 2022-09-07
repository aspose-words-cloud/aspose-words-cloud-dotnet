// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ListInsert.cs">
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
    /// Insert document to document list.
    /// </summary>
    public class ListInsert : IModel
    {
        /// <summary>
        /// Gets or sets the option that controls how list should be restarted at each section.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TemplateEnum
        {
            /// <summary>
            /// Enum value "BulletDefault"
            /// </summary>
            BulletDefault,

            /// <summary>
            /// Enum value "BulletDisk"
            /// </summary>
            BulletDisk,

            /// <summary>
            /// Enum value "BulletCircle"
            /// </summary>
            BulletCircle,

            /// <summary>
            /// Enum value "BulletSquare"
            /// </summary>
            BulletSquare,

            /// <summary>
            /// Enum value "BulletDiamonds"
            /// </summary>
            BulletDiamonds,

            /// <summary>
            /// Enum value "BulletArrowHead"
            /// </summary>
            BulletArrowHead,

            /// <summary>
            /// Enum value "BulletTick"
            /// </summary>
            BulletTick,

            /// <summary>
            /// Enum value "NumberDefault"
            /// </summary>
            NumberDefault,

            /// <summary>
            /// Enum value "NumberArabicDot"
            /// </summary>
            NumberArabicDot,

            /// <summary>
            /// Enum value "NumberArabicParenthesis"
            /// </summary>
            NumberArabicParenthesis,

            /// <summary>
            /// Enum value "NumberUppercaseRomanDot"
            /// </summary>
            NumberUppercaseRomanDot,

            /// <summary>
            /// Enum value "NumberUppercaseLetterDot"
            /// </summary>
            NumberUppercaseLetterDot,

            /// <summary>
            /// Enum value "NumberLowercaseLetterParenthesis"
            /// </summary>
            NumberLowercaseLetterParenthesis,

            /// <summary>
            /// Enum value "NumberLowercaseLetterDot"
            /// </summary>
            NumberLowercaseLetterDot,

            /// <summary>
            /// Enum value "NumberLowercaseRomanDot"
            /// </summary>
            NumberLowercaseRomanDot,

            /// <summary>
            /// Enum value "OutlineNumbers"
            /// </summary>
            OutlineNumbers,

            /// <summary>
            /// Enum value "OutlineLegal"
            /// </summary>
            OutlineLegal,

            /// <summary>
            /// Enum value "OutlineBullets"
            /// </summary>
            OutlineBullets,

            /// <summary>
            /// Enum value "OutlineHeadingsArticleSection"
            /// </summary>
            OutlineHeadingsArticleSection,

            /// <summary>
            /// Enum value "OutlineHeadingsLegal"
            /// </summary>
            OutlineHeadingsLegal,

            /// <summary>
            /// Enum value "OutlineHeadingsNumbers"
            /// </summary>
            OutlineHeadingsNumbers,

            /// <summary>
            /// Enum value "OutlineHeadingsChapter"
            /// </summary>
            OutlineHeadingsChapter,
        }

        /// <summary>
        /// Gets or sets the option that controls how list should be restarted at each section.
        /// </summary>
        public virtual TemplateEnum Template { get; set; }



        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInsert {\n");
            sb.Append("  Template: ").Append(this.Template).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
