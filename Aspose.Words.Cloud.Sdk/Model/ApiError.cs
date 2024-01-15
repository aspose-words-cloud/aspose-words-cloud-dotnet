// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ApiError.cs">
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
    /// Api error.
    /// </summary>
    public class ApiError : IModel
    {
        /// <summary>
        /// Gets or sets the API error code.
        /// </summary>
        public virtual string Code { get; set; }

        /// <summary>
        /// Gets or sets the server DateTime.
        /// </summary>
        public virtual DateTime? DateTime { get; set; }

        /// <summary>
        /// Gets or sets the error description.
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// Gets or sets the inner error.
        /// </summary>
        public virtual ApiError InnerError { get; set; }

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        public virtual string Message { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public virtual void Validate()
        {

            this.InnerError?.Validate();


        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiError {\n");
            sb.Append("  Code: ").Append(this.Code).Append("\n");
            sb.Append("  DateTime: ").Append(this.DateTime).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  InnerError: ").Append(this.InnerError).Append("\n");
            sb.Append("  Message: ").Append(this.Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
