// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ListFormat.cs">
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
    /// DTO container with a paragraph list format element.
    /// </summary>
    public class ListFormat : LinkElement, IModel
    {
        /// <summary>
        /// Gets or sets the list level number (0 to 8) for the paragraph.
        /// In Word documents, lists may consist of 1 or 9 levels, numbered 0 to 8. Has effect only when the Aspose.Words.ListFormat.List property is set to reference a valid list. Aspose.Words.ListFormat.List.
        /// </summary>
        public virtual int? ListLevelNumber { get; set; }

        /// <summary>
        /// Gets or sets the list id of this paragraph.
        /// The list that is being assigned to this property must belong to the current document.The list that is being assigned to this property must not be a list style definition.
        /// </summary>
        public virtual int? ListId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the paragraph has bulleted or numbered formatting applied to it.
        /// </summary>
        public virtual bool? IsListItem { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (this.ListLevelNumber == null)
            {
                throw new ArgumentException("Property ListLevelNumber in ListFormat is required.");
            }
            if (this.IsListItem == null)
            {
                throw new ArgumentException("Property IsListItem in ListFormat is required.");
            }
        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFormat {\n");
            sb.Append("  Link: ").Append(this.Link).Append("\n");
            sb.Append("  ListLevelNumber: ").Append(this.ListLevelNumber).Append("\n");
            sb.Append("  ListId: ").Append(this.ListId).Append("\n");
            sb.Append("  IsListItem: ").Append(this.IsListItem).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
