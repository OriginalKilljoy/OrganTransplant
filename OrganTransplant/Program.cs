
using System.Net.NetworkInformation;
using OrganTransplant;

List<Organ> organs;
List<Human> humans;

organs = new List<Organ>
{
    new Organ("Nyre", false),
    new Organ("Nyre", false),
    new Organ("Nyre", true),
    new Organ("Nyre", true),
};

humans = new List<Human>
{
    new Human("Bernt", 34, false, new List<Organ>{organs[0], organs[1]}),
    new Human("Kåre", 32, true, new List<Organ>{organs[2], organs[3]}),
};




Console.WriteLine($"Det har vært en ulykke!!");
Thread.Sleep(1000);
CheckHealth();
Thread.Sleep(1000);
CheckHealth2();
Thread.Sleep(2000);
Console.WriteLine($"Legene sier at det er en høy suksessrate hvis {humans[1]._name} donerer en nyre til {humans[0]._name}.");
Thread.Sleep(2000);
Console.WriteLine("Ønsker du å iverksette transplantasjonen?");
Console.WriteLine("[1]Ja\n[2]Nei");
var userInput = Console.ReadLine();

switch (userInput)
{
    case "1":
        MakeTransplant();
        break;
    case "2":
        Console.WriteLine("...... Det var dumt....");
        break;
}

void CheckHealth()
{
    if (humans[0]._isHealthy == false)
    {
        Console.WriteLine($"Det ser ut som {humans[0]._name} ikke klarte seg så bra...");
    }
}

void CheckHealth2()
{
    if (humans[1]._isHealthy == true) 
    {
        Console.WriteLine($"{humans[1]._name}, fetteren til {humans[0]._name}, er derimot frisk som en fisk.");
    }
}

void MakeTransplant()
{
    humans[0]._myOrgans.RemoveAt(0);
    humans[1]._myOrgans.RemoveAt(0);
    humans[0]._myOrgans.Add(organs[2]);

    Console.WriteLine($"{humans[1]._name} ga nyren sin til {humans[0]._name} og reddet livet hans!");
}

//bool isChoosing = false;

//while( isChoosing)
//{
//    Console.WriteLine("Hva ønsker du å gjøre?");
//    Console.WriteLine("[1]Sjekk helse\n[2]Utfør transplantasjon");
//    var userInput = Console.ReadLine();
//    switch (userInput)
//    {
//        case "1":
//            IsHealthy();
//            break;
//        case "2":
//            break;
//    }
//}

//void IsHealthy()
//{
//    Console.WriteLine("Hvem vil du sjekke?");
//    Console.WriteLine($"[1]{humans[0]}\n[2]{humans[1]}");
//    var userInput = Console.ReadLine();
//    switch (userInput)
//    {
//        case "1":
//            break;
//        case "2":
//            break;
//    }
//}

//var input = Convert.ToInt32(Console.ReadLine());
//IsOrganHealthy(input);

//void IsOrganHealthy(int input)
//{
//    if (organs[input - 1]._isHealthy == false)
//    {
//        Console.WriteLine("Denne nyren er ikke sunn");
//    }
//    else
//    {
//        Console.WriteLine("Denne nyren er sunn!");
//    }
//}