# WebAPI.Core
This is my Blog.Template, which consists of dotnet core and react. I will recall everything to create this repository for learning aims. This repository takes [anjoy8](https://github.com/anjoy8/Blog.Core) as reference.
The following image is to show the structure of the back end, it is same from [anjoy8](https://github.com/anjoy8/Blog.Core).
![enter image description here](https://camo.githubusercontent.com/6e66d92b605cf5c6dc9672d416c7e020b85c1e5a/687474703a2f2f61706b2e6e65746572732e636c75622f426c6f672e436f72652e53797374656d2e4172636869746563747572652e706e67)


## Serilog and Swagger
***Serilog***
1. Adding nuget packages to WebAPI.Core: serilog，serilog.sinks.file，serilog.sinks.console, Serilog.AspNetCore
2. UseSerilog in IWebHostBuilder under program.cs main function

***Swagger***
1. Add `Swashbuckle.AspNetCore` to use Swagger.
2. Under `ConfigureServices` method, Swagger should be add first.
3. Then use Swagger under `Configure`.
4. Change the `launchUrl` under luanchSettings.json to "" will set the luanch url to swagger, do not forget to change the rout to reach swagger.
5. To annoate the Swagger, add the following code to `AddSwaggerGen`. Then those API annotated as XML format will be shown in the Swagger side. More about [Swagger](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-3.1&tabs=visual-studio-mac)
```C#
    // Set the comments path for the Swagger JSON and UI.
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    // c.IncludeXmlComments(xmlPath);
    c.IncludeXmlComments(xmlPath, true); // with controller annotation
```
And, <GenerateDocumentationFile>true</GenerateDocumentationFile> is to get xml file, write it under .csproj


## User DbContext
1. Create `AppUser`, `AppRole` and `AppUserRole` for authantication.
