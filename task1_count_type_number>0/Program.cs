/*
Задача 41: Пользователь вводит с 
клавиатуры M чисел. Посчитайте, сколько 
чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


 List<int> numbers = new List<int>();

        Console.WriteLine("Введите 5 чисел:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Число {0}: ", i + 1);
            int number = Convert.ToInt32(Console.ReadLine());
            numbers.Add(number);
        }

        Console.WriteLine("Введенные числа:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

int GetCountPositiveNumbersInCollection(List<int> collection)
    {
        int count = 0;
        foreach (int number in collection)
        {
            if (number > 0)
            {
                count++;
            }
        }
        return count;
    }

int count = GetCountPositiveNumbersInCollection(numbers);
Console.WriteLine($"Count numbers > 0 here is -> {count}");