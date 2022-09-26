
The Issues with the default implementaiton were but not limitted to:

1- No interface was implemented: 
	1.1 - This make it tightly coupled to one concrete implementation and not possbile to use DI
	1.2 - Testing will be difficult. Not able to mock or fake it
	1.3 - Chaning the current implementation makes all the code where this Car is used to be changed.
	1.4 - If decide to have more implementations of the another car and use the new one across the application then 
	we have to change all the refereces from the old one to the new one
2- No unit testing was presented
3- Some methods and properties could be shared across different implementations and the lack of a base class is issue here



 
 New implemention:

 1- Coded against the contracts ( Interfaces)
  1.1 - makes it easy to use DI and test
  1.2 - makes it easy to add a new implementation without the code using it needs to be changed
 2- An abstract base class is used for shared properties and methods  and some default implementation that could be changed 
	by a child class
 3- Unit testing added to avoid any logic issue at runtime.