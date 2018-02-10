/*
 why use static members?
 - there are many pre build static methods and classes comes with C# (e.g. Date Class, Console.WriteLine().... etc)
 - Static members can only be accessed through class name then dot notation. it can not be instantiated.
 */

class StaticSample{
    public static void StaticMethod01(){
        System.Console.WriteLine($"StaticMethod01 is called");
    }
}