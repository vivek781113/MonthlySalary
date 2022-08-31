// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var lib = new SomeOtherLib();

Console.WriteLine(lib.Age);
Console.WriteLine(lib.Time);







class SomeOtherLib 
{
    public int Age { get; set; }
    public int Time { get; set; }
}