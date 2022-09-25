//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void Задача1()
{
{
Console.WriteLine("Напишите любое трёхзначное число");
}

int number = Convert.ToInt32(Console.ReadLine());
int tens = number/10%10;
int i = number%10;
if((number>99&&number<=999)^(number>-999&&number<=-99))
{
 Console.WriteLine(tens + " - второе число в "+ number);
}
else
{
Console.WriteLine("Число не трехзначное");
}
}
Задача1();