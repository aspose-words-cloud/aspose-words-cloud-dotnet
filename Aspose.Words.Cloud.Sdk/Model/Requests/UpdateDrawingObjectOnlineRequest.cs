// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UpdateDrawingObjectOnlineRequest.cs">
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

namespace Aspose.Words.Cloud.Sdk.Model.Requests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Text.RegularExpressions;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Responses;

    /// <summary>
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.UpdateDrawingObjectOnline" /> operation.
    /// </summary>
    public class UpdateDrawingObjectOnlineRequest : IRequestModel, ICanModifyDocumentRequest, ICanSaveRevisionRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDrawingObjectOnlineRequest"/> class.
        /// </summary>
        public UpdateDrawingObjectOnlineRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDrawingObjectOnlineRequest"/> class.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="drawingObject">Drawing object parameters.</param>
        /// <param name="imageFile">File with image.</param>
        /// <param name="index">Object index.</param>
        /// <param name="nodePath">The path to the node in the document tree.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        /// <param name="destFileName">Result path of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param>
        /// <param name="revisionDateTime">The date and time to use for revisions.</param>
        public UpdateDrawingObjectOnlineRequest(System.IO.Stream document, DrawingObjectUpdate drawingObject, System.IO.Stream imageFile, int index, string nodePath = null, string loadEncoding = null, string password = null, string destFileName = null, string revisionAuthor = null, string revisionDateTime = null)
        {
            this.Document = document;
            this.DrawingObject = drawingObject;
            this.ImageFile = imageFile;
            this.Index = index;
            this.NodePath = nodePath;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.DestFileName = destFileName;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
        }

        /// <summary>
        /// The document.
        /// </summary>
        public System.IO.Stream Document { get; set; }

        /// <summary>
        /// Drawing object parameters.
        /// </summary>
        public DrawingObjectUpdate DrawingObject { get; set; }

        /// <summary>
        /// File with image.
        /// </summary>
        public System.IO.Stream ImageFile { get; set; }

        /// <summary>
        /// Object index.
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// The path to the node in the document tree.
        /// </summary>
        public string NodePath { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Result path of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>
        public string DestFileName { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="configuration">SDK configuration.</param>
        /// <returns>The http request instance.</returns>
        public HttpRequestMessage CreateHttpRequest(Configuration configuration)
        {
            // verify the required parameter 'document' is set
            if (this.Document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling UpdateDrawingObjectOnline");
            }

            // verify the required parameter 'drawingObject' is set
            if (this.DrawingObject == null)
            {
                throw new ApiException(400, "Missing required parameter 'drawingObject' when calling UpdateDrawingObjectOnline");
            }

            // verify the required parameter 'imageFile' is set
            if (this.ImageFile == null)
            {
                throw new ApiException(400, "Missing required parameter 'imageFile' when calling UpdateDrawingObjectOnline");
            }

            var path = configuration.GetApiRootUrl() + "/words/online/put/{nodePath}/drawingObjects/{index}";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = UrlHelper.AddPathParameter(path, "index", this.Index);
            path = UrlHelper.AddPathParameter(path, "nodePath", this.NodePath);
            path = UrlHelper.AddQueryParameterToUrl(path, "loadEncoding", this.LoadEncoding);
            path = UrlHelper.AddQueryParameterToUrl(path, "password", this.Password);
            path = UrlHelper.AddQueryParameterToUrl(path, "destFileName", this.DestFileName);
            path = UrlHelper.AddQueryParameterToUrl(path, "revisionAuthor", this.RevisionAuthor);
            path = UrlHelper.AddQueryParameterToUrl(path, "revisionDateTime", this.RevisionDateTime);

            var result = new HttpRequestMessage(HttpMethod.Put, path);
            var formData = new Dictionary<string, object>();
            if (this.Document != null)
            {
                formData.Add("document", new Aspose.Words.Cloud.Sdk.FileInfo() { Name = "Document", FileContent = StreamHelper.ReadAsBytes(this.Document) });
            }

            if (this.DrawingObject != null)
            {
                formData.Add("DrawingObject", this.DrawingObject);
            }

            if (this.ImageFile != null)
            {
                formData.Add("imageFile", new Aspose.Words.Cloud.Sdk.FileInfo() { Name = "ImageFile", FileContent = StreamHelper.ReadAsBytes(this.ImageFile) });
            }

            if (formData.Count > 0)
            {
                result.Content = ApiInvoker.GetMultipartFormData(formData);
            }

            return result;
        }

        /// <summary>
        /// Deserialize response object.
        /// </summary>
        /// <param name="message">Response message.</param>
        /// <returns>Response type.</returns>
        public object DeserializeResponse(HttpResponseMessage message)
        {
            var multipart = ApiInvoker.ToMultipartForm(message);
            return new UpdateDrawingObjectOnlineResponse(
                model: (DrawingObjectResponse)SerializationHelper.Deserialize(
                    new StreamReader(multipart["Model"], System.Text.Encoding.UTF8).ReadToEnd(),
                    typeof(DrawingObjectResponse)),
                document: multipart["Document"]
            );
        }
    }
}
