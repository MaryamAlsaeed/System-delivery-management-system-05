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
         */
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
