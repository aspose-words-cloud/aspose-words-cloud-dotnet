FROM mcr.microsoft.com/dotnet/core/sdk:3.1

SHELL ["powershell.exe", "-ExecutionPolicy", "Bypass", "-Command"]

# RUN Install-WindowsFeature NET-Framework-Features
# INSTALL PowerShell
RUN dotnet tool install --global PowerShell

#RUN Enable SSL
RUN [Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12 -bor [Net.SecurityProtocolType]::Tls11 -bor [Net.SecurityProtocolType]::Tls

# Download log collection utility
RUN $ErrorActionPreference = 'Stop'; \
	$ProgressPreference = 'SilentlyContinue'; \
	$VerbosePreference = 'Continue'; \
	Invoke-WebRequest -Uri https://aka.ms/vscollect.exe -OutFile C:\collect.exe

# Download NuGet v4.5.0
RUN $ErrorActionPreference = 'Stop'; \
	$ProgressPreference = 'SilentlyContinue'; \
	$VerbosePreference = 'Continue'; \
	New-Item -Path C:\nuget -Type Directory | Out-Null; \
	[System.Environment]::SetEnvironmentVariable('PATH', "\"${env:PATH};C:\nuget\"", 'Machine'); \
	Invoke-WebRequest -Uri "https://dist.nuget.org/win-x86-commandline/v4.5.0/nuget.exe" -OutFile C:\nuget\nuget.exe; 

# Download and install .Net 4.5.2 Developer Pack
RUN $ErrorActionPreference = 'Stop'; \
	$ProgressPreference = 'SilentlyContinue'; \
	$VerbosePreference = 'Continue'; \
	Invoke-WebRequest "https://download.microsoft.com/download/4/3/B/43B61315-B2CE-4F5B-9E32-34CCA07B2F0E/NDP452-KB2901951-x86-x64-DevPack.exe" -OutFile "$env:TEMP\NDP452-KB2901951-x86-x64-DevPack.exe" -UseBasicParsing; \
	$p = Start-Process -Wait -PassThru -FilePath "$env:TEMP\NDP452-KB2901951-x86-x64-DevPack.exe" -ArgumentList "/install","/quiet"; \
	rm "$env:TEMP\NDP452-KB2901951-x86-x64-DevPack.exe"

# Download and install .Net Core 2.1 Developer Pack
RUN $ErrorActionPreference = 'Stop'; \
	$ProgressPreference = 'SilentlyContinue'; \
	$VerbosePreference = 'Continue'; \
	Invoke-WebRequest "https://download.visualstudio.microsoft.com/download/pr/e93f0f95-6bf6-4ff9-abbe-d9c995aeb090/c62c4b5dc10ea76578043413b6997a57/dotnet-sdk-2.1.509-win-x64.exe" -OutFile "$env:TEMP\core-DevPack.exe" -UseBasicParsing; \
	$p = Start-Process -Wait -PassThru -FilePath "$env:TEMP\core-DevPack.exe" -ArgumentList "/install","/quiet"; \
	rm "$env:TEMP\core-DevPack.exe"

# Download and install Microsoft Build Tools 15
RUN $ErrorActionPreference = 'Stop'; \
	$ProgressPreference = 'SilentlyContinue'; \
	$VerbosePreference = 'Continue'; \
	Invoke-WebRequest -Uri "https://download.microsoft.com/download/3/A/B/3ABDE7FA-A349-4AF0-A3AC-0D7BB0977A32/vs_BuildTools.exe" -OutFile $env:TEMP\vs_buildtools.exe; \
	$p = Start-Process -Wait -PassThru -FilePath $env:TEMP\vs_buildtools.exe -ArgumentList '--add Microsoft.VisualStudio.Workload.MSBuildTools --add Microsoft.VisualStudio.Workload.NetCoreBuildTools --add Microsoft.VisualStudio.Workload.VCTools --add Microsoft.VisualStudio.Workload.WebBuildTools --quiet --nocache --wait --installPath C:\BuildTools'; \
	if ($ret = $p.ExitCode) { c:\collect.exe; throw ('Install failed with exit code 0x{0:x}' -f $ret) }; \
	rm "$env:TEMP\vs_buildtools.exe"

# Use shell form to start developer command prompt and any other commands specified
WORKDIR /build
COPY Aspose.Words.Cloud.Sdk/Aspose.Words.Cloud.Sdk.csproj Aspose.Words.Cloud.Sdk/Aspose.Words.Cloud.Sdk.csproj
RUN dotnet restore Aspose.Words.Cloud.Sdk/Aspose.Words.Cloud.Sdk.csproj
COPY Aspose.Words.Cloud.Sdk.Tests/Aspose.Words.Cloud.Sdk.Tests.csproj Aspose.Words.Cloud.Sdk.Tests/Aspose.Words.Cloud.Sdk.Tests.csproj
RUN dotnet restore Aspose.Words.Cloud.Sdk.Tests/Aspose.Words.Cloud.Sdk.Tests.csproj
COPY Aspose.Words.Cloud.Sdk.BddTests/Aspose.Words.Cloud.Sdk.BddTests.csproj Aspose.Words.Cloud.Sdk.BddTests/Aspose.Words.Cloud.Sdk.BddTests.csproj
RUN dotnet restore Aspose.Words.Cloud.Sdk.BddTests/Aspose.Words.Cloud.Sdk.BddTests.csproj
COPY Aspose.Words.Cloud.Sdk.sln Aspose.Words.Cloud.Sdk.sln
RUN dotnet restore Aspose.Words.Cloud.Sdk.sln

SHELL ["cmd.exe", "/s", "/c"]
COPY . .
RUN C:\BuildTools\Common7\Tools\VsDevCmd.bat && msbuild c:\build\Aspose.Words.Cloud.Sdk.sln

ENTRYPOINT C:\BuildTools\Common7\Tools\VsDevCmd.bat &&