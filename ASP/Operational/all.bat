﻿rem SQL2X Generated code based on a SQL Server Schema
rem SQL2X Version: 1.0
rem http://sql2x.org/
rem Generated Date: 12/30/2020 6:40:26 AM
rem From Machine: DESKTOP-LSRVP12
rem Template: sql2x.PrototypeDotNetCoreTwoOoneV3.Content_allDOTBat
rem Create new .net core 2.1 project
cd ..
rem Fix packages
dotnet new razorrem Fix packages
dotnet restore  ASP.csproj
rem Build
dotnet build  ASP.csproj
rem Run
dotnet publish  ASP.csproj
cd Operational
call publish
echo Done
pause
