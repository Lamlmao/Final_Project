FROM mcr.microsoft.com/dotnet/aspnet:7.0 as base 
WORKDIR /app
EXPOSE 80
EXPOSE 443 

FROM mcr.microsoft.com/dotnet/sdk:7.0 as build
WORKDIR /src 

COPY . .

RUN dotnet build web_api.csproj -c Release -o /app/build

RUN dotnet publish "web_api.csproj" -c Release -o /app/publish

FROM base
WORKDIR /app
COPY --from=build /app/publish . 
ENTRYPOINT [ "dotnet" , "web_api.dll"] 