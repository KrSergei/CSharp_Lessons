/// TASK-1: --- Программа бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
/// TASK-2: --- Массив заполненный случайными трёхзначными числами. Программа показывает количество чётных чисел в массиве.
/// NASK-3: --- Программа перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
#region GENERAL FUNCTIONS
void Main()
{
    /// <-------------- TASK1 -------------->    
    bool isCanContinue = true;
    int sum = 0;
    while (isCanContinue)
    {
        Console.WriteLine("Enter natural numbers");
        string number = EnterNumber();
        isCanContinue = CheckPressKeyQ(number);
        if (isCanContinue == true) {
            sum = SumNumber(number);
            isCanContinue = CheckIsSumNumbersEven(sum);
        }          
        if (isCanContinue) PrintToConsole("Sum numbers = " + sum);
        else PrintToConsole("You are enter q or sum numbers is a entered number is a even");
    }

    /// <-------------- TASK2 -------------->
    int[] randomNumbers = new int[10];
    int countEvenNumbers = 0;
    randomNumbers = CreateArray(randomNumbers.Length);
    countEvenNumbers = CountEvenNumbers(randomNumbers);
    PrintArrayToConsole(randomNumbers);
    PrintToConsole(countEvenNumbers.ToString());

    /// <-------------- TASK3 -------------->
    int[] arrayReverse = new int[randomNumbers.Length];
    arrayReverse = ReverseArray(randomNumbers);
     PrintArrayToConsole(arrayReverse);
}
void PrintToConsole(string msg)
{
    Console.WriteLine("\n" + msg);
}
void PrintArrayToConsole(int[] array){
    foreach(int item in array){
        Console.Write($"{item} ");
    }
}
Main();
#endregion

#region TASK1
string EnterNumber()
{   
    string? num = Console.ReadLine(); 
    return num;
}
bool CheckPressKeyQ(string number)
{
    if (number.Equals("Q") || number.Equals("q")) { 
        return false;
    }   
    else return true;
}
bool CheckIsSumNumbersEven(int numbers)
{
    if (numbers % 2 == 0) return false;
    else return true;
}

int SumNumber(string enteredNumber)
{
    int sum = 0;
    int[] numbers = ConvertNumberToArray(enteredNumber);
    sum = SumNumbers(numbers);
    return sum;
}
int[] ConvertNumberToArray(string number)
{
    int[] numbersInt = number.Select(x => x - '0').ToArray();
    return numbersInt;
}
int SumNumbers(int[] numbersArray) {
    int sum = 0;
    for (int i = 0; i < numbersArray.Length; i++)
    {
        sum += numbersArray[i];
    }
    return sum;
}
#endregion

#region TASK2
int[] CreateArray(int lengthArray){
    Random rnd = new Random();
    int[] array = new int[lengthArray];
    for(int i =0; i < lengthArray; i++){
        array[i] = rnd.Next(99, 1000);
    }
    return array;
}
int  CountEvenNumbers(int[] array){
    int count = 0;
    for(int i =0; i < array.Length; i++){
        if(array[i] %2 ==0) count++;
    }
    return count;
}
#endregion

#region TASK3
int[] ReverseArray(int[] array){
  return Enumerable.Reverse(array).ToArray();
}
#endregion