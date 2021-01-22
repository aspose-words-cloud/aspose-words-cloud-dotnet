FROM git.auckland.dynabic.com:4567/words-cloud/api/net/buildenv


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
RUN dotnet build Aspose.Words.Cloud.Sdk.sln