#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Src/OrganizeIt.Tasks.WebApi/OrganizeIt.Tasks.WebApi.csproj", "Src/OrganizeIt.Tasks.WebApi/"]
COPY ["Src/OrganizeIt.Tasks.Application/OrganizeIt.Tasks.Application.csproj", "Src/OrganizeIt.Tasks.Application/"]
COPY ["Src/OrganizeIt.Tasks.Persistence/OrganizeIt.Tasks.Persistence.csproj", "Src/OrganizeIt.Tasks.Persistence/"]
COPY ["Src/OrganizeIt.Tasks.Domain/OrganizeIt.Tasks.Domain.csproj", "Src/OrganizeIt.Tasks.Domain/"]
COPY ["Src/OrganizeIt.Tasks.Infrastructure/OrganizeIt.Tasks.Infrastructure.csproj", "Src/OrganizeIt.Tasks.Infrastructure/"]
RUN dotnet restore "Src/OrganizeIt.Tasks.WebApi/OrganizeIt.Tasks.WebApi.csproj"
COPY . .
WORKDIR "/src/Src/OrganizeIt.Tasks.WebApi"
RUN dotnet build "OrganizeIt.Tasks.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OrganizeIt.Tasks.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OrganizeIt.Tasks.WebApi.dll"]