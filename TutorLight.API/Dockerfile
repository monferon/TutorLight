FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["TutorLight.API/TutorLight.API.csproj", "TutorLight.API/"]
RUN dotnet restore "TutorLight.API/TutorLight.API.csproj"
COPY . .
WORKDIR "/src/TutorLight.API"
RUN dotnet build "TutorLight.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TutorLight.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TutorLight.API.dll"]
