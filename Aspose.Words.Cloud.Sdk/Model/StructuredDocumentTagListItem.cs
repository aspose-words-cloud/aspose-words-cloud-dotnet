// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StructuredDocumentTagListItem.cs">
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
    /// DTO container with a SdtListItem for StructuredDocumentTag.
    /// </summary>
    public class StructuredDocumentTagListItem : IModel
    {
        /// <summary>
        /// Gets or sets the text to display in the run content in place of the Aspose.Words.Markup.SdtListItem.Value attribute contents for this list item.
        /// Cannot be null and cannot be an empty string.
        /// </summary>
        public virtual string DisplayText { get; set; }

        /// <summary>
        /// Gets or sets the value of this list item.
        /// Cannot be null and cannot be an empty string.
        /// </summary>
        public virtual string Value { get; set; }


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
            sb.Append("class StructuredDocumentTagListItem {\n");
            sb.Append("  DisplayText: ").Append(this.DisplayText).Append("\n");
            sb.Append("  Value: ").Append(this.Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
