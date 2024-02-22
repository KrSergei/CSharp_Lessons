/// TASK1 Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
/// TASK2 Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные. 
/// TASK3 Задайте произвольную строку. Выясните, является ли она палиндромом.
/// TASK4 Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. 
///        В полученной строке слова должны быть также разделены пробелами.

#region GENERAL FUNCTION
void Main(){
    // <---------- TASK1 ---------->
    Console.WriteLine("<---------- TASK1 ---------->");
    char[,] charsArray = GetCharArray();
    string str = ConvertArrayToString(charsArray);
    Print(str);
    Console.WriteLine();
    Console.WriteLine("<---------- TASK2 ---------->");
    // <---------- TASK2 ---------->
    str = GetStringToLowerCase();
    Print(str);
    Console.WriteLine();
    Console.WriteLine("<---------- TASK3 ---------->");
    // <---------- TASK3 ---------->
    str = GetString();
    bool isPalydrom = ChekString(str);
    PrintResult(isPalydrom);
    Console.WriteLine();
    Console.WriteLine("<---------- TASK4 ---------->");
    // <---------- TASK4 ---------->
     str = GetString();
     string[] strArray = GetStringArray(str);
     strArray = ReverceArray(strArray);
     PrintArray(strArray);

}

void Print(string str){
    Console.Write(str);
}
Main();
#endregion

#region TASK1
char[,] GetCharArray(){
    char[,] charArr = new char[,]
    {
        {'&', 'b', 'c', '%', '^'},
        {'k', '%', 'f', 'g', '/'}
    };
    return charArr;
}

string ConvertArrayToString(char[,] array){
    string str ="";
    for(int i=0; i < array.GetLength(0); i++)
         for(int j=0; j < array.GetLength(1); j++)
            str += array[i,j];

    return str;
}
#endregion 

#region TASK2
string GetStringToLowerCase(){
    string? str = "";
    str = Console.ReadLine();
    str = str!.ToLower();
    return str!;
}
#endregion

#region TASK3

string GetString(){
    string? str = "";
    str = Console.ReadLine();
    return str!;
}
bool ChekString(string str){
    
    for(int i =0; i <str.Length; i++)
        if(str[i] !=str[str.Length -1 -i]) 
            return false;     
    return true; 
}
void PrintResult(bool value){
    if(value) Console.WriteLine("String is a palydrom");
    else Console.WriteLine("String is not a palydrom");
}
#endregion

#region TASK4

string[] GetStringArray(string str){
    return str.Split();
}

string[] ReverceArray(string[] array){
    return Enumerable.Reverse(array).ToArray();
}
void PrintArray(string[] strArray){
        Console.Write(string.Join(" ", strArray));
}

#endregion
