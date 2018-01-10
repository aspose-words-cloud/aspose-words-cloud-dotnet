// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SpecifyOutputFormatRequestSteps.cs">
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

namespace Aspose.Words.Cloud.Sdk.BddTests.Base.Steps
{
    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;
    using Aspose.Words.Cloud.Sdk.Model.Requests;

    using TechTalk.SpecFlow;

    /// <summary>
    /// Steps to specify output format of document
    /// </summary>
    [Binding]
    public class SpecifyOutputFormatRequestSteps
    {
        private readonly BaseContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecifyOutputFormatRequestSteps"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public SpecifyOutputFormatRequestSteps(BaseContext context)
        {
            this.context = context;
            this.context.TestSubFolderInStorage = "Conversion";
        }

        private ICanSpecifyOutputFormatRequest Request
        {
            get
            {
                return (ICanSpecifyOutputFormatRequest)ScenarioContext.Current["Request"];
            }
        }

        /// <summary>
        /// Sets destination format
        /// </summary>
        /// <param name="destinationFormat">format document to be converted in</param>
        [Given(@"I have specified format (.*) document to be converted")]
        public void GivenIHaveSpecifiedFormatDocumentToBeConverted(string destinationFormat)
        {
            this.Request.Format = destinationFormat;
        }

        /// <summary>
        /// Sets output name for converted document
        /// </summary>
        /// <param name="outPath">name for converted document</param>
        [Given(@"I have specified output path (.*)")]
        public void GivenIHaveSpecifiedOutputPath(string outPath)
        {
            this.Request.OutPath = this.context.TestFolderInStorage + outPath;
        }
    }
}