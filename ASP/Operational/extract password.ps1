﻿# SQL2X Generated code based on a SQL Server Schema
# SQL2X Version: 1.0
# http://sql2x.org/
# Generated Date: 1/5/2021 9:29:24 AM
# From Machine: DESKTOP-LSRVP12
# Template: sql2x.PrototypeDotNetCoreTwoOoneV3.Content_extractPasswordDOTps1
# extract publishing password from existing web app 
# Add-AzureAccount
# write to password file
$Xml = [xml](Get-AzureRmWebAppPublishingProfile -Format:WebDeploy -ResourceGroupName Default-Web-EastUS2 -Name NorSolutionPortCore )
$PublishProfile = $Xml.FirstChild.ChildNodes[1]   
$PublishProfile.userPWD | Out-File -NoNewline 'WebAppPassword.txt'
