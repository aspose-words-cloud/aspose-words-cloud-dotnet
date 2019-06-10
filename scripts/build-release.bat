:Build a release
c:\build\.nuget\NuGet.exe restore c:\build\Aspose.Words.Cloud.Sdk.sln || goto end
c:\build\tools\specflow\specflow.exe generateall  c:\\build\Aspose.Words.Cloud.Sdk.BddTests\Aspose.Words.Cloud.Sdk.BddTests.csproj /force /verbose || goto end
msbuild c:\build\Aspose.Words.Cloud.Sdk.sln /p:Configuration=Release || goto end

:Create a strong name PE library and sign it
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\Bin\NETFX 4.6.1 Tools\x64\ildasm" c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\net2\Aspose.Words.Cloud.Sdk.dll /out=c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.il || goto end
"C:\Windows\Microsoft.NET\Framework\v2.0.50727\ilasm" c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.il /res=c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.res /dll /key=c:\Build\Scripts\aspose.snk /out=c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.dll || goto end
c:\\build\tools\\signtool.exe sign /f c:\Build\Scripts\aspose.pfx /fd sha256 /p f27Hp99Ds3 /tr http://timestamp.comodoca.com/?td=sha256 /td sha256 /v c:\Build\Aspose.Words.Cloud.Sdk\bin\\Release\Aspose.Words.Cloud.Sdk.dll || goto end

:Check the strong name and the signature
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\Bin\NETFX 4.6.1 Tools\x64\sn" -vf c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.dll || goto end
c:\\build\tools\signtool.exe verify /pa c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.dll || goto end

:Build nuget package
mkdir c:\Build\package\lib\net2 -p || goto end
copy c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.dll c:\Build\package\lib\net2\ || goto end
copy c:\Build\Aspose.Words.Cloud.Sdk\Aspose.Words.Cloud.Sdk.Net.nuspec c:\Build\package\ || goto end
c:\Build\.nuget\NuGet.exe" pack c:\Build\package\Aspose.Words.Cloud.Sdk.Net.nuspec || goto end

:Replace the nuget package with a new version
for %%f in (c:\Build\*.nupkg) do c:\Build\.nuget\NuGet.exe add %%~f -Source c:\Build\packages || goto end
dotnet remove c:\Build\Aspose.Words.Cloud.Sdk.Tests\Aspose.Words.Cloud.Sdk.Tests.csproj reference ..\Aspose.Words.Cloud.Sdk\Aspose.Words.Cloud.Sdk.csproj || goto end
dotnet add c:\Build\Aspose.Words.Cloud.Sdk.Tests\Aspose.Words.Cloud.Sdk.Tests.csproj package Aspose.Words.Cloud.Sdk.Net -s c:\Build\packages || goto end
dotnet remove c:\Build\Aspose.Words.Cloud.Sdk.BddTests\Aspose.Words.Cloud.Sdk.BddTests.csproj reference ..\Aspose.Words.Cloud.Sdk\Aspose.Words.Cloud.Sdk.csproj || goto end
dotnet add c:\Build\Aspose.Words.Cloud.Sdk.BddTests\Aspose.Words.Cloud.Sdk.BddTests.csproj package Aspose.Words.Cloud.Sdk.Net -s c:\Build\packages || goto end

:Build tests
msbuild c:\build\Aspose.Words.Cloud.Sdk.sln /p:Configuration=Release

:end
exit /b %ERRORLEVEL%

