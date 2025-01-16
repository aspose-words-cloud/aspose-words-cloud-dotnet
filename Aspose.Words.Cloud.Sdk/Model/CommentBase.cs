// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CommentBase.cs">
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
    /// Comment.
    /// </summary>
    public abstract class CommentBase : IModel
    {
        /// <summary>
        /// Gets or sets the link to comment range start node.
        /// </summary>
        public virtual PositionInsideNode RangeStart { get; set; }

        /// <summary>
        /// Gets or sets the link to comment range end node.
        /// </summary>
        public virtual PositionInsideNode RangeEnd { get; set; }

        /// <summary>
        /// Gets or sets the author name for a comment.
        /// Cannot be null.Default is empty string.
        /// </summary>
        public virtual string Author { get; set; }

        /// <summary>
        /// Gets or sets the initials of the user associated with a specific comment.
        /// Cannot be null.Default is empty string.
        /// </summary>
        public virtual string Initial { get; set; }

        /// <summary>
        /// Gets or sets the date and time that the comment was made.
        /// Default is MinValue03.01.0001.
        /// </summary>
        public virtual DateTime? DateTime { get; set; }

        /// <summary>
        /// Gets or sets text of the comment.
        /// This method allows to quickly set text of a comment from a string. The string can contain paragraph breaks, this will create paragraphs of text in the comment accordingly.
        /// </summary>
        public virtual string Text { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public virtual void Validate()
        {
            if (this.RangeStart == null)
            {
                throw new ArgumentException("Property RangeStart in CommentBase is required.");
            }
            if (this.RangeEnd == null)
            {
                throw new ArgumentException("Property RangeEnd in CommentBase is required.");
            }
            if (this.Author == null)
            {
                throw new ArgumentException("Property Author in CommentBase is required.");
            }
            if (this.Initial == null)
            {
                throw new ArgumentException("Property Initial in CommentBase is required.");
            }
            if (this.Text == null)
            {
                throw new ArgumentException("Property Text in CommentBase is required.");
            }

            this.RangeStart?.Validate();



            this.RangeEnd?.Validate();





        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommentBase {\n");
            sb.Append("  RangeStart: ").Append(this.RangeStart).Append("\n");
            sb.Append("  RangeEnd: ").Append(this.RangeEnd).Append("\n");
            sb.Append("  Author: ").Append(this.Author).Append("\n");
            sb.Append("  Initial: ").Append(this.Initial).Append("\n");
            sb.Append("  DateTime: ").Append(this.DateTime).Append("\n");
            sb.Append("  Text: ").Append(this.Text).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
