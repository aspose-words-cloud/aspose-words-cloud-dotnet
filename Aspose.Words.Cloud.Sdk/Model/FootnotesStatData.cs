// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FootnotesStatData.cs">
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
    /// Container for the footnotes statistical data.
    /// </summary>
    public class FootnotesStatData : IModel
    {
        /// <summary>
        /// Gets or sets the total count of paragraphs in footnotes.
        /// </summary>
        public virtual int? ParagraphCount { get; set; }

        /// <summary>
        /// Gets or sets the total count of words in footnotes.
        /// </summary>
        public virtual int? WordCount { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public virtual void Validate()
        {
            if (this.ParagraphCount == null)
            {
                throw new ArgumentException("Property ParagraphCount in FootnotesStatData is required.");
            }
            if (this.WordCount == null)
            {
                throw new ArgumentException("Property WordCount in FootnotesStatData is required.");
            }
        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FootnotesStatData {\n");
            sb.Append("  ParagraphCount: ").Append(this.ParagraphCount).Append("\n");
            sb.Append("  WordCount: ").Append(this.WordCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
