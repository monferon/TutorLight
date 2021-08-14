FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["TutorLight.Telegram/TutorLight.Telegram.csproj", "TutorLight.Telegram/"]
RUN dotnet restore "TutorLight.Telegram/TutorLight.Telegram.csproj"
COPY . .
WORKDIR "/src/TutorLight.Telegram"
RUN dotnet build "TutorLight.Telegram.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TutorLight.Telegram.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TutorLight.Telegram.dll"]
