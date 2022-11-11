using System;

namespace mycode
{
class sample
{
public static void Main(String[] args)
{
example o = new example(33);
o.show();

}
}
class example
{
public readonly int a=10;
public readonly int b;
public exapmle(int x)
{
b=x;
}
public void show()
{
Console.WriteLine("a "+a);
Console.WriteLine("b "+b);
}

}
}