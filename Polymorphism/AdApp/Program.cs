using System;

namespace AdApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            var c = new Campaign();
            c.AddAdvert(new Advert(1000));
            c.AddAdvert(new Hoarding(500, 7));
            c.AddAdvert(new NewspaperAd(100, 30, 20));
            c.AddAdvert(new TVAd(50000, 30, 10));
            c.AddAdvert(new Poster(200,30,20,2,15));
            Console.WriteLine(c);
        }
    }
}