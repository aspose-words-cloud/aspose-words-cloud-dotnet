// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Section.cs">
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
    /// DTO container with a section element.
    /// </summary>
    public class Section : LinkElement, IModel
    {
        /// <summary>
        /// Gets or sets the list of child nodes.
        /// </summary>
        public virtual List<NodeLink> ChildNodes { get; set; }

        /// <summary>
        /// Gets or sets the link to Paragraphs resource.
        /// </summary>
        public virtual LinkElement Paragraphs { get; set; }

        /// <summary>
        /// Gets or sets the link to PageSetup resource.
        /// </summary>
        public virtual LinkElement PageSetup { get; set; }

        /// <summary>
        /// Gets or sets the link to HeaderFooters resource.
        /// </summary>
        public virtual LinkElement HeaderFooters { get; set; }

        /// <summary>
        /// Gets or sets the link to Tables resource.
        /// </summary>
        public virtual LinkElement Tables { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public override void Validate()
        {
            base.Validate();

            if (this.ChildNodes != null)
            {
                foreach (var elementChildNodes in this.ChildNodes)
                {
                    elementChildNodes?.Validate();
                }
            }



            this.Paragraphs?.Validate();



            this.PageSetup?.Validate();



            this.HeaderFooters?.Validate();



            this.Tables?.Validate();

        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Section {\n");
            sb.Append("  Link: ").Append(this.Link).Append("\n");
            sb.Append("  ChildNodes: ").Append(this.ChildNodes).Append("\n");
            sb.Append("  Paragraphs: ").Append(this.Paragraphs).Append("\n");
            sb.Append("  PageSetup: ").Append(this.PageSetup).Append("\n");
            sb.Append("  HeaderFooters: ").Append(this.HeaderFooters).Append("\n");
            sb.Append("  Tables: ").Append(this.Tables).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
