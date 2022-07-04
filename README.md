# CodeFirst

## Project Type: ASP.Net Core MVC ##

* Create simple User Model and Storage Model
* Generated Table via Entity Framework
<br>

Task          | Command
------------- | -------------
Migration | dotnet ef migrations add _MigrationName_
Controller | dotnet aspnet-codegenerator controller -name _ControllerName_ -async -api -m _ModelName_ -dc _ContextClassName_ -outDir Controllers
database | dotnet ef database update
