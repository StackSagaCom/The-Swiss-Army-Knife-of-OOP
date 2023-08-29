
//1.SRP- Single responsibility principle
//If you look at commented code in this class-the Gear class has two methods: changeGear and changeSpeed. If we apply the SRP, it seems like the class might be
//responsible for handling both gear changes and speed changes, potentially violating the principle. Ideally, each class should focus on a single responsibility.
//To adhere to SRP, you could consider splitting the responsibilities of gear changes and speed changes into separate classes.


//2.Open closed principle
//If you look at commented code, the Vehicle class has methods for displaying plate numbers for both cars and trucks.
//If you need to add support for a new type of vehicle (e.g., motorcycles or buses), you would need to modify the existing class to add new methods.
//This violates the Open/Closed Principle because it requires modifying existing code.
//In this improved scenario, the Vehicle class provides a virtual method carDisplayPlateNumber that returns a default plate number.
//The Car and Truck classes inherit from Vehicle and override the carDisplayPlateNumber method to add their own suffixes ("C" for cars and "T" for trucks).
//By doing so, you can extend the functionality of the Vehicle class without modifying its existing code. This adheres to the Open/Closed Principle.

//3.LISK principle
//If you look at commented code, the base abstract class Car declares two abstract methods: speed and refuel. The ElectricCar class, which inherits from Car,
//implements both methods by throwing NotImplementedException. This indicates that the ElectricCar class does not intend to provide implementations for these methods.
//However, this implementation contradicts the behavior expected from the base class, and this violates the Liskov Substitution Principle.
//Subclasses should be able to provide meaningful implementations that honor the contract established by the base class.

//4.Interface seggragation
//In this snippet, the ForecedInterfacePayment class implements the IPayment interface by providing an implementation for the EPay method. However, if this class doesn't
//need all the methods of the IPayment interface, it is being forced to implement more than it requires, which can lead to unnecessary dependencies and implementation
//details.

//5.Dependency inversion
//the FeedingSystem class depends on the IAnimal interface, an abstraction. The Dog and Cat classes implement this interface. Now, the high-level module depends
//on an abstraction, adhering to the Dependency Inversion Principle. Adding new animals or changing animal behavior won't affect the FeedingSystem class as long
//as the new animals implement the IAnimal interface.