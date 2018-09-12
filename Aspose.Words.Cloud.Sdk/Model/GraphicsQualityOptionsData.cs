// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GraphicsQualityOptionsData.cs">
//   Copyright (c) 2018 Aspose.Words for Cloud
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
  /// 
  /// </summary>  
  public class GraphicsQualityOptionsData 
  {                       
        /// <summary>
        /// Gets or sets CompositingMode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompositingModeEnum
        { 
            /// <summary>
            /// Enum SourceOver for "SourceOver"
            /// </summary>            
            SourceOver,
            
            /// <summary>
            /// Enum SourceCopy for "SourceCopy"
            /// </summary>            
            SourceCopy            
        }

        /// <summary>
        /// Gets or sets CompositingQuality
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompositingQualityEnum
        { 
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum HighSpeed for "HighSpeed"
            /// </summary>            
            HighSpeed,
            
            /// <summary>
            /// Enum HighQuality for "HighQuality"
            /// </summary>            
            HighQuality,
            
            /// <summary>
            /// Enum GammaCorrected for "GammaCorrected"
            /// </summary>            
            GammaCorrected,
            
            /// <summary>
            /// Enum AssumeLinear for "AssumeLinear"
            /// </summary>            
            AssumeLinear,
            
            /// <summary>
            /// Enum Invalid for "Invalid"
            /// </summary>            
            Invalid            
        }

        /// <summary>
        /// Gets or sets InterpolationMode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InterpolationModeEnum
        { 
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum Low for "Low"
            /// </summary>            
            Low,
            
            /// <summary>
            /// Enum High for "High"
            /// </summary>            
            High,
            
            /// <summary>
            /// Enum Bilinear for "Bilinear"
            /// </summary>            
            Bilinear,
            
            /// <summary>
            /// Enum Bicubic for "Bicubic"
            /// </summary>            
            Bicubic,
            
            /// <summary>
            /// Enum NearestNeighbor for "NearestNeighbor"
            /// </summary>            
            NearestNeighbor,
            
            /// <summary>
            /// Enum HighQualityBilinear for "HighQualityBilinear"
            /// </summary>            
            HighQualityBilinear,
            
            /// <summary>
            /// Enum HighQualityBicubic for "HighQualityBicubic"
            /// </summary>            
            HighQualityBicubic,
            
            /// <summary>
            /// Enum Invalid for "Invalid"
            /// </summary>            
            Invalid            
        }

        /// <summary>
        /// Gets or sets SmoothingMode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SmoothingModeEnum
        { 
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum HighSpeed for "HighSpeed"
            /// </summary>            
            HighSpeed,
            
            /// <summary>
            /// Enum HighQuality for "HighQuality"
            /// </summary>            
            HighQuality,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum AntiAlias for "AntiAlias"
            /// </summary>            
            AntiAlias,
            
            /// <summary>
            /// Enum Invalid for "Invalid"
            /// </summary>            
            Invalid            
        }

        /// <summary>
        /// Gets or sets TextRenderingHint
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextRenderingHintEnum
        { 
            /// <summary>
            /// Enum SystemDefault for "SystemDefault"
            /// </summary>            
            SystemDefault,
            
            /// <summary>
            /// Enum SingleBitPerPixelGridFit for "SingleBitPerPixelGridFit"
            /// </summary>            
            SingleBitPerPixelGridFit,
            
            /// <summary>
            /// Enum SingleBitPerPixel for "SingleBitPerPixel"
            /// </summary>            
            SingleBitPerPixel,
            
            /// <summary>
            /// Enum AntiAliasGridFit for "AntiAliasGridFit"
            /// </summary>            
            AntiAliasGridFit,
            
            /// <summary>
            /// Enum AntiAlias for "AntiAlias"
            /// </summary>            
            AntiAlias,
            
            /// <summary>
            /// Enum ClearTypeGridFit for "ClearTypeGridFit"
            /// </summary>            
            ClearTypeGridFit            
        }

        /// <summary>
        /// Gets or sets CompositingMode
        /// </summary>
        public CompositingModeEnum? CompositingMode { get; set; }

        /// <summary>
        /// Gets or sets CompositingQuality
        /// </summary>
        public CompositingQualityEnum? CompositingQuality { get; set; }

        /// <summary>
        /// Gets or sets InterpolationMode
        /// </summary>
        public InterpolationModeEnum? InterpolationMode { get; set; }

        /// <summary>
        /// Gets or sets SmoothingMode
        /// </summary>
        public SmoothingModeEnum? SmoothingMode { get; set; }

        /// <summary>
        /// Gets or sets TextRenderingHint
        /// </summary>
        public TextRenderingHintEnum? TextRenderingHint { get; set; }

        /// <summary>
        /// Gets or sets StringFormat
        /// </summary>  
        public StringFormatData StringFormat { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class GraphicsQualityOptionsData {\n");
          sb.Append("  CompositingMode: ").Append(this.CompositingMode).Append("\n");
          sb.Append("  CompositingQuality: ").Append(this.CompositingQuality).Append("\n");
          sb.Append("  InterpolationMode: ").Append(this.InterpolationMode).Append("\n");
          sb.Append("  SmoothingMode: ").Append(this.SmoothingMode).Append("\n");
          sb.Append("  StringFormat: ").Append(this.StringFormat).Append("\n");
          sb.Append("  TextRenderingHint: ").Append(this.TextRenderingHint).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
