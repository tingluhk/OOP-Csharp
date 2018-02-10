class Person{
    // using prop+tab+tab, C# creates auto get;set; fields
    public int Age { get; set; }
    // private set means it is readonly modifier;
    public string Name { get; set; }
    // here we use private variable , so it won't be able to be set with .notation
    private string IdCardNumber;
    public int Height { get; private set; }

    public void SetIdCardNumber(string number){
        if(number != null)
        this.IdCardNumber = number;
    }

    public string GetIdCardNumber(){
        return this.IdCardNumber;
    }

}