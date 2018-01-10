// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutConvertSteps.cs">
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

namespace Aspose.Words.Cloud.Sdk.BddTests.Features.Conversion.PutConvert.Steps
{
    using System.IO;
   
    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;
    using Aspose.Words.Cloud.Sdk.Model.Requests;

    using TechTalk.SpecFlow;

    /// <summary>
    /// It's "PutConvert" step class with injection of conversion context
    /// </summary>
    [Binding]
    public class PutConvertSteps
    {
        private readonly BaseContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="PutConvertSteps"/> class.
        /// </summary>
        /// <param name="context">Conversion context</param>
        protected PutConvertSteps(BaseContext context)
        {
            this.context = context;
            this.context.TestSubFolderInStorage = "Conversion";
        }

        private PutConvertDocumentRequest Request
        {
            get
            {
                return (PutConvertDocumentRequest)ScenarioContext.Current["Request"];
            }
        }

        /// <summary>
        /// Initialize context before each scenario.
        /// </summary>
        [BeforeScenario("PutConvert")]
        public static void BeforeScenario()
        {
            ScenarioContext.Current["Request"] = new PutConvertDocumentRequest();
        }

        /// <summary>
        /// Sets the name of document
        /// </summary>
        /// <param name="documentName">name of document</param>
        [Given(@"I have specified document (.*) to send it in request body")]
        public void GivenIHaveSpecifiedDocumentToSendItInRequestBody(string documentName)
        {
            using (var fileStream = File.OpenRead(Path.Combine(this.context.TestDataPath, documentName)))
            {
                this.Request.Document = new MemoryStream();
                fileStream.CopyTo(this.Request.Document);               
            }            
        }        

        /// <summary>
        /// Executes conversion
        /// </summary>
        [When(@"I execute conversion \(PUT convert\)")]
        public void WhenIExecuteConversion()
        {
            this.context.Response = this.context.WordsApi.PutConvertDocument(this.Request);
        }                                    
    }
}