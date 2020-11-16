// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WordsApi.cs">
//   Copyright (c) 2020 Aspose.Words for Cloud
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
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (RevisionsModificationResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(RevisionsModificationResponse));
        }

        /// <summary>
        /// Appends documents to the original document.
        /// </summary>
        /// <param name="request">Request. <see cref="AppendDocumentRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse AppendDocument(AppendDocumentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Applies a style to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="ApplyStyleToDocumentElementRequest" /></param>
        /// <returns><see cref="WordsResponse" /></returns>
        public WordsResponse ApplyStyleToDocumentElement(ApplyStyleToDocumentElementRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (WordsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(WordsResponse));
        }

        /// <summary>
        /// Executes the report generation process using the specified document template and the external data source in XML, JSON or CSV format.
        /// </summary>
        /// <param name="request">Request. <see cref="BuildReportRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse BuildReport(BuildReportRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Executes the report generation process online using the specified document template and the external data source in XML, JSON or CSV format.
        /// </summary>
        /// <param name="request">Request. <see cref="BuildReportOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream BuildReportOnline(BuildReportOnlineRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Runs a multi-class text classification for the specified raw text.
        /// </summary>
        /// <param name="request">Request. <see cref="ClassifyRequest" /></param>
        /// <returns><see cref="ClassificationResponse" /></returns>
        public ClassificationResponse Classify(ClassifyRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ClassificationResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ClassificationResponse));
        }

        /// <summary>
        /// Runs a multi-class text classification for the document.
        /// </summary>
        /// <param name="request">Request. <see cref="ClassifyDocumentRequest" /></param>
        /// <returns><see cref="ClassificationResponse" /></returns>
        public ClassificationResponse ClassifyDocument(ClassifyDocumentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ClassificationResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ClassificationResponse));
        }

        /// <summary>
        /// Compares two documents.
        /// </summary>
        /// <param name="request">Request. <see cref="CompareDocumentRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse CompareDocument(CompareDocumentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Converts a document on a local drive to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertDocumentRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream ConvertDocument(ConvertDocumentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Copy file.
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFileRequest" /></param>
        public void CopyFile(CopyFileRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Copy folder.
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFolderRequest" /></param>
        public void CopyFolder(CopyFolderRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Makes a copy of the style in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="CopyStyleRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public StyleResponse CopyStyle(CopyStyleRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (StyleResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(StyleResponse));
        }

        /// <summary>
        /// Supported extensions: ".doc", ".docx", ".docm", ".dot", ".dotm", ".dotx", ".flatopc", ".fopc", ".flatopc_macro", ".fopc_macro", ".flatopc_template", ".fopc_template", ".flatopc_template_macro", ".fopc_template_macro", ".wordml", ".wml", ".rtf".
        /// </summary>
        /// <param name="request">Request. <see cref="CreateDocumentRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse CreateDocument(CreateDocumentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Create the folder.
        /// </summary>
        /// <param name="request">Request. <see cref="CreateFolderRequest" /></param>
        public void CreateFolder(CreateFolderRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Adds a new or updates an existing document property.
        /// </summary>
        /// <param name="request">Request. <see cref="CreateOrUpdateDocumentPropertyRequest" /></param>
        /// <returns><see cref="DocumentPropertyResponse" /></returns>
        public DocumentPropertyResponse CreateOrUpdateDocumentProperty(CreateOrUpdateDocumentPropertyRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentPropertyResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentPropertyResponse));
        }

        /// <summary>
        /// Removes paragraph tab stops from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteAllParagraphTabStopsRequest" /></param>
        /// <returns><see cref="TabStopsResponse" /></returns>
        public TabStopsResponse DeleteAllParagraphTabStops(DeleteAllParagraphTabStopsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TabStopsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TabStopsResponse));
        }

        /// <summary>
        /// The 'nodePath' parameter should refer to a paragraph, a cell or a row.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteBorderRequest" /></param>
        /// <returns><see cref="BorderResponse" /></returns>
        public BorderResponse DeleteBorder(DeleteBorderRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (BorderResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(BorderResponse));
        }

        /// <summary>
        /// The 'nodePath' parameter should refer to a paragraph, a cell or a row.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteBordersRequest" /></param>
        /// <returns><see cref="BordersResponse" /></returns>
        public BordersResponse DeleteBorders(DeleteBordersRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (BordersResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(BordersResponse));
        }

        /// <summary>
        /// Removes a comment from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteCommentRequest" /></param>
        public void DeleteComment(DeleteCommentRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes a document property.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDocumentPropertyRequest" /></param>
        public void DeleteDocumentProperty(DeleteDocumentPropertyRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes a DrawingObject from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDrawingObjectRequest" /></param>
        public void DeleteDrawingObject(DeleteDrawingObjectRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes a field from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFieldRequest" /></param>
        public void DeleteField(DeleteFieldRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes fields from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFieldsRequest" /></param>
        public void DeleteFields(DeleteFieldsRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Delete file.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFileRequest" /></param>
        public void DeleteFile(DeleteFileRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Delete folder.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFolderRequest" /></param>
        public void DeleteFolder(DeleteFolderRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes a footnote from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFootnoteRequest" /></param>
        public void DeleteFootnote(DeleteFootnoteRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes a form field from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFormFieldRequest" /></param>
        public void DeleteFormField(DeleteFormFieldRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes a HeaderFooter object from the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHeaderFooterRequest" /></param>
        public void DeleteHeaderFooter(DeleteHeaderFooterRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes HeaderFooter objects from the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHeadersFootersRequest" /></param>
        public void DeleteHeadersFooters(DeleteHeadersFootersRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes macros from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteMacrosRequest" /></param>
        public void DeleteMacros(DeleteMacrosRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes an OfficeMath object from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteOfficeMathObjectRequest" /></param>
        public void DeleteOfficeMathObject(DeleteOfficeMathObjectRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes a paragraph from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphRequest" /></param>
        public void DeleteParagraph(DeleteParagraphRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes the formatting properties of a paragraph list from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphListFormatRequest" /></param>
        /// <returns><see cref="ParagraphListFormatResponse" /></returns>
        public ParagraphListFormatResponse DeleteParagraphListFormat(DeleteParagraphListFormatRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ParagraphListFormatResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ParagraphListFormatResponse));
        }

        /// <summary>
        /// Removes a paragraph tab stop from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphTabStopRequest" /></param>
        /// <returns><see cref="TabStopsResponse" /></returns>
        public TabStopsResponse DeleteParagraphTabStop(DeleteParagraphTabStopRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TabStopsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TabStopsResponse));
        }

        /// <summary>
        /// Removes a Run object from the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteRunRequest" /></param>
        public void DeleteRun(DeleteRunRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes a section from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSectionRequest" /></param>
        public void DeleteSection(DeleteSectionRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes a table from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableRequest" /></param>
        public void DeleteTable(DeleteTableRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes a cell from the table row.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableCellRequest" /></param>
        public void DeleteTableCell(DeleteTableCellRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes a row from the table.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableRowRequest" /></param>
        public void DeleteTableRow(DeleteTableRowRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes a watermark from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWatermarkRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse DeleteWatermark(DeleteWatermarkRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Download file.
        /// </summary>
        /// <param name="request">Request. <see cref="DownloadFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream DownloadFile(DownloadFileRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Executes a Mail Merge operation.
        /// </summary>
        /// <param name="request">Request. <see cref="ExecuteMailMergeRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse ExecuteMailMerge(ExecuteMailMergeRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Executes a Mail Merge operation online.
        /// </summary>
        /// <param name="request">Request. <see cref="ExecuteMailMergeOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream ExecuteMailMergeOnline(ExecuteMailMergeOnlineRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Reads available fonts from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetAvailableFontsRequest" /></param>
        /// <returns><see cref="AvailableFontsResponse" /></returns>
        public AvailableFontsResponse GetAvailableFonts(GetAvailableFontsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (AvailableFontsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(AvailableFontsResponse));
        }

        /// <summary>
        /// Reads a bookmark, specified by name, from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBookmarkByNameRequest" /></param>
        /// <returns><see cref="BookmarkResponse" /></returns>
        public BookmarkResponse GetBookmarkByName(GetBookmarkByNameRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (BookmarkResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(BookmarkResponse));
        }

        /// <summary>
        /// Reads bookmarks from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBookmarksRequest" /></param>
        /// <returns><see cref="BookmarksResponse" /></returns>
        public BookmarksResponse GetBookmarks(GetBookmarksRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (BookmarksResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(BookmarksResponse));
        }

        /// <summary>
        /// The 'nodePath' parameter should refer to a paragraph, a cell or a row.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBorderRequest" /></param>
        /// <returns><see cref="BorderResponse" /></returns>
        public BorderResponse GetBorder(GetBorderRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (BorderResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(BorderResponse));
        }

        /// <summary>
        /// Reads borders from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBordersRequest" /></param>
        /// <returns><see cref="BordersResponse" /></returns>
        public BordersResponse GetBorders(GetBordersRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (BordersResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(BordersResponse));
        }

        /// <summary>
        /// Reads a comment from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetCommentRequest" /></param>
        /// <returns><see cref="CommentResponse" /></returns>
        public CommentResponse GetComment(GetCommentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (CommentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(CommentResponse));
        }

        /// <summary>
        /// Reads comments from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetCommentsRequest" /></param>
        /// <returns><see cref="CommentsResponse" /></returns>
        public CommentsResponse GetComments(GetCommentsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (CommentsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(CommentsResponse));
        }

        /// <summary>
        /// Reads common information from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse GetDocument(GetDocumentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Reads a DrawingObject from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectByIndexRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse" /></returns>
        public DrawingObjectResponse GetDocumentDrawingObjectByIndex(GetDocumentDrawingObjectByIndexRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DrawingObjectResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DrawingObjectResponse));
        }

        /// <summary>
        /// Reads image data of a DrawingObject from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectImageDataRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream GetDocumentDrawingObjectImageData(GetDocumentDrawingObjectImageDataRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Reads OLE data of a DrawingObject from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectOleDataRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream GetDocumentDrawingObjectOleData(GetDocumentDrawingObjectOleDataRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Reads DrawingObjects from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectsRequest" /></param>
        /// <returns><see cref="DrawingObjectsResponse" /></returns>
        public DrawingObjectsResponse GetDocumentDrawingObjects(GetDocumentDrawingObjectsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DrawingObjectsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DrawingObjectsResponse));
        }

        /// <summary>
        /// Reads merge field names from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentFieldNamesRequest" /></param>
        /// <returns><see cref="FieldNamesResponse" /></returns>
        public FieldNamesResponse GetDocumentFieldNames(GetDocumentFieldNamesRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FieldNamesResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FieldNamesResponse));
        }

        /// <summary>
        /// Reads merge field names from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentFieldNamesOnlineRequest" /></param>
        /// <returns><see cref="FieldNamesResponse" /></returns>
        public FieldNamesResponse GetDocumentFieldNamesOnline(GetDocumentFieldNamesOnlineRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FieldNamesResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FieldNamesResponse));
        }

        /// <summary>
        /// Reads a hyperlink from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentHyperlinkByIndexRequest" /></param>
        /// <returns><see cref="HyperlinkResponse" /></returns>
        public HyperlinkResponse GetDocumentHyperlinkByIndex(GetDocumentHyperlinkByIndexRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (HyperlinkResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(HyperlinkResponse));
        }

        /// <summary>
        /// Reads hyperlinks from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentHyperlinksRequest" /></param>
        /// <returns><see cref="HyperlinksResponse" /></returns>
        public HyperlinksResponse GetDocumentHyperlinks(GetDocumentHyperlinksRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (HyperlinksResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(HyperlinksResponse));
        }

        /// <summary>
        /// Reads document properties.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentPropertiesRequest" /></param>
        /// <returns><see cref="DocumentPropertiesResponse" /></returns>
        public DocumentPropertiesResponse GetDocumentProperties(GetDocumentPropertiesRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentPropertiesResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentPropertiesResponse));
        }

        /// <summary>
        /// Reads a document property.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentPropertyRequest" /></param>
        /// <returns><see cref="DocumentPropertyResponse" /></returns>
        public DocumentPropertyResponse GetDocumentProperty(GetDocumentPropertyRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentPropertyResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentPropertyResponse));
        }

        /// <summary>
        /// Reads protection properties from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentProtectionRequest" /></param>
        /// <returns><see cref="ProtectionDataResponse" /></returns>
        public ProtectionDataResponse GetDocumentProtection(GetDocumentProtectionRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ProtectionDataResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ProtectionDataResponse));
        }

        /// <summary>
        /// Reads document statistics.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentStatisticsRequest" /></param>
        /// <returns><see cref="StatDataResponse" /></returns>
        public StatDataResponse GetDocumentStatistics(GetDocumentStatisticsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (StatDataResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(StatDataResponse));
        }

        /// <summary>
        /// Converts a document in cloud storage to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentWithFormatRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream GetDocumentWithFormat(GetDocumentWithFormatRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Reads a field from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFieldRequest" /></param>
        /// <returns><see cref="FieldResponse" /></returns>
        public FieldResponse GetField(GetFieldRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FieldResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FieldResponse));
        }

        /// <summary>
        /// Reads fields from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFieldsRequest" /></param>
        /// <returns><see cref="FieldsResponse" /></returns>
        public FieldsResponse GetFields(GetFieldsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FieldsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FieldsResponse));
        }

        /// <summary>
        /// Get all files and folders within a folder.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFilesListRequest" /></param>
        /// <returns><see cref="FilesList" /></returns>
        public FilesList GetFilesList(GetFilesListRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FilesList)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FilesList));
        }

        /// <summary>
        /// Reads a footnote from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFootnoteRequest" /></param>
        /// <returns><see cref="FootnoteResponse" /></returns>
        public FootnoteResponse GetFootnote(GetFootnoteRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FootnoteResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FootnoteResponse));
        }

        /// <summary>
        /// Reads footnotes from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFootnotesRequest" /></param>
        /// <returns><see cref="FootnotesResponse" /></returns>
        public FootnotesResponse GetFootnotes(GetFootnotesRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FootnotesResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FootnotesResponse));
        }

        /// <summary>
        /// Reads a form field from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFormFieldRequest" /></param>
        /// <returns><see cref="FormFieldResponse" /></returns>
        public FormFieldResponse GetFormField(GetFormFieldRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FormFieldResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FormFieldResponse));
        }

        /// <summary>
        /// Reads form fields from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFormFieldsRequest" /></param>
        /// <returns><see cref="FormFieldsResponse" /></returns>
        public FormFieldsResponse GetFormFields(GetFormFieldsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FormFieldsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FormFieldsResponse));
        }

        /// <summary>
        /// Reads a HeaderFooter object from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderFooterRequest" /></param>
        /// <returns><see cref="HeaderFooterResponse" /></returns>
        public HeaderFooterResponse GetHeaderFooter(GetHeaderFooterRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (HeaderFooterResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(HeaderFooterResponse));
        }

        /// <summary>
        /// Reads a HeaderFooter object from the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderFooterOfSectionRequest" /></param>
        /// <returns><see cref="HeaderFooterResponse" /></returns>
        public HeaderFooterResponse GetHeaderFooterOfSection(GetHeaderFooterOfSectionRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (HeaderFooterResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(HeaderFooterResponse));
        }

        /// <summary>
        /// Reads HeaderFooter objects from the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderFootersRequest" /></param>
        /// <returns><see cref="HeaderFootersResponse" /></returns>
        public HeaderFootersResponse GetHeaderFooters(GetHeaderFootersRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (HeaderFootersResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(HeaderFootersResponse));
        }

        /// <summary>
        /// Reads a list from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetListRequest" /></param>
        /// <returns><see cref="ListResponse" /></returns>
        public ListResponse GetList(GetListRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ListResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ListResponse));
        }

        /// <summary>
        /// Reads lists from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetListsRequest" /></param>
        /// <returns><see cref="ListsResponse" /></returns>
        public ListsResponse GetLists(GetListsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ListsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ListsResponse));
        }

        /// <summary>
        /// Reads an OfficeMath object from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetOfficeMathObjectRequest" /></param>
        /// <returns><see cref="OfficeMathObjectResponse" /></returns>
        public OfficeMathObjectResponse GetOfficeMathObject(GetOfficeMathObjectRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (OfficeMathObjectResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(OfficeMathObjectResponse));
        }

        /// <summary>
        /// Reads OfficeMath objects from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetOfficeMathObjectsRequest" /></param>
        /// <returns><see cref="OfficeMathObjectsResponse" /></returns>
        public OfficeMathObjectsResponse GetOfficeMathObjects(GetOfficeMathObjectsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (OfficeMathObjectsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(OfficeMathObjectsResponse));
        }

        /// <summary>
        /// Reads a paragraph from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphRequest" /></param>
        /// <returns><see cref="ParagraphResponse" /></returns>
        public ParagraphResponse GetParagraph(GetParagraphRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ParagraphResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ParagraphResponse));
        }

        /// <summary>
        /// Reads the formatting properties of a paragraph from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphFormatRequest" /></param>
        /// <returns><see cref="ParagraphFormatResponse" /></returns>
        public ParagraphFormatResponse GetParagraphFormat(GetParagraphFormatRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ParagraphFormatResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ParagraphFormatResponse));
        }

        /// <summary>
        /// Reads the formatting properties of a paragraph list from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphListFormatRequest" /></param>
        /// <returns><see cref="ParagraphListFormatResponse" /></returns>
        public ParagraphListFormatResponse GetParagraphListFormat(GetParagraphListFormatRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ParagraphListFormatResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ParagraphListFormatResponse));
        }

        /// <summary>
        /// Reads paragraphs from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphsRequest" /></param>
        /// <returns><see cref="ParagraphLinkCollectionResponse" /></returns>
        public ParagraphLinkCollectionResponse GetParagraphs(GetParagraphsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ParagraphLinkCollectionResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ParagraphLinkCollectionResponse));
        }

        /// <summary>
        /// Reads paragraph tab stops from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphTabStopsRequest" /></param>
        /// <returns><see cref="TabStopsResponse" /></returns>
        public TabStopsResponse GetParagraphTabStops(GetParagraphTabStopsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TabStopsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TabStopsResponse));
        }

        /// <summary>
        /// Reads range text from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRangeTextRequest" /></param>
        /// <returns><see cref="RangeTextResponse" /></returns>
        public RangeTextResponse GetRangeText(GetRangeTextRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (RangeTextResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(RangeTextResponse));
        }

        /// <summary>
        /// Reads a Run object from the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRunRequest" /></param>
        /// <returns><see cref="RunResponse" /></returns>
        public RunResponse GetRun(GetRunRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (RunResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(RunResponse));
        }

        /// <summary>
        /// Reads the font properties of a Run object from the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRunFontRequest" /></param>
        /// <returns><see cref="FontResponse" /></returns>
        public FontResponse GetRunFont(GetRunFontRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FontResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FontResponse));
        }

        /// <summary>
        /// Reads Run objects from the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRunsRequest" /></param>
        /// <returns><see cref="RunsResponse" /></returns>
        public RunsResponse GetRuns(GetRunsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (RunsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(RunsResponse));
        }

        /// <summary>
        /// Reads a section from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetSectionRequest" /></param>
        /// <returns><see cref="SectionResponse" /></returns>
        public SectionResponse GetSection(GetSectionRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (SectionResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(SectionResponse));
        }

        /// <summary>
        /// Reads the page setup of a section from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetSectionPageSetupRequest" /></param>
        /// <returns><see cref="SectionPageSetupResponse" /></returns>
        public SectionPageSetupResponse GetSectionPageSetup(GetSectionPageSetupRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (SectionPageSetupResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(SectionPageSetupResponse));
        }

        /// <summary>
        /// Reads sections from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetSectionsRequest" /></param>
        /// <returns><see cref="SectionLinkCollectionResponse" /></returns>
        public SectionLinkCollectionResponse GetSections(GetSectionsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (SectionLinkCollectionResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(SectionLinkCollectionResponse));
        }

        /// <summary>
        /// Reads a style from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetStyleRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public StyleResponse GetStyle(GetStyleRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (StyleResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(StyleResponse));
        }

        /// <summary>
        /// Reads a style from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetStyleFromDocumentElementRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public StyleResponse GetStyleFromDocumentElement(GetStyleFromDocumentElementRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (StyleResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(StyleResponse));
        }

        /// <summary>
        /// Reads styles from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetStylesRequest" /></param>
        /// <returns><see cref="StylesResponse" /></returns>
        public StylesResponse GetStyles(GetStylesRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (StylesResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(StylesResponse));
        }

        /// <summary>
        /// Reads a table from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableRequest" /></param>
        /// <returns><see cref="TableResponse" /></returns>
        public TableResponse GetTable(GetTableRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TableResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TableResponse));
        }

        /// <summary>
        /// Reads a cell from the table row.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableCellRequest" /></param>
        /// <returns><see cref="TableCellResponse" /></returns>
        public TableCellResponse GetTableCell(GetTableCellRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TableCellResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TableCellResponse));
        }

        /// <summary>
        /// Reads the formatting properties of a table cell.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableCellFormatRequest" /></param>
        /// <returns><see cref="TableCellFormatResponse" /></returns>
        public TableCellFormatResponse GetTableCellFormat(GetTableCellFormatRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TableCellFormatResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TableCellFormatResponse));
        }

        /// <summary>
        /// Reads properties of a table from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTablePropertiesRequest" /></param>
        /// <returns><see cref="TablePropertiesResponse" /></returns>
        public TablePropertiesResponse GetTableProperties(GetTablePropertiesRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TablePropertiesResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TablePropertiesResponse));
        }

        /// <summary>
        /// Reads a row from the table.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableRowRequest" /></param>
        /// <returns><see cref="TableRowResponse" /></returns>
        public TableRowResponse GetTableRow(GetTableRowRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TableRowResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TableRowResponse));
        }

        /// <summary>
        /// Reads the formatting properties of a table row.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableRowFormatRequest" /></param>
        /// <returns><see cref="TableRowFormatResponse" /></returns>
        public TableRowFormatResponse GetTableRowFormat(GetTableRowFormatRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TableRowFormatResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TableRowFormatResponse));
        }

        /// <summary>
        /// Reads tables from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTablesRequest" /></param>
        /// <returns><see cref="TableLinkCollectionResponse" /></returns>
        public TableLinkCollectionResponse GetTables(GetTablesRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TableLinkCollectionResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TableLinkCollectionResponse));
        }

        /// <summary>
        /// Inserts a new comment to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertCommentRequest" /></param>
        /// <returns><see cref="CommentResponse" /></returns>
        public CommentResponse InsertComment(InsertCommentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (CommentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(CommentResponse));
        }

        /// <summary>
        /// Inserts a new DrawingObject to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertDrawingObjectRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse" /></returns>
        public DrawingObjectResponse InsertDrawingObject(InsertDrawingObjectRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DrawingObjectResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DrawingObjectResponse));
        }

        /// <summary>
        /// Inserts a new field to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFieldRequest" /></param>
        /// <returns><see cref="FieldResponse" /></returns>
        public FieldResponse InsertField(InsertFieldRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FieldResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FieldResponse));
        }

        /// <summary>
        /// Inserts a new footnote to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFootnoteRequest" /></param>
        /// <returns><see cref="FootnoteResponse" /></returns>
        public FootnoteResponse InsertFootnote(InsertFootnoteRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FootnoteResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FootnoteResponse));
        }

        /// <summary>
        /// Inserts a new form field to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFormFieldRequest" /></param>
        /// <returns><see cref="FormFieldResponse" /></returns>
        public FormFieldResponse InsertFormField(InsertFormFieldRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FormFieldResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FormFieldResponse));
        }

        /// <summary>
        /// Inserts a new HeaderFooter object to the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertHeaderFooterRequest" /></param>
        /// <returns><see cref="HeaderFooterResponse" /></returns>
        public HeaderFooterResponse InsertHeaderFooter(InsertHeaderFooterRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (HeaderFooterResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(HeaderFooterResponse));
        }

        /// <summary>
        /// Inserts a new list to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertListRequest" /></param>
        /// <returns><see cref="ListResponse" /></returns>
        public ListResponse InsertList(InsertListRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ListResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ListResponse));
        }

        /// <summary>
        /// Inserts a new or updates an existing paragraph tab stop in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertOrUpdateParagraphTabStopRequest" /></param>
        /// <returns><see cref="TabStopsResponse" /></returns>
        public TabStopsResponse InsertOrUpdateParagraphTabStop(InsertOrUpdateParagraphTabStopRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TabStopsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TabStopsResponse));
        }

        /// <summary>
        /// Inserts page numbers to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertPageNumbersRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse InsertPageNumbers(InsertPageNumbersRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Inserts a new paragraph to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertParagraphRequest" /></param>
        /// <returns><see cref="ParagraphResponse" /></returns>
        public ParagraphResponse InsertParagraph(InsertParagraphRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ParagraphResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ParagraphResponse));
        }

        /// <summary>
        /// Inserts a new Run object to the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertRunRequest" /></param>
        /// <returns><see cref="RunResponse" /></returns>
        public RunResponse InsertRun(InsertRunRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (RunResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(RunResponse));
        }

        /// <summary>
        /// Inserts a new style to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertStyleRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public StyleResponse InsertStyle(InsertStyleRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (StyleResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(StyleResponse));
        }

        /// <summary>
        /// Inserts a new table to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableRequest" /></param>
        /// <returns><see cref="TableResponse" /></returns>
        public TableResponse InsertTable(InsertTableRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TableResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TableResponse));
        }

        /// <summary>
        /// Inserts a new cell to the table row.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableCellRequest" /></param>
        /// <returns><see cref="TableCellResponse" /></returns>
        public TableCellResponse InsertTableCell(InsertTableCellRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TableCellResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TableCellResponse));
        }

        /// <summary>
        /// Inserts a new row to the table.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableRowRequest" /></param>
        /// <returns><see cref="TableRowResponse" /></returns>
        public TableRowResponse InsertTableRow(InsertTableRowRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TableRowResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TableRowResponse));
        }

        /// <summary>
        /// Inserts a new watermark image to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertWatermarkImageRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse InsertWatermarkImage(InsertWatermarkImageRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Inserts a new watermark text to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertWatermarkTextRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse InsertWatermarkText(InsertWatermarkTextRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Downloads a document from the Web using URL and saves it to cloud storage in the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="LoadWebDocumentRequest" /></param>
        /// <returns><see cref="SaveResponse" /></returns>
        public SaveResponse LoadWebDocument(LoadWebDocumentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (SaveResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(SaveResponse));
        }

        /// <summary>
        /// Move file.
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFileRequest" /></param>
        public void MoveFile(MoveFileRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Move folder.
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFolderRequest" /></param>
        public void MoveFolder(MoveFolderRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Applies document content optimization options, specific to a particular versions of Microsoft Word.
        /// </summary>
        /// <param name="request">Request. <see cref="OptimizeDocumentRequest" /></param>
        public void OptimizeDocument(OptimizeDocumentRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Adds protection to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="ProtectDocumentRequest" /></param>
        /// <returns><see cref="ProtectionDataResponse" /></returns>
        public ProtectionDataResponse ProtectDocument(ProtectDocumentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ProtectionDataResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ProtectionDataResponse));
        }

        /// <summary>
        /// Rejects all revisions in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="RejectAllRevisionsRequest" /></param>
        /// <returns><see cref="RevisionsModificationResponse" /></returns>
        public RevisionsModificationResponse RejectAllRevisions(RejectAllRevisionsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (RevisionsModificationResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(RevisionsModificationResponse));
        }

        /// <summary>
        /// Removes a range from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="RemoveRangeRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse RemoveRange(RemoveRangeRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Renders a DrawingObject to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderDrawingObjectRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream RenderDrawingObject(RenderDrawingObjectRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Renders an OfficeMath object to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderMathObjectRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream RenderMathObject(RenderMathObjectRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Renders a page to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderPageRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream RenderPage(RenderPageRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Renders a paragraph to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderParagraphRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream RenderParagraph(RenderParagraphRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Renders a table to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderTableRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream RenderTable(RenderTableRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Replaces text in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="ReplaceTextRequest" /></param>
        /// <returns><see cref="ReplaceTextResponse" /></returns>
        public ReplaceTextResponse ReplaceText(ReplaceTextRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ReplaceTextResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ReplaceTextResponse));
        }

        /// <summary>
        /// Replaces a range with text in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="ReplaceWithTextRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse ReplaceWithText(ReplaceWithTextRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Clears the font cache.
        /// </summary>
        /// <param name="request">Request. <see cref="ResetCacheRequest" /></param>
        public void ResetCache(ResetCacheRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Converts a document in cloud storage to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="SaveAsRequest" /></param>
        /// <returns><see cref="SaveResponse" /></returns>
        public SaveResponse SaveAs(SaveAsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (SaveResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(SaveResponse));
        }

        /// <summary>
        /// Saves a range as a new document.
        /// </summary>
        /// <param name="request">Request. <see cref="SaveAsRangeRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse SaveAsRange(SaveAsRangeRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Converts a document in cloud storage to TIFF format using detailed conversion settings.
        /// </summary>
        /// <param name="request">Request. <see cref="SaveAsTiffRequest" /></param>
        /// <returns><see cref="SaveResponse" /></returns>
        public SaveResponse SaveAsTiff(SaveAsTiffRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (SaveResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(SaveResponse));
        }

        /// <summary>
        /// Searches text, specified by the regular expression, in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="SearchRequest" /></param>
        /// <returns><see cref="SearchResponse" /></returns>
        public SearchResponse Search(SearchRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (SearchResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(SearchResponse));
        }

        /// <summary>
        /// Splits a document into parts and saves them in the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="SplitDocumentRequest" /></param>
        /// <returns><see cref="SplitDocumentResponse" /></returns>
        public SplitDocumentResponse SplitDocument(SplitDocumentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (SplitDocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(SplitDocumentResponse));
        }

        /// <summary>
        /// Removes protection from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UnprotectDocumentRequest" /></param>
        /// <returns><see cref="ProtectionDataResponse" /></returns>
        public ProtectionDataResponse UnprotectDocument(UnprotectDocumentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ProtectionDataResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ProtectionDataResponse));
        }

        /// <summary>
        /// Updates a bookmark in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateBookmarkRequest" /></param>
        /// <returns><see cref="BookmarkResponse" /></returns>
        public BookmarkResponse UpdateBookmark(UpdateBookmarkRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (BookmarkResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(BookmarkResponse));
        }

        /// <summary>
        /// The 'nodePath' parameter should refer to a paragraph, a cell or a row.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateBorderRequest" /></param>
        /// <returns><see cref="BorderResponse" /></returns>
        public BorderResponse UpdateBorder(UpdateBorderRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (BorderResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(BorderResponse));
        }

        /// <summary>
        /// Updates a comment in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateCommentRequest" /></param>
        /// <returns><see cref="CommentResponse" /></returns>
        public CommentResponse UpdateComment(UpdateCommentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (CommentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(CommentResponse));
        }

        /// <summary>
        /// Updates a DrawingObject in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateDrawingObjectRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse" /></returns>
        public DrawingObjectResponse UpdateDrawingObject(UpdateDrawingObjectRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DrawingObjectResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DrawingObjectResponse));
        }

        /// <summary>
        /// Updates a field in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFieldRequest" /></param>
        /// <returns><see cref="FieldResponse" /></returns>
        public FieldResponse UpdateField(UpdateFieldRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FieldResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FieldResponse));
        }

        /// <summary>
        /// Reevaluates field values in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFieldsRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse UpdateFields(UpdateFieldsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Updates a footnote in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFootnoteRequest" /></param>
        /// <returns><see cref="FootnoteResponse" /></returns>
        public FootnoteResponse UpdateFootnote(UpdateFootnoteRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FootnoteResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FootnoteResponse));
        }

        /// <summary>
        /// Updates a form field in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFormFieldRequest" /></param>
        /// <returns><see cref="FormFieldResponse" /></returns>
        public FormFieldResponse UpdateFormField(UpdateFormFieldRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FormFieldResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FormFieldResponse));
        }

        /// <summary>
        /// Updates a list in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateListRequest" /></param>
        /// <returns><see cref="ListResponse" /></returns>
        public ListResponse UpdateList(UpdateListRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ListResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ListResponse));
        }

        /// <summary>
        /// Updates the level of a List element in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateListLevelRequest" /></param>
        /// <returns><see cref="ListResponse" /></returns>
        public ListResponse UpdateListLevel(UpdateListLevelRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ListResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ListResponse));
        }

        /// <summary>
        /// Updates the formatting properties of a paragraph in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateParagraphFormatRequest" /></param>
        /// <returns><see cref="ParagraphFormatResponse" /></returns>
        public ParagraphFormatResponse UpdateParagraphFormat(UpdateParagraphFormatRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ParagraphFormatResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ParagraphFormatResponse));
        }

        /// <summary>
        /// Updates the formatting properties of a paragraph list in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateParagraphListFormatRequest" /></param>
        /// <returns><see cref="ParagraphListFormatResponse" /></returns>
        public ParagraphListFormatResponse UpdateParagraphListFormat(UpdateParagraphListFormatRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ParagraphListFormatResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ParagraphListFormatResponse));
        }

        /// <summary>
        /// Updates a Run object in the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateRunRequest" /></param>
        /// <returns><see cref="RunResponse" /></returns>
        public RunResponse UpdateRun(UpdateRunRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (RunResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(RunResponse));
        }

        /// <summary>
        /// Updates the font properties of a Run object in the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateRunFontRequest" /></param>
        /// <returns><see cref="FontResponse" /></returns>
        public FontResponse UpdateRunFont(UpdateRunFontRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FontResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FontResponse));
        }

        /// <summary>
        /// Updates the page setup of a section in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateSectionPageSetupRequest" /></param>
        /// <returns><see cref="SectionPageSetupResponse" /></returns>
        public SectionPageSetupResponse UpdateSectionPageSetup(UpdateSectionPageSetupRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (SectionPageSetupResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(SectionPageSetupResponse));
        }

        /// <summary>
        /// Updates a style in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateStyleRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public StyleResponse UpdateStyle(UpdateStyleRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (StyleResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(StyleResponse));
        }

        /// <summary>
        /// Updates the formatting properties of a cell in the table row.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTableCellFormatRequest" /></param>
        /// <returns><see cref="TableCellFormatResponse" /></returns>
        public TableCellFormatResponse UpdateTableCellFormat(UpdateTableCellFormatRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TableCellFormatResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TableCellFormatResponse));
        }

        /// <summary>
        /// Updates properties of a table in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTablePropertiesRequest" /></param>
        /// <returns><see cref="TablePropertiesResponse" /></returns>
        public TablePropertiesResponse UpdateTableProperties(UpdateTablePropertiesRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TablePropertiesResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TablePropertiesResponse));
        }

        /// <summary>
        /// Updates the formatting properties of a table row.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTableRowFormatRequest" /></param>
        /// <returns><see cref="TableRowFormatResponse" /></returns>
        public TableRowFormatResponse UpdateTableRowFormat(UpdateTableRowFormatRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TableRowFormatResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TableRowFormatResponse));
        }

        /// <summary>
        /// Upload file.
        /// </summary>
        /// <param name="request">Request. <see cref="UploadFileRequest" /></param>
        /// <returns><see cref="FilesUploadResult" /></returns>
        public FilesUploadResult UploadFile(UploadFileRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FilesUploadResult)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FilesUploadResult));
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

            var responseTypes = new System.Type[requests.Length];
            for (int i = 0; i < requests.Length; i++)
            {
                responseTypes[i] = requests[i].GetResponseType();
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
                    var responsePartType = responseTypes[i];
                    if (responsePartType == null)
                    {
                        result[i] = null;
                    }
                    else if (responsePartType == typeof(System.IO.Stream))
                    {
                        result[i] = responsePart.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
                    }
                    else
                    {
                        result[i] = SerializationHelper.Deserialize(responsePart.Content.ReadAsStringAsync().GetAwaiter().GetResult(), responsePartType);
                    }
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
