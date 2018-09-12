// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DrawingObject.cs">
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
  public class DrawingObject : DrawingObjectLink 
  {                       
        /// <summary>
        /// Gets or sets RelativeHorizontalPosition
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RelativeHorizontalPositionEnum
        { 
            /// <summary>
            /// Enum Margin for "Margin"
            /// </summary>            
            Margin,
            
            /// <summary>
            /// Enum Page for "Page"
            /// </summary>            
            Page,
            
            /// <summary>
            /// Enum Column for "Column"
            /// </summary>            
            Column,
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum Character for "Character"
            /// </summary>            
            Character,
            
            /// <summary>
            /// Enum LeftMargin for "LeftMargin"
            /// </summary>            
            LeftMargin,
            
            /// <summary>
            /// Enum RightMargin for "RightMargin"
            /// </summary>            
            RightMargin,
            
            /// <summary>
            /// Enum InsideMargin for "InsideMargin"
            /// </summary>            
            InsideMargin,
            
            /// <summary>
            /// Enum OutsideMargin for "OutsideMargin"
            /// </summary>            
            OutsideMargin            
        }

        /// <summary>
        /// Gets or sets RelativeVerticalPosition
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RelativeVerticalPositionEnum
        { 
            /// <summary>
            /// Enum Margin for "Margin"
            /// </summary>            
            Margin,
            
            /// <summary>
            /// Enum TableDefault for "TableDefault"
            /// </summary>            
            TableDefault,
            
            /// <summary>
            /// Enum Page for "Page"
            /// </summary>            
            Page,
            
            /// <summary>
            /// Enum Paragraph for "Paragraph"
            /// </summary>            
            Paragraph,
            
            /// <summary>
            /// Enum TextFrameDefault for "TextFrameDefault"
            /// </summary>            
            TextFrameDefault,
            
            /// <summary>
            /// Enum Line for "Line"
            /// </summary>            
            Line,
            
            /// <summary>
            /// Enum TopMargin for "TopMargin"
            /// </summary>            
            TopMargin,
            
            /// <summary>
            /// Enum BottomMargin for "BottomMargin"
            /// </summary>            
            BottomMargin,
            
            /// <summary>
            /// Enum InsideMargin for "InsideMargin"
            /// </summary>            
            InsideMargin,
            
            /// <summary>
            /// Enum OutsideMargin for "OutsideMargin"
            /// </summary>            
            OutsideMargin            
        }

        /// <summary>
        /// Gets or sets WrapType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WrapTypeEnum
        { 
            /// <summary>
            /// Enum Inline for "Inline"
            /// </summary>            
            Inline,
            
            /// <summary>
            /// Enum TopBottom for "TopBottom"
            /// </summary>            
            TopBottom,
            
            /// <summary>
            /// Enum Square for "Square"
            /// </summary>            
            Square,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Tight for "Tight"
            /// </summary>            
            Tight,
            
            /// <summary>
            /// Enum Through for "Through"
            /// </summary>            
            Through            
        }

        /// <summary>
        /// Gets or sets RelativeHorizontalPosition
        /// </summary>
        public RelativeHorizontalPositionEnum? RelativeHorizontalPosition { get; set; }

        /// <summary>
        /// Gets or sets RelativeVerticalPosition
        /// </summary>
        public RelativeVerticalPositionEnum? RelativeVerticalPosition { get; set; }

        /// <summary>
        /// Gets or sets WrapType
        /// </summary>
        public WrapTypeEnum? WrapType { get; set; }

        /// <summary>
        /// Gets or sets Height
        /// </summary>  
        public double? Height { get; set; }

        /// <summary>
        /// Gets or sets ImageDataLink
        /// </summary>  
        public WordsApiLink ImageDataLink { get; set; }

        /// <summary>
        /// Gets or sets Left
        /// </summary>  
        public double? Left { get; set; }

        /// <summary>
        /// Gets or sets OleDataLink
        /// </summary>  
        public WordsApiLink OleDataLink { get; set; }

        /// <summary>
        /// Gets or sets RenderLinks
        /// </summary>  
        public List<WordsApiLink> RenderLinks { get; set; }

        /// <summary>
        /// Gets or sets Top
        /// </summary>  
        public double? Top { get; set; }

        /// <summary>
        /// Gets or sets Width
        /// </summary>  
        public double? Width { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DrawingObject {\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  ImageDataLink: ").Append(this.ImageDataLink).Append("\n");
          sb.Append("  Left: ").Append(this.Left).Append("\n");
          sb.Append("  OleDataLink: ").Append(this.OleDataLink).Append("\n");
          sb.Append("  RelativeHorizontalPosition: ").Append(this.RelativeHorizontalPosition).Append("\n");
          sb.Append("  RelativeVerticalPosition: ").Append(this.RelativeVerticalPosition).Append("\n");
          sb.Append("  RenderLinks: ").Append(this.RenderLinks).Append("\n");
          sb.Append("  Top: ").Append(this.Top).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  WrapType: ").Append(this.WrapType).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
