// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SignDocumentOnlineResponse.cs">
//   Copyright (c) 2024 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.Model.Responses
{
    using Aspose.Words.Cloud.Sdk.Model;

    /// <summary>
    /// Response model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.SignDocumentOnline" /> operation.
    /// </summary>
    public class SignDocumentOnlineResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignDocumentOnlineResponse"/> class.
        /// </summary>
        /// <param name="model">The REST response with a document signature collection. This response is returned by the Service when handling any "https://api.aspose.cloud/v4.0/words/Test.doc/signatures" REST API requests.</param>
        /// <param name="document">The document after modification.</param>
        public SignDocumentOnlineResponse(SignatureCollectionResponse model, System.Collections.Generic.Dictionary<string, System.IO.Stream> document)
        {
            this.Model = model;
            this.Document = document;
        }

        /// <summary>
        /// The REST response with a document signature collection.
        /// This response is returned by the Service when handling any "https://api.aspose.cloud/v4.0/words/Test.doc/signatures" REST API requests.
        /// </summary>
        public SignatureCollectionResponse Model { get; private set; }

        /// <summary>
        /// The document after modification.
        /// </summary>
        public System.Collections.Generic.Dictionary<string, System.IO.Stream> Document { get; private set; }
    }
}