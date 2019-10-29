:Create folder structure
if exist c:\Build\package rmdir c:\Build\package /S /Q
mkdir c:\Build\package\lib\net20 || goto end
mkdir c:\Build\package\lib\netstandard2.0 || goto end
mkdir c:\Build\package\License || goto end

:Build a release
c:\build\.nuget\NuGet.exe restore c:\build\Aspose.Words.Cloud.Sdk.sln || goto end
msbuild c:\build\Aspose.Words.Cloud.Sdk.sln /p:Configuration=Release || goto end

:Create a strong name PE .net 2.0 library and sign it
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\Bin\NETFX 4.6.1 Tools\x64\ildasm" c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\net20\Aspose.Words.Cloud.Sdk.dll /out=c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.il || goto end
"C:\Windows\Microsoft.NET\Framework\v2.0.50727\ilasm" c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.il /res=c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.res /dll /key=c:\Build\Scripts\aspose.snk /out=c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.dll || goto end
c:\\build\tools\\signtool.exe sign /f c:\Build\Scripts\aspose.pfx /fd sha256 /p f27Hp99Ds3 /tr http://timestamp.comodoca.com/?td=sha256 /td sha256 /v c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.dll || goto end

:Check the strong name and the signature for .net 2.0 library
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\Bin\NETFX 4.6.1 Tools\x64\sn" -vf c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.dll || goto end
c:\\build\tools\signtool.exe verify /pa c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.dll || goto end

:Copy dll to package folder
copy c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.dll c:\Build\package\lib\net20\ || goto end

:Create a strong name PE .net standard 2.0 library and sign it
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\Bin\NETFX 4.6.1 Tools\x64\ildasm" c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\netstandard2.0\Aspose.Words.Cloud.Sdk.dll /out=c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.il || goto end
"C:\Windows\Microsoft.NET\Framework\v2.0.50727\ilasm" c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.il /res=c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.res /dll /key=c:\Build\Scripts\aspose.snk /out=c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.dll || goto end
c:\\build\tools\\signtool.exe sign /f c:\Build\Scripts\aspose.pfx /fd sha256 /p f27Hp99Ds3 /tr http://timestamp.comodoca.com/?td=sha256 /td sha256 /v c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.dll || goto end

:Check the strong name and the signature for .net standard 2.0 library
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\Bin\NETFX 4.6.1 Tools\x64\sn" -vf c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.dll || goto end
c:\\build\tools\signtool.exe verify /pa c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.dll || goto end

:Copy dll to package folder
copy c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.dll c:\Build\package\lib\netstandard2.0\ || goto end

:Build nuget package
copy c:\Build\Aspose.Words.Cloud.Sdk\Aspose.Words-Cloud.nuspec c:\Build\package\ || goto end
copy c:\Build\License c:\Build\package\License || goto end
"c:\Build\.nuget\NuGet.exe" pack c:\Build\package\Aspose.Words-Cloud.nuspec -OutputDirectory c:\Build\packages  -properties version=%SDK_VERSION% || goto end

:Replace the nuget package with a new version
c:\Build\.nuget\NuGet.exe add c:\Build\packages\Aspose.Words-Cloud.%SDK_VERSION%.0.nupkg -Source c:\Build\packages || goto end
dotnet remove c:\Build\Aspose.Words.Cloud.Sdk.Tests\Aspose.Words.Cloud.Sdk.Tests.csproj reference ..\Aspose.Words.Cloud.Sdk\Aspose.Words.Cloud.Sdk.csproj || goto end
dotnet add c:\Build\Aspose.Words.Cloud.Sdk.Tests\Aspose.Words.Cloud.Sdk.Tests.csproj package Aspose.Words-Cloud -s c:\Build\packages -v %SDK_VERSION%.0 || goto end
dotnet remove c:\Build\Aspose.Words.Cloud.Sdk.BddTests\Aspose.Words.Cloud.Sdk.BddTests.csproj reference ..\Aspose.Words.Cloud.Sdk\Aspose.Words.Cloud.Sdk.csproj || goto end
dotnet add c:\Build\Aspose.Words.Cloud.Sdk.BddTests\Aspose.Words.Cloud.Sdk.BddTests.csproj package Aspose.Words-Cloud -s c:\Build\packages -v %SDK_VERSION%.0 || goto end

:Build tests
c:\build\.nuget\NuGet.exe restore c:\build\Aspose.Words.Cloud.Sdk.sln || goto end
msbuild c:\build\Aspose.Words.Cloud.Sdk.sln

:end
exit /b %ERRORLEVEL%

