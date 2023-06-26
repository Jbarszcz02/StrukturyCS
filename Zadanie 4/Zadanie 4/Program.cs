using System;
class Program
{
    enum Płeć
    {
        Mężczyzna,
        Kobieta
    }

    struct Student
    {
        public string Nazwisko;
        public int Nralbumu;
        public float Ocena;
        public Płeć Płeć;

    }
    
    static void WypełnijDane(ref Student student, string Nazwisko, int Nralbumu, float Ocena, Płeć Płeć )
    {
        student.Nazwisko = Nazwisko;
        student.Nralbumu = Nralbumu;
        student.Ocena = Ocena;
        student.Płeć = Płeć;
    }

    static void Wyświetl(Student[] students)
    {
        foreach (var student in students)
        {
            Console.WriteLine($"Nazwisko: {student.Nazwisko}, ");
            Console.WriteLine($"Nr Albumu: {student.Nralbumu}, ");
            Console.WriteLine($"Ocena: {student.Ocena}, ");
            Console.WriteLine($"Płeć: {student.Płeć}, ");
        }
    }
    
    static float ObliczŚrednią(Student[] students)
    {
        float suma = 0;
        foreach (var  student in students)
        {
            suma += student.Ocena;
        }

        return suma / students.Length;
        {
            
        }
    }

    static void Main(string[] args )
    {
        Student[] studentg = new Student[5];
        WypełnijDane(ref studentg[0], "Barszcz", 12345, 4.5f, Płeć.Mężczyzna);
        WypełnijDane(ref studentg[1], "Banasik", 12435, 4.8f, Płeć.Mężczyzna);
        WypełnijDane(ref studentg[2], "Bortlik", 32145, 3.2f, Płeć.Mężczyzna);
        WypełnijDane(ref studentg[3], "Sziler", 43215, 4.1f, Płeć.Mężczyzna);
        WypełnijDane(ref studentg[4], "Antonowicz", 52145, 2.5f, Płeć.Mężczyzna);

        Console.WriteLine("Studenci:");
        Wyświetl(studentg);

        float średnia = ObliczŚrednią(studentg);
        Console.WriteLine("\nŚrednia: " + średnia);

    }
}