/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

Console.WriteLine("Input  number ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num % 100 / 10;
 Console.WriteLine($" {result} "); 
 ////////////////////////////////////////////////////////////////
 /* Задача 13: Напишите программу, которая выводит третью
  цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

/*Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
    if (num / 100 > 0)
      
    {
         Console.WriteLine($"третья цифра {num / 10 % 10} ");
    } 
    else
{
    Console.WriteLine("нет") 
}*/
////////////////////////////////////////////////////////////////    
/*Задача 15: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет    
 
void Vdni(int num)
{   
  if (num < 6)   
 {
   Console.WriteLine($" {num}-> нет ");
 }
 else
  { 
   Console.WriteLine($" {num}->да ");
 }
}

Console.WriteLine("input number" ); 
int num = Convert.ToInt32(Console.ReadLine());
Vdni( num); */
