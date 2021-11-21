# See https://aka.ms/containerfastmode to understand how
# Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

ARG SERVER_URL
ENV SERVER_URL_VAR=$SERVER_URL

ARG GAME_TO_RUN
ENV GAME_TO_RUN_VAR=$GAME_TO_RUN

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY Dojo/Dojo.csproj Dojo/
RUN dotnet restore "Dojo/Dojo.csproj"
COPY . ./
WORKDIR /src/Dojo
RUN dotnet build "Dojo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Dojo.csproj" -r linux-x64 -c Release -o /app/publish -p:PublishTrimmed=True

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT dotnet Dojo.dll "${GAME_TO_RUN_VAR}" "${SERVER_URL_VAR}"