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



            #endregion

        }
    }
}
