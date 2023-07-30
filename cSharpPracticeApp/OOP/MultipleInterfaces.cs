using cSharpPracticeApp.OOP;
using Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpPracticeApp.OOP
{
    /*
    Suppose we have three interfaces representing different types of electronic devices:

    1. `ISmartphone` interface:
    */

    interface ISmartphone
    {
        void MakeCall(string phoneNumber);
        void SendTextMessage(string phoneNumber, string message);
    }


    /*

    2. `ILaptop` interface:
    */
    interface ILaptop
    {
        void Start();
        void Shutdown();
        void OpenApplication(string appName);
    }

    /*
    3. `ITablet` interface:
    */
    interface ITablet
    {
        void TakeNotes(string notes);
        void ReadEBook(string bookTitle);
    }

    /*

    Now, we'll create a class named `ElectronicDevice` that implements all three interfaces:

    */

    class ElectronicDevice : ISmartphone, ILaptop, ITablet
    {
        // Implementation of ISmartphone interface
        public void MakeCall(string phoneNumber)
        {
            Console.WriteLine($"Calling {phoneNumber} from the smartphone.");
        }

        public void SendTextMessage(string phoneNumber, string message)
        {
            Console.WriteLine($"Sending '{message}' to {phoneNumber} from the smartphone.");
        }

        // Implementation of ILaptop interface
        public void Start()
        {
            Console.WriteLine("Laptop is starting.");
        }

        public void Shutdown()
        {
            Console.WriteLine("Laptop is shutting down.");
        }

        public void OpenApplication(string appName)
        {
            Console.WriteLine($"Opening {appName} on the laptop.");
        }

        // Implementation of ITablet interface
        public void TakeNotes(string notes)
        {
            Console.WriteLine($"Taking notes: {notes} on the tablet.");
        }

        public void ReadEBook(string bookTitle)
        {
            Console.WriteLine($"Reading '{bookTitle}' on the tablet.");
        }
    }

    internal class MultipleInterfaces
    {
        public static void MultipleInterfacesExample()
        {
            ElectronicDevice device = new ElectronicDevice();

            // Calling methods from ISmartphone interface
            device.MakeCall("1234567890");
            device.SendTextMessage("9876543210", "Hello there!");

            // Calling methods from ILaptop interface
            device.Start();
            device.OpenApplication("Notepad");
            device.Shutdown();

            // Calling methods from ITablet interface
            device.TakeNotes("Important meeting details");
            device.ReadEBook("The Adventures of Tom Sawyer");
        }
    }
}
/*

In this example, the `ElectronicDevice` class implements all three interfaces: `ISmartphone`, `ILaptop`, and `ITablet`.
Each interface defines specific methods that the class must implement.

When you run the `Main` method, it creates an instance of the `ElectronicDevice` class and calls various methods from each interface.
The `ElectronicDevice` class provides the implementation for all the methods declared in the interfaces, allowing it to act as a smartphone, laptop,
and tablet, all in one class. This is how multiple interfaces enable a class to have multiple behaviors and functionalities through separate contracts
defined by the interfaces.    */