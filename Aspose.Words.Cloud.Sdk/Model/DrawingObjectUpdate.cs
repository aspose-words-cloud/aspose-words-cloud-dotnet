// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DrawingObjectUpdate.cs">
//   Copyright (c) 2025 Aspose.Words for Cloud
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
    /// Drawing object element for update.
    /// </summary>
    public class DrawingObjectUpdate : IModel
    {
        /// <summary>
        /// Gets or sets the relative horizontal position, from which the distance to the image is measured.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RelativeHorizontalPositionEnum
        {
            /// <summary>
            /// Enum value "Margin"
            /// </summary>
            Margin,

            /// <summary>
            /// Enum value "Page"
            /// </summary>
            Page,

            /// <summary>
            /// Enum value "Column"
            /// </summary>
            Column,

            /// <summary>
            /// Enum value "Default"
            /// </summary>
            Default,

            /// <summary>
            /// Enum value "Character"
            /// </summary>
            Character,

            /// <summary>
            /// Enum value "LeftMargin"
            /// </summary>
            LeftMargin,

            /// <summary>
            /// Enum value "RightMargin"
            /// </summary>
            RightMargin,

            /// <summary>
            /// Enum value "InsideMargin"
            /// </summary>
            InsideMargin,

            /// <summary>
            /// Enum value "OutsideMargin"
            /// </summary>
            OutsideMargin,
        }

        /// <summary>
        /// Gets or sets the relative vertical position, from which the distance to the image measured.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RelativeVerticalPositionEnum
        {
            /// <summary>
            /// Enum value "Margin"
            /// </summary>
            Margin,

            /// <summary>
            /// Enum value "TableDefault"
            /// </summary>
            TableDefault,

            /// <summary>
            /// Enum value "Page"
            /// </summary>
            Page,

            /// <summary>
            /// Enum value "Paragraph"
            /// </summary>
            Paragraph,

            /// <summary>
            /// Enum value "TextFrameDefault"
            /// </summary>
            TextFrameDefault,

            /// <summary>
            /// Enum value "Line"
            /// </summary>
            Line,

            /// <summary>
            /// Enum value "TopMargin"
            /// </summary>
            TopMargin,

            /// <summary>
            /// Enum value "BottomMargin"
            /// </summary>
            BottomMargin,

            /// <summary>
            /// Enum value "InsideMargin"
            /// </summary>
            InsideMargin,

            /// <summary>
            /// Enum value "OutsideMargin"
            /// </summary>
            OutsideMargin,
        }

        /// <summary>
        /// Gets or sets the option that controls how to wrap text around the image.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WrapTypeEnum
        {
            /// <summary>
            /// Enum value "Inline"
            /// </summary>
            Inline,

            /// <summary>
            /// Enum value "TopBottom"
            /// </summary>
            TopBottom,

            /// <summary>
            /// Enum value "Square"
            /// </summary>
            Square,

            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,

            /// <summary>
            /// Enum value "Tight"
            /// </summary>
            Tight,

            /// <summary>
            /// Enum value "Through"
            /// </summary>
            Through,
        }

        /// <summary>
        /// Gets or sets the relative horizontal position, from which the distance to the image is measured.
        /// </summary>
        public virtual RelativeHorizontalPositionEnum? RelativeHorizontalPosition { get; set; }

        /// <summary>
        /// Gets or sets the distance in points from the origin to the left side of the image.
        /// </summary>
        public virtual double? Left { get; set; }

        /// <summary>
        /// Gets or sets the relative vertical position, from which the distance to the image measured.
        /// </summary>
        public virtual RelativeVerticalPositionEnum? RelativeVerticalPosition { get; set; }

        /// <summary>
        /// Gets or sets the distance in points from the origin to the top side of the image.
        /// </summary>
        public virtual double? Top { get; set; }

        /// <summary>
        /// Gets or sets the width of the DrawingObjects in points.
        /// </summary>
        public virtual double? Width { get; set; }

        /// <summary>
        /// Gets or sets the height of the DrawingObject in points.
        /// </summary>
        public virtual double? Height { get; set; }

        /// <summary>
        /// Gets or sets the option that controls how to wrap text around the image.
        /// </summary>
        public virtual WrapTypeEnum? WrapType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether AspectRatioLocked option on or off.
        /// </summary>
        public virtual bool? AspectRatioLocked { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public virtual void Validate()
        {
        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DrawingObjectUpdate {\n");
            sb.Append("  RelativeHorizontalPosition: ").Append(this.RelativeHorizontalPosition).Append("\n");
            sb.Append("  Left: ").Append(this.Left).Append("\n");
            sb.Append("  RelativeVerticalPosition: ").Append(this.RelativeVerticalPosition).Append("\n");
            sb.Append("  Top: ").Append(this.Top).Append("\n");
            sb.Append("  Width: ").Append(this.Width).Append("\n");
            sb.Append("  Height: ").Append(this.Height).Append("\n");
            sb.Append("  WrapType: ").Append(this.WrapType).Append("\n");
            sb.Append("  AspectRatioLocked: ").Append(this.AspectRatioLocked).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
