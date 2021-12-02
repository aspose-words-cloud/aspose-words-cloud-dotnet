// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConvertSteps.cs">
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
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;
    using Aspose.Words.Cloud.Sdk.Model.Requests;

    using TechTalk.SpecFlow;

    /// <summary>
    /// It's "Convert" step class with injection of conversion context
    /// </summary>
    [Binding]
    public class ConvertSteps : Steps
    {
        private readonly BaseContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertSteps"/> class.
        /// </summary>
        /// <param name="context">Conversion context</param>
        protected ConvertSteps(BaseContext context)
        {
            this.context = context;
        }

        private ConvertDocumentRequest Request
        {
            get
            {
                return (ConvertDocumentRequest)this.ScenarioContext["Request"];
            }
        }

        /// <summary>
        /// Initialize context before each scenario.
        /// </summary>
        [BeforeScenario("PutConvert")]
        public void BeforeScenario()
        {
            this.ScenarioContext["Request"] = new ConvertDocumentRequest();
        }

        /// <summary>
        /// Sets the name of document
        /// </summary>
        /// <param name="documentName">name of document</param>
        [Given(@"I have specified document (.*) to send it in request body")]
        public void GivenIHaveSpecifiedDocumentToSendItInRequestBody(string documentName)
        {
            var localPath = Path.Combine(this.context.TestDataPath, "DocumentActions/ConvertDocument/", documentName);
            using (var fileStream = File.OpenRead(localPath))
            {
                this.Request.Document = new MemoryStream();
                fileStream.CopyTo(this.Request.Document);               
            }            
        }        

        /// <summary>
        /// Executes conversion
        /// </summary>
        [When(@"I execute conversion \(PUT convert\)")]
        public async Task WhenIExecuteConversion()
        {
            this.context.Response = await this.context.WordsApi.ConvertDocument(this.Request);
        }                                    
    }
}