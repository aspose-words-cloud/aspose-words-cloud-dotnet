// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CsvDataLoadOptions.cs">
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
    /// Represents options for parsing CSV data.
    /// To learn more, visit the LINQ Reporting Engine documentation article.
    /// An instance of this class can be passed into constructors of CsvDataSource.
    /// </summary>
    public class CsvDataLoadOptions : IModel
    {
        /// <summary>
        /// Gets or sets the character that is used to comment lines of CSV data.
        /// The default value is '#' (number sign).
        /// </summary>
        public virtual string CommentChar { get; set; }

        /// <summary>
        /// Gets or sets the character to be used as a column delimiter.
        /// The default value is ',' (comma).
        /// </summary>
        public virtual string Delimiter { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the first record of CSV data contains column names.
        /// The default value is false.
        /// </summary>
        public virtual bool? HasHeaders { get; set; }

        /// <summary>
        /// Gets or sets the character that is used to quote field values.
        /// The default value is '"' (quotation mark).Double the character to place it into quoted text.
        /// </summary>
        public virtual string QuoteChar { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public virtual void Validate()
        {
            if (this.CommentChar == null)
            {
                throw new ArgumentException("Property CommentChar in CsvDataLoadOptions is required.");
            }
            if (this.Delimiter == null)
            {
                throw new ArgumentException("Property Delimiter in CsvDataLoadOptions is required.");
            }
            if (this.HasHeaders == null)
            {
                throw new ArgumentException("Property HasHeaders in CsvDataLoadOptions is required.");
            }
            if (this.QuoteChar == null)
            {
                throw new ArgumentException("Property QuoteChar in CsvDataLoadOptions is required.");
            }
        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CsvDataLoadOptions {\n");
            sb.Append("  CommentChar: ").Append(this.CommentChar).Append("\n");
            sb.Append("  Delimiter: ").Append(this.Delimiter).Append("\n");
            sb.Append("  HasHeaders: ").Append(this.HasHeaders).Append("\n");
            sb.Append("  QuoteChar: ").Append(this.QuoteChar).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
