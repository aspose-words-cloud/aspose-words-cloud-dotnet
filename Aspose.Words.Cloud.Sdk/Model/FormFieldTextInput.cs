// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FormFieldTextInput.cs">
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
    /// FormField text input element.
    /// </summary>
    public class FormFieldTextInput : FormField, IModel
    {
        /// <summary>
        /// Gets or sets the type of the text form field.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextInputTypeEnum
        {
            /// <summary>
            /// Enum value "Regular"
            /// </summary>
            Regular,

            /// <summary>
            /// Enum value "Number"
            /// </summary>
            Number,

            /// <summary>
            /// Enum value "Date"
            /// </summary>
            Date,

            /// <summary>
            /// Enum value "CurrentDate"
            /// </summary>
            CurrentDate,

            /// <summary>
            /// Enum value "CurrentTime"
            /// </summary>
            CurrentTime,

            /// <summary>
            /// Enum value "Calculated"
            /// </summary>
            Calculated,
        }

        /// <summary>
        /// Gets or sets text formatting for the text form field.
        /// If the text form field contains regular text, then valid format strings are "", "UPPERCASE", "LOWERCASE", "FIRST CAPITAL" and "TITLE CASE". The strings are case-insensitive.If the text form field contains a number or a date/time value, then valid format strings are number or date and time format strings.
        /// </summary>
        public virtual string TextInputFormat { get; set; }

        /// <summary>
        /// Gets or sets the type of the text form field.
        /// </summary>
        public virtual TextInputTypeEnum? TextInputType { get; set; }

        /// <summary>
        /// Gets or sets the default string or a calculation expression of the text form field.
        /// The meaning of this property depends on the value of the TextInputType property.When TextInputType is Regular or Number, this string specifies the default string for the text form field. This string is the content that Microsoft Word will display in the document when the form field is empty.When TextInputType is Calculated, then this string holds the expression to be calculated. The expression needs to be a formula valid according to Microsoft Word formula field requirements. When you set a new expression using this property, Aspose.Words calculates the formula result automatically and inserts it into the form field.
        /// </summary>
        public virtual string TextInputDefault { get; set; }

        /// <summary>
        /// Gets or sets the maximum length for the text field. Zero when the length is not limited.
        /// </summary>
        public virtual int? MaxLength { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (this.TextInputFormat == null)
            {
                throw new ArgumentException("Property TextInputFormat in FormFieldTextInput is required.");
            }
            if (this.TextInputDefault == null)
            {
                throw new ArgumentException("Property TextInputDefault in FormFieldTextInput is required.");
            }
        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormFieldTextInput {\n");
            sb.Append("  Link: ").Append(this.Link).Append("\n");
            sb.Append("  NodeId: ").Append(this.NodeId).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Enabled: ").Append(this.Enabled).Append("\n");
            sb.Append("  StatusText: ").Append(this.StatusText).Append("\n");
            sb.Append("  OwnStatus: ").Append(this.OwnStatus).Append("\n");
            sb.Append("  HelpText: ").Append(this.HelpText).Append("\n");
            sb.Append("  OwnHelp: ").Append(this.OwnHelp).Append("\n");
            sb.Append("  CalculateOnExit: ").Append(this.CalculateOnExit).Append("\n");
            sb.Append("  EntryMacro: ").Append(this.EntryMacro).Append("\n");
            sb.Append("  ExitMacro: ").Append(this.ExitMacro).Append("\n");
            sb.Append("  TextInputFormat: ").Append(this.TextInputFormat).Append("\n");
            sb.Append("  TextInputType: ").Append(this.TextInputType).Append("\n");
            sb.Append("  TextInputDefault: ").Append(this.TextInputDefault).Append("\n");
            sb.Append("  MaxLength: ").Append(this.MaxLength).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
