// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите число, которое является не менее чем двухзначным");
int numbers = Convert.ToInt32(Console.ReadLine());
string num = Math.Abs(numbers).ToString();
if (num.Length > 2)
{
Console.Write("Третьей цифрой является: ");  
Console.Write(num[2]);
}
else 
{
Console.Write("Третьей цифы нет!");
}
