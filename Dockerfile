FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Копируем sln и csproj
COPY WorkoutTracker.sln .
COPY WorkoutTracker/WorkoutTracker.csproj WorkoutTracker/

# Дебаг: проверяем файлы
RUN ls -la && ls -la WorkoutTracker/

# Восстанавливаем зависимости
RUN dotnet restore WorkoutTracker/WorkoutTracker.csproj --source https://api.nuget.org/v3/index.json --verbosity detailed /p:EnableWindowsTargeting=true

# Копируем код
COPY WorkoutTracker/ WorkoutTracker/

# Собираем проект
WORKDIR /app/WorkoutTracker
RUN dotnet publish -c Release -o /app/publish /p:EnableWindowsTargeting=true

# Финальный образ
FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app/publish .

# Выводим сообщение, так как GUI не поддерживается
CMD ["echo", "WorkoutTracker built successfully. GUI not supported in Docker."]