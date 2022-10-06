Console.WriteLine("Введите ваше имя");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    Console.WriteLine ("Ура, это же Маша с Амурлитмаша");
}
 else
{
    Console.Write("Привет,");
    Console.Write(username);
}