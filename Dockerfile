FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["User-Microservice.csproj", "./"]
RUN dotnet restore "./User-Microservice.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "User-Microservice.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "User-Microservice.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "User-Microservice.dll"]
