// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TableNodePathBuilder.cs">
//   Copyright (c) 2025 Aspose.Words for Cloud
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
    /// Node path builder for tables.
    /// </summary>
    public class TableNodePathBuilder : NodePathBuilderBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableNodePathBuilder"/> class.
        /// </summary>
        /// <param name="parentBuilder">parent node path builder.</param>
        /// <param name="index">element node index.</param>
        public TableNodePathBuilder(NodePathBuilderBase parentBuilder, int index)
            : base(parentBuilder, "tables", index)
        {
        }

        /// <summary>
        /// Gets a node path builder for row node.
        /// </summary>
        /// <param name="index">element node index.</param>
        /// <returns>node path builder for the node.</returns>
        public TableRowNodePathBuilder Rows(int index) => new TableRowNodePathBuilder(this, index);
    }
}
