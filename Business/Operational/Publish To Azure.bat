rem SQL2X Generated code based on a SQL Server Schema
rem SQL2X Version: 1.0
rem http://sql2x.org/
rem Generated Date: 1/6/2021 5:05:09 PM
rem Template: sql2x.AzureBase.ExecuteDOSIncognito
rem From: SQL2XExtension.SQL2XExtensionCreatorCoreV0.PublishDotNetFrameworkFolderToAzureByPublishSettingsAndMSDeploy
"C:\Program Files (x86)\IIS\Microsoft Web Deploy V3\msdeploy.exe" ^
 -verb:sync ^
 -source:contentPath=C:\SQL2XProjects\SolutionNorSolutionPort\Business\obj\Debug\Package\PackageTmp ^
 -dest:contentPath=d:\home\site\wwwroot\,publishSettings=C:\SQL2XProjects\SolutionNorSolutionPort\Business\Operational\NorSolutionPortBusiness.publishSettings ^
