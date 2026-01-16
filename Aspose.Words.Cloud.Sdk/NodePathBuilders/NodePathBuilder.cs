// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="NodePathBuilder.cs">
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

namespace Aspose.Words.Cloud.Sdk.NodePathBuilders
{
    /// <summary>
    /// Node path builder.
    /// </summary>
    public static class NodePathBuilder
    {
        /// <summary>
        /// Gets a node path builder for section node.
        /// </summary>
        /// <param name="index">element node index.</param>
        /// <returns>node path builder for the node.</returns>
        public static SectionNodePathBuilder Sections(int index) => new SectionNodePathBuilder(null, index);

        /// <summary>
        /// Gets a node path builder for paragraph node.
        /// </summary>
        /// <param name="index">element node index.</param>
        /// <returns>node path builder for the node.</returns>
        public static ParagraphNodePathBuilder Paragraphs(int index) => new ParagraphNodePathBuilder(null, index);

        /// <summary>
        /// Gets a node path builder for header / footer node.
        /// </summary>
        /// <param name="index">element node index.</param>
        /// <returns>node path builder for the node collection.</returns>
        public static HeaderFooterNodePathBuilder HeaderFooters(int index) => new HeaderFooterNodePathBuilder(null, index);

        /// <summary>
        /// Gets a node path builder for table node.
        /// </summary>
        /// <param name="index">element node index.</param>
        /// <returns>node path builder for the node.</returns>
        public static TableNodePathBuilder Tables(int index) => new TableNodePathBuilder(null, index);

        /// <summary>
        /// Gets a node path builder for list node.
        /// </summary>
        /// <param name="index">element node index.</param>
        /// <returns>node path builder for the node.</returns>
        public static ListNodePathBuilder Lists(int index) => new ListNodePathBuilder(null, index);
    }
}
