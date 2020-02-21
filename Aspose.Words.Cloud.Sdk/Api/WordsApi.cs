// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WordsApi.cs">
//   Copyright (c) 2019 Aspose.Words for Cloud
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
            if (string.IsNullOrEmpty(configuration.AppKey?.Trim()))
            {
                throw new ArgumentException("AppKey configuration value must be non-empty string");
            }

            if (string.IsNullOrEmpty(configuration.AppSid?.Trim()))
            {
                throw new ArgumentException("AppSid configuration value must be non-empty string");
            }

            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new OAuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            requestHandlers.Add(new AuthWithSignatureRequestHandler(this.configuration));
            this.apiInvoker = new ApiInvoker(requestHandlers);
        }                            

        /// <summary>
        /// Accepts all revisions in document. 
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
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (RevisionsModificationResponse)SerializationHelper.Deserialize(response, typeof(RevisionsModificationResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Appends documents to original document. 
        /// </summary>
        /// <param name="request">Request. <see cref="AppendDocumentRequest" /></param>
        /// <returns><see cref="DocumentResponse"/></returns>         
        public DocumentResponse AppendDocument(AppendDocumentRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling AppendDocument");
            }

           // verify the required parameter 'documentList' is set
            if (request.DocumentList == null) 
            {
                throw new ApiException(400, "Missing required parameter 'documentList' when calling AppendDocument");
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
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                postBody, 
                null, 
                null);
            if (response != null)
            {
                return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Classifies raw text. 
        /// </summary>
        /// <param name="request">Request. <see cref="ClassifyRequest" /></param>
        /// <returns><see cref="ClassificationResponse"/></returns>         
        public ClassificationResponse Classify(ClassifyRequest request)
        {
           // verify the required parameter 'text' is set
            if (request.Text == null) 
            {
                throw new ApiException(400, "Missing required parameter 'text' when calling Classify");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/classify";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bestClassesCount", request.BestClassesCount);
            var postBody = SerializationHelper.Serialize(request.Text); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                postBody, 
                null, 
                null);
            if (response != null)
            {
                return (ClassificationResponse)SerializationHelper.Deserialize(response, typeof(ClassificationResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Classifies document. 
        /// </summary>
        /// <param name="request">Request. <see cref="ClassifyDocumentRequest" /></param>
        /// <returns><see cref="ClassificationResponse"/></returns>         
        public ClassificationResponse ClassifyDocument(ClassifyDocumentRequest request)
        {
           // verify the required parameter 'documentName' is set
            if (request.DocumentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'documentName' when calling ClassifyDocument");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{documentName}/classify";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "documentName", request.DocumentName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bestClassesCount", request.BestClassesCount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "taxonomy", request.Taxonomy);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (ClassificationResponse)SerializationHelper.Deserialize(response, typeof(ClassificationResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Compares document with original document. 
        /// </summary>
        /// <param name="request">Request. <see cref="CompareDocumentRequest" /></param>
        /// <returns><see cref="DocumentResponse"/></returns>         
        public DocumentResponse CompareDocument(CompareDocumentRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CompareDocument");
            }

           // verify the required parameter 'compareData' is set
            if (request.CompareData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'compareData' when calling CompareDocument");
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
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                postBody, 
                null, 
                null);
            if (response != null)
            {
                return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Converts document from the request&#39;s content to the specified format . 
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertDocumentRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>         
        public System.IO.Stream ConvertDocument(ConvertDocumentRequest request)
        {
           // verify the required parameter 'document' is set
            if (request.Document == null) 
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling ConvertDocument");
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileNameFieldValue", request.FileNameFieldValue);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsLocation", request.FontsLocation);
            
            if (request.Document != null) 
            {
                formParams.Add("document", this.apiInvoker.ToFileInfo(request.Document, "Document"));
            }
            
                    return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                   "PUT", 
                    null, 
                null, 
                formParams);
        }

        /// <summary>
        /// Copy file 
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFileRequest" /></param>         
        public void CopyFile(CopyFileRequest request)
        {
           // verify the required parameter 'srcPath' is set
            if (request.SrcPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling CopyFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/storage/file/copy/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.SrcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.DestPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.SrcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.DestStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.VersionId);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Copy folder 
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFolderRequest" /></param>         
        public void CopyFolder(CopyFolderRequest request)
        {
           // verify the required parameter 'srcPath' is set
            if (request.SrcPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling CopyFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/storage/folder/copy/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.SrcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.DestPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.SrcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.DestStorageName);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Creates new document. Document is created with format which is recognized from file extensions. Supported extensions: \&quot;.doc\&quot;, \&quot;.docx\&quot;, \&quot;.docm\&quot;, \&quot;.dot\&quot;, \&quot;.dotm\&quot;, \&quot;.dotx\&quot;, \&quot;.flatopc\&quot;, \&quot;.fopc\&quot;, \&quot;.flatopc_macro\&quot;, \&quot;.fopc_macro\&quot;, \&quot;.flatopc_template\&quot;, \&quot;.fopc_template\&quot;, \&quot;.flatopc_template_macro\&quot;, \&quot;.fopc_template_macro\&quot;, \&quot;.wordml\&quot;, \&quot;.wml\&quot;, \&quot;.rtf\&quot;. 
        /// </summary>
        /// <param name="request">Request. <see cref="CreateDocumentRequest" /></param>
        /// <returns><see cref="DocumentResponse"/></returns>         
        public DocumentResponse CreateDocument(CreateDocumentRequest request)
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

        /// <summary>
        /// Create the folder 
        /// </summary>
        /// <param name="request">Request. <see cref="CreateFolderRequest" /></param>         
        public void CreateFolder(CreateFolderRequest request)
        {
           // verify the required parameter 'path' is set
            if (request.Path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling CreateFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/storage/folder/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Adds new or update existing document property. 
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
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                postBody, 
                null, 
                null);
            if (response != null)
            {
                return (DocumentPropertyResponse)SerializationHelper.Deserialize(response, typeof(DocumentPropertyResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Resets border properties to default values.              &#39;nodePath&#39; should refer to paragraph, cell or row.
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

           // verify the required parameter 'borderType' is set
            if (request.BorderType == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderType' when calling DeleteBorder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/borders/{borderType}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "borderType", request.BorderType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            
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

        /// <summary>
        /// Resets borders properties to default values.              &#39;nodePath&#39; should refer to paragraph, cell or row.
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

        /// <summary>
        /// Removes comment from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteCommentRequest" /></param>         
        public void DeleteComment(DeleteCommentRequest request)
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
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Deletes document property. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDocumentPropertyRequest" /></param>         
        public void DeleteDocumentProperty(DeleteDocumentPropertyRequest request)
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
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Removes drawing object from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDrawingObjectRequest" /></param>         
        public void DeleteDrawingObject(DeleteDrawingObjectRequest request)
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Removes drawing object from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDrawingObjectWithoutNodePathRequest" /></param>         
        public void DeleteDrawingObjectWithoutNodePath(DeleteDrawingObjectWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteDrawingObjectWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteDrawingObjectWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/drawingObjects/{index}";
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
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Deletes field from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFieldRequest" /></param>         
        public void DeleteField(DeleteFieldRequest request)
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Deletes field from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFieldWithoutNodePathRequest" /></param>         
        public void DeleteFieldWithoutNodePath(DeleteFieldWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteFieldWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteFieldWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/fields/{index}";
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
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Removes fields from section paragraph. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFieldsRequest" /></param>         
        public void DeleteFields(DeleteFieldsRequest request)
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Removes fields from section paragraph. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFieldsWithoutNodePathRequest" /></param>         
        public void DeleteFieldsWithoutNodePath(DeleteFieldsWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteFieldsWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/fields";
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
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Delete file 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFileRequest" /></param>         
        public void DeleteFile(DeleteFileRequest request)
        {
           // verify the required parameter 'path' is set
            if (request.Path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/storage/file/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.VersionId);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Delete folder 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFolderRequest" /></param>         
        public void DeleteFolder(DeleteFolderRequest request)
        {
           // verify the required parameter 'path' is set
            if (request.Path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/storage/folder/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recursive", request.Recursive);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Removes footnote from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFootnoteRequest" /></param>         
        public void DeleteFootnote(DeleteFootnoteRequest request)
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Removes footnote from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFootnoteWithoutNodePathRequest" /></param>         
        public void DeleteFootnoteWithoutNodePath(DeleteFootnoteWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteFootnoteWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteFootnoteWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/footnotes/{index}";
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
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Removes form field from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFormFieldRequest" /></param>         
        public void DeleteFormField(DeleteFormFieldRequest request)
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Removes form field from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFormFieldWithoutNodePathRequest" /></param>         
        public void DeleteFormFieldWithoutNodePath(DeleteFormFieldWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteFormFieldWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteFormFieldWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/formfields/{index}";
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
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Deletes header/footer from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHeaderFooterRequest" /></param>         
        public void DeleteHeaderFooter(DeleteHeaderFooterRequest request)
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sectionPath", request.SectionPath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Deletes document headers and footers. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHeadersFootersRequest" /></param>         
        public void DeleteHeadersFooters(DeleteHeadersFootersRequest request)
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sectionPath", request.SectionPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "headersFootersTypes", request.HeadersFootersTypes);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Removes macros from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteMacrosRequest" /></param>         
        public void DeleteMacros(DeleteMacrosRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteMacros");
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
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Removes OfficeMath object from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteOfficeMathObjectRequest" /></param>         
        public void DeleteOfficeMathObject(DeleteOfficeMathObjectRequest request)
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Removes OfficeMath object from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteOfficeMathObjectWithoutNodePathRequest" /></param>         
        public void DeleteOfficeMathObjectWithoutNodePath(DeleteOfficeMathObjectWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteOfficeMathObjectWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteOfficeMathObjectWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/OfficeMathObjects/{index}";
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
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Removes paragraph from section. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphRequest" /></param>         
        public void DeleteParagraph(DeleteParagraphRequest request)
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Removes paragraph from section. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphWithoutNodePathRequest" /></param>         
        public void DeleteParagraphWithoutNodePath(DeleteParagraphWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteParagraphWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteParagraphWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/paragraphs/{index}";
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
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Removes run from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteRunRequest" /></param>         
        public void DeleteRun(DeleteRunRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteRun");
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
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Removes section from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSectionRequest" /></param>         
        public void DeleteSection(DeleteSectionRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSection");
            }

           // verify the required parameter 'sectionIndex' is set
            if (request.SectionIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'sectionIndex' when calling DeleteSection");
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Deletes a table. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableRequest" /></param>         
        public void DeleteTable(DeleteTableRequest request)
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Deletes a table cell. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableCellRequest" /></param>         
        public void DeleteTableCell(DeleteTableCellRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteTableCell");
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
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Deletes a table row. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableRowRequest" /></param>         
        public void DeleteTableRow(DeleteTableRowRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteTableRow");
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
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Deletes a table. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableWithoutNodePathRequest" /></param>         
        public void DeleteTableWithoutNodePath(DeleteTableWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteTableWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteTableWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/tables/{index}";
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
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Deletes watermark (for deleting last watermark from the document). 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWatermarkRequest" /></param>
        /// <returns><see cref="DocumentResponse"/></returns>         
        public DocumentResponse DeleteWatermark(DeleteWatermarkRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteWatermark");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/watermarks/deleteLast";
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

        /// <summary>
        /// Download file 
        /// </summary>
        /// <param name="request">Request. <see cref="DownloadFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>         
        public System.IO.Stream DownloadFile(DownloadFileRequest request)
        {
           // verify the required parameter 'path' is set
            if (request.Path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DownloadFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/storage/file/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.VersionId);
            
                    return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                   "GET", 
                    null, 
                null, 
                null);
        }

        /// <summary>
        /// Executes document mail merge operation. 
        /// </summary>
        /// <param name="request">Request. <see cref="ExecuteMailMergeRequest" /></param>
        /// <returns><see cref="DocumentResponse"/></returns>         
        public DocumentResponse ExecuteMailMerge(ExecuteMailMergeRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ExecuteMailMerge");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/MailMerge";
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "withRegions", request.WithRegions);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "mailMergeDataFile", request.MailMergeDataFile);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cleanup", request.Cleanup);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "useWholeParagraphAsRegion", request.UseWholeParagraphAsRegion);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            
            if (request.Data != null) 
            {
                formParams.Add("Data", request.Data); // form parameter
            }
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                formParams);
            if (response != null)
            {
                return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Executes document mail merge online. 
        /// </summary>
        /// <param name="request">Request. <see cref="ExecuteMailMergeOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>         
        public System.IO.Stream ExecuteMailMergeOnline(ExecuteMailMergeOnlineRequest request)
        {
           // verify the required parameter 'template' is set
            if (request.Template == null) 
            {
                throw new ApiException(400, "Missing required parameter 'template' when calling ExecuteMailMergeOnline");
            }

           // verify the required parameter 'data' is set
            if (request.Data == null) 
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling ExecuteMailMergeOnline");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/MailMerge";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "withRegions", request.WithRegions);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cleanup", request.Cleanup);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "documentFileName", request.DocumentFileName);
            
            if (request.Template != null) 
            {
                formParams.Add("template", this.apiInvoker.ToFileInfo(request.Template, "Template"));
            }
            
            if (request.Data != null) 
            {
                formParams.Add("data", this.apiInvoker.ToFileInfo(request.Data, "Data"));
            }
            
                    return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                   "PUT", 
                    null, 
                null, 
                formParams);
        }

        /// <summary>
        /// Gets the list of fonts, available for document processing. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetAvailableFontsRequest" /></param>
        /// <returns><see cref="AvailableFontsResponse"/></returns>         
        public AvailableFontsResponse GetAvailableFonts(GetAvailableFontsRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/fonts/available";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsLocation", request.FontsLocation);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (AvailableFontsResponse)SerializationHelper.Deserialize(response, typeof(AvailableFontsResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Reads document bookmark data by its name. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetBookmarkByNameRequest" /></param>
        /// <returns><see cref="BookmarkResponse"/></returns>         
        public BookmarkResponse GetBookmarkByName(GetBookmarkByNameRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetBookmarkByName");
            }

           // verify the required parameter 'bookmarkName' is set
            if (request.BookmarkName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bookmarkName' when calling GetBookmarkByName");
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

        /// <summary>
        /// Reads document bookmarks common info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetBookmarksRequest" /></param>
        /// <returns><see cref="BookmarksResponse"/></returns>         
        public BookmarksResponse GetBookmarks(GetBookmarksRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetBookmarks");
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

        /// <summary>
        /// Returns a border. &#39;nodePath&#39; should refer to paragraph, cell or row.
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

           // verify the required parameter 'borderType' is set
            if (request.BorderType == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderType' when calling GetBorder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/borders/{borderType}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "borderType", request.BorderType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
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

        /// <summary>
        /// Returns a collection of borders. &#39;nodePath&#39; should refer to paragraph, cell or row.
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

        /// <summary>
        /// Gets comment from document. 
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

        /// <summary>
        /// Gets comments from document. 
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

        /// <summary>
        /// Reads document common info. 
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

        /// <summary>
        /// Reads document drawing object common info by its index or convert to format specified. 
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
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

        /// <summary>
        /// Reads document drawing object common info by its index or convert to format specified. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectByIndexWithoutNodePathRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse"/></returns>         
        public DrawingObjectResponse GetDocumentDrawingObjectByIndexWithoutNodePath(GetDocumentDrawingObjectByIndexWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjectByIndexWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentDrawingObjectByIndexWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/drawingObjects/{index}";
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

        /// <summary>
        /// Reads drawing object image data. 
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
                    return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                   "GET", 
                    null, 
                null, 
                null);
        }

        /// <summary>
        /// Reads drawing object image data. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectImageDataWithoutNodePathRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>         
        public System.IO.Stream GetDocumentDrawingObjectImageDataWithoutNodePath(GetDocumentDrawingObjectImageDataWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjectImageDataWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentDrawingObjectImageDataWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/drawingObjects/{index}/imageData";
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
            
                    return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                   "GET", 
                    null, 
                null, 
                null);
        }

        /// <summary>
        /// Gets drawing object OLE data. 
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
                    return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                   "GET", 
                    null, 
                null, 
                null);
        }

        /// <summary>
        /// Gets drawing object OLE data. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectOleDataWithoutNodePathRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>         
        public System.IO.Stream GetDocumentDrawingObjectOleDataWithoutNodePath(GetDocumentDrawingObjectOleDataWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjectOleDataWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentDrawingObjectOleDataWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/drawingObjects/{index}/oleData";
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
            
                    return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                   "GET", 
                    null, 
                null, 
                null);
        }

        /// <summary>
        /// Reads document drawing objects common info. 
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
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

        /// <summary>
        /// Reads document drawing objects common info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectsWithoutNodePathRequest" /></param>
        /// <returns><see cref="DrawingObjectsResponse"/></returns>         
        public DrawingObjectsResponse GetDocumentDrawingObjectsWithoutNodePath(GetDocumentDrawingObjectsWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjectsWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/drawingObjects";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
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

        /// <summary>
        /// Reads document field names. 
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
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/mailMerge/FieldNames";
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

        /// <summary>
        /// Reads document field names. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentFieldNamesOnlineRequest" /></param>
        /// <returns><see cref="FieldNamesResponse"/></returns>         
        public FieldNamesResponse GetDocumentFieldNamesOnline(GetDocumentFieldNamesOnlineRequest request)
        {
           // verify the required parameter 'template' is set
            if (request.Template == null) 
            {
                throw new ApiException(400, "Missing required parameter 'template' when calling GetDocumentFieldNamesOnline");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/mailMerge/FieldNames";
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

        /// <summary>
        /// Reads document hyperlink by its index. 
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

        /// <summary>
        /// Reads document hyperlinks common info. 
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

        /// <summary>
        /// Reads document properties info. 
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

        /// <summary>
        /// Reads document property info by the property name. 
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

        /// <summary>
        /// Reads document protection common info. 
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

        /// <summary>
        /// Reads document statistics. 
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

        /// <summary>
        /// Exports the document into the specified format. 
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
            
                    return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                   "GET", 
                    null, 
                null, 
                null);
        }

        /// <summary>
        /// Gets field from document. 
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
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

        /// <summary>
        /// Gets field from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFieldWithoutNodePathRequest" /></param>
        /// <returns><see cref="FieldResponse"/></returns>         
        public FieldResponse GetFieldWithoutNodePath(GetFieldWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFieldWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetFieldWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/fields/{index}";
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
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

        /// <summary>
        /// Get fields from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFieldsWithoutNodePathRequest" /></param>
        /// <returns><see cref="FieldsResponse"/></returns>         
        public FieldsResponse GetFieldsWithoutNodePath(GetFieldsWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFieldsWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/fields";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
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

        /// <summary>
        /// Get all files and folders within a folder 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFilesListRequest" /></param>
        /// <returns><see cref="FilesList"/></returns>         
        public FilesList GetFilesList(GetFilesListRequest request)
        {
           // verify the required parameter 'path' is set
            if (request.Path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetFilesList");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/storage/folder/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (FilesList)SerializationHelper.Deserialize(response, typeof(FilesList));
            }
                    
            return null;
        }

        /// <summary>
        /// Reads footnote by index. 
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
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

        /// <summary>
        /// Reads footnote by index. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFootnoteWithoutNodePathRequest" /></param>
        /// <returns><see cref="FootnoteResponse"/></returns>         
        public FootnoteResponse GetFootnoteWithoutNodePath(GetFootnoteWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFootnoteWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetFootnoteWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/footnotes/{index}";
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

        /// <summary>
        /// Gets footnotes from document. 
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
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

        /// <summary>
        /// Gets footnotes from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFootnotesWithoutNodePathRequest" /></param>
        /// <returns><see cref="FootnotesResponse"/></returns>         
        public FootnotesResponse GetFootnotesWithoutNodePath(GetFootnotesWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFootnotesWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/footnotes";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
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

        /// <summary>
        /// Returns representation of an one of the form field. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFormFieldWithoutNodePathRequest" /></param>
        /// <returns><see cref="FormFieldResponse"/></returns>         
        public FormFieldResponse GetFormFieldWithoutNodePath(GetFormFieldWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFormFieldWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetFormFieldWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/formfields/{index}";
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

        /// <summary>
        /// Gets form fields from document. 
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
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

        /// <summary>
        /// Gets form fields from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFormFieldsWithoutNodePathRequest" /></param>
        /// <returns><see cref="FormFieldsResponse"/></returns>         
        public FormFieldsResponse GetFormFieldsWithoutNodePath(GetFormFieldsWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFormFieldsWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/formfields";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
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

        /// <summary>
        /// Returns a header/footer from the document by index. 
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

        /// <summary>
        /// Returns a header/footer from the document section. 
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

        /// <summary>
        /// Returns a list of header/footers from the document. 
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sectionPath", request.SectionPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "filterByType", request.FilterByType);
            
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

        /// <summary>
        /// Reads OfficeMath object by index. 
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
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

        /// <summary>
        /// Reads OfficeMath object by index. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetOfficeMathObjectWithoutNodePathRequest" /></param>
        /// <returns><see cref="OfficeMathObjectResponse"/></returns>         
        public OfficeMathObjectResponse GetOfficeMathObjectWithoutNodePath(GetOfficeMathObjectWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetOfficeMathObjectWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetOfficeMathObjectWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/OfficeMathObjects/{index}";
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

        /// <summary>
        /// Gets OfficeMath objects from document. 
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
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

        /// <summary>
        /// Gets OfficeMath objects from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetOfficeMathObjectsWithoutNodePathRequest" /></param>
        /// <returns><see cref="OfficeMathObjectsResponse"/></returns>         
        public OfficeMathObjectsResponse GetOfficeMathObjectsWithoutNodePath(GetOfficeMathObjectsWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetOfficeMathObjectsWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/OfficeMathObjects";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
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

        /// <summary>
        /// This resource represents one of the paragraphs contained in the document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphRequest" /></param>
        /// <returns><see cref="ParagraphResponse"/></returns>         
        public ParagraphResponse GetParagraph(GetParagraphRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetParagraph");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetParagraph");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs/{index}";
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

        /// <summary>
        /// Represents all the formatting for a paragraph. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphFormatRequest" /></param>
        /// <returns><see cref="ParagraphFormatResponse"/></returns>         
        public ParagraphFormatResponse GetParagraphFormat(GetParagraphFormatRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetParagraphFormat");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetParagraphFormat");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs/{index}/format";
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
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (ParagraphFormatResponse)SerializationHelper.Deserialize(response, typeof(ParagraphFormatResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Represents all the formatting for a paragraph. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphFormatWithoutNodePathRequest" /></param>
        /// <returns><see cref="ParagraphFormatResponse"/></returns>         
        public ParagraphFormatResponse GetParagraphFormatWithoutNodePath(GetParagraphFormatWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetParagraphFormatWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetParagraphFormatWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/paragraphs/{index}/format";
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
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (ParagraphFormatResponse)SerializationHelper.Deserialize(response, typeof(ParagraphFormatResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// This resource represents one of the paragraphs contained in the document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphWithoutNodePathRequest" /></param>
        /// <returns><see cref="ParagraphResponse"/></returns>         
        public ParagraphResponse GetParagraphWithoutNodePath(GetParagraphWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetParagraphWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetParagraphWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/paragraphs/{index}";
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

        /// <summary>
        /// Returns a list of paragraphs that are contained in the document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphsRequest" /></param>
        /// <returns><see cref="ParagraphLinkCollectionResponse"/></returns>         
        public ParagraphLinkCollectionResponse GetParagraphs(GetParagraphsRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetParagraphs");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs";
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

        /// <summary>
        /// Returns a list of paragraphs that are contained in the document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphsWithoutNodePathRequest" /></param>
        /// <returns><see cref="ParagraphLinkCollectionResponse"/></returns>         
        public ParagraphLinkCollectionResponse GetParagraphsWithoutNodePath(GetParagraphsWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetParagraphsWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/paragraphs";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
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

        /// <summary>
        /// Gets the text from the range. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetRangeTextRequest" /></param>
        /// <returns><see cref="RangeTextResponse"/></returns>         
        public RangeTextResponse GetRangeText(GetRangeTextRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetRangeText");
            }

           // verify the required parameter 'rangeStartIdentifier' is set
            if (request.RangeStartIdentifier == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rangeStartIdentifier' when calling GetRangeText");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/range/{rangeStartIdentifier}/{rangeEndIdentifier}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "rangeStartIdentifier", request.RangeStartIdentifier);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "rangeEndIdentifier", request.RangeEndIdentifier);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (RangeTextResponse)SerializationHelper.Deserialize(response, typeof(RangeTextResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// This resource represents run of text contained in the document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetRunRequest" /></param>
        /// <returns><see cref="RunResponse"/></returns>         
        public RunResponse GetRun(GetRunRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetRun");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetRun");
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

        /// <summary>
        /// This resource represents font of run. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetRunFontRequest" /></param>
        /// <returns><see cref="FontResponse"/></returns>         
        public FontResponse GetRunFont(GetRunFontRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetRunFont");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetRunFont");
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

        /// <summary>
        /// This resource represents collection of runs in the paragraph. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetRunsRequest" /></param>
        /// <returns><see cref="RunsResponse"/></returns>         
        public RunsResponse GetRuns(GetRunsRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetRuns");
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

        /// <summary>
        /// Gets document section by index. 
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

        /// <summary>
        /// Gets page setup of section. 
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

        /// <summary>
        /// Returns a list of sections that are contained in the document. 
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

        /// <summary>
        /// Returns a table. 
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
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

        /// <summary>
        /// Returns a table cell. 
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

        /// <summary>
        /// Returns a table cell format. 
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

        /// <summary>
        /// Returns a table properties. 
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
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

        /// <summary>
        /// Returns a table properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetTablePropertiesWithoutNodePathRequest" /></param>
        /// <returns><see cref="TablePropertiesResponse"/></returns>         
        public TablePropertiesResponse GetTablePropertiesWithoutNodePath(GetTablePropertiesWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTablePropertiesWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTablePropertiesWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/tables/{index}/properties";
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

        /// <summary>
        /// Returns a table row. 
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

        /// <summary>
        /// Returns a table row format. 
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

        /// <summary>
        /// Returns a table. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableWithoutNodePathRequest" /></param>
        /// <returns><see cref="TableResponse"/></returns>         
        public TableResponse GetTableWithoutNodePath(GetTableWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTableWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/tables/{index}";
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

        /// <summary>
        /// Returns a list of tables that are contained in the document. 
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
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

        /// <summary>
        /// Returns a list of tables that are contained in the document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetTablesWithoutNodePathRequest" /></param>
        /// <returns><see cref="TableLinkCollectionResponse"/></returns>         
        public TableLinkCollectionResponse GetTablesWithoutNodePath(GetTablesWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTablesWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/tables";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
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

        /// <summary>
        /// Adds comment to document, returns inserted comment data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertCommentRequest" /></param>
        /// <returns><see cref="CommentResponse"/></returns>         
        public CommentResponse InsertComment(InsertCommentRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertComment");
            }

           // verify the required parameter 'comment' is set
            if (request.Comment == null) 
            {
                throw new ApiException(400, "Missing required parameter 'comment' when calling InsertComment");
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

        /// <summary>
        /// Adds drawing object to document, returns added  drawing object&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertDrawingObjectRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse"/></returns>         
        public DrawingObjectResponse InsertDrawingObject(InsertDrawingObjectRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertDrawingObject");
            }

           // verify the required parameter 'drawingObject' is set
            if (request.DrawingObject == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingObject' when calling InsertDrawingObject");
            }

           // verify the required parameter 'imageFile' is set
            if (request.ImageFile == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageFile' when calling InsertDrawingObject");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/drawingObjects";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            
            if (request.DrawingObject != null) 
            {
                formParams.Add("DrawingObject", request.DrawingObject); // form parameter
            }
            
            if (request.ImageFile != null) 
            {
                formParams.Add("imageFile", this.apiInvoker.ToFileInfo(request.ImageFile, "ImageFile"));
            }
            
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

        /// <summary>
        /// Adds drawing object to document, returns added  drawing object&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertDrawingObjectWithoutNodePathRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse"/></returns>         
        public DrawingObjectResponse InsertDrawingObjectWithoutNodePath(InsertDrawingObjectWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertDrawingObjectWithoutNodePath");
            }

           // verify the required parameter 'drawingObject' is set
            if (request.DrawingObject == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingObject' when calling InsertDrawingObjectWithoutNodePath");
            }

           // verify the required parameter 'imageFile' is set
            if (request.ImageFile == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageFile' when calling InsertDrawingObjectWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/drawingObjects";
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
            
            if (request.DrawingObject != null) 
            {
                formParams.Add("DrawingObject", request.DrawingObject); // form parameter
            }
            
            if (request.ImageFile != null) 
            {
                formParams.Add("imageFile", this.apiInvoker.ToFileInfo(request.ImageFile, "ImageFile"));
            }
            
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

        /// <summary>
        /// Adds field to document, returns inserted field&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFieldRequest" /></param>
        /// <returns><see cref="FieldResponse"/></returns>         
        public FieldResponse InsertField(InsertFieldRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertField");
            }

           // verify the required parameter 'field' is set
            if (request.Field == null) 
            {
                throw new ApiException(400, "Missing required parameter 'field' when calling InsertField");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/fields";
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "insertBeforeNode", request.InsertBeforeNode);
            var postBody = SerializationHelper.Serialize(request.Field); // http body (model) parameter
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

        /// <summary>
        /// Adds field to document, returns inserted field&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFieldWithoutNodePathRequest" /></param>
        /// <returns><see cref="FieldResponse"/></returns>         
        public FieldResponse InsertFieldWithoutNodePath(InsertFieldWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertFieldWithoutNodePath");
            }

           // verify the required parameter 'field' is set
            if (request.Field == null) 
            {
                throw new ApiException(400, "Missing required parameter 'field' when calling InsertFieldWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/fields";
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "insertBeforeNode", request.InsertBeforeNode);
            var postBody = SerializationHelper.Serialize(request.Field); // http body (model) parameter
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

        /// <summary>
        /// Adds footnote to document, returns added footnote&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFootnoteRequest" /></param>
        /// <returns><see cref="FootnoteResponse"/></returns>         
        public FootnoteResponse InsertFootnote(InsertFootnoteRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertFootnote");
            }

           // verify the required parameter 'footnoteDto' is set
            if (request.FootnoteDto == null) 
            {
                throw new ApiException(400, "Missing required parameter 'footnoteDto' when calling InsertFootnote");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/footnotes";
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
            var postBody = SerializationHelper.Serialize(request.FootnoteDto); // http body (model) parameter
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

        /// <summary>
        /// Adds footnote to document, returns added footnote&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFootnoteWithoutNodePathRequest" /></param>
        /// <returns><see cref="FootnoteResponse"/></returns>         
        public FootnoteResponse InsertFootnoteWithoutNodePath(InsertFootnoteWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertFootnoteWithoutNodePath");
            }

           // verify the required parameter 'footnoteDto' is set
            if (request.FootnoteDto == null) 
            {
                throw new ApiException(400, "Missing required parameter 'footnoteDto' when calling InsertFootnoteWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/footnotes";
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
            var postBody = SerializationHelper.Serialize(request.FootnoteDto); // http body (model) parameter
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

        /// <summary>
        /// Adds form field to paragraph, returns added form field&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFormFieldRequest" /></param>
        /// <returns><see cref="FormFieldResponse"/></returns>         
        public FormFieldResponse InsertFormField(InsertFormFieldRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertFormField");
            }

           // verify the required parameter 'formField' is set
            if (request.FormField == null) 
            {
                throw new ApiException(400, "Missing required parameter 'formField' when calling InsertFormField");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/formfields";
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "insertBeforeNode", request.InsertBeforeNode);
            var postBody = SerializationHelper.Serialize(request.FormField); // http body (model) parameter
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

        /// <summary>
        /// Adds form field to paragraph, returns added form field&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFormFieldWithoutNodePathRequest" /></param>
        /// <returns><see cref="FormFieldResponse"/></returns>         
        public FormFieldResponse InsertFormFieldWithoutNodePath(InsertFormFieldWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertFormFieldWithoutNodePath");
            }

           // verify the required parameter 'formField' is set
            if (request.FormField == null) 
            {
                throw new ApiException(400, "Missing required parameter 'formField' when calling InsertFormFieldWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/formfields";
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "insertBeforeNode", request.InsertBeforeNode);
            var postBody = SerializationHelper.Serialize(request.FormField); // http body (model) parameter
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

        /// <summary>
        /// Inserts to document header or footer. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertHeaderFooterRequest" /></param>
        /// <returns><see cref="HeaderFooterResponse"/></returns>         
        public HeaderFooterResponse InsertHeaderFooter(InsertHeaderFooterRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertHeaderFooter");
            }

           // verify the required parameter 'headerFooterType' is set
            if (request.HeaderFooterType == null) 
            {
                throw new ApiException(400, "Missing required parameter 'headerFooterType' when calling InsertHeaderFooter");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{sectionPath}/headersfooters";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sectionPath", request.SectionPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            var postBody = SerializationHelper.Serialize(request.HeaderFooterType); // http body (model) parameter
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

        /// <summary>
        /// Inserts document page numbers. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertPageNumbersRequest" /></param>
        /// <returns><see cref="DocumentResponse"/></returns>         
        public DocumentResponse InsertPageNumbers(InsertPageNumbersRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertPageNumbers");
            }

           // verify the required parameter 'pageNumber' is set
            if (request.PageNumber == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling InsertPageNumbers");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/PageNumbers";
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
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                postBody, 
                null, 
                null);
            if (response != null)
            {
                return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Adds paragraph to document, returns added paragraph&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertParagraphRequest" /></param>
        /// <returns><see cref="ParagraphResponse"/></returns>         
        public ParagraphResponse InsertParagraph(InsertParagraphRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertParagraph");
            }

           // verify the required parameter 'paragraph' is set
            if (request.Paragraph == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraph' when calling InsertParagraph");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs";
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "insertBeforeNode", request.InsertBeforeNode);
            var postBody = SerializationHelper.Serialize(request.Paragraph); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
                postBody, 
                null, 
                null);
            if (response != null)
            {
                return (ParagraphResponse)SerializationHelper.Deserialize(response, typeof(ParagraphResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Adds run to document, returns added paragraph&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertRunRequest" /></param>
        /// <returns><see cref="RunResponse"/></returns>         
        public RunResponse InsertRun(InsertRunRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertRun");
            }

           // verify the required parameter 'run' is set
            if (request.Run == null) 
            {
                throw new ApiException(400, "Missing required parameter 'run' when calling InsertRun");
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

           // verify the required parameter 'table' is set
            if (request.Table == null) 
            {
                throw new ApiException(400, "Missing required parameter 'table' when calling InsertTable");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/tables";
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
            var postBody = SerializationHelper.Serialize(request.Table); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
                postBody, 
                null, 
                null);
            if (response != null)
            {
                return (TableResponse)SerializationHelper.Deserialize(response, typeof(TableResponse));
            }
                    
            return null;
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

           // verify the required parameter 'cell' is set
            if (request.Cell == null) 
            {
                throw new ApiException(400, "Missing required parameter 'cell' when calling InsertTableCell");
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
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
                postBody, 
                null, 
                null);
            if (response != null)
            {
                return (TableCellResponse)SerializationHelper.Deserialize(response, typeof(TableCellResponse));
            }
                    
            return null;
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

           // verify the required parameter 'row' is set
            if (request.Row == null) 
            {
                throw new ApiException(400, "Missing required parameter 'row' when calling InsertTableRow");
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
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
                postBody, 
                null, 
                null);
            if (response != null)
            {
                return (TableRowResponse)SerializationHelper.Deserialize(response, typeof(TableRowResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Adds table to document, returns added table&#39;s data.              
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableWithoutNodePathRequest" /></param>
        /// <returns><see cref="TableResponse"/></returns>         
        public TableResponse InsertTableWithoutNodePath(InsertTableWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertTableWithoutNodePath");
            }

           // verify the required parameter 'table' is set
            if (request.Table == null) 
            {
                throw new ApiException(400, "Missing required parameter 'table' when calling InsertTableWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/tables";
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
            var postBody = SerializationHelper.Serialize(request.Table); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
                postBody, 
                null, 
                null);
            if (response != null)
            {
                return (TableResponse)SerializationHelper.Deserialize(response, typeof(TableResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Inserts document watermark image. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertWatermarkImageRequest" /></param>
        /// <returns><see cref="DocumentResponse"/></returns>         
        public DocumentResponse InsertWatermarkImage(InsertWatermarkImageRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertWatermarkImage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/watermarks/images";
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

        /// <summary>
        /// Inserts document watermark text. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertWatermarkTextRequest" /></param>
        /// <returns><see cref="DocumentResponse"/></returns>         
        public DocumentResponse InsertWatermarkText(InsertWatermarkTextRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertWatermarkText");
            }

           // verify the required parameter 'watermarkText' is set
            if (request.WatermarkText == null) 
            {
                throw new ApiException(400, "Missing required parameter 'watermarkText' when calling InsertWatermarkText");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/watermarks/texts";
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

        /// <summary>
        /// Loads new document from web into the file with any supported format of data. 
        /// </summary>
        /// <param name="request">Request. <see cref="LoadWebDocumentRequest" /></param>
        /// <returns><see cref="SaveResponse"/></returns>         
        public SaveResponse LoadWebDocument(LoadWebDocumentRequest request)
        {
           // verify the required parameter 'data' is set
            if (request.Data == null) 
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling LoadWebDocument");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/loadWebDocument";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Data); // http body (model) parameter
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

        /// <summary>
        /// Move file 
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFileRequest" /></param>         
        public void MoveFile(MoveFileRequest request)
        {
           // verify the required parameter 'srcPath' is set
            if (request.SrcPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling MoveFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/storage/file/move/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.SrcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.DestPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.SrcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.DestStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.VersionId);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Move folder 
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFolderRequest" /></param>         
        public void MoveFolder(MoveFolderRequest request)
        {
           // verify the required parameter 'srcPath' is set
            if (request.SrcPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling MoveFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/storage/folder/move/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.SrcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.DestPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.SrcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.DestStorageName);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Protects document. 
        /// </summary>
        /// <param name="request">Request. <see cref="ProtectDocumentRequest" /></param>
        /// <returns><see cref="ProtectionDataResponse"/></returns>         
        public ProtectionDataResponse ProtectDocument(ProtectDocumentRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ProtectDocument");
            }

           // verify the required parameter 'protectionRequest' is set
            if (request.ProtectionRequest == null) 
            {
                throw new ApiException(400, "Missing required parameter 'protectionRequest' when calling ProtectDocument");
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

        /// <summary>
        /// Rejects all revisions in document. 
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
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (RevisionsModificationResponse)SerializationHelper.Deserialize(response, typeof(RevisionsModificationResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Removes the range from the document. 
        /// </summary>
        /// <param name="request">Request. <see cref="RemoveRangeRequest" /></param>
        /// <returns><see cref="DocumentResponse"/></returns>         
        public DocumentResponse RemoveRange(RemoveRangeRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RemoveRange");
            }

           // verify the required parameter 'rangeStartIdentifier' is set
            if (request.RangeStartIdentifier == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rangeStartIdentifier' when calling RemoveRange");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/range/{rangeStartIdentifier}/{rangeEndIdentifier}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "rangeStartIdentifier", request.RangeStartIdentifier);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "rangeEndIdentifier", request.RangeEndIdentifier);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsLocation", request.FontsLocation);
            
                    return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                   "GET", 
                    null, 
                null, 
                null);
        }

        /// <summary>
        /// Renders drawing object to specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="RenderDrawingObjectWithoutNodePathRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>         
        public System.IO.Stream RenderDrawingObjectWithoutNodePath(RenderDrawingObjectWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderDrawingObjectWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderDrawingObjectWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/drawingObjects/{index}/render";
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsLocation", request.FontsLocation);
            
                    return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                   "GET", 
                    null, 
                null, 
                null);
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsLocation", request.FontsLocation);
            
                    return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                   "GET", 
                    null, 
                null, 
                null);
        }

        /// <summary>
        /// Renders math object to specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="RenderMathObjectWithoutNodePathRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>         
        public System.IO.Stream RenderMathObjectWithoutNodePath(RenderMathObjectWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderMathObjectWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderMathObjectWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/OfficeMathObjects/{index}/render";
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsLocation", request.FontsLocation);
            
                    return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                   "GET", 
                    null, 
                null, 
                null);
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
            
                    return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                   "GET", 
                    null, 
                null, 
                null);
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsLocation", request.FontsLocation);
            
                    return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                   "GET", 
                    null, 
                null, 
                null);
        }

        /// <summary>
        /// Renders paragraph to specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="RenderParagraphWithoutNodePathRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>         
        public System.IO.Stream RenderParagraphWithoutNodePath(RenderParagraphWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderParagraphWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderParagraphWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/paragraphs/{index}/render";
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsLocation", request.FontsLocation);
            
                    return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                   "GET", 
                    null, 
                null, 
                null);
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsLocation", request.FontsLocation);
            
                    return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                   "GET", 
                    null, 
                null, 
                null);
        }

        /// <summary>
        /// Renders table to specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="RenderTableWithoutNodePathRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>         
        public System.IO.Stream RenderTableWithoutNodePath(RenderTableWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderTableWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderTableWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/tables/{index}/render";
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsLocation", request.FontsLocation);
            
                    return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                   "GET", 
                    null, 
                null, 
                null);
        }

        /// <summary>
        /// Replaces document text. 
        /// </summary>
        /// <param name="request">Request. <see cref="ReplaceTextRequest" /></param>
        /// <returns><see cref="ReplaceTextResponse"/></returns>         
        public ReplaceTextResponse ReplaceText(ReplaceTextRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceText");
            }

           // verify the required parameter 'replaceText' is set
            if (request.ReplaceText == null) 
            {
                throw new ApiException(400, "Missing required parameter 'replaceText' when calling ReplaceText");
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
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                postBody, 
                null, 
                null);
            if (response != null)
            {
                return (ReplaceTextResponse)SerializationHelper.Deserialize(response, typeof(ReplaceTextResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Replaces the content in the range. 
        /// </summary>
        /// <param name="request">Request. <see cref="ReplaceWithTextRequest" /></param>
        /// <returns><see cref="DocumentResponse"/></returns>         
        public DocumentResponse ReplaceWithText(ReplaceWithTextRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceWithText");
            }

           // verify the required parameter 'rangeStartIdentifier' is set
            if (request.RangeStartIdentifier == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rangeStartIdentifier' when calling ReplaceWithText");
            }

           // verify the required parameter 'rangeText' is set
            if (request.RangeText == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rangeText' when calling ReplaceWithText");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/range/{rangeStartIdentifier}/{rangeEndIdentifier}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "rangeStartIdentifier", request.RangeStartIdentifier);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "rangeEndIdentifier", request.RangeEndIdentifier);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            var postBody = SerializationHelper.Serialize(request.RangeText); // http body (model) parameter
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

        /// <summary>
        /// Resets font&#39;s cache. 
        /// </summary>
        /// <param name="request">Request. <see cref="ResetCacheRequest" /></param>         
        public void ResetCache(ResetCacheRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/fonts/cache";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Converts document to destination format with detailed settings and saves result to storage. 
        /// </summary>
        /// <param name="request">Request. <see cref="SaveAsRequest" /></param>
        /// <returns><see cref="SaveResponse"/></returns>         
        public SaveResponse SaveAs(SaveAsRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling SaveAs");
            }

           // verify the required parameter 'saveOptionsData' is set
            if (request.SaveOptionsData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'saveOptionsData' when calling SaveAs");
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsLocation", request.FontsLocation);
            var postBody = SerializationHelper.Serialize(request.SaveOptionsData); // http body (model) parameter
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

        /// <summary>
        /// Saves the selected range as a new document. 
        /// </summary>
        /// <param name="request">Request. <see cref="SaveAsRangeRequest" /></param>
        /// <returns><see cref="DocumentResponse"/></returns>         
        public DocumentResponse SaveAsRange(SaveAsRangeRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling SaveAsRange");
            }

           // verify the required parameter 'rangeStartIdentifier' is set
            if (request.RangeStartIdentifier == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rangeStartIdentifier' when calling SaveAsRange");
            }

           // verify the required parameter 'documentParameters' is set
            if (request.DocumentParameters == null) 
            {
                throw new ApiException(400, "Missing required parameter 'documentParameters' when calling SaveAsRange");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/range/{rangeStartIdentifier}/{rangeEndIdentifier}/SaveAs";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "rangeStartIdentifier", request.RangeStartIdentifier);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "rangeEndIdentifier", request.RangeEndIdentifier);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            var postBody = SerializationHelper.Serialize(request.DocumentParameters); // http body (model) parameter
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

        /// <summary>
        /// Converts document to tiff with detailed settings and saves result to storage. 
        /// </summary>
        /// <param name="request">Request. <see cref="SaveAsTiffRequest" /></param>
        /// <returns><see cref="SaveResponse"/></returns>         
        public SaveResponse SaveAsTiff(SaveAsTiffRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling SaveAsTiff");
            }

           // verify the required parameter 'saveOptions' is set
            if (request.SaveOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'saveOptions' when calling SaveAsTiff");
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

        /// <summary>
        /// Searches text in document. 
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

        /// <summary>
        /// Splits document. 
        /// </summary>
        /// <param name="request">Request. <see cref="SplitDocumentRequest" /></param>
        /// <returns><see cref="SplitDocumentResponse"/></returns>         
        public SplitDocumentResponse SplitDocument(SplitDocumentRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling SplitDocument");
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
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (SplitDocumentResponse)SerializationHelper.Deserialize(response, typeof(SplitDocumentResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Unprotects document. 
        /// </summary>
        /// <param name="request">Request. <see cref="UnprotectDocumentRequest" /></param>
        /// <returns><see cref="ProtectionDataResponse"/></returns>         
        public ProtectionDataResponse UnprotectDocument(UnprotectDocumentRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UnprotectDocument");
            }

           // verify the required parameter 'protectionRequest' is set
            if (request.ProtectionRequest == null) 
            {
                throw new ApiException(400, "Missing required parameter 'protectionRequest' when calling UnprotectDocument");
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

        /// <summary>
        /// Updates document bookmark. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateBookmarkRequest" /></param>
        /// <returns><see cref="BookmarkResponse"/></returns>         
        public BookmarkResponse UpdateBookmark(UpdateBookmarkRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateBookmark");
            }

           // verify the required parameter 'bookmarkData' is set
            if (request.BookmarkData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bookmarkData' when calling UpdateBookmark");
            }

           // verify the required parameter 'bookmarkName' is set
            if (request.BookmarkName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bookmarkName' when calling UpdateBookmark");
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
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                postBody, 
                null, 
                null);
            if (response != null)
            {
                return (BookmarkResponse)SerializationHelper.Deserialize(response, typeof(BookmarkResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Updates border properties.              &#39;nodePath&#39; should refer to paragraph, cell or row.
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

           // verify the required parameter 'borderType' is set
            if (request.BorderType == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderType' when calling UpdateBorder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/borders/{borderType}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "borderType", request.BorderType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            var postBody = SerializationHelper.Serialize(request.BorderProperties); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                postBody, 
                null, 
                null);
            if (response != null)
            {
                return (BorderResponse)SerializationHelper.Deserialize(response, typeof(BorderResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Updates the comment, returns updated comment data. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateCommentRequest" /></param>
        /// <returns><see cref="CommentResponse"/></returns>         
        public CommentResponse UpdateComment(UpdateCommentRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateComment");
            }

           // verify the required parameter 'commentIndex' is set
            if (request.CommentIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'commentIndex' when calling UpdateComment");
            }

           // verify the required parameter 'comment' is set
            if (request.Comment == null) 
            {
                throw new ApiException(400, "Missing required parameter 'comment' when calling UpdateComment");
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

        /// <summary>
        /// Updates drawing object, returns updated  drawing object&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateDrawingObjectRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse"/></returns>         
        public DrawingObjectResponse UpdateDrawingObject(UpdateDrawingObjectRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateDrawingObject");
            }

           // verify the required parameter 'drawingObject' is set
            if (request.DrawingObject == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingObject' when calling UpdateDrawingObject");
            }

           // verify the required parameter 'imageFile' is set
            if (request.ImageFile == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageFile' when calling UpdateDrawingObject");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateDrawingObject");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/drawingObjects/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
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
            
            if (request.DrawingObject != null) 
            {
                formParams.Add("DrawingObject", request.DrawingObject); // form parameter
            }
            
            if (request.ImageFile != null) 
            {
                formParams.Add("imageFile", this.apiInvoker.ToFileInfo(request.ImageFile, "ImageFile"));
            }
            
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

        /// <summary>
        /// Updates drawing object, returns updated  drawing object&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateDrawingObjectWithoutNodePathRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse"/></returns>         
        public DrawingObjectResponse UpdateDrawingObjectWithoutNodePath(UpdateDrawingObjectWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateDrawingObjectWithoutNodePath");
            }

           // verify the required parameter 'drawingObject' is set
            if (request.DrawingObject == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingObject' when calling UpdateDrawingObjectWithoutNodePath");
            }

           // verify the required parameter 'imageFile' is set
            if (request.ImageFile == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageFile' when calling UpdateDrawingObjectWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateDrawingObjectWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/drawingObjects/{index}";
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
            
            if (request.DrawingObject != null) 
            {
                formParams.Add("DrawingObject", request.DrawingObject); // form parameter
            }
            
            if (request.ImageFile != null) 
            {
                formParams.Add("imageFile", this.apiInvoker.ToFileInfo(request.ImageFile, "ImageFile"));
            }
            
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

        /// <summary>
        /// Updates field&#39;s properties, returns updated field&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFieldRequest" /></param>
        /// <returns><see cref="FieldResponse"/></returns>         
        public FieldResponse UpdateField(UpdateFieldRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateField");
            }

           // verify the required parameter 'field' is set
            if (request.Field == null) 
            {
                throw new ApiException(400, "Missing required parameter 'field' when calling UpdateField");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateField");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/fields/{index}";
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
            var postBody = SerializationHelper.Serialize(request.Field); // http body (model) parameter
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

        /// <summary>
        /// Updates (reevaluate) fields in document. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFieldsRequest" /></param>
        /// <returns><see cref="DocumentResponse"/></returns>         
        public DocumentResponse UpdateFields(UpdateFieldsRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateFields");
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

        /// <summary>
        /// Updates footnote&#39;s properties, returns updated run&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFootnoteRequest" /></param>
        /// <returns><see cref="FootnoteResponse"/></returns>         
        public FootnoteResponse UpdateFootnote(UpdateFootnoteRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateFootnote");
            }

           // verify the required parameter 'footnoteDto' is set
            if (request.FootnoteDto == null) 
            {
                throw new ApiException(400, "Missing required parameter 'footnoteDto' when calling UpdateFootnote");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateFootnote");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/footnotes/{index}";
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
            var postBody = SerializationHelper.Serialize(request.FootnoteDto); // http body (model) parameter
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

        /// <summary>
        /// Updates footnote&#39;s properties, returns updated run&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFootnoteWithoutNodePathRequest" /></param>
        /// <returns><see cref="FootnoteResponse"/></returns>         
        public FootnoteResponse UpdateFootnoteWithoutNodePath(UpdateFootnoteWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateFootnoteWithoutNodePath");
            }

           // verify the required parameter 'footnoteDto' is set
            if (request.FootnoteDto == null) 
            {
                throw new ApiException(400, "Missing required parameter 'footnoteDto' when calling UpdateFootnoteWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateFootnoteWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/footnotes/{index}";
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
            var postBody = SerializationHelper.Serialize(request.FootnoteDto); // http body (model) parameter
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

        /// <summary>
        /// Updates properties of form field, returns updated form field. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFormFieldRequest" /></param>
        /// <returns><see cref="FormFieldResponse"/></returns>         
        public FormFieldResponse UpdateFormField(UpdateFormFieldRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateFormField");
            }

           // verify the required parameter 'formField' is set
            if (request.FormField == null) 
            {
                throw new ApiException(400, "Missing required parameter 'formField' when calling UpdateFormField");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateFormField");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/formfields/{index}";
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
            var postBody = SerializationHelper.Serialize(request.FormField); // http body (model) parameter
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

        /// <summary>
        /// Updates properties of form field, returns updated form field. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFormFieldWithoutNodePathRequest" /></param>
        /// <returns><see cref="FormFieldResponse"/></returns>         
        public FormFieldResponse UpdateFormFieldWithoutNodePath(UpdateFormFieldWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateFormFieldWithoutNodePath");
            }

           // verify the required parameter 'formField' is set
            if (request.FormField == null) 
            {
                throw new ApiException(400, "Missing required parameter 'formField' when calling UpdateFormFieldWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateFormFieldWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/formfields/{index}";
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
            var postBody = SerializationHelper.Serialize(request.FormField); // http body (model) parameter
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

        /// <summary>
        /// Updates paragraph format properties, returns updated format properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateParagraphFormatRequest" /></param>
        /// <returns><see cref="ParagraphFormatResponse"/></returns>         
        public ParagraphFormatResponse UpdateParagraphFormat(UpdateParagraphFormatRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateParagraphFormat");
            }

           // verify the required parameter 'dto' is set
            if (request.Dto == null) 
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling UpdateParagraphFormat");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateParagraphFormat");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs/{index}/format";
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
            var postBody = SerializationHelper.Serialize(request.Dto); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                postBody, 
                null, 
                null);
            if (response != null)
            {
                return (ParagraphFormatResponse)SerializationHelper.Deserialize(response, typeof(ParagraphFormatResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Updates run&#39;s properties, returns updated run&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateRunRequest" /></param>
        /// <returns><see cref="RunResponse"/></returns>         
        public RunResponse UpdateRun(UpdateRunRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateRun");
            }

           // verify the required parameter 'run' is set
            if (request.Run == null) 
            {
                throw new ApiException(400, "Missing required parameter 'run' when calling UpdateRun");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateRun");
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

        /// <summary>
        /// Updates font properties, returns updated font data. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateRunFontRequest" /></param>
        /// <returns><see cref="FontResponse"/></returns>         
        public FontResponse UpdateRunFont(UpdateRunFontRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateRunFont");
            }

           // verify the required parameter 'fontDto' is set
            if (request.FontDto == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fontDto' when calling UpdateRunFont");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateRunFont");
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
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                postBody, 
                null, 
                null);
            if (response != null)
            {
                return (FontResponse)SerializationHelper.Deserialize(response, typeof(FontResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Updates page setup of section. 
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
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                postBody, 
                null, 
                null);
            if (response != null)
            {
                return (SectionPageSetupResponse)SerializationHelper.Deserialize(response, typeof(SectionPageSetupResponse));
            }
                    
            return null;
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
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                postBody, 
                null, 
                null);
            if (response != null)
            {
                return (TableCellFormatResponse)SerializationHelper.Deserialize(response, typeof(TableCellFormatResponse));
            }
                    
            return null;
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

           // verify the required parameter 'properties' is set
            if (request.Properties == null) 
            {
                throw new ApiException(400, "Missing required parameter 'properties' when calling UpdateTableProperties");
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
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "revisionDateTime", request.RevisionDateTime);
            var postBody = SerializationHelper.Serialize(request.Properties); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                postBody, 
                null, 
                null);
            if (response != null)
            {
                return (TablePropertiesResponse)SerializationHelper.Deserialize(response, typeof(TablePropertiesResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Updates a table properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTablePropertiesWithoutNodePathRequest" /></param>
        /// <returns><see cref="TablePropertiesResponse"/></returns>         
        public TablePropertiesResponse UpdateTablePropertiesWithoutNodePath(UpdateTablePropertiesWithoutNodePathRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateTablePropertiesWithoutNodePath");
            }

           // verify the required parameter 'properties' is set
            if (request.Properties == null) 
            {
                throw new ApiException(400, "Missing required parameter 'properties' when calling UpdateTablePropertiesWithoutNodePath");
            }

           // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateTablePropertiesWithoutNodePath");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/tables/{index}/properties";
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
            var postBody = SerializationHelper.Serialize(request.Properties); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                postBody, 
                null, 
                null);
            if (response != null)
            {
                return (TablePropertiesResponse)SerializationHelper.Deserialize(response, typeof(TablePropertiesResponse));
            }
                    
            return null;
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
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                postBody, 
                null, 
                null);
            if (response != null)
            {
                return (TableRowFormatResponse)SerializationHelper.Deserialize(response, typeof(TableRowFormatResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Upload file 
        /// </summary>
        /// <param name="request">Request. <see cref="UploadFileRequest" /></param>
        /// <returns><see cref="FilesUploadResult"/></returns>         
        public FilesUploadResult UploadFile(UploadFileRequest request)
        {
           // verify the required parameter 'fileContent' is set
            if (request.FileContent == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileContent' when calling UploadFile");
            }

           // verify the required parameter 'path' is set
            if (request.Path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling UploadFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/storage/file/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            
            if (request.FileContent != null) 
            {
                formParams.Add("fileContent", this.apiInvoker.ToFileInfo(request.FileContent, "FileContent"));
            }
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                formParams);
            if (response != null)
            {
                return (FilesUploadResult)SerializationHelper.Deserialize(response, typeof(FilesUploadResult));
            }
                    
            return null;
        }
    }
}
