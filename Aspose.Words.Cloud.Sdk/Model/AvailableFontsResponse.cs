// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AvailableFontsResponse.cs">
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
    /// The REST response with data on system, additional and custom fonts, available for document processing.
    /// </summary>
    public class AvailableFontsResponse : WordsResponse
    {
        /// <summary>
        /// Gets or sets the list of additional fonts, provided by Aspose team.
        /// </summary>
        public virtual List<FontInfo> AdditionalFonts { get; set; }

        /// <summary>
        /// Gets or sets the list of custom user fonts from user cloud storage. To use them, you should specify "fontsLocation" parameter in any request.
        /// </summary>
        public virtual List<FontInfo> CustomFonts { get; set; }

        /// <summary>
        /// Gets or sets the list of system fonts, available on the server.
        /// </summary>
        public virtual List<FontInfo> SystemFonts { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailableFontsResponse {\n");
            sb.Append("  RequestId: ").Append(this.RequestId).Append("\n");
            sb.Append("  AdditionalFonts: ").Append(this.AdditionalFonts).Append("\n");
            sb.Append("  CustomFonts: ").Append(this.CustomFonts).Append("\n");
            sb.Append("  SystemFonts: ").Append(this.SystemFonts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
