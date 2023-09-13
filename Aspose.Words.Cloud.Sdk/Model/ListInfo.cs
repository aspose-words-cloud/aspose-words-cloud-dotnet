// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ListInfo.cs">
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
    /// DTO container with a single document list.
    /// </summary>
    public class ListInfo : LinkElement, IModel
    {
        /// <summary>
        /// Gets or sets the unique identifier of the list.
        /// </summary>
        public virtual int ListId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the list contains 9 levels; false when 1 level.
        /// </summary>
        public virtual bool IsMultiLevel { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether list should be restarted at each section. The default value is false.
        /// </summary>
        public virtual bool IsRestartAtEachSection { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this list is a definition of a list style.
        /// </summary>
        public virtual bool IsListStyleDefinition { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this list is a reference to a list style.
        /// </summary>
        public virtual bool IsListStyleReference { get; set; }

        /// <summary>
        /// Gets or sets the list style that this list references or defines.
        /// </summary>
        public virtual Style Style { get; set; }

        /// <summary>
        /// Gets or sets the collection of list levels for this list.
        /// </summary>
        public virtual ListLevels ListLevels { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInfo {\n");
            sb.Append("  Link: ").Append(this.Link).Append("\n");
            sb.Append("  ListId: ").Append(this.ListId).Append("\n");
            sb.Append("  IsMultiLevel: ").Append(this.IsMultiLevel).Append("\n");
            sb.Append("  IsRestartAtEachSection: ").Append(this.IsRestartAtEachSection).Append("\n");
            sb.Append("  IsListStyleDefinition: ").Append(this.IsListStyleDefinition).Append("\n");
            sb.Append("  IsListStyleReference: ").Append(this.IsListStyleReference).Append("\n");
            sb.Append("  Style: ").Append(this.Style).Append("\n");
            sb.Append("  ListLevels: ").Append(this.ListLevels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
