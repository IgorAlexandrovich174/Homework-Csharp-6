//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void FindingAnIntersection() {

    System.Console.Write("Введите значения через запятую в следующем порядке - b1, k1, b2, k2: ");
    
    int count = 0;
    double b1 = 0;
    double k1 = 0;
    double b2 = 0;
    double k2 = 0;

    string? inputValue = System.Console.ReadLine();
    double[] ReceivedNumbers = inputValue.Split(new[] {','}).Select(double.Parse).ToArray();
    

    b1 = ReceivedNumbers[count];
    count++;
    k1 = ReceivedNumbers[count];
    count++;
    b2 = ReceivedNumbers[count];
    count++;
    k2 = ReceivedNumbers[count];

    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;

    x = Math.Round(x, 3);
    y = Math.Round(y, 3);

    System.Console.WriteLine("Точка пересечания: "+ x + ":" + y);
}


FindingAnIntersection();
