Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Ну и пиздуй, Я Машу жду. Как тебя там - ");
    Console.WriteLine(username);
}