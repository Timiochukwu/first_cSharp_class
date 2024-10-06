// Method Overidding

class Amimal
{
    public virtual void Speak(){
        Console.WriteLine(" The Amimal Goes **brrrr**");
    }
    
}
class Dog : Amimal
{
      public override void Speak(){
        Console.WriteLine(" The Amimal Goes **wooff**");
    }
    
}
class Cat : Amimal
{
    public override void Speak(){
         Console.WriteLine(" The Amimal Goes **meeoww**");
    }
}