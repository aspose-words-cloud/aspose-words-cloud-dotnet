// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostExecuteTemplateWithSavingToStorageSteps.cs">
//   Copyright (c) 2017 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.BddTests.Steps.MailMerge
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;
    using Aspose.Words.Cloud.Sdk.Model.Requests;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TechTalk.SpecFlow;

    /// <summary>
    /// Steps for executing template with saving to storage
    /// </summary>
    [Binding]
    public class PostExecuteTemplateWithSavingToStorageSteps
    {
        private const string TestFolder = "DocumentActions/MailMerge/";
        private readonly BaseContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="PostExecuteTemplateWithSavingToStorageSteps"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public PostExecuteTemplateWithSavingToStorageSteps(BaseContext context)
        {
            this.context = context;
        }

        private PostExecuteTemplateRequest Request
        {
            get
            {
                return ScenarioContext.Current["Request"] as PostExecuteTemplateRequest;
            }
        }

        /// <summary>
        /// Initialize context before each scenario.
        /// </summary>
        [BeforeScenario("PostExecuteTemplate")]
        public static void BeforeScenario()
        {
            ScenarioContext.Current["Request"] = new PostExecuteTemplateRequest();
        }

        /// <summary>
        /// Initialize document name for executing template from storage
        /// </summary>
        /// <param name="documentName">document name</param>
        [Given(@"I have specified a template file name (.*) in storage")]
        public void GivenIHaveSpecifiedATemplateWithMustacheSyntax(string documentName)
        {
            var remotePath = BaseContext.RemoteBaseFolder + TestFolder;
            var localPath = Path.Combine(this.context.TestDataPath, TestFolder, documentName);

            this.context.StorageApi.PutCreate(
                remotePath + documentName,
                null,
                null,
                File.ReadAllBytes(localPath));

            this.Request.Name = documentName;
            this.Request.Folder = remotePath.TrimEnd('/');
        }

        /// <summary>
        /// Initialize body document name for executing template from storage
        /// </summary>
        /// <param name="bodyDocumentName">body document name</param>
        [Given(@"I have specified a body (.*)")]
        public void GivenIHaveSpecifiedABody(string bodyDocumentName)
        {
            this.Request.Data = File.ReadAllText(Path.Combine(this.context.TestDataPath, TestFolder, bodyDocumentName));
        }
        
        /// <summary>
        /// Executes template from storage
        /// </summary>
        [When(@"I execute template")]
        public void WhenIExecuteTemplate()
        {
            this.context.Response = this.context.WordsApi.PostExecuteTemplate(this.Request);
        }

        /// <summary>
        /// Checks output document contains images
        /// </summary>
        [Then(@"image should be rendered")]
        public void ThenImageShouldBeRendered()
        {
            var imagesResponse = this.context.WordsApi.GetDocumentDrawingObjects(
                new GetDocumentDrawingObjectsRequest(
                    "ExecuteTemplateWithImagesResult.doc",
                    BaseContext.RemoteBaseFolder + "DocumentActions/MailMerge"));

            Assert.IsTrue(imagesResponse.DrawingObjects.List.Count > 0);
        }
    }
}
