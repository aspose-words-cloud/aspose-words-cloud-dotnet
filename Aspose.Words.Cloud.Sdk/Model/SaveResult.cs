// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SaveResult.cs">
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
    /// Result of saving.
    /// </summary>
    public class SaveResult : IModel
    {
        /// <summary>
        /// Gets or sets the link to destination document.
        /// </summary>
        public virtual FileLink DestDocument { get; set; }

        /// <summary>
        /// Gets or sets the link to source document.
        /// </summary>
        public virtual FileLink SourceDocument { get; set; }

        /// <summary>
        /// Gets or sets the list of links to additional items (css, images etc).
        /// </summary>
        public virtual List<FileLink> AdditionalItems { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public virtual void Validate()
        {

            this.DestDocument?.Validate();



            this.SourceDocument?.Validate();



            if (this.AdditionalItems != null)
            {
                foreach (var elementAdditionalItems in this.AdditionalItems)
                {
                    elementAdditionalItems?.Validate();
                }
            }

        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveResult {\n");
            sb.Append("  DestDocument: ").Append(this.DestDocument).Append("\n");
            sb.Append("  SourceDocument: ").Append(this.SourceDocument).Append("\n");
            sb.Append("  AdditionalItems: ").Append(this.AdditionalItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
