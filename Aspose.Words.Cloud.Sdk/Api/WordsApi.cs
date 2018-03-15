// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WordsApi.cs">
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

namespace Aspose.Words.Cloud.Sdk
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.RequestHandlers;
    
    /// <summary>
    /// Aspose.Words for Cloud API.
    /// </summary>
    public class WordsApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="WordsApi"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        public WordsApi(string apiKey, string appSid)
            : this(new Configuration { AppKey = apiKey, AppSid = appSid })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordsApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public WordsApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new OAuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            requestHandlers.Add(new AuthWithSignatureRequestHandler(this.configuration));
            this.apiInvoker = new ApiInvoker(requestHandlers);
        }                            

        /// <summary>
        /// Accept all revisions in document 
        /// </summary>
        /// <param name="request">Request. <see cref="AcceptAllRevisionsRequest" /></param> 
        /// <returns><see cref="RevisionsModificationResponse"/></returns>            
        public RevisionsModificationResponse AcceptAllRevisions(AcceptAllRevisionsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling AcceptAllRevisions");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/revisions/acceptAll";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (RevisionsModificationResponse)SerializationHelper.Deserialize(response, typeof(RevisionsModificationResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Add new or update existing document property. 
        /// </summary>
        /// <param name="request">Request. <see cref="CreateOrUpdateDocumentPropertyRequest" /></param> 
        /// <returns><see cref="DocumentPropertyResponse"/></returns>            
        public DocumentPropertyResponse CreateOrUpdateDocumentProperty(CreateOrUpdateDocumentPropertyRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateOrUpdateDocumentProperty");
            }

            // verify the required parameter 'propertyName' is set
            if (request.PropertyName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling CreateOrUpdateDocumentProperty");
            }

            // verify the required parameter 'property' is set
            if (request.Property == null) 
            {
                throw new ApiException(400, "Missing required parameter 'property' when calling CreateOrUpdateDocumentProperty");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/documentProperties/{propertyName}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "propertyName", request.PropertyName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            var postBody = SerializationHelper.Serialize(request.Property); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (DocumentPropertyResponse)SerializationHelper.Deserialize(response, typeof(DocumentPropertyResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Resets border properties to default values.              &#39;nodePath&#39; should refer to node with cell or row
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteBorderRequest" /></param> 
        /// <returns><see cref="BorderResponse"/></returns>            
        public BorderResponse DeleteBorder(DeleteBorderRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteBorder");
            }

            // verify the required parameter 'nodePath' is set
            if (request.NodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling DeleteBorder");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteBorder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/borders/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (BorderResponse)SerializationHelper.Deserialize(response, typeof(BorderResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Resets borders properties to default values.              &#39;nodePath&#39; should refer to node with cell or row
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteBordersRequest" /></param> 
        /// <returns><see cref="BordersResponse"/></returns>            
        public BordersResponse DeleteBorders(DeleteBordersRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteBorders");
            }

            // verify the required parameter 'nodePath' is set
            if (request.NodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling DeleteBorders");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/borders";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (BordersResponse)SerializationHelper.Deserialize(response, typeof(BordersResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Remove comment from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteCommentRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteComment(DeleteCommentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteComment");
            }

            // verify the required parameter 'commentIndex' is set
            if (request.CommentIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'commentIndex' when calling DeleteComment");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/comments/{commentIndex}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "commentIndex", request.CommentIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (AsposeResponse)SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Remove macros from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDocumentMacrosRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteDocumentMacros(DeleteDocumentMacrosRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteDocumentMacros");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/macros";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (AsposeResponse)SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Delete document property. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDocumentPropertyRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteDocumentProperty(DeleteDocumentPropertyRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteDocumentProperty");
            }

            // verify the required parameter 'propertyName' is set
            if (request.PropertyName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling DeleteDocumentProperty");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/documentProperties/{propertyName}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "propertyName", request.PropertyName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (AsposeResponse)SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Delete watermark (for deleting last watermark from the document). 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDocumentWatermarkRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse DeleteDocumentWatermark(DeleteDocumentWatermarkRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteDocumentWatermark");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/watermark";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Removes drawing object from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDrawingObjectRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteDrawingObject(DeleteDrawingObjectRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteDrawingObject");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteDrawingObject");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/drawingObjects/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (AsposeResponse)SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Delete field from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFieldRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteField(DeleteFieldRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteField");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteField");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/fields/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (AsposeResponse)SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Remove fields from section paragraph. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFieldsRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteFields(DeleteFieldsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteFields");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/fields";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (AsposeResponse)SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Removes footnote from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFootnoteRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteFootnote(DeleteFootnoteRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteFootnote");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteFootnote");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/footnotes/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (AsposeResponse)SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Removes form field from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFormFieldRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteFormField(DeleteFormFieldRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteFormField");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteFormField");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/formfields/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (AsposeResponse)SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Delete header/footer from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHeaderFooterRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteHeaderFooter(DeleteHeaderFooterRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteHeaderFooter");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteHeaderFooter");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{sectionPath}/headersfooters/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "sectionPath", request.SectionPath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (AsposeResponse)SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Delete document headers and footers. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHeadersFootersRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteHeadersFooters(DeleteHeadersFootersRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteHeadersFooters");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{sectionPath}/headersfooters";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "sectionPath", request.SectionPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "headersFootersTypes", request.HeadersFootersTypes);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (AsposeResponse)SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Removes OfficeMath object from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteOfficeMathObjectRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteOfficeMathObject(DeleteOfficeMathObjectRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteOfficeMathObject");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteOfficeMathObject");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/OfficeMathObjects/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (AsposeResponse)SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Remove paragraph from section. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteParagraph(DeleteParagraphRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteParagraph");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteParagraph");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (AsposeResponse)SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Removes run from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteRunRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteRun(DeleteRunRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteRun");
            }

            // verify the required parameter 'paragraphPath' is set
            if (request.ParagraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling DeleteRun");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteRun");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{paragraphPath}/runs/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphPath", request.ParagraphPath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (AsposeResponse)SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Delete a table. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteTable(DeleteTableRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteTable");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteTable");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/tables/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (AsposeResponse)SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Delete a table cell. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableCellRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteTableCell(DeleteTableCellRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteTableCell");
            }

            // verify the required parameter 'tableRowPath' is set
            if (request.TableRowPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tableRowPath' when calling DeleteTableCell");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteTableCell");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{tableRowPath}/cells/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "tableRowPath", request.TableRowPath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (AsposeResponse)SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Delete a table row. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableRowRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteTableRow(DeleteTableRowRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteTableRow");
            }

            // verify the required parameter 'tablePath' is set
            if (request.TablePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tablePath' when calling DeleteTableRow");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteTableRow");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{tablePath}/rows/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "tablePath", request.TablePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (AsposeResponse)SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Unprotect document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteUnprotectDocumentRequest" /></param> 
        /// <returns><see cref="ProtectionDataResponse"/></returns>            
        public ProtectionDataResponse DeleteUnprotectDocument(DeleteUnprotectDocumentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteUnprotectDocument");
            }

            // verify the required parameter 'protectionRequest' is set
            if (request.ProtectionRequest == null) 
            {
                throw new ApiException(400, "Missing required parameter 'protectionRequest' when calling DeleteUnprotectDocument");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/protection";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            var postBody = SerializationHelper.Serialize(request.ProtectionRequest); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (ProtectionDataResponse)SerializationHelper.Deserialize(response, typeof(ProtectionDataResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Return a border. &#39;nodePath&#39; should refer to node with cell or row
        /// </summary>
        /// <param name="request">Request. <see cref="GetBorderRequest" /></param> 
        /// <returns><see cref="BorderResponse"/></returns>            
        public BorderResponse GetBorder(GetBorderRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetBorder");
            }

            // verify the required parameter 'nodePath' is set
            if (request.NodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetBorder");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetBorder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/borders/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (BorderResponse)SerializationHelper.Deserialize(response, typeof(BorderResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Return a collection of borders. &#39;nodePath&#39; should refer to node with cell or row
        /// </summary>
        /// <param name="request">Request. <see cref="GetBordersRequest" /></param> 
        /// <returns><see cref="BordersResponse"/></returns>            
        public BordersResponse GetBorders(GetBordersRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetBorders");
            }

            // verify the required parameter 'nodePath' is set
            if (request.NodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetBorders");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/borders";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (BordersResponse)SerializationHelper.Deserialize(response, typeof(BordersResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Get comment from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetCommentRequest" /></param> 
        /// <returns><see cref="CommentResponse"/></returns>            
        public CommentResponse GetComment(GetCommentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetComment");
            }

            // verify the required parameter 'commentIndex' is set
            if (request.CommentIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'commentIndex' when calling GetComment");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/comments/{commentIndex}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "commentIndex", request.CommentIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (CommentResponse)SerializationHelper.Deserialize(response, typeof(CommentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Get comments from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetCommentsRequest" /></param> 
        /// <returns><see cref="CommentsResponse"/></returns>            
        public CommentsResponse GetComments(GetCommentsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetComments");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/comments";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (CommentsResponse)SerializationHelper.Deserialize(response, typeof(CommentsResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Read document common info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse GetDocument(GetDocumentRequest request)
        {
            // verify the required parameter 'documentName' is set
            if (request.DocumentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'documentName' when calling GetDocument");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{documentName}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "documentName", request.DocumentName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Read document bookmark data by its name. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentBookmarkByNameRequest" /></param> 
        /// <returns><see cref="BookmarkResponse"/></returns>            
        public BookmarkResponse GetDocumentBookmarkByName(GetDocumentBookmarkByNameRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentBookmarkByName");
            }

            // verify the required parameter 'bookmarkName' is set
            if (request.BookmarkName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bookmarkName' when calling GetDocumentBookmarkByName");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/bookmarks/{bookmarkName}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "bookmarkName", request.BookmarkName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (BookmarkResponse)SerializationHelper.Deserialize(response, typeof(BookmarkResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Read document bookmarks common info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentBookmarksRequest" /></param> 
        /// <returns><see cref="BookmarksResponse"/></returns>            
        public BookmarksResponse GetDocumentBookmarks(GetDocumentBookmarksRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentBookmarks");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/bookmarks";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (BookmarksResponse)SerializationHelper.Deserialize(response, typeof(BookmarksResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Read document drawing object common info by its index or convert to format specified. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectByIndexRequest" /></param> 
        /// <returns><see cref="DrawingObjectResponse"/></returns>            
        public DrawingObjectResponse GetDocumentDrawingObjectByIndex(GetDocumentDrawingObjectByIndexRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjectByIndex");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentDrawingObjectByIndex");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/drawingObjects/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (DrawingObjectResponse)SerializationHelper.Deserialize(response, typeof(DrawingObjectResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Read drawing object image data. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectImageDataRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetDocumentDrawingObjectImageData(GetDocumentDrawingObjectImageDataRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjectImageData");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentDrawingObjectImageData");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/drawingObjects/{index}/imageData";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "GET", 
                        null, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Get drawing object OLE data. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectOleDataRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetDocumentDrawingObjectOleData(GetDocumentDrawingObjectOleDataRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjectOleData");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentDrawingObjectOleData");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/drawingObjects/{index}/oleData";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "GET", 
                        null, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Read document drawing objects common info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectsRequest" /></param> 
        /// <returns><see cref="DrawingObjectsResponse"/></returns>            
        public DrawingObjectsResponse GetDocumentDrawingObjects(GetDocumentDrawingObjectsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjects");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/drawingObjects";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (DrawingObjectsResponse)SerializationHelper.Deserialize(response, typeof(DrawingObjectsResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Read document field names. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentFieldNamesRequest" /></param> 
        /// <returns><see cref="FieldNamesResponse"/></returns>            
        public FieldNamesResponse GetDocumentFieldNames(GetDocumentFieldNamesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentFieldNames");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/mailMergeFieldNames";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "useNonMergeFields", request.UseNonMergeFields);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (FieldNamesResponse)SerializationHelper.Deserialize(response, typeof(FieldNamesResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Read document hyperlink by its index. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentHyperlinkByIndexRequest" /></param> 
        /// <returns><see cref="HyperlinkResponse"/></returns>            
        public HyperlinkResponse GetDocumentHyperlinkByIndex(GetDocumentHyperlinkByIndexRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentHyperlinkByIndex");
            }

            // verify the required parameter 'hyperlinkIndex' is set
            if (request.HyperlinkIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'hyperlinkIndex' when calling GetDocumentHyperlinkByIndex");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/hyperlinks/{hyperlinkIndex}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "hyperlinkIndex", request.HyperlinkIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (HyperlinkResponse)SerializationHelper.Deserialize(response, typeof(HyperlinkResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Read document hyperlinks common info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentHyperlinksRequest" /></param> 
        /// <returns><see cref="HyperlinksResponse"/></returns>            
        public HyperlinksResponse GetDocumentHyperlinks(GetDocumentHyperlinksRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentHyperlinks");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/hyperlinks";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (HyperlinksResponse)SerializationHelper.Deserialize(response, typeof(HyperlinksResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// This resource represents one of the paragraphs contained in the document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentParagraphRequest" /></param> 
        /// <returns><see cref="ParagraphResponse"/></returns>            
        public ParagraphResponse GetDocumentParagraph(GetDocumentParagraphRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentParagraph");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentParagraph");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (ParagraphResponse)SerializationHelper.Deserialize(response, typeof(ParagraphResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// This resource represents run of text contained in the document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentParagraphRunRequest" /></param> 
        /// <returns><see cref="RunResponse"/></returns>            
        public RunResponse GetDocumentParagraphRun(GetDocumentParagraphRunRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentParagraphRun");
            }

            // verify the required parameter 'paragraphPath' is set
            if (request.ParagraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling GetDocumentParagraphRun");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentParagraphRun");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{paragraphPath}/runs/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphPath", request.ParagraphPath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (RunResponse)SerializationHelper.Deserialize(response, typeof(RunResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// This resource represents font of run. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentParagraphRunFontRequest" /></param> 
        /// <returns><see cref="FontResponse"/></returns>            
        public FontResponse GetDocumentParagraphRunFont(GetDocumentParagraphRunFontRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentParagraphRunFont");
            }

            // verify the required parameter 'paragraphPath' is set
            if (request.ParagraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling GetDocumentParagraphRunFont");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentParagraphRunFont");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{paragraphPath}/runs/{index}/font";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphPath", request.ParagraphPath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (FontResponse)SerializationHelper.Deserialize(response, typeof(FontResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// This resource represents collection of runs in the paragraph. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentParagraphRunsRequest" /></param> 
        /// <returns><see cref="RunsResponse"/></returns>            
        public RunsResponse GetDocumentParagraphRuns(GetDocumentParagraphRunsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentParagraphRuns");
            }

            // verify the required parameter 'paragraphPath' is set
            if (request.ParagraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling GetDocumentParagraphRuns");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{paragraphPath}/runs";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphPath", request.ParagraphPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (RunsResponse)SerializationHelper.Deserialize(response, typeof(RunsResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Return a list of paragraphs that are contained in the document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentParagraphsRequest" /></param> 
        /// <returns><see cref="ParagraphLinkCollectionResponse"/></returns>            
        public ParagraphLinkCollectionResponse GetDocumentParagraphs(GetDocumentParagraphsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentParagraphs");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (ParagraphLinkCollectionResponse)SerializationHelper.Deserialize(response, typeof(ParagraphLinkCollectionResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Read document properties info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentPropertiesRequest" /></param> 
        /// <returns><see cref="DocumentPropertiesResponse"/></returns>            
        public DocumentPropertiesResponse GetDocumentProperties(GetDocumentPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentProperties");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/documentProperties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (DocumentPropertiesResponse)SerializationHelper.Deserialize(response, typeof(DocumentPropertiesResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Read document property info by the property name. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentPropertyRequest" /></param> 
        /// <returns><see cref="DocumentPropertyResponse"/></returns>            
        public DocumentPropertyResponse GetDocumentProperty(GetDocumentPropertyRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentProperty");
            }

            // verify the required parameter 'propertyName' is set
            if (request.PropertyName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling GetDocumentProperty");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/documentProperties/{propertyName}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "propertyName", request.PropertyName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (DocumentPropertyResponse)SerializationHelper.Deserialize(response, typeof(DocumentPropertyResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Read document protection common info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentProtectionRequest" /></param> 
        /// <returns><see cref="ProtectionDataResponse"/></returns>            
        public ProtectionDataResponse GetDocumentProtection(GetDocumentProtectionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentProtection");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/protection";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (ProtectionDataResponse)SerializationHelper.Deserialize(response, typeof(ProtectionDataResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Read document statistics. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentStatisticsRequest" /></param> 
        /// <returns><see cref="StatDataResponse"/></returns>            
        public StatDataResponse GetDocumentStatistics(GetDocumentStatisticsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentStatistics");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/statistics";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "includeComments", request.IncludeComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "includeFootnotes", request.IncludeFootnotes);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "includeTextInShapes", request.IncludeTextInShapes);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (StatDataResponse)SerializationHelper.Deserialize(response, typeof(StatDataResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Read document text items. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentTextItemsRequest" /></param> 
        /// <returns><see cref="TextItemsResponse"/></returns>            
        public TextItemsResponse GetDocumentTextItems(GetDocumentTextItemsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentTextItems");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/textItems";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (TextItemsResponse)SerializationHelper.Deserialize(response, typeof(TextItemsResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export the document into the specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentWithFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetDocumentWithFormat(GetDocumentWithFormatRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentWithFormat");
            }

            // verify the required parameter 'format' is set
            if (request.Format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling GetDocumentWithFormat");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsLocation", request.FontsLocation);
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "GET", 
                        null, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Get field from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFieldRequest" /></param> 
        /// <returns><see cref="FieldResponse"/></returns>            
        public FieldResponse GetField(GetFieldRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetField");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetField");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/fields/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (FieldResponse)SerializationHelper.Deserialize(response, typeof(FieldResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Get fields from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFieldsRequest" /></param> 
        /// <returns><see cref="FieldsResponse"/></returns>            
        public FieldsResponse GetFields(GetFieldsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFields");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/fields";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (FieldsResponse)SerializationHelper.Deserialize(response, typeof(FieldsResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Read footnote by index. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFootnoteRequest" /></param> 
        /// <returns><see cref="FootnoteResponse"/></returns>            
        public FootnoteResponse GetFootnote(GetFootnoteRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFootnote");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetFootnote");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/footnotes/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (FootnoteResponse)SerializationHelper.Deserialize(response, typeof(FootnoteResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Get footnotes from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFootnotesRequest" /></param> 
        /// <returns><see cref="FootnotesResponse"/></returns>            
        public FootnotesResponse GetFootnotes(GetFootnotesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFootnotes");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/footnotes";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (FootnotesResponse)SerializationHelper.Deserialize(response, typeof(FootnotesResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Returns representation of an one of the form field. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFormFieldRequest" /></param> 
        /// <returns><see cref="FormFieldResponse"/></returns>            
        public FormFieldResponse GetFormField(GetFormFieldRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFormField");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetFormField");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/formfields/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (FormFieldResponse)SerializationHelper.Deserialize(response, typeof(FormFieldResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Get form fields from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFormFieldsRequest" /></param> 
        /// <returns><see cref="FormFieldsResponse"/></returns>            
        public FormFieldsResponse GetFormFields(GetFormFieldsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFormFields");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/formfields";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (FormFieldsResponse)SerializationHelper.Deserialize(response, typeof(FormFieldsResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Return a header/footer that is contained in the document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderFooterRequest" /></param> 
        /// <returns><see cref="HeaderFooterResponse"/></returns>            
        public HeaderFooterResponse GetHeaderFooter(GetHeaderFooterRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetHeaderFooter");
            }

            // verify the required parameter 'headerFooterIndex' is set
            if (request.HeaderFooterIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'headerFooterIndex' when calling GetHeaderFooter");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/headersfooters/{headerFooterIndex}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "headerFooterIndex", request.HeaderFooterIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "filterByType", request.FilterByType);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (HeaderFooterResponse)SerializationHelper.Deserialize(response, typeof(HeaderFooterResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Return a header/footer that is contained in the document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderFooterOfSectionRequest" /></param> 
        /// <returns><see cref="HeaderFooterResponse"/></returns>            
        public HeaderFooterResponse GetHeaderFooterOfSection(GetHeaderFooterOfSectionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetHeaderFooterOfSection");
            }

            // verify the required parameter 'headerFooterIndex' is set
            if (request.HeaderFooterIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'headerFooterIndex' when calling GetHeaderFooterOfSection");
            }

            // verify the required parameter 'sectionIndex' is set
            if (request.SectionIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'sectionIndex' when calling GetHeaderFooterOfSection");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/sections/{sectionIndex}/headersfooters/{headerFooterIndex}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "headerFooterIndex", request.HeaderFooterIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sectionIndex", request.SectionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "filterByType", request.FilterByType);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (HeaderFooterResponse)SerializationHelper.Deserialize(response, typeof(HeaderFooterResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Return a list of header/footers that are contained in the document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderFootersRequest" /></param> 
        /// <returns><see cref="HeaderFootersResponse"/></returns>            
        public HeaderFootersResponse GetHeaderFooters(GetHeaderFootersRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetHeaderFooters");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{sectionPath}/headersfooters";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "sectionPath", request.SectionPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "filterByType", request.FilterByType);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (HeaderFootersResponse)SerializationHelper.Deserialize(response, typeof(HeaderFootersResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Read OfficeMath object by index. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetOfficeMathObjectRequest" /></param> 
        /// <returns><see cref="OfficeMathObjectResponse"/></returns>            
        public OfficeMathObjectResponse GetOfficeMathObject(GetOfficeMathObjectRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetOfficeMathObject");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetOfficeMathObject");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/OfficeMathObjects/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (OfficeMathObjectResponse)SerializationHelper.Deserialize(response, typeof(OfficeMathObjectResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Get OfficeMath objects from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetOfficeMathObjectsRequest" /></param> 
        /// <returns><see cref="OfficeMathObjectsResponse"/></returns>            
        public OfficeMathObjectsResponse GetOfficeMathObjects(GetOfficeMathObjectsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetOfficeMathObjects");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/OfficeMathObjects";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (OfficeMathObjectsResponse)SerializationHelper.Deserialize(response, typeof(OfficeMathObjectsResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Get document section by index. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSectionRequest" /></param> 
        /// <returns><see cref="SectionResponse"/></returns>            
        public SectionResponse GetSection(GetSectionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSection");
            }

            // verify the required parameter 'sectionIndex' is set
            if (request.SectionIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'sectionIndex' when calling GetSection");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/sections/{sectionIndex}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sectionIndex", request.SectionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (SectionResponse)SerializationHelper.Deserialize(response, typeof(SectionResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Get page setup of section. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSectionPageSetupRequest" /></param> 
        /// <returns><see cref="SectionPageSetupResponse"/></returns>            
        public SectionPageSetupResponse GetSectionPageSetup(GetSectionPageSetupRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSectionPageSetup");
            }

            // verify the required parameter 'sectionIndex' is set
            if (request.SectionIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'sectionIndex' when calling GetSectionPageSetup");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/sections/{sectionIndex}/pageSetup";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sectionIndex", request.SectionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (SectionPageSetupResponse)SerializationHelper.Deserialize(response, typeof(SectionPageSetupResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Return a list of sections that are contained in the document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSectionsRequest" /></param> 
        /// <returns><see cref="SectionLinkCollectionResponse"/></returns>            
        public SectionLinkCollectionResponse GetSections(GetSectionsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSections");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/sections";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (SectionLinkCollectionResponse)SerializationHelper.Deserialize(response, typeof(SectionLinkCollectionResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Return a table. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableRequest" /></param> 
        /// <returns><see cref="TableResponse"/></returns>            
        public TableResponse GetTable(GetTableRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTable");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTable");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/tables/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (TableResponse)SerializationHelper.Deserialize(response, typeof(TableResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Return a table cell. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableCellRequest" /></param> 
        /// <returns><see cref="TableCellResponse"/></returns>            
        public TableCellResponse GetTableCell(GetTableCellRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableCell");
            }

            // verify the required parameter 'tableRowPath' is set
            if (request.TableRowPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tableRowPath' when calling GetTableCell");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTableCell");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{tableRowPath}/cells/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "tableRowPath", request.TableRowPath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (TableCellResponse)SerializationHelper.Deserialize(response, typeof(TableCellResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Return a table cell format. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableCellFormatRequest" /></param> 
        /// <returns><see cref="TableCellFormatResponse"/></returns>            
        public TableCellFormatResponse GetTableCellFormat(GetTableCellFormatRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableCellFormat");
            }

            // verify the required parameter 'tableRowPath' is set
            if (request.TableRowPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tableRowPath' when calling GetTableCellFormat");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTableCellFormat");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{tableRowPath}/cells/{index}/cellformat";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "tableRowPath", request.TableRowPath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (TableCellFormatResponse)SerializationHelper.Deserialize(response, typeof(TableCellFormatResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Return a table properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetTablePropertiesRequest" /></param> 
        /// <returns><see cref="TablePropertiesResponse"/></returns>            
        public TablePropertiesResponse GetTableProperties(GetTablePropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableProperties");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTableProperties");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/tables/{index}/properties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (TablePropertiesResponse)SerializationHelper.Deserialize(response, typeof(TablePropertiesResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Return a table row. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableRowRequest" /></param> 
        /// <returns><see cref="TableRowResponse"/></returns>            
        public TableRowResponse GetTableRow(GetTableRowRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableRow");
            }

            // verify the required parameter 'tablePath' is set
            if (request.TablePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tablePath' when calling GetTableRow");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTableRow");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{tablePath}/rows/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "tablePath", request.TablePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (TableRowResponse)SerializationHelper.Deserialize(response, typeof(TableRowResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Return a table row format. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableRowFormatRequest" /></param> 
        /// <returns><see cref="TableRowFormatResponse"/></returns>            
        public TableRowFormatResponse GetTableRowFormat(GetTableRowFormatRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableRowFormat");
            }

            // verify the required parameter 'tablePath' is set
            if (request.TablePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tablePath' when calling GetTableRowFormat");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTableRowFormat");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{tablePath}/rows/{index}/rowformat";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "tablePath", request.TablePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (TableRowFormatResponse)SerializationHelper.Deserialize(response, typeof(TableRowFormatResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Return a list of tables that are contained in the document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetTablesRequest" /></param> 
        /// <returns><see cref="TableLinkCollectionResponse"/></returns>            
        public TableLinkCollectionResponse GetTables(GetTablesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTables");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/tables";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (TableLinkCollectionResponse)SerializationHelper.Deserialize(response, typeof(TableLinkCollectionResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Adds table to document, returns added table&#39;s data.              
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableRequest" /></param> 
        /// <returns><see cref="TableResponse"/></returns>            
        public TableResponse InsertTable(InsertTableRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertTable");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/tables";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            var postBody = SerializationHelper.Serialize(request.Table); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (TableResponse)SerializationHelper.Deserialize(response, typeof(TableResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Adds table cell to table, returns added cell&#39;s data.              
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableCellRequest" /></param> 
        /// <returns><see cref="TableCellResponse"/></returns>            
        public TableCellResponse InsertTableCell(InsertTableCellRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertTableCell");
            }

            // verify the required parameter 'tableRowPath' is set
            if (request.TableRowPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tableRowPath' when calling InsertTableCell");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{tableRowPath}/cells";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "tableRowPath", request.TableRowPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            var postBody = SerializationHelper.Serialize(request.Cell); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (TableCellResponse)SerializationHelper.Deserialize(response, typeof(TableCellResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Adds table row to table, returns added row&#39;s data.              
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableRowRequest" /></param> 
        /// <returns><see cref="TableRowResponse"/></returns>            
        public TableRowResponse InsertTableRow(InsertTableRowRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertTableRow");
            }

            // verify the required parameter 'tablePath' is set
            if (request.TablePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tablePath' when calling InsertTableRow");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{tablePath}/rows";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "tablePath", request.TablePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            var postBody = SerializationHelper.Serialize(request.Row); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (TableRowResponse)SerializationHelper.Deserialize(response, typeof(TableRowResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Append documents to original document. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAppendDocumentRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostAppendDocument(PostAppendDocumentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAppendDocument");
            }

            // verify the required parameter 'documentList' is set
            if (request.DocumentList == null) 
            {
                throw new ApiException(400, "Missing required parameter 'documentList' when calling PostAppendDocument");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/appendDocument";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            var postBody = SerializationHelper.Serialize(request.DocumentList); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Change document protection. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostChangeDocumentProtectionRequest" /></param> 
        /// <returns><see cref="ProtectionDataResponse"/></returns>            
        public ProtectionDataResponse PostChangeDocumentProtection(PostChangeDocumentProtectionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostChangeDocumentProtection");
            }

            // verify the required parameter 'protectionRequest' is set
            if (request.ProtectionRequest == null) 
            {
                throw new ApiException(400, "Missing required parameter 'protectionRequest' when calling PostChangeDocumentProtection");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/protection";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            var postBody = SerializationHelper.Serialize(request.ProtectionRequest); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (ProtectionDataResponse)SerializationHelper.Deserialize(response, typeof(ProtectionDataResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Updates the comment, returns updated comment&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostCommentRequest" /></param> 
        /// <returns><see cref="CommentResponse"/></returns>            
        public CommentResponse PostComment(PostCommentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostComment");
            }

            // verify the required parameter 'commentIndex' is set
            if (request.CommentIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'commentIndex' when calling PostComment");
            }

            // verify the required parameter 'comment' is set
            if (request.Comment == null) 
            {
                throw new ApiException(400, "Missing required parameter 'comment' when calling PostComment");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/comments/{commentIndex}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "commentIndex", request.CommentIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            var postBody = SerializationHelper.Serialize(request.Comment); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (CommentResponse)SerializationHelper.Deserialize(response, typeof(CommentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Compare document with original document. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostCompareDocumentRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostCompareDocument(PostCompareDocumentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostCompareDocument");
            }

            // verify the required parameter 'compareData' is set
            if (request.CompareData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'compareData' when calling PostCompareDocument");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/compareDocument";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            var postBody = SerializationHelper.Serialize(request.CompareData); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Execute document mail merge operation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostDocumentExecuteMailMergeRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostDocumentExecuteMailMerge(PostDocumentExecuteMailMergeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDocumentExecuteMailMerge");
            }

            // verify the required parameter 'withRegions' is set
            if (request.WithRegions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'withRegions' when calling PostDocumentExecuteMailMerge");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/executeMailMerge";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "withRegions", request.WithRegions);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "mailMergeDataFile", request.MailMergeDataFile);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cleanup", request.Cleanup);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "useWholeParagraphAsRegion", request.UseWholeParagraphAsRegion);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            
            if (request.Data != null) 
            {
                formParams.Add("Data", request.Data); // form parameter
            }
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    null, 
                    null, 
                    formParams);
                if (response != null)
                {
                    return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Updates font properties, returns updated font data. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostDocumentParagraphRunFontRequest" /></param> 
        /// <returns><see cref="FontResponse"/></returns>            
        public FontResponse PostDocumentParagraphRunFont(PostDocumentParagraphRunFontRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDocumentParagraphRunFont");
            }

            // verify the required parameter 'fontDto' is set
            if (request.FontDto == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fontDto' when calling PostDocumentParagraphRunFont");
            }

            // verify the required parameter 'paragraphPath' is set
            if (request.ParagraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling PostDocumentParagraphRunFont");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostDocumentParagraphRunFont");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{paragraphPath}/runs/{index}/font";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphPath", request.ParagraphPath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            var postBody = SerializationHelper.Serialize(request.FontDto); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (FontResponse)SerializationHelper.Deserialize(response, typeof(FontResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Convert document to destination format with detailed settings and save result to storage. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostDocumentSaveAsRequest" /></param> 
        /// <returns><see cref="SaveResponse"/></returns>            
        public SaveResponse PostDocumentSaveAs(PostDocumentSaveAsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDocumentSaveAs");
            }

            // verify the required parameter 'saveOptionsData' is set
            if (request.SaveOptionsData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'saveOptionsData' when calling PostDocumentSaveAs");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/saveAs";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsLocation", request.FontsLocation);
            var postBody = SerializationHelper.Serialize(request.SaveOptionsData); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (SaveResponse)SerializationHelper.Deserialize(response, typeof(SaveResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Updates drawing object, returns updated  drawing object&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostDrawingObjectRequest" /></param> 
        /// <returns><see cref="DrawingObjectResponse"/></returns>            
        public DrawingObjectResponse PostDrawingObject(PostDrawingObjectRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDrawingObject");
            }

            // verify the required parameter 'drawingObject' is set
            if (request.DrawingObject == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingObject' when calling PostDrawingObject");
            }

            // verify the required parameter 'imageFile' is set
            if (request.ImageFile == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageFile' when calling PostDrawingObject");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostDrawingObject");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/drawingObjects/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            if (request.DrawingObject != null) 
            {
                formParams.Add("DrawingObject", request.DrawingObject); // form parameter
            }
            
            if (request.ImageFile != null) 
            {
                formParams.Add("imageFile", this.apiInvoker.ToFileInfo(request.ImageFile, "ImageFile"));
            }
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    null, 
                    null, 
                    formParams);
                if (response != null)
                {
                    return (DrawingObjectResponse)SerializationHelper.Deserialize(response, typeof(DrawingObjectResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Populate document template with data. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostExecuteTemplateRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostExecuteTemplate(PostExecuteTemplateRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostExecuteTemplate");
            }

            // verify the required parameter 'data' is set
            if (request.Data == null) 
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling PostExecuteTemplate");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/executeTemplate";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cleanup", request.Cleanup);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "useWholeParagraphAsRegion", request.UseWholeParagraphAsRegion);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "withRegions", request.WithRegions);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            
            if (request.Data != null) 
            {
                formParams.Add("Data", request.Data); // form parameter
            }
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    null, 
                    null, 
                    formParams);
                if (response != null)
                {
                    return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Updates field&#39;s properties, returns updated field&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostFieldRequest" /></param> 
        /// <returns><see cref="FieldResponse"/></returns>            
        public FieldResponse PostField(PostFieldRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostField");
            }

            // verify the required parameter 'field' is set
            if (request.Field == null) 
            {
                throw new ApiException(400, "Missing required parameter 'field' when calling PostField");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostField");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/fields/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            var postBody = SerializationHelper.Serialize(request.Field); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (FieldResponse)SerializationHelper.Deserialize(response, typeof(FieldResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Updates footnote&#39;s properties, returns updated run&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostFootnoteRequest" /></param> 
        /// <returns><see cref="FootnoteResponse"/></returns>            
        public FootnoteResponse PostFootnote(PostFootnoteRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostFootnote");
            }

            // verify the required parameter 'footnoteDto' is set
            if (request.FootnoteDto == null) 
            {
                throw new ApiException(400, "Missing required parameter 'footnoteDto' when calling PostFootnote");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostFootnote");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/footnotes/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            var postBody = SerializationHelper.Serialize(request.FootnoteDto); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (FootnoteResponse)SerializationHelper.Deserialize(response, typeof(FootnoteResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Updates properties of form field, returns updated form field. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostFormFieldRequest" /></param> 
        /// <returns><see cref="FormFieldResponse"/></returns>            
        public FormFieldResponse PostFormField(PostFormFieldRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostFormField");
            }

            // verify the required parameter 'formField' is set
            if (request.FormField == null) 
            {
                throw new ApiException(400, "Missing required parameter 'formField' when calling PostFormField");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostFormField");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/formfields/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            var postBody = SerializationHelper.Serialize(request.FormField); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (FormFieldResponse)SerializationHelper.Deserialize(response, typeof(FormFieldResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Insert document watermark image. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostInsertDocumentWatermarkImageRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostInsertDocumentWatermarkImage(PostInsertDocumentWatermarkImageRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostInsertDocumentWatermarkImage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/watermark/insertImage";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rotationAngle", request.RotationAngle);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "image", request.Image);
            
            if (request.ImageFile != null) 
            {
                formParams.Add("imageFile", this.apiInvoker.ToFileInfo(request.ImageFile, "ImageFile"));
            }
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    null, 
                    null, 
                    formParams);
                if (response != null)
                {
                    return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Insert document watermark text. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostInsertDocumentWatermarkTextRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostInsertDocumentWatermarkText(PostInsertDocumentWatermarkTextRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostInsertDocumentWatermarkText");
            }

            // verify the required parameter 'watermarkText' is set
            if (request.WatermarkText == null) 
            {
                throw new ApiException(400, "Missing required parameter 'watermarkText' when calling PostInsertDocumentWatermarkText");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/watermark/insertText";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            var postBody = SerializationHelper.Serialize(request.WatermarkText); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Insert document page numbers. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostInsertPageNumbersRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostInsertPageNumbers(PostInsertPageNumbersRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostInsertPageNumbers");
            }

            // verify the required parameter 'pageNumber' is set
            if (request.PageNumber == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PostInsertPageNumbers");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/insertPageNumbers";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            var postBody = SerializationHelper.Serialize(request.PageNumber); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Loads new document from web into the file with any supported format of data. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostLoadWebDocumentRequest" /></param> 
        /// <returns><see cref="SaveResponse"/></returns>            
        public SaveResponse PostLoadWebDocument(PostLoadWebDocumentRequest request)
        {
            // verify the required parameter 'data' is set
            if (request.Data == null) 
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling PostLoadWebDocument");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/loadWebDocument";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Data); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (SaveResponse)SerializationHelper.Deserialize(response, typeof(SaveResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Replace document text. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostReplaceTextRequest" /></param> 
        /// <returns><see cref="ReplaceTextResponse"/></returns>            
        public ReplaceTextResponse PostReplaceText(PostReplaceTextRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostReplaceText");
            }

            // verify the required parameter 'replaceText' is set
            if (request.ReplaceText == null) 
            {
                throw new ApiException(400, "Missing required parameter 'replaceText' when calling PostReplaceText");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/replaceText";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            var postBody = SerializationHelper.Serialize(request.ReplaceText); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (ReplaceTextResponse)SerializationHelper.Deserialize(response, typeof(ReplaceTextResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Updates run&#39;s properties, returns updated run&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostRunRequest" /></param> 
        /// <returns><see cref="RunResponse"/></returns>            
        public RunResponse PostRun(PostRunRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostRun");
            }

            // verify the required parameter 'run' is set
            if (request.Run == null) 
            {
                throw new ApiException(400, "Missing required parameter 'run' when calling PostRun");
            }

            // verify the required parameter 'paragraphPath' is set
            if (request.ParagraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling PostRun");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostRun");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{paragraphPath}/runs/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphPath", request.ParagraphPath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            var postBody = SerializationHelper.Serialize(request.Run); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (RunResponse)SerializationHelper.Deserialize(response, typeof(RunResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Split document. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSplitDocumentRequest" /></param> 
        /// <returns><see cref="SplitDocumentResponse"/></returns>            
        public SplitDocumentResponse PostSplitDocument(PostSplitDocumentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSplitDocument");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/split";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "from", request.From);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "to", request.To);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "zipOutput", request.ZipOutput);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsLocation", request.FontsLocation);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (SplitDocumentResponse)SerializationHelper.Deserialize(response, typeof(SplitDocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Update document bookmark. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostUpdateDocumentBookmarkRequest" /></param> 
        /// <returns><see cref="BookmarkResponse"/></returns>            
        public BookmarkResponse PostUpdateDocumentBookmark(PostUpdateDocumentBookmarkRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostUpdateDocumentBookmark");
            }

            // verify the required parameter 'bookmarkData' is set
            if (request.BookmarkData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bookmarkData' when calling PostUpdateDocumentBookmark");
            }

            // verify the required parameter 'bookmarkName' is set
            if (request.BookmarkName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bookmarkName' when calling PostUpdateDocumentBookmark");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/bookmarks/{bookmarkName}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "bookmarkName", request.BookmarkName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            var postBody = SerializationHelper.Serialize(request.BookmarkData); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (BookmarkResponse)SerializationHelper.Deserialize(response, typeof(BookmarkResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Update (reevaluate) fields in document. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostUpdateDocumentFieldsRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostUpdateDocumentFields(PostUpdateDocumentFieldsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostUpdateDocumentFields");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/updateFields";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Adds comment to document, returns inserted comment&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutCommentRequest" /></param> 
        /// <returns><see cref="CommentResponse"/></returns>            
        public CommentResponse PutComment(PutCommentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutComment");
            }

            // verify the required parameter 'comment' is set
            if (request.Comment == null) 
            {
                throw new ApiException(400, "Missing required parameter 'comment' when calling PutComment");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/comments";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            var postBody = SerializationHelper.Serialize(request.Comment); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (CommentResponse)SerializationHelper.Deserialize(response, typeof(CommentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Convert document from request content to format specified. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutConvertDocumentRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutConvertDocument(PutConvertDocumentRequest request)
        {
            // verify the required parameter 'document' is set
            if (request.Document == null) 
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PutConvertDocument");
            }

            // verify the required parameter 'format' is set
            if (request.Format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PutConvertDocument");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/convert";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsLocation", request.FontsLocation);
            
            if (request.Document != null) 
            {
                formParams.Add("document", this.apiInvoker.ToFileInfo(request.Document, "Document"));
            }
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "PUT", 
                        null, 
                        null, 
                        formParams);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Creates new document. Document is created with format which is recognized from file extensions.  Supported extentions: \&quot;.doc\&quot;, \&quot;.docx\&quot;, \&quot;.docm\&quot;, \&quot;.dot\&quot;, \&quot;.dotm\&quot;, \&quot;.dotx\&quot;, \&quot;.flatopc\&quot;, \&quot;.fopc\&quot;, \&quot;.flatopc_macro\&quot;, \&quot;.fopc_macro\&quot;, \&quot;.flatopc_template\&quot;, \&quot;.fopc_template\&quot;, \&quot;.flatopc_template_macro\&quot;, \&quot;.fopc_template_macro\&quot;, \&quot;.wordml\&quot;, \&quot;.wml\&quot;, \&quot;.rtf\&quot; 
        /// </summary>
        /// <param name="request">Request. <see cref="PutCreateDocumentRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PutCreateDocument(PutCreateDocumentRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/create";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Read document field names. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutDocumentFieldNamesRequest" /></param> 
        /// <returns><see cref="FieldNamesResponse"/></returns>            
        public FieldNamesResponse PutDocumentFieldNames(PutDocumentFieldNamesRequest request)
        {
            // verify the required parameter 'template' is set
            if (request.Template == null) 
            {
                throw new ApiException(400, "Missing required parameter 'template' when calling PutDocumentFieldNames");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/mailMergeFieldNames";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "useNonMergeFields", request.UseNonMergeFields);
            
            if (request.Template != null) 
            {
                formParams.Add("template", this.apiInvoker.ToFileInfo(request.Template, "Template"));
            }
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    null, 
                    null, 
                    formParams);
                if (response != null)
                {
                    return (FieldNamesResponse)SerializationHelper.Deserialize(response, typeof(FieldNamesResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Convert document to tiff with detailed settings and save result to storage. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutDocumentSaveAsTiffRequest" /></param> 
        /// <returns><see cref="SaveResponse"/></returns>            
        public SaveResponse PutDocumentSaveAsTiff(PutDocumentSaveAsTiffRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutDocumentSaveAsTiff");
            }

            // verify the required parameter 'saveOptions' is set
            if (request.SaveOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'saveOptions' when calling PutDocumentSaveAsTiff");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/saveAs/tiff";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resultFile", request.ResultFile);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "useAntiAliasing", request.UseAntiAliasing);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "useHighQualityRendering", request.UseHighQualityRendering);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageBrightness", request.ImageBrightness);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageColorMode", request.ImageColorMode);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageContrast", request.ImageContrast);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "numeralFormat", request.NumeralFormat);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageCount", request.PageCount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageIndex", request.PageIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "paperColor", request.PaperColor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pixelFormat", request.PixelFormat);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resolution", request.Resolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scale", request.Scale);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "tiffCompression", request.TiffCompression);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "dmlRenderingMode", request.DmlRenderingMode);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "dmlEffectsRenderingMode", request.DmlEffectsRenderingMode);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "tiffBinarizationMethod", request.TiffBinarizationMethod);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "zipOutput", request.ZipOutput);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsLocation", request.FontsLocation);
            var postBody = SerializationHelper.Serialize(request.SaveOptions); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (SaveResponse)SerializationHelper.Deserialize(response, typeof(SaveResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Adds  drawing object to document, returns added  drawing object&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutDrawingObjectRequest" /></param> 
        /// <returns><see cref="DrawingObjectResponse"/></returns>            
        public DrawingObjectResponse PutDrawingObject(PutDrawingObjectRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutDrawingObject");
            }

            // verify the required parameter 'drawingObject' is set
            if (request.DrawingObject == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingObject' when calling PutDrawingObject");
            }

            // verify the required parameter 'imageFile' is set
            if (request.ImageFile == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageFile' when calling PutDrawingObject");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/drawingObjects";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            
            if (request.DrawingObject != null) 
            {
                formParams.Add("DrawingObject", request.DrawingObject); // form parameter
            }
            
            if (request.ImageFile != null) 
            {
                formParams.Add("imageFile", this.apiInvoker.ToFileInfo(request.ImageFile, "ImageFile"));
            }
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    null, 
                    null, 
                    formParams);
                if (response != null)
                {
                    return (DrawingObjectResponse)SerializationHelper.Deserialize(response, typeof(DrawingObjectResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Execute document mail merge online. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutExecuteMailMergeOnlineRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutExecuteMailMergeOnline(PutExecuteMailMergeOnlineRequest request)
        {
            // verify the required parameter 'template' is set
            if (request.Template == null) 
            {
                throw new ApiException(400, "Missing required parameter 'template' when calling PutExecuteMailMergeOnline");
            }

            // verify the required parameter 'data' is set
            if (request.Data == null) 
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling PutExecuteMailMergeOnline");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/executeMailMerge";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "withRegions", request.WithRegions);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cleanup", request.Cleanup);
            
            if (request.Template != null) 
            {
                formParams.Add("template", this.apiInvoker.ToFileInfo(request.Template, "Template"));
            }
            
            if (request.Data != null) 
            {
                formParams.Add("data", this.apiInvoker.ToFileInfo(request.Data, "Data"));
            }
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "PUT", 
                        null, 
                        null, 
                        formParams);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Populate document template with data online. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutExecuteTemplateOnlineRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutExecuteTemplateOnline(PutExecuteTemplateOnlineRequest request)
        {
            // verify the required parameter 'template' is set
            if (request.Template == null) 
            {
                throw new ApiException(400, "Missing required parameter 'template' when calling PutExecuteTemplateOnline");
            }

            // verify the required parameter 'data' is set
            if (request.Data == null) 
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling PutExecuteTemplateOnline");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/executeTemplate";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cleanup", request.Cleanup);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "useWholeParagraphAsRegion", request.UseWholeParagraphAsRegion);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "withRegions", request.WithRegions);
            
            if (request.Template != null) 
            {
                formParams.Add("template", this.apiInvoker.ToFileInfo(request.Template, "Template"));
            }
            
            if (request.Data != null) 
            {
                formParams.Add("data", this.apiInvoker.ToFileInfo(request.Data, "Data"));
            }
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "PUT", 
                        null, 
                        null, 
                        formParams);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Adds field to document, returns inserted field&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutFieldRequest" /></param> 
        /// <returns><see cref="FieldResponse"/></returns>            
        public FieldResponse PutField(PutFieldRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutField");
            }

            // verify the required parameter 'field' is set
            if (request.Field == null) 
            {
                throw new ApiException(400, "Missing required parameter 'field' when calling PutField");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/fields";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "insertBeforeNode", request.InsertBeforeNode);
            var postBody = SerializationHelper.Serialize(request.Field); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (FieldResponse)SerializationHelper.Deserialize(response, typeof(FieldResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Adds footnote to document, returns added footnote&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutFootnoteRequest" /></param> 
        /// <returns><see cref="FootnoteResponse"/></returns>            
        public FootnoteResponse PutFootnote(PutFootnoteRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutFootnote");
            }

            // verify the required parameter 'footnoteDto' is set
            if (request.FootnoteDto == null) 
            {
                throw new ApiException(400, "Missing required parameter 'footnoteDto' when calling PutFootnote");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/footnotes";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            var postBody = SerializationHelper.Serialize(request.FootnoteDto); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (FootnoteResponse)SerializationHelper.Deserialize(response, typeof(FootnoteResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Adds form field to paragraph, returns added form field&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutFormFieldRequest" /></param> 
        /// <returns><see cref="FormFieldResponse"/></returns>            
        public FormFieldResponse PutFormField(PutFormFieldRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutFormField");
            }

            // verify the required parameter 'formField' is set
            if (request.FormField == null) 
            {
                throw new ApiException(400, "Missing required parameter 'formField' when calling PutFormField");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/formfields";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "insertBeforeNode", request.InsertBeforeNode);
            var postBody = SerializationHelper.Serialize(request.FormField); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (FormFieldResponse)SerializationHelper.Deserialize(response, typeof(FormFieldResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Insert to document header or footer. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutHeaderFooterRequest" /></param> 
        /// <returns><see cref="HeaderFooterResponse"/></returns>            
        public HeaderFooterResponse PutHeaderFooter(PutHeaderFooterRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutHeaderFooter");
            }

            // verify the required parameter 'headerFooterType' is set
            if (request.HeaderFooterType == null) 
            {
                throw new ApiException(400, "Missing required parameter 'headerFooterType' when calling PutHeaderFooter");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{sectionPath}/headersfooters";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "sectionPath", request.SectionPath);
            var postBody = SerializationHelper.Serialize(request.HeaderFooterType); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (HeaderFooterResponse)SerializationHelper.Deserialize(response, typeof(HeaderFooterResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Adds paragraph to document, returns added paragraph&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutParagraphRequest" /></param> 
        /// <returns><see cref="ParagraphResponse"/></returns>            
        public ParagraphResponse PutParagraph(PutParagraphRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutParagraph");
            }

            // verify the required parameter 'paragraph' is set
            if (request.Paragraph == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraph' when calling PutParagraph");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "insertBeforeNode", request.InsertBeforeNode);
            var postBody = SerializationHelper.Serialize(request.Paragraph); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (ParagraphResponse)SerializationHelper.Deserialize(response, typeof(ParagraphResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Protect document. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutProtectDocumentRequest" /></param> 
        /// <returns><see cref="ProtectionDataResponse"/></returns>            
        public ProtectionDataResponse PutProtectDocument(PutProtectDocumentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutProtectDocument");
            }

            // verify the required parameter 'protectionRequest' is set
            if (request.ProtectionRequest == null) 
            {
                throw new ApiException(400, "Missing required parameter 'protectionRequest' when calling PutProtectDocument");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/protection";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            var postBody = SerializationHelper.Serialize(request.ProtectionRequest); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (ProtectionDataResponse)SerializationHelper.Deserialize(response, typeof(ProtectionDataResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Adds run to document, returns added paragraph&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutRunRequest" /></param> 
        /// <returns><see cref="RunResponse"/></returns>            
        public RunResponse PutRun(PutRunRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutRun");
            }

            // verify the required parameter 'paragraphPath' is set
            if (request.ParagraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling PutRun");
            }

            // verify the required parameter 'run' is set
            if (request.Run == null) 
            {
                throw new ApiException(400, "Missing required parameter 'run' when calling PutRun");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{paragraphPath}/runs";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphPath", request.ParagraphPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "insertBeforeNode", request.InsertBeforeNode);
            var postBody = SerializationHelper.Serialize(request.Run); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (RunResponse)SerializationHelper.Deserialize(response, typeof(RunResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Reject all revisions in document 
        /// </summary>
        /// <param name="request">Request. <see cref="RejectAllRevisionsRequest" /></param> 
        /// <returns><see cref="RevisionsModificationResponse"/></returns>            
        public RevisionsModificationResponse RejectAllRevisions(RejectAllRevisionsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RejectAllRevisions");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/revisions/rejectAll";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (RevisionsModificationResponse)SerializationHelper.Deserialize(response, typeof(RevisionsModificationResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Renders drawing object to specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="RenderDrawingObjectRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream RenderDrawingObject(RenderDrawingObjectRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderDrawingObject");
            }

            // verify the required parameter 'format' is set
            if (request.Format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling RenderDrawingObject");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderDrawingObject");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/drawingObjects/{index}/render";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsLocation", request.FontsLocation);
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "GET", 
                        null, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Renders math object to specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="RenderMathObjectRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream RenderMathObject(RenderMathObjectRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderMathObject");
            }

            // verify the required parameter 'format' is set
            if (request.Format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling RenderMathObject");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderMathObject");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/OfficeMathObjects/{index}/render";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsLocation", request.FontsLocation);
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "GET", 
                        null, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Renders page to specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="RenderPageRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream RenderPage(RenderPageRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderPage");
            }

            // verify the required parameter 'pageIndex' is set
            if (request.PageIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageIndex' when calling RenderPage");
            }

            // verify the required parameter 'format' is set
            if (request.Format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling RenderPage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/pages/{pageIndex}/render";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "pageIndex", request.PageIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsLocation", request.FontsLocation);
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "GET", 
                        null, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Renders paragraph to specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="RenderParagraphRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream RenderParagraph(RenderParagraphRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderParagraph");
            }

            // verify the required parameter 'format' is set
            if (request.Format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling RenderParagraph");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderParagraph");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs/{index}/render";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsLocation", request.FontsLocation);
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "GET", 
                        null, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Renders table to specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="RenderTableRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream RenderTable(RenderTableRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderTable");
            }

            // verify the required parameter 'format' is set
            if (request.Format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling RenderTable");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderTable");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/tables/{index}/render";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsLocation", request.FontsLocation);
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "GET", 
                        null, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Resets font&#39;s cache. 
        /// </summary>
        /// <param name="request">Request. <see cref="ResetCacheRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse ResetCache(ResetCacheRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/fonts/cache";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (AsposeResponse)SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Search text in document. 
        /// </summary>
        /// <param name="request">Request. <see cref="SearchRequest" /></param> 
        /// <returns><see cref="SearchResponse"/></returns>            
        public SearchResponse Search(SearchRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling Search");
            }

            // verify the required parameter 'pattern' is set
            if (request.Pattern == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pattern' when calling Search");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/search";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pattern", request.Pattern);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (SearchResponse)SerializationHelper.Deserialize(response, typeof(SearchResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Updates border properties.              &#39;nodePath&#39; should refer to node with cell or row
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateBorderRequest" /></param> 
        /// <returns><see cref="BorderResponse"/></returns>            
        public BorderResponse UpdateBorder(UpdateBorderRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateBorder");
            }

            // verify the required parameter 'borderProperties' is set
            if (request.BorderProperties == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderProperties' when calling UpdateBorder");
            }

            // verify the required parameter 'nodePath' is set
            if (request.NodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling UpdateBorder");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateBorder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/borders/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            var postBody = SerializationHelper.Serialize(request.BorderProperties); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (BorderResponse)SerializationHelper.Deserialize(response, typeof(BorderResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Update page setup of section. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateSectionPageSetupRequest" /></param> 
        /// <returns><see cref="SectionPageSetupResponse"/></returns>            
        public SectionPageSetupResponse UpdateSectionPageSetup(UpdateSectionPageSetupRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateSectionPageSetup");
            }

            // verify the required parameter 'sectionIndex' is set
            if (request.SectionIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'sectionIndex' when calling UpdateSectionPageSetup");
            }

            // verify the required parameter 'pageSetup' is set
            if (request.PageSetup == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageSetup' when calling UpdateSectionPageSetup");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/sections/{sectionIndex}/pageSetup";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sectionIndex", request.SectionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            var postBody = SerializationHelper.Serialize(request.PageSetup); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (SectionPageSetupResponse)SerializationHelper.Deserialize(response, typeof(SectionPageSetupResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Updates a table cell format. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTableCellFormatRequest" /></param> 
        /// <returns><see cref="TableCellFormatResponse"/></returns>            
        public TableCellFormatResponse UpdateTableCellFormat(UpdateTableCellFormatRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateTableCellFormat");
            }

            // verify the required parameter 'tableRowPath' is set
            if (request.TableRowPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tableRowPath' when calling UpdateTableCellFormat");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateTableCellFormat");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{tableRowPath}/cells/{index}/cellformat";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "tableRowPath", request.TableRowPath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            var postBody = SerializationHelper.Serialize(request.Format); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (TableCellFormatResponse)SerializationHelper.Deserialize(response, typeof(TableCellFormatResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Updates a table properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTablePropertiesRequest" /></param> 
        /// <returns><see cref="TablePropertiesResponse"/></returns>            
        public TablePropertiesResponse UpdateTableProperties(UpdateTablePropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateTableProperties");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateTableProperties");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/tables/{index}/properties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "nodePath", request.NodePath);
            var postBody = SerializationHelper.Serialize(request.Properties); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (TablePropertiesResponse)SerializationHelper.Deserialize(response, typeof(TablePropertiesResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Updates a table row format. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTableRowFormatRequest" /></param> 
        /// <returns><see cref="TableRowFormatResponse"/></returns>            
        public TableRowFormatResponse UpdateTableRowFormat(UpdateTableRowFormatRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateTableRowFormat");
            }

            // verify the required parameter 'tablePath' is set
            if (request.TablePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tablePath' when calling UpdateTableRowFormat");
            }

            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateTableRowFormat");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{tablePath}/rows/{index}/rowformat";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "tablePath", request.TablePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            var postBody = SerializationHelper.Serialize(request.Format); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (TableRowFormatResponse)SerializationHelper.Deserialize(response, typeof(TableRowFormatResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
    }
}