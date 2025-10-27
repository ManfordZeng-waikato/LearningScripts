# ASP.NET Core Learning Scripts

This repository contains my practice scripts and notes while learning **ASP.NET Core**.  
The code is written for study purposes only and does not provide real application functionality.
Copyright from https://github.com/Harsha-Global/AspNetCore-Harsha

## Contents
- Basic middleware exercises  

- Request and response handling 

- Routing  and static files

- Controller and Controller class
  - IActionResult
  - Status Code Results
  - Redirect Results

- Model Binding
  - Query String vs Route Data
  - Model Class
  - Form Urlencoded and Form-data
  - Model Validation 
	- [Required]
	- {0} string.Format
	- [Display]
	- [StringLength(max,min)]
	- [Range(min,max)]
	- [Compare]
	- [Email]
	- [Phone]
	- [ValidateNever]
	- Custom Validation
	  -With Multiple properties / Reflection
	- IValidatableObject, yield
  - ModelState
  - Bind and BindNever
  - FromBody
	- json
	- XmlSerializerInputFormatter
  - Custom Model Binders
  - Custom Model Binder Providers 
  - Collection Binding

- Model View Controller
  - View
  - Razor View Engine
	- If
	- Switch
	- Foreach / For
	- Literal
	- Local Functions
	- Html.Raw()
	- View Data
	- View Bag
  - Strongly Type Views
	- With Multiple Models
  - _ViewImports
  - Shared Views
  - Layout Views
	- _Layout and @RenderBody
	- With Multiple Views
	- View Data
	- _ViewStart.cshtml
	- Dynamic Layout Views
	- Layout Views - Sections
  - Partial Views
    - With ViewData
	- Strongly Typed Partial Views
	- Partial View Result
  - View Components
	- With ViewData
	- Strongly Typed ViewComponent
	- With Parameters
	- View Component Result

- Services
  - Dependency Inversion Principle
  - Inversion of Control
  - Dependency Injection(Constructor Injection)
    - Method Injection
  - Transient,Scoped & Singleton
  - Service Scope, "using(){}", IDisposable
  - AddSingleton<ICitiesService, CitiesService>(), AddTransient, AddScoped
  - View Injection
  - Best Practices for Dependency Injection
  - AutoFAC

- Environment
  -	In LaunchSettings.json
  - In Controller
  - <environment>  Tag Helpler
  - Process-Level Environment
	PS: dotnet run --no-launch-profile
	    $Env:ASPNETCORE_ENVIRONMENT="Staging"
	    dotnet run

- Configuration Settings
  - appsettings.json
  - IConfiguration in Controller
  - Hierarchical Configuration
  - Options Parttern
  - As Service
  - Environment-Specific Configuration
  - Secrets Manager
  - Environment Variables Configuration

- Personal learning notes  
