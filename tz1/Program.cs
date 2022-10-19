Console.Write("Введите трёхзначное число :->" );
int num = Convert.ToInt32(Console.ReadLine());

if(num > 99 && num < 1000)
{
    int number = num / 10;
    int N = number % 10;
    Console.WriteLine("Вторая цифра" + "->" + N);
}
else
{
Console.WriteLine("Не верное число");
}

