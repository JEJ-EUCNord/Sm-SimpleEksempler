/*
 * Her introduceres de basale metoder til at
 * skrive og læse til/fra konsollen i C#
 */

Demo1();
Demo2();
Demo3();
Demo4();
Demo5();
Demo6();

// Demonstration af udskrivning af tekst og tal
void Demo1()
{
    Console.WriteLine("--- Demo1 ---");
    // Udskriv en tekst (streng)
    Console.WriteLine("Hej verden");
    // Udskriv et tal
    Console.WriteLine(67);
}

// Introduktion af variable
void Demo2()
{
    Console.WriteLine("--- Demo 2 ---");
    var a = 7;
    var b = 12;
    Console.WriteLine(a + b);
}

// Introduktion af formatteret udskrivning; 
void Demo3()
{
    Console.WriteLine("--- Demo 3 ---");
    var a = 7;
    var b = 12;
    var c = 0;
    c = a + b;
    Console.WriteLine($"Summen af {a} og {b} er {c}");
}

void Demo4()
{
    Console.WriteLine("--- Demo 4 ---");
    Console.Write("Indtast brugernavn     : ");
    var brugerNavn = Console.ReadLine();
    Console.Write("Indtast dit postnummer : ");
    var postNummer = Console.ReadLine();

    Console.WriteLine($"Hej {brugerNavn}. Du bor i postnummer {postNummer}");
}


// Introduktion til 'if' - betinget udførelse
void Demo5()
{
    Console.WriteLine("--- Demo 5 ---");
    Console.Write("Indtast brugernavn   : ");
    var brugerNavn = Console.ReadLine();
    Console.Write("Indtast dit password : ");
    var password = Console.ReadLine();

    if (password == "1234")
    {
        Console.WriteLine("Velkommen");
    }
    else
    {
        Console.WriteLine("Forkert password");
    }
}

// Introduktion løkker
void Demo6()
{
    string password = "";
    string brugerNavn = "";
    Console.WriteLine("--- Demo 6 ---");
    do
    {
        Console.Write("Indtast brugernavn   : ");
        brugerNavn = Console.ReadLine();
        Console.Write("Indtast dit password : ");
        password = Console.ReadLine();
    } while (password != "1234");
}
