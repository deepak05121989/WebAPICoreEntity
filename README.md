# CoreAPIEntityFrameworkDemo
- Create ASP.Net Core Web API Project
- Add Entity Framework and Create Tables
- Create Service to perform CRUD Operation
- Implement Service in Controller
- Test API Using Swagger

# Install the Following NuGet Packages.

- Microsoft.EntityFrameworkCore.SqlServer: This package is used to interact with SQL Server from our C# and .Net Core.
- Microsoft.EntityFrameworkCore.Tools: This package is contained various commands like Add-Migration, Drop-Database, Get-DbContext, Get-Migration, Remove-Migration, - --- Scaffold-DbContext, Script-Migration, Update-Database. In this article, we use Add-Migration and Update-Database commands.
- Microsoft.Extensions.Configuration: Using this NuGet package we can read data from our app setting file. We will get our connection string from the app setting file.

# Add the following command.

- Add-Migration Init
  - Here Init is our name of migration, you can give as per your choice. Hit enter. Then As you can see in your solution new folder named Migration is created and in  
    this project, there are two files. One is EmpContextModelSnapshot and another one is *_Init, here * mean date time stamp.

- For now, our database and table are not created to make changes in the Server-side use below command.
  - Update-Database
