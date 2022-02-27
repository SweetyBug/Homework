Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i < number + 1) 
{
    if (i % 2 == 0) Console.WriteLine(i);
    i += 1;
}