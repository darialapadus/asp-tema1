using System;
using System.Collections.Generic;

class Gen
{
    public string Titlu { get; set; }
    public int Varsta { get; set; }

    public Gen(string titlu, int varsta)
    {
        Titlu = titlu;
        Varsta = varsta;
    }
}

class Film
{
    public string Nume { get; set; }
    public string Durata { get; set; }
    public string Sala { get; set; }
    public List<Gen> Genuri { get; set; }

    public Film(string nume, string durata, string sala)
    {
        Nume = nume;
        Durata = durata;
        Sala = sala;
        Genuri = new List<Gen>();
    }
}

class Program
{
    static void Main()
    {
        Gen actiune = new Gen("Actiune", 16);
        Gen comedie = new Gen("Comedie", 12);
        Gen drama = new Gen("Drama", 15);
        Gen horror = new Gen("Horror", 18);
        Gen mister = new Gen("Mister", 18);
        Gen thriller = new Gen("Thriller", 18);
        Gen romantic = new Gen("Romantic", 15);


        Film film1 = new Film("NUNTA PE BANI", "95 min", "Sala 1");
        Film film2 = new Film("CALUGARITA II", "110 min", "Sala 2");
        Film film3 = new Film("DUPA TOT CE S-A INTAMPLAT", "94 min", "Sala 3");

        film1.Genuri.Add(comedie);
        film2.Genuri.Add(horror);
        film2.Genuri.Add(mister);
        film2.Genuri.Add(thriller);
        film3.Genuri.Add(drama);
        film3.Genuri.Add(romantic);

        Console.WriteLine("Film 1: " + film1.Nume);
        Console.WriteLine("Durata: " + film1.Durata);
        Console.WriteLine("Sala: " + film1.Sala);
        Console.WriteLine("Genuri:");
        foreach (var gen in film1.Genuri)
        {
            Console.WriteLine("- " + gen.Titlu + " (Varsta minima: " + gen.Varsta + ")");
        }

        Console.WriteLine();

        Console.WriteLine("Film 2: " + film2.Nume);
        Console.WriteLine("Durata: " + film2.Durata);
        Console.WriteLine("Sala: " + film2.Sala);
        Console.WriteLine("Genuri:");
        foreach (var gen in film2.Genuri)
        {
            Console.WriteLine("- " + gen.Titlu + " (Varsta minima: " + gen.Varsta + ")");
        }

        Console.WriteLine();

        Console.WriteLine("Film 3: " + film3.Nume);
        Console.WriteLine("Durata: " + film3.Durata);
        Console.WriteLine("Sala: " + film3.Sala);
        Console.WriteLine("Genuri:");
        foreach (var gen in film3.Genuri)
        {
            Console.WriteLine("- " + gen.Titlu + " (Varsta minima: " + gen.Varsta + ")");
        }
    }
}
