FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["EmployeeDatabase.csproj", "src/EmployeeDatabase/"]
RUN dotnet restore "src/EmployeeDatabase/EmployeeDatabase.csproj"
WORKDIR "/src/EmployeeDatabase"
COPY . .
RUN dotnet build "EmployeeDatabase.csproj" -c Debug -o /app/build

FROM build AS publish
RUN dotnet publish "EmployeeDatabase.csproj" -c Debug -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EmployeeDatabase.dll"]