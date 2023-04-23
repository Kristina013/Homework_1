// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Input 1st number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input 2nd number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if(number_1 > number_2)
{
    Console.WriteLine($"Max number is {number_1} , min number is {number_2}");
}
else
{
    Console.WriteLine($"Max number is {number_2} , min number is {number_1}");
}
*/


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.WriteLine("Input 1st number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input 2nd number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input 3rd number: ");
int number_3= Convert.ToInt32(Console.ReadLine());

int max = number_1;

if(number_2 > max) max = number_2;
if(number_3 > max) max = number_3;

Console.WriteLine("max = ");
Console.WriteLine(max);
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number%2 == 0)
{
    Console.WriteLine($"Ваше число четное");
}
else
{
    Console.WriteLine($"Ваше число нечетное");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

/*
Console.WriteLine("Введите число N: ");
int number_N = Convert.ToInt32(Console.ReadLine());

int start_number = 1;

while (start_number <= number_N)
{
    if(start_number%2 == 0)
    {
    Console.Write(start_number + " ");
    }
    start_number++;
}
*/