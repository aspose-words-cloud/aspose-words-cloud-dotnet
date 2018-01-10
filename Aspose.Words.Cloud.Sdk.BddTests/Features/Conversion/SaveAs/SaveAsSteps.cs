// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SaveAsSteps.cs">
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

namespace Aspose.Words.Cloud.Sdk.BddTests.Features.Conversion.SaveAs
{
    using System.IO;
    using System.Xml;

    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TechTalk.SpecFlow;

    /// <summary>
    /// Steps for SaveUs feature
    /// </summary>
    [Binding]
    public class SaveAsSteps
    {
        private BaseContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveAsSteps"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public SaveAsSteps(BaseContext context)
        {
            this.context = context;
        }

        private MemoryStream File
        {
            get { return this.context.Response as MemoryStream; }
        }

        private PostDocumentSaveAsRequest Request
        {
            get
            {
                return (PostDocumentSaveAsRequest)ScenarioContext.Current["Request"];
            }
        }

        /// <summary>
        /// Initialize context before each scenario.
        /// </summary>
        [BeforeScenario("StoredDocConversionWithStorage", "ConversionPdfToWord")]
        public static void BeforeScenario()
        {
            ScenarioContext.Current["Request"] = new PostDocumentSaveAsRequest() { SaveOptionsData = new SaveOptionsData() };
        }

        /// <summary>
        /// Sets saveFormat to SaveOptionsData
        /// </summary>
        /// <param name="saveFormat">format in which document will be converted</param>
        [Given(@"I have specified save format (.*) document to be converted")]
        public void GivenIHaveSpecifiedSaveFormatDocumentToBeConverted(string saveFormat)
        {
            this.Request.SaveOptionsData.SaveFormat = saveFormat;
        }

        /// <summary>
        /// Sets destination file name
        /// </summary>
        /// <param name="destFileName">destionation file name</param>
        [Given(@"I have specified destFileName (.*)")]
        public void GivenIHaveSpecifiedDestFileName(string destFileName)
        {
            this.Request.SaveOptionsData.FileName = destFileName;
        }

        /// <summary>
        /// Executes conversion
        /// </summary>
        [When(@"I execute conversion from storage \(POST SaveAs\)")]
        public void WhenIExecuteConversion()
        {
            this.Request.Folder = this.context.TestFolderInStorage;
            this.context.Response = this.context.WordsApi.PostDocumentSaveAs(this.Request);
        }

        /// <summary>
        /// Checks that document converted properly
        /// </summary>
        [Then(@"symbols are encoded properly")]
        public void ThenSymbolsAreEncodedProperly()
        {
            this.File.Position = 0;
            var doc = new Words.Document(this.File);
            Assert.IsTrue(doc.GetText().Contains("строка"), "Wrong conversion");
        }        
    }
}