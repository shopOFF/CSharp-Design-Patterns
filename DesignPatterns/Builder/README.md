## Builder Design Pattern - CSharp
#### Builder pattern falls under Creational Pattern of Gang of Four (GOF) Design Patterns in .Net. It is used to builds a complex object by using a step by step approach. It provides an interface for creating parts of a product. In this article, I would like share what is builder pattern and how is it work?
## What is Builder Pattern?
#### Builder pattern builds a complex object by using a step by step approach. Builder interface defines the steps to build the final object. This builder is independent from the objects creation process. A class that is known as Director, controls the object creation process.
#### Moreover, builder pattern describes a way to separate an object from its construction. The same construction method can create different representation of the object.

### Example:
 - ITarget - ITarget
	
		This is an interface which is used by the client to achieve its functionality/request.
 
 - Adapter - EmployeeAdapter
	
		This is a class which implements the ITarget interface and inherits the Adaptee class. 
		It is responsible for communication between Client and Adaptee.

 - Adaptee - HRSystem
	
		This is a class which have the functionality, required by the client. 
		However, its interface is not compatible with the client.

 - Client - ThirdPartyBillingSystem
 
		This is a class which interact with a type that implements the ITarget interface.
		However, the communication class called adaptee, is not compatible with the client.
	
	
## When to use it?
 - Need to create an object in several steps (a step by step approach).
 - The creation of objects should be independent from the way the object's parts are assembled.
 - Runtime control over the creation process is required.
