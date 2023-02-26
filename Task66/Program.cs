// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());


int SumNaturalNumbers(int num1, int num2)
{
    if (num1 == num2 + 1) return 0;
    else number1 += SumNaturalNumbers(number1 + 1, number2);
    return SumNaturalNumbers(number1, number2);
    
}
if(number1 > 0 && number2 > 0) Console.WriteLine(SumNaturalNumbers(number1, number2));
else Console.WriteLine("Число не натуральное!");



