// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutDocumentSaveAsTiffRequest.cs">
//   Copyright (c) 2018 Aspose.Words for Cloud
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
namespace Aspose.Words.Cloud.Sdk.Model.Requests 
{
  using Aspose.Words.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutDocumentSaveAsTiff" /> operation.
  /// </summary>  
  public class PutDocumentSaveAsTiffRequest : ICanModifyDocumentRequest, IWordDocumentRequest, ICanUseCustomFontsRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutDocumentSaveAsTiffRequest"/> class.
        /// </summary>        
        public PutDocumentSaveAsTiffRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutDocumentSaveAsTiffRequest"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="saveOptions"></param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        /// <param name="resultFile"></param>
        /// <param name="useAntiAliasing"></param>
        /// <param name="useHighQualityRendering"></param>
        /// <param name="imageBrightness"></param>
        /// <param name="imageColorMode"></param>
        /// <param name="imageContrast"></param>
        /// <param name="numeralFormat"></param>
        /// <param name="pageCount"></param>
        /// <param name="pageIndex"></param>
        /// <param name="paperColor"></param>
        /// <param name="pixelFormat"></param>
        /// <param name="resolution"></param>
        /// <param name="scale"></param>
        /// <param name="tiffCompression"></param>
        /// <param name="dmlRenderingMode"></param>
        /// <param name="dmlEffectsRenderingMode"></param>
        /// <param name="tiffBinarizationMethod"></param>
        /// <param name="zipOutput"></param>
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param>
        public PutDocumentSaveAsTiffRequest(string name, TiffSaveOptionsData saveOptions, string folder = null, string storage = null, string loadEncoding = null, string password = null, string destFileName = null, string resultFile = null, bool? useAntiAliasing = null, bool? useHighQualityRendering = null, double? imageBrightness = null, string imageColorMode = null, double? imageContrast = null, string numeralFormat = null, int? pageCount = null, int? pageIndex = null, string paperColor = null, string pixelFormat = null, double? resolution = null, double? scale = null, string tiffCompression = null, string dmlRenderingMode = null, string dmlEffectsRenderingMode = null, string tiffBinarizationMethod = null, bool? zipOutput = null, string fontsLocation = null)             
        {
            this.Name = name;
            this.SaveOptions = saveOptions;
            this.Folder = folder;
            this.Storage = storage;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.DestFileName = destFileName;
            this.ResultFile = resultFile;
            this.UseAntiAliasing = useAntiAliasing;
            this.UseHighQualityRendering = useHighQualityRendering;
            this.ImageBrightness = imageBrightness;
            this.ImageColorMode = imageColorMode;
            this.ImageContrast = imageContrast;
            this.NumeralFormat = numeralFormat;
            this.PageCount = pageCount;
            this.PageIndex = pageIndex;
            this.PaperColor = paperColor;
            this.PixelFormat = pixelFormat;
            this.Resolution = resolution;
            this.Scale = scale;
            this.TiffCompression = tiffCompression;
            this.DmlRenderingMode = dmlRenderingMode;
            this.DmlEffectsRenderingMode = dmlEffectsRenderingMode;
            this.TiffBinarizationMethod = tiffBinarizationMethod;
            this.ZipOutput = zipOutput;
            this.FontsLocation = fontsLocation;
        }

        /// <summary>
        /// Gets or sets Name
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets SaveOptions
        /// </summary>  
        public TiffSaveOptionsData SaveOptions { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// Gets or sets ResultFile
        /// </summary>  
        public string ResultFile { get; set; }

        /// <summary>
        /// Gets or sets UseAntiAliasing
        /// </summary>  
        public bool? UseAntiAliasing { get; set; }

        /// <summary>
        /// Gets or sets UseHighQualityRendering
        /// </summary>  
        public bool? UseHighQualityRendering { get; set; }

        /// <summary>
        /// Gets or sets ImageBrightness
        /// </summary>  
        public double? ImageBrightness { get; set; }

        /// <summary>
        /// Gets or sets ImageColorMode
        /// </summary>  
        public string ImageColorMode { get; set; }

        /// <summary>
        /// Gets or sets ImageContrast
        /// </summary>  
        public double? ImageContrast { get; set; }

        /// <summary>
        /// Gets or sets NumeralFormat
        /// </summary>  
        public string NumeralFormat { get; set; }

        /// <summary>
        /// Gets or sets PageCount
        /// </summary>  
        public int? PageCount { get; set; }

        /// <summary>
        /// Gets or sets PageIndex
        /// </summary>  
        public int? PageIndex { get; set; }

        /// <summary>
        /// Gets or sets PaperColor
        /// </summary>  
        public string PaperColor { get; set; }

        /// <summary>
        /// Gets or sets PixelFormat
        /// </summary>  
        public string PixelFormat { get; set; }

        /// <summary>
        /// Gets or sets Resolution
        /// </summary>  
        public double? Resolution { get; set; }

        /// <summary>
        /// Gets or sets Scale
        /// </summary>  
        public double? Scale { get; set; }

        /// <summary>
        /// Gets or sets TiffCompression
        /// </summary>  
        public string TiffCompression { get; set; }

        /// <summary>
        /// Gets or sets DmlRenderingMode
        /// </summary>  
        public string DmlRenderingMode { get; set; }

        /// <summary>
        /// Gets or sets DmlEffectsRenderingMode
        /// </summary>  
        public string DmlEffectsRenderingMode { get; set; }

        /// <summary>
        /// Gets or sets TiffBinarizationMethod
        /// </summary>  
        public string TiffBinarizationMethod { get; set; }

        /// <summary>
        /// Gets or sets ZipOutput
        /// </summary>  
        public bool? ZipOutput { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string FontsLocation { get; set; }
  }
}