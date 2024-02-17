#region TASK1
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
}
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
void PrintToConsole(string msg)
{
    Console.WriteLine(msg);
}
#endregion



Main();