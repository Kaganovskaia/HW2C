/*Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
//int[] array=[]
System.Console.WriteLine("Введите число");
string number=Console.ReadLine();
 System.Console.WriteLine(number[2]);
 if (number.Length<3) System.Console.WriteLine("Третьей цифры нет");

