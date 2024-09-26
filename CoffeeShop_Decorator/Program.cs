using System.Buffers.Binary;
using System.ComponentModel;

namespace CoffeeShop_Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decorator Design Pattern - Kaffee Beispiel - Krishan, Isma\n");

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
            Kaffee kaffeeMitAlles = new SchwarzerKaffee();
            kaffeeMitAlles = new MilchDecorator(kaffeeMitAlles);
            kaffeeMitAlles = new ZuckerDecorator(kaffeeMitAlles);
            kaffeeMitAlles = new KakaoDecorator(kaffeeMitAlles);
            Console.WriteLine($"\n{kaffeeMitAlles.getDescription()}\t = {kaffeeMitAlles.getPrice()} Euro.");

        }
    }
}
