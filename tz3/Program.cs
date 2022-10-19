Console.Write("Введите день недели :->" );
int num = Convert.ToInt32(Console.ReadLine());

if(num > 0 && num < 6)
{
Console.WriteLine("НЕТ");
}
else if(num > 5 && num < 8)
{
Console.WriteLine("ДА");
} 
else
{
Console.WriteLine("Нет такого дня недели");
}


    
