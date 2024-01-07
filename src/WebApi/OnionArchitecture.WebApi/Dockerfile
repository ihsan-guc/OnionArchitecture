FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/WebApi/OnionArchitecture.WebApi/OnionArchitecture.WebApi.csproj", "src/WebApi/OnionArchitecture.WebApi/"]
COPY ["src/Core/OnionArchitecture.Application/OnionArchitecture.Application.csproj", "src/Core/OnionArchitecture.Application/"]
COPY ["src/Core/OnionArchitecture.Domain/OnionArchitecture.Domain.csproj", "src/Core/OnionArchitecture.Domain/"]
COPY ["src/Infrastructure/OnionArchitecture.Persistence/OnionArchitecture.Persistence.csproj", "src/Infrastructure/OnionArchitecture.Persistence/"]
RUN dotnet restore "./src/WebApi/OnionArchitecture.WebApi/./OnionArchitecture.WebApi.csproj"
COPY . .
WORKDIR "/src/src/WebApi/OnionArchitecture.WebApi"
RUN dotnet build "./OnionArchitecture.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./OnionArchitecture.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish 

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OnionArchitecture.WebApi.dll"]