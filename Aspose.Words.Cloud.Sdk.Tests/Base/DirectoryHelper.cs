// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DirectoryHelper.cs">
//   Copyright (c) 2025 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.Tests.Base
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// This class contains helper methods for working with directories
    /// </summary>
    public static class DirectoryHelper
    {
        /// <summary>
        /// Returns path to folder with test data
        /// </summary>
        /// <param name="parentDir">parent directory</param>
        /// <returns>path to test data folder</returns>
        public static string GetRootSdkFolder(string parentDir = null)
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);

            var info = Directory.GetParent(parentDir ?? Path.GetDirectoryName(path));
            if (info != null)
            {
                var dataFolderExists = info.GetDirectories("Settings");
                if (dataFolderExists.Any())
                {
                    return info.FullName;
                }

                return GetRootSdkFolder(info.FullName);
            }

            throw new ArgumentException("Unexpected folder structure");
        }

        /// <summary>
        /// Get Files with specified extension
        /// </summary>
        /// <param name="directoryPath">folder</param>
        /// <param name="extension">extension</param>
        /// <param name="searchOption">option</param>
        /// <returns>list of files names</returns>
        public static IEnumerable<string> GetFilesByExtension(string directoryPath, string extension, SearchOption searchOption)
        {
            return
                Directory.EnumerateFiles(directoryPath, "*" + extension, searchOption).OrderBy(x => x)
                    .Where(x => string.Equals(Path.GetExtension(x), extension, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
