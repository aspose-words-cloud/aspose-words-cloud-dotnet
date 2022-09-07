// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TimeZoneInfoData.cs">
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
    /// Class to specify TimeZoneInfo parameters.
    /// </summary>
    public class TimeZoneInfoData : IModel
    {
        /// <summary>
        /// Gets or sets base utc offset in hh:mm:ss format.
        /// </summary>
        public virtual string BaseUtcOffset { get; set; }

        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets an Id string for CustomTimeZoneInfo.
        /// </summary>
        public virtual string Id { get; set; }

        /// <summary>
        /// Gets or sets standard display name.
        /// </summary>
        public virtual string StandardDisplayName { get; set; }



        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeZoneInfoData {\n");
            sb.Append("  BaseUtcOffset: ").Append(this.BaseUtcOffset).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  StandardDisplayName: ").Append(this.StandardDisplayName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
