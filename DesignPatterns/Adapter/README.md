## Adapter Design Pattern - CSharp
#### Adapter pattern falls under Structural Pattern of Gang of Four (GOF) Design Patterns in .Net. The Adapter pattern allows a system to use classes of another system that is incompatible with it. It is especially used for toolkits and libraries. In this article, I would like share what is adapter pattern and how is it work?
## What is Adapter Pattern?
#### Adapter pattern acts as a bridge between two incompatible interfaces. This pattern involves a single class called adapter which is responsible for communication between two independent or incompatible interfaces.
#### For Example: A card reader acts as an adapter between memory card and a laptop. You plugins the memory card into card reader and card reader into the laptop so that memory card can be read via laptop.

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
 - Allow a system to use classes of another system that is incompatible with it.
 - Allow communication between new and already existing system which are independent to each other.
 - Ado.Net SqlAdapter, OracleAdapter, MySqlAdapter are best example of Adapter Pattern.
 
## Note
 - Internally, Adapter use Factory design pattern for creating objects. But it can also use Builder design pattern and prototype design pattern for creating product. It completely depends upon your implementation for creating products.
 - Adapter can be used as an alternative to Facade to hide platform-specific classes.
 - When Adapter, Builder, and Prototype define a factory for creating the products, we should consider the following points :
		
		1. Adapter use the factory for creating objects of several classes.
		2. Builder use the factory for creating a complex product by using simple objects
		and a step by step approach.
		3. Prototype use the factory for building a product by copying an existing product.