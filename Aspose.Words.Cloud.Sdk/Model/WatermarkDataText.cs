// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WatermarkDataText.cs">
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
    /// Class for insert watermark text request building.
    /// </summary>
    public class WatermarkDataText : WatermarkDataBase, IModel
    {
        /// <summary>
        /// Gets or sets layout of the watermark. The default value is Aspose.Words.WatermarkLayout.Diagonal.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LayoutEnum
        {
            /// <summary>
            /// Enum value "Horizontal"
            /// </summary>
            Horizontal,

            /// <summary>
            /// Enum value "Diagonal"
            /// </summary>
            Diagonal,
        }

        /// <summary>
        /// Gets or sets font color. The default value is System.Drawing.Color.Silver.
        /// </summary>
        public virtual XmlColor Color { get; set; }

        /// <summary>
        /// Gets or sets font family name. The default value is "Calibri".
        /// </summary>
        public virtual string FontFamily { get; set; }

        /// <summary>
        /// Gets or sets a font size. The default value is 0 - auto.
        /// Valid values range from 0 to 65.5 inclusive. Auto font size means that the watermark will be scaled to its max width and max height relative to the page margins.
        /// </summary>
        public virtual double? FontSize { get; set; }

        /// <summary>
        /// Gets or sets a boolean value which is responsible for opacity of the watermark. The default value is true.
        /// </summary>
        public virtual bool? IsSemitrasparent { get; set; }

        /// <summary>
        /// Gets or sets layout of the watermark. The default value is Aspose.Words.WatermarkLayout.Diagonal.
        /// </summary>
        public virtual LayoutEnum? Layout { get; set; }

        /// <summary>
        /// Gets or sets the watermark text.
        /// </summary>
        public virtual string Text { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (this.Text == null)
            {
                throw new ArgumentException("Property Text in WatermarkDataText is required.");
            }

            this.Color?.Validate();






        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WatermarkDataText {\n");
            sb.Append("  Color: ").Append(this.Color).Append("\n");
            sb.Append("  FontFamily: ").Append(this.FontFamily).Append("\n");
            sb.Append("  FontSize: ").Append(this.FontSize).Append("\n");
            sb.Append("  IsSemitrasparent: ").Append(this.IsSemitrasparent).Append("\n");
            sb.Append("  Layout: ").Append(this.Layout).Append("\n");
            sb.Append("  Text: ").Append(this.Text).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
