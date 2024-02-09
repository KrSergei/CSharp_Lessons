/// Task1
decimal value;
Console.WriteLine("Enter numver");
value = Convert.ToInt32(Console.ReadLine());
if(value % 7 == 0 && value % 23 == 0) Console.WriteLine("the number is a multiple 7 and 23");
else Console.WriteLine("the number is a not multiple 7 and 23");
Console.ReadKey();

///Task2 
decimal x, y;
Console.WriteLine("Enter x coordinate");
x = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Enter y coordinate");
y = Convert.ToDecimal(Console.ReadLine());
if( x >=0 && y >= 0) Console.WriteLine("Coordinate is in the first quarter");
else if(x < 0 && y > 0) Console.WriteLine("Coordinate is in the second quarter");
else if(x < 0 && y < 0) Console.WriteLine("Coordinate is in the third quarter");
else if(x > 0 && y < 0) Console.WriteLine("Coordinate is in the fourth quarter");
else if(x== 0 || y ==0) Console.WriteLine("Coordinate is on the axix");

///Task3
int number;
Console.WriteLine("Enter numver from 10 to 99");
number = Convert.ToInt32(Console.ReadLine());
while(number < 10 || number > 99){
    Console.WriteLine("Not valid is a number");
    Console.WriteLine("Enter number from 10 to 99");
    number = Convert.ToInt32(Console.ReadLine());
    }
if(number / 10 > number % 10) Console.WriteLine(number / 10);
else Console.WriteLine(number % 10);

//Task4
Console.WriteLine("Enter a natural number");
number = Convert.ToInt32(Console.ReadLine());
if(number < 10) Console.WriteLine(number);
else{
    while(number > 0){
        int currentNumber = number % 10;
        number /=10;
        if(number > 0){
            Console.Write(currentNumber +", ");
        } else Console.Write(currentNumber);
    }
}
