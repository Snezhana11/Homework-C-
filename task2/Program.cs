// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
int numbar1 = Convert.ToInt32(Console.ReadLine());
int numbar2 = Convert.ToInt32(Console.ReadLine());
int numbar3 = Convert.ToInt32(Console.ReadLine());
int max = numbar1;

    if (numbar2 > max)
    {
        max = numbar2; 
    }
    if (numbar3 > max )
    {
        max = numbar3;
    }
Console.WriteLine("максималбное число" + max);  