// to Inherite simple add : , now Car has all the Methods from Vehicle.

namespace Console01.Vehicles
{
    class Car : Vehicle{

        public Car(){
            
        }
        public Car(string registration) : base ("test",registration)
        {
            System.Console.WriteLine($"car is instantiated...regNum = {registration}");
        }

        public Car(string name, string regNum)
        {
            this.Name = " new car - " + name;
            // the following line won't work because the parent Class is private readlonly. need to pass it to :base();
            //this._registration = regNum;
        }

        public void Drive(){
            System.Console.WriteLine($"{this.Name}, ID = {this.Id} is  Moving...");
        }


    }
}