// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="JsonDataLoadOptions.cs">
//   Copyright (c) 2022 Aspose.Words for Cloud
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
    /// Represents options for parsing JSON data.
    /// </summary>
    public class JsonDataLoadOptions
    {
        /// <summary>
        /// Gets or sets a mode for parsing JSON simple values (null, boolean, number, integer,
        /// and string) while loading JSON. Such a mode does not affect parsing of date-time
        /// values. The default is Aspose.Words.Reporting.JsonSimpleValueParseMode.Loose.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SimpleValueParseModeEnum
        {
            /// <summary>
            /// Enum value "Loose"
            /// </summary>
            Loose,

            /// <summary>
            /// Enum value "Strict"
            /// </summary>
            Strict,
        }

        /// <summary>
        /// Gets or sets a value indicating whether a generated data source will always contain
        /// an object for a JSON root element. If a JSON root element contains a single complex
        /// property, such an object is not created by default.
        /// </summary>
        public virtual bool AlwaysGenerateRootObject { get; set; }

        /// <summary>
        /// Gets or sets exact formats for parsing JSON date-time values while loading JSON.
        /// The default is null.
        /// </summary>
        public virtual List<string> ExactDateTimeParseFormats { get; set; }

        /// <summary>
        /// Gets or sets a mode for parsing JSON simple values (null, boolean, number, integer,
        /// and string) while loading JSON. Such a mode does not affect parsing of date-time
        /// values. The default is Aspose.Words.Reporting.JsonSimpleValueParseMode.Loose.
        /// </summary>
        public virtual SimpleValueParseModeEnum SimpleValueParseMode { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonDataLoadOptions {\n");
            sb.Append("  AlwaysGenerateRootObject: ").Append(this.AlwaysGenerateRootObject).Append("\n");
            sb.Append("  ExactDateTimeParseFormats: ").Append(this.ExactDateTimeParseFormats).Append("\n");
            sb.Append("  SimpleValueParseMode: ").Append(this.SimpleValueParseMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
