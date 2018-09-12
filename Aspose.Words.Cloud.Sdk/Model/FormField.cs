// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FormField.cs">
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
  public class FormField : NodeLink 
  {                       
        /// <summary>
        /// Gets or sets CalculateOnExit
        /// </summary>  
        public bool? CalculateOnExit { get; set; }

        /// <summary>
        /// Gets or sets Enabled
        /// </summary>  
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets EntryMacro
        /// </summary>  
        public string EntryMacro { get; set; }

        /// <summary>
        /// Gets or sets ExitMacro
        /// </summary>  
        public string ExitMacro { get; set; }

        /// <summary>
        /// Gets or sets HelpText
        /// </summary>  
        public string HelpText { get; set; }

        /// <summary>
        /// Gets or sets Name
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets OwnHelp
        /// </summary>  
        public bool? OwnHelp { get; set; }

        /// <summary>
        /// Gets or sets OwnStatus
        /// </summary>  
        public bool? OwnStatus { get; set; }

        /// <summary>
        /// Gets or sets StatusText
        /// </summary>  
        public string StatusText { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FormField {\n");
          sb.Append("  CalculateOnExit: ").Append(this.CalculateOnExit).Append("\n");
          sb.Append("  Enabled: ").Append(this.Enabled).Append("\n");
          sb.Append("  EntryMacro: ").Append(this.EntryMacro).Append("\n");
          sb.Append("  ExitMacro: ").Append(this.ExitMacro).Append("\n");
          sb.Append("  HelpText: ").Append(this.HelpText).Append("\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  OwnHelp: ").Append(this.OwnHelp).Append("\n");
          sb.Append("  OwnStatus: ").Append(this.OwnStatus).Append("\n");
          sb.Append("  StatusText: ").Append(this.StatusText).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
