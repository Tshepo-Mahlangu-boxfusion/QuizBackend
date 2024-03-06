FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/QuizT.Web.Host/QuizT.Web.Host.csproj", "src/QuizT.Web.Host/"]
COPY ["src/QuizT.Web.Core/QuizT.Web.Core.csproj", "src/QuizT.Web.Core/"]
COPY ["src/QuizT.Application/QuizT.Application.csproj", "src/QuizT.Application/"]
COPY ["src/QuizT.Core/QuizT.Core.csproj", "src/QuizT.Core/"]
COPY ["src/QuizT.EntityFrameworkCore/QuizT.EntityFrameworkCore.csproj", "src/QuizT.EntityFrameworkCore/"]
WORKDIR "/src/src/QuizT.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/QuizT.Web.Host", "src/QuizT.Web.Host"]
COPY ["src/QuizT.Web.Core", "src/QuizT.Web.Core"]
COPY ["src/QuizT.Application", "src/QuizT.Application"]
COPY ["src/QuizT.Core", "src/QuizT.Core"]
COPY ["src/QuizT.EntityFrameworkCore", "src/QuizT.EntityFrameworkCore"]
WORKDIR "/src/src/QuizT.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "QuizT.Web.Host.dll"]
