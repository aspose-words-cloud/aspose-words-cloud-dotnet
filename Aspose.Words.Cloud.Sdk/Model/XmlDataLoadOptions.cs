// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="XmlDataLoadOptions.cs">
//   Copyright (c) 2023 Aspose.Words for Cloud
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
    /// Represents options for XML data loading.
    /// To learn more, visit the LINQ Reporting Engine documentation article.
    /// An instance of this class can be passed into constructors of XmlDataSource.
    /// </summary>
    public class XmlDataLoadOptions : IModel
    {
        /// <summary>
        /// Gets or sets a flag indicating whether a generated data source will always contain an object for an XML root
        /// element. If an XML root element has no attributes and all its child elements have same names, such an object
        /// is not created by default.
        /// The default value is false.
        /// </summary>
        public virtual bool? AlwaysGenerateRootObject { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public virtual void Validate()
        {
            if (this.AlwaysGenerateRootObject == null)
            {
                throw new ArgumentException("Property AlwaysGenerateRootObject in XmlDataLoadOptions is required.");
            }
        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XmlDataLoadOptions {\n");
            sb.Append("  AlwaysGenerateRootObject: ").Append(this.AlwaysGenerateRootObject).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
