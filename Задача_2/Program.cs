Console.Write("Введите первое число: ");
double numberFirst = Convert.ToDouble(Console.ReadLine());
double numberSecond = Convert.ToDouble(Console.ReadLine());
double maxNumber;
double minNumber;
if (numberFirst < numberSecond)
{
    minNumber = numberFirst;
    maxNumber = numberSecond;
}
else
{
    minNumber = numberSecond;
    maxNumber = numberFirst;
}
Console.WriteLine("Большее число: " + maxNumber);
    Console.WriteLine("Наименьшее число: " + minNumber);