void Main(){
    string str = GetString();
    int[] numbersArray = new int[CheckCountNumbersInString(str)];
    numbersArray = GetNumbersArrayFromString(str);
    PrintArray(numbersArray);
}

string GetString(){
    return Console.ReadLine();
}

int CheckCountNumbersInString(string str){
    int count = 0;
    foreach(char c in str){
        if(CheckIsnumber(c)) count++;
    }
    return count;
}
bool CheckIsnumber(char c){
     if(char.IsDigit(c)) return true;
     else return false;
}

int[] GetNumbersArrayFromString(string str){
    string strNumbers = "";
    foreach(char c in str){
        if(CheckIsnumber(c)) strNumbers = strNumbers + c;
    }
    int[] numbers = new int[strNumbers.Length];
    for(int i = 0; i < strNumbers.Length; i++){
        if(CheckIsnumber(strNumbers[i])) numbers[i] = Convert.ToInt32(strNumbers[i] - '0');
    } 
    return numbers;
}

void PrintArray(int[] array){
    foreach(int n in array){
        Console.Write($"{n} ");
    }
}

Main();

int[,] matrix = new int[5,5];
matrix.GetLength(0);
