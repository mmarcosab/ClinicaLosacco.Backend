#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["src/ClinicaLosacco.APi/ClinicaLosacco.API.csproj", "src/ClinicaLosacco.APi/"]
COPY ["src/ClinicaLosacco.Infra/ClinicaLosacco.Infra.csproj", "src/ClinicaLosacco.Infra/"]
COPY ["src/ClinicaLosacco.Core/ClinicaLosacco.Core.csproj", "src/ClinicaLosacco.Core/"]
COPY ["src/ClinicaLosacco.Application/ClinicaLosacco.Application.csproj", "src/ClinicaLosacco.Application/"]
RUN dotnet restore "src/ClinicaLosacco.APi/ClinicaLosacco.API.csproj"
COPY . .
WORKDIR "/src/src/ClinicaLosacco.APi"
RUN dotnet build "ClinicaLosacco.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ClinicaLosacco.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ClinicaLosacco.API.dll"]