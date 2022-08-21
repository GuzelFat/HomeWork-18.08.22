Console.WriteLine("Введите 2 числа");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());

if (A>B)
{
    Console.Write("max = ");
    Console.WriteLine(A);
    Console.Write("min = ");
    Console.WriteLine(B);
}
else 
{
    Console.Write("max = ");
    Console.WriteLine(B);
    Console.Write("min = ");
    Console.WriteLine(A);
}
