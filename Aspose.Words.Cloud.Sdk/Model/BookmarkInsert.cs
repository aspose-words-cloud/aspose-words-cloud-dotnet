// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BookmarkInsert.cs">
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
    /// Represents a bookmark to insert.
    /// </summary>
    public class BookmarkInsert : BookmarkData
    {
        /// <summary>
        /// Gets or sets the link to end bookmark node.
        /// </summary>
        public virtual DocumentPosition EndRange { get; set; }

        /// <summary>
        /// Gets or sets the link to start bookmark node.
        /// </summary>
        public virtual DocumentPosition StartRange { get; set; }


        /// <summary>
        /// Gets all file content properties.
        /// </summary>
        /// <returns>The http request instance.</returns>
        public override IEnumerable<FileReference> GetFileReferences()
        {
            var result = new List<FileReference>();
            result.AddRange(base.GetFileReferences());
            if (this.EndRange != null){
                result.AddRange(this.EndRange.GetFileReferences());
            }

            if (this.StartRange != null){
                result.AddRange(this.StartRange.GetFileReferences());
            }

            return result;
        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BookmarkInsert {\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Text: ").Append(this.Text).Append("\n");
            sb.Append("  EndRange: ").Append(this.EndRange).Append("\n");
            sb.Append("  StartRange: ").Append(this.StartRange).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
