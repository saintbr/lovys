FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["identity/Lovys.Identity/Lovys.Identity.csproj", "identity/Lovys.Identity/"]
RUN dotnet restore "identity/Lovys.Identity/Lovys.Identity.csproj"
COPY . .
WORKDIR "/src/identity/Lovys.Identity"
RUN dotnet build "Lovys.Identity.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Lovys.Identity.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Lovys.Identity.dll"]