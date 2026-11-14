
int Add(int a,int b)
{
    return a+b;
}
string CheckNumber(int x)
{
    if (x%2==0) return "even";
    return "odd";
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
}
else
{
    Console.WriteLine("not num");
}