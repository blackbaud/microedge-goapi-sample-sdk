## Description
This project is an example of how to use the GIFTS Online API SDK, located at https://www.nuget.org/packages/MicroEdge.GoApi.SDK/. It is a C# project using .NET Core development tools, but the example authentication and get organization code is transferrable to any .NET project context, including Visual Studio projects. 

This repo also contains files to make debugging with the VS Code text editor easier. VS Code is not required to run the project, but is a useful tool for developing .NET Core applications.

## Running the Sample Console App
- Ensure you have the dotnet CLI installed. See this website for more information about .NET Core: https://www.microsoft.com/net/core#windowsvs2017
- Update Program.cs with your authentication secret and key, and the ID of an organization that exists on your client site.
- Run `dotnet restore` from a command line in the project directory to retrieve required dependencies from nuget.
- Run `dotnet run -u <API-user-key-here> -k <API-secret-key-here> -i <GIFTS-Online-organization-id-here>` to execute the console app. The name of the organization will display in the command line.
