/*
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Input first int number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second int number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (num1 == num2) {
    Console.WriteLine($"{num1} = {num2}, same numbers entered");
}

else {
if (num1 > num2) {
    max = num1;
    Console.WriteLine($"{num1} > {num2}, max = {max}, the first number is greater than the second");
}
else {
    max = num2;
    Console.WriteLine($"{num1} < {num2}, max = {max}, the second number is greater than the first");
}
}

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Input first int number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second int number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third int number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if ((num1 == num2) & (num2 == num3)) {
    Console.WriteLine($"{num1} = {num2} = {num3}, same numbers entered");
}

else {
if ((num1 > num2) & (num1 > num3)) {
    max = num1;
    Console.WriteLine($"{num1}, {num2}, {num3}, max = {max}, the first number is greater than the second and the third");
}
else {
    if ((num2 > max) & (num2 > num3)) {
    max = num2;
    Console.WriteLine($"{num1}, {num2}, {num3}, max = {max}, the second number is greater than the first and the third");
}
else {
    max = num3;
    Console.WriteLine($"{num1}, {num2}, {num3}, max = {max}, the third number is greater than the first and the second");
}
}
}
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Input int number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) {
    Console.WriteLine($"{num} - even number");
}

else {
    Console.WriteLine($"{num} - odd number");
}

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.