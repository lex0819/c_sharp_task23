/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int GetNumber(string message){
  bool isCorrect = false;
  int result = 0;

  while (!isCorrect)
  {
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine() , out result) && result > 1)
    {
      isCorrect = true;
    }
    else
    {
      Console.WriteLine("You've entered incorrect number, please try again");
    }
  }
  return result;
}

void PrintCubesOfRowOfNumber(int number){
  Console.Write($"{number} cubes -> ");
  for (int i = 1; i <= number; i++)
  {
    Console.Write($"{i * i * i}  ");
  }
}

int num = GetNumber("Enter integer number more than 1");
PrintCubesOfRowOfNumber(num);