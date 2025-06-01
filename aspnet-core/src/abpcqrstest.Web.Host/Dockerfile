FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/abpcqrstest.Web.Host/abpcqrstest.Web.Host.csproj", "src/abpcqrstest.Web.Host/"]
COPY ["src/abpcqrstest.Web.Core/abpcqrstest.Web.Core.csproj", "src/abpcqrstest.Web.Core/"]
COPY ["src/abpcqrstest.Application/abpcqrstest.Application.csproj", "src/abpcqrstest.Application/"]
COPY ["src/abpcqrstest.Core/abpcqrstest.Core.csproj", "src/abpcqrstest.Core/"]
COPY ["src/abpcqrstest.EntityFrameworkCore/abpcqrstest.EntityFrameworkCore.csproj", "src/abpcqrstest.EntityFrameworkCore/"]
WORKDIR "/src/src/abpcqrstest.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/abpcqrstest.Web.Host", "src/abpcqrstest.Web.Host"]
COPY ["src/abpcqrstest.Web.Core", "src/abpcqrstest.Web.Core"]
COPY ["src/abpcqrstest.Application", "src/abpcqrstest.Application"]
COPY ["src/abpcqrstest.Core", "src/abpcqrstest.Core"]
COPY ["src/abpcqrstest.EntityFrameworkCore", "src/abpcqrstest.EntityFrameworkCore"]
WORKDIR "/src/src/abpcqrstest.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "abpcqrstest.Web.Host.dll"]
