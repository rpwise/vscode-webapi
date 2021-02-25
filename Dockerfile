FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base 
WORKDIR /app
EXPOSE 80
EXPOSE 443
ENV ASPNETCORE_URLS=http://*:5000

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["vscode-webapi.csproj", "./"]
RUN dotnet restore "vscode-webapi.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "vscode-webapi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "vscode-webapi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "vscode-webapi.dll"]
