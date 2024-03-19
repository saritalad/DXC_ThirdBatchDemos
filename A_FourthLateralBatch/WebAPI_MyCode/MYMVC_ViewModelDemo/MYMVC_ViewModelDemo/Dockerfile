#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["MYMVC_ViewModelDemo/MYMVC_ViewModelDemo.csproj", "MYMVC_ViewModelDemo/"]
RUN dotnet restore "MYMVC_ViewModelDemo/MYMVC_ViewModelDemo.csproj"
COPY . .
WORKDIR "/src/MYMVC_ViewModelDemo"
RUN dotnet build "MYMVC_ViewModelDemo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MYMVC_ViewModelDemo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MYMVC_ViewModelDemo.dll"]