string name = "Ewa";
var sex = "woman";
int age = 17;

if (sex == "woman" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex != "Woman" && age<18)
{
    Console.WriteLine("Niepełnoletni  Mężczyzna");
}