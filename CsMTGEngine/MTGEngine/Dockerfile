FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MTGEngine/MTGEngine.csproj", "MTGEngine/"]
RUN dotnet restore "MTGEngine/MTGEngine.csproj"
COPY . .
WORKDIR "/src/MTGEngine"
RUN dotnet build "MTGEngine.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MTGEngine.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MTGEngine.dll"]
