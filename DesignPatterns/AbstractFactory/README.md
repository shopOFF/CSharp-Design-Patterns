## Abstract Factory Design Pattern - CSharp
#### Abstract Factory method pattern falls under Creational Pattern of Gang of Four (GOF) Design Patterns in .Net. It is used to create a set of related objects, or dependent objects. Internally, Abstract Factory use Factory design pattern for creating objects. It may also use Builder design pattern and prototype design pattern for creating objects. It completely depends upon your implementation for creating objects. In this article, I would like share what is abstract factory pattern and how is it work?
## What is Abstract Factory Pattern?
#### Abstract Factory patterns acts a super-factory which creates other factories. This pattern is also called as Factory of factories. In Abstract Factory pattern an interface is responsible for creating a set of related objects, or dependent objects without specifying their concrete classes.

### Example:
 - AbstractFactory - IVehicleFactory
	
		This is an interface which is used to create abstract product.
 
 - ConcreteFactory - HondaFactory & HeroFactory
	
		This is a class which implements the AbstractFactory interface to create concrete products.

 - AbstractProduct - IBike & IScooter
	
		This is an interface which declares a type of product. 

 - ConcreteProduct - RegularBike, SportsBike, RegularScooter & SportsScooter
 
		This is a class which implements the AbstractProduct interface to create product.
	
 - Client - VehicleClient
 
		This is a class which use AbstractFactory and AbstractProduct interfaces to create a
		family of related objects.
	
## When to use it?
 - Create a set of related objects, or dependent objects which must be used together.
 - System should be configured to work with multiple families of products.
 - The creation of objects should be independent from the utilizing system.
 - Concrete classes should be decoupled from clients.
 
## Note
 - Internally, Abstract Factory use Factory design pattern for creating objects. But it can also use Builder design pattern and prototype design pattern for creating objects. It completely depends upon your implementation for creating objects.
 - Abstract Factory can be used as an alternative to Facade to hide platform-specific classes.
 - When Abstract Factory, Builder, and Prototype define a factory for creating the objects, we should consider the following points :
		
		1. Abstract Factory use the factory for creating objects of several classes.
		2. Builder use the factory for creating a complex object by using simple objects 
		and a step by step approach.
		3. Prototype use the factory for building a object by copying an existing object.