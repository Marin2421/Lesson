//Домашнее задание. Тема 11. Урок 3. Условные операторы и класс Random.
//1
Random random = new Random();
Console.Write("Введите число от 0 до 5:");
int n = int.Parse(Console.ReadLine());
int m = random.Next(0, 6);
if (n == m) Console.WriteLine("Победа");
else Console.WriteLine("Поражение");
//2
Console.WriteLine("Введите номер месяца:");
int a = int.Parse(Console.ReadLine());
switch (a)
{
    case 12:
    case 1:
    case 2:
        {
            Console.Write("Какая температура: ");
            int b = int.Parse(Console.ReadLine());
            if (b > 0) Console.WriteLine("Дождливая зима");
        }
        break;
    case 3:
    case 4:
    case 5:
        {
            Console.WriteLine("Весна");
        }
        break;
    case 6:
    case 7:
    case 8:
        {
            Console.WriteLine("Лето");
        }
        break;
    case 9:
    case 10:
    case 11:
        {
            Console.WriteLine("Осень");
        }
        break;
    default: Console.WriteLine("Нет такого месяца"); break;
}
//Домашнее задание. Тема 11. Урок 4. Условные операторы и класс Random.
Console.Write("Ваш возраст:");
int age = int.Parse(Console.ReadLine());
Console.Write("За кого вы будете болеть, если проиграете в выборах или будете недопущены до них?\n1 - Незнайка\n2 - Лунтик\n3 - Карлсон\n" +
    "4 - Дядя Фёдор");
int leaders = int.Parse(Console.ReadLine());
switch (leaders)
{
    case 1:
        Console.Write("А у тебя в животе арбуз вырастет!!!\n"); break;
    case 2: Console.Write("Я упал с луны\n"); break;
    case 3: Console.Write("Я люблю варенье\n"); break;
    case 4: Console.Write("Я ничей. Я сам по себе мальчик. Свой собственный.\n"); break;
    default: Console.Write("Нет такого кандидата\n"); break;
}
if (age < 18) Console.WriteLine("Вы слишком молоды для участия в выборах");
else if (age >= 18 && age <= 35) Console.WriteLine("Вы можете участвовать в выборах в качестве депутата");
else if (age >= 36 && age <= 65) Console.WriteLine("Вы можете участвовать в выборах в качестве кандидата в президенты");
else Console.WriteLine("Ваш возраст слишком велик для участия в выборах");
//2
Random random = new Random();
int r = random.Next(1, 13);
switch (r)
{
    case 1: Console.Write("Январь"); break;
    case 2: Console.Write("Февраль"); break;
    case 3: Console.Write("Март"); break;
    case 4: Console.Write("Апрель"); break;
    case 5: Console.Write("Май"); break;
    case 6: Console.Write("Июнь"); break;
    case 7: Console.Write("Июль"); break;
    case 8: Console.Write("Август"); break;
    case 9: Console.Write("Сентябрь"); break;
    case 10: Console.Write("Октябрь"); break;
    case 11: Console.Write("Ноябрь"); break;
    case 12: Console.Write("Декабрь"); break;

}