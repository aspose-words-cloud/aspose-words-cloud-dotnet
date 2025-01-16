// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Signature.cs">
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
    /// The REST response with a document signature collection.
    /// This response is returned by the Service when handling any "https://api.aspose.cloud/v4.0/words/Test.doc/signatures" REST API requests.
    /// </summary>
    public class Signature : IModel
    {
        /// <summary>
        /// Gets or sets the signing purpose comment.
        /// </summary>
        public virtual string Comments { get; set; }

        /// <summary>
        /// Gets or sets the subject distinguished name of the certificate isuuer.
        /// </summary>
        public virtual string IssuerName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this digital signature is valid.
        /// </summary>
        public virtual bool? IsValid { get; set; }

        /// <summary>
        /// Gets or sets the type of the digital signature.
        /// </summary>
        public virtual string SignatureType { get; set; }

        /// <summary>
        /// Gets or sets an array of bytes representing a signature value as base64 string.
        /// </summary>
        public virtual string SignatureValue { get; set; }

        /// <summary>
        /// Gets or sets the time the document was signed.
        /// </summary>
        public virtual DateTime? SignTime { get; set; }

        /// <summary>
        /// Gets or sets the subject distinguished name of the certificate that was used to sign the document.
        /// </summary>
        public virtual string SubjectName { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public virtual void Validate()
        {
            if (this.IsValid == null)
            {
                throw new ArgumentException("Property IsValid in Signature is required.");
            }
            if (this.SignTime == null)
            {
                throw new ArgumentException("Property SignTime in Signature is required.");
            }
        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Signature {\n");
            sb.Append("  Comments: ").Append(this.Comments).Append("\n");
            sb.Append("  IssuerName: ").Append(this.IssuerName).Append("\n");
            sb.Append("  IsValid: ").Append(this.IsValid).Append("\n");
            sb.Append("  SignatureType: ").Append(this.SignatureType).Append("\n");
            sb.Append("  SignatureValue: ").Append(this.SignatureValue).Append("\n");
            sb.Append("  SignTime: ").Append(this.SignTime).Append("\n");
            sb.Append("  SubjectName: ").Append(this.SubjectName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
