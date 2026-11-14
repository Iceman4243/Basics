
int Add(int a,int b)
{
    return a+b;
}
string CheckNumber(int x)
{
    if (x%2==0) return "even";
    return "odd";
}
bool Adult(int age)
{
    return age>=18;
}
Console.WriteLine("entr num:");
if (int.TryParse(Console.ReadLine(),out int n))
{
    Console.WriteLine(CheckNumber(n));
    Console.WriteLine($"{n}+10={Add(n,10)}");
    for (int i=1; i<=n; i++)
    {
        Console.WriteLine(i);
    }
    if (Adult(n))
    {
        Console.WriteLine("Adult");
    }
    else
    {
        Console.WriteLine("minor");
    }
}
else
{
    Console.WriteLine("not num");
}