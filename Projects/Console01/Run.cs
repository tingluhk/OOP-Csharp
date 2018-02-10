/*
this class is just a wrapper to Run Static Methods for the Program
 */

using System;

class Run{
        public static void Method01(int Age, string Name){
            // to initiate an object from a class, use new keyword;
            Person person01 = new Person();
            // passing the parameters to the object fields.
            person01.Name = Name;
            person01.Age = Age;
            System.Console.WriteLine($"my name is {person01.Name}, my age is {person01.Age}");
        }

    
    public static void Method02(){
            // here we test the StaticSample Class. calling StaticMethod01() without initiating the object. 
            StaticSample.StaticMethod01();
        }
        public static void Method03(){
            // here we test the constructors from Vehicle Class.
            Vehicle v01 = new Vehicle();
            Vehicle v02 = new Vehicle("Toyota A410");
            Vehicle v03 = new Vehicle(112, "Honda HD14");

            v01.ShowVehicleSpecs();
            v02.ShowVehicleSpecs();
            v03.ShowVehicleSpecs();

            /* -------------  result  ------------------
            The spec is Name = default Name, and ID = 0
            The spec is Name = Toyota A410, and ID = 0
            The spec is Name = Honda HD14, and ID = 112 
            */
        }


        public  static void Method04()
        {
            // object initializer. this syntax is to instantiate object without creating the constructor, however only works with public fields. this way we don't have to create multiple constructors.
            Vehicle v01 = new Vehicle{
                Id = 1414,
                Name = "Porsch"
            };
            v01.ShowVehicleSpecs();
        }

        public static void Method05()
        {
            // Ref Modifier, you can reference to the value type variables with ref, but not really recommended to do it.
            int a = 12;
            int b = Function01.SquareANumber(ref a);
   
            System.Console.WriteLine($"a = {a}");

            // Out Modifier, out is same as ref, except that you can pass many refs in parameters.
        }

        public static void Method06()
        {
            // readonly modifier
            var v01 = new Vehicle("Tesla");
            v01.Parts.Add(new Parts("wheels", 1344));
            v01.Parts.Add(new Parts("chair", 1413));
            System.Console.WriteLine($"v01.Parts.Count = {v01.Parts.Count}");
            // v01.Parts.Count = 2 , however if we accidentally have another method rewrite the field.
            v01.Reset();
            System.Console.WriteLine($"v01.Parts.Count = {v01.Parts.Count}");
            // v01.Parts.Count = 0, to fix this, we add readonly modifier to Parts field.

        }

        

}