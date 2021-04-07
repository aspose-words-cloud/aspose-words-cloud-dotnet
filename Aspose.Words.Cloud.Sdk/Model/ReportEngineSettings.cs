// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ReportEngineSettings.cs">
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
    /// Report engine settings.
    /// </summary>
    public class ReportEngineSettings
    {
        /// <summary>
        /// Gets or sets type of datasource.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DataSourceTypeEnum
        { 
            /// <summary>
            /// Enum value "Xml"
            /// </summary>
            Xml,

            /// <summary>
            /// Enum value "Json"
            /// </summary>
            Json,

            /// <summary>
            /// Enum value "Csv"
            /// </summary>
            Csv
        }

        /// <summary>
        /// Gets or sets the options for parsing CSV data.
        /// </summary>  
        public CsvDataLoadOptions CsvDataLoadOptions { get; set; }

        /// <summary>
        /// Gets or sets the name to reference the data source object in the template.
        /// </summary>  
        public string DataSourceName { get; set; }

        /// <summary>
        /// Gets or sets type of datasource.
        /// </summary>  
        public DataSourceTypeEnum DataSourceType { get; set; }

        /// <summary>
        /// Gets or sets type of options to build report.
        /// </summary>  
        public List<ReportBuildOptions> ReportBuildOptions { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class ReportEngineSettings {\n");
            sb.Append("  CsvDataLoadOptions: ").Append(this.CsvDataLoadOptions).Append("\n");
            sb.Append("  DataSourceName: ").Append(this.DataSourceName).Append("\n");
            sb.Append("  DataSourceType: ").Append(this.DataSourceType).Append("\n");
            sb.Append("  ReportBuildOptions: ").Append(this.ReportBuildOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
