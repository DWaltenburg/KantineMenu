using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KantineMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.name = "Pizza";
            class1.price = 28;
            class1.desc = "Du får et fladt stykke brød af questionable character. " +
                          "Hvis du forventer spiselige kanter, hold dig væk. " +
                          "Hvis du elsker at ødelægge din tænder, er du kommet til det rette sted. " +
                          "Har også salat og to valg af dressing. Luksus.";

            Console.WriteLine($"Dagens menu er {class1.name} for {class1.price} kr");
            Console.WriteLine(class1.desc);
          
        }
    }
}