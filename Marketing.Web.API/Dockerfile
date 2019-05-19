FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Marketing.Web.API/Marketing.Web.API.csproj", "Marketing.Web.API/"]
RUN dotnet restore "Marketing.Web.API/Marketing.Web.API.csproj"
COPY . .
WORKDIR "/src/Marketing.Web.API"
RUN dotnet build "Marketing.Web.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Marketing.Web.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Marketing.Web.API.dll"]