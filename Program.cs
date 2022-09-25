//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void Задача1()
{
{
Console.WriteLine("Напишите любое трёхзначное число");
}

int number = Convert.ToInt32(Console.ReadLine());
int tens = number/10%10;
int i = number%10;
if((number>99&&number<=999)^(number>=-999&&number<-99))
{
 Console.WriteLine(tens + " - второе число в "+ number);
}
else
{
Console.WriteLine("Число не трехзначное");
}
}
//Задача1();

//Напишите программу, 
//которая с помощью деления выводит третью 
//цифру заданного числа или сообщает,
//что третьей цифры нет.
void Задача2()
{
{
Console.WriteLine("Введите любое число");
}
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if(number>99)
{
    while (number>999)
    {
        number /= 10;
    }
    { Console.WriteLine("третья цифра числа - " + number%10);}
}
    else
    {
        Console.WriteLine("нет третьей цифры");
    }
}
//Задача2()
//Напишите программу, 
//которая принимает на вход цифру,
// обозначающую день недели, и проверяет,
//является ли этот день выходным.
void Задача3()
{
    {
    Console.WriteLine("Введите число от 1 до 7");
    }
    int book = Convert.ToInt32(Console.ReadLine());
    if(book>=1&&book<=7)
        {
        if(book == 1)
        {Console.WriteLine("Понедельник");}
        else if(book == 2)
        {Console.WriteLine("Вторник");}
        else if(book == 3)
        {Console.WriteLine("Среда");}
        else if(book == 4)
        {Console.WriteLine("Четверг");}
        else if(book == 5)
        {Console.WriteLine("Пятница");}
        else if(book == 6)
        {Console.WriteLine("Суббота");}
        else if(book == 7)
        {Console.WriteLine("Воскресенье");}
        }
        
     else
     {Console.WriteLine("Ошибка");}

if (book == 6 || book == 7) 
    { Console.WriteLine("этот день выходной");}
else 
    {
        if((book == 1)^(book == 2)^(book == 3)^(book == 4)^(book == 5))
        {Console.WriteLine("этот день будний");} 
    }   
}

//Задача2();
//Задача1();
//Задача3();
Задача2();



