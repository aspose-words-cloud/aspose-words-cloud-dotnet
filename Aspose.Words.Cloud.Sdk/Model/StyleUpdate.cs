// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StyleUpdate.cs">
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
    /// Represents a single document style properties to update.
    /// </summary>
    public class StyleUpdate : IModel
    {
        /// <summary>
        /// Gets or sets the name of the style to be applied automatically to a new paragraph inserted after a paragraph formatted with the specified style.
        /// This property is not used by Aspose.Words. The next paragraph style will only be applied automatically when you edit the document in MS Word.
        /// </summary>
        public virtual string NextParagraphStyleName { get; set; }

        /// <summary>
        /// Gets or sets the name of the style this style is based on.
        /// This will be an empty string if the style is not based on any other style and it can be set to an empty string.
        /// </summary>
        public virtual string BaseStyleName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this style is shown in the Quick Style gallery inside MS Word UI.
        /// </summary>
        public virtual bool? IsQuickStyle { get; set; }

        /// <summary>
        /// Gets or sets the name of the style.
        /// Can not be empty string. If there already is a style with such name in the collection, than this style will override it. All affected nodes will reference new style.
        /// </summary>
        public virtual string Name { get; set; }


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
            sb.Append("class StyleUpdate {\n");
            sb.Append("  NextParagraphStyleName: ").Append(this.NextParagraphStyleName).Append("\n");
            sb.Append("  BaseStyleName: ").Append(this.BaseStyleName).Append("\n");
            sb.Append("  IsQuickStyle: ").Append(this.IsQuickStyle).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
