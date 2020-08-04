using System;

namespace Lesson7EncapsulationGetSetAbstration
{
    class Program
    {
        public static ClassA classAObject;
        public static ClassB classBObject;
        static public void Main()
        {
            classAObject = new ClassA();
            classBObject = new ClassB();
            classBObject.SeemsHarmless();

            Console.WriteLine(classAObject.state);

            WithEncap exampleObject = new WithEncap();
            exampleObject.notProtected = -50;
            // Program Class directly updates the public, unprotected property.
            exampleObject.UpdatePrivateProperty(4);
            // Program class asks WithEncap class to update the protected private property
            // With Encap class is "in control"

            Car myCar = new Car("Ford", "Mustang", 2, "Red", Car.DriveTrain.FrontWheel);
            myCar.PaintCar("turkey");
            myCar.PaintCar("black");

            GetSet example1 = new GetSet("Read me", "Hidden Name", 1);
            GetSet example2 = new GetSet("Another Read Only", "Hidden Name", 2);

            example1.isProtected = 12;
            // Set this to a negative number to throw an validation error.

            // Asking for the public objName let's us get the value of the hidden objName
            Console.WriteLine(example2.objName);
            example2.objName = "Updated by another class";
            example2.ShowMeInternalName();

            // I can ready the value of the public variable with Get
            Console.WriteLine(example1.readOnly);
            // example1.readOnly = "Error!"
            // Property cannot be assigned to -- it is read only.
            Console.WriteLine(example2.readOnly);
            // This other object has a different value for it's readOnly property.

            Console.WriteLine(GetSet.alwaysTheSame);
            // This public constant is always the same for EVERY object of the class.
        }
    }
}
