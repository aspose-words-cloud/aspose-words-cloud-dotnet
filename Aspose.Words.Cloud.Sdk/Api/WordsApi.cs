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
        /// Accepts all revisions in document.
        /// </summary>
        /// <param name="request">Request. <see cref="AcceptAllRevisionsRequest" /></param>
        /// <returns><see cref="RevisionsModificationResponse" /></returns>
        public RevisionsModificationResponse AcceptAllRevisions(AcceptAllRevisionsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (RevisionsModificationResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(RevisionsModificationResponse));
        }

        /// <summary>
        /// Appends documents to original document.
        /// </summary>
        /// <param name="request">Request. <see cref="AppendDocumentRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse AppendDocument(AppendDocumentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Apply a style to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="ApplyStyleToDocumentElementRequest" /></param>
        /// <returns><see cref="WordsResponse" /></returns>
        public WordsResponse ApplyStyleToDocumentElement(ApplyStyleToDocumentElementRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (WordsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(WordsResponse));
        }

        /// <summary>
        /// Executes document "build report" operation.
        /// </summary>
        /// <param name="request">Request. <see cref="BuildReportRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse BuildReport(BuildReportRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Executes document "build report" online operation.
        /// </summary>
        /// <param name="request">Request. <see cref="BuildReportOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream BuildReportOnline(BuildReportOnlineRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Classifies raw text.
        /// </summary>
        /// <param name="request">Request. <see cref="ClassifyRequest" /></param>
        /// <returns><see cref="ClassificationResponse" /></returns>
        public ClassificationResponse Classify(ClassifyRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ClassificationResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ClassificationResponse));
        }

        /// <summary>
        /// Classifies document.
        /// </summary>
        /// <param name="request">Request. <see cref="ClassifyDocumentRequest" /></param>
        /// <returns><see cref="ClassificationResponse" /></returns>
        public ClassificationResponse ClassifyDocument(ClassifyDocumentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ClassificationResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ClassificationResponse));
        }

        /// <summary>
        /// Compares document with original document.
        /// </summary>
        /// <param name="request">Request. <see cref="CompareDocumentRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse CompareDocument(CompareDocumentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Converts document from the request's content to the specified format.
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
        /// Copy and insert a new style to the document, returns a copied style.
        /// </summary>
        /// <param name="request">Request. <see cref="CopyStyleRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public StyleResponse CopyStyle(CopyStyleRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (StyleResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(StyleResponse));
        }

        /// <summary>
        /// Creates new document.
        /// Document is created with format which is recognized from file extensions.
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
        /// Adds new or update existing document property.
        /// </summary>
        /// <param name="request">Request. <see cref="CreateOrUpdateDocumentPropertyRequest" /></param>
        /// <returns><see cref="DocumentPropertyResponse" /></returns>
        public DocumentPropertyResponse CreateOrUpdateDocumentProperty(CreateOrUpdateDocumentPropertyRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentPropertyResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentPropertyResponse));
        }

        /// <summary>
        /// Remove all tab stops.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteAllParagraphTabStopsRequest" /></param>
        /// <returns><see cref="TabStopsResponse" /></returns>
        public TabStopsResponse DeleteAllParagraphTabStops(DeleteAllParagraphTabStopsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TabStopsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TabStopsResponse));
        }

        /// <summary>
        /// 'nodePath' should refer to paragraph, cell or row.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteBorderRequest" /></param>
        /// <returns><see cref="BorderResponse" /></returns>
        public BorderResponse DeleteBorder(DeleteBorderRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (BorderResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(BorderResponse));
        }

        /// <summary>
        /// 'nodePath' should refer to paragraph, cell or row.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteBordersRequest" /></param>
        /// <returns><see cref="BordersResponse" /></returns>
        public BordersResponse DeleteBorders(DeleteBordersRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (BordersResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(BordersResponse));
        }

        /// <summary>
        /// Removes comment from document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteCommentRequest" /></param>
        public void DeleteComment(DeleteCommentRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Deletes document property.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDocumentPropertyRequest" /></param>
        public void DeleteDocumentProperty(DeleteDocumentPropertyRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes drawing object from document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDrawingObjectRequest" /></param>
        public void DeleteDrawingObject(DeleteDrawingObjectRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Deletes field from document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFieldRequest" /></param>
        public void DeleteField(DeleteFieldRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes fields from section paragraph.
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
        /// Removes footnote from document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFootnoteRequest" /></param>
        public void DeleteFootnote(DeleteFootnoteRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes form field from document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFormFieldRequest" /></param>
        public void DeleteFormField(DeleteFormFieldRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Deletes header/footer from document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHeaderFooterRequest" /></param>
        public void DeleteHeaderFooter(DeleteHeaderFooterRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Deletes document headers and footers.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHeadersFootersRequest" /></param>
        public void DeleteHeadersFooters(DeleteHeadersFootersRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes macros from document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteMacrosRequest" /></param>
        public void DeleteMacros(DeleteMacrosRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes OfficeMath object from document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteOfficeMathObjectRequest" /></param>
        public void DeleteOfficeMathObject(DeleteOfficeMathObjectRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes paragraph from section.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphRequest" /></param>
        public void DeleteParagraph(DeleteParagraphRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Delete paragraph list format, returns updated list format properties.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphListFormatRequest" /></param>
        /// <returns><see cref="ParagraphListFormatResponse" /></returns>
        public ParagraphListFormatResponse DeleteParagraphListFormat(DeleteParagraphListFormatRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ParagraphListFormatResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ParagraphListFormatResponse));
        }

        /// <summary>
        /// Remove the i-th tab stop.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphTabStopRequest" /></param>
        /// <returns><see cref="TabStopsResponse" /></returns>
        public TabStopsResponse DeleteParagraphTabStop(DeleteParagraphTabStopRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TabStopsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TabStopsResponse));
        }

        /// <summary>
        /// Removes run from document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteRunRequest" /></param>
        public void DeleteRun(DeleteRunRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Removes section from document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSectionRequest" /></param>
        public void DeleteSection(DeleteSectionRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Deletes a table.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableRequest" /></param>
        public void DeleteTable(DeleteTableRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Deletes a table cell.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableCellRequest" /></param>
        public void DeleteTableCell(DeleteTableCellRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Deletes a table row.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableRowRequest" /></param>
        public void DeleteTableRow(DeleteTableRowRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Deletes watermark (for deleting last watermark from the document).
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
        /// Executes document mail merge operation.
        /// </summary>
        /// <param name="request">Request. <see cref="ExecuteMailMergeRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse ExecuteMailMerge(ExecuteMailMergeRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Executes document mail merge online.
        /// </summary>
        /// <param name="request">Request. <see cref="ExecuteMailMergeOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream ExecuteMailMergeOnline(ExecuteMailMergeOnlineRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the list of fonts, available for document processing.
        /// </summary>
        /// <param name="request">Request. <see cref="GetAvailableFontsRequest" /></param>
        /// <returns><see cref="AvailableFontsResponse" /></returns>
        public AvailableFontsResponse GetAvailableFonts(GetAvailableFontsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (AvailableFontsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(AvailableFontsResponse));
        }

        /// <summary>
        /// Reads document bookmark data by its name.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBookmarkByNameRequest" /></param>
        /// <returns><see cref="BookmarkResponse" /></returns>
        public BookmarkResponse GetBookmarkByName(GetBookmarkByNameRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (BookmarkResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(BookmarkResponse));
        }

        /// <summary>
        /// Reads document bookmarks common info.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBookmarksRequest" /></param>
        /// <returns><see cref="BookmarksResponse" /></returns>
        public BookmarksResponse GetBookmarks(GetBookmarksRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (BookmarksResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(BookmarksResponse));
        }

        /// <summary>
        /// 'nodePath' should refer to paragraph, cell or row.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBorderRequest" /></param>
        /// <returns><see cref="BorderResponse" /></returns>
        public BorderResponse GetBorder(GetBorderRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (BorderResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(BorderResponse));
        }

        /// <summary>
        /// 'nodePath' should refer to paragraph, cell or row.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBordersRequest" /></param>
        /// <returns><see cref="BordersResponse" /></returns>
        public BordersResponse GetBorders(GetBordersRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (BordersResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(BordersResponse));
        }

        /// <summary>
        /// Gets comment from document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetCommentRequest" /></param>
        /// <returns><see cref="CommentResponse" /></returns>
        public CommentResponse GetComment(GetCommentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (CommentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(CommentResponse));
        }

        /// <summary>
        /// Gets comments from document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetCommentsRequest" /></param>
        /// <returns><see cref="CommentsResponse" /></returns>
        public CommentsResponse GetComments(GetCommentsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (CommentsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(CommentsResponse));
        }

        /// <summary>
        /// Reads document common info.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse GetDocument(GetDocumentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Reads document drawing object common info by its index or convert to format specified.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectByIndexRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse" /></returns>
        public DrawingObjectResponse GetDocumentDrawingObjectByIndex(GetDocumentDrawingObjectByIndexRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DrawingObjectResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DrawingObjectResponse));
        }

        /// <summary>
        /// Reads drawing object image data.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectImageDataRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream GetDocumentDrawingObjectImageData(GetDocumentDrawingObjectImageDataRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets drawing object OLE data.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectOleDataRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream GetDocumentDrawingObjectOleData(GetDocumentDrawingObjectOleDataRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Reads document drawing objects common info.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectsRequest" /></param>
        /// <returns><see cref="DrawingObjectsResponse" /></returns>
        public DrawingObjectsResponse GetDocumentDrawingObjects(GetDocumentDrawingObjectsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DrawingObjectsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DrawingObjectsResponse));
        }

        /// <summary>
        /// Reads document field names.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentFieldNamesRequest" /></param>
        /// <returns><see cref="FieldNamesResponse" /></returns>
        public FieldNamesResponse GetDocumentFieldNames(GetDocumentFieldNamesRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FieldNamesResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FieldNamesResponse));
        }

        /// <summary>
        /// Reads document field names.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentFieldNamesOnlineRequest" /></param>
        /// <returns><see cref="FieldNamesResponse" /></returns>
        public FieldNamesResponse GetDocumentFieldNamesOnline(GetDocumentFieldNamesOnlineRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FieldNamesResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FieldNamesResponse));
        }

        /// <summary>
        /// Reads document hyperlink by its index.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentHyperlinkByIndexRequest" /></param>
        /// <returns><see cref="HyperlinkResponse" /></returns>
        public HyperlinkResponse GetDocumentHyperlinkByIndex(GetDocumentHyperlinkByIndexRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (HyperlinkResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(HyperlinkResponse));
        }

        /// <summary>
        /// Reads document hyperlinks common info.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentHyperlinksRequest" /></param>
        /// <returns><see cref="HyperlinksResponse" /></returns>
        public HyperlinksResponse GetDocumentHyperlinks(GetDocumentHyperlinksRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (HyperlinksResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(HyperlinksResponse));
        }

        /// <summary>
        /// Reads document properties info.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentPropertiesRequest" /></param>
        /// <returns><see cref="DocumentPropertiesResponse" /></returns>
        public DocumentPropertiesResponse GetDocumentProperties(GetDocumentPropertiesRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentPropertiesResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentPropertiesResponse));
        }

        /// <summary>
        /// Reads document property info by the property name.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentPropertyRequest" /></param>
        /// <returns><see cref="DocumentPropertyResponse" /></returns>
        public DocumentPropertyResponse GetDocumentProperty(GetDocumentPropertyRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentPropertyResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentPropertyResponse));
        }

        /// <summary>
        /// Reads document protection common info.
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
        /// Exports the document into the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentWithFormatRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream GetDocumentWithFormat(GetDocumentWithFormatRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets field from document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFieldRequest" /></param>
        /// <returns><see cref="FieldResponse" /></returns>
        public FieldResponse GetField(GetFieldRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FieldResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FieldResponse));
        }

        /// <summary>
        /// Get fields from document.
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
        /// Reads footnote by index.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFootnoteRequest" /></param>
        /// <returns><see cref="FootnoteResponse" /></returns>
        public FootnoteResponse GetFootnote(GetFootnoteRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FootnoteResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FootnoteResponse));
        }

        /// <summary>
        /// Gets footnotes from document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFootnotesRequest" /></param>
        /// <returns><see cref="FootnotesResponse" /></returns>
        public FootnotesResponse GetFootnotes(GetFootnotesRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FootnotesResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FootnotesResponse));
        }

        /// <summary>
        /// Returns representation of an one of the form field.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFormFieldRequest" /></param>
        /// <returns><see cref="FormFieldResponse" /></returns>
        public FormFieldResponse GetFormField(GetFormFieldRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FormFieldResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FormFieldResponse));
        }

        /// <summary>
        /// Gets form fields from document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFormFieldsRequest" /></param>
        /// <returns><see cref="FormFieldsResponse" /></returns>
        public FormFieldsResponse GetFormFields(GetFormFieldsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FormFieldsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FormFieldsResponse));
        }

        /// <summary>
        /// Returns a header/footer from the document by index.
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderFooterRequest" /></param>
        /// <returns><see cref="HeaderFooterResponse" /></returns>
        public HeaderFooterResponse GetHeaderFooter(GetHeaderFooterRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (HeaderFooterResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(HeaderFooterResponse));
        }

        /// <summary>
        /// Returns a header/footer from the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderFooterOfSectionRequest" /></param>
        /// <returns><see cref="HeaderFooterResponse" /></returns>
        public HeaderFooterResponse GetHeaderFooterOfSection(GetHeaderFooterOfSectionRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (HeaderFooterResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(HeaderFooterResponse));
        }

        /// <summary>
        /// Returns a list of header/footers from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderFootersRequest" /></param>
        /// <returns><see cref="HeaderFootersResponse" /></returns>
        public HeaderFootersResponse GetHeaderFooters(GetHeaderFootersRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (HeaderFootersResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(HeaderFootersResponse));
        }

        /// <summary>
        /// This resource represents one of the lists contained in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetListRequest" /></param>
        /// <returns><see cref="ListResponse" /></returns>
        public ListResponse GetList(GetListRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ListResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ListResponse));
        }

        /// <summary>
        /// Returns a list of lists that are contained in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetListsRequest" /></param>
        /// <returns><see cref="ListsResponse" /></returns>
        public ListsResponse GetLists(GetListsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ListsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ListsResponse));
        }

        /// <summary>
        /// Reads OfficeMath object by index.
        /// </summary>
        /// <param name="request">Request. <see cref="GetOfficeMathObjectRequest" /></param>
        /// <returns><see cref="OfficeMathObjectResponse" /></returns>
        public OfficeMathObjectResponse GetOfficeMathObject(GetOfficeMathObjectRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (OfficeMathObjectResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(OfficeMathObjectResponse));
        }

        /// <summary>
        /// Gets OfficeMath objects from document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetOfficeMathObjectsRequest" /></param>
        /// <returns><see cref="OfficeMathObjectsResponse" /></returns>
        public OfficeMathObjectsResponse GetOfficeMathObjects(GetOfficeMathObjectsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (OfficeMathObjectsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(OfficeMathObjectsResponse));
        }

        /// <summary>
        /// This resource represents one of the paragraphs contained in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphRequest" /></param>
        /// <returns><see cref="ParagraphResponse" /></returns>
        public ParagraphResponse GetParagraph(GetParagraphRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ParagraphResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ParagraphResponse));
        }

        /// <summary>
        /// Represents all the formatting for a paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphFormatRequest" /></param>
        /// <returns><see cref="ParagraphFormatResponse" /></returns>
        public ParagraphFormatResponse GetParagraphFormat(GetParagraphFormatRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ParagraphFormatResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ParagraphFormatResponse));
        }

        /// <summary>
        /// Represents list format for a paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphListFormatRequest" /></param>
        /// <returns><see cref="ParagraphListFormatResponse" /></returns>
        public ParagraphListFormatResponse GetParagraphListFormat(GetParagraphListFormatRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ParagraphListFormatResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ParagraphListFormatResponse));
        }

        /// <summary>
        /// Returns a list of paragraphs that are contained in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphsRequest" /></param>
        /// <returns><see cref="ParagraphLinkCollectionResponse" /></returns>
        public ParagraphLinkCollectionResponse GetParagraphs(GetParagraphsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ParagraphLinkCollectionResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ParagraphLinkCollectionResponse));
        }

        /// <summary>
        /// Get all tab stops for the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphTabStopsRequest" /></param>
        /// <returns><see cref="TabStopsResponse" /></returns>
        public TabStopsResponse GetParagraphTabStops(GetParagraphTabStopsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TabStopsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TabStopsResponse));
        }

        /// <summary>
        /// Gets the text from the range.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRangeTextRequest" /></param>
        /// <returns><see cref="RangeTextResponse" /></returns>
        public RangeTextResponse GetRangeText(GetRangeTextRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (RangeTextResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(RangeTextResponse));
        }

        /// <summary>
        /// This resource represents run of text contained in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRunRequest" /></param>
        /// <returns><see cref="RunResponse" /></returns>
        public RunResponse GetRun(GetRunRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (RunResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(RunResponse));
        }

        /// <summary>
        /// This resource represents font of run.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRunFontRequest" /></param>
        /// <returns><see cref="FontResponse" /></returns>
        public FontResponse GetRunFont(GetRunFontRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FontResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FontResponse));
        }

        /// <summary>
        /// This resource represents collection of runs in the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRunsRequest" /></param>
        /// <returns><see cref="RunsResponse" /></returns>
        public RunsResponse GetRuns(GetRunsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (RunsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(RunsResponse));
        }

        /// <summary>
        /// Gets document section by index.
        /// </summary>
        /// <param name="request">Request. <see cref="GetSectionRequest" /></param>
        /// <returns><see cref="SectionResponse" /></returns>
        public SectionResponse GetSection(GetSectionRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (SectionResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(SectionResponse));
        }

        /// <summary>
        /// Gets page setup of section.
        /// </summary>
        /// <param name="request">Request. <see cref="GetSectionPageSetupRequest" /></param>
        /// <returns><see cref="SectionPageSetupResponse" /></returns>
        public SectionPageSetupResponse GetSectionPageSetup(GetSectionPageSetupRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (SectionPageSetupResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(SectionPageSetupResponse));
        }

        /// <summary>
        /// Returns a list of sections that are contained in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetSectionsRequest" /></param>
        /// <returns><see cref="SectionLinkCollectionResponse" /></returns>
        public SectionLinkCollectionResponse GetSections(GetSectionsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (SectionLinkCollectionResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(SectionLinkCollectionResponse));
        }

        /// <summary>
        /// This resource represents one of the styles contained in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetStyleRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public StyleResponse GetStyle(GetStyleRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (StyleResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(StyleResponse));
        }

        /// <summary>
        /// Gets a style from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetStyleFromDocumentElementRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public StyleResponse GetStyleFromDocumentElement(GetStyleFromDocumentElementRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (StyleResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(StyleResponse));
        }

        /// <summary>
        /// Returns a list of styles contained in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetStylesRequest" /></param>
        /// <returns><see cref="StylesResponse" /></returns>
        public StylesResponse GetStyles(GetStylesRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (StylesResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(StylesResponse));
        }

        /// <summary>
        /// Returns a table.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableRequest" /></param>
        /// <returns><see cref="TableResponse" /></returns>
        public TableResponse GetTable(GetTableRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TableResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TableResponse));
        }

        /// <summary>
        /// Returns a table cell.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableCellRequest" /></param>
        /// <returns><see cref="TableCellResponse" /></returns>
        public TableCellResponse GetTableCell(GetTableCellRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TableCellResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TableCellResponse));
        }

        /// <summary>
        /// Returns a table cell format.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableCellFormatRequest" /></param>
        /// <returns><see cref="TableCellFormatResponse" /></returns>
        public TableCellFormatResponse GetTableCellFormat(GetTableCellFormatRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TableCellFormatResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TableCellFormatResponse));
        }

        /// <summary>
        /// Returns a table properties.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTablePropertiesRequest" /></param>
        /// <returns><see cref="TablePropertiesResponse" /></returns>
        public TablePropertiesResponse GetTableProperties(GetTablePropertiesRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TablePropertiesResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TablePropertiesResponse));
        }

        /// <summary>
        /// Returns a table row.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableRowRequest" /></param>
        /// <returns><see cref="TableRowResponse" /></returns>
        public TableRowResponse GetTableRow(GetTableRowRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TableRowResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TableRowResponse));
        }

        /// <summary>
        /// Returns a table row format.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableRowFormatRequest" /></param>
        /// <returns><see cref="TableRowFormatResponse" /></returns>
        public TableRowFormatResponse GetTableRowFormat(GetTableRowFormatRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TableRowFormatResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TableRowFormatResponse));
        }

        /// <summary>
        /// Returns a list of tables that are contained in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTablesRequest" /></param>
        /// <returns><see cref="TableLinkCollectionResponse" /></returns>
        public TableLinkCollectionResponse GetTables(GetTablesRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TableLinkCollectionResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TableLinkCollectionResponse));
        }

        /// <summary>
        /// Adds comment to document, returns inserted comment data.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertCommentRequest" /></param>
        /// <returns><see cref="CommentResponse" /></returns>
        public CommentResponse InsertComment(InsertCommentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (CommentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(CommentResponse));
        }

        /// <summary>
        /// Adds drawing object to document, returns added  drawing object's data.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertDrawingObjectRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse" /></returns>
        public DrawingObjectResponse InsertDrawingObject(InsertDrawingObjectRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DrawingObjectResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DrawingObjectResponse));
        }

        /// <summary>
        /// Adds field to document, returns inserted field's data.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFieldRequest" /></param>
        /// <returns><see cref="FieldResponse" /></returns>
        public FieldResponse InsertField(InsertFieldRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FieldResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FieldResponse));
        }

        /// <summary>
        /// Adds footnote to document, returns added footnote's data.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFootnoteRequest" /></param>
        /// <returns><see cref="FootnoteResponse" /></returns>
        public FootnoteResponse InsertFootnote(InsertFootnoteRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FootnoteResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FootnoteResponse));
        }

        /// <summary>
        /// Adds form field to paragraph, returns added form field's data.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFormFieldRequest" /></param>
        /// <returns><see cref="FormFieldResponse" /></returns>
        public FormFieldResponse InsertFormField(InsertFormFieldRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FormFieldResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FormFieldResponse));
        }

        /// <summary>
        /// Inserts to document header or footer.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertHeaderFooterRequest" /></param>
        /// <returns><see cref="HeaderFooterResponse" /></returns>
        public HeaderFooterResponse InsertHeaderFooter(InsertHeaderFooterRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (HeaderFooterResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(HeaderFooterResponse));
        }

        /// <summary>
        /// Adds list to document, returns added list's data.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertListRequest" /></param>
        /// <returns><see cref="ListResponse" /></returns>
        public ListResponse InsertList(InsertListRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ListResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ListResponse));
        }

        /// <summary>
        /// Insert or resplace tab stop if a tab stop with the position exists.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertOrUpdateParagraphTabStopRequest" /></param>
        /// <returns><see cref="TabStopsResponse" /></returns>
        public TabStopsResponse InsertOrUpdateParagraphTabStop(InsertOrUpdateParagraphTabStopRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TabStopsResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TabStopsResponse));
        }

        /// <summary>
        /// Inserts document page numbers.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertPageNumbersRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse InsertPageNumbers(InsertPageNumbersRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Adds paragraph to document, returns added paragraph's data.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertParagraphRequest" /></param>
        /// <returns><see cref="ParagraphResponse" /></returns>
        public ParagraphResponse InsertParagraph(InsertParagraphRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ParagraphResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ParagraphResponse));
        }

        /// <summary>
        /// Adds run to document, returns added paragraph's data.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertRunRequest" /></param>
        /// <returns><see cref="RunResponse" /></returns>
        public RunResponse InsertRun(InsertRunRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (RunResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(RunResponse));
        }

        /// <summary>
        /// Adds a style to the document, returns an added style.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertStyleRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public StyleResponse InsertStyle(InsertStyleRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (StyleResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(StyleResponse));
        }

        /// <summary>
        /// Adds table to document, returns added table's data.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableRequest" /></param>
        /// <returns><see cref="TableResponse" /></returns>
        public TableResponse InsertTable(InsertTableRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TableResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TableResponse));
        }

        /// <summary>
        /// Adds table cell to table, returns added cell's data.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableCellRequest" /></param>
        /// <returns><see cref="TableCellResponse" /></returns>
        public TableCellResponse InsertTableCell(InsertTableCellRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TableCellResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TableCellResponse));
        }

        /// <summary>
        /// Adds table row to table, returns added row's data.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableRowRequest" /></param>
        /// <returns><see cref="TableRowResponse" /></returns>
        public TableRowResponse InsertTableRow(InsertTableRowRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TableRowResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TableRowResponse));
        }

        /// <summary>
        /// Inserts document watermark image.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertWatermarkImageRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse InsertWatermarkImage(InsertWatermarkImageRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Inserts document watermark text.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertWatermarkTextRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse InsertWatermarkText(InsertWatermarkTextRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Loads new document from web into the file with any supported format of data.
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
        /// Allows to optimize the document contents as well as default Aspose.Words behavior to a particular versions of MS Word.
        /// </summary>
        /// <param name="request">Request. <see cref="OptimizeDocumentRequest" /></param>
        public void OptimizeDocument(OptimizeDocumentRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Protects document.
        /// </summary>
        /// <param name="request">Request. <see cref="ProtectDocumentRequest" /></param>
        /// <returns><see cref="ProtectionDataResponse" /></returns>
        public ProtectionDataResponse ProtectDocument(ProtectDocumentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ProtectionDataResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ProtectionDataResponse));
        }

        /// <summary>
        /// Rejects all revisions in document.
        /// </summary>
        /// <param name="request">Request. <see cref="RejectAllRevisionsRequest" /></param>
        /// <returns><see cref="RevisionsModificationResponse" /></returns>
        public RevisionsModificationResponse RejectAllRevisions(RejectAllRevisionsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (RevisionsModificationResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(RevisionsModificationResponse));
        }

        /// <summary>
        /// Removes the range from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="RemoveRangeRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse RemoveRange(RemoveRangeRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Renders drawing object to specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderDrawingObjectRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream RenderDrawingObject(RenderDrawingObjectRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Renders math object to specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderMathObjectRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream RenderMathObject(RenderMathObjectRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Renders page to specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderPageRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream RenderPage(RenderPageRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Renders paragraph to specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderParagraphRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream RenderParagraph(RenderParagraphRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Renders table to specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderTableRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public System.IO.Stream RenderTable(RenderTableRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Replaces document text.
        /// </summary>
        /// <param name="request">Request. <see cref="ReplaceTextRequest" /></param>
        /// <returns><see cref="ReplaceTextResponse" /></returns>
        public ReplaceTextResponse ReplaceText(ReplaceTextRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ReplaceTextResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ReplaceTextResponse));
        }

        /// <summary>
        /// Replaces the content in the range.
        /// </summary>
        /// <param name="request">Request. <see cref="ReplaceWithTextRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse ReplaceWithText(ReplaceWithTextRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Resets font's cache.
        /// </summary>
        /// <param name="request">Request. <see cref="ResetCacheRequest" /></param>
        public void ResetCache(ResetCacheRequest request)
        {
            this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));
        }

        /// <summary>
        /// Converts document to destination format with detailed settings and saves result to storage.
        /// </summary>
        /// <param name="request">Request. <see cref="SaveAsRequest" /></param>
        /// <returns><see cref="SaveResponse" /></returns>
        public SaveResponse SaveAs(SaveAsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (SaveResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(SaveResponse));
        }

        /// <summary>
        /// Saves the selected range as a new document.
        /// </summary>
        /// <param name="request">Request. <see cref="SaveAsRangeRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse SaveAsRange(SaveAsRangeRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Converts document to tiff with detailed settings and saves result to storage.
        /// </summary>
        /// <param name="request">Request. <see cref="SaveAsTiffRequest" /></param>
        /// <returns><see cref="SaveResponse" /></returns>
        public SaveResponse SaveAsTiff(SaveAsTiffRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (SaveResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(SaveResponse));
        }

        /// <summary>
        /// Searches text in document.
        /// </summary>
        /// <param name="request">Request. <see cref="SearchRequest" /></param>
        /// <returns><see cref="SearchResponse" /></returns>
        public SearchResponse Search(SearchRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (SearchResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(SearchResponse));
        }

        /// <summary>
        /// Splits document.
        /// </summary>
        /// <param name="request">Request. <see cref="SplitDocumentRequest" /></param>
        /// <returns><see cref="SplitDocumentResponse" /></returns>
        public SplitDocumentResponse SplitDocument(SplitDocumentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (SplitDocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(SplitDocumentResponse));
        }

        /// <summary>
        /// Unprotects document.
        /// </summary>
        /// <param name="request">Request. <see cref="UnprotectDocumentRequest" /></param>
        /// <returns><see cref="ProtectionDataResponse" /></returns>
        public ProtectionDataResponse UnprotectDocument(UnprotectDocumentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ProtectionDataResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ProtectionDataResponse));
        }

        /// <summary>
        /// Updates document bookmark.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateBookmarkRequest" /></param>
        /// <returns><see cref="BookmarkResponse" /></returns>
        public BookmarkResponse UpdateBookmark(UpdateBookmarkRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (BookmarkResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(BookmarkResponse));
        }

        /// <summary>
        /// 'nodePath' should refer to paragraph, cell or row.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateBorderRequest" /></param>
        /// <returns><see cref="BorderResponse" /></returns>
        public BorderResponse UpdateBorder(UpdateBorderRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (BorderResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(BorderResponse));
        }

        /// <summary>
        /// Updates the comment, returns updated comment data.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateCommentRequest" /></param>
        /// <returns><see cref="CommentResponse" /></returns>
        public CommentResponse UpdateComment(UpdateCommentRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (CommentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(CommentResponse));
        }

        /// <summary>
        /// Updates drawing object, returns updated  drawing object's data.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateDrawingObjectRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse" /></returns>
        public DrawingObjectResponse UpdateDrawingObject(UpdateDrawingObjectRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DrawingObjectResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DrawingObjectResponse));
        }

        /// <summary>
        /// Updates field's properties, returns updated field's data.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFieldRequest" /></param>
        /// <returns><see cref="FieldResponse" /></returns>
        public FieldResponse UpdateField(UpdateFieldRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FieldResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FieldResponse));
        }

        /// <summary>
        /// Updates (reevaluate) fields in document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFieldsRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public DocumentResponse UpdateFields(UpdateFieldsRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (DocumentResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }

        /// <summary>
        /// Updates footnote's properties, returns updated run's data.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFootnoteRequest" /></param>
        /// <returns><see cref="FootnoteResponse" /></returns>
        public FootnoteResponse UpdateFootnote(UpdateFootnoteRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FootnoteResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FootnoteResponse));
        }

        /// <summary>
        /// Updates properties of form field, returns updated form field.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFormFieldRequest" /></param>
        /// <returns><see cref="FormFieldResponse" /></returns>
        public FormFieldResponse UpdateFormField(UpdateFormFieldRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FormFieldResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FormFieldResponse));
        }

        /// <summary>
        /// Updates list properties, returns updated list.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateListRequest" /></param>
        /// <returns><see cref="ListResponse" /></returns>
        public ListResponse UpdateList(UpdateListRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ListResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ListResponse));
        }

        /// <summary>
        /// Updates list level in document list, returns updated list.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateListLevelRequest" /></param>
        /// <returns><see cref="ListResponse" /></returns>
        public ListResponse UpdateListLevel(UpdateListLevelRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ListResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ListResponse));
        }

        /// <summary>
        /// Updates paragraph format properties, returns updated format properties.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateParagraphFormatRequest" /></param>
        /// <returns><see cref="ParagraphFormatResponse" /></returns>
        public ParagraphFormatResponse UpdateParagraphFormat(UpdateParagraphFormatRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ParagraphFormatResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ParagraphFormatResponse));
        }

        /// <summary>
        /// Updates paragraph list format properties, returns updated list format properties.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateParagraphListFormatRequest" /></param>
        /// <returns><see cref="ParagraphListFormatResponse" /></returns>
        public ParagraphListFormatResponse UpdateParagraphListFormat(UpdateParagraphListFormatRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (ParagraphListFormatResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(ParagraphListFormatResponse));
        }

        /// <summary>
        /// Updates run's properties, returns updated run's data.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateRunRequest" /></param>
        /// <returns><see cref="RunResponse" /></returns>
        public RunResponse UpdateRun(UpdateRunRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (RunResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(RunResponse));
        }

        /// <summary>
        /// Updates font properties, returns updated font data.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateRunFontRequest" /></param>
        /// <returns><see cref="FontResponse" /></returns>
        public FontResponse UpdateRunFont(UpdateRunFontRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (FontResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(FontResponse));
        }

        /// <summary>
        /// Updates page setup of section.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateSectionPageSetupRequest" /></param>
        /// <returns><see cref="SectionPageSetupResponse" /></returns>
        public SectionPageSetupResponse UpdateSectionPageSetup(UpdateSectionPageSetupRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (SectionPageSetupResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(SectionPageSetupResponse));
        }

        /// <summary>
        /// Updates style properties, returns an updated style.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateStyleRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public StyleResponse UpdateStyle(UpdateStyleRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (StyleResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(StyleResponse));
        }

        /// <summary>
        /// Updates a table cell format.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTableCellFormatRequest" /></param>
        /// <returns><see cref="TableCellFormatResponse" /></returns>
        public TableCellFormatResponse UpdateTableCellFormat(UpdateTableCellFormatRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TableCellFormatResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TableCellFormatResponse));
        }

        /// <summary>
        /// Updates a table properties.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTablePropertiesRequest" /></param>
        /// <returns><see cref="TablePropertiesResponse" /></returns>
        public TablePropertiesResponse UpdateTableProperties(UpdateTablePropertiesRequest request)
        {
            var response = this.apiInvoker.InvokeApi(() => request.CreateHttpRequest(this.configuration));

            return (TablePropertiesResponse)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TablePropertiesResponse));
        }

        /// <summary>
        /// Updates a table row format.
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
