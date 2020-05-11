// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Shading.cs">
//   Copyright (c) 2019 Aspose.Words for Cloud
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
  /// Paragraph format shading element.             
  /// </summary>  
  public class Shading 
  {                       
        /// <summary>
        /// Gets or sets the shading texture.
        /// </summary>
        /// <value>Gets or sets the shading texture.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextureEnum
        { 
            /// <summary>
            /// Enum value "TextureNone"
            /// </summary>
            TextureNone,
            
            /// <summary>
            /// Enum value "TextureSolid"
            /// </summary>
            TextureSolid,
            
            /// <summary>
            /// Enum value "Texture5Percent"
            /// </summary>
            Texture5Percent,
            
            /// <summary>
            /// Enum value "Texture10Percent"
            /// </summary>
            Texture10Percent,
            
            /// <summary>
            /// Enum value "Texture20Percent"
            /// </summary>
            Texture20Percent,
            
            /// <summary>
            /// Enum value "Texture25Percent"
            /// </summary>
            Texture25Percent,
            
            /// <summary>
            /// Enum value "Texture30Percent"
            /// </summary>
            Texture30Percent,
            
            /// <summary>
            /// Enum value "Texture40Percent"
            /// </summary>
            Texture40Percent,
            
            /// <summary>
            /// Enum value "Texture50Percent"
            /// </summary>
            Texture50Percent,
            
            /// <summary>
            /// Enum value "Texture60Percent"
            /// </summary>
            Texture60Percent,
            
            /// <summary>
            /// Enum value "Texture70Percent"
            /// </summary>
            Texture70Percent,
            
            /// <summary>
            /// Enum value "Texture75Percent"
            /// </summary>
            Texture75Percent,
            
            /// <summary>
            /// Enum value "Texture80Percent"
            /// </summary>
            Texture80Percent,
            
            /// <summary>
            /// Enum value "Texture90Percent"
            /// </summary>
            Texture90Percent,
            
            /// <summary>
            /// Enum value "TextureDarkHorizontal"
            /// </summary>
            TextureDarkHorizontal,
            
            /// <summary>
            /// Enum value "TextureDarkVertical"
            /// </summary>
            TextureDarkVertical,
            
            /// <summary>
            /// Enum value "TextureDarkDiagonalDown"
            /// </summary>
            TextureDarkDiagonalDown,
            
            /// <summary>
            /// Enum value "TextureDarkDiagonalUp"
            /// </summary>
            TextureDarkDiagonalUp,
            
            /// <summary>
            /// Enum value "TextureDarkCross"
            /// </summary>
            TextureDarkCross,
            
            /// <summary>
            /// Enum value "TextureDarkDiagonalCross"
            /// </summary>
            TextureDarkDiagonalCross,
            
            /// <summary>
            /// Enum value "TextureHorizontal"
            /// </summary>
            TextureHorizontal,
            
            /// <summary>
            /// Enum value "TextureVertical"
            /// </summary>
            TextureVertical,
            
            /// <summary>
            /// Enum value "TextureDiagonalDown"
            /// </summary>
            TextureDiagonalDown,
            
            /// <summary>
            /// Enum value "TextureDiagonalUp"
            /// </summary>
            TextureDiagonalUp,
            
            /// <summary>
            /// Enum value "TextureCross"
            /// </summary>
            TextureCross,
            
            /// <summary>
            /// Enum value "TextureDiagonalCross"
            /// </summary>
            TextureDiagonalCross,
            
            /// <summary>
            /// Enum value "Texture2Pt5Percent"
            /// </summary>
            Texture2Pt5Percent,
            
            /// <summary>
            /// Enum value "Texture7Pt5Percent"
            /// </summary>
            Texture7Pt5Percent,
            
            /// <summary>
            /// Enum value "Texture12Pt5Percent"
            /// </summary>
            Texture12Pt5Percent,
            
            /// <summary>
            /// Enum value "Texture15Percent"
            /// </summary>
            Texture15Percent,
            
            /// <summary>
            /// Enum value "Texture17Pt5Percent"
            /// </summary>
            Texture17Pt5Percent,
            
            /// <summary>
            /// Enum value "Texture22Pt5Percent"
            /// </summary>
            Texture22Pt5Percent,
            
            /// <summary>
            /// Enum value "Texture27Pt5Percent"
            /// </summary>
            Texture27Pt5Percent,
            
            /// <summary>
            /// Enum value "Texture32Pt5Percent"
            /// </summary>
            Texture32Pt5Percent,
            
            /// <summary>
            /// Enum value "Texture35Percent"
            /// </summary>
            Texture35Percent,
            
            /// <summary>
            /// Enum value "Texture37Pt5Percent"
            /// </summary>
            Texture37Pt5Percent,
            
            /// <summary>
            /// Enum value "Texture42Pt5Percent"
            /// </summary>
            Texture42Pt5Percent,
            
            /// <summary>
            /// Enum value "Texture45Percent"
            /// </summary>
            Texture45Percent,
            
            /// <summary>
            /// Enum value "Texture47Pt5Percent"
            /// </summary>
            Texture47Pt5Percent,
            
            /// <summary>
            /// Enum value "Texture52Pt5Percent"
            /// </summary>
            Texture52Pt5Percent,
            
            /// <summary>
            /// Enum value "Texture55Percent"
            /// </summary>
            Texture55Percent,
            
            /// <summary>
            /// Enum value "Texture57Pt5Percent"
            /// </summary>
            Texture57Pt5Percent,
            
            /// <summary>
            /// Enum value "Texture62Pt5Percent"
            /// </summary>
            Texture62Pt5Percent,
            
            /// <summary>
            /// Enum value "Texture65Percent"
            /// </summary>
            Texture65Percent,
            
            /// <summary>
            /// Enum value "Texture67Pt5Percent"
            /// </summary>
            Texture67Pt5Percent,
            
            /// <summary>
            /// Enum value "Texture72Pt5Percent"
            /// </summary>
            Texture72Pt5Percent,
            
            /// <summary>
            /// Enum value "Texture77Pt5Percent"
            /// </summary>
            Texture77Pt5Percent,
            
            /// <summary>
            /// Enum value "Texture82Pt5Percent"
            /// </summary>
            Texture82Pt5Percent,
            
            /// <summary>
            /// Enum value "Texture85Percent"
            /// </summary>
            Texture85Percent,
            
            /// <summary>
            /// Enum value "Texture87Pt5Percent"
            /// </summary>
            Texture87Pt5Percent,
            
            /// <summary>
            /// Enum value "Texture92Pt5Percent"
            /// </summary>
            Texture92Pt5Percent,
            
            /// <summary>
            /// Enum value "Texture95Percent"
            /// </summary>
            Texture95Percent,
            
            /// <summary>
            /// Enum value "Texture97Pt5Percent"
            /// </summary>
            Texture97Pt5Percent,
            
            /// <summary>
            /// Enum value "TextureNil"
            /// </summary>
            TextureNil            
        }

        /// <summary>
        /// Gets or sets the shading texture.
        /// </summary>
        public TextureEnum? Texture { get; set; }

        /// <summary>
        /// Gets or sets BackgroundPatternColor
        /// </summary>  
        public XmlColor BackgroundPatternColor { get; set; }

        /// <summary>
        /// Gets or sets ForegroundPatternColor
        /// </summary>  
        public XmlColor ForegroundPatternColor { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Shading {\n");
          sb.Append("  BackgroundPatternColor: ").Append(this.BackgroundPatternColor).Append("\n");
          sb.Append("  ForegroundPatternColor: ").Append(this.ForegroundPatternColor).Append("\n");
          sb.Append("  Texture: ").Append(this.Texture).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
