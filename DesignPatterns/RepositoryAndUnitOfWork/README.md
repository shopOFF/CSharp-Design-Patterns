## Repository Pattern - CSharp
#### The repository pattern is used to create an abstraction layer between the DAL (data access layer) and the BAL (business access layer) to perform CRUD operations.
## The repository pattern can be implemented by using following two method :
 - Generic Repository Pattern
	
		A generic repository implementation is used to define common database operations 
		(like Create, Retrieve Update, Delete etc.) for all the database entities in a single class.
		
 - Non-Generic Repository Pattern (Specific Repository)
 
		A non-generic repository implementation is used to define all database operation related 
		to an entity within a separate class. For example, if you have two entities Category and Product,
		each entity will have its own implementation repository.
		
## Recommended Repository Pattern Implementation
###If you will use one of the above implementation, generic you can not use for specific operation on an entity and in case of non-generic implementation, you have to write code for common CRUD operations for each entity. So better way is, just create a generic repository for commonly used CRUD operation and for specific one create a non-generic repository and inherit form generic repository. The example code is given :
 
 
## Unit of Work Pattern - CSharp 
#### The unit of pattern implementation manage in-memory database CRUD operations on entities as one transaction. So, if one of the operation is failing then entire db operations will be rollback.

## Entity Framework and Repository and Unit Of Work Patterns
#### Entity Framework is based on the repository and unit of work patterns to perform CRUD operations on an entity.The DbSet class is based on the repository design pattern which provides us a set of method to perform CRUD operations on an entity. The DbContext class is based on unit of work pattern which includes all the DbSet entities. The DbContext class manages in-memory database operations on these entities and later saves all these updates as one transaction into database.	

## Advantages of Repository and Unit Of Work Design Patterns :
 - Abstract Data Access Layer and Business Access Layer from the Application.
 - Manage in-memory database operations and later saves in-memory updates as one transaction
	into database.
 - Facilitates to make the layers loosely-coupled using dependency injection.
 - Facilitates to follow unit testing or test-driven development (TDD).
