// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DocSaveOptionsData.cs">
//   Copyright (c) 2021 Aspose.Words for Cloud
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
    /// Container class for doc/dot save options.
    /// </summary>
    public class DocSaveOptionsData : SaveOptionsData
    {
        /// <summary>
        /// Gets or sets a value indicating when False, that small metafiles are not compressed for performance reason.
        /// The default value is true, all metafiles are compressed regardless of its size.
        /// </summary>  
        public bool? AlwaysCompressMetafiles { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets a value indicating when False, that PictureBullet data is not saved to the output document.
        /// The default value is true.
        /// </summary>  
        public bool? SavePictureBullet { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to save RoutingSlip data to output document.
        /// </summary>  
        public bool? SaveRoutingSlip { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class DocSaveOptionsData {\n");
            sb.Append("  AlwaysCompressMetafiles: ").Append(this.AlwaysCompressMetafiles).Append("\n");
            sb.Append("  Password: ").Append(this.Password).Append("\n");
            sb.Append("  SavePictureBullet: ").Append(this.SavePictureBullet).Append("\n");
            sb.Append("  SaveRoutingSlip: ").Append(this.SaveRoutingSlip).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
