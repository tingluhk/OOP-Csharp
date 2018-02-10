/*
this class is to try List data type
 */
namespace Console01.Vehicles{
    public class Parts
    {
        public string Name { get; set; }
        public int Id { get; set; }
        
        public Parts(){

        }
        public Parts(string name, int id):this(){
            this.Name = name;
            this.Id = id;
        }
    }
}