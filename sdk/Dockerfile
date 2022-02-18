FROM mcr.microsoft.com/dotnet/core/sdk:3.1

RUN mkdir -p /usr/src
WORKDIR /usr/src

COPY Finbourne.Luminesce.Sdk.Extensions.sln /usr/src/
COPY Finbourne.Luminesce.Sdk.Extensions/Finbourne.Luminesce.Sdk.Extensions.csproj /usr/src/Finbourne.Luminesce.Sdk.Extensions/
COPY Finbourne.Luminesce.Sdk.Extensions.Tests/Finbourne.Luminesce.Sdk.Extensions.Tests.csproj /usr/src/Finbourne.Luminesce.Sdk.Extensions.Tests/
COPY Finbourne.Luminesce.Sdk.Extensions.Tutorials/Finbourne.Luminesce.Sdk.Extensions.Tutorials.csproj /usr/src/Finbourne.Luminesce.Sdk.Extensions.Tutorials/
RUN dotnet restore Finbourne.Luminesce.Sdk.Extensions

ENV FBN_LUMINESCE_API_URL ${FBN_LUMINESCE_API_URL}

# ENTRYPOINT [ "/bin/bash" ]
ENTRYPOINT dotnet test --configuration Release --verbosity normal Finbourne.Luminesce.Sdk.Extensions