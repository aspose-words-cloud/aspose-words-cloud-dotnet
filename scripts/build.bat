c:\\build\.nuget\NuGet.exe restore c:\\build\Aspose.Words.Cloud.Sdk.sln
c:\\build\tools\specflow\specflow.exe generateall  c:\\build\Aspose.Words.Cloud.Sdk.BddTests\\Aspose.Words.Cloud.Sdk.BddTests.csproj /force /verbose
msbuild c:\\build\Aspose.Words.Cloud.Sdk.sln /p:OutputPath=c:\Build\BuildOut\