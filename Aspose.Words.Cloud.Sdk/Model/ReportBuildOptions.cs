// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ReportBuildOptions.cs">
//   Copyright (c) 2021 Aspose.Words for Cloud
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
    /// Specifies options controlling behavior of ReportingEngine while building a report.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReportBuildOptions
    {
        /// <summary>
        /// Enum value "None"
        /// </summary>
        None,

        /// <summary>
        /// Enum value "AllowMissingMembers"
        /// </summary>
        AllowMissingMembers,

        /// <summary>
        /// Enum value "RemoveEmptyParagraphs"
        /// </summary>
        RemoveEmptyParagraphs,

        /// <summary>
        /// Enum value "InlineErrorMessages"
        /// </summary>
        InlineErrorMessages,

        /// <summary>
        /// Enum value "UseLegacyHeaderFooterVisiting"
        /// </summary>
        UseLegacyHeaderFooterVisiting
    }
}
