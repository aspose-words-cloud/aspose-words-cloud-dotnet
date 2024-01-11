// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BookmarkInsert.cs">
//   Copyright (c) 2024 Aspose.Words for Cloud
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
    /// Represents a bookmark to insert.
    /// </summary>
    public class BookmarkInsert : IModel
    {
        /// <summary>
        /// Gets or sets the name of the bookmark.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets text, enclosed in the bookmark.
        /// </summary>
        public virtual string Text { get; set; }

        /// <summary>
        /// Gets or sets the link to start bookmark node.
        /// </summary>
        public virtual Position StartRange { get; set; }

        /// <summary>
        /// Gets or sets the link to end bookmark node.
        /// </summary>
        public virtual Position EndRange { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Name == null)
            {
                throw new ArgumentException("Property Name in BookmarkInsert is required.");
            }
            if (this.Text == null)
            {
                throw new ArgumentException("Property Text in BookmarkInsert is required.");
            }
            if (this.StartRange == null)
            {
                throw new ArgumentException("Property StartRange in BookmarkInsert is required.");
            }
            if (this.EndRange == null)
            {
                throw new ArgumentException("Property EndRange in BookmarkInsert is required.");
            }

            this.StartRange?.Validate();



            this.EndRange?.Validate();

        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BookmarkInsert {\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Text: ").Append(this.Text).Append("\n");
            sb.Append("  StartRange: ").Append(this.StartRange).Append("\n");
            sb.Append("  EndRange: ").Append(this.EndRange).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
