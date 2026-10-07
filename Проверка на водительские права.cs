Console.WriteLine("Введите ваш возраст:");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Есть ли у вас водительское удостоверение? (Введите 1 - если есть, 0 - если нет)");
int hasLicense = Convert.ToInt32(Console.ReadLine());

if (age >= 18 && hasLicense == 1)
{
    Console.WriteLine("Можно водить");
}
else
{
    Console.WriteLine("Нельзя водить");
}
