// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutExecuteTemplateWithoutSavingSteps.cs">
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

namespace Aspose.Words.Cloud.Sdk.BddTests.Features.MailMerge.ExecuteTemplate.PutExecute.Steps
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;
    using Aspose.Words.Cloud.Sdk.Model.Requests;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TechTalk.SpecFlow;

    /// <summary>
    /// Steps for executing template online
    /// </summary>
    [Binding]
    public class PutExecuteTemplateWithoutSavingSteps
    {
        private BaseContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="PutExecuteTemplateWithoutSavingSteps"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public PutExecuteTemplateWithoutSavingSteps(BaseContext context)
        {
            this.context = context;
            this.context.TestSubFolderInStorage = "MailMerge";
        }

        private PutExecuteTemplateOnlineRequest Request
        {
            get
            {
                return ScenarioContext.Current["Request"] as PutExecuteTemplateOnlineRequest;
            }
        }

        /// <summary>
        /// Initialize context before each scenario.
        /// </summary>
        [BeforeScenario("PutExecuteTemplate")]
        public static void BeforeScenario()
        {
            ScenarioContext.Current["Request"] = new PutExecuteTemplateOnlineRequest();
        }

        /// <summary>
        /// Initialize cleanup option
        /// </summary>
        /// <param name="cleanup">cleanup option</param>
        [Given(@"I have specified a cleanup option (.*)")]
        public void GivenIHaveSpecifiedACleanupOption(string cleanup)
        {
            this.Request.Cleanup = cleanup;
        }

        /// <summary>
        /// Executes template online
        /// </summary>
        [When(@"I execute template online")]
        public void WhenIExecuteTemplateOnline()
        {
            this.context.Response = this.context.WordsApi.PutExecuteTemplateOnline(this.Request);
        }
        
        /// <summary>
        /// Checks document with merge value was successfully created
        /// </summary>
        [Then(@"document with merged values should be created")]
        public void ThenDocumentWithMergedValuesShouldBeCreated()
        {
            Assert.IsNotNull(this.context.Response as MemoryStream);
        }
        
        /// <summary>
        /// Checks output document contains images
        /// </summary>
        [Then(@"image should be rendered")]
        public void ThenImageShouldBeRendered()
        {
            var doc = new Document(this.context.Response as MemoryStream);
            var images = doc.GetChildNodes(NodeType.Shape, true);
            Assert.IsTrue(images.Count > 0);
        }
        
        /// <summary>
        /// Checks options is cleanup
        /// </summary>
        [Then(@"unused option is cleaned up")]
        public void ThenUnusedOptionIsCleanedUp()
        {
            Assert.IsNotNull(this.context.Response);
        }
    }
}
