// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TableRowInsert.cs">
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
    /// DTO container with a table row element.
    /// </summary>
    public class TableRowInsert : IModel
    {
        /// <summary>
        /// Gets or sets the count of columns. The default value is 1.
        /// </summary>
        public virtual int? ColumnsCount { get; set; }

        /// <summary>
        /// Gets or sets the position of the table row that will be used to determine the placement of a new row.
        /// </summary>
        public virtual Position ExistingRowPosition { get; set; }

        /// <summary>
        /// Gets or sets table row will be inserted after row with specified 0-based index.
        /// </summary>
        [Obsolete("This property will be removed in the future.")]
        public virtual int? InsertAfter { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public virtual void Validate()
        {
            if (this.ColumnsCount == null)
            {
                throw new ArgumentException("Property ColumnsCount in TableRowInsert is required.");
            }

            this.ExistingRowPosition?.Validate();


        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableRowInsert {\n");
            sb.Append("  ColumnsCount: ").Append(this.ColumnsCount).Append("\n");
            sb.Append("  ExistingRowPosition: ").Append(this.ExistingRowPosition).Append("\n");
            sb.Append("  InsertAfter: ").Append(this.InsertAfter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
