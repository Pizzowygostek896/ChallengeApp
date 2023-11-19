
// Dzień Czwarty
string name = "Ewa";
var isWomen = "true";
int age = 33;

if (isWomen == "true" && age < 30)
{
    Console.WriteLine("Kobieta Poniżej 30 lat");
}
else if (isWomen == "true" && age == 33 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}
else if (isWomen == "false" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine($"Osoba o imieniu: {name} w wieku: {age} lat");
}