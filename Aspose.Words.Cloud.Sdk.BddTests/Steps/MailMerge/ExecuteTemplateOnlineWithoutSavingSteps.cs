// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ExecuteTemplateOnlineWithoutSavingSteps.cs">
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
    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    
    using TechTalk.SpecFlow;

    /// <summary>
    /// Steps for executing template online
    /// </summary>
    [Binding]
    public class ExecuteTemplateOnlineWithoutSavingSteps : Steps
    {        
        private readonly BaseContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteTemplateOnlineWithoutSavingSteps"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public ExecuteTemplateOnlineWithoutSavingSteps(BaseContext context)
        {
            this.context = context;
        }

        private ExecuteMailMergeOnlineRequest Request
        {
            get
            {
                return ScenarioContext["Request"] as ExecuteMailMergeOnlineRequest;
            }
        }

        /// <summary>
        /// Initialize context before each scenario.
        /// </summary>
        [BeforeScenario("PutExecuteTemplate")]
        public void BeforeScenario()
        {
            ScenarioContext["Request"] = new ExecuteMailMergeOnlineRequest();
        }

        /// <summary>
        /// Initialize cleanup option
        /// </summary>
        /// <param name="cleanup">cleanup option</param>
        [Given(@"I have specified a cleanup option (.*)")]
        public void GivenIHaveSpecifiedACleanupOption(string cleanup)
        {
            // TODO: move to SpecifyMailMergeParametersRequestSteps
            this.Request.Cleanup = cleanup;
        }

        /// <summary>
        /// Executes template online
        /// </summary>
        [When(@"I execute template online")]
        [Scope(Tag = "PutMailMergeOnline")]
        public void WhenIExecuteTemplateOnline()
        {
            this.context.Response = this.context.WordsApi.ExecuteMailMergeOnline(this.Request);
        }              
    }
}
