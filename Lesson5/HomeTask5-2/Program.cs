/// TASK1 Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
/// TSAK2 Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/// TASK3 Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

#region GENERAL FUNCTION
void Main()
{
    //<---------- TASK1 ---------->
    Console.WriteLine("<---------- TASK1 ---------->");
    int firstNumber, secondNuber;
    ShowMessage();
    firstNumber = GetNumber();
    ShowMessage();  
    secondNuber = GetNumber();
    if(firstNumber > secondNuber) FindNumders(secondNuber, firstNumber);
    else FindNumders(firstNumber, secondNuber);
    Console.WriteLine();

    //<---------- TASK2 ---------->
    Console.WriteLine("<---------- TASK2 ---------->");
    ShowMessage();
    firstNumber = GetNumber();
    ShowMessage();  
    secondNuber = GetNumber();
    Print(Ackerman(firstNumber, secondNuber));
    Console.WriteLine();

    //<---------- TASK3 ---------->
    Console.WriteLine("<---------- TASK3 ---------->");
    Console.WriteLine("Enter array length");
    firstNumber = GetNumber();
    int[] array = RandomArray(firstNumber);
    PrintArray(array);
    PrintArrayFromLastIndex(array, array.Length -1);
}

void ShowMessage(){
    Console.WriteLine("Enter number");
}
int GetNumber(){
    return Convert.ToInt32(Console.ReadLine());
}
void Print(int value){
    Console.Write($"{value} ");
}
void PrintArray(int[] array){
     Console.Write(string.Join(" ", array));
     Console.WriteLine();
}
Main();
#endregion

#region TASK1
void FindNumders(int first, int second){
    if(first > second) return;    
    Print(first);
    FindNumders(first + 1, second);
}
#endregion

#region TASK2
int Ackerman(int n, int m) => (n < 0 || m < 0) 
                        ? throw new ArgumentOutOfRangeException() 
                        : (n == 0) ? (m + 1) 
                        : (m == 0) ? Ackerman (n - 1, 1)
                        : Ackerman (n - 1, Ackerman (n, m - 1));

#endregion

#region TASK3
int[] RandomArray(int length){
    Random rnd = new Random();
    int[] array = new int [length];
    for(int i = 0; i < array.Length; i++){
        array[i] = rnd.Next(-100, 100);
    }
    return array;
}

void PrintArrayFromLastIndex(int[] array, int index){
    if(index < 0) return;
    Print(array[index]);
    PrintArrayFromLastIndex(array, index - 1);
}

#endregion