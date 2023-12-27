class Zodiac
{
    static void Main(string[] args)
    {
        Console.Write("Введите день рождения: ");
        int day = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите месяц рождения: ");
        int month = Convert.ToInt32(Console.ReadLine());

        int sign = GetZodiac(day, month);

        Console.WriteLine("Ваш знак зодиака: " + sign);
    }

    static int GetZodiac(int day, int month)
    {
        if ((month == 3 && day >= 22) || (month == 4 && day <= 21))
            return 4; // Овен
        else if ((month == 4 && day >= 22) || (month == 5 && day <= 21))
            return 5; // Телец
        else if ((month == 5 && day >= 22) || (month == 6 && day <= 21))
            return 6; // Близнецы
        else if ((month == 6 && day >= 22) || (month == 7 && day <= 21))
            return 7; // Рак
        else if ((month == 7 && day >= 22) || (month == 8 && day <= 21))
            return 8; // Лев
        else if ((month == 8 && day >= 22) || (month == 9 && day <= 21))
            return 9; // Дева
        else if ((month == 9 && day >= 22) || (month == 10 && day <= 21))
            return 10; // Весы
        else if ((month == 10 && day >= 22) || (month == 11 && day <= 21))
            return 11; // Скорпион
        else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
            return 12; // Стрелец
        else if ((month == 12 && day >= 22) || (month == 1 && day <= 21))
            return 1; // Козерог
        else if ((month == 1 && day >= 22) || (month == 2 && day <= 21))
            return 2; // Водолей
        else
            return 3; // Рыбы
    }
}