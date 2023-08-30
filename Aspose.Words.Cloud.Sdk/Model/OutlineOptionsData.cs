// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OutlineOptionsData.cs">
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
    /// Container class for outline options.
    /// </summary>
    public class OutlineOptionsData : IModel
    {
        /// <summary>
        /// Gets or sets the individual bookmarks outline level.
        /// </summary>
        public virtual List<BookmarksOutlineLevelData> BookmarksOutlineLevels { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to create missing outline levels when the document is exported. The default value is false.
        /// </summary>
        public virtual bool? CreateMissingOutlineLevels { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to create outlines for headings (paragraphs formatted with the Heading styles) inside tables.
        /// </summary>
        public virtual bool? CreateOutlinesForHeadingsInTables { get; set; }

        /// <summary>
        /// Gets or sets the default level in the document outline at which to display Word bookmarks.
        /// </summary>
        public virtual int? DefaultBookmarksOutlineLevel { get; set; }

        /// <summary>
        /// Gets or sets the number of levels in the document outline to show expanded when the file is viewed.
        /// </summary>
        public virtual int? ExpandedOutlineLevels { get; set; }

        /// <summary>
        /// Gets or sets the number of levels of headings (paragraphs formatted with the Heading styles) to include in the document outline.
        /// </summary>
        public virtual int? HeadingsOutlineLevels { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutlineOptionsData {\n");
            sb.Append("  BookmarksOutlineLevels: ").Append(this.BookmarksOutlineLevels).Append("\n");
            sb.Append("  CreateMissingOutlineLevels: ").Append(this.CreateMissingOutlineLevels).Append("\n");
            sb.Append("  CreateOutlinesForHeadingsInTables: ").Append(this.CreateOutlinesForHeadingsInTables).Append("\n");
            sb.Append("  DefaultBookmarksOutlineLevel: ").Append(this.DefaultBookmarksOutlineLevel).Append("\n");
            sb.Append("  ExpandedOutlineLevels: ").Append(this.ExpandedOutlineLevels).Append("\n");
            sb.Append("  HeadingsOutlineLevels: ").Append(this.HeadingsOutlineLevels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
