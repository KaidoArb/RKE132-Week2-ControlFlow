// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajalt sugu (m/f)
//rakendus küsib kasutajalt perekonnanime
//rakendus tervitab kasutajat, lähtudes valikust:
//"Welcome, Mr. [kasutaja perekonnanimi]" / "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");
char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string formaadis

Console.WriteLine("Please, enter your surname:");
string userSurname = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userSurname}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userSurname}!");
}
else
{
    Console.WriteLine($"Welcome, {userSurname}!");
}
