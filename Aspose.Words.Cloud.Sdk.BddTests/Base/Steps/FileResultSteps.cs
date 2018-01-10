// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FileResultSteps.cs">
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
    using System;
    using System.IO;

    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TechTalk.SpecFlow;

    /// <summary>
    /// Steps for working with "File results".
    /// </summary>
    [Binding]
    public class FileResultSteps
    {
        private readonly MemoryStream fileResult;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileResultSteps"/> class.
        /// </summary>
        /// <param name="context">Conversion context</param>
        protected FileResultSteps(BaseContext context)
        {           
            this.fileResult = context.Response as MemoryStream;            
        }

        /// <summary>
        /// Asserts document has been converted successfully
        /// </summary>
        [Then(@"document is returned as an attachment")]
        public void ThenDocumentHasToBeReturnedAsAnAttachment()
        {
            Assert.IsNotNull(this.fileResult);
        }

        /// <summary>
        /// Checks output format
        /// </summary>
        /// <param name="format">output format</param>
        [Then(@"attachment's format is (.*)")]
        public void ThenItsFormat(string format)
        {
            var attachment = this.fileResult;
            if (attachment == null)
            {
                throw new Exception("MemoryStream is expected in operation result");
            }

            if (format == "pdf")
            {
                byte[] pdfHeader = new byte[10];
                attachment.Position = 0;
                attachment.Read(pdfHeader, 0, pdfHeader.Length);

                char[] exptectedArray = { '%', 'P', 'D', 'F' };
                char[] actualArray =
                    {
                        Convert.ToChar(pdfHeader[0]),
                        Convert.ToChar(pdfHeader[1]),
                        Convert.ToChar(pdfHeader[2]),
                        Convert.ToChar(pdfHeader[3])
                    };

                CollectionAssert.AreEqual(exptectedArray, actualArray, "Expected format is \"pdf\"");
            }

            Assert.AreNotEqual(0, attachment.Length);
        } 
    }
}