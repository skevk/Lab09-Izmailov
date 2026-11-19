int totalExercises = 8;

for (int number = totalExercises; number >= 1; number--)
{
    Console.WriteLine($"Упражнение {number}");
}

Console.WriteLine("Домашнее задание готово");


for (int room = 5; room <= 50; room += 5)
{
    Console.WriteLine($"Кабинет {room}");
}


int totalWeeks = 3;

for (int week = 1; week <= totalWeeks; week++)
{
    for (int day = 1; day <= 5; day++)
    {
        Console.WriteLine($"Неделя {week}, день {day}");
    }
    Console.WriteLine("^_^");
}


int skippedCount = 0;

for (int ticket = 1; ticket <= 30; ticket++)
{
    if (ticket == 4 || ticket == 12 || ticket == 19)
    {
        skippedCount++;
        continue;
    }
    Console.WriteLine($"Пропущено билетов: {skippedCount}. Первый доступный билет: {ticket}");
    break;
}


for (; ; ) {
    Console.Write("Введите код группы (для выхода — «выход»): ");
    string groupCode = Console.ReadLine();

    if (groupCode == "выход") {
        break;
    }

    Console.WriteLine($"Записан код группы: {groupCode}");
}

Console.WriteLine("Работа с журналом завершена");


for (int i = 100; i >= 0; i -= 10)
{
    Console.WriteLine(i);
}

int N = 15;

for (int i = 1; i <= N; i += 2)
{
    Console.WriteLine(i);
}


Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();

if (string.IsNullOrEmpty(surname)) {
    Console.WriteLine("Фамилия не введена. Завершение работы.");
    return;
}

Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

var assigned = Enumerable.Range(1, 10)
    .OrderBy(_ => rnd.Next())
    .Take(2)
    .OrderBy(x => x)
    .ToList();

Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


int A = 4; 
for (int i = 1; i <= A; i++) 
{
    for (int j = 1; j <= i; j++) 
    {
        Console.Write("*"); 
    }
    Console.WriteLine(); 
}


for (int i = 1; i <= 30; i++)
{
    if (i % 4 == 0)
    {
        continue; 
    }
    
    Console.WriteLine(i);
}
