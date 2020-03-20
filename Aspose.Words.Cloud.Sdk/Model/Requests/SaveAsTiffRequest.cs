// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SaveAsTiffRequest.cs">
//   Copyright (c) 2019 Aspose.Words for Cloud
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
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.SaveAsTiff" /> operation.
  /// </summary>  
  public class SaveAsTiffRequest : IWordDocumentRequest, ICanUseCustomFontsRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveAsTiffRequest"/> class.
        /// </summary>        
        public SaveAsTiffRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveAsTiffRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="saveOptions">Tiff save options.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="storage">Original document storage.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        /// <param name="useAntiAliasing">Use antialiasing flag.</param>
        /// <param name="useHighQualityRendering">Use high quality flag.</param>
        /// <param name="imageBrightness">Brightness for the generated images.</param>
        /// <param name="imageColorMode">Color mode for the generated images.</param>
        /// <param name="imageContrast">The contrast for the generated images.</param>
        /// <param name="numeralFormat">The images numeral format.</param>
        /// <param name="pageCount">Number of pages to render.</param>
        /// <param name="pageIndex">Page index to start rendering.</param>
        /// <param name="paperColor">Background image color.</param>
        /// <param name="pixelFormat">The pixel format of generated images.</param>
        /// <param name="resolution">The resolution of generated images.</param>
        /// <param name="scale">Zoom factor for generated images.</param>
        /// <param name="tiffCompression">The compression tipe.</param>
        /// <param name="dmlRenderingMode">Optional, default is Fallback.</param>
        /// <param name="dmlEffectsRenderingMode">Optional, default is Simplified.</param>
        /// <param name="tiffBinarizationMethod">Optional, Tiff binarization method, possible values are: FloydSteinbergDithering, Threshold.</param>
        /// <param name="zipOutput">Optional. A value determining zip output or not.</param>
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param>
        public SaveAsTiffRequest( name saveOptions folder = null storage = null loadEncoding = null password = null useAntiAliasing = null useHighQualityRendering = null imageBrightness = null imageColorMode = null imageContrast = null numeralFormat = null pageCount = null pageIndex = null paperColor = null pixelFormat = null resolution = null scale = null tiffCompression = null dmlRenderingMode = null dmlEffectsRenderingMode = null tiffBinarizationMethod = null zipOutput = null fontsLocation = null)             
        {
            this.Name = name;
            this.SaveOptions = saveOptions;
            this.Folder = folder;
            this.Storage = storage;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
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
        /// The document name.
        /// </summary>  
        public  Name { get; set; }
        /// <summary>
        /// Tiff save options.
        /// </summary>  
        public  SaveOptions { get; set; }
        /// <summary>
        /// Original document folder.
        /// </summary>  
        public  Folder { get; set; }
        /// <summary>
        /// Original document storage.
        /// </summary>  
        public  Storage { get; set; }
        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public  LoadEncoding { get; set; }
        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public  Password { get; set; }
        /// <summary>
        /// Use antialiasing flag.
        /// </summary>  
        public  UseAntiAliasing { get; set; }
        /// <summary>
        /// Use high quality flag.
        /// </summary>  
        public  UseHighQualityRendering { get; set; }
        /// <summary>
        /// Brightness for the generated images.
        /// </summary>  
        public  ImageBrightness { get; set; }
        /// <summary>
        /// Color mode for the generated images.
        /// </summary>  
        public  ImageColorMode { get; set; }
        /// <summary>
        /// The contrast for the generated images.
        /// </summary>  
        public  ImageContrast { get; set; }
        /// <summary>
        /// The images numeral format.
        /// </summary>  
        public  NumeralFormat { get; set; }
        /// <summary>
        /// Number of pages to render.
        /// </summary>  
        public  PageCount { get; set; }
        /// <summary>
        /// Page index to start rendering.
        /// </summary>  
        public  PageIndex { get; set; }
        /// <summary>
        /// Background image color.
        /// </summary>  
        public  PaperColor { get; set; }
        /// <summary>
        /// The pixel format of generated images.
        /// </summary>  
        public  PixelFormat { get; set; }
        /// <summary>
        /// The resolution of generated images.
        /// </summary>  
        public  Resolution { get; set; }
        /// <summary>
        /// Zoom factor for generated images.
        /// </summary>  
        public  Scale { get; set; }
        /// <summary>
        /// The compression tipe.
        /// </summary>  
        public  TiffCompression { get; set; }
        /// <summary>
        /// Optional, default is Fallback.
        /// </summary>  
        public  DmlRenderingMode { get; set; }
        /// <summary>
        /// Optional, default is Simplified.
        /// </summary>  
        public  DmlEffectsRenderingMode { get; set; }
        /// <summary>
        /// Optional, Tiff binarization method, possible values are: FloydSteinbergDithering, Threshold.
        /// </summary>  
        public  TiffBinarizationMethod { get; set; }
        /// <summary>
        /// Optional. A value determining zip output or not.
        /// </summary>  
        public  ZipOutput { get; set; }
        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public  FontsLocation { get; set; }
  }
}
