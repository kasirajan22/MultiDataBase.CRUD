
# MultiDataBase.CRUD

  
**We can use multiple EF Core DbContexts in a single application in the following scenarios:**

  

 - **Separation of Concerns**: When you have multiple, unrelated domains or subdomains within your application, each with its own set of entities and business logic. Using separate DbContexts for each domain helps to keep the code organized and maintainable.
 - **Large and Complex Models**: When you have a large and complex data model, using multiple DbContexts can help to reduce the complexity and improve performance. You can split the model into smaller, more manageable pieces, each with its own DbContext.
 - **Different Data Sources**: When you need to connect to different data sources, such as multiple databases, APIs, or file systems, using separate DbContexts for each data source can help to keep the code organized and make it easier to manage.
 - **Read-Only and Read-Write Scenarios**: When you have read-only and read-write scenarios in your application, using separate DbContexts for each scenario can help to improve performance and reduce the risk of accidental data modifications.
 - **Microservices Architecture**: In a microservices architecture, each microservice may have its own DbContext, which helps to keep the code organized and makes it easier to develop, test, and deploy each microservice independently.
 - **Legacy System Integration**: When integrating with legacy systems, using separate DbContexts can help to isolate the legacy system's data model and business logic from the rest of the application.
 - **Testing and Mocking**: Using separate DbContexts for testing and mocking can help to improve the testing experience and make it easier to write unit tests and integration tests.

