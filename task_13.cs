// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 99)
{
    while(a >= 1000)
    {
        int newNumber = (a / 10);
        a = newNumber; 
    }
    Console.WriteLine ("Третья цифра: " + a % 10);
}
else
{
    Console.WriteLine ("Третьей цифры нет");
}