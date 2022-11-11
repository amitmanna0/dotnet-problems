using System;

namespace  mycode
{
    
public class firstcode
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog();
        
    }
}
public interface Animal
{
    void sound();
    
}
class Dog : Animal
{
    void sound()
    {
        Console.WriteLine("Sound....");
    }
    void leg()
    {
        Console.WriteLine("legg....");
    }
}
}