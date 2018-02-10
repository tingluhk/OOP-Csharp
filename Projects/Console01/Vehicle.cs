/*
 this class we use constructor for instantiation, this class we have 2 fields Name and Id,
 and 3 constructors, each with different signature. 

 first Constructor doesnt' take any parameters, 
 2nd Constructor takes string name, 
 3rd constructor takes id and name.

 - Try instantiate objects with different constructors.
 */

 class Vehicle{
     
     private string Name;
     private int Id;
     public Vehicle(){
         this.Name = "default Name";
         this.Id = 0000;
     }

    public Vehicle(string name){
         this.Name = name;
         this.Id = 0000;
     }
     public Vehicle(int id, string name){
         this.Name = name;
         this.Id = id;
     }

     public void ShowVehicleSpecs(){
         System.Console.WriteLine($"The spec is Name = {this.Name}, and ID = {this.Id}");
     }
     
 }