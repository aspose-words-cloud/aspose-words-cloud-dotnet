// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Border.cs">
//   Copyright (c) 2026 Aspose.Words for Cloud
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
    /// Represents a border of an object.
    /// Borders can be applied to various document elements including paragraph, run of text inside a paragraph or a table cell.
    /// </summary>
    public class Border : LinkElement, IModel
    {
        /// <summary>
        /// Gets or sets the border type.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BorderTypeEnum
        {
            /// <summary>
            /// Enum value "Bottom"
            /// </summary>
            Bottom,

            /// <summary>
            /// Enum value "Left"
            /// </summary>
            Left,

            /// <summary>
            /// Enum value "Right"
            /// </summary>
            Right,

            /// <summary>
            /// Enum value "Top"
            /// </summary>
            Top,

            /// <summary>
            /// Enum value "Horizontal"
            /// </summary>
            Horizontal,

            /// <summary>
            /// Enum value "Vertical"
            /// </summary>
            Vertical,

            /// <summary>
            /// Enum value "DiagonalDown"
            /// </summary>
            DiagonalDown,

            /// <summary>
            /// Enum value "DiagonalUp"
            /// </summary>
            DiagonalUp,

            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,
        }

        /// <summary>
        /// Gets or sets the border style.
        /// If you set line style to none, then line width is automatically changed to zero.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LineStyleEnum
        {
            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,

            /// <summary>
            /// Enum value "Single"
            /// </summary>
            Single,

            /// <summary>
            /// Enum value "Thick"
            /// </summary>
            Thick,

            /// <summary>
            /// Enum value "Double"
            /// </summary>
            Double,

            /// <summary>
            /// Enum value "Hairline"
            /// </summary>
            Hairline,

            /// <summary>
            /// Enum value "Dot"
            /// </summary>
            Dot,

            /// <summary>
            /// Enum value "DashLargeGap"
            /// </summary>
            DashLargeGap,

            /// <summary>
            /// Enum value "DotDash"
            /// </summary>
            DotDash,

            /// <summary>
            /// Enum value "DotDotDash"
            /// </summary>
            DotDotDash,

            /// <summary>
            /// Enum value "Triple"
            /// </summary>
            Triple,

            /// <summary>
            /// Enum value "ThinThickSmallGap"
            /// </summary>
            ThinThickSmallGap,

            /// <summary>
            /// Enum value "ThickThinSmallGap"
            /// </summary>
            ThickThinSmallGap,

            /// <summary>
            /// Enum value "ThinThickThinSmallGap"
            /// </summary>
            ThinThickThinSmallGap,

            /// <summary>
            /// Enum value "ThinThickMediumGap"
            /// </summary>
            ThinThickMediumGap,

            /// <summary>
            /// Enum value "ThickThinMediumGap"
            /// </summary>
            ThickThinMediumGap,

            /// <summary>
            /// Enum value "ThinThickThinMediumGap"
            /// </summary>
            ThinThickThinMediumGap,

            /// <summary>
            /// Enum value "ThinThickLargeGap"
            /// </summary>
            ThinThickLargeGap,

            /// <summary>
            /// Enum value "ThickThinLargeGap"
            /// </summary>
            ThickThinLargeGap,

            /// <summary>
            /// Enum value "ThinThickThinLargeGap"
            /// </summary>
            ThinThickThinLargeGap,

            /// <summary>
            /// Enum value "Wave"
            /// </summary>
            Wave,

            /// <summary>
            /// Enum value "DoubleWave"
            /// </summary>
            DoubleWave,

            /// <summary>
            /// Enum value "DashSmallGap"
            /// </summary>
            DashSmallGap,

            /// <summary>
            /// Enum value "DashDotStroker"
            /// </summary>
            DashDotStroker,

            /// <summary>
            /// Enum value "Emboss3D"
            /// </summary>
            Emboss3D,

            /// <summary>
            /// Enum value "Engrave3D"
            /// </summary>
            Engrave3D,

            /// <summary>
            /// Enum value "Outset"
            /// </summary>
            Outset,

            /// <summary>
            /// Enum value "Inset"
            /// </summary>
            Inset,
        }

        /// <summary>
        /// Gets or sets the border type.
        /// </summary>
        public virtual BorderTypeEnum? BorderType { get; set; }

        /// <summary>
        /// Gets or sets the border color.
        /// </summary>
        public virtual XmlColor Color { get; set; }

        /// <summary>
        /// Gets or sets the distance of the border from text or from the page edge in points.
        /// Has no effect and will be automatically reset to zero for borders of table cells.
        /// </summary>
        public virtual double? DistanceFromText { get; set; }

        /// <summary>
        /// Gets or sets the border style.
        /// If you set line style to none, then line width is automatically changed to zero.
        /// </summary>
        public virtual LineStyleEnum? LineStyle { get; set; }

        /// <summary>
        /// Gets or sets the border width in points.
        /// If you set line width greater than zero when line style is none, the line style is automatically changed to single line.
        /// </summary>
        public virtual double? LineWidth { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the border has a shadow.
        /// In Microsoft Word, for a border to have a shadow, the borders on all four sides (left, top, right and bottom) should be of the same type, width, color and all should have the Shadow property set to true.
        /// </summary>
        public virtual bool? Shadow { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public override void Validate()
        {
            base.Validate();

            this.Color?.Validate();





        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Border {\n");
            sb.Append("  Link: ").Append(this.Link).Append("\n");
            sb.Append("  BorderType: ").Append(this.BorderType).Append("\n");
            sb.Append("  Color: ").Append(this.Color).Append("\n");
            sb.Append("  DistanceFromText: ").Append(this.DistanceFromText).Append("\n");
            sb.Append("  LineStyle: ").Append(this.LineStyle).Append("\n");
            sb.Append("  LineWidth: ").Append(this.LineWidth).Append("\n");
            sb.Append("  Shadow: ").Append(this.Shadow).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
