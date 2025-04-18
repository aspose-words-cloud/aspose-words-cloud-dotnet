// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="LoadWebDocumentData.cs">
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
    /// Contains data for load web document.
    /// </summary>
    public class LoadWebDocumentData : IModel
    {
        /// <summary>
        /// Gets or sets the save options.
        /// </summary>
        public virtual SaveOptionsData SaveOptions { get; set; }

        /// <summary>
        /// Gets or sets the web document URL.
        /// </summary>
        public virtual string LoadingDocumentUrl { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public virtual void Validate()
        {
            if (this.LoadingDocumentUrl == null)
            {
                throw new ArgumentException("Property LoadingDocumentUrl in LoadWebDocumentData is required.");
            }

            this.SaveOptions?.Validate();


        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoadWebDocumentData {\n");
            sb.Append("  SaveOptions: ").Append(this.SaveOptions).Append("\n");
            sb.Append("  LoadingDocumentUrl: ").Append(this.LoadingDocumentUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
