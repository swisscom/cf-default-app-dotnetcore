# CF Default App .NET Core

The default .NET Core app that will be pushed in the Swisscom Application Cloud if no source code is provided

Based on [ASP.NET Core](https://www.asp.net/core)

## Run locally

1. Install [.NET Core](https://www.microsoft.com/net/core)
1. Run `dotnet restore`
1. Run `dotnet run`
1. Visit [http://localhost:5000](http://localhost:5000)

## Run in the cloud

1. Install the [cf CLI](https://github.com/cloudfoundry/cli#downloads)
1. Run `cf push --random-route`
1. Visit the given URL

## Create ZIP

1. Run `zip -r dotnetcore_app.zip Controllers Views wwwroot Program.cs Startup.cs cf-default-app-dotnetcore.csproj`
