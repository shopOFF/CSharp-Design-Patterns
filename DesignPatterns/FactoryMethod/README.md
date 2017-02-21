## Factory Method Design Pattern - CSharp
#### Factory method pattern falls under Creational Pattern of Gang of Four (GOF) Design Patterns in .Net. It is used to create objects. People usually use this pattern as the standard way to create objects. In this article, I would like share what is factory pattern and how is it work?
## What is Factory Method Pattern?
#### In Factory pattern, we create object without exposing the creation logic. In this pattern, an interface is used for creating an object, but let subclass decide which class to instantiate. The creation of object is done when it is required. The Factory method allows a class later instantiation to subclasses.

### Example:
 - Product - IVehicle
	
		This is an interface for creating the objects.
 
 - ConcreteProducts - Scooter & Bike
	
		This is a class which implements the Product interface.

 - AbstracCreator - AbstractVehicleFactory
	
		This is an abstract class and declares the factory method, which returns an object of type Product.

 - ConcreteCreator - VehicleFactory 
		This is a class which implements the Creator class and overrides the factory method to return an instance of a ConcreteProduct.
	
## When to use it?
 - Subclasses figure out what objects should be created.
 - Parent class allows later instantiation to subclasses means the creation of object is done when it is required.
 - The process of objects creation is required to centralize within the application.
 - A class (creator) will not know what classes it will be required to create.