// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SwfSaveOptionsData.cs">
//   Copyright (c) 2016 Aspose.Words for Cloud
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
  /// container class for swf save options
  /// </summary>  
  public class SwfSaveOptionsData : FixedPageSaveOptionsData 
  {                       
        /// <summary>
        /// Allows to enable read mode
        /// </summary>  
        public bool? AllowReadMode { get; set; }

        /// <summary>
        /// Specifies the level in the SWF document outline at which to display Word bookmarks
        /// </summary>  
        public int? BookmarksOutlineLevel { get; set; }

        /// <summary>
        /// Specifies whether the generated SWF document should be compressed or not
        /// </summary>  
        public bool? Compressed { get; set; }

        /// <summary>
        /// Enable/disable context menu
        /// </summary>  
        public bool? EnableContextMenu { get; set; }

        /// <summary>
        /// Specifies how many levels in the SWF document outline to show expanded when the SWF file is viewed
        /// </summary>  
        public int? ExpandedOutlineLevels { get; set; }

        /// <summary>
        /// Specifies how many levels of headings (paragraphs formatted with the Heading styles) to include in the SWF document outline
        /// </summary>  
        public int? HeadingsOutlineLevels { get; set; }

        /// <summary>
        /// Control flags used to configure appearance of left panel of SWF viewer
        /// </summary>  
        public string LeftPaneControlFlags { get; set; }

        /// <summary>
        /// Image that will be displayed as logo in the top right corner of the viewer as string in base64 format
        /// </summary>  
        public string LogoImageBytes { get; set; }

        /// <summary>
        /// Specifies the full hyperlink address for a logo
        /// </summary>  
        public string LogoLink { get; set; }

        /// <summary>
        /// Allows to specify outline options
        /// </summary>  
        public OutlineOptionsData OutlineOptions { get; set; }

        /// <summary>
        /// Show/hide bottom pane
        /// </summary>  
        public bool? ShowBottomPane { get; set; }

        /// <summary>
        /// Show/hide fullscreen button
        /// </summary>  
        public bool? ShowFullScreen { get; set; }

        /// <summary>
        /// Show/hide left pane
        /// </summary>  
        public bool? ShowLeftPane { get; set; }

        /// <summary>
        /// Specifies whether border around pages should be shown
        /// </summary>  
        public bool? ShowPageBorder { get; set; }

        /// <summary>
        /// Show/hide page stepper
        /// </summary>  
        public bool? ShowPageStepper { get; set; }

        /// <summary>
        /// Show/hide search section
        /// </summary>  
        public bool? ShowSearch { get; set; }

        /// <summary>
        /// Show/hide whole top pane
        /// </summary>  
        public bool? ShowTopPane { get; set; }

        /// <summary>
        /// Start with opened left pane
        /// </summary>  
        public bool? StartOpenLeftPane { get; set; }

        /// <summary>
        /// Specifies a font used for tooltips in SWF viewer
        /// </summary>  
        public string ToolTipsFontName { get; set; }

        /// <summary>
        /// Control flags used to configure appearance of top panel of SWF viewer
        /// </summary>  
        public string TopPaneControlFlags { get; set; }

        /// <summary>
        /// Specifies whether the generated SWF document should include the integrated document viewer or not
        /// </summary>  
        public bool? ViewerIncluded { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SwfSaveOptionsData {\n");
          sb.Append("  AllowReadMode: ").Append(this.AllowReadMode).Append("\n");
          sb.Append("  BookmarksOutlineLevel: ").Append(this.BookmarksOutlineLevel).Append("\n");
          sb.Append("  Compressed: ").Append(this.Compressed).Append("\n");
          sb.Append("  EnableContextMenu: ").Append(this.EnableContextMenu).Append("\n");
          sb.Append("  ExpandedOutlineLevels: ").Append(this.ExpandedOutlineLevels).Append("\n");
          sb.Append("  HeadingsOutlineLevels: ").Append(this.HeadingsOutlineLevels).Append("\n");
          sb.Append("  LeftPaneControlFlags: ").Append(this.LeftPaneControlFlags).Append("\n");
          sb.Append("  LogoImageBytes: ").Append(this.LogoImageBytes).Append("\n");
          sb.Append("  LogoLink: ").Append(this.LogoLink).Append("\n");
          sb.Append("  OutlineOptions: ").Append(this.OutlineOptions).Append("\n");
          sb.Append("  ShowBottomPane: ").Append(this.ShowBottomPane).Append("\n");
          sb.Append("  ShowFullScreen: ").Append(this.ShowFullScreen).Append("\n");
          sb.Append("  ShowLeftPane: ").Append(this.ShowLeftPane).Append("\n");
          sb.Append("  ShowPageBorder: ").Append(this.ShowPageBorder).Append("\n");
          sb.Append("  ShowPageStepper: ").Append(this.ShowPageStepper).Append("\n");
          sb.Append("  ShowSearch: ").Append(this.ShowSearch).Append("\n");
          sb.Append("  ShowTopPane: ").Append(this.ShowTopPane).Append("\n");
          sb.Append("  StartOpenLeftPane: ").Append(this.StartOpenLeftPane).Append("\n");
          sb.Append("  ToolTipsFontName: ").Append(this.ToolTipsFontName).Append("\n");
          sb.Append("  TopPaneControlFlags: ").Append(this.TopPaneControlFlags).Append("\n");
          sb.Append("  ViewerIncluded: ").Append(this.ViewerIncluded).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
