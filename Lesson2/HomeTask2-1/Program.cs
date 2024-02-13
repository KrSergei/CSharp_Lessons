int number = 0;
bool isCorrectNumber = false;

void Main()
{
  while (isCorrectNumber == false)
  {
    Console.WriteLine("Enter natural number from 1 to 100 000");
    number = GetNumber();
    if (number > 0 && number < 100000) isCorrectNumber = true;
  }
  ConvertNumberToArray(number);
}

int GetNumber()
{
  return Convert.ToInt32(Console.ReadLine());
}

void ConvertNumberToArray(int number)
{
  string num = number.ToString();
  int[] array = new int[num.Length];
  for (int i = 0; i < num.Length; i++)
  {
    array[i] = Convert.ToInt32(num[i]);
    if (i == num.Length -1) PrintArrayValue(num[i], true);
    else PrintArrayValue(num[i]);
  }
}

void PrintArrayValue(char ch, bool lastChar = false)
{
  if (lastChar) Console.Write($"{ch}");
  else Console.Write($"{ch}, ");
}

Main();