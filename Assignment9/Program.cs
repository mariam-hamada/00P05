using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 01 — Theoretical Questions

            #region Question1

            //a) What happens when you assign one object variable to another object variable?
            //The reference (address) is copied, not the actual object.
            //b) Does assigning one object to another create a new object? Explain.
            //No, Assigning one object variable to another does not create a new object. This only copies the reference to the existing object.
            //c) What is the difference between copying an object and copying its reference ?
            //==> Copying the object: A new, separate object is created with the same data as the original.Changes to one object do not affect the other.
            //==> Copying the reference: Both variables point to the same object. Changing the object through one variable affects the other.

            #endregion

            #region Question2

            //a) What is a Shallow Copy?
            //A Shallow Copy creates a new object, but it copies the values of the original object's fields. For reference-type fields, it copies the reference, not the referenced object.
            //b) What is a Deep Copy?
            //A Deep Copy creates a new object and also creates new copies of the objects referenced by its reference-type members. The copied object is completely independent of the original.
            //c) What happens to reference-type members when a Shallow Copy is created?
            //The reference itself is copied, so both the original and copied objects point to the same referenced object.Therefore, changing that referenced object through one copy can affect the other copy.
            //d) What happens to reference-type members when a Deep Copy is created?
            //A new copy of each referenced object is created. The original and copied objects have their own separate reference-type members, so changes to one do not affect the other.
            //e) Give one situation where Deep Copy would be safer than Shallow Copy.
            //

            #endregion

            #region Question3

            //a) What is a static field, and how is it different from an instance field ?
            //==> A static field belongs to the class itself, not to a specific object. There is only one copy of a static field shared by all objects of that class.
            //==> An instance field belongs to a specific object, so each object has its own copy.
            //b) What is a static method? Can a static method directly access instance members?
            //A static method belongs to the class rather than to a specific object. No, a static method cannot directly access instance members, because instance members belong to a particular objec
            //c) What is a static constructor, and when is it executed ?
            //A static constructor is used to initialize static fields or perform one-time setup for a class.It: Has the same name as the class, Has no access modifier, Takes no parameters, Executes automatically once, before the class is first used.
            //d) What is a static class? Can you create an object from a static class?
            //A static class is a class that can contain only static members. It is used when the class does not need to represent individual objects.No, you cannot create an object from a static class.

            #endregion

            #region Question4

            //a) What is an Extension Method?
            //An Extension Method is a method that allows you to add new functionality to an existing class or type without modifying the original class or creating a derived class.
            //b) What keyword must be used in the first parameter of an extension method?
            //The this keyword must be used before the first parameter.
            //c) Where must an extension method be declared?
            //An extension method must be declared inside a static class.
            //d) Can an extension method access private members of the class it extends?
            //No. An extension method cannot directly access the private members of the class it extends.

            #endregion

            #region Question5

            //a) What is a Partial Class?
            //A Partial Class allows you to split the definition of one class into multiple files. The compiler combines all parts into a single class when the program is compiled.
            //b) Why would a developer split one class into multiple files?
            //Keep large classes organized, Make the code easier to read and maintain, Allow multiple developers to work on different parts of the same class, Separate different functionalities of the class.
            //c) What is a Partial Method?
            //A Partial Method is a method that can be declared in one part of a partial class and implemented in another part.
            //d) What happens if a declared partial method has no implementation?
            //If a partial method has no implementation, the compiler can remove the method declaration and any calls to it from the compiled code.

            #endregion

            #endregion

            #region Part 02 — Practical

            #region 1 Object Copying

            //Shipment shipment1 = new Shipment("SH001", "Mobile Phone", 2, 50, new DeliveryAddress("cairo", "Tahrir", 6));
            //Shipment shipment2 = shipment1;
            //Console.WriteLine("By Assignment");
            //Console.WriteLine($"shipment1 == shipment2 --> {shipment1==shipment2}");
            ////copies the refrence so, will be true 

            //Shipment shipment3 = shipment1.CopyShipment();

            //Console.WriteLine("By Copy shipment method ");
            //Console.WriteLine($"shipment1 == shipment3 --> {shipment1 == shipment3}");
            //// creates a new object so, will be false 
            #endregion

            #region 2 Shallow Copy

            //Shipment shipment1 = new Shipment("SH001", "Mobile Phone", 2, 50, new DeliveryAddress("cairo", "Tahrir", 6));
            //Shipment shallowShipment = shipment1.ShallowCopy();
            //Console.WriteLine($"Is the Shallow shipment object is the same as Shipment1: {shallowShipment == shipment1}");
            //Console.WriteLine($"Is the two shipments points to the same address: {shallowShipment.Destination == shipment1.Destination}");
            //Console.WriteLine("Before change:");
            //Console.WriteLine("Original: " + shipment1.Destination.City);
            //Console.WriteLine("Copied: " + shallowShipment.Destination.City);

            //shallowShipment.Destination.City = "Giza";

            //Console.WriteLine("After change:");
            //Console.WriteLine("Original: " + shipment1.Destination.City);
            //Console.WriteLine("Copied: " + shallowShipment.Destination.City);

            #endregion

            #region 3 Deep Copy
            //Shipment shipment1 = new Shipment("SH001", "Mobile Phone", 2, 50, new DeliveryAddress("cairo", "Tahrir", 6));
            //Shipment deepShipment = shipment1.DeepCopy();
            //Console.WriteLine($"Are Shipment objects the same: {shipment1 == deepShipment}");

            //Console.WriteLine($"Are DeliveryAddress objects the same {shipment1.Destination == deepShipment.Destination}");

            //Console.WriteLine("\nBefore change:");

            //Console.WriteLine("Original: " + shipment1.Destination.City);

            //Console.WriteLine("Copied: "+ deepShipment.Destination.City);

            //deepShipment.Destination.City = "Giza";

            //Console.WriteLine("\nAfter changing copied address:");

            //Console.WriteLine("Original: " + shipment1.Destination.City);

            //Console.WriteLine("Copied: " + deepShipment.Destination.City);


            #endregion

            #region 4 Static Field

            //Shipment shipment1 = new Shipment(
            //    "SH001",
            //    "Laptop",
            //    5,
            //    100,
            //    new DeliveryAddress("Cairo", "Tahrir", 10)
            //);

            //Shipment shipment2 = new Shipment(
            //    "SH002",
            //    "Phone",
            //    2,
            //    80,
            //    new DeliveryAddress("Giza", "Nile Street", 20)
            //);

            //Shipment shipment3 = new Shipment("SH003");

            //Console.WriteLine("Total Shipments Created: "
            //+Shipment.TotalShipmentsCreated);

            #endregion

            #region 5 Static Constructor

            //Shipment shipment1 = new Shipment("SH001");

            //Shipment shipment2 = new Shipment("SH002");

            //Console.WriteLine("Total Shipments Created: "
            //    + Shipment.TotalShipmentsCreated);

            #endregion

            #endregion

        }
    }
}
