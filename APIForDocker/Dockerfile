FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
ENV ASPNETCORE_URLS http://+83
EXPOSE 83


FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["APIForDocker/APIForDocker.csproj", "APIForDocker/"]
RUN dotnet restore "APIForDocker/APIForDocker.csproj"
COPY . .
WORKDIR "/src/APIForDocker"
RUN dotnet build "APIForDocker.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "APIForDocker.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "APIForDocker.dll"]