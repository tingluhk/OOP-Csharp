/*
this class is just a wrapper to Run Static Methods for the Program
 */

using System;
using Log = Console01.Log;
using Veh = Console01.Vehicles;
using Sp = Console01.Shapes;
using System.IO;
using System.Collections;
using System.Collections.Generic;

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
            Veh.Vehicle v01 = new Veh.Vehicle();
            Veh.Vehicle v02 = new Veh.Vehicle("Toyota A410");
            Veh.Vehicle v03 = new Veh.Vehicle(112, "Honda HD14");

            v01.ShowVehicleSpecs();
            v02.ShowVehicleSpecs();
            v03.ShowVehicleSpecs();

            /* -------------  result  ------------------
            The spec is Name = default Name, and ID = 0
            The spec is Name = Toyota A410, and ID = 0
            The spec is Name = Honda HD14, and ID = 112 
            */
        }


        public static void Method04()
        {
            // object initializer. this syntax is to instantiate object without creating the constructor, however only works with public fields. this way we don't have to create multiple constructors.
            Veh.Vehicle v01 = new Veh.Vehicle{
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
            var v01 = new Veh.Vehicle("Tesla");
            v01.Parts.Add(new Veh.Parts("wheels", 1344));
            v01.Parts.Add(new Veh.Parts("chair", 1413));
            System.Console.WriteLine($"v01.Parts.Count = {v01.Parts.Count}");
            // v01.Parts.Count = 2 , however if we accidentally have another method rewrite the field.
            v01.Reset();
            System.Console.WriteLine($"v01.Parts.Count = {v01.Parts.Count}");
            // v01.Parts.Count = 0, to fix this, we add readonly modifier to Parts field, alternatively you can use const variable to achieve same thing.

        }

        public static void Method07()
        {
            Person p01 = new Person();
            // let's try to set the "IdCardNumber" field directly, we see we can't do it
            // p01.IdCardNumber = "1213";
            // we need to use public method to set the value of a private field
            p01.SetIdCardNumber("0145");
            System.Console.WriteLine($"{p01.GetIdCardNumber()}");

        }
        
        public static void Method08(){
            // Indexer, it is a simple way to access elements in class.
            IndexerSample idx = new IndexerSample();
            idx["name"] = "John P";
            System.Console.WriteLine($"idx[name] = {idx["name"]}");
        }

        public static void Method09(){
            // Class loose Coupling, to createa a loosely coupled app, one need to know the - Encapsulation, - The relationships between Classes, - Interfaces.
            // Inheritance, to inherit from parent class, and have all its methods and properties
            Veh.Car car01 = new Veh.Car();
            car01.Name = "newly inherited Car";
            car01.Id = 1414;
            car01.Drive();
            /* -------------  result  ------------------
            newly inherited Car, ID = 1414 is  Moving...
            */

        }


        public static void Method10()
        {
            // Composition is a way to decouple the classes, so that one is no longer dependant on the other, and they can be modified much more easily. similar to inheritance.
            Log.Robot robot01 = new Log.Robot(new Log.Logger("hi there I am Robot"));
            Log.Orc orc01 = new Log.Orc(new Log.Logger("hi there I am Orc"));
        }

        public static void Method11()
        {
            /*
            Access Modifier,
            1 - Private (Accessible only from the class)
            2 - Protected (Accessible only from the class and its derived classes)
            3 - Internal (Accessible only from the same Assembly)
            4 - Protected Internal (Accessible only from the same Assembly or any derived Classes)
             */
        }

        public static void Method12()
        {
            // Constructor and Inheritance. (Added Car:base()), Car class is getting a parameter, however it is passing the parameter to the Base class so that the Base can modify the registration number. the Private readonly field of _registration
            Veh.Car car01 = new Veh.Car("reg10414");
            
        }

        public static void Method13()
        {
            // Upcasting and Downcastin
            Sp.Square sq01 = new Sp.Square();
            sq01.Colors = "blue";
            Sp.Shape shape01 = sq01;
            sq01.Height = 200;
            shape01.Height = 100;
            // here because shape01 and sq01 both pointing to the same object reference, so that the result = 100;
            System.Console.WriteLine($"shape.Height = {shape01.Height}");
        }


        public static void Method14()
        {
            StreamReader reader01 = new StreamReader(new MemoryStream());
            var list = new ArrayList();
            // you can add any dataType here; however its not really good practise in real world
            list.Add(1);
            list.Add("john");
            list.Add(new Person());

            var list02 = new List<Sp.Shape>();
            list02.Add(new Sp.Square());
            list02.Add(new Sp.Circle());
            list02.Add(new Sp.Triangle());

            Sp.Shape shape01 = new Sp.Circle();
            Sp.Circle circle01 = (Sp.Circle) shape01;
            circle01.Radius = 12.14f;
            circle01.Area();
            var shape02 = (Sp.Circle) shape01;
            shape02.Radius = 1.14f;
            shape02.Area();
            // generally downcasting or upcasting so that we can get access to the methods that destination class holds.
        }

        public static void Method15()
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("john");
            list.Add(DateTime.Now);

            var number = (int) list[0];
            System.Console.WriteLine($"number = {number}");
            //because list[1] is a string type, it will throw error. System.InvalidCastException: Unable to cast object of type 'System.String' to type 'System.Int32'.

            // to fix it use generics
            var list02 = new List<int>();
            list02.Add(12);
            list02.Add(22);
            
        }

        public static void Method16()
        {
            // virtual overriding
            Sp.Shape circle = new Sp.Circle();
            circle.Draw();
        }

        public static void Method17()
        {
            // abstract classes, abstract means the method doesn't have any implementation, so its waiting for the derived class to make the implementation
            // adding public abstract class Shape
            Sp.Circle circle = new Sp.Circle();
            circle.Math01();
        }

        public static void Method18()
        {
            

        }

        public static void Method19()
        {
            

        }

        public static void Method20()
        {
            

        }


        public static void Method21()
        {
            

        }

        public static void Method22()
        {
            

        }

        public static void Method23()
        {
            

        }

        public static void Method24()
        {
            

        }

        public static void Method25()
        {
            

        }

        public static void Method26()
        {
            

        }

        public static void Method27()
        {
            

        }
}