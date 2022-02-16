// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SerializationHelper.cs">
//   Copyright (c) 2022 Aspose.Words for Cloud
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
    using System;
    using System.IO;
#if NETSTANDARD2_0
    using System.Reflection;
#endif
    using System.Threading.Tasks;

    using Aspose.Words.Cloud.Sdk.Model;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    internal class SerializationHelper
    {
        public static string Serialize(object obj)
        {
            try
            {
                return obj != null
                           ? JsonConvert.SerializeObject(
                               obj,
                               new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore })
                           : null;
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        public static object Deserialize(string json, Type type)
        {
            try
            {
                if (json.StartsWith("{") || json.StartsWith("["))
                {
                    return JsonConvert.DeserializeObject(json, type, new FormFieldJsonConverter(), new NodeLinkJsonConverter());
                }

                throw new ApiException(500, "Server does not return json: '" + json + "'");
            }
            catch (IOException e)
            {
                throw new ApiException(500, e.Message);
            }
            catch (JsonSerializationException jse)
            {
                throw new ApiException(500, "Error while parse response: " + jse.Message);
            }
            catch (System.Xml.XmlException xmle)
            {
                throw new ApiException(500, "Error while parse response: " + xmle.Message);
            }
            catch (Exception ex)
            {
                throw new ApiException(500, "Internal deserialization error: " + ex.Message);
            }
        }

        public static async Task< System.IO.Stream > MultipartSectionToStream(Microsoft.AspNetCore.WebUtilities.MultipartSection section)
        {
            var ms = new MemoryStream();
            section.Body.Seek(0, SeekOrigin.Begin);
            await section.Body.CopyToAsync(ms);
            ms.Seek(0, SeekOrigin.Begin);
            return ms;
        }

        public static async Task< System.Collections.Generic.Dictionary<string, System.IO.Stream> > DeserializeFilesCollection(Microsoft.AspNetCore.WebUtilities.MultipartSection section)
        {
            var result = new System.Collections.Generic.Dictionary<string, System.IO.Stream>();
            var files = new System.Collections.Generic.List<Microsoft.AspNetCore.WebUtilities.MultipartSection>();
            var dataType = section.ContentType;
            if (dataType != null && dataType.StartsWith("multipart/mixed"))
            {
                string boundary = null;
                var boundaryParts = dataType.Split(';');
                foreach (var boundaryPart in boundaryParts)
                {
                    var boundarySubparts = boundaryPart.Trim().Split('=');
                    if (boundarySubparts.Length == 2 && boundarySubparts[0] == "boundary")
                    {
                        boundary = boundarySubparts[1].Trim(' ', '"');
                        break;
                    }
                }

                section.Body.Seek(0, SeekOrigin.Begin);
                Microsoft.AspNetCore.WebUtilities.MultipartSection fileSection;
                var reader = new Microsoft.AspNetCore.WebUtilities.MultipartReader(boundary, section.Body);
                while ((fileSection = await reader.ReadNextSectionAsync()) != null)
                {
                    files.Add(fileSection);
                }
            }
            else
            {
                files.Add(section);
            }

            foreach (var file in files)
            {
                string fileName = null;
                var contentHeaders = file.ContentDisposition.Split(';');
                foreach (var contentHeader in contentHeaders)
                {
                    var contentHeaderParts = contentHeader.Split('=');
                    if (contentHeaderParts.Length == 2)
                    {
                        if (contentHeaderParts[0].Trim().Equals("filename"))
                        {
                            fileName = contentHeaderParts[1].Trim(' ', '"');
                            break;
                        }
                    }
                }

                if (fileName != null)
                {
                    result.Add(fileName, await MultipartSectionToStream(file));
                }
            }

            return result;
        }

        internal abstract class JsonCreationConverter<T> : JsonConverter
        {
            public override bool CanConvert(Type objectType)
            {
                return typeof(T).GetTypeInfo().IsAssignableFrom(objectType);
            }

            public override object ReadJson(
                JsonReader reader,
                Type objectType,
                object existingValue,
                JsonSerializer serializer)
            {
                var jsonObject = JObject.Load(reader);
                T target = this.Create(objectType, jsonObject);
                serializer.Populate(jsonObject.CreateReader(), target);
                return target;
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value);
            }

            /// <summary>
            /// Create an instance of objectType, based properties in the JSON object.
            /// </summary>
            /// <param name="objectType">type of object expected.</param>
            /// <param name="jsonObject">
            /// Contents of JSON object that will be deserialized.
            /// </param>
            /// <returns>An instance of objectType.</returns>
            protected abstract T Create(Type objectType, JObject jsonObject);
        }       

        internal class FormFieldJsonConverter : JsonCreationConverter<FormField>
        {
            public override bool CanWrite
            {
                get
                {
                    return false;
                }
            }

            protected override FormField Create(Type objectType, JObject jsonObject)
            {
                if (jsonObject["Checked"] != null)
                {
                    return new FormFieldCheckbox();
                }

                if (jsonObject["TextInputFormat"] != null || jsonObject["TextInputDefault"] != null)
                {
                    return new FormFieldTextInput();
                }

                if (jsonObject["DropDownItems"] != null)
                {
                    return new FormFieldDropDown();
                }

                throw new ApiException(500, "Can not determine formfield type.");
            }
        }

        internal class NodeLinkJsonConverter : JsonCreationConverter<NodeLink>
        {
            public override bool CanWrite
            {
                get
                {
                    return false;
                }
            }

            protected override NodeLink Create(Type objectType, JObject jsonObject)
            {
                if (objectType != typeof(NodeLink))
                {
                    return Activator.CreateInstance(objectType) as NodeLink;
                }

                if (jsonObject["Text"] != null)
                {
                    return new RunLink();
                }

                if (jsonObject["FieldCode"] != null)
                {
                    return new FieldLink();
                }

                return new NodeLink();
            }
        }
    }
}
