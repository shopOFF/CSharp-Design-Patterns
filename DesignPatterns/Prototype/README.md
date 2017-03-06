## Prototype Design Pattern - CSharp
#### Prototype pattern falls under Creational Pattern of Gang of Four (GOF) Design Patterns in .Net. It is used to used to create a duplicate object or clone of the current object. It provides an interface for creating parts of a product. In this article, I would like share what is Prototype pattern and how is it work?
## What is Prototype Pattern?
#### Decorator pattern is used to add new functionality to an existing object without changing its structure.
#### This pattern creates a decorator class which wraps the original class and add new behaviors/operations to an object at run-time.

### Example:
 - Component - IVehicle
	
		This is an interface containing members that will be implemented by ConcreteClass and Decorator.
 
 - ConcreteComponent - HondaCity
	
		This is a class which implements the Component interface.

 - Decorator - AbstractVehicleDecorator
	
		This is an abstract class which implements the Component interface and contains the reference to a 
		Component instance. This class also acts as base class for all decorators for components.

 - ConcreteDecorator - VehicleSpecialOffer 
 
		This is a class which inherits from Decorator class and provides a decorator for components.
	
	
## When to use it?
 - Add additional state or behavior to an object dynamically.
 - Make changes to some objects in a class without affecting others.