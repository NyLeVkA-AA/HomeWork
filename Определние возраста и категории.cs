Console.WriteLine("Введите возраст человека:");
int age = Convert.ToInt32(Console.ReadLine());

if (age < 13)
{
    Console.WriteLine("Ребенок");
}
else if (age >= 13 && age <= 19)
{
    Console.WriteLine("Подросток");
}
else if (age >= 20 && age <= 59)
{
    Console.WriteLine("Взрослый");
}
else 
{
    Console.WriteLine("Пожилой");
}
