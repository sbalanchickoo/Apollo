FROM microsoft/aspnetcore:2.0-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-1709 AS build
WORKDIR /src
COPY Apollo.HelloWorld.ASPNet/Apollo.HelloWorld.ASPNet.csproj Apollo.HelloWorld.ASPNet/
RUN dotnet restore Apollo.HelloWorld.ASPNet/Apollo.HelloWorld.ASPNet.csproj
COPY . .
WORKDIR /src/Apollo.HelloWorld.ASPNet
RUN dotnet build Apollo.HelloWorld.ASPNet.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Apollo.HelloWorld.ASPNet.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Apollo.HelloWorld.ASPNet.dll"]
