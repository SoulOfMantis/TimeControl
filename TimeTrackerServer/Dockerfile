FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["TimeTrackerServer/TimeTrackerServer.csproj", "."]
RUN dotnet restore "./TimeTrackerServer.csproj"
COPY . .
WORKDIR "/src/TimeTrackerServer"
RUN dotnet build "TimeTrackerServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TimeTrackerServer.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=publish /app/publish .

# Установка curl для healthcheck
RUN apt-get update && apt-get install -y curl && rm -rf /var/lib/apt/lists/*

EXPOSE 5000
ENV ASPNETCORE_URLS=http://*:5000
ENTRYPOINT ["dotnet", "TimeTrackerServer.dll"]