// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UrlHelper.cs">
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

namespace Aspose.Words.Cloud.Sdk
{
    using System;
    using System.Text.RegularExpressions;
    using System.Web;

    internal class UrlHelper
    {
        public static string AddPathParameter(string url, string parameterName, object parameterValue)
        {
            if (parameterValue == null || string.IsNullOrEmpty(parameterValue.ToString()))
            {
                url = url.Replace("/{" + parameterName + "}", string.Empty);
            }
            else
            {
                url = url.Replace("{" + parameterName + "}", parameterValue.ToString());
            }

            return url;
        }        

        public static string AddQueryParameterToUrl(string url, string parameterName, object parameterValue)
        {
            if (url.Contains("{" + parameterName + "}"))
            {               
                url = AddPathParameter(url, parameterName, parameterValue);
                return url;
            }

            if (url.Contains("%7B" + parameterName + "%7D"))
            {
                url = url.Replace("%7B", "{").Replace("%7D", "}");
                url = AddPathParameter(url, parameterName, parameterValue);
                return url;
            }
           
            if (parameterValue == null)
            {
                return url;
            }

            var uriBuilder = new UriBuilder(url);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query.Add(parameterName, parameterValue.ToString());
            uriBuilder.Query = query.ToString();

            return uriBuilder.ToString();
        }
    }
}