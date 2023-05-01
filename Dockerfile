FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["src/FlexiCoudPay.Web.Host/FlexiCoudPay.Web.Host.csproj", "src/FlexiCoudPay.Web.Host/"]
COPY ["src/FlexiCoudPay.Web.Core/FlexiCoudPay.Web.Core.csproj", "src/FlexiCoudPay.Web.Core/"]
COPY ["src/FlexiCoudPay.Application/FlexiCoudPay.Application.csproj", "src/FlexiCoudPay.Application/"]
COPY ["src/FlexiCoudPay.Core/FlexiCoudPay.Core.csproj", "src/FlexiCoudPay.Core/"]
COPY ["src/FlexiCoudPay.EntityFrameworkCore/FlexiCoudPay.EntityFrameworkCore.csproj", "src/FlexiCoudPay.EntityFrameworkCore/"]
WORKDIR "/src/src/FlexiCoudPay.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/FlexiCoudPay.Web.Host", "src/FlexiCoudPay.Web.Host"]
COPY ["src/FlexiCoudPay.Web.Core", "src/FlexiCoudPay.Web.Core"]
COPY ["src/FlexiCoudPay.Application", "src/FlexiCoudPay.Application"]
COPY ["src/FlexiCoudPay.Core", "src/FlexiCoudPay.Core"]
COPY ["src/FlexiCoudPay.EntityFrameworkCore", "src/FlexiCoudPay.EntityFrameworkCore"]
WORKDIR "/src/src/FlexiCoudPay.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "FlexiCoudPay.Web.Host.dll"]
