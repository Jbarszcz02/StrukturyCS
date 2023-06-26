using System;
class Program
{
    struct Student
    {
        public string Imie;
        public string Nazwisko;
        public int Wiek;
        public string Kierunek;
    }

    struct Przedmiot
    {
        public string Nazwa;
        public int LiczbaGodzin;
        public int Punkty;
    }

    struct Nauczyciel
    {
        public string Imie;
        public string Nazwisko;
        public int Wiek;
        public string Przedmiot;
    }

    static void Main(string[] args)
    {
        Student student1;
        student1.Imie = "Jakub";
        student1.Nazwisko = "Barszcz";
        student1.Wiek = 20;
        student1.Kierunek = "Informatyka";

        Przedmiot przedmiot1;
        przedmiot1.Nazwa = "Programowanie";
        przedmiot1.LiczbaGodzin = 15;
        przedmiot1.Punkty = 5;

        Nauczyciel nauczyciel1;
        nauczyciel1.Imie = "Mariusz";
        nauczyciel1.Nazwisko = "Mol";
        nauczyciel1.Wiek = 36;
        nauczyciel1.Przedmiot = "Programowanie";

        Console.WriteLine("Student: ");
        Console.WriteLine("Imie: " + student1.Imie);
        Console.WriteLine("Nazwisko: " + student1.Nazwisko);
        Console.WriteLine("Wiek: " + student1.Wiek);
        Console.WriteLine("Kierunek: " + student1.Kierunek);

        Console.WriteLine("\nPrzedmiot: ");
        Console.WriteLine("Nazwa: " + przedmiot1.Nazwa);
        Console.WriteLine("Liczba godzin: " + przedmiot1.LiczbaGodzin);
        Console.WriteLine("Punkty: " + przedmiot1.Punkty);

        Console.WriteLine("\nNauczyciel:");
        Console.WriteLine("Imie: " + nauczyciel1.Imie);
        Console.WriteLine("Nazwisko: " + nauczyciel1.Nazwisko);
        Console.WriteLine("Wiek: " + nauczyciel1.Wiek);
        Console.WriteLine("Przedmiot: " + nauczyciel1.Przedmiot);


    }
}