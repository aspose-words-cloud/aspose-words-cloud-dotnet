:Create folder structure
if exist c:\Build\package rmdir c:\Build\package /S /Q
mkdir c:\Build\package\lib\netstandard2.0 || goto end
mkdir c:\Build\package\License || goto end

:Build a release
dotnet build c:\build\Aspose.Words.Cloud.Sdk.sln -c Release || goto end

:Create a strong name PE .net standard 2.0 library and sign it
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\Bin\NETFX 4.6.1 Tools\x64\ildasm" c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\netstandard2.0\Aspose.Words.Cloud.Sdk.dll /out=c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.il || goto end
"C:\Windows\Microsoft.NET\Framework\v4.0.30319\ilasm" c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.il /res=c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.res /dll /key=c:\Build\Scripts\aspose.snk /out=c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.dll || goto end
c:\\build\tools\\signtool.exe sign /f c:\Build\Scripts\aspose.pfx /fd sha256 /p f27Hp99Ds3 /tr http://timestamp.comodoca.com/?td=sha256 /td sha256 /v c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.dll || goto end

:Check the strong name and the signature for .net standard 2.0 library
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\Bin\NETFX 4.6.1 Tools\x64\sn" -vf c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.dll || goto end
c:\\build\tools\signtool.exe verify /pa c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.dll || goto end

:Copy dll to package folder
copy c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.dll c:\Build\package\lib\netstandard2.0\ || goto end
copy c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.pdb c:\Build\package\lib\netstandard2.0\ || goto end
copy c:\Build\Aspose.Words.Cloud.Sdk\bin\Release\Aspose.Words.Cloud.Sdk.xml c:\Build\package\lib\netstandard2.0\ || goto end

:Build nuget package
copy c:\Build\Aspose.Words.Cloud.Sdk\Aspose.Words-Cloud.nuspec c:\Build\package\ || goto end
copy c:\Build\License c:\Build\package\License || goto end
"c:\Build\.nuget\NuGet.exe" pack c:\Build\package\Aspose.Words-Cloud.nuspec -OutputDirectory c:\Build\packages  -properties version=%SDK_VERSION%.1 || goto end
"c:\Build\.nuget\NuGet.exe" sign c:\Build\packages\Aspose.Words-Cloud.%SDK_VERSION%.1.nupkg -CertificatePath c:\Build\Scripts\aspose.pfx -Timestamper http://timestamp.comodoca.com/?td=sha256 -CertificatePassword f27Hp99Ds3 || goto end

:end
exit /b %ERRORLEVEL%


