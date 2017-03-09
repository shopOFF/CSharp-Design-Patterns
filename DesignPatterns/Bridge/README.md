## Bridge Design Pattern - CSharp
#### Bridge pattern falls under Structural Pattern of Gang of Four (GOF) Design Patterns in .Net. All we know, Inheritance is a way to specify different implementations of an abstraction. But in this way, implementations are tightly bound to the abstraction and can not be modified independently. The Bridge pattern provides an alternative to inheritance when there are more than one version of an abstraction. In this article, I would like share what is bridge pattern and how is it work?
## What is Bridge Pattern?
#### Bridge pattern is used to separate an abstraction from its implementation so that both can be modified independently.
#### This pattern involves an interface which acts as a bridge between the abstraction class and implementer classes and also makes the functionality of implementer class independent from the abstraction class. Both types of classes can be modified without affecting to each other.

### Example:
 - Abstraction - Message
	
		This is an abstract class and containing members that define an abstract business object 
		and its functionality. It contains a reference to an object of type Bridge. It can also 
		acts as the base class for other abstractions.
 
 - Redefined Abstraction - SystemMessage & UserMessage
	
		This is a class which inherits from the Abstraction class. It extends the interface defined
		by Abstraction class.

 - Bridge - IMessageSender
	
		This is an interface which acts as a bridge between the abstraction class and implementer 
		classes and also makes the functionality of implementer class independent from the abstraction class.

 - ImplementationA & ImplementationB - EmailSender, WebServiceSender & MSMQ Sender
 
		These are classes which implement the Bridge interface and also provide the implementation details
		for the associated Abstraction class.
		
## When to use it?
 - Abstractions and implementations should be modified independently.
 - Changes in the implementation of an abstraction should have no impact on clients.
 - The Bridge pattern is used when a new version of a software or system is brought out, but the older version of the software still running for its existing client. There is no need to change the client code, but the client need to choose which version he wants to use.
 
## Note
 - Bridge pattern has nearly the same structure as the Adapter Pattern. But it is used when designing new systems instead of the Adapter pattern which is used with already existing systems.