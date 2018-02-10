/*
 this class we use constructor for instantiation, this class we have 2 fields Name and Id,
 and 3 constructors, each with different signature. 

 first Constructor doesnt' take any parameters, 
 2nd Constructor takes string name, 
 3rd constructor takes id and name.

 - Try instantiate objects with different constructors.
 */

using System.Collections.Generic;

class Vehicle{
     
     private string Name;
     private int Id;

     // if you don't initialize LIST<OBJ> variable there will be error "Field 'Vehicle.Parts' is never assigned to, and will always have its default value null" to fix it, just add this.Parts = new List<Parts>() in constructor.
     public List<Parts> Parts;
     
     public Vehicle(){
         this.Name = "default Name";
         this.Id = 0000;
         this.Parts = new List<Parts>();
     }

    public Vehicle(string name) : this () {
        // to not repeat the this.Parts = new List, we can call the first constructor with : this(); try not to use this(), its hard to maintain. its best just leave the first constructor to deal with the new List initialization.
         this.Name = name;
         this.Id = 0000;
     }
     public Vehicle(int id, string name) : this (name) {
         this.Name = name;
         this.Id = id;
     }

     public void ShowVehicleSpecs(){
         System.Console.WriteLine($"The spec is Name = {this.Name}, and ID = {this.Id}");
     }
     
 }