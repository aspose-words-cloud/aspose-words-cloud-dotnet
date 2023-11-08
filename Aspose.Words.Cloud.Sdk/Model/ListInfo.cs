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
        /// You do not normally need to use this property. But if you use it, you normally do so in conjunction with the Aspose.Words.Lists.ListCollection.GetListByListId(System.Int32) method to find a list by its identifier.
        /// </summary>
        public virtual int? ListId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the list contains 9 levels; false when 1 level.
        /// The lists that you create with Aspose.Words are always multi-level lists and contain 9 levels. Microsoft Word 2003 and later always create multi-level lists with 9 levels. But in some documents, created with earlier versions of Microsoft Word you might encounter lists that have 1 level only.
        /// </summary>
        public virtual bool? IsMultiLevel { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether list should be restarted at each section. The default value is false.
        /// This option is supported only in RTF, DOC and DOCX document formats. This option will be written to DOCX only if Aspose.Words.Saving.OoxmlCompliance is higher then Aspose.Words.Saving.OoxmlCompliance.Ecma376_2006.
        /// </summary>
        public virtual bool? IsRestartAtEachSection { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this list is a definition of a list style.
        /// When this property is true, the Aspose.Words.Lists.List.Style property returns the list style that this list defines. By modifying properties of a list that defines a list style, you modify The properties of the list style. A list that is a definition of a list style cannot be applied directly to paragraphs to make them numbered. Aspose.Words.Lists.List.Style Aspose.Words.Lists.List.IsListStyleReference.
        /// </summary>
        public virtual bool? IsListStyleDefinition { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this list is a reference to a list style.
        /// Note, modifying properties of a list that is a reference to list style has no effect. The list formatting specified in the list style itself always takes precedence. Aspose.Words.Lists.List.Style Aspose.Words.Lists.List.IsListStyleDefinition.
        /// </summary>
        public virtual bool? IsListStyleReference { get; set; }

        /// <summary>
        /// Gets or sets the list style that this list references or defines.
        /// If this list is not associated with a list style, the property will return null. A list could be a reference to a list style, in this case Aspose.Words.Lists.List.IsListStyleReference will be true. A list could be a definition of a list style, in this case Aspose.Words.Lists.List.IsListStyleDefinition will be true. Such a list cannot be applied to paragraphs in the document directly.
        /// </summary>
        public virtual Style Style { get; set; }

        /// <summary>
        /// Gets or sets the collection of list levels for this list.
        /// Use this property to access and modify formatting individual to each level of the list.
        /// </summary>
        public virtual ListLevels ListLevels { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (this.ListId == null)
            {
                throw new ArgumentException("Property ListId in ListInfo is required.");
            }
            if (this.IsMultiLevel == null)
            {
                throw new ArgumentException("Property IsMultiLevel in ListInfo is required.");
            }
            if (this.IsRestartAtEachSection == null)
            {
                throw new ArgumentException("Property IsRestartAtEachSection in ListInfo is required.");
            }
            if (this.IsListStyleDefinition == null)
            {
                throw new ArgumentException("Property IsListStyleDefinition in ListInfo is required.");
            }
            if (this.IsListStyleReference == null)
            {
                throw new ArgumentException("Property IsListStyleReference in ListInfo is required.");
            }

            this.Style?.Validate();



            this.ListLevels?.Validate();

        }

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
