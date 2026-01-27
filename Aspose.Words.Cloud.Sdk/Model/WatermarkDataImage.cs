// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WatermarkDataImage.cs">
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
    /// Class for insert watermark image request building.
    /// </summary>
    public class WatermarkDataImage : WatermarkDataBase, IFileReference, IModel
    {
        /// <summary>
        /// Gets or sets the watermark image.
        /// </summary>
        public virtual FileReference Image { get; set; }

        /// <summary>
        /// Gets or sets a boolean value which is responsible for washout effect of the watermark. The default value is true.
        /// </summary>
        public virtual bool? IsWashout { get; set; }

        /// <summary>
        /// Gets or sets the scale factor expressed as a fraction of the image. The default value is 0 - auto.
        /// Valid values range from 0 to 65.5 inclusive. Auto scale means that the watermark will be scaled to its max width and max height relative to the page margins.
        /// </summary>
        public virtual double? Scale { get; set; }

        /// <summary>
        /// Collect all files content properties.
        /// </summary>
        /// <param name="resultFileReferences">File references collection used to append new references from current model.</param>
        public override void CollectFileReferences(ref List<FileReference> resultFileReferences)
        {
            base.CollectFileReferences(ref resultFileReferences);
            if (this.Image != null)
            {
                this.Image.CollectFileReferences(ref resultFileReferences);
            }



        }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (this.Image == null)
            {
                throw new ArgumentException("Property Image in WatermarkDataImage is required.");
            }

            this.Image?.Validate();



        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WatermarkDataImage {\n");
            sb.Append("  Image: ").Append(this.Image).Append("\n");
            sb.Append("  IsWashout: ").Append(this.IsWashout).Append("\n");
            sb.Append("  Scale: ").Append(this.Scale).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
