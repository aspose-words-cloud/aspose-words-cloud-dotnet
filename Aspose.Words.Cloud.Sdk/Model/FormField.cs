// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FormField.cs">
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
    /// FromField.
    /// </summary>
    public abstract class FormField : NodeLink, IModel
    {
        /// <summary>
        /// Gets or sets the form field name.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a form field is enabled.
        /// If a form field is enabled, its contents can be changed as the form is filled in.
        /// </summary>
        public virtual bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets text, displayed in the status bar when a form field has the focus.
        /// If the OwnStatus property is set to true, the StatusText property specifies the status bar text. If the OwnStatus property is set to false, the StatusText property specifies the name of an AutoText entry that contains status bar text for the form field.
        /// </summary>
        public virtual string StatusText { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the source of the text that's displayed in the status bar when a form field has the focus.
        /// If true, the text specified by the StatusText property is displayed. If false, the text of the AutoText entry specified by the StatusText property is displayed.
        /// </summary>
        public virtual bool? OwnStatus { get; set; }

        /// <summary>
        /// Gets or sets text, displayed in a message box when the form field has the focus and the user presses F1.
        /// If the OwnHelp property is set to True, HelpText specifies the text string value. If OwnHelp is set to False, HelpText specifies the name of an AutoText entry that contains help text for the form field.
        /// </summary>
        public virtual string HelpText { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the source of the text that's displayed in a message box when a form field has the focus and the user presses F1.
        /// If true, the text specified by the HelpText property is displayed. If False, the text in the AutoText entry specified by the HelpText property is displayed.
        /// </summary>
        public virtual bool? OwnHelp { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether references to the specified form field are automatically updated whenever the field is exited.
        /// Setting CalculateOnExit only affects the behavior of the form field when the document is opened in Microsoft Word. Aspose.Words never updates references to the form field.
        /// </summary>
        public virtual bool? CalculateOnExit { get; set; }

        /// <summary>
        /// Gets or sets the entry macro name for the form field.
        /// The entry macro runs when the form field gets the focus in Microsoft Word.
        /// </summary>
        public virtual string EntryMacro { get; set; }

        /// <summary>
        /// Gets or sets the exit macro name for the form field.
        /// The exit macro runs when the form field loses the focus in Microsoft Word.
        /// </summary>
        public virtual string ExitMacro { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (this.Name == null)
            {
                throw new ArgumentException("Property Name in FormField is required.");
            }
        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormField {\n");
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
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
