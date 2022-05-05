// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите несколько чисел через запятую ");
string userNumber = Console.ReadLine();
int countPositive = 0;

string temp = string.Empty;

for (int i = 0; i < userNumber.Length; i++)
{
    if ((userNumber[i] >= '0' && userNumber[i] <= '9') || (userNumber[i] == '-' && temp == string.Empty))
        temp += userNumber[i];
    if ((userNumber[i] == ',' || i == userNumber.Length - 1) && temp != string.Empty)
    {
        int numberEnter = Convert.ToInt32(temp);
        if (numberEnter > 0)
            countPositive++;
        temp = string.Empty;
    }
}

Console.WriteLine($"Количество чисел больше 0: {countPositive}");