# DesignPatternPractice
Let's test out design pattern in a console application
Please find my thought process for the solution as below.
Requirement:
New person detail received by Account using UI entered into system.
New Member account created using given information.
Requirement may change to include new person info
Account may need to process with new rule as new Designation type can be added which demand different email format rule.
Output new information based on requirement in UI.

This requirement more focussed on Design pattern instead of architecture pattern or style.
Our current scope is 2 layer architecture since it doesn’t involve persistent storage.

We don’t need to be perfect from the beginning because it needs to evolve with thought and time, but we should take care of all aspect that has potential for breaking changes.

We should engage creational, structural and behavioral pattern as need.
All new class templates are structural, how we create new object is Creational, what these objects does is Behavioral pattern.

Here we have Person, Employee and Account entity.
Person is an employee when account is created in real world or we say Employee is a Person who has Account. 

Now getting to further relationship, Person may have different designations and that comes with different requirement.
But all of them has same basic property like FName, LName and Designation. 
Since this object has to interact with UI, we should identify its dependency to UI.

Here comes SOLID principle:
SRP/SOC
OCP
LSP
ISP
DIP/IOC

Since UI has responsibility of capturing data and layout, it should not be held responsible to creation of new objects.

Let’s follow SRP to abstract classes in UI using interface.
So I assume any new roles like Manager, Engineer, Worker will implement IPerson interface.

But if we new up these different Person type in UI based on role, it doesn’t solve dependency.

So we use simple factory pattern to decouple creation of new Person based on designation.
Factory will return IPerson interface to UI.

To improve performance we should declare static Factory class to use single instance(SFI), since it will be called multiple times in UI.
Note that this will accomplish DI implementation as well.

Now lets move to Factory class
Here we will start creating new Person object based on designation (Type) condition and return to UI using filter of designation.

We can avoid IF conditions using RIP pattern (Replace IF pattern)

We can create all Objects without condition and return the one that is requested using Type filter from a dictionary.


Account and Employee creation has followed similar factory patter, SRP and IOC principle for decoupling.

Email account logic has been separated from Employee entity.

We can further enhance if else condition of Email format logic in account using member and designation by moving them to it’s own factory class that just returns formatted email (I didn’t pursue this for now).

Created folder for different components within business library and managed literals using constants across project.

I have assumed further that if we have to add contractor instead of employee in the future, then it is handled in this scenario.

We can continue improve this more using better DI framework like Unity Container to register constructors in factory.
There could be requirement for data validation that can now be injected into these objects without much breaking changes.
Unit test project should be added in real world.

Things stop when we stop imagining, but I would let you review my thought process which is not perfect either.
