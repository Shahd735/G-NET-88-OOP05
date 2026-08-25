namespace Assignment_8_OOP_5;

internal class Program
{
    static void Main(string[] args)
    {
        #region Question1
        // a) What is Abstraction in Object-Oriented Programming?
        // => hiding complex implementation details and showing only the essential features of an object to the user.

        // b)  Why is abstraction considered one of the four pillars of OOP?
        // => It reduces system complexity, increases code reusability
        #endregion

        #region Question2
        // a) What is the difference between an Abstract Class and an Interface?
        // => An Abstract Class can contain both fully implemented methods and abstract methods, An Interface containing only method signatures without implementation or fields.

        // b)  When would you choose an Interface instead of an Abstract Class?
        // => when you want to define a common behavior that multiple unrelated classes must implement.

        // c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
        // => A class cannot inherit from multiple abstract classes. However, it can implement multiple interfaces.
        #endregion
    }
}