FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src/TimeTrackerClient
COPY ["TimeTrackerClient/TimeTrackerClient.csproj", "."]
RUN dotnet restore "TimeTrackerClient.csproj"
COPY /TimeTrackerClient .
RUN dotnet build "TimeTrackerClient.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TimeTrackerClient.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TimeTrackerClient.dll"]