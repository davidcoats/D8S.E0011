# D8S.E0011
An experiment with Checked\<ICheck> outputs.


This experiment explorers outputting an instance of a type where the type communicates what checks were performed on the instance by a method, or what check are are required for the instance by a method.

Generally, check types are interfaces. This allows for easy multiple inheritance (since in C# classes can only inherit from one class, but interfaces can inherit from any number of interfaces).

For the checked type, two implementation options were tried:

1. struct Checked\<TCheck>

Pros:
	* As a struct, any methods outputing a checked instance do not need to initialize the checked instance! This is a neat trick.

Cons:
	* We can't use a struct Checked\<TDerivedCheck>, where TDerivedCheck : ICheck where a Checked\<TCheck> instance is required because in C# only interface types can have covariant type parameters.
	* Need to use an awkward As<TCheck, TDerivedCheck>() extension method (awkward because the TDerivedType type parameter will always need to be specified).


2. interface IChecked\<out TCheck>

Pros:
	* We can use a struct Checked\<TDerivedCheck>, where TDerivedCheck : ICheck wherever a Checked\<TCheck> instance is required due to covariant interface type parameter.

Cons:
	* As an interface (and thus a reference type), all methods outputting an IChecked instance will need to initialize it (so we can't take advantage of the neat out struct trick).

Result: use the interface. Yes, it is a neat trick with structs that you don't have to initialize the out parameter (and functionally, it saves GC work). But the awkwardness of needing to specify both type parameters of the As() method far outweighs a nifty trick.

It's worth asking why the struct IsSet\<T> works so well for communicating what sub-context properties were set. The answer is that that those are individal properties can be treated as individual properties.
Only sub-contextual method signatures will need to define all those individal IsSet\<T> tuple properties, not each and every method signature (as with these checks)!



