dotnet restore c:\build\Aspose.Words.Cloud.Sdk\Aspose.Words.Cloud.Sdk.csproj
dotnet restore c:\build\Aspose.Words.Cloud.Sdk.%1\Aspose.Words.Cloud.Sdk.%1.csproj
dotnet test c:\build\Aspose.Words.Cloud.Sdk.%1\Aspose.Words.Cloud.Sdk.%1.csproj --framework netcoreapp2.1 --logger "junit;LogFilePath=c:\Build\testResults\%1%2-results-netcoreapp2.1.xml" --no-restore --no-build