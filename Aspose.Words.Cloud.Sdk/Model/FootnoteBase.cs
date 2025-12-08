// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FootnoteBase.cs">
//   Copyright (c) 2025 Aspose.Words for Cloud
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
    /// Footnote base class.
    /// </summary>
    public abstract class FootnoteBase : IModel
    {
        /// <summary>
        /// Gets or sets the option, that specifies whether this is a footnote or endnote.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FootnoteTypeEnum
        {
            /// <summary>
            /// Enum value "Footnote"
            /// </summary>
            Footnote,

            /// <summary>
            /// Enum value "Endnote"
            /// </summary>
            Endnote,
        }

        /// <summary>
        /// Gets or sets the link to range start node.
        /// </summary>
        public virtual Position Position { get; set; }

        /// <summary>
        /// Gets or sets the option, that specifies whether this is a footnote or endnote.
        /// </summary>
        public virtual FootnoteTypeEnum? FootnoteType { get; set; }

        /// <summary>
        /// Gets or sets the custom reference mark to be used for this footnote.
        /// The default value is Empty, meaning auto-numbered footnotes are used.
        /// RTF-format can only store 1 symbol as custom reference mark, so upon export only the first symbol will be written others will be discard.
        /// </summary>
        public virtual string ReferenceMark { get; set; }

        /// <summary>
        /// Gets or sets text of the footnote.
        /// This method allows to quickly set text of a footnote from a string. The string can contain paragraph breaks, this will create paragraphs of text in the footnote accordingly.
        /// </summary>
        public virtual string Text { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public virtual void Validate()
        {

            this.Position?.Validate();




        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FootnoteBase {\n");
            sb.Append("  Position: ").Append(this.Position).Append("\n");
            sb.Append("  FootnoteType: ").Append(this.FootnoteType).Append("\n");
            sb.Append("  ReferenceMark: ").Append(this.ReferenceMark).Append("\n");
            sb.Append("  Text: ").Append(this.Text).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
