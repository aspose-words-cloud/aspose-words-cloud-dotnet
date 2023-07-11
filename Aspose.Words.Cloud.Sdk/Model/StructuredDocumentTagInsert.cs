// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StructuredDocumentTagInsert.cs">
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
    /// DTO container with a StructuredDocumentTag.
    /// </summary>
    public class StructuredDocumentTagInsert : StructuredDocumentTag
    {
        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StructuredDocumentTagInsert {\n");
            sb.Append("  Link: ").Append(this.Link).Append("\n");
            sb.Append("  NodeId: ").Append(this.NodeId).Append("\n");
            sb.Append("  ListItems: ").Append(this.ListItems).Append("\n");
            sb.Append("  Checked: ").Append(this.Checked).Append("\n");
            sb.Append("  Appearance: ").Append(this.Appearance).Append("\n");
            sb.Append("  DateDisplayLocale: ").Append(this.DateDisplayLocale).Append("\n");
            sb.Append("  DateDisplayFormat: ").Append(this.DateDisplayFormat).Append("\n");
            sb.Append("  FullDate: ").Append(this.FullDate).Append("\n");
            sb.Append("  Title: ").Append(this.Title).Append("\n");
            sb.Append("  DateStorageFormat: ").Append(this.DateStorageFormat).Append("\n");
            sb.Append("  BuildingBlockGallery: ").Append(this.BuildingBlockGallery).Append("\n");
            sb.Append("  BuildingBlockCategory: ").Append(this.BuildingBlockCategory).Append("\n");
            sb.Append("  Multiline: ").Append(this.Multiline).Append("\n");
            sb.Append("  Color: ").Append(this.Color).Append("\n");
            sb.Append("  StyleName: ").Append(this.StyleName).Append("\n");
            sb.Append("  CalendarType: ").Append(this.CalendarType).Append("\n");
            sb.Append("  IsTemporary: ").Append(this.IsTemporary).Append("\n");
            sb.Append("  Level: ").Append(this.Level).Append("\n");
            sb.Append("  SdtType: ").Append(this.SdtType).Append("\n");
            sb.Append("  PlaceholderName: ").Append(this.PlaceholderName).Append("\n");
            sb.Append("  LockContentControl: ").Append(this.LockContentControl).Append("\n");
            sb.Append("  LockContents: ").Append(this.LockContents).Append("\n");
            sb.Append("  IsShowingPlaceholderText: ").Append(this.IsShowingPlaceholderText).Append("\n");
            sb.Append("  Tag: ").Append(this.Tag).Append("\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  WordOpenXML: ").Append(this.WordOpenXML).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
