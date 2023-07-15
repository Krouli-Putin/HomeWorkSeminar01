// Задача 2. Напишите программу, которая на вход принимает два числа и выдает большее
/*
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2 )
{
    Console.Write($"Большее число {num1}");
}
else
{
    Console.Write($"Большее число {num2}");
}
*/

//Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Consol.Write("Здравствуйте! Эта программа поможет найти максимальное число из трех чисел, которые Вы введете");
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if(num1 > num2 && num1 > num3)
{
    max = num1;
    Console.Write($"Наибольшее число: {max}");
}
if(num2 > num1 && num2 > num3) 
{
     max = num2;
     Console.Write($"Наибольшее число: {max}");
}
if(num3 > num2 && num3 > num1)
{
max = num3; 
Console.Write($"Наибольшее число: {max}");
} */

//Задача 6. Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("Здравстуйте! Эта программа позволит проверить, является ли ваше число четным.");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
   Console.Write($"Число {num} четное!");
}
else 
{
    Console.Write($"Число {num} не четное!");
}
*/

// задача 8. Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Здравствуйте! Эта программа поможет показать все четные числа,  от 1 до Вашего числа");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for(int a = 1; a<=num; a++)
{
    if (a % 2 == 0)
    Console.Write(a + ",");
}
*/


