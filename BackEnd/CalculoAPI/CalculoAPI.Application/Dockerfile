#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CalculoAPI.Application/CalculoAPI.Application.csproj", "CalculoAPI.Application/"]
RUN dotnet restore "CalculoAPI.Application/CalculoAPI.Application.csproj"
COPY . .
WORKDIR "/src/CalculoAPI.Application"
RUN dotnet build "CalculoAPI.Application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CalculoAPI.Application.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CalculoAPI.Application.dll"]