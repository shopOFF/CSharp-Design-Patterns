## Prototype Design Pattern - CSharp
#### Prototype pattern falls under Creational Pattern of Gang of Four (GOF) Design Patterns in .Net. It is used to used to create a duplicate object or clone of the current object. It provides an interface for creating parts of a product. In this article, I would like share what is Prototype pattern and how is it work?
## What is Prototype Pattern?
#### Prototype pattern is used to create a duplicate object or clone of the current object to enhance performance. This pattern is used when creation of object is costly or complex.
#### For Example: An object is to be created after a costly database operation. We can cache the object, returns its clone on next request and update the database as and when needed thus reducing database calls.

### Example:
 - Prototype Interface - IEmployee
	
		This is an interface which is used for the types of object that can be cloned itself.
 
 - Concrete Prototype - Developer & Typist
	
		This is a class which implements the Prototype interface for cloning itself.

	
## When to use it?
 - The creation of each object is costly or complex.
 - A limited number of state combinations exist in an object.