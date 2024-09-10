// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SignatureCollectionResponse.cs">
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
    /// The REST response with a document signature collection.
    /// This response is returned by the Service when handling any "https://api.aspose.cloud/v4.0/words/Test.doc/signatures" REST API requests.
    /// </summary>
    public class SignatureCollectionResponse : WordsResponse, IModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether all signatures are valid. Returns true if there is no signatures.
        /// </summary>
        public virtual bool? IsValid { get; set; }

        /// <summary>
        /// Gets or sets signatures.
        /// </summary>
        public virtual List<Signature> Signatures { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (this.IsValid == null)
            {
                throw new ArgumentException("Property IsValid in SignatureCollectionResponse is required.");
            }

            if (this.Signatures != null)
            {
                foreach (var elementSignatures in this.Signatures)
                {
                    elementSignatures?.Validate();
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
            sb.Append("class SignatureCollectionResponse {\n");
            sb.Append("  RequestId: ").Append(this.RequestId).Append("\n");
            sb.Append("  IsValid: ").Append(this.IsValid).Append("\n");
            sb.Append("  Signatures: ").Append(this.Signatures).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
