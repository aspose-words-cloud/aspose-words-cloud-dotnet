// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ExecuteTemplateOnlineSteps.cs">
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

namespace Aspose.Words.Cloud.Sdk.BddTests.Steps.MailMerge
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;
    using Aspose.Words.Cloud.Sdk.Model.Requests;

    using TechTalk.SpecFlow;

    /// <summary>
    /// Steps for Execute Template operations
    /// </summary>
    [Binding]
    public class ExecuteTemplateOnlineSteps : Steps
    {
        private const string TestFolder = "DocumentActions/MailMerge/";
        private readonly BaseContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteTemplateOnlineSteps"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public ExecuteTemplateOnlineSteps(BaseContext context)
        {
            this.context = context;
        }

        private IPutExecuteRequest Request
        {
            get
            {
                return ScenarioContext["Request"] as IPutExecuteRequest;
            }
        }

        /// <summary>
        /// Initialize template stream 
        /// </summary>
        /// <param name="templateFile">template file</param>
        [Given(@"I have specified a template file (.*) in request")]
        ////[Scope(Tag = "PutMailMergeOnline")]
        public void GivenIHaveSpecifiedATemplateFileWithMustacheSyntax(string templateFile)
        {
            this.Request.Template =
                new MemoryStream(
                    File.ReadAllBytes(
                        Path.Combine(this.context.TestDataPath, TestFolder, templateFile)));
        }

        /// <summary>
        /// Initialize body stream
        /// </summary>
        /// <param name="dataFile">body file</param>
        [Given(@"I have specified a body (.*)")]
        [Scope(Tag = "PutMailMergeOnline")]
        public void GivenIHaveSpecifiedADataFile(string dataFile)
        {
            this.Request.Data =
                new MemoryStream(
                    File.ReadAllBytes(
                        Path.Combine(this.context.TestDataPath, TestFolder, dataFile)));
        }
    }
}