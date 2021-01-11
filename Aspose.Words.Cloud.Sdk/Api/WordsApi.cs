// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WordsApi.cs">
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

namespace Aspose.Words.Cloud.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Text.RegularExpressions;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Model.Responses;
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
        /// <param name="clientId">
        /// The client id.
        /// </param>
        /// <param name="clientSecret">
        /// The client secret.
        /// </param>
        public WordsApi(string clientId, string clientSecret)
            : this(new Configuration { ClientId = clientId, ClientSecret = clientSecret })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordsApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public WordsApi(Configuration configuration)
        {

            if (string.IsNullOrEmpty(configuration.ClientId?.Trim()))
            {
                throw new ArgumentException("ClientId configuration value must be non-empty string");
            }

            if (string.IsNullOrEmpty(configuration.ClientSecret?.Trim()))
            {
                throw new ArgumentException("ClientSecret configuration value must be non-empty string");
            }

            this.configuration = configuration;

            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new OAuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers);
        }

        /// <summary>
        /// Accepts all revisions in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="AcceptAllRevisionsRequest" /></param>
        /// <returns><see cref="RevisionsModificationResponse" /></returns>
        public RevisionsModificationResponse AcceptAllRevisions(AcceptAllRevisionsRequest request)
        {
            return (RevisionsModificationResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Accepts all revisions in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="AcceptAllRevisionsOnlineRequest" /></param>
        /// <returns><see cref="AcceptAllRevisionsOnlineResponse" /></returns>
        public AcceptAllRevisionsOnlineResponse AcceptAllRevisionsOnline(AcceptAllRevisionsOnlineRequest request)
        {
            return (AcceptAllRevisionsOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Appends documents to the original document.
        /// </summary>
        /// <param name="request">Request. <see cref="AppendDocumentRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse AppendDocument(AppendDocumentRequest request)
        {
            return (DocumentResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Appends documents to the original document.
        /// </summary>
        /// <param name="request">Request. <see cref="AppendDocumentOnlineRequest" /></param>
        /// <returns><see cref="AppendDocumentOnlineResponse" /></returns>
        public AppendDocumentOnlineResponse AppendDocumentOnline(AppendDocumentOnlineRequest request)
        {
            return (AppendDocumentOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Applies a style to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="ApplyStyleToDocumentElementRequest" /></param>
        /// <returns><see cref="WordsResponse" /></returns>
        public WordsResponse ApplyStyleToDocumentElement(ApplyStyleToDocumentElementRequest request)
        {
            return (WordsResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Applies a style to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="ApplyStyleToDocumentElementOnlineRequest" /></param>
        /// <returns><see cref="ApplyStyleToDocumentElementOnlineResponse" /></returns>
        public ApplyStyleToDocumentElementOnlineResponse ApplyStyleToDocumentElementOnline(ApplyStyleToDocumentElementOnlineRequest request)
        {
            return (ApplyStyleToDocumentElementOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Executes the report generation process using the specified document template and the external data source in XML, JSON or CSV format.
        /// </summary>
        /// <param name="request">Request. <see cref="BuildReportRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse BuildReport(BuildReportRequest request)
        {
            return (DocumentResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Executes the report generation process online using the specified document template and the external data source in XML, JSON or CSV format.
        /// </summary>
        /// <param name="request">Request. <see cref="BuildReportOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream BuildReportOnline(BuildReportOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Runs a multi-class text classification for the specified raw text.
        /// </summary>
        /// <param name="request">Request. <see cref="ClassifyRequest" /></param>
        /// <returns><see cref="ClassificationResponse" /></returns>
        public ClassificationResponse Classify(ClassifyRequest request)
        {
            return (ClassificationResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Runs a multi-class text classification for the document.
        /// </summary>
        /// <param name="request">Request. <see cref="ClassifyDocumentRequest" /></param>
        /// <returns><see cref="ClassificationResponse" /></returns>
        public ClassificationResponse ClassifyDocument(ClassifyDocumentRequest request)
        {
            return (ClassificationResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Runs a multi-class text classification for the document.
        /// </summary>
        /// <param name="request">Request. <see cref="ClassifyDocumentOnlineRequest" /></param>
        /// <returns><see cref="ClassificationResponse" /></returns>
        public ClassificationResponse ClassifyDocumentOnline(ClassifyDocumentOnlineRequest request)
        {
            return (ClassificationResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Compares two documents.
        /// </summary>
        /// <param name="request">Request. <see cref="CompareDocumentRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse CompareDocument(CompareDocumentRequest request)
        {
            return (DocumentResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Compares two documents.
        /// </summary>
        /// <param name="request">Request. <see cref="CompareDocumentOnlineRequest" /></param>
        /// <returns><see cref="CompareDocumentOnlineResponse" /></returns>
        public CompareDocumentOnlineResponse CompareDocumentOnline(CompareDocumentOnlineRequest request)
        {
            return (CompareDocumentOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Converts a document on a local drive to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertDocumentRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream ConvertDocument(ConvertDocumentRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Copy file.
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFileRequest" /></param>
        public void CopyFile(CopyFileRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Copy folder.
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFolderRequest" /></param>
        public void CopyFolder(CopyFolderRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Makes a copy of the style in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="CopyStyleRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public StyleResponse CopyStyle(CopyStyleRequest request)
        {
            return (StyleResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Makes a copy of the style in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="CopyStyleOnlineRequest" /></param>
        /// <returns><see cref="CopyStyleOnlineResponse" /></returns>
        public CopyStyleOnlineResponse CopyStyleOnline(CopyStyleOnlineRequest request)
        {
            return (CopyStyleOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Supported extensions: ".doc", ".docx", ".docm", ".dot", ".dotm", ".dotx", ".flatopc", ".fopc", ".flatopc_macro", ".fopc_macro", ".flatopc_template", ".fopc_template", ".flatopc_template_macro", ".fopc_template_macro", ".wordml", ".wml", ".rtf".
        /// </summary>
        /// <param name="request">Request. <see cref="CreateDocumentRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse CreateDocument(CreateDocumentRequest request)
        {
            return (DocumentResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Create the folder.
        /// </summary>
        /// <param name="request">Request. <see cref="CreateFolderRequest" /></param>
        public void CreateFolder(CreateFolderRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Adds a new or updates an existing document property.
        /// </summary>
        /// <param name="request">Request. <see cref="CreateOrUpdateDocumentPropertyRequest" /></param>
        /// <returns><see cref="DocumentPropertyResponse" /></returns>
        public DocumentPropertyResponse CreateOrUpdateDocumentProperty(CreateOrUpdateDocumentPropertyRequest request)
        {
            return (DocumentPropertyResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Adds a new or updates an existing document property.
        /// </summary>
        /// <param name="request">Request. <see cref="CreateOrUpdateDocumentPropertyOnlineRequest" /></param>
        /// <returns><see cref="CreateOrUpdateDocumentPropertyOnlineResponse" /></returns>
        public CreateOrUpdateDocumentPropertyOnlineResponse CreateOrUpdateDocumentPropertyOnline(CreateOrUpdateDocumentPropertyOnlineRequest request)
        {
            return (CreateOrUpdateDocumentPropertyOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes paragraph tab stops from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteAllParagraphTabStopsRequest" /></param>
        /// <returns><see cref="TabStopsResponse" /></returns>
        public TabStopsResponse DeleteAllParagraphTabStops(DeleteAllParagraphTabStopsRequest request)
        {
            return (TabStopsResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes paragraph tab stops from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteAllParagraphTabStopsOnlineRequest" /></param>
        /// <returns><see cref="DeleteAllParagraphTabStopsOnlineResponse" /></returns>
        public DeleteAllParagraphTabStopsOnlineResponse DeleteAllParagraphTabStopsOnline(DeleteAllParagraphTabStopsOnlineRequest request)
        {
            return (DeleteAllParagraphTabStopsOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// The 'nodePath' parameter should refer to a paragraph, a cell or a row.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteBorderRequest" /></param>
        /// <returns><see cref="BorderResponse" /></returns>
        public BorderResponse DeleteBorder(DeleteBorderRequest request)
        {
            return (BorderResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a border from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteBorderOnlineRequest" /></param>
        /// <returns><see cref="DeleteBorderOnlineResponse" /></returns>
        public DeleteBorderOnlineResponse DeleteBorderOnline(DeleteBorderOnlineRequest request)
        {
            return (DeleteBorderOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// The 'nodePath' parameter should refer to a paragraph, a cell or a row.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteBordersRequest" /></param>
        /// <returns><see cref="BordersResponse" /></returns>
        public BordersResponse DeleteBorders(DeleteBordersRequest request)
        {
            return (BordersResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes borders from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteBordersOnlineRequest" /></param>
        /// <returns><see cref="DeleteBordersOnlineResponse" /></returns>
        public DeleteBordersOnlineResponse DeleteBordersOnline(DeleteBordersOnlineRequest request)
        {
            return (DeleteBordersOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a comment from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteCommentRequest" /></param>
        public void DeleteComment(DeleteCommentRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a comment from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteCommentOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream DeleteCommentOnline(DeleteCommentOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a document property.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDocumentPropertyRequest" /></param>
        public void DeleteDocumentProperty(DeleteDocumentPropertyRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a document property.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDocumentPropertyOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream DeleteDocumentPropertyOnline(DeleteDocumentPropertyOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a DrawingObject from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDrawingObjectRequest" /></param>
        public void DeleteDrawingObject(DeleteDrawingObjectRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a DrawingObject from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDrawingObjectOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream DeleteDrawingObjectOnline(DeleteDrawingObjectOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a field from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFieldRequest" /></param>
        public void DeleteField(DeleteFieldRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a field from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFieldOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream DeleteFieldOnline(DeleteFieldOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes fields from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFieldsRequest" /></param>
        public void DeleteFields(DeleteFieldsRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes fields from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFieldsOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream DeleteFieldsOnline(DeleteFieldsOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Delete file.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFileRequest" /></param>
        public void DeleteFile(DeleteFileRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Delete folder.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFolderRequest" /></param>
        public void DeleteFolder(DeleteFolderRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a footnote from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFootnoteRequest" /></param>
        public void DeleteFootnote(DeleteFootnoteRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a footnote from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFootnoteOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream DeleteFootnoteOnline(DeleteFootnoteOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a form field from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFormFieldRequest" /></param>
        public void DeleteFormField(DeleteFormFieldRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a form field from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFormFieldOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream DeleteFormFieldOnline(DeleteFormFieldOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a HeaderFooter object from the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHeaderFooterRequest" /></param>
        public void DeleteHeaderFooter(DeleteHeaderFooterRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a HeaderFooter object from the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHeaderFooterOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream DeleteHeaderFooterOnline(DeleteHeaderFooterOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes HeaderFooter objects from the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHeadersFootersRequest" /></param>
        public void DeleteHeadersFooters(DeleteHeadersFootersRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes HeaderFooter objects from the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHeadersFootersOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream DeleteHeadersFootersOnline(DeleteHeadersFootersOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes macros from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteMacrosRequest" /></param>
        public void DeleteMacros(DeleteMacrosRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes macros from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteMacrosOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream DeleteMacrosOnline(DeleteMacrosOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes an OfficeMath object from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteOfficeMathObjectRequest" /></param>
        public void DeleteOfficeMathObject(DeleteOfficeMathObjectRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes an OfficeMath object from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteOfficeMathObjectOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream DeleteOfficeMathObjectOnline(DeleteOfficeMathObjectOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a paragraph from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphRequest" /></param>
        public void DeleteParagraph(DeleteParagraphRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes the formatting properties of a paragraph list from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphListFormatRequest" /></param>
        /// <returns><see cref="ParagraphListFormatResponse" /></returns>
        public ParagraphListFormatResponse DeleteParagraphListFormat(DeleteParagraphListFormatRequest request)
        {
            return (ParagraphListFormatResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes the formatting properties of a paragraph list from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphListFormatOnlineRequest" /></param>
        /// <returns><see cref="DeleteParagraphListFormatOnlineResponse" /></returns>
        public DeleteParagraphListFormatOnlineResponse DeleteParagraphListFormatOnline(DeleteParagraphListFormatOnlineRequest request)
        {
            return (DeleteParagraphListFormatOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a paragraph from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream DeleteParagraphOnline(DeleteParagraphOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a paragraph tab stop from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphTabStopRequest" /></param>
        /// <returns><see cref="TabStopsResponse" /></returns>
        public TabStopsResponse DeleteParagraphTabStop(DeleteParagraphTabStopRequest request)
        {
            return (TabStopsResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a paragraph tab stop from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphTabStopOnlineRequest" /></param>
        /// <returns><see cref="DeleteParagraphTabStopOnlineResponse" /></returns>
        public DeleteParagraphTabStopOnlineResponse DeleteParagraphTabStopOnline(DeleteParagraphTabStopOnlineRequest request)
        {
            return (DeleteParagraphTabStopOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a Run object from the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteRunRequest" /></param>
        public void DeleteRun(DeleteRunRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a Run object from the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteRunOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream DeleteRunOnline(DeleteRunOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a section from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSectionRequest" /></param>
        public void DeleteSection(DeleteSectionRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a section from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSectionOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream DeleteSectionOnline(DeleteSectionOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a table from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableRequest" /></param>
        public void DeleteTable(DeleteTableRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a cell from the table row.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableCellRequest" /></param>
        public void DeleteTableCell(DeleteTableCellRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a cell from the table row.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableCellOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream DeleteTableCellOnline(DeleteTableCellOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a table from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream DeleteTableOnline(DeleteTableOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a row from the table.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableRowRequest" /></param>
        public void DeleteTableRow(DeleteTableRowRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a row from the table.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableRowOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream DeleteTableRowOnline(DeleteTableRowOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a watermark from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWatermarkRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse DeleteWatermark(DeleteWatermarkRequest request)
        {
            return (DocumentResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a watermark from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWatermarkOnlineRequest" /></param>
        /// <returns><see cref="DeleteWatermarkOnlineResponse" /></returns>
        public DeleteWatermarkOnlineResponse DeleteWatermarkOnline(DeleteWatermarkOnlineRequest request)
        {
            return (DeleteWatermarkOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Download file.
        /// </summary>
        /// <param name="request">Request. <see cref="DownloadFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream DownloadFile(DownloadFileRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Executes a Mail Merge operation.
        /// </summary>
        /// <param name="request">Request. <see cref="ExecuteMailMergeRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse ExecuteMailMerge(ExecuteMailMergeRequest request)
        {
            return (DocumentResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Executes a Mail Merge operation online.
        /// </summary>
        /// <param name="request">Request. <see cref="ExecuteMailMergeOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream ExecuteMailMergeOnline(ExecuteMailMergeOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads available fonts from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetAvailableFontsRequest" /></param>
        /// <returns><see cref="AvailableFontsResponse" /></returns>
        public AvailableFontsResponse GetAvailableFonts(GetAvailableFontsRequest request)
        {
            return (AvailableFontsResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a bookmark, specified by name, from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBookmarkByNameRequest" /></param>
        /// <returns><see cref="BookmarkResponse" /></returns>
        public BookmarkResponse GetBookmarkByName(GetBookmarkByNameRequest request)
        {
            return (BookmarkResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a bookmark, specified by name, from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBookmarkByNameOnlineRequest" /></param>
        /// <returns><see cref="BookmarkResponse" /></returns>
        public BookmarkResponse GetBookmarkByNameOnline(GetBookmarkByNameOnlineRequest request)
        {
            return (BookmarkResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads bookmarks from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBookmarksRequest" /></param>
        /// <returns><see cref="BookmarksResponse" /></returns>
        public BookmarksResponse GetBookmarks(GetBookmarksRequest request)
        {
            return (BookmarksResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads bookmarks from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBookmarksOnlineRequest" /></param>
        /// <returns><see cref="BookmarksResponse" /></returns>
        public BookmarksResponse GetBookmarksOnline(GetBookmarksOnlineRequest request)
        {
            return (BookmarksResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// The 'nodePath' parameter should refer to a paragraph, a cell or a row.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBorderRequest" /></param>
        /// <returns><see cref="BorderResponse" /></returns>
        public BorderResponse GetBorder(GetBorderRequest request)
        {
            return (BorderResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a border from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBorderOnlineRequest" /></param>
        /// <returns><see cref="BorderResponse" /></returns>
        public BorderResponse GetBorderOnline(GetBorderOnlineRequest request)
        {
            return (BorderResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads borders from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBordersRequest" /></param>
        /// <returns><see cref="BordersResponse" /></returns>
        public BordersResponse GetBorders(GetBordersRequest request)
        {
            return (BordersResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads borders from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBordersOnlineRequest" /></param>
        /// <returns><see cref="BordersResponse" /></returns>
        public BordersResponse GetBordersOnline(GetBordersOnlineRequest request)
        {
            return (BordersResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a comment from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetCommentRequest" /></param>
        /// <returns><see cref="CommentResponse" /></returns>
        public CommentResponse GetComment(GetCommentRequest request)
        {
            return (CommentResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a comment from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetCommentOnlineRequest" /></param>
        /// <returns><see cref="CommentResponse" /></returns>
        public CommentResponse GetCommentOnline(GetCommentOnlineRequest request)
        {
            return (CommentResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads comments from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetCommentsRequest" /></param>
        /// <returns><see cref="CommentsResponse" /></returns>
        public CommentsResponse GetComments(GetCommentsRequest request)
        {
            return (CommentsResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads comments from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetCommentsOnlineRequest" /></param>
        /// <returns><see cref="CommentsResponse" /></returns>
        public CommentsResponse GetCommentsOnline(GetCommentsOnlineRequest request)
        {
            return (CommentsResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads common information from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse GetDocument(GetDocumentRequest request)
        {
            return (DocumentResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a DrawingObject from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectByIndexRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse" /></returns>
        public DrawingObjectResponse GetDocumentDrawingObjectByIndex(GetDocumentDrawingObjectByIndexRequest request)
        {
            return (DrawingObjectResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a DrawingObject from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectByIndexOnlineRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse" /></returns>
        public DrawingObjectResponse GetDocumentDrawingObjectByIndexOnline(GetDocumentDrawingObjectByIndexOnlineRequest request)
        {
            return (DrawingObjectResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads image data of a DrawingObject from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectImageDataRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream GetDocumentDrawingObjectImageData(GetDocumentDrawingObjectImageDataRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads image data of a DrawingObject from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectImageDataOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream GetDocumentDrawingObjectImageDataOnline(GetDocumentDrawingObjectImageDataOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads OLE data of a DrawingObject from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectOleDataRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream GetDocumentDrawingObjectOleData(GetDocumentDrawingObjectOleDataRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads OLE data of a DrawingObject from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectOleDataOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream GetDocumentDrawingObjectOleDataOnline(GetDocumentDrawingObjectOleDataOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads DrawingObjects from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectsRequest" /></param>
        /// <returns><see cref="DrawingObjectsResponse" /></returns>
        public DrawingObjectsResponse GetDocumentDrawingObjects(GetDocumentDrawingObjectsRequest request)
        {
            return (DrawingObjectsResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads DrawingObjects from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectsOnlineRequest" /></param>
        /// <returns><see cref="DrawingObjectsResponse" /></returns>
        public DrawingObjectsResponse GetDocumentDrawingObjectsOnline(GetDocumentDrawingObjectsOnlineRequest request)
        {
            return (DrawingObjectsResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads merge field names from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentFieldNamesRequest" /></param>
        /// <returns><see cref="FieldNamesResponse" /></returns>
        public FieldNamesResponse GetDocumentFieldNames(GetDocumentFieldNamesRequest request)
        {
            return (FieldNamesResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads merge field names from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentFieldNamesOnlineRequest" /></param>
        /// <returns><see cref="FieldNamesResponse" /></returns>
        public FieldNamesResponse GetDocumentFieldNamesOnline(GetDocumentFieldNamesOnlineRequest request)
        {
            return (FieldNamesResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a hyperlink from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentHyperlinkByIndexRequest" /></param>
        /// <returns><see cref="HyperlinkResponse" /></returns>
        public HyperlinkResponse GetDocumentHyperlinkByIndex(GetDocumentHyperlinkByIndexRequest request)
        {
            return (HyperlinkResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a hyperlink from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentHyperlinkByIndexOnlineRequest" /></param>
        /// <returns><see cref="HyperlinkResponse" /></returns>
        public HyperlinkResponse GetDocumentHyperlinkByIndexOnline(GetDocumentHyperlinkByIndexOnlineRequest request)
        {
            return (HyperlinkResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads hyperlinks from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentHyperlinksRequest" /></param>
        /// <returns><see cref="HyperlinksResponse" /></returns>
        public HyperlinksResponse GetDocumentHyperlinks(GetDocumentHyperlinksRequest request)
        {
            return (HyperlinksResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads hyperlinks from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentHyperlinksOnlineRequest" /></param>
        /// <returns><see cref="HyperlinksResponse" /></returns>
        public HyperlinksResponse GetDocumentHyperlinksOnline(GetDocumentHyperlinksOnlineRequest request)
        {
            return (HyperlinksResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads document properties.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentPropertiesRequest" /></param>
        /// <returns><see cref="DocumentPropertiesResponse" /></returns>
        public DocumentPropertiesResponse GetDocumentProperties(GetDocumentPropertiesRequest request)
        {
            return (DocumentPropertiesResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads document properties.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentPropertiesOnlineRequest" /></param>
        /// <returns><see cref="DocumentPropertiesResponse" /></returns>
        public DocumentPropertiesResponse GetDocumentPropertiesOnline(GetDocumentPropertiesOnlineRequest request)
        {
            return (DocumentPropertiesResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a document property.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentPropertyRequest" /></param>
        /// <returns><see cref="DocumentPropertyResponse" /></returns>
        public DocumentPropertyResponse GetDocumentProperty(GetDocumentPropertyRequest request)
        {
            return (DocumentPropertyResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a document property.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentPropertyOnlineRequest" /></param>
        /// <returns><see cref="DocumentPropertyResponse" /></returns>
        public DocumentPropertyResponse GetDocumentPropertyOnline(GetDocumentPropertyOnlineRequest request)
        {
            return (DocumentPropertyResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads protection properties from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentProtectionRequest" /></param>
        /// <returns><see cref="ProtectionDataResponse" /></returns>
        public ProtectionDataResponse GetDocumentProtection(GetDocumentProtectionRequest request)
        {
            return (ProtectionDataResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads protection properties from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentProtectionOnlineRequest" /></param>
        /// <returns><see cref="ProtectionDataResponse" /></returns>
        public ProtectionDataResponse GetDocumentProtectionOnline(GetDocumentProtectionOnlineRequest request)
        {
            return (ProtectionDataResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads document statistics.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentStatisticsRequest" /></param>
        /// <returns><see cref="StatDataResponse" /></returns>
        public StatDataResponse GetDocumentStatistics(GetDocumentStatisticsRequest request)
        {
            return (StatDataResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads document statistics.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentStatisticsOnlineRequest" /></param>
        /// <returns><see cref="StatDataResponse" /></returns>
        public StatDataResponse GetDocumentStatisticsOnline(GetDocumentStatisticsOnlineRequest request)
        {
            return (StatDataResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Converts a document in cloud storage to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentWithFormatRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream GetDocumentWithFormat(GetDocumentWithFormatRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a field from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFieldRequest" /></param>
        /// <returns><see cref="FieldResponse" /></returns>
        public FieldResponse GetField(GetFieldRequest request)
        {
            return (FieldResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a field from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFieldOnlineRequest" /></param>
        /// <returns><see cref="FieldResponse" /></returns>
        public FieldResponse GetFieldOnline(GetFieldOnlineRequest request)
        {
            return (FieldResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads fields from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFieldsRequest" /></param>
        /// <returns><see cref="FieldsResponse" /></returns>
        public FieldsResponse GetFields(GetFieldsRequest request)
        {
            return (FieldsResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads fields from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFieldsOnlineRequest" /></param>
        /// <returns><see cref="FieldsResponse" /></returns>
        public FieldsResponse GetFieldsOnline(GetFieldsOnlineRequest request)
        {
            return (FieldsResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Get all files and folders within a folder.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFilesListRequest" /></param>
        /// <returns><see cref="FilesList" /></returns>
        public FilesList GetFilesList(GetFilesListRequest request)
        {
            return (FilesList)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a footnote from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFootnoteRequest" /></param>
        /// <returns><see cref="FootnoteResponse" /></returns>
        public FootnoteResponse GetFootnote(GetFootnoteRequest request)
        {
            return (FootnoteResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a footnote from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFootnoteOnlineRequest" /></param>
        /// <returns><see cref="FootnoteResponse" /></returns>
        public FootnoteResponse GetFootnoteOnline(GetFootnoteOnlineRequest request)
        {
            return (FootnoteResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads footnotes from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFootnotesRequest" /></param>
        /// <returns><see cref="FootnotesResponse" /></returns>
        public FootnotesResponse GetFootnotes(GetFootnotesRequest request)
        {
            return (FootnotesResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads footnotes from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFootnotesOnlineRequest" /></param>
        /// <returns><see cref="FootnotesResponse" /></returns>
        public FootnotesResponse GetFootnotesOnline(GetFootnotesOnlineRequest request)
        {
            return (FootnotesResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a form field from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFormFieldRequest" /></param>
        /// <returns><see cref="FormFieldResponse" /></returns>
        public FormFieldResponse GetFormField(GetFormFieldRequest request)
        {
            return (FormFieldResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a form field from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFormFieldOnlineRequest" /></param>
        /// <returns><see cref="FormFieldResponse" /></returns>
        public FormFieldResponse GetFormFieldOnline(GetFormFieldOnlineRequest request)
        {
            return (FormFieldResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads form fields from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFormFieldsRequest" /></param>
        /// <returns><see cref="FormFieldsResponse" /></returns>
        public FormFieldsResponse GetFormFields(GetFormFieldsRequest request)
        {
            return (FormFieldsResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads form fields from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFormFieldsOnlineRequest" /></param>
        /// <returns><see cref="FormFieldsResponse" /></returns>
        public FormFieldsResponse GetFormFieldsOnline(GetFormFieldsOnlineRequest request)
        {
            return (FormFieldsResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a HeaderFooter object from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderFooterRequest" /></param>
        /// <returns><see cref="HeaderFooterResponse" /></returns>
        public HeaderFooterResponse GetHeaderFooter(GetHeaderFooterRequest request)
        {
            return (HeaderFooterResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a HeaderFooter object from the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderFooterOfSectionRequest" /></param>
        /// <returns><see cref="HeaderFooterResponse" /></returns>
        public HeaderFooterResponse GetHeaderFooterOfSection(GetHeaderFooterOfSectionRequest request)
        {
            return (HeaderFooterResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a HeaderFooter object from the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderFooterOfSectionOnlineRequest" /></param>
        /// <returns><see cref="HeaderFooterResponse" /></returns>
        public HeaderFooterResponse GetHeaderFooterOfSectionOnline(GetHeaderFooterOfSectionOnlineRequest request)
        {
            return (HeaderFooterResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a HeaderFooter object from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderFooterOnlineRequest" /></param>
        /// <returns><see cref="HeaderFooterResponse" /></returns>
        public HeaderFooterResponse GetHeaderFooterOnline(GetHeaderFooterOnlineRequest request)
        {
            return (HeaderFooterResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads HeaderFooter objects from the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderFootersRequest" /></param>
        /// <returns><see cref="HeaderFootersResponse" /></returns>
        public HeaderFootersResponse GetHeaderFooters(GetHeaderFootersRequest request)
        {
            return (HeaderFootersResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads HeaderFooter objects from the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderFootersOnlineRequest" /></param>
        /// <returns><see cref="HeaderFootersResponse" /></returns>
        public HeaderFootersResponse GetHeaderFootersOnline(GetHeaderFootersOnlineRequest request)
        {
            return (HeaderFootersResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a list from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetListRequest" /></param>
        /// <returns><see cref="ListResponse" /></returns>
        public ListResponse GetList(GetListRequest request)
        {
            return (ListResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a list from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetListOnlineRequest" /></param>
        /// <returns><see cref="ListResponse" /></returns>
        public ListResponse GetListOnline(GetListOnlineRequest request)
        {
            return (ListResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads lists from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetListsRequest" /></param>
        /// <returns><see cref="ListsResponse" /></returns>
        public ListsResponse GetLists(GetListsRequest request)
        {
            return (ListsResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads lists from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetListsOnlineRequest" /></param>
        /// <returns><see cref="ListsResponse" /></returns>
        public ListsResponse GetListsOnline(GetListsOnlineRequest request)
        {
            return (ListsResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads an OfficeMath object from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetOfficeMathObjectRequest" /></param>
        /// <returns><see cref="OfficeMathObjectResponse" /></returns>
        public OfficeMathObjectResponse GetOfficeMathObject(GetOfficeMathObjectRequest request)
        {
            return (OfficeMathObjectResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads an OfficeMath object from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetOfficeMathObjectOnlineRequest" /></param>
        /// <returns><see cref="OfficeMathObjectResponse" /></returns>
        public OfficeMathObjectResponse GetOfficeMathObjectOnline(GetOfficeMathObjectOnlineRequest request)
        {
            return (OfficeMathObjectResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads OfficeMath objects from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetOfficeMathObjectsRequest" /></param>
        /// <returns><see cref="OfficeMathObjectsResponse" /></returns>
        public OfficeMathObjectsResponse GetOfficeMathObjects(GetOfficeMathObjectsRequest request)
        {
            return (OfficeMathObjectsResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads OfficeMath objects from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetOfficeMathObjectsOnlineRequest" /></param>
        /// <returns><see cref="OfficeMathObjectsResponse" /></returns>
        public OfficeMathObjectsResponse GetOfficeMathObjectsOnline(GetOfficeMathObjectsOnlineRequest request)
        {
            return (OfficeMathObjectsResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a paragraph from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphRequest" /></param>
        /// <returns><see cref="ParagraphResponse" /></returns>
        public ParagraphResponse GetParagraph(GetParagraphRequest request)
        {
            return (ParagraphResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads the formatting properties of a paragraph from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphFormatRequest" /></param>
        /// <returns><see cref="ParagraphFormatResponse" /></returns>
        public ParagraphFormatResponse GetParagraphFormat(GetParagraphFormatRequest request)
        {
            return (ParagraphFormatResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads the formatting properties of a paragraph from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphFormatOnlineRequest" /></param>
        /// <returns><see cref="ParagraphFormatResponse" /></returns>
        public ParagraphFormatResponse GetParagraphFormatOnline(GetParagraphFormatOnlineRequest request)
        {
            return (ParagraphFormatResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads the formatting properties of a paragraph list from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphListFormatRequest" /></param>
        /// <returns><see cref="ParagraphListFormatResponse" /></returns>
        public ParagraphListFormatResponse GetParagraphListFormat(GetParagraphListFormatRequest request)
        {
            return (ParagraphListFormatResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads the formatting properties of a paragraph list from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphListFormatOnlineRequest" /></param>
        /// <returns><see cref="ParagraphListFormatResponse" /></returns>
        public ParagraphListFormatResponse GetParagraphListFormatOnline(GetParagraphListFormatOnlineRequest request)
        {
            return (ParagraphListFormatResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a paragraph from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphOnlineRequest" /></param>
        /// <returns><see cref="ParagraphResponse" /></returns>
        public ParagraphResponse GetParagraphOnline(GetParagraphOnlineRequest request)
        {
            return (ParagraphResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads paragraphs from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphsRequest" /></param>
        /// <returns><see cref="ParagraphLinkCollectionResponse" /></returns>
        public ParagraphLinkCollectionResponse GetParagraphs(GetParagraphsRequest request)
        {
            return (ParagraphLinkCollectionResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads paragraphs from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphsOnlineRequest" /></param>
        /// <returns><see cref="ParagraphLinkCollectionResponse" /></returns>
        public ParagraphLinkCollectionResponse GetParagraphsOnline(GetParagraphsOnlineRequest request)
        {
            return (ParagraphLinkCollectionResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads paragraph tab stops from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphTabStopsRequest" /></param>
        /// <returns><see cref="TabStopsResponse" /></returns>
        public TabStopsResponse GetParagraphTabStops(GetParagraphTabStopsRequest request)
        {
            return (TabStopsResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads paragraph tab stops from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphTabStopsOnlineRequest" /></param>
        /// <returns><see cref="TabStopsResponse" /></returns>
        public TabStopsResponse GetParagraphTabStopsOnline(GetParagraphTabStopsOnlineRequest request)
        {
            return (TabStopsResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads range text from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRangeTextRequest" /></param>
        /// <returns><see cref="RangeTextResponse" /></returns>
        public RangeTextResponse GetRangeText(GetRangeTextRequest request)
        {
            return (RangeTextResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads range text from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRangeTextOnlineRequest" /></param>
        /// <returns><see cref="RangeTextResponse" /></returns>
        public RangeTextResponse GetRangeTextOnline(GetRangeTextOnlineRequest request)
        {
            return (RangeTextResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a Run object from the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRunRequest" /></param>
        /// <returns><see cref="RunResponse" /></returns>
        public RunResponse GetRun(GetRunRequest request)
        {
            return (RunResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads the font properties of a Run object from the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRunFontRequest" /></param>
        /// <returns><see cref="FontResponse" /></returns>
        public FontResponse GetRunFont(GetRunFontRequest request)
        {
            return (FontResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads the font properties of a Run object from the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRunFontOnlineRequest" /></param>
        /// <returns><see cref="FontResponse" /></returns>
        public FontResponse GetRunFontOnline(GetRunFontOnlineRequest request)
        {
            return (FontResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a Run object from the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRunOnlineRequest" /></param>
        /// <returns><see cref="RunResponse" /></returns>
        public RunResponse GetRunOnline(GetRunOnlineRequest request)
        {
            return (RunResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads Run objects from the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRunsRequest" /></param>
        /// <returns><see cref="RunsResponse" /></returns>
        public RunsResponse GetRuns(GetRunsRequest request)
        {
            return (RunsResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads Run objects from the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRunsOnlineRequest" /></param>
        /// <returns><see cref="RunsResponse" /></returns>
        public RunsResponse GetRunsOnline(GetRunsOnlineRequest request)
        {
            return (RunsResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a section from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetSectionRequest" /></param>
        /// <returns><see cref="SectionResponse" /></returns>
        public SectionResponse GetSection(GetSectionRequest request)
        {
            return (SectionResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a section from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetSectionOnlineRequest" /></param>
        /// <returns><see cref="SectionResponse" /></returns>
        public SectionResponse GetSectionOnline(GetSectionOnlineRequest request)
        {
            return (SectionResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads the page setup of a section from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetSectionPageSetupRequest" /></param>
        /// <returns><see cref="SectionPageSetupResponse" /></returns>
        public SectionPageSetupResponse GetSectionPageSetup(GetSectionPageSetupRequest request)
        {
            return (SectionPageSetupResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads the page setup of a section from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetSectionPageSetupOnlineRequest" /></param>
        /// <returns><see cref="SectionPageSetupResponse" /></returns>
        public SectionPageSetupResponse GetSectionPageSetupOnline(GetSectionPageSetupOnlineRequest request)
        {
            return (SectionPageSetupResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads sections from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetSectionsRequest" /></param>
        /// <returns><see cref="SectionLinkCollectionResponse" /></returns>
        public SectionLinkCollectionResponse GetSections(GetSectionsRequest request)
        {
            return (SectionLinkCollectionResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads sections from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetSectionsOnlineRequest" /></param>
        /// <returns><see cref="SectionLinkCollectionResponse" /></returns>
        public SectionLinkCollectionResponse GetSectionsOnline(GetSectionsOnlineRequest request)
        {
            return (SectionLinkCollectionResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a style from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetStyleRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public StyleResponse GetStyle(GetStyleRequest request)
        {
            return (StyleResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a style from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetStyleFromDocumentElementRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public StyleResponse GetStyleFromDocumentElement(GetStyleFromDocumentElementRequest request)
        {
            return (StyleResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a style from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetStyleFromDocumentElementOnlineRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public StyleResponse GetStyleFromDocumentElementOnline(GetStyleFromDocumentElementOnlineRequest request)
        {
            return (StyleResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a style from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetStyleOnlineRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public StyleResponse GetStyleOnline(GetStyleOnlineRequest request)
        {
            return (StyleResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads styles from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetStylesRequest" /></param>
        /// <returns><see cref="StylesResponse" /></returns>
        public StylesResponse GetStyles(GetStylesRequest request)
        {
            return (StylesResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads styles from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetStylesOnlineRequest" /></param>
        /// <returns><see cref="StylesResponse" /></returns>
        public StylesResponse GetStylesOnline(GetStylesOnlineRequest request)
        {
            return (StylesResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a table from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableRequest" /></param>
        /// <returns><see cref="TableResponse" /></returns>
        public TableResponse GetTable(GetTableRequest request)
        {
            return (TableResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a cell from the table row.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableCellRequest" /></param>
        /// <returns><see cref="TableCellResponse" /></returns>
        public TableCellResponse GetTableCell(GetTableCellRequest request)
        {
            return (TableCellResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads the formatting properties of a table cell.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableCellFormatRequest" /></param>
        /// <returns><see cref="TableCellFormatResponse" /></returns>
        public TableCellFormatResponse GetTableCellFormat(GetTableCellFormatRequest request)
        {
            return (TableCellFormatResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads the formatting properties of a table cell.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableCellFormatOnlineRequest" /></param>
        /// <returns><see cref="TableCellFormatResponse" /></returns>
        public TableCellFormatResponse GetTableCellFormatOnline(GetTableCellFormatOnlineRequest request)
        {
            return (TableCellFormatResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a cell from the table row.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableCellOnlineRequest" /></param>
        /// <returns><see cref="TableCellResponse" /></returns>
        public TableCellResponse GetTableCellOnline(GetTableCellOnlineRequest request)
        {
            return (TableCellResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a table from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableOnlineRequest" /></param>
        /// <returns><see cref="TableResponse" /></returns>
        public TableResponse GetTableOnline(GetTableOnlineRequest request)
        {
            return (TableResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads properties of a table from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTablePropertiesRequest" /></param>
        /// <returns><see cref="TablePropertiesResponse" /></returns>
        public TablePropertiesResponse GetTableProperties(GetTablePropertiesRequest request)
        {
            return (TablePropertiesResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads properties of a table from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTablePropertiesOnlineRequest" /></param>
        /// <returns><see cref="TablePropertiesResponse" /></returns>
        public TablePropertiesResponse GetTablePropertiesOnline(GetTablePropertiesOnlineRequest request)
        {
            return (TablePropertiesResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a row from the table.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableRowRequest" /></param>
        /// <returns><see cref="TableRowResponse" /></returns>
        public TableRowResponse GetTableRow(GetTableRowRequest request)
        {
            return (TableRowResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads the formatting properties of a table row.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableRowFormatRequest" /></param>
        /// <returns><see cref="TableRowFormatResponse" /></returns>
        public TableRowFormatResponse GetTableRowFormat(GetTableRowFormatRequest request)
        {
            return (TableRowFormatResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads the formatting properties of a table row.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableRowFormatOnlineRequest" /></param>
        /// <returns><see cref="TableRowFormatResponse" /></returns>
        public TableRowFormatResponse GetTableRowFormatOnline(GetTableRowFormatOnlineRequest request)
        {
            return (TableRowFormatResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads a row from the table.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableRowOnlineRequest" /></param>
        /// <returns><see cref="TableRowResponse" /></returns>
        public TableRowResponse GetTableRowOnline(GetTableRowOnlineRequest request)
        {
            return (TableRowResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads tables from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTablesRequest" /></param>
        /// <returns><see cref="TableLinkCollectionResponse" /></returns>
        public TableLinkCollectionResponse GetTables(GetTablesRequest request)
        {
            return (TableLinkCollectionResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reads tables from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTablesOnlineRequest" /></param>
        /// <returns><see cref="TableLinkCollectionResponse" /></returns>
        public TableLinkCollectionResponse GetTablesOnline(GetTablesOnlineRequest request)
        {
            return (TableLinkCollectionResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new comment to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertCommentRequest" /></param>
        /// <returns><see cref="CommentResponse" /></returns>
        public CommentResponse InsertComment(InsertCommentRequest request)
        {
            return (CommentResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new comment to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertCommentOnlineRequest" /></param>
        /// <returns><see cref="InsertCommentOnlineResponse" /></returns>
        public InsertCommentOnlineResponse InsertCommentOnline(InsertCommentOnlineRequest request)
        {
            return (InsertCommentOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new DrawingObject to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertDrawingObjectRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse" /></returns>
        public DrawingObjectResponse InsertDrawingObject(InsertDrawingObjectRequest request)
        {
            return (DrawingObjectResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new DrawingObject to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertDrawingObjectOnlineRequest" /></param>
        /// <returns><see cref="InsertDrawingObjectOnlineResponse" /></returns>
        public InsertDrawingObjectOnlineResponse InsertDrawingObjectOnline(InsertDrawingObjectOnlineRequest request)
        {
            return (InsertDrawingObjectOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new field to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFieldRequest" /></param>
        /// <returns><see cref="FieldResponse" /></returns>
        public FieldResponse InsertField(InsertFieldRequest request)
        {
            return (FieldResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new field to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFieldOnlineRequest" /></param>
        /// <returns><see cref="InsertFieldOnlineResponse" /></returns>
        public InsertFieldOnlineResponse InsertFieldOnline(InsertFieldOnlineRequest request)
        {
            return (InsertFieldOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new footnote to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFootnoteRequest" /></param>
        /// <returns><see cref="FootnoteResponse" /></returns>
        public FootnoteResponse InsertFootnote(InsertFootnoteRequest request)
        {
            return (FootnoteResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new footnote to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFootnoteOnlineRequest" /></param>
        /// <returns><see cref="InsertFootnoteOnlineResponse" /></returns>
        public InsertFootnoteOnlineResponse InsertFootnoteOnline(InsertFootnoteOnlineRequest request)
        {
            return (InsertFootnoteOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new form field to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFormFieldRequest" /></param>
        /// <returns><see cref="FormFieldResponse" /></returns>
        public FormFieldResponse InsertFormField(InsertFormFieldRequest request)
        {
            return (FormFieldResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new form field to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFormFieldOnlineRequest" /></param>
        /// <returns><see cref="InsertFormFieldOnlineResponse" /></returns>
        public InsertFormFieldOnlineResponse InsertFormFieldOnline(InsertFormFieldOnlineRequest request)
        {
            return (InsertFormFieldOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new HeaderFooter object to the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertHeaderFooterRequest" /></param>
        /// <returns><see cref="HeaderFooterResponse" /></returns>
        public HeaderFooterResponse InsertHeaderFooter(InsertHeaderFooterRequest request)
        {
            return (HeaderFooterResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new HeaderFooter object to the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertHeaderFooterOnlineRequest" /></param>
        /// <returns><see cref="InsertHeaderFooterOnlineResponse" /></returns>
        public InsertHeaderFooterOnlineResponse InsertHeaderFooterOnline(InsertHeaderFooterOnlineRequest request)
        {
            return (InsertHeaderFooterOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new list to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertListRequest" /></param>
        /// <returns><see cref="ListResponse" /></returns>
        public ListResponse InsertList(InsertListRequest request)
        {
            return (ListResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new list to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertListOnlineRequest" /></param>
        /// <returns><see cref="InsertListOnlineResponse" /></returns>
        public InsertListOnlineResponse InsertListOnline(InsertListOnlineRequest request)
        {
            return (InsertListOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new or updates an existing paragraph tab stop in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertOrUpdateParagraphTabStopRequest" /></param>
        /// <returns><see cref="TabStopsResponse" /></returns>
        public TabStopsResponse InsertOrUpdateParagraphTabStop(InsertOrUpdateParagraphTabStopRequest request)
        {
            return (TabStopsResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new or updates an existing paragraph tab stop in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertOrUpdateParagraphTabStopOnlineRequest" /></param>
        /// <returns><see cref="InsertOrUpdateParagraphTabStopOnlineResponse" /></returns>
        public InsertOrUpdateParagraphTabStopOnlineResponse InsertOrUpdateParagraphTabStopOnline(InsertOrUpdateParagraphTabStopOnlineRequest request)
        {
            return (InsertOrUpdateParagraphTabStopOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts page numbers to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertPageNumbersRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse InsertPageNumbers(InsertPageNumbersRequest request)
        {
            return (DocumentResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts page numbers to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertPageNumbersOnlineRequest" /></param>
        /// <returns><see cref="InsertPageNumbersOnlineResponse" /></returns>
        public InsertPageNumbersOnlineResponse InsertPageNumbersOnline(InsertPageNumbersOnlineRequest request)
        {
            return (InsertPageNumbersOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new paragraph to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertParagraphRequest" /></param>
        /// <returns><see cref="ParagraphResponse" /></returns>
        public ParagraphResponse InsertParagraph(InsertParagraphRequest request)
        {
            return (ParagraphResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new paragraph to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertParagraphOnlineRequest" /></param>
        /// <returns><see cref="InsertParagraphOnlineResponse" /></returns>
        public InsertParagraphOnlineResponse InsertParagraphOnline(InsertParagraphOnlineRequest request)
        {
            return (InsertParagraphOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new Run object to the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertRunRequest" /></param>
        /// <returns><see cref="RunResponse" /></returns>
        public RunResponse InsertRun(InsertRunRequest request)
        {
            return (RunResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new Run object to the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertRunOnlineRequest" /></param>
        /// <returns><see cref="InsertRunOnlineResponse" /></returns>
        public InsertRunOnlineResponse InsertRunOnline(InsertRunOnlineRequest request)
        {
            return (InsertRunOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new style to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertStyleRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public StyleResponse InsertStyle(InsertStyleRequest request)
        {
            return (StyleResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new style to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertStyleOnlineRequest" /></param>
        /// <returns><see cref="InsertStyleOnlineResponse" /></returns>
        public InsertStyleOnlineResponse InsertStyleOnline(InsertStyleOnlineRequest request)
        {
            return (InsertStyleOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new table to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableRequest" /></param>
        /// <returns><see cref="TableResponse" /></returns>
        public TableResponse InsertTable(InsertTableRequest request)
        {
            return (TableResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new cell to the table row.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableCellRequest" /></param>
        /// <returns><see cref="TableCellResponse" /></returns>
        public TableCellResponse InsertTableCell(InsertTableCellRequest request)
        {
            return (TableCellResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new cell to the table row.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableCellOnlineRequest" /></param>
        /// <returns><see cref="InsertTableCellOnlineResponse" /></returns>
        public InsertTableCellOnlineResponse InsertTableCellOnline(InsertTableCellOnlineRequest request)
        {
            return (InsertTableCellOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new table to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableOnlineRequest" /></param>
        /// <returns><see cref="InsertTableOnlineResponse" /></returns>
        public InsertTableOnlineResponse InsertTableOnline(InsertTableOnlineRequest request)
        {
            return (InsertTableOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new row to the table.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableRowRequest" /></param>
        /// <returns><see cref="TableRowResponse" /></returns>
        public TableRowResponse InsertTableRow(InsertTableRowRequest request)
        {
            return (TableRowResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new row to the table.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableRowOnlineRequest" /></param>
        /// <returns><see cref="InsertTableRowOnlineResponse" /></returns>
        public InsertTableRowOnlineResponse InsertTableRowOnline(InsertTableRowOnlineRequest request)
        {
            return (InsertTableRowOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new watermark image to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertWatermarkImageRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse InsertWatermarkImage(InsertWatermarkImageRequest request)
        {
            return (DocumentResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new watermark image to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertWatermarkImageOnlineRequest" /></param>
        /// <returns><see cref="InsertWatermarkImageOnlineResponse" /></returns>
        public InsertWatermarkImageOnlineResponse InsertWatermarkImageOnline(InsertWatermarkImageOnlineRequest request)
        {
            return (InsertWatermarkImageOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new watermark text to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertWatermarkTextRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse InsertWatermarkText(InsertWatermarkTextRequest request)
        {
            return (DocumentResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Inserts a new watermark text to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertWatermarkTextOnlineRequest" /></param>
        /// <returns><see cref="InsertWatermarkTextOnlineResponse" /></returns>
        public InsertWatermarkTextOnlineResponse InsertWatermarkTextOnline(InsertWatermarkTextOnlineRequest request)
        {
            return (InsertWatermarkTextOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Downloads a document from the Web using URL and saves it to cloud storage in the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="LoadWebDocumentRequest" /></param>
        /// <returns><see cref="SaveResponse" /></returns>
        public SaveResponse LoadWebDocument(LoadWebDocumentRequest request)
        {
            return (SaveResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Move file.
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFileRequest" /></param>
        public void MoveFile(MoveFileRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Move folder.
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFolderRequest" /></param>
        public void MoveFolder(MoveFolderRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Applies document content optimization options, specific to a particular versions of Microsoft Word.
        /// </summary>
        /// <param name="request">Request. <see cref="OptimizeDocumentRequest" /></param>
        public void OptimizeDocument(OptimizeDocumentRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Applies document content optimization options, specific to a particular versions of Microsoft Word.
        /// </summary>
        /// <param name="request">Request. <see cref="OptimizeDocumentOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream OptimizeDocumentOnline(OptimizeDocumentOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Adds protection to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="ProtectDocumentRequest" /></param>
        /// <returns><see cref="ProtectionDataResponse" /></returns>
        public ProtectionDataResponse ProtectDocument(ProtectDocumentRequest request)
        {
            return (ProtectionDataResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Adds protection to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="ProtectDocumentOnlineRequest" /></param>
        /// <returns><see cref="ProtectDocumentOnlineResponse" /></returns>
        public ProtectDocumentOnlineResponse ProtectDocumentOnline(ProtectDocumentOnlineRequest request)
        {
            return (ProtectDocumentOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Rejects all revisions in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="RejectAllRevisionsRequest" /></param>
        /// <returns><see cref="RevisionsModificationResponse" /></returns>
        public RevisionsModificationResponse RejectAllRevisions(RejectAllRevisionsRequest request)
        {
            return (RevisionsModificationResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Rejects all revisions in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="RejectAllRevisionsOnlineRequest" /></param>
        /// <returns><see cref="RejectAllRevisionsOnlineResponse" /></returns>
        public RejectAllRevisionsOnlineResponse RejectAllRevisionsOnline(RejectAllRevisionsOnlineRequest request)
        {
            return (RejectAllRevisionsOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a range from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="RemoveRangeRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse RemoveRange(RemoveRangeRequest request)
        {
            return (DocumentResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes a range from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="RemoveRangeOnlineRequest" /></param>
        /// <returns><see cref="RemoveRangeOnlineResponse" /></returns>
        public RemoveRangeOnlineResponse RemoveRangeOnline(RemoveRangeOnlineRequest request)
        {
            return (RemoveRangeOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Renders a DrawingObject to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderDrawingObjectRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream RenderDrawingObject(RenderDrawingObjectRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Renders a DrawingObject to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderDrawingObjectOnlineRequest" /></param>
        /// <returns><see cref="RenderDrawingObjectOnlineResponse" /></returns>
        public RenderDrawingObjectOnlineResponse RenderDrawingObjectOnline(RenderDrawingObjectOnlineRequest request)
        {
            return (RenderDrawingObjectOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Renders an OfficeMath object to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderMathObjectRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream RenderMathObject(RenderMathObjectRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Renders an OfficeMath object to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderMathObjectOnlineRequest" /></param>
        /// <returns><see cref="RenderMathObjectOnlineResponse" /></returns>
        public RenderMathObjectOnlineResponse RenderMathObjectOnline(RenderMathObjectOnlineRequest request)
        {
            return (RenderMathObjectOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Renders a page to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderPageRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream RenderPage(RenderPageRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Renders a page to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderPageOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream RenderPageOnline(RenderPageOnlineRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Renders a paragraph to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderParagraphRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream RenderParagraph(RenderParagraphRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Renders a paragraph to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderParagraphOnlineRequest" /></param>
        /// <returns><see cref="RenderParagraphOnlineResponse" /></returns>
        public RenderParagraphOnlineResponse RenderParagraphOnline(RenderParagraphOnlineRequest request)
        {
            return (RenderParagraphOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Renders a table to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderTableRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream RenderTable(RenderTableRequest request)
        {
            return (System.IO.Stream)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Renders a table to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderTableOnlineRequest" /></param>
        /// <returns><see cref="RenderTableOnlineResponse" /></returns>
        public RenderTableOnlineResponse RenderTableOnline(RenderTableOnlineRequest request)
        {
            return (RenderTableOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Replaces text in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="ReplaceTextRequest" /></param>
        /// <returns><see cref="ReplaceTextResponse" /></returns>
        public ReplaceTextResponse ReplaceText(ReplaceTextRequest request)
        {
            return (ReplaceTextResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Replaces text in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="ReplaceTextOnlineRequest" /></param>
        /// <returns><see cref="ReplaceTextOnlineResponse" /></returns>
        public ReplaceTextOnlineResponse ReplaceTextOnline(ReplaceTextOnlineRequest request)
        {
            return (ReplaceTextOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Replaces a range with text in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="ReplaceWithTextRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse ReplaceWithText(ReplaceWithTextRequest request)
        {
            return (DocumentResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Replaces a range with text in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="ReplaceWithTextOnlineRequest" /></param>
        /// <returns><see cref="ReplaceWithTextOnlineResponse" /></returns>
        public ReplaceWithTextOnlineResponse ReplaceWithTextOnline(ReplaceWithTextOnlineRequest request)
        {
            return (ReplaceWithTextOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Clears the font cache.
        /// </summary>
        /// <param name="request">Request. <see cref="ResetCacheRequest" /></param>
        public void ResetCache(ResetCacheRequest request)
        {
        request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Converts a document in cloud storage to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="SaveAsRequest" /></param>
        /// <returns><see cref="SaveResponse" /></returns>
        public SaveResponse SaveAs(SaveAsRequest request)
        {
            return (SaveResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Converts a document in cloud storage to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="SaveAsOnlineRequest" /></param>
        /// <returns><see cref="SaveAsOnlineResponse" /></returns>
        public SaveAsOnlineResponse SaveAsOnline(SaveAsOnlineRequest request)
        {
            return (SaveAsOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Saves a range as a new document.
        /// </summary>
        /// <param name="request">Request. <see cref="SaveAsRangeRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse SaveAsRange(SaveAsRangeRequest request)
        {
            return (DocumentResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Saves a range as a new document.
        /// </summary>
        /// <param name="request">Request. <see cref="SaveAsRangeOnlineRequest" /></param>
        /// <returns><see cref="SaveAsRangeOnlineResponse" /></returns>
        public SaveAsRangeOnlineResponse SaveAsRangeOnline(SaveAsRangeOnlineRequest request)
        {
            return (SaveAsRangeOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Converts a document in cloud storage to TIFF format using detailed conversion settings.
        /// </summary>
        /// <param name="request">Request. <see cref="SaveAsTiffRequest" /></param>
        /// <returns><see cref="SaveResponse" /></returns>
        public SaveResponse SaveAsTiff(SaveAsTiffRequest request)
        {
            return (SaveResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Converts a document in cloud storage to TIFF format using detailed conversion settings.
        /// </summary>
        /// <param name="request">Request. <see cref="SaveAsTiffOnlineRequest" /></param>
        /// <returns><see cref="SaveAsTiffOnlineResponse" /></returns>
        public SaveAsTiffOnlineResponse SaveAsTiffOnline(SaveAsTiffOnlineRequest request)
        {
            return (SaveAsTiffOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Searches text, specified by the regular expression, in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="SearchRequest" /></param>
        /// <returns><see cref="SearchResponse" /></returns>
        public SearchResponse Search(SearchRequest request)
        {
            return (SearchResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Searches text, specified by the regular expression, in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="SearchOnlineRequest" /></param>
        /// <returns><see cref="SearchResponse" /></returns>
        public SearchResponse SearchOnline(SearchOnlineRequest request)
        {
            return (SearchResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Splits a document into parts and saves them in the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="SplitDocumentRequest" /></param>
        /// <returns><see cref="SplitDocumentResponse" /></returns>
        public SplitDocumentResponse SplitDocument(SplitDocumentRequest request)
        {
            return (SplitDocumentResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Splits a document into parts and saves them in the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="SplitDocumentOnlineRequest" /></param>
        /// <returns><see cref="SplitDocumentOnlineResponse" /></returns>
        public SplitDocumentOnlineResponse SplitDocumentOnline(SplitDocumentOnlineRequest request)
        {
            return (SplitDocumentOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes protection from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UnprotectDocumentRequest" /></param>
        /// <returns><see cref="ProtectionDataResponse" /></returns>
        public ProtectionDataResponse UnprotectDocument(UnprotectDocumentRequest request)
        {
            return (ProtectionDataResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Removes protection from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UnprotectDocumentOnlineRequest" /></param>
        /// <returns><see cref="UnprotectDocumentOnlineResponse" /></returns>
        public UnprotectDocumentOnlineResponse UnprotectDocumentOnline(UnprotectDocumentOnlineRequest request)
        {
            return (UnprotectDocumentOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates a bookmark in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateBookmarkRequest" /></param>
        /// <returns><see cref="BookmarkResponse" /></returns>
        public BookmarkResponse UpdateBookmark(UpdateBookmarkRequest request)
        {
            return (BookmarkResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates a bookmark in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateBookmarkOnlineRequest" /></param>
        /// <returns><see cref="UpdateBookmarkOnlineResponse" /></returns>
        public UpdateBookmarkOnlineResponse UpdateBookmarkOnline(UpdateBookmarkOnlineRequest request)
        {
            return (UpdateBookmarkOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// The 'nodePath' parameter should refer to a paragraph, a cell or a row.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateBorderRequest" /></param>
        /// <returns><see cref="BorderResponse" /></returns>
        public BorderResponse UpdateBorder(UpdateBorderRequest request)
        {
            return (BorderResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates a border in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateBorderOnlineRequest" /></param>
        /// <returns><see cref="UpdateBorderOnlineResponse" /></returns>
        public UpdateBorderOnlineResponse UpdateBorderOnline(UpdateBorderOnlineRequest request)
        {
            return (UpdateBorderOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates a comment in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateCommentRequest" /></param>
        /// <returns><see cref="CommentResponse" /></returns>
        public CommentResponse UpdateComment(UpdateCommentRequest request)
        {
            return (CommentResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates a comment in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateCommentOnlineRequest" /></param>
        /// <returns><see cref="UpdateCommentOnlineResponse" /></returns>
        public UpdateCommentOnlineResponse UpdateCommentOnline(UpdateCommentOnlineRequest request)
        {
            return (UpdateCommentOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates a DrawingObject in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateDrawingObjectRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse" /></returns>
        public DrawingObjectResponse UpdateDrawingObject(UpdateDrawingObjectRequest request)
        {
            return (DrawingObjectResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates a DrawingObject in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateDrawingObjectOnlineRequest" /></param>
        /// <returns><see cref="UpdateDrawingObjectOnlineResponse" /></returns>
        public UpdateDrawingObjectOnlineResponse UpdateDrawingObjectOnline(UpdateDrawingObjectOnlineRequest request)
        {
            return (UpdateDrawingObjectOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates a field in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFieldRequest" /></param>
        /// <returns><see cref="FieldResponse" /></returns>
        public FieldResponse UpdateField(UpdateFieldRequest request)
        {
            return (FieldResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates a field in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFieldOnlineRequest" /></param>
        /// <returns><see cref="UpdateFieldOnlineResponse" /></returns>
        public UpdateFieldOnlineResponse UpdateFieldOnline(UpdateFieldOnlineRequest request)
        {
            return (UpdateFieldOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reevaluates field values in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFieldsRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse UpdateFields(UpdateFieldsRequest request)
        {
            return (DocumentResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Reevaluates field values in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFieldsOnlineRequest" /></param>
        /// <returns><see cref="UpdateFieldsOnlineResponse" /></returns>
        public UpdateFieldsOnlineResponse UpdateFieldsOnline(UpdateFieldsOnlineRequest request)
        {
            return (UpdateFieldsOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates a footnote in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFootnoteRequest" /></param>
        /// <returns><see cref="FootnoteResponse" /></returns>
        public FootnoteResponse UpdateFootnote(UpdateFootnoteRequest request)
        {
            return (FootnoteResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates a footnote in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFootnoteOnlineRequest" /></param>
        /// <returns><see cref="UpdateFootnoteOnlineResponse" /></returns>
        public UpdateFootnoteOnlineResponse UpdateFootnoteOnline(UpdateFootnoteOnlineRequest request)
        {
            return (UpdateFootnoteOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates a form field in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFormFieldRequest" /></param>
        /// <returns><see cref="FormFieldResponse" /></returns>
        public FormFieldResponse UpdateFormField(UpdateFormFieldRequest request)
        {
            return (FormFieldResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates a form field in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFormFieldOnlineRequest" /></param>
        /// <returns><see cref="UpdateFormFieldOnlineResponse" /></returns>
        public UpdateFormFieldOnlineResponse UpdateFormFieldOnline(UpdateFormFieldOnlineRequest request)
        {
            return (UpdateFormFieldOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates a list in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateListRequest" /></param>
        /// <returns><see cref="ListResponse" /></returns>
        public ListResponse UpdateList(UpdateListRequest request)
        {
            return (ListResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates the level of a List element in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateListLevelRequest" /></param>
        /// <returns><see cref="ListResponse" /></returns>
        public ListResponse UpdateListLevel(UpdateListLevelRequest request)
        {
            return (ListResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates the level of a List element in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateListLevelOnlineRequest" /></param>
        /// <returns><see cref="UpdateListLevelOnlineResponse" /></returns>
        public UpdateListLevelOnlineResponse UpdateListLevelOnline(UpdateListLevelOnlineRequest request)
        {
            return (UpdateListLevelOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates a list in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateListOnlineRequest" /></param>
        /// <returns><see cref="UpdateListOnlineResponse" /></returns>
        public UpdateListOnlineResponse UpdateListOnline(UpdateListOnlineRequest request)
        {
            return (UpdateListOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates the formatting properties of a paragraph in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateParagraphFormatRequest" /></param>
        /// <returns><see cref="ParagraphFormatResponse" /></returns>
        public ParagraphFormatResponse UpdateParagraphFormat(UpdateParagraphFormatRequest request)
        {
            return (ParagraphFormatResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates the formatting properties of a paragraph in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateParagraphFormatOnlineRequest" /></param>
        /// <returns><see cref="UpdateParagraphFormatOnlineResponse" /></returns>
        public UpdateParagraphFormatOnlineResponse UpdateParagraphFormatOnline(UpdateParagraphFormatOnlineRequest request)
        {
            return (UpdateParagraphFormatOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates the formatting properties of a paragraph list in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateParagraphListFormatRequest" /></param>
        /// <returns><see cref="ParagraphListFormatResponse" /></returns>
        public ParagraphListFormatResponse UpdateParagraphListFormat(UpdateParagraphListFormatRequest request)
        {
            return (ParagraphListFormatResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates the formatting properties of a paragraph list in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateParagraphListFormatOnlineRequest" /></param>
        /// <returns><see cref="UpdateParagraphListFormatOnlineResponse" /></returns>
        public UpdateParagraphListFormatOnlineResponse UpdateParagraphListFormatOnline(UpdateParagraphListFormatOnlineRequest request)
        {
            return (UpdateParagraphListFormatOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates a Run object in the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateRunRequest" /></param>
        /// <returns><see cref="RunResponse" /></returns>
        public RunResponse UpdateRun(UpdateRunRequest request)
        {
            return (RunResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates the font properties of a Run object in the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateRunFontRequest" /></param>
        /// <returns><see cref="FontResponse" /></returns>
        public FontResponse UpdateRunFont(UpdateRunFontRequest request)
        {
            return (FontResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates the font properties of a Run object in the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateRunFontOnlineRequest" /></param>
        /// <returns><see cref="UpdateRunFontOnlineResponse" /></returns>
        public UpdateRunFontOnlineResponse UpdateRunFontOnline(UpdateRunFontOnlineRequest request)
        {
            return (UpdateRunFontOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates a Run object in the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateRunOnlineRequest" /></param>
        /// <returns><see cref="UpdateRunOnlineResponse" /></returns>
        public UpdateRunOnlineResponse UpdateRunOnline(UpdateRunOnlineRequest request)
        {
            return (UpdateRunOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates the page setup of a section in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateSectionPageSetupRequest" /></param>
        /// <returns><see cref="SectionPageSetupResponse" /></returns>
        public SectionPageSetupResponse UpdateSectionPageSetup(UpdateSectionPageSetupRequest request)
        {
            return (SectionPageSetupResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates the page setup of a section in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateSectionPageSetupOnlineRequest" /></param>
        /// <returns><see cref="UpdateSectionPageSetupOnlineResponse" /></returns>
        public UpdateSectionPageSetupOnlineResponse UpdateSectionPageSetupOnline(UpdateSectionPageSetupOnlineRequest request)
        {
            return (UpdateSectionPageSetupOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates a style in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateStyleRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public StyleResponse UpdateStyle(UpdateStyleRequest request)
        {
            return (StyleResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates a style in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateStyleOnlineRequest" /></param>
        /// <returns><see cref="UpdateStyleOnlineResponse" /></returns>
        public UpdateStyleOnlineResponse UpdateStyleOnline(UpdateStyleOnlineRequest request)
        {
            return (UpdateStyleOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates the formatting properties of a cell in the table row.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTableCellFormatRequest" /></param>
        /// <returns><see cref="TableCellFormatResponse" /></returns>
        public TableCellFormatResponse UpdateTableCellFormat(UpdateTableCellFormatRequest request)
        {
            return (TableCellFormatResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates the formatting properties of a cell in the table row.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTableCellFormatOnlineRequest" /></param>
        /// <returns><see cref="UpdateTableCellFormatOnlineResponse" /></returns>
        public UpdateTableCellFormatOnlineResponse UpdateTableCellFormatOnline(UpdateTableCellFormatOnlineRequest request)
        {
            return (UpdateTableCellFormatOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates properties of a table in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTablePropertiesRequest" /></param>
        /// <returns><see cref="TablePropertiesResponse" /></returns>
        public TablePropertiesResponse UpdateTableProperties(UpdateTablePropertiesRequest request)
        {
            return (TablePropertiesResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates properties of a table in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTablePropertiesOnlineRequest" /></param>
        /// <returns><see cref="UpdateTablePropertiesOnlineResponse" /></returns>
        public UpdateTablePropertiesOnlineResponse UpdateTablePropertiesOnline(UpdateTablePropertiesOnlineRequest request)
        {
            return (UpdateTablePropertiesOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates the formatting properties of a table row.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTableRowFormatRequest" /></param>
        /// <returns><see cref="TableRowFormatResponse" /></returns>
        public TableRowFormatResponse UpdateTableRowFormat(UpdateTableRowFormatRequest request)
        {
            return (TableRowFormatResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Updates the formatting properties of a table row.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTableRowFormatOnlineRequest" /></param>
        /// <returns><see cref="UpdateTableRowFormatOnlineResponse" /></returns>
        public UpdateTableRowFormatOnlineResponse UpdateTableRowFormatOnline(UpdateTableRowFormatOnlineRequest request)
        {
            return (UpdateTableRowFormatOnlineResponse)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Upload file.
        /// </summary>
        /// <param name="request">Request. <see cref="UploadFileRequest" /></param>
        /// <returns><see cref="FilesUploadResult" /></returns>
        public FilesUploadResult UploadFile(UploadFileRequest request)
        {
            return (FilesUploadResult)request.DeserializeResponse(this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration)));
        }

        /// <summary>
        /// Batch request.
        /// </summary>
        /// <param name="requests">Array of <see cref="IRequestModel" /> requests.</param>
        /// <returns><see cref="HttpResponseMessage[]" /></returns>
        public object[] Batch(params IRequestModel[] requests)
        {
            if (requests == null || requests.Length == 0)
            {
                 return null;
            }

            var url = this.configuration.GetApiRootUrl() + "/words/batch";
            var response = this.apiInvoker.InvokeApi(() =>
            {
                var multipartFormDataContent = new MultipartFormDataContent();
                foreach (var request in requests)
                {
                    multipartFormDataContent.Add(new ChildRequestContent(this.configuration, request.CreateHttpRequest(this.configuration)));
                }

                var httpContent = new HttpRequestMessage(HttpMethod.Put, url);
                httpContent.Content = multipartFormDataContent;
                return httpContent;
            });
            var responseParts = ApiInvoker.ToMultipartResponse(response);

            if (responseParts.Length != requests.Length)
            {
                 throw new ApiException(400, "The number of responses does not match the number of requests.");
            }

            var result = new object[responseParts.Length];
            for (int i = 0; i < responseParts.Length; i++)
            {
                var responsePart = responseParts[i];
                if (responsePart.IsSuccessStatusCode)
                {
                    result[i] = requests[i].DeserializeResponse(responsePart);
                }
                else
                {
                    try
                    {
                        ApiExceptionRequestHandler.ThrowApiException(responsePart);
                    }
                    catch (Exception ex)
                    {
                        result[i] = ex;
                    }
                }
            }

            return result;
        }
    }
}
