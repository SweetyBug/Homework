Console.Write("Введите первое число: ");
double numberFirst = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double numberSecond = Convert.ToDouble(Console.ReadLine());
double maxNumber;
double minNumber;
if (numberFirst < numberSecond)
{
    minNumber = numberFirst;
    maxNumber = numberSecond;
    Console.WriteLine("Наибольшее число: " + maxNumber);
    Console.WriteLine("Наименьшее число: " + minNumber);
}
else if (numberFirst == numberSecond)
{
    Console.WriteLine("Оба числа равны!");
}
else
{
    minNumber = numberSecond;
    maxNumber = numberFirst;
    Console.WriteLine("Наибольшее число: " + maxNumber);
    Console.WriteLine("Наименьшее число: " + minNumber);
}