// Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями
//y = k1*x + b1,   y = k2*x + b2;
//значения b1,k1, b2 и k2 задаются пользователем.

double b1 = inputValue("b1");
double k1 = inputValue("k1");
double b2 = inputValue("b2");
double k2 = inputValue("k2");

double inputValue(string value)
{
    Console.WriteLine($"Введение значение {value}: ");
    return Convert.ToDouble(Console.ReadLine());
}
if(k1!=k2)
{
    double x = (b2-b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения двух прямых {x} {y}");
}
else
{
    if(b1 == b2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else
    {
       Console.WriteLine("Прямые параллельны"); 
    }
}




