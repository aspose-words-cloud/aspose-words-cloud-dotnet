// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CompareOptions.cs">
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
    /// DTO container with compare documents options.
    /// </summary>
    public class CompareOptions : IModel
    {
        /// <summary>
        /// Gets or sets the option that controls which document shall be used as a target during comparison.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TargetEnum
        {
            /// <summary>
            /// Enum value "Current"
            /// </summary>
            Current,

            /// <summary>
            /// Enum value "New"
            /// </summary>
            New,
        }

        /// <summary>
        /// Gets or sets whether accept revisions before comparison or not.
        /// </summary>
        public virtual bool? AcceptAllRevisionsBeforeComparison { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether documents comparison is case insensitive. By default comparison is case sensitive.
        /// </summary>
        public virtual bool? IgnoreCaseChanges { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether comments content is ignored. By default comments are not ignored.
        /// </summary>
        public virtual bool? IgnoreComments { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether fields content is ignored. By default fields are not ignored.
        /// </summary>
        public virtual bool? IgnoreFields { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether footnotes/endnotes content is ignored. By default footnotes/endnotes are not ignored.
        /// </summary>
        public virtual bool? IgnoreFootnotes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether formatting is ignored. By default document formatting is not ignored.
        /// </summary>
        public virtual bool? IgnoreFormatting { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether headers and footers content is ignored. By default headers and footers are not ignored.
        /// </summary>
        public virtual bool? IgnoreHeadersAndFooters { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether tables content is ignored. By default tables are not ignored.
        /// </summary>
        public virtual bool? IgnoreTables { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether textboxes content is ignored. By default textboxes are not ignored.
        /// </summary>
        public virtual bool? IgnoreTextboxes { get; set; }

        /// <summary>
        /// Gets or sets the option that controls which document shall be used as a target during comparison.
        /// </summary>
        public virtual TargetEnum? Target { get; set; }


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
            sb.Append("class CompareOptions {\n");
            sb.Append("  AcceptAllRevisionsBeforeComparison: ").Append(this.AcceptAllRevisionsBeforeComparison).Append("\n");
            sb.Append("  IgnoreCaseChanges: ").Append(this.IgnoreCaseChanges).Append("\n");
            sb.Append("  IgnoreComments: ").Append(this.IgnoreComments).Append("\n");
            sb.Append("  IgnoreFields: ").Append(this.IgnoreFields).Append("\n");
            sb.Append("  IgnoreFootnotes: ").Append(this.IgnoreFootnotes).Append("\n");
            sb.Append("  IgnoreFormatting: ").Append(this.IgnoreFormatting).Append("\n");
            sb.Append("  IgnoreHeadersAndFooters: ").Append(this.IgnoreHeadersAndFooters).Append("\n");
            sb.Append("  IgnoreTables: ").Append(this.IgnoreTables).Append("\n");
            sb.Append("  IgnoreTextboxes: ").Append(this.IgnoreTextboxes).Append("\n");
            sb.Append("  Target: ").Append(this.Target).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
