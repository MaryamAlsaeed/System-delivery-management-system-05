namespace OOP_5
{
    #region Theoretical Questions
    /*
     * -----------Q1:-----------
     * OBJECT COPYING
     *
     *
     * a) What happens when you assign one object variable to another object variable?
     * - The address of the first object is copied to the second one.
     *
     *
     * b) Does assigning one object to another create a new object? Explain.
     * - No, it just copies the address of the object to the other one so they are the same object.
     * - Changing s2 will affect s1 because they're the same object.
     *
     *
     * c) What is the difference between copying an object and copying its reference?
     * - Copying an object: Copying an object means taking a copy of its data to another new object.
     *                      so we can use one of those methods:
     *                      - Shallow copy: to copy the refernce of the same object.
     *                      - Deep copy: to copy the data to a new object with new address.
     *
     *
     * - Copying objects reference: Copying reference means copying the address of
     *                              one object to other => it refers to the same object.
     *
     *
     * -----------Q2:-----------
     * SHALLOW COPY VS DEEP COPY
     *
     *
     * a) What is a Shallow Copy?
     * - A Shallow copy creates a new object but it still refers to the same address.
     * - It is created using MemberwiseClone()
     * - At the end while copying we refere to the same refernce.
     *
     *
     * b) What is a Deep Copy?
     * - Deep copy creates a new object and creates new copy for references.
     * - It is created using IConable
     * - Any change in object 2 doesn't effect the first object, bec. they are now 2 different objects.
     *
     *
     * c) What happens to reference-type members when a Shallow Copy is created?
     * - In shallow copy, we create a new object but we copy the reference address.
     * - So, 2 different objects refere to the same object.
     *
     *
     * d) What happens to reference-type members when a Deep Copy is created?
     * - In deep copy we create a new object with new copy reference address
     *   so a new DeliveryAddress is created.
     * - Now the 2 objects have completely independent DeliveryAddress objects.
     *
     *
     * e) Give one situation where Deep Copy would be safer than Shallow Copy.
     * - When you want to madify the copied object without affecting the original one.
     * - Example:
     *   If i want to change the shioment address and i dont need the old address anymore.
     *   so, with deep copy it will not affect the old address and we will just affect the new copy independently.
     *
     *
     * -----------Q3:-----------
     * STATIC MEMBERS
     * 
     * 
     * a) What is a static field, and how is it different from an instance field? 
     * - Static field: A static field is a feild that is available in a static class.
     *                 It is shared by all objects of that class.
     *                 
     * - Instance field: An instance field belongs to a specific object.
     *                   Each object has it's own instance fiels.
     * 
     * b) What is a static method? Can a static method directly access instance members? 
     * - Static method: it belongs to a static class and we cannot call it by any object.
     * - No, you cannot access directly access it we need to create an object to be able to access it.
     * - Because static methids can be accessed only by static members.
     * 
     * c) What is a static constructor, and when is it executed? 
     * - Static contructor: A static contructor runs first before any object is created.
     * - It is executed automatically when we run so we dont need to run it manually.
     * 
     * d) What is a static class? Can you create an object from a static class? 
     * - Static class: A static class can only contain static members.
     *                 A static class cannot be instantiated.
     * - No we cannot create an object from a static class.
     * 
     * -----------Q4:-----------
     * EXTENTION METHODS
     * 
     * 
     * a) What is an Extension Method? 
     * Extention methid: Is a method that you can use without editing in it 
     *                   and anailable as a built in method.
     *                   
     * b) What keyword must be used in the first parameter of an extension method? 
     * keyword: this we put it as a parameter
     * 
     * c) Where must an extension method be declared? 
     * An extention methid must be declared in a static class and also must be public.
     * 
     * d) Can an extension method access private members of the class it extends?
     * Yes, extention methods can access private members of a class it extends.
     * But out of this class we can never access those private fields.
     * 
     */
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}