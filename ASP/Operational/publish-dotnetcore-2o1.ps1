﻿# SQL2X Generated code based on a SQL Server Schema
# SQL2X Version: 1.0
# http://sql2x.org/
# Generated Date: 1/5/2021 9:29:52 AM
# Template: sql2x.AzureBase.ExecutePowerShell
# From: sql2x.Azure.DotNetTwoOonePublish
dotnet `
 clean C:\SQL2XProjects\SolutionNorSolutionPort\ASP\ASP.csproj `
 --output C:\SQL2XProjects\SolutionNorSolutionPort\ASP\bin\Debug\netcoreapp2.1\publish\ 
;
Remove-Item -Force -Recurse -Path C:\SQL2XProjects\SolutionNorSolutionPort\ASP\bin\Debug\netcoreapp2.1\publish;
dotnet `
 publish C:\SQL2XProjects\SolutionNorSolutionPort\ASP\ASP.csproj `
 --output C:\SQL2XProjects\SolutionNorSolutionPort\ASP\bin\Debug\netcoreapp2.1\publish\ 
;
