//Домашняя работа.

//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNums(num - 1);
}

Console.Write("Введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());

ShowNums(numbers);
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int FindSumNumbers(int num1, int num2, int sum)
{
    if(num1 < num2) return FindSumNumbers(num1 + 1, num2, sum) + sum + num1;
    if(num1 > num2) return FindSumNumbers(num1, num2 + 1, sum) + sum + num2;
    if(num1 == num2) return sum += num1;
    else return 0;
}

Console.Write("Введите первое число: ");
int numbers1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numbers2 = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int ans = FindSumNumbers(numbers1, numbers2, sum);

Console.WriteLine(ans);
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*
int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
return AckermannFunction(numberM, numberN);
}

Console.Write("Введите начальное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начальное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");
*/