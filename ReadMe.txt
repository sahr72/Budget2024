Summary of References

1.Project Layer: MyApp.Api	
 *References: MyApp.Application, MyApp.Core	
 **Purpose:Consumes services (from MyApp.Application) and domain models/interfaces (from MyApp.Core)
2.Project Layer: MyApp.Application (Business Logic & Services)	
 *References: MyApp.Core, MyApp.Infrastructure	
 **Purpose: Provides business logic (services) that use repositories (from MyApp.Infrastructure) and domain models/interfaces (from MyApp.Core)
3.Project Layer: MyApp.Infrastructure (Data Access Layer)	
 *References: MyApp.Core	
 **Purpose: Provides data access and repository implementations using domain models (from MyApp.Core)
4.Project Layer: MyApp.Web (Blazor)	
 *References: MyApp.Application, MyApp.Core	
 **Purpose: Consumes services (from MyApp.Application) and domain models (from MyApp.Core)
5.Project Layer: MyApp.Tests	
 *References: MyApp.Api, MyApp.Application, MyApp.Core, MyApp.Infrastructure	
 **Purpose: Unit and integration tests for API, services, repositories, and models
