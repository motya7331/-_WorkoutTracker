FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY WorkoutTracker.sln .
COPY WorkoutTracker/WorkoutTracker.csproj WorkoutTracker/

RUN ls -la && ls -la WorkoutTracker/

RUN dotnet restore WorkoutTracker/WorkoutTracker.csproj --source https://api.nuget.org/v3/index.json --verbosity detailed /p:EnableWindowsTargeting=true

COPY WorkoutTracker/ WorkoutTracker/

WORKDIR /app/WorkoutTracker
RUN dotnet publish -c Release -o /app/publish /p:EnableWindowsTargeting=true

FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app/publish .

CMD ["echo", "WorkoutTracker built successfully. GUI not supported in Docker."]