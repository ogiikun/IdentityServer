#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["IdentityServer/Identity.Server/Identity.Server.csproj", "IdentityServer/Identity.Server/"]
COPY ["IdentityServer/Shared/Shared/Shared.csproj", "IdentityServer/Shared/Shared/"]
RUN dotnet restore "IdentityServer/Identity.Server/Identity.Server.csproj"
COPY . .
WORKDIR "/src/IdentityServer/Identity.Server"
RUN dotnet build "Identity.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Identity.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Identity.Server.dll"]