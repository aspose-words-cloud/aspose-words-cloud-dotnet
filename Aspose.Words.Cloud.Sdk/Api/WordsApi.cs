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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/revisions/acceptAll";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/appendDocument";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
        /// Apply a style to the document node. 
        /// </summary>
        /// <param name="request">Request. <see cref="ApplyStyleToDocumentElementRequest" /></param>
        /// <returns><see cref="WordsResponse"/></returns>         
        public WordsResponse ApplyStyleToDocumentElement(ApplyStyleToDocumentElementRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{styledNodePath}/style";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (WordsResponse)SerializationHelper.Deserialize(response, typeof(WordsResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Executes document \&quot;build report\&quot; operation. 
        /// </summary>
        /// <param name="request">Request. <see cref="BuildReportRequest" /></param>
        /// <returns><see cref="DocumentResponse"/></returns>         
        public DocumentResponse BuildReport(BuildReportRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/buildReport";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
        /// Executes document \&quot;build report\&quot; online operation. 
        /// </summary>
        /// <param name="request">Request. <see cref="BuildReportOnlineRequest" /></param>
        /// <returns><see cref="byte[]"/></returns>         
        public byte[] BuildReportOnline(BuildReportOnlineRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/buildReport";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (byte[])SerializationHelper.Deserialize(response, typeof(byte[]));
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/classify";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Classifies document. 
        /// </summary>
        /// <param name="request">Request. <see cref="ClassifyDocumentRequest" /></param>
        /// <returns><see cref="ClassificationResponse"/></returns>         
        public ClassificationResponse ClassifyDocument(ClassifyDocumentRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{documentName}/classify";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/compareDocument";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
        /// Converts document from the request&#39;s content to the specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertDocumentRequest" /></param>
        /// <returns><see cref="byte[]"/></returns>         
        public byte[] ConvertDocument(ConvertDocumentRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/convert";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (byte[])SerializationHelper.Deserialize(response, typeof(byte[]));
            }
                    
            return null;
        }

        /// <summary>
        /// Copy file 
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFileRequest" /></param>         
        public void CopyFile(CopyFileRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/storage/file/copy/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/storage/folder/copy/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Copy and insert a new style to the document, returns a copied style. 
        /// </summary>
        /// <param name="request">Request. <see cref="CopyStyleRequest" /></param>
        /// <returns><see cref="StyleResponse"/></returns>         
        public StyleResponse CopyStyle(CopyStyleRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/styles/copy";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (StyleResponse)SerializationHelper.Deserialize(response, typeof(StyleResponse));
            }
                    
            return null;
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/storage/folder/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/documentProperties/{propertyName}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Remove all tab stops. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteAllParagraphTabStopsRequest" /></param>
        /// <returns><see cref="TabStopsResponse"/></returns>         
        public TabStopsResponse DeleteAllParagraphTabStops(DeleteAllParagraphTabStopsRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs/{index}/tabstops";
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
            if (response != null)
            {
                return (TabStopsResponse)SerializationHelper.Deserialize(response, typeof(TabStopsResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Remove all tab stops. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteAllParagraphTabStopsWithoutNodePathRequest" /></param>
        /// <returns><see cref="TabStopsResponse"/></returns>         
        public TabStopsResponse DeleteAllParagraphTabStopsWithoutNodePath(DeleteAllParagraphTabStopsWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/paragraphs/{index}/tabstops";
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
            if (response != null)
            {
                return (TabStopsResponse)SerializationHelper.Deserialize(response, typeof(TabStopsResponse));
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/borders/{borderType}";
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/borders";
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/comments/{commentIndex}";
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
        /// Deletes document property. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDocumentPropertyRequest" /></param>         
        public void DeleteDocumentProperty(DeleteDocumentPropertyRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/documentProperties/{propertyName}";
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
        /// Removes drawing object from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDrawingObjectRequest" /></param>         
        public void DeleteDrawingObject(DeleteDrawingObjectRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/drawingObjects/{index}";
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
        /// Removes drawing object from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDrawingObjectWithoutNodePathRequest" /></param>         
        public void DeleteDrawingObjectWithoutNodePath(DeleteDrawingObjectWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/drawingObjects/{index}";
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
        /// Deletes field from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFieldRequest" /></param>         
        public void DeleteField(DeleteFieldRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/fields/{index}";
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
        /// Deletes field from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFieldWithoutNodePathRequest" /></param>         
        public void DeleteFieldWithoutNodePath(DeleteFieldWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/fields/{index}";
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
        /// Removes fields from section paragraph. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFieldsRequest" /></param>         
        public void DeleteFields(DeleteFieldsRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/fields";
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
        /// Removes fields from section paragraph. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFieldsWithoutNodePathRequest" /></param>         
        public void DeleteFieldsWithoutNodePath(DeleteFieldsWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/fields";
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
        /// Delete file 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFileRequest" /></param>         
        public void DeleteFile(DeleteFileRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/storage/file/{path}";
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
        /// Delete folder 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFolderRequest" /></param>         
        public void DeleteFolder(DeleteFolderRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/storage/folder/{path}";
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
        /// Removes footnote from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFootnoteRequest" /></param>         
        public void DeleteFootnote(DeleteFootnoteRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/footnotes/{index}";
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
        /// Removes footnote from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFootnoteWithoutNodePathRequest" /></param>         
        public void DeleteFootnoteWithoutNodePath(DeleteFootnoteWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/footnotes/{index}";
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
        /// Removes form field from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFormFieldRequest" /></param>         
        public void DeleteFormField(DeleteFormFieldRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/formfields/{index}";
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
        /// Removes form field from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFormFieldWithoutNodePathRequest" /></param>         
        public void DeleteFormFieldWithoutNodePath(DeleteFormFieldWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/formfields/{index}";
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
        /// Deletes header/footer from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHeaderFooterRequest" /></param>         
        public void DeleteHeaderFooter(DeleteHeaderFooterRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{sectionPath}/headersfooters/{index}";
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
        /// Deletes document headers and footers. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHeadersFootersRequest" /></param>         
        public void DeleteHeadersFooters(DeleteHeadersFootersRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{sectionPath}/headersfooters";
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
        /// Removes macros from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteMacrosRequest" /></param>         
        public void DeleteMacros(DeleteMacrosRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/macros";
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
        /// Removes OfficeMath object from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteOfficeMathObjectRequest" /></param>         
        public void DeleteOfficeMathObject(DeleteOfficeMathObjectRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/OfficeMathObjects/{index}";
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
        /// Removes OfficeMath object from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteOfficeMathObjectWithoutNodePathRequest" /></param>         
        public void DeleteOfficeMathObjectWithoutNodePath(DeleteOfficeMathObjectWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/OfficeMathObjects/{index}";
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
        /// Removes paragraph from section. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphRequest" /></param>         
        public void DeleteParagraph(DeleteParagraphRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs/{index}";
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
        /// Delete paragraph list format, returns updated list format properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphListFormatRequest" /></param>
        /// <returns><see cref="ParagraphListFormatResponse"/></returns>         
        public ParagraphListFormatResponse DeleteParagraphListFormat(DeleteParagraphListFormatRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs/{index}/listFormat";
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
            if (response != null)
            {
                return (ParagraphListFormatResponse)SerializationHelper.Deserialize(response, typeof(ParagraphListFormatResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Delete paragraph list format, returns updated list format properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphListFormatWithoutNodePathRequest" /></param>
        /// <returns><see cref="ParagraphListFormatResponse"/></returns>         
        public ParagraphListFormatResponse DeleteParagraphListFormatWithoutNodePath(DeleteParagraphListFormatWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/paragraphs/{index}/listFormat";
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
            if (response != null)
            {
                return (ParagraphListFormatResponse)SerializationHelper.Deserialize(response, typeof(ParagraphListFormatResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Remove the i-th tab stop. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphTabStopRequest" /></param>
        /// <returns><see cref="TabStopsResponse"/></returns>         
        public TabStopsResponse DeleteParagraphTabStop(DeleteParagraphTabStopRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs/{index}/tabstop";
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
            if (response != null)
            {
                return (TabStopsResponse)SerializationHelper.Deserialize(response, typeof(TabStopsResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Remove the i-th tab stop. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphTabStopWithoutNodePathRequest" /></param>
        /// <returns><see cref="TabStopsResponse"/></returns>         
        public TabStopsResponse DeleteParagraphTabStopWithoutNodePath(DeleteParagraphTabStopWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/paragraphs/{index}/tabstop";
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
            if (response != null)
            {
                return (TabStopsResponse)SerializationHelper.Deserialize(response, typeof(TabStopsResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Removes paragraph from section. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphWithoutNodePathRequest" /></param>         
        public void DeleteParagraphWithoutNodePath(DeleteParagraphWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/paragraphs/{index}";
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
        /// Removes run from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteRunRequest" /></param>         
        public void DeleteRun(DeleteRunRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{paragraphPath}/runs/{index}";
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
        /// Removes section from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSectionRequest" /></param>         
        public void DeleteSection(DeleteSectionRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/sections/{sectionIndex}";
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
        /// Deletes a table. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableRequest" /></param>         
        public void DeleteTable(DeleteTableRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/tables/{index}";
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
        /// Deletes a table cell. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableCellRequest" /></param>         
        public void DeleteTableCell(DeleteTableCellRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{tableRowPath}/cells/{index}";
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
        /// Deletes a table row. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableRowRequest" /></param>         
        public void DeleteTableRow(DeleteTableRowRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{tablePath}/rows/{index}";
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
        /// Deletes a table. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableWithoutNodePathRequest" /></param>         
        public void DeleteTableWithoutNodePath(DeleteTableWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/tables/{index}";
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
        /// Deletes watermark (for deleting last watermark from the document). 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWatermarkRequest" /></param>
        /// <returns><see cref="DocumentResponse"/></returns>         
        public DocumentResponse DeleteWatermark(DeleteWatermarkRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/watermarks/deleteLast";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
        /// <returns><see cref="byte[]"/></returns>         
        public byte[] DownloadFile(DownloadFileRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/storage/file/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (byte[])SerializationHelper.Deserialize(response, typeof(byte[]));
            }
                    
            return null;
        }

        /// <summary>
        /// Executes document mail merge operation. 
        /// </summary>
        /// <param name="request">Request. <see cref="ExecuteMailMergeRequest" /></param>
        /// <returns><see cref="DocumentResponse"/></returns>         
        public DocumentResponse ExecuteMailMerge(ExecuteMailMergeRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/MailMerge";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
        /// Executes document mail merge online. 
        /// </summary>
        /// <param name="request">Request. <see cref="ExecuteMailMergeOnlineRequest" /></param>
        /// <returns><see cref="byte[]"/></returns>         
        public byte[] ExecuteMailMergeOnline(ExecuteMailMergeOnlineRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/MailMerge";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (byte[])SerializationHelper.Deserialize(response, typeof(byte[]));
            }
                    
            return null;
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/bookmarks/{bookmarkName}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/bookmarks";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/borders/{borderType}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/borders";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/comments/{commentIndex}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/comments";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{documentName}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/drawingObjects/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/drawingObjects/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
        /// <returns><see cref="byte[]"/></returns>         
        public byte[] GetDocumentDrawingObjectImageData(GetDocumentDrawingObjectImageDataRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/drawingObjects/{index}/imageData";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (byte[])SerializationHelper.Deserialize(response, typeof(byte[]));
            }
                    
            return null;
        }

        /// <summary>
        /// Reads drawing object image data. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectImageDataWithoutNodePathRequest" /></param>
        /// <returns><see cref="byte[]"/></returns>         
        public byte[] GetDocumentDrawingObjectImageDataWithoutNodePath(GetDocumentDrawingObjectImageDataWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/drawingObjects/{index}/imageData";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (byte[])SerializationHelper.Deserialize(response, typeof(byte[]));
            }
                    
            return null;
        }

        /// <summary>
        /// Gets drawing object OLE data. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectOleDataRequest" /></param>
        /// <returns><see cref="byte[]"/></returns>         
        public byte[] GetDocumentDrawingObjectOleData(GetDocumentDrawingObjectOleDataRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/drawingObjects/{index}/oleData";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (byte[])SerializationHelper.Deserialize(response, typeof(byte[]));
            }
                    
            return null;
        }

        /// <summary>
        /// Gets drawing object OLE data. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectOleDataWithoutNodePathRequest" /></param>
        /// <returns><see cref="byte[]"/></returns>         
        public byte[] GetDocumentDrawingObjectOleDataWithoutNodePath(GetDocumentDrawingObjectOleDataWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/drawingObjects/{index}/oleData";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (byte[])SerializationHelper.Deserialize(response, typeof(byte[]));
            }
                    
            return null;
        }

        /// <summary>
        /// Reads document drawing objects common info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectsRequest" /></param>
        /// <returns><see cref="DrawingObjectsResponse"/></returns>         
        public DrawingObjectsResponse GetDocumentDrawingObjects(GetDocumentDrawingObjectsRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/drawingObjects";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/drawingObjects";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/mailMerge/FieldNames";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/mailMerge/FieldNames";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Reads document hyperlink by its index. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentHyperlinkByIndexRequest" /></param>
        /// <returns><see cref="HyperlinkResponse"/></returns>         
        public HyperlinkResponse GetDocumentHyperlinkByIndex(GetDocumentHyperlinkByIndexRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/hyperlinks/{hyperlinkIndex}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/hyperlinks";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/documentProperties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/documentProperties/{propertyName}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/protection";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/statistics";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
        /// <returns><see cref="byte[]"/></returns>         
        public byte[] GetDocumentWithFormat(GetDocumentWithFormatRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (byte[])SerializationHelper.Deserialize(response, typeof(byte[]));
            }
                    
            return null;
        }

        /// <summary>
        /// Gets field from document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFieldRequest" /></param>
        /// <returns><see cref="FieldResponse"/></returns>         
        public FieldResponse GetField(GetFieldRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/fields/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/fields/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/fields";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/fields";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/storage/folder/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/footnotes/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/footnotes/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/footnotes";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/footnotes";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/formfields/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/formfields/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/formfields";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/formfields";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/headersfooters/{headerFooterIndex}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/sections/{sectionIndex}/headersfooters/{headerFooterIndex}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{sectionPath}/headersfooters";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
        /// This resource represents one of the lists contained in the document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetListRequest" /></param>
        /// <returns><see cref="ListResponse"/></returns>         
        public ListResponse GetList(GetListRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/lists/{listId}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (ListResponse)SerializationHelper.Deserialize(response, typeof(ListResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Returns a list of lists that are contained in the document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetListsRequest" /></param>
        /// <returns><see cref="ListsResponse"/></returns>         
        public ListsResponse GetLists(GetListsRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/lists";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (ListsResponse)SerializationHelper.Deserialize(response, typeof(ListsResponse));
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/OfficeMathObjects/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/OfficeMathObjects/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/OfficeMathObjects";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/OfficeMathObjects";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs/{index}/format";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/paragraphs/{index}/format";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
        /// Represents list format for a paragraph. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphListFormatRequest" /></param>
        /// <returns><see cref="ParagraphListFormatResponse"/></returns>         
        public ParagraphListFormatResponse GetParagraphListFormat(GetParagraphListFormatRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs/{index}/listFormat";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (ParagraphListFormatResponse)SerializationHelper.Deserialize(response, typeof(ParagraphListFormatResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Represents list format for a paragraph. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphListFormatWithoutNodePathRequest" /></param>
        /// <returns><see cref="ParagraphListFormatResponse"/></returns>         
        public ParagraphListFormatResponse GetParagraphListFormatWithoutNodePath(GetParagraphListFormatWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/paragraphs/{index}/listFormat";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (ParagraphListFormatResponse)SerializationHelper.Deserialize(response, typeof(ParagraphListFormatResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Get all tab stops for the paragraph. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphTabStopsRequest" /></param>
        /// <returns><see cref="TabStopsResponse"/></returns>         
        public TabStopsResponse GetParagraphTabStops(GetParagraphTabStopsRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs/{index}/tabstops";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (TabStopsResponse)SerializationHelper.Deserialize(response, typeof(TabStopsResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Get all tab stops for the paragraph. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphTabStopsWithoutNodePathRequest" /></param>
        /// <returns><see cref="TabStopsResponse"/></returns>         
        public TabStopsResponse GetParagraphTabStopsWithoutNodePath(GetParagraphTabStopsWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/paragraphs/{index}/tabstops";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (TabStopsResponse)SerializationHelper.Deserialize(response, typeof(TabStopsResponse));
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/paragraphs/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/paragraphs";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/range/{rangeStartIdentifier}/{rangeEndIdentifier}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{paragraphPath}/runs/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{paragraphPath}/runs/{index}/font";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{paragraphPath}/runs";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/sections/{sectionIndex}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/sections/{sectionIndex}/pageSetup";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/sections";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
        /// This resource represents one of the styles contained in the document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetStyleRequest" /></param>
        /// <returns><see cref="StyleResponse"/></returns>         
        public StyleResponse GetStyle(GetStyleRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/styles/{styleName}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (StyleResponse)SerializationHelper.Deserialize(response, typeof(StyleResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Gets a style from the document node. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetStyleFromDocumentElementRequest" /></param>
        /// <returns><see cref="StyleResponse"/></returns>         
        public StyleResponse GetStyleFromDocumentElement(GetStyleFromDocumentElementRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{styledNodePath}/style";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (StyleResponse)SerializationHelper.Deserialize(response, typeof(StyleResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Returns a list of styles contained in the document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetStylesRequest" /></param>
        /// <returns><see cref="StylesResponse"/></returns>         
        public StylesResponse GetStyles(GetStylesRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/styles";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (StylesResponse)SerializationHelper.Deserialize(response, typeof(StylesResponse));
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/tables/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{tableRowPath}/cells/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{tableRowPath}/cells/{index}/cellformat";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/tables/{index}/properties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/tables/{index}/properties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{tablePath}/rows/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{tablePath}/rows/{index}/rowformat";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/tables/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/tables";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/tables";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/comments";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
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
        /// Adds drawing object to document, returns added  drawing object&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertDrawingObjectRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse"/></returns>         
        public DrawingObjectResponse InsertDrawingObject(InsertDrawingObjectRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/drawingObjects";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
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
        /// Adds drawing object to document, returns added  drawing object&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertDrawingObjectWithoutNodePathRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse"/></returns>         
        public DrawingObjectResponse InsertDrawingObjectWithoutNodePath(InsertDrawingObjectWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/drawingObjects";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
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
        /// Adds field to document, returns inserted field&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFieldRequest" /></param>
        /// <returns><see cref="FieldResponse"/></returns>         
        public FieldResponse InsertField(InsertFieldRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/fields";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
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
        /// Adds field to document, returns inserted field&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFieldWithoutNodePathRequest" /></param>
        /// <returns><see cref="FieldResponse"/></returns>         
        public FieldResponse InsertFieldWithoutNodePath(InsertFieldWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/fields";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
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
        /// Adds footnote to document, returns added footnote&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFootnoteRequest" /></param>
        /// <returns><see cref="FootnoteResponse"/></returns>         
        public FootnoteResponse InsertFootnote(InsertFootnoteRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/footnotes";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
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
        /// Adds footnote to document, returns added footnote&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFootnoteWithoutNodePathRequest" /></param>
        /// <returns><see cref="FootnoteResponse"/></returns>         
        public FootnoteResponse InsertFootnoteWithoutNodePath(InsertFootnoteWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/footnotes";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
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
        /// Adds form field to paragraph, returns added form field&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFormFieldRequest" /></param>
        /// <returns><see cref="FormFieldResponse"/></returns>         
        public FormFieldResponse InsertFormField(InsertFormFieldRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/formfields";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
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
        /// Adds form field to paragraph, returns added form field&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFormFieldWithoutNodePathRequest" /></param>
        /// <returns><see cref="FormFieldResponse"/></returns>         
        public FormFieldResponse InsertFormFieldWithoutNodePath(InsertFormFieldWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/formfields";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
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
        /// Inserts to document header or footer. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertHeaderFooterRequest" /></param>
        /// <returns><see cref="HeaderFooterResponse"/></returns>         
        public HeaderFooterResponse InsertHeaderFooter(InsertHeaderFooterRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{sectionPath}/headersfooters";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Adds list to document, returns added list&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertListRequest" /></param>
        /// <returns><see cref="ListResponse"/></returns>         
        public ListResponse InsertList(InsertListRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/lists";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (ListResponse)SerializationHelper.Deserialize(response, typeof(ListResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Insert or resplace tab stop if a tab stop with the position exists. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertOrUpdateParagraphTabStopRequest" /></param>
        /// <returns><see cref="TabStopsResponse"/></returns>         
        public TabStopsResponse InsertOrUpdateParagraphTabStop(InsertOrUpdateParagraphTabStopRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs/{index}/tabstops";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (TabStopsResponse)SerializationHelper.Deserialize(response, typeof(TabStopsResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Insert or resplace tab stop if a tab stop with the position exists. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertOrUpdateParagraphTabStopWithoutNodePathRequest" /></param>
        /// <returns><see cref="TabStopsResponse"/></returns>         
        public TabStopsResponse InsertOrUpdateParagraphTabStopWithoutNodePath(InsertOrUpdateParagraphTabStopWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/paragraphs/{index}/tabstops";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (TabStopsResponse)SerializationHelper.Deserialize(response, typeof(TabStopsResponse));
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/PageNumbers";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
        /// Adds paragraph to document, returns added paragraph&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertParagraphRequest" /></param>
        /// <returns><see cref="ParagraphResponse"/></returns>         
        public ParagraphResponse InsertParagraph(InsertParagraphRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
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
        /// Adds paragraph to document, returns added paragraph&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertParagraphWithoutNodePathRequest" /></param>
        /// <returns><see cref="ParagraphResponse"/></returns>         
        public ParagraphResponse InsertParagraphWithoutNodePath(InsertParagraphWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/paragraphs";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
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
        /// Adds run to document, returns added paragraph&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertRunRequest" /></param>
        /// <returns><see cref="RunResponse"/></returns>         
        public RunResponse InsertRun(InsertRunRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{paragraphPath}/runs";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
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
        /// Adds a style to the document, returns an added style. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertStyleRequest" /></param>
        /// <returns><see cref="StyleResponse"/></returns>         
        public StyleResponse InsertStyle(InsertStyleRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/styles/insert";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (StyleResponse)SerializationHelper.Deserialize(response, typeof(StyleResponse));
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/tables";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
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
        /// Adds table cell to table, returns added cell&#39;s data.              
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableCellRequest" /></param>
        /// <returns><see cref="TableCellResponse"/></returns>         
        public TableCellResponse InsertTableCell(InsertTableCellRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{tableRowPath}/cells";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
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
        /// Adds table row to table, returns added row&#39;s data.              
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableRowRequest" /></param>
        /// <returns><see cref="TableRowResponse"/></returns>         
        public TableRowResponse InsertTableRow(InsertTableRowRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{tablePath}/rows";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
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
        /// Adds table to document, returns added table&#39;s data.              
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableWithoutNodePathRequest" /></param>
        /// <returns><see cref="TableResponse"/></returns>         
        public TableResponse InsertTableWithoutNodePath(InsertTableWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/tables";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "POST", 
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
        /// Inserts document watermark image. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertWatermarkImageRequest" /></param>
        /// <returns><see cref="DocumentResponse"/></returns>         
        public DocumentResponse InsertWatermarkImage(InsertWatermarkImageRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/watermarks/images";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
        /// Inserts document watermark text. 
        /// </summary>
        /// <param name="request">Request. <see cref="InsertWatermarkTextRequest" /></param>
        /// <returns><see cref="DocumentResponse"/></returns>         
        public DocumentResponse InsertWatermarkText(InsertWatermarkTextRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/watermarks/texts";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
        /// Loads new document from web into the file with any supported format of data. 
        /// </summary>
        /// <param name="request">Request. <see cref="LoadWebDocumentRequest" /></param>
        /// <returns><see cref="SaveResponse"/></returns>         
        public SaveResponse LoadWebDocument(LoadWebDocumentRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/loadWebDocument";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/storage/file/move/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/storage/folder/move/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/protection";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Rejects all revisions in document. 
        /// </summary>
        /// <param name="request">Request. <see cref="RejectAllRevisionsRequest" /></param>
        /// <returns><see cref="RevisionsModificationResponse"/></returns>         
        public RevisionsModificationResponse RejectAllRevisions(RejectAllRevisionsRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/revisions/rejectAll";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/range/{rangeStartIdentifier}/{rangeEndIdentifier}";
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
        /// <returns><see cref="byte[]"/></returns>         
        public byte[] RenderDrawingObject(RenderDrawingObjectRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/drawingObjects/{index}/render";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (byte[])SerializationHelper.Deserialize(response, typeof(byte[]));
            }
                    
            return null;
        }

        /// <summary>
        /// Renders drawing object to specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="RenderDrawingObjectWithoutNodePathRequest" /></param>
        /// <returns><see cref="byte[]"/></returns>         
        public byte[] RenderDrawingObjectWithoutNodePath(RenderDrawingObjectWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/drawingObjects/{index}/render";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (byte[])SerializationHelper.Deserialize(response, typeof(byte[]));
            }
                    
            return null;
        }

        /// <summary>
        /// Renders math object to specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="RenderMathObjectRequest" /></param>
        /// <returns><see cref="byte[]"/></returns>         
        public byte[] RenderMathObject(RenderMathObjectRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/OfficeMathObjects/{index}/render";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (byte[])SerializationHelper.Deserialize(response, typeof(byte[]));
            }
                    
            return null;
        }

        /// <summary>
        /// Renders math object to specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="RenderMathObjectWithoutNodePathRequest" /></param>
        /// <returns><see cref="byte[]"/></returns>         
        public byte[] RenderMathObjectWithoutNodePath(RenderMathObjectWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/OfficeMathObjects/{index}/render";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (byte[])SerializationHelper.Deserialize(response, typeof(byte[]));
            }
                    
            return null;
        }

        /// <summary>
        /// Renders page to specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="RenderPageRequest" /></param>
        /// <returns><see cref="byte[]"/></returns>         
        public byte[] RenderPage(RenderPageRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/pages/{pageIndex}/render";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (byte[])SerializationHelper.Deserialize(response, typeof(byte[]));
            }
                    
            return null;
        }

        /// <summary>
        /// Renders paragraph to specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="RenderParagraphRequest" /></param>
        /// <returns><see cref="byte[]"/></returns>         
        public byte[] RenderParagraph(RenderParagraphRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs/{index}/render";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (byte[])SerializationHelper.Deserialize(response, typeof(byte[]));
            }
                    
            return null;
        }

        /// <summary>
        /// Renders paragraph to specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="RenderParagraphWithoutNodePathRequest" /></param>
        /// <returns><see cref="byte[]"/></returns>         
        public byte[] RenderParagraphWithoutNodePath(RenderParagraphWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/paragraphs/{index}/render";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (byte[])SerializationHelper.Deserialize(response, typeof(byte[]));
            }
                    
            return null;
        }

        /// <summary>
        /// Renders table to specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="RenderTableRequest" /></param>
        /// <returns><see cref="byte[]"/></returns>         
        public byte[] RenderTable(RenderTableRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/tables/{index}/render";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (byte[])SerializationHelper.Deserialize(response, typeof(byte[]));
            }
                    
            return null;
        }

        /// <summary>
        /// Renders table to specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="RenderTableWithoutNodePathRequest" /></param>
        /// <returns><see cref="byte[]"/></returns>         
        public byte[] RenderTableWithoutNodePath(RenderTableWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/tables/{index}/render";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (byte[])SerializationHelper.Deserialize(response, typeof(byte[]));
            }
                    
            return null;
        }

        /// <summary>
        /// Replaces document text. 
        /// </summary>
        /// <param name="request">Request. <see cref="ReplaceTextRequest" /></param>
        /// <returns><see cref="ReplaceTextResponse"/></returns>         
        public ReplaceTextResponse ReplaceText(ReplaceTextRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/replaceText";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/range/{rangeStartIdentifier}/{rangeEndIdentifier}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/saveAs";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/range/{rangeStartIdentifier}/{rangeEndIdentifier}/SaveAs";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
        /// Converts document to tiff with detailed settings and saves result to storage. 
        /// </summary>
        /// <param name="request">Request. <see cref="SaveAsTiffRequest" /></param>
        /// <returns><see cref="SaveResponse"/></returns>         
        public SaveResponse SaveAsTiff(SaveAsTiffRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/saveAs/tiff";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/search";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/split";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/protection";
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/bookmarks/{bookmarkName}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Updates border properties.              &#39;nodePath&#39; should refer to paragraph, cell or row.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateBorderRequest" /></param>
        /// <returns><see cref="BorderResponse"/></returns>         
        public BorderResponse UpdateBorder(UpdateBorderRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/borders/{borderType}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Updates the comment, returns updated comment data. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateCommentRequest" /></param>
        /// <returns><see cref="CommentResponse"/></returns>         
        public CommentResponse UpdateComment(UpdateCommentRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/comments/{commentIndex}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Updates drawing object, returns updated  drawing object&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateDrawingObjectRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse"/></returns>         
        public DrawingObjectResponse UpdateDrawingObject(UpdateDrawingObjectRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/drawingObjects/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Updates drawing object, returns updated  drawing object&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateDrawingObjectWithoutNodePathRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse"/></returns>         
        public DrawingObjectResponse UpdateDrawingObjectWithoutNodePath(UpdateDrawingObjectWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/drawingObjects/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Updates field&#39;s properties, returns updated field&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFieldRequest" /></param>
        /// <returns><see cref="FieldResponse"/></returns>         
        public FieldResponse UpdateField(UpdateFieldRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/fields/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Updates (reevaluate) fields in document. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFieldsRequest" /></param>
        /// <returns><see cref="DocumentResponse"/></returns>         
        public DocumentResponse UpdateFields(UpdateFieldsRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/updateFields";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/footnotes/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Updates footnote&#39;s properties, returns updated run&#39;s data. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFootnoteWithoutNodePathRequest" /></param>
        /// <returns><see cref="FootnoteResponse"/></returns>         
        public FootnoteResponse UpdateFootnoteWithoutNodePath(UpdateFootnoteWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/footnotes/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Updates properties of form field, returns updated form field. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFormFieldRequest" /></param>
        /// <returns><see cref="FormFieldResponse"/></returns>         
        public FormFieldResponse UpdateFormField(UpdateFormFieldRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/formfields/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Updates properties of form field, returns updated form field. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFormFieldWithoutNodePathRequest" /></param>
        /// <returns><see cref="FormFieldResponse"/></returns>         
        public FormFieldResponse UpdateFormFieldWithoutNodePath(UpdateFormFieldWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/formfields/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Updates list properties, returns updated list. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateListRequest" /></param>
        /// <returns><see cref="ListResponse"/></returns>         
        public ListResponse UpdateList(UpdateListRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/lists/{listId}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (ListResponse)SerializationHelper.Deserialize(response, typeof(ListResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Updates list level in document list, returns updated list. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateListLevelRequest" /></param>
        /// <returns><see cref="ListResponse"/></returns>         
        public ListResponse UpdateListLevel(UpdateListLevelRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/lists/{listId}/listLevels/{listLevel}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (ListResponse)SerializationHelper.Deserialize(response, typeof(ListResponse));
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs/{index}/format";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Updates paragraph format properties, returns updated format properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateParagraphFormatWithoutNodePathRequest" /></param>
        /// <returns><see cref="ParagraphFormatResponse"/></returns>         
        public ParagraphFormatResponse UpdateParagraphFormatWithoutNodePath(UpdateParagraphFormatWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/paragraphs/{index}/format";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Updates paragraph list format properties, returns updated list format properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateParagraphListFormatRequest" /></param>
        /// <returns><see cref="ParagraphListFormatResponse"/></returns>         
        public ParagraphListFormatResponse UpdateParagraphListFormat(UpdateParagraphListFormatRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs/{index}/listFormat";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (ParagraphListFormatResponse)SerializationHelper.Deserialize(response, typeof(ParagraphListFormatResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Updates paragraph list format properties, returns updated list format properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateParagraphListFormatWithoutNodePathRequest" /></param>
        /// <returns><see cref="ParagraphListFormatResponse"/></returns>         
        public ParagraphListFormatResponse UpdateParagraphListFormatWithoutNodePath(UpdateParagraphListFormatWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/paragraphs/{index}/listFormat";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (ParagraphListFormatResponse)SerializationHelper.Deserialize(response, typeof(ParagraphListFormatResponse));
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{paragraphPath}/runs/{index}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Updates font properties, returns updated font data. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateRunFontRequest" /></param>
        /// <returns><see cref="FontResponse"/></returns>         
        public FontResponse UpdateRunFont(UpdateRunFontRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{paragraphPath}/runs/{index}/font";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Updates page setup of section. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateSectionPageSetupRequest" /></param>
        /// <returns><see cref="SectionPageSetupResponse"/></returns>         
        public SectionPageSetupResponse UpdateSectionPageSetup(UpdateSectionPageSetupRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/sections/{sectionIndex}/pageSetup";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Updates style properties, returns an updated style. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateStyleRequest" /></param>
        /// <returns><see cref="StyleResponse"/></returns>         
        public StyleResponse UpdateStyle(UpdateStyleRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/styles/{styleName}/update";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (StyleResponse)SerializationHelper.Deserialize(response, typeof(StyleResponse));
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
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{tableRowPath}/cells/{index}/cellformat";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Updates a table properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTablePropertiesRequest" /></param>
        /// <returns><see cref="TablePropertiesResponse"/></returns>         
        public TablePropertiesResponse UpdateTableProperties(UpdateTablePropertiesRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/tables/{index}/properties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Updates a table properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTablePropertiesWithoutNodePathRequest" /></param>
        /// <returns><see cref="TablePropertiesResponse"/></returns>         
        public TablePropertiesResponse UpdateTablePropertiesWithoutNodePath(UpdateTablePropertiesWithoutNodePathRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/tables/{index}/properties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Updates a table row format. 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTableRowFormatRequest" /></param>
        /// <returns><see cref="TableRowFormatResponse"/></returns>         
        public TableRowFormatResponse UpdateTableRowFormat(UpdateTableRowFormatRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/{name}/{tablePath}/rows/{index}/rowformat";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
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
        /// Upload file 
        /// </summary>
        /// <param name="request">Request. <see cref="UploadFileRequest" /></param>
        /// <returns><see cref="FilesUploadResult"/></returns>         
        public FilesUploadResult UploadFile(UploadFileRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/words/storage/file/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (FilesUploadResult)SerializationHelper.Deserialize(response, typeof(FilesUploadResult));
            }
                    
            return null;
        }
    }
}
