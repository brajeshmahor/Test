FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["FORGIT/FORGIT.csproj", "FORGIT/"]
RUN dotnet restore "FORGIT/FORGIT.csproj"
COPY . .
WORKDIR "/src/FORGIT"
RUN dotnet build "FORGIT.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "FORGIT.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "FORGIT.dll"]