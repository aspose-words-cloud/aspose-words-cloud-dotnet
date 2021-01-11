// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ApiExceptionRequestHandler.cs">
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

namespace Aspose.Words.Cloud.Sdk.RequestHandlers
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;

    using Aspose.Words.Cloud.Sdk.Model;

    internal class ApiExceptionRequestHandler : IRequestHandler
    {
        public void ProcessRequest(HttpRequestMessage request)
        {
        }

        public void ProcessResponse(HttpResponseMessage response)
        {
            if (response.StatusCode != HttpStatusCode.OK)
            {
                ApiExceptionRequestHandler.ThrowApiException(response);
            }
        }

        internal static void ThrowApiException(HttpResponseMessage response)
        {
            Exception resutException;
            try
            {
                var responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                var errorResponse = (WordsApiErrorResponse)SerializationHelper.Deserialize(responseData, typeof(WordsApiErrorResponse));
                if (string.IsNullOrEmpty(errorResponse.Error.Message))
                {
                    errorResponse.Error.Message = responseData;
                }

                resutException = new ApiException((int)response.StatusCode, errorResponse.Error.Message);
            }          
            catch (Exception)
            {
                throw new ApiException((int)response.StatusCode, response.ReasonPhrase);
            }

            throw resutException;
        }
    }
}
