FROM mcr.microsoft.com/dotnet/core/runtime:3.0 AS base
WORKDIR /app


FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /src
COPY ["hospital-service-loader-tlhow/hospital-service-loader-tlhow.csproj", "hospital-service-loader-tlhow/"]
COPY nuget.config ./
RUN dotnet restore --configfile nuget.config "hospital-service-loader-tlhow/hospital-service-loader-tlhow.csproj"
COPY . .
WORKDIR "/src/hospital-service-loader-tlhow"
RUN dotnet build "hospital-service-loader-tlhow.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "hospital-service-loader-tlhow.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "hospital-service-loader-tlhow.dll"]