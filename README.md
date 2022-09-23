# Wideroe.Interview
git clone
dotnet build
dotnet test

# Missing dotnet sdk?
winget install Microsoft.DotNet.SDK.6

# Solution/projects does not work
dotnet new sln --name Wideroe.Interview
dotnet new classlib --name Wideroe.Interview.RunwayResolver
dotnet new xunit --name Wideroe.Interview.RunwayResolver.Test

dotnet sln add .\Wideroe.Interview.RunwayResolver\Wideroe.Interview.RunwayResolver.csproj
dotnet sln add .\Wideroe.Interview.RunwayResolver.Test\Wideroe.Interview.RunwayResolver.Test.csproj
dotnet add .\Wideroe.Interview.RunwayResolver.Test\Wideroe.Interview.RunwayResolver.Test.csproj reference .\Wideroe.Interview.RunwayResolver\Wideroe.Interview.RunwayResolver.csproj

dotnet restore