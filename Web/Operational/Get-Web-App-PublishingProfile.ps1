# SQL2X Generated code based on a SQL Server Schema
# SQL2X Version: 1.0
# http://sql2x.org/
# Generated Date: 1/6/2021 5:15:34 PM
# Template: sql2x.AzureBase.ExecutePowerShell
# From: sql2x.AzureBase.WebAppPublishingProfileGet
$username = 'emailPersonal@Second.com';
$securePassword = ConvertTo-SecureString -String 'azureActiveDirectoryPassword' -AsPlainText -Force;
$cred = New-Object System.Management.Automation.PSCredential ($username, $securePassword);
Add-AzureRmAccount -Credential $cred;
Select-AzureRmSubscription -SubscriptionName 'Free Trial'
Get-AzureRmWebAppPublishingProfile  `
 -Name NorSolutionPort `
 -OutputFile C:\SQL2XProjects\SolutionNorSolutionPort\Web\Operational\NorSolutionPort.publishSettings `
 -Format WebDeploy `
 -ResourceGroupName Default-Web-EastUS2
