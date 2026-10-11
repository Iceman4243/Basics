using System.ComponentModel.Design.Serialization;

Console.WriteLine("number:");
int n=int.Parse(Console.ReadLine());
if (n%2==0)
{
    Console.WriteLine("even");
}
else
{
    Console.WriteLine("odd");
}
for(int i=1;i<=n;i++)
{
    Console.WriteLine(i);
}