Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "Masha")
{
    Console.WriteLine("Ura,ato ge Masha");
}
else
{
    Console.Write("Привет");
    Console.Write(username);
}