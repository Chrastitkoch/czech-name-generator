// Generator nahodnych klasickych ceskych jmen

string[] prefix = {"Bar", "Buď", "Bud", "Boh", "Bož", "Bor", "Boř", "Bron", "Bran", "Buz", "Bol", "Cti", "Čest", "Jar", "Kaz",
"Lub", "Lib", "Lud", "Lid", "Mil", "Měř", "Mir", "Rad", "Sob", "Svět", "Vít", "Vlad", "Vrat", "Zby", "Zdi", "Dal", "Old", "Bed"};
string[] suffix = {"imír", "ivoj", "oslav", "islav", "ibor", "buz", "bůz", "mír", "ěslav", "rad", "hněv", "mysl"};
string[] surname = { "Horák", "Kovář", "Kovářík", "Dvořák", "Novák", "Tesařík", "Pospíšil", "Král"};

Random rnd = new Random();

for (int i = 0; i < 10; i++)
{
    int prefixIndex = rnd.Next(prefix.Length);
    int suffixIndex = rnd.Next(suffix.Length);
    int surnameIndex = rnd.Next(surname.Length);
    bool gender = rnd.Next(2) == 0;

    if(gender){
        Console.WriteLine(prefix[prefixIndex] + suffix[suffixIndex] + " " + surname[surnameIndex]);
    }
    else {
        Console.WriteLine(prefix[prefixIndex] + suffix[suffixIndex] + "a " + surname[surnameIndex] + "ová");
    }
    
}
