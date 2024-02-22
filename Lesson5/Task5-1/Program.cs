void Main(){
    Console.WriteLine("Enter string");
    string str = GetString();
    char[] chars = GetArrayChars(str);
    PrintArray(chars);
}

string GetString(){
    string? str = Console.ReadLine();
    return str!; 
}

char[] GetArrayChars(string str){
 char[] chars = new char[str.Length];
    for(int i =0; i <chars.Length; i++){
        chars[i] = str[i];
    }
    return chars;
}

void PrintArray(char[] array){
    Console.WriteLine(string.Join(",", array));
}

Main();