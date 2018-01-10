// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Document.cs">
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
  /// Represents Words document DTO.
  /// </summary>  
  public class Document 
  {                       
        /// <summary>
        /// Gets the original format of the document.
        /// </summary>
        /// <value>Gets the original format of the document.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceFormatEnum
        { 
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>            
            Unknown,
            
            /// <summary>
            /// Enum Doc for "Doc"
            /// </summary>            
            Doc,
            
            /// <summary>
            /// Enum Dot for "Dot"
            /// </summary>            
            Dot,
            
            /// <summary>
            /// Enum DocPreWord60 for "DocPreWord60"
            /// </summary>            
            DocPreWord60,
            
            /// <summary>
            /// Enum Docx for "Docx"
            /// </summary>            
            Docx,
            
            /// <summary>
            /// Enum Docm for "Docm"
            /// </summary>            
            Docm,
            
            /// <summary>
            /// Enum Dotx for "Dotx"
            /// </summary>            
            Dotx,
            
            /// <summary>
            /// Enum Dotm for "Dotm"
            /// </summary>            
            Dotm,
            
            /// <summary>
            /// Enum FlatOpc for "FlatOpc"
            /// </summary>            
            FlatOpc,
            
            /// <summary>
            /// Enum Rtf for "Rtf"
            /// </summary>            
            Rtf,
            
            /// <summary>
            /// Enum WordML for "WordML"
            /// </summary>            
            WordML,
            
            /// <summary>
            /// Enum Html for "Html"
            /// </summary>            
            Html,
            
            /// <summary>
            /// Enum Mhtml for "Mhtml"
            /// </summary>            
            Mhtml,
            
            /// <summary>
            /// Enum Epub for "Epub"
            /// </summary>            
            Epub,
            
            /// <summary>
            /// Enum Text for "Text"
            /// </summary>            
            Text,
            
            /// <summary>
            /// Enum Odt for "Odt"
            /// </summary>            
            Odt,
            
            /// <summary>
            /// Enum Ott for "Ott"
            /// </summary>            
            Ott,
            
            /// <summary>
            /// Enum Pdf for "Pdf"
            /// </summary>            
            Pdf,
            
            /// <summary>
            /// Enum Xps for "Xps"
            /// </summary>            
            Xps,
            
            /// <summary>
            /// Enum Swf for "Swf"
            /// </summary>            
            Swf,
            
            /// <summary>
            /// Enum Tiff for "Tiff"
            /// </summary>            
            Tiff,
            
            /// <summary>
            /// Enum Svg for "Svg"
            /// </summary>            
            Svg            
        }

        /// <summary>
        /// Gets the original format of the document.
        /// </summary>
        public SourceFormatEnum? SourceFormat { get; set; }

        /// <summary>
        /// A list of links that originate from this document.
        /// </summary>  
        public List<Link> Links { get; set; }

        /// <summary>
        /// Gets the name of the file.
        /// </summary>  
        public string FileName { get; set; }

        /// <summary>
        /// Returns true if the document is encrypted and requires a password to open. 
        /// </summary>  
        public bool? IsEncrypted { get; set; }

        /// <summary>
        /// Returns true if the document contains a digital signature. This property merely informs that a  digital signature is present on a document, but it does not specify whether the signature is valid or not. 
        /// </summary>  
        public bool? IsSigned { get; set; }

        /// <summary>
        /// Returns document properties.
        /// </summary>  
        public DocumentProperties DocumentProperties { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Document {\n");
          sb.Append("  Links: ").Append(this.Links).Append("\n");
          sb.Append("  FileName: ").Append(this.FileName).Append("\n");
          sb.Append("  SourceFormat: ").Append(this.SourceFormat).Append("\n");
          sb.Append("  IsEncrypted: ").Append(this.IsEncrypted).Append("\n");
          sb.Append("  IsSigned: ").Append(this.IsSigned).Append("\n");
          sb.Append("  DocumentProperties: ").Append(this.DocumentProperties).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
