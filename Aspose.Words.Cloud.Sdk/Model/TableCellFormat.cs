// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TableCellFormat.cs">
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
  public class TableCellFormat : LinkElement 
  {                       
        /// <summary>
        /// Gets or sets HorizontalMerge
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HorizontalMergeEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum First for "First"
            /// </summary>            
            First,
            
            /// <summary>
            /// Enum Previous for "Previous"
            /// </summary>            
            Previous            
        }

        /// <summary>
        /// Gets or sets Orientation
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrientationEnum
        { 
            /// <summary>
            /// Enum Horizontal for "Horizontal"
            /// </summary>            
            Horizontal,
            
            /// <summary>
            /// Enum Downward for "Downward"
            /// </summary>            
            Downward,
            
            /// <summary>
            /// Enum Upward for "Upward"
            /// </summary>            
            Upward,
            
            /// <summary>
            /// Enum HorizontalRotatedFarEast for "HorizontalRotatedFarEast"
            /// </summary>            
            HorizontalRotatedFarEast,
            
            /// <summary>
            /// Enum VerticalFarEast for "VerticalFarEast"
            /// </summary>            
            VerticalFarEast,
            
            /// <summary>
            /// Enum VerticalRotatedFarEast for "VerticalRotatedFarEast"
            /// </summary>            
            VerticalRotatedFarEast            
        }

        /// <summary>
        /// Gets or sets VerticalAlignment
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VerticalAlignmentEnum
        { 
            /// <summary>
            /// Enum Top for "Top"
            /// </summary>            
            Top,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>            
            Center,
            
            /// <summary>
            /// Enum Bottom for "Bottom"
            /// </summary>            
            Bottom            
        }

        /// <summary>
        /// Gets or sets VerticalMerge
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VerticalMergeEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum First for "First"
            /// </summary>            
            First,
            
            /// <summary>
            /// Enum Previous for "Previous"
            /// </summary>            
            Previous            
        }

        /// <summary>
        /// Gets or sets HorizontalMerge
        /// </summary>
        public HorizontalMergeEnum? HorizontalMerge { get; set; }

        /// <summary>
        /// Gets or sets Orientation
        /// </summary>
        public OrientationEnum? Orientation { get; set; }

        /// <summary>
        /// Gets or sets VerticalAlignment
        /// </summary>
        public VerticalAlignmentEnum? VerticalAlignment { get; set; }

        /// <summary>
        /// Gets or sets VerticalMerge
        /// </summary>
        public VerticalMergeEnum? VerticalMerge { get; set; }

        /// <summary>
        /// Gets or sets BottomPadding
        /// </summary>  
        public double? BottomPadding { get; set; }

        /// <summary>
        /// Gets or sets FitText
        /// </summary>  
        public bool? FitText { get; set; }

        /// <summary>
        /// Gets or sets LeftPadding
        /// </summary>  
        public double? LeftPadding { get; set; }

        /// <summary>
        /// Gets or sets PreferredWidth
        /// </summary>  
        public PreferredWidth PreferredWidth { get; set; }

        /// <summary>
        /// Gets or sets RightPadding
        /// </summary>  
        public double? RightPadding { get; set; }

        /// <summary>
        /// Gets or sets TopPadding
        /// </summary>  
        public double? TopPadding { get; set; }

        /// <summary>
        /// Gets or sets Width
        /// </summary>  
        public double? Width { get; set; }

        /// <summary>
        /// Gets or sets WrapText
        /// </summary>  
        public bool? WrapText { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TableCellFormat {\n");
          sb.Append("  BottomPadding: ").Append(this.BottomPadding).Append("\n");
          sb.Append("  FitText: ").Append(this.FitText).Append("\n");
          sb.Append("  HorizontalMerge: ").Append(this.HorizontalMerge).Append("\n");
          sb.Append("  LeftPadding: ").Append(this.LeftPadding).Append("\n");
          sb.Append("  Orientation: ").Append(this.Orientation).Append("\n");
          sb.Append("  PreferredWidth: ").Append(this.PreferredWidth).Append("\n");
          sb.Append("  RightPadding: ").Append(this.RightPadding).Append("\n");
          sb.Append("  TopPadding: ").Append(this.TopPadding).Append("\n");
          sb.Append("  VerticalAlignment: ").Append(this.VerticalAlignment).Append("\n");
          sb.Append("  VerticalMerge: ").Append(this.VerticalMerge).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  WrapText: ").Append(this.WrapText).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
