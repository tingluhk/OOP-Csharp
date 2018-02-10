/*
this class is just a wrapper to Run Static Methods for the Program
 */

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

}