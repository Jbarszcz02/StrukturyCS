using System;

class Program
{
    enum dzien
    {
        Poniedziałek,
        Wtorek,
        Środa,
        Czwartek,
        Piątek,
        Sobota,
        Niedziela
    }

    enum pralka
    {
        Mycie,
        Płukanie,
        Kręcenie,
        Suszenie
    }

    enum jedzenie
    {
        Śniadanie,
        Lunch,
        Obiad,
        Podwieczorek,
        Kolacja
    }

    enum szachy
    {
        Pionek,
        Skoczek,
        Goniec,
        Wieża,
        Król,
        Królowa
    }

static void Main(string[] args)
{
    dzien dzis = dzien.Poniedziałek;
    Console.WriteLine("Dzisiaj jest " + dzis);

    pralka faza = pralka.Mycie;
    Console.WriteLine("Aktualny etap prania: " + faza);

    jedzenie danie  = jedzenie.Lunch;
    Console.WriteLine("Obecny posiłek: " + danie);

    szachy dostepnefigury = szachy.Pionek | szachy.Skoczek | szachy.Goniec;
    Console.WriteLine("Dostępne bierki szachowe: " + dostepnefigury);
}
}