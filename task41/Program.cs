//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//
//0, 7, 8, -2, -2 -> 2
//
//1, -7, 567, 89, 223-> 3

int CountingNumbers() {
    int count = 0;
    System.Console.Write("Введите числа через запятую: ");
    string? inputValue = System.Console.ReadLine();
    int[] array = inputValue.Split(new[] { ',' }).Select(int.Parse).ToArray();
    for (int i = 0; i < array.Length; i++) {
        if(array[i] > 0) {
            count++;
        }
    }
    System.Console.WriteLine("Количество цифр больше 0: " + count);
    return count;
}

CountingNumbers();