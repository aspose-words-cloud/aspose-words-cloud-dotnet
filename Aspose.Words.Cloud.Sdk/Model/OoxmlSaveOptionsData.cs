// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OoxmlSaveOptionsData.cs">
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
    /// Container class for docx/docm/dotx/dotm/flatopc save options.
    /// </summary>
    public abstract class OoxmlSaveOptionsData : SaveOptionsData
    {
        /// <summary>
        /// Gets or sets the oOXML version for the output document.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ComplianceEnum
        {
            /// <summary>
            /// Enum value "Ecma376_2006"
            /// </summary>
            Ecma376_2006,

            /// <summary>
            /// Enum value "Iso29500_2008_Transitional"
            /// </summary>
            Iso29500_2008_Transitional,

            /// <summary>
            /// Enum value "Iso29500_2008_Strict"
            /// </summary>
            Iso29500_2008_Strict,
        }

        /// <summary>
        /// Gets or sets the compression level.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompressionLevelEnum
        {
            /// <summary>
            /// Enum value "Normal"
            /// </summary>
            Normal,

            /// <summary>
            /// Enum value "Maximum"
            /// </summary>
            Maximum,

            /// <summary>
            /// Enum value "Fast"
            /// </summary>
            Fast,

            /// <summary>
            /// Enum value "SuperFast"
            /// </summary>
            SuperFast,
        }

        /// <summary>
        /// Gets or sets the oOXML version for the output document.
        /// </summary>
        public virtual ComplianceEnum? Compliance { get; set; }

        /// <summary>
        /// Gets or sets the compression level.
        /// </summary>
        public virtual CompressionLevelEnum? CompressionLevel { get; set; }

        /// <summary>
        /// Gets or sets the password to encrypt document using ECMA376 Standard encryption algorithm.
        /// </summary>
        public virtual string Password { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use pretty formats output.
        /// </summary>
        public virtual bool? PrettyFormat { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OoxmlSaveOptionsData {\n");
            sb.Append("  AllowEmbeddingPostScriptFonts: ").Append(this.AllowEmbeddingPostScriptFonts).Append("\n");
            sb.Append("  CustomTimeZoneInfoData: ").Append(this.CustomTimeZoneInfoData).Append("\n");
            sb.Append("  Dml3DEffectsRenderingMode: ").Append(this.Dml3DEffectsRenderingMode).Append("\n");
            sb.Append("  DmlEffectsRenderingMode: ").Append(this.DmlEffectsRenderingMode).Append("\n");
            sb.Append("  DmlRenderingMode: ").Append(this.DmlRenderingMode).Append("\n");
            sb.Append("  FileName: ").Append(this.FileName).Append("\n");
            sb.Append("  ImlRenderingMode: ").Append(this.ImlRenderingMode).Append("\n");
            sb.Append("  UpdateCreatedTimeProperty: ").Append(this.UpdateCreatedTimeProperty).Append("\n");
            sb.Append("  UpdateFields: ").Append(this.UpdateFields).Append("\n");
            sb.Append("  UpdateLastPrintedProperty: ").Append(this.UpdateLastPrintedProperty).Append("\n");
            sb.Append("  UpdateLastSavedTimeProperty: ").Append(this.UpdateLastSavedTimeProperty).Append("\n");
            sb.Append("  ZipOutput: ").Append(this.ZipOutput).Append("\n");
            sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
            sb.Append("  Compliance: ").Append(this.Compliance).Append("\n");
            sb.Append("  CompressionLevel: ").Append(this.CompressionLevel).Append("\n");
            sb.Append("  Password: ").Append(this.Password).Append("\n");
            sb.Append("  PrettyFormat: ").Append(this.PrettyFormat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
