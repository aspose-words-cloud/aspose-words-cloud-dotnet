// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ClassificationResponse.cs">
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
    /// The REST response with data on multi-class text classification.
    /// This response is returned by the Service when handling "PUT https://api.aspose.cloud/v4.0/words/classify" REST API requests.
    /// </summary>
    public class ClassificationResponse : WordsResponse, IModel
    {
        /// <summary>
        /// Gets or sets the best class name.
        /// </summary>
        public virtual string BestClassName { get; set; }

        /// <summary>
        /// Gets or sets the best class probability.
        /// </summary>
        public virtual double? BestClassProbability { get; set; }

        /// <summary>
        /// Gets or sets the array of best classes results.
        /// </summary>
        public virtual List<ClassificationResult> BestResults { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (this.BestClassProbability == null)
            {
                throw new ArgumentException("Property BestClassProbability in ClassificationResponse is required.");
            }

            if (this.BestResults != null)
            {
                foreach (var elementBestResults in this.BestResults)
                {
                    elementBestResults?.Validate();
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
            sb.Append("class ClassificationResponse {\n");
            sb.Append("  RequestId: ").Append(this.RequestId).Append("\n");
            sb.Append("  BestClassName: ").Append(this.BestClassName).Append("\n");
            sb.Append("  BestClassProbability: ").Append(this.BestClassProbability).Append("\n");
            sb.Append("  BestResults: ").Append(this.BestResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
