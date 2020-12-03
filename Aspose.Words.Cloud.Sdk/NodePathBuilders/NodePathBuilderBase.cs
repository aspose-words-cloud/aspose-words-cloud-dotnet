// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="NodePathBuilderBase.cs">
//   Copyright (c) 2020 Aspose.Words for Cloud
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
    using System.Collections.Generic;

    /// <summary>
    /// Base class for all node path builder.
    /// </summary>
    public abstract class NodePathBuilderBase
    {
        private NodePathBuilderBase parentBuilder;
        private string name;
        private int? index;

        /// <summary>
        /// Initializes a new instance of the <see cref="NodePathBuilderBase"/> class.
        /// </summary>
        /// <param name="parentBuilder">parent node path builder.</param>
        /// <param name="name">name of node collection.</param>
        /// <param name="index">element index.</param>
        protected NodePathBuilderBase(NodePathBuilderBase parentBuilder, string name, int? index = null)
        {
            this.parentBuilder = parentBuilder;
            this.name = name.ToLower();
            this.index = index;
        }

        /// <summary>
        /// Build node path for given node.
        /// </summary>
        /// <returns>node path as string.</returns>
        public string Build()
        {
            var stack = new Stack<string>\();
            var builder = this;

            while (builder != null)
            {
                stack.Push(builder.name + (builder.index == null ? string.Empty : $"/{builder.index}"));
                builder = builder.parentBuilder;
            }

            return string.Join("/", stack);
        }
    }
}
