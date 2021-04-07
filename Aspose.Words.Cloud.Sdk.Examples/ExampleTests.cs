using System;
using System.IO;
using Aspose.Words.Cloud.Sdk;
using Aspose.Words.Cloud.Sdk.Model.Requests;
using NUnit.Framework;

[TestFixture]
public partial class ExampleTests
{
    private Configuration config = null;

    [OneTimeSetUp]
    public void SetUp()
    {
        Environment.CurrentDirectory = Path.Combine(Aspose.Words.Cloud.Sdk.Tests.Base.DirectoryHelper.GetRootSdkFolder(), "ExamplesData");
        var configKeys = Aspose.Words.Cloud.Sdk.Tests.Base.BaseTestContext.GetConfig();
        config = new Configuration {
            ApiBaseUrl = configKeys.BaseUrl,
            ClientId = configKeys.ClientId,
            ClientSecret = configKeys.ClientSecret
        };

        var wordsApi = new WordsApi(config);
        using (var stream =  File.OpenRead("test_doc.docx"))
        {
            wordsApi.UploadFile(new UploadFileRequest(stream, "test_doc.docx"));
        }
    }
}