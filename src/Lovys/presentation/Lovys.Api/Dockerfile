FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["presentation/Lovys.Api/Lovys.Api.csproj", "presentation/Lovys.Api/"]
COPY ["presentation/Lovys.Api.Core/Lovys.Api.Core.csproj", "presentation/Lovys.Api.Core/"]
RUN dotnet restore "presentation/Lovys.Api/Lovys.Api.csproj"
COPY . .
WORKDIR "/src/presentation/Lovys.Api"
RUN dotnet build "Lovys.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Lovys.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Lovys.Api.dll"]