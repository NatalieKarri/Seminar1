Console.Clear();

// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Введите два числа ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 > number2)
// {
//     Console.Write("Максимальное число " + number1);
// }
// else
// {
//     Console.Write("Максимальное число " + number2);    
// }

// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите три числа ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());
// int number3 = Convert.ToInt32(Console.ReadLine());
// int max = number1;

// if (max < number2)
//  {
//     max = number2;
//  }
// if (max < number3)  
// {
//     max = number3;
// }

//  Console.Write("Максимальное число " + max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}