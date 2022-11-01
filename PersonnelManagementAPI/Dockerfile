FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PersonnelManagementAPI/PersonnelManagementAPI.csproj", "PersonnelManagementAPI/"]
RUN dotnet restore "PersonnelManagementAPI/PersonnelManagementAPI.csproj"
COPY . .
WORKDIR "/src/PersonnelManagementAPI"
RUN dotnet build "PersonnelManagementAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PersonnelManagementAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PersonnelManagementAPI.dll"]
