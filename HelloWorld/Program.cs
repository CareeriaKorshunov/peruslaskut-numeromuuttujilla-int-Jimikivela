namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //luku muuttujat
            int luku1 = 10;
            int luku2 = 5;

            //tulos muuttujat
            int tulo;
            int erotus;
            int summa;
            int osamäärä;
            
            //annetaan arvot tulos muuttujille luku muuttujista
            summa = luku1 + luku2;
            erotus = luku1 - luku2;
            tulo = luku1 * luku2;
            osamäärä = luku1 / luku2;

            //tulostetaan vastaukset
            Console.WriteLine("Peruslaskujen tulokset:");
            Console.WriteLine("Tulo: " + tulo);
            Console.WriteLine("Summa: " + summa);
            Console.WriteLine("Erotus: " + erotus);
            Console.WriteLine("Osamäärä: " + osamäärä);


        }
    }
}
