FROM git.auckland.dynabic.com:4567/words-cloud/api/net/buildenv


# Use shell form to start developer command prompt and any other commands specified
WORKDIR /build

SHELL ["cmd.exe", "/s", "/c"]
COPY . .
RUN dotnet build Aspose.Words.Cloud.Sdk.sln