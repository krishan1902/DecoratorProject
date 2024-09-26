using System.Buffers.Binary;
using System.ComponentModel;

namespace CoffeeShop_Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaffee Automat - Krishan, Isma\n");
            Console.WriteLine("extra Milch kostet 60 Cent\nextra Zucker kostet 40 Cent\nextra Kakaopulver kostet 50 Cent\n\n");

            //Schwarzer Kaffee
            Kaffee schwarzerKaffee = new SchwarzerKaffee();
            Console.WriteLine($"{schwarzerKaffee.getDescription()}\t\t\t\t = {schwarzerKaffee.getPrice()} Euro.");
            
            //Schwarzer Kaffee mit Milch
            Kaffee schwarzerKaffeeMilch = new MilchDecorator(schwarzerKaffee);
            Console.WriteLine($"{schwarzerKaffeeMilch.getDescription()}\t\t = {schwarzerKaffeeMilch.getPrice()} Euro.");

            //Schwarzer Kaffee mit Zucker
            Kaffee schwarzerKaffeeZucker = new ZuckerDecorator(schwarzerKaffee);
            Console.WriteLine($"{schwarzerKaffeeZucker.getDescription()}\t\t = {schwarzerKaffeeZucker.getPrice()} Euro.");

            //Schwarzer Kaffee mit Kakaopulver
            Kaffee schwarzerKaffeeKakao = new KakaoDecorator(schwarzerKaffee);
            Console.WriteLine($"{schwarzerKaffeeKakao.getDescription()}\t\t = {schwarzerKaffeeKakao.getPrice()} Euro.");

            //Schwarzer Kaffee mit Milch, Zucker und Kakaopulver
            Kaffee schwarzerKaffeeAllMilch = new MilchDecorator(schwarzerKaffee);
            Kaffee schwarzerKaffeeAllZucker = new ZuckerDecorator(schwarzerKaffeeAllMilch);
            Kaffee schwarzerKaffeeAllKakao = new KakaoDecorator(schwarzerKaffeeAllZucker);
            Console.WriteLine($"\n{schwarzerKaffeeAllKakao.getDescription()}\t = {schwarzerKaffeeAllKakao.getPrice()} Euro.");

        }
    }
}
