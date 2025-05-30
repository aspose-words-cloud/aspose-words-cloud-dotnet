// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TableInsert.cs">
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
    /// DTO container with a table element.
    /// </summary>
    public class TableInsert : IModel
    {
        /// <summary>
        /// Gets or sets the number of columns. The default value is 2.
        /// </summary>
        public virtual int? ColumnsCount { get; set; }

        /// <summary>
        /// Gets or sets the position to insert the table. The table will be inserted using the specified position.
        /// </summary>
        public virtual Position Position { get; set; }

        /// <summary>
        /// Gets or sets the number of rows. The default value is 2.
        /// </summary>
        public virtual int? RowsCount { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public virtual void Validate()
        {
            if (this.ColumnsCount == null)
            {
                throw new ArgumentException("Property ColumnsCount in TableInsert is required.");
            }
            if (this.RowsCount == null)
            {
                throw new ArgumentException("Property RowsCount in TableInsert is required.");
            }

            this.Position?.Validate();


        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableInsert {\n");
            sb.Append("  ColumnsCount: ").Append(this.ColumnsCount).Append("\n");
            sb.Append("  Position: ").Append(this.Position).Append("\n");
            sb.Append("  RowsCount: ").Append(this.RowsCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
