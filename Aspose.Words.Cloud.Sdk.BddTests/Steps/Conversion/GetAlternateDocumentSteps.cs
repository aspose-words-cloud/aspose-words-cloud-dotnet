// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetAlternateDocumentSteps.cs">
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

namespace Aspose.Words.Cloud.Sdk.BddTests.Steps.Conversion
{
    using System.IO;
    
    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;
    using Aspose.Words.Cloud.Sdk.Model.Requests;

    using NUnit.Framework;

    using TechTalk.SpecFlow;

    /// <summary>
    /// Class contains steps related to document conversion of stored document
    /// </summary>
    [Binding]
    public class GetAlternateDocumentSteps : Steps
    {
        private readonly BaseContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAlternateDocumentSteps"/> class.
        /// </summary>
        /// <param name="context">Conversion context</param>
        public GetAlternateDocumentSteps(BaseContext context)
        {
            this.context = context;
        }

        private GetDocumentWithFormatRequest Request
        {
            get
            {
                return this.ScenarioContext["Request"] as GetDocumentWithFormatRequest;
            }
        }

        /// <summary>
        /// Initialize context before each scenario.
        /// </summary>
        [BeforeScenario("ConversionOfStoredDoc")]
        public void BeforeScenario()
        {
            this.ScenarioContext["Request"] = new GetDocumentWithFormatRequest();
        }

        /// <summary>
        /// Executes conversion from storage
        /// </summary>
        [When(@"I execute conversion from storage \(GET document with format\)")]
        public void WhenIExecuteConversionFromStorage()
        {
            this.context.Response = this.context.WordsApi.GetDocumentWithFormat(this.Request);
        }

        /// <summary>
        /// Checks document is downloadble from storage
        /// </summary>
        [Then(@"converted document downloads from storage")]
        public void ThenConvertedDocumentDownloadsFromStorage()
        {
            this.context.Response = this.context.WordsApi.DownloadFile(new DownloadFileRequest(this.Request.OutPath));            
            Assert.AreNotEqual(0, ((MemoryStream)this.context.Response).Length);
        }
    }
}
