using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir limit değeri girin: ");
        int limit = int.Parse(Console.ReadLine());

        int sayac = 0;

        while (sayac <= limit)
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayac++;  
        }
    }
}


// do while da kontrol sonda oldugu için en az 1 kere yazıyor fakat whileda basta oldugu icin olumsuz olabiliyor
