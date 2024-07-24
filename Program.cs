// Programın random belirlediği bir sayıya yaklaşan program.


Random rnd = new Random();

int randomSayi = rnd.Next(10);

Console.WriteLine("Bakalım ne kadar şanşlısın? Random sayı belirlendi, BAŞLA!");

int tahmin = Convert.ToInt32(Console.ReadLine());


while (randomSayi != tahmin)
{
   
    if (tahmin < randomSayi)
    { 
        Console.WriteLine("Daha büyük bir sayı gir \n"); 
    }


    else if (tahmin > randomSayi)
    {
        Console.WriteLine("Daha küçük bir sayı gir \n");
    }
    else
    {
        Console.WriteLine("BRAVO");
    }
}



