// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BatchTests.cs">
//   Copyright (c) 2026 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.Tests
{
    using Aspose.Words.Cloud.Sdk.NodePathBuilders;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Test node path builder.
    /// </summary>
    public class NodePathBuilderTests
    {
        /// <summary>
        /// Check of node path.
        /// </summary>
        [Test]
        public void TestNodePaths()
        {
            // paragraph node paths
            Assert.AreEqual("paragraphs/0", NodePathBuilder.Paragraphs(0).Build());
            Assert.AreEqual("headerfooters/0/paragraphs/0", NodePathBuilder.HeaderFooters(0).Paragraphs(0).Build());
            Assert.AreEqual("tables/0/rows/0/cells/0/paragraphs/0", NodePathBuilder.Tables(0).Rows(0).Cells(0).Paragraphs(0).Build());

            // header / footer node paths
            Assert.AreEqual("headerfooters/0", NodePathBuilder.HeaderFooters(0).Build());
            Assert.AreEqual("sections/0/headerfooters/0", NodePathBuilder.Sections(0).HeaderFooters(0).Build());

            // table node paths
            Assert.AreEqual("tables/0/rows/0/cells/0", NodePathBuilder.Tables(0).Rows(0).Cells(0).Build());
            Assert.AreEqual("sections/1/tables/0", NodePathBuilder.Sections(1).Tables(0).Build());

            // styled element node paths
            Assert.AreEqual("paragraphs/0/paragraphformat", NodePathBuilder.Paragraphs(0).Format.Build());
            Assert.AreEqual("lists/0/listlevels/0", NodePathBuilder.Lists(0).Levels(0).Build());
            Assert.AreEqual("sections/0/lists/0/listlevels/0", NodePathBuilder.Sections(0).Lists(0).Levels(0).Build());
        }
    }
}
