FROM mcr.microsoft.com/dotnet/core/sdk:3.1

RUN mkdir -p /usr/src
WORKDIR /usr/src

COPY Finbourne.Luminesce.Sdk.Extensions.sln /usr/src/
COPY Finbourne.Luminesce.Sdk.Extensions/Finbourne.Luminesce.Sdk.Extensions.csproj /usr/src/Finbourne.Luminesce.Sdk.Extensions/
COPY Finbourne.Luminesce.Sdk.Extensions.Tests/Finbourne.Luminesce.Sdk.Extensions.Tests.csproj /usr/src/Finbourne.Luminesce.Sdk.Extensions.Tests/
COPY Finbourne.Luminesce.Sdk.Extensions.IntegrationTests/Finbourne.Luminesce.Sdk.Extensions.IntegrationTests.csproj /usr/src/Finbourne.Luminesce.Sdk.Extensions.IntegrationTests/
RUN dotnet restore Finbourne.Luminesce.Sdk.Extensions

ENTRYPOINT dotnet test --configuration Release --verbosity normal