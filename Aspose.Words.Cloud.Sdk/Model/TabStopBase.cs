// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TabStopBase.cs">
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
    /// Base class for paragraph format tab stop DTO.
    /// </summary>
    public class TabStopBase : IModel
    {
        /// <summary>
        /// Gets or sets the alignment of text at this tab stop.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlignmentEnum
        {
            /// <summary>
            /// Enum value "Left"
            /// </summary>
            Left,

            /// <summary>
            /// Enum value "Center"
            /// </summary>
            Center,

            /// <summary>
            /// Enum value "Right"
            /// </summary>
            Right,

            /// <summary>
            /// Enum value "Decimal"
            /// </summary>
            Decimal,

            /// <summary>
            /// Enum value "Bar"
            /// </summary>
            Bar,

            /// <summary>
            /// Enum value "List"
            /// </summary>
            List,

            /// <summary>
            /// Enum value "Clear"
            /// </summary>
            Clear,
        }

        /// <summary>
        /// Gets or sets the type of the leader line displayed under the tab character.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LeaderEnum
        {
            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,

            /// <summary>
            /// Enum value "Dots"
            /// </summary>
            Dots,

            /// <summary>
            /// Enum value "Dashes"
            /// </summary>
            Dashes,

            /// <summary>
            /// Enum value "Line"
            /// </summary>
            Line,

            /// <summary>
            /// Enum value "Heavy"
            /// </summary>
            Heavy,

            /// <summary>
            /// Enum value "MiddleDot"
            /// </summary>
            MiddleDot,
        }

        /// <summary>
        /// Gets or sets the alignment of text at this tab stop.
        /// </summary>
        public virtual AlignmentEnum Alignment { get; set; }

        /// <summary>
        /// Gets or sets the type of the leader line displayed under the tab character.
        /// </summary>
        public virtual LeaderEnum Leader { get; set; }

        /// <summary>
        /// Gets or sets the position of the tab stop in points.
        /// </summary>
        public virtual double Position { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TabStopBase {\n");
            sb.Append("  Alignment: ").Append(this.Alignment).Append("\n");
            sb.Append("  Leader: ").Append(this.Leader).Append("\n");
            sb.Append("  Position: ").Append(this.Position).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
