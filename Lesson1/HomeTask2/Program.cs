/// Task1
float value;
Console.WriteLine("Enter numver");
value = Convert.ToInt32(Console.ReadLine());
if(value % 7 == 0 && value % 23 == 0) Console.WriteLine("the number is a multiple 7 and 23");
else Console.WriteLine("the number is a not multiple 7 and 23");
Console.ReadKey();

///Task2 
float x, y;
Console.WriteLine("Enter x coordinate");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y coordinate");
y = Convert.ToInt32(Console.ReadLine());
if( x >=0 && y >= 0) Console.WriteLine("Coordinate is in the first quarter");
else if(x < 0 && y > 0) Console.WriteLine("Coordinate is in the second quarter");
else if(x < 0 && y < 0) Console.WriteLine("Coordinate is in the third quarter");
else if(x > 0 && y < 0) Console.WriteLine("Coordinate is in the fourth quarter");
else if(x== 0 || y ==0) Console.WriteLine("Coordinate is on the axix");

///Task3
