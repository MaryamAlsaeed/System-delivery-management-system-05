namespace OOP_5
{
    #region Theoretical Questions
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
     */
    #endregion
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
