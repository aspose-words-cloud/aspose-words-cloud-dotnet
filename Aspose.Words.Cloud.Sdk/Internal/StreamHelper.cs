// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StreamHelper.cs">
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

namespace Aspose.Words.Cloud.Sdk
{
    using System.IO;
    using System.Text;

    internal class StreamHelper
    {
        public static void CopyTo(Stream source, Stream destination, int bufferSize = 81920)
        {
            if (source.CanSeek)
            {
                source.Flush();
                source.Position = 0;
            }

            byte[] array = new byte[bufferSize];
            int count;
            while ((count = source.Read(array, 0, array.Length)) != 0)
            {
                destination.Write(array, 0, count);
            }
        }

        public static byte[] ReadAsBytes(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }

                return ms.ToArray();
            }
        }

        public static void CopyStreamToStringBuilder(StringBuilder sb, Stream stream)
        {
            if ((stream == null) || !stream.CanRead)
            {
                return;
            }

            Stream streamToRead;
            if (!stream.CanSeek)
            {
                streamToRead = new MemoryStream(1024);
                CopyTo(stream, streamToRead);
            }
            else
            {
                streamToRead = stream;
            }

            streamToRead.Seek(0, SeekOrigin.Begin);
            var bodyReader = new StreamReader(streamToRead);
            if (bodyReader.Peek() != -1)
            {
                var content = bodyReader.ReadToEnd();
                streamToRead.Seek(0, SeekOrigin.Begin);

                sb.AppendLine("Body:");
                sb.AppendLine(content);
            }
        }       
    }
}