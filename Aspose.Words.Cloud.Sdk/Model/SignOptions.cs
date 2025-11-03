// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SignOptions.cs">
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
    /// Container class for digital signature options.
    /// </summary>
    public class SignOptions : IModel
    {
        /// <summary>
        /// Gets or sets comments on the digital signature. The default value is an empty string.
        /// </summary>
        public virtual string Comments { get; set; }

        /// <summary>
        /// Gets or sets the password to decrypt source document. The default value is an empty string.
        /// </summary>
        public virtual string DecryptionPassword { get; set; }

        /// <summary>
        /// Gets or sets the class Guid of the signature cryptography provider. The default value is Empty (all zeroes) Guid.
        /// </summary>
        public virtual string ProviderId { get; set; }

        /// <summary>
        /// Gets or sets user defined signature line Guid. The default value is Empty (all zeroes) Guid.
        /// </summary>
        public virtual string SignatureLineId { get; set; }

        /// <summary>
        /// Gets or sets the image that will be shown in associated SignatureLine. The default value is an empty string.
        /// </summary>
        public virtual string SignatureLineImageFilename { get; set; }

        /// <summary>
        /// Gets or sets the date of signing. The default value is current time (Now).
        /// </summary>
        public virtual DateTime? SignTime { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public virtual void Validate()
        {
        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignOptions {\n");
            sb.Append("  Comments: ").Append(this.Comments).Append("\n");
            sb.Append("  DecryptionPassword: ").Append(this.DecryptionPassword).Append("\n");
            sb.Append("  ProviderId: ").Append(this.ProviderId).Append("\n");
            sb.Append("  SignatureLineId: ").Append(this.SignatureLineId).Append("\n");
            sb.Append("  SignatureLineImageFilename: ").Append(this.SignatureLineImageFilename).Append("\n");
            sb.Append("  SignTime: ").Append(this.SignTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
