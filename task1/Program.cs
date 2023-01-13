// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int namber1 = Convert.ToInt32(Console.ReadLine());
int namber2 = Convert.ToInt32(Console.ReadLine());
    if ( namber1 > namber2 )
    {
    Console.WriteLine(namber1);
    }
    else
    {
    Console.WriteLine(namber2);
    }