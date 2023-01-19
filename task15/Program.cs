//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7)
{
    System.Console.WriteLine("Выходной день");;
}
else
{
System.Console.WriteLine("Будний день");
}
