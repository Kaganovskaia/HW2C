/*Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

System.Console.WriteLine("Введите число от 1 до 7");
int number=Convert.ToInt32(Console.ReadLine());
if (number==1) System.Console.WriteLine("понедельник не является выходным");
if (number==2) System.Console.WriteLine("вторник не является выходным");
if (number==3) System.Console.WriteLine("среда не является выходным");
if (number==4) System.Console.WriteLine("четверг не является выходным");
if (number==5) System.Console.WriteLine("пятница, день предвкушения выходного");
if (number==6) System.Console.WriteLine("суббота-это выходной день");
if (number==7) System.Console.WriteLine("воскресенье-это выходной день");
else if (number>7 || number<1) System.Console.WriteLine("Введите число от 1 до 7");