// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TableRowFormat.cs">
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
    /// DTO container with formatting for a table row.
    /// </summary>
    public class TableRowFormat : LinkElement, IModel
    {
        /// <summary>
        /// Gets or sets the rule for determining the height of the table row.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HeightRuleEnum
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
            /// Enum value "Auto"
            /// </summary>
            Auto,
        }

        /// <summary>
        /// Gets or sets the height of the table row in points.
        /// </summary>
        public virtual double? Height { get; set; }

        /// <summary>
        /// Gets or sets the rule for determining the height of the table row.
        /// </summary>
        public virtual HeightRuleEnum? HeightRule { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the text in a table row is allowed to split across a page break.
        /// </summary>
        public virtual bool? AllowBreakAcrossPages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the row is repeated as a table heading on every page when the table spans more than one page.
        /// </summary>
        public virtual bool? HeadingFormat { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableRowFormat {\n");
            sb.Append("  Link: ").Append(this.Link).Append("\n");
            sb.Append("  Height: ").Append(this.Height).Append("\n");
            sb.Append("  HeightRule: ").Append(this.HeightRule).Append("\n");
            sb.Append("  AllowBreakAcrossPages: ").Append(this.AllowBreakAcrossPages).Append("\n");
            sb.Append("  HeadingFormat: ").Append(this.HeadingFormat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
