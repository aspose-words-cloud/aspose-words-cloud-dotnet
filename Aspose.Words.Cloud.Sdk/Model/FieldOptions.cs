// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FieldOptions.cs">
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
    /// DTO for field options.
    /// </summary>
    public class FieldOptions : IModel
    {
        /// <summary>
        /// Gets or sets Field Index Format.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FieldIndexFormatEnum
        {
            /// <summary>
            /// Enum value "Template"
            /// </summary>
            Template,

            /// <summary>
            /// Enum value "Classic"
            /// </summary>
            Classic,

            /// <summary>
            /// Enum value "Fancy"
            /// </summary>
            Fancy,

            /// <summary>
            /// Enum value "Modern"
            /// </summary>
            Modern,

            /// <summary>
            /// Enum value "Bulleted"
            /// </summary>
            Bulleted,

            /// <summary>
            /// Enum value "Formal"
            /// </summary>
            Formal,

            /// <summary>
            /// Enum value "Simple"
            /// </summary>
            Simple,
        }

        /// <summary>
        /// Gets or sets Field Update Culture Source.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FieldUpdateCultureSourceEnum
        {
            /// <summary>
            /// Enum value "CurrentThread"
            /// </summary>
            CurrentThread,

            /// <summary>
            /// Enum value "FieldCode"
            /// </summary>
            FieldCode,
        }

        /// <summary>
        /// Gets or sets Current User.
        /// </summary>
        public virtual UserInformation CurrentUser { get; set; }

        /// <summary>
        /// Gets or sets Custom Toc Style Separator.
        /// </summary>
        public virtual string CustomTocStyleSeparator { get; set; }

        /// <summary>
        /// Gets or sets Default Document Author.
        /// </summary>
        public virtual string DefaultDocumentAuthor { get; set; }

        /// <summary>
        /// Gets or sets Field Index Format.
        /// </summary>
        public virtual FieldIndexFormatEnum? FieldIndexFormat { get; set; }

        /// <summary>
        /// Gets or sets Field Update Culture Name.
        /// It is used for all fields if FieldUpdateCultureSource is FieldCode.
        /// </summary>
        public virtual string FieldUpdateCultureName { get; set; }

        /// <summary>
        /// Gets or sets Field Update Culture Source.
        /// </summary>
        public virtual FieldUpdateCultureSourceEnum? FieldUpdateCultureSource { get; set; }

        /// <summary>
        /// Gets or sets File Name.
        /// </summary>
        public virtual string FileName { get; set; }

        /// <summary>
        /// Gets or sets if Bidi Text Supported OnUpdate.
        /// </summary>
        public virtual bool? IsBidiTextSupportedOnUpdate { get; set; }

        /// <summary>
        /// Gets or sets if Legacy Number Format.
        /// </summary>
        public virtual bool? LegacyNumberFormat { get; set; }

        /// <summary>
        /// Gets or sets PreProcess Culture Name.
        /// It is a culture code for DOC fields.
        /// </summary>
        public virtual string PreProcessCultureName { get; set; }

        /// <summary>
        /// Gets or sets Template Name.
        /// </summary>
        public virtual string TemplateName { get; set; }

        /// <summary>
        /// Gets or sets if Use Invariant Culture Number Format.
        /// </summary>
        public virtual bool? UseInvariantCultureNumberFormat { get; set; }

        /// <summary>
        /// Gets or sets BuiltIn Templates Paths.
        /// </summary>
        public virtual List<string> BuiltInTemplatesPaths { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public virtual void Validate()
        {

            this.CurrentUser?.Validate();













        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldOptions {\n");
            sb.Append("  CurrentUser: ").Append(this.CurrentUser).Append("\n");
            sb.Append("  CustomTocStyleSeparator: ").Append(this.CustomTocStyleSeparator).Append("\n");
            sb.Append("  DefaultDocumentAuthor: ").Append(this.DefaultDocumentAuthor).Append("\n");
            sb.Append("  FieldIndexFormat: ").Append(this.FieldIndexFormat).Append("\n");
            sb.Append("  FieldUpdateCultureName: ").Append(this.FieldUpdateCultureName).Append("\n");
            sb.Append("  FieldUpdateCultureSource: ").Append(this.FieldUpdateCultureSource).Append("\n");
            sb.Append("  FileName: ").Append(this.FileName).Append("\n");
            sb.Append("  IsBidiTextSupportedOnUpdate: ").Append(this.IsBidiTextSupportedOnUpdate).Append("\n");
            sb.Append("  LegacyNumberFormat: ").Append(this.LegacyNumberFormat).Append("\n");
            sb.Append("  PreProcessCultureName: ").Append(this.PreProcessCultureName).Append("\n");
            sb.Append("  TemplateName: ").Append(this.TemplateName).Append("\n");
            sb.Append("  UseInvariantCultureNumberFormat: ").Append(this.UseInvariantCultureNumberFormat).Append("\n");
            sb.Append("  BuiltInTemplatesPaths: ").Append(this.BuiltInTemplatesPaths).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
