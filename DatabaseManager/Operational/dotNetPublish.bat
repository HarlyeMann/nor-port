rem SQL2X Generated code based on a SQL Server Schema
rem SQL2X Version: 1.0
rem http://sql2x.org/
rem Generated Date: 12/28/2020 7:50:04 AM
rem From Machine: DESKTOP-BP3OHLH
rem Template: SQL2XExtensionV3.SQL2XExtensionCreatorNorSolution.ExecuteDatabaseManager
cd C:\SQL2XProjects\SolutionNorSolutionPort\DatabaseManager
dotnet restore DatabaseManager.csproj
dotnet build DatabaseManager.csproj
dotnet publish DatabaseManager.csproj
dotnet bin\Debug\netcoreapp2.0\DatabaseManager.dll
