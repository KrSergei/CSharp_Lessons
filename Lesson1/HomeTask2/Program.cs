/// Task1
int value;
Console.WriteLine("Enter numver");
value = Convert.ToInt32(Console.ReadLine());
if(value % 7 == 0 && value% 23 == 0) Console.WriteLine("the number is a multiple 7 and 23");
else Console.WriteLine("the number is a not multiple 7 and 23");
Console.ReadKey();
