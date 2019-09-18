# Aspose.Words Cloud SDK for .NET [![NuGet](https://img.shields.io/nuget/v/Aspose.Words-Cloud.svg)](https://www.nuget.org/packages/Aspose.Words-Cloud/)
This repository contains Aspose.Words Cloud SDK for .NET source code. This SDK allows you to work with Aspose.Words Cloud REST APIs in your .NET applications quickly and easily, with zero initial cost.

[Aspose.Words Cloud](https://products.aspose.cloud/words/family "Aspose.Words Cloud")
[API Reference](https://apireference.aspose.cloud/words/)

# Key Features
* Conversion between various document-related formats (20+ formats supported), including PDF<->Word conversion
* Mail merge and reports generation 
* Splitting Word documents
* Accessing Word document metadata and statistics
* Find and replace
* Watermarks and protection
* Full read & write access to Document Object Model, including sections, paragraphs, text, images, tables, headers/footers and many others

## How to use the SDK?

The complete source code is available in this repository folder. You can either directly use it in your project via source code or get [NuGet distribution](https://www.nuget.org/packages/Aspose.Words-Cloud/) (recommended). For more details, please visit our [documentation website](https://docs.aspose.cloud/display/wordscloud/Available+SDKs#AvailableSDKs-.NET).

### Prerequisites

To use Aspose Words for Cloud .NET SDK you need :
- have at least one version of the [.NET Framework 2.0 or later](https://dotnet.microsoft.com/download) installed.

- to register an account with [Aspose Cloud](https://www.aspose.cloud/) and lookup/create App Key and SID at [Cloud Dashboard](https://dashboard.aspose.cloud/#/apps). There is free quota available. For more details, see [Aspose Cloud Pricing](https://purchase.aspose.cloud/pricing).

### Installation

#### Install Aspose.Words-Cloud via NuGet

From the command line:

	nuget install Aspose.Words-Cloud

From Package Manager:

	PM> Install-Package Aspose.Words-Cloud

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on *Manage NuGet Packages...*
4. Click on the *Browse* tab and search for "Aspose.Words-Cloud".
5. Click on the Aspose.Words-Cloud package, select the appropriate version in the right-tab and click *Install*.

### Sample usage

The examples below show how your application have to initiate and convert "doc" file to "pdf" using Aspose.Words-Cloud library:
```csharp
var wordsApi = new WordsApi(AppKey, AppSid);
var saveOptionsData = new SaveOptionsData { SaveFormat = "pdf", FileName = "destination.pdf" };
var request = new PostDocumentSaveAsRequest("fileStoredInCloud.doc", saveOptionsData);            
wordsApi.PostDocumentSaveAs(request);
```

[Tests](Aspose.Words.Cloud.Sdk.Tests) contain various examples of using the SDK.  For other examples, check the product [Developer Guide](https://docs.aspose.cloud/display/wordscloud/Developer+Guide).

## Dependencies
- [.NET Framework 2.0 or later](https://dotnet.microsoft.com/download ".NET Framework 2.0 or later")
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/)

## Licensing
 
All Aspose.Words Cloud SDKs, helper scripts and templates are licensed under [MIT License](https://github.com/aspose-words-cloud/aspose-words-cloud-dotnet/blob/master/License/LICENSE). 
Licenses for dependencies can be found [here](https://github.com/aspose-words-cloud/aspose-words-cloud-dotnet/blob/master/License/thirdpartylicenses-Aspose.Words%20Cloud%20SDK%20for%20.NET.txt "here")

## Contact Us
Your feedback is very important to us. Please feel free to contact us using our [Support Forums](https://forum.aspose.cloud/c/words).

## Resources
 
[Website](https://www.aspose.cloud/)
[Product Home](https://products.aspose.cloud/words/family)
[API Reference](https://apireference.aspose.cloud/words/)
[Documentation](https://docs.aspose.cloud/display/wordscloud/Home)
[Blog](https://blog.aspose.cloud/category/words/)
 
## Other languages
We generate our SDKs in different languages so you may check if yours is available in our [list](https://github.com/aspose-words-cloud).
 
If you don't find your language in the list, feel free to request it from us, or use raw REST API requests as you can find it [here](https://products.aspose.cloud/words/curl).
