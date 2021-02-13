using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseFee
{
    class AmbientalLicenseFee
    {
        static void Main(string[] args)
        {

            FishermanTaxCalculator f = new FishermanTaxCalculator();
            int qtd;

            Console.WriteLine("Number of fishermen: ");
            qtd = int.Parse(Console.ReadLine());

            if(qtd<1)
            {
                Console.WriteLine("The quantity needs to be a positive number!");
                Console.WriteLine("Number of fishermen: ");
                qtd = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i<qtd;i++)
            {
                Console.WriteLine("Name: ");
                f.name = Console.ReadLine();

                Console.WriteLine("Category: ");
                f.category = char.Parse(Console.ReadLine());
                f.category = Char.ToUpper(f.category);

                if(f.category!='C'&&f.category!='E')
                {
                    do
                    {
                        Console.WriteLine("Error! Enter with Category 'C' or 'E' (C to coastal fishing and E to embarked fishing)");
                        Console.WriteLine("Category: ");
                        f.category = char.Parse(Console.ReadLine());
                        f.category = Char.ToUpper(f.category);
                    } while (f.category != 'C'&&f.category!='E');
                }

                Console.WriteLine("Age: ");
                f.age = int.Parse(Console.ReadLine());

                if(f.age<0)
                {
                    do
                    {
                        Console.WriteLine("Error! Age are only positive numbers.");
                        Console.WriteLine("Age: ");
                        f.age = int.Parse(Console.ReadLine());
                    } while (f.age < 0);
                }

                Console.WriteLine("Anual Tax: {0:c}", f.anualTax);
            }

            Console.ReadKey();

        }
    }
}
