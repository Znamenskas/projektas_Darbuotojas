using System;

namespace projektasDarbuotojas
{
    internal class Program
    {


        static void Main(string[] args)
        {
            // susikuriu kaip KINTAMAJI
            Darbuotojas darbuotojas1;

            darbuotojas1 = NuskaitytiDarbuotojas();

            IsvestiDarbuotoja(darbuotojas1);
        }
            

            // SUSIKURIU PAPYLDOMA FUNKCIJA IR NUSKAITYTI VIENA DARBUOTOJO OBJEKTA IR JI GRAZINTI.
        static Darbuotojas NuskaitytiDarbuotojas()
            {
                Darbuotojas darbuotojas = new Darbuotojas();
                Console.WriteLine("Ivesti Darbuotojas: ");
              
                

                Console.WriteLine("Vardas: ");
                string vardas = Console.ReadLine();
                darbuotojas.Vardas = vardas;

                Console.WriteLine("Pavarde: ");
                string pavarde = Console.ReadLine();
                darbuotojas.Pavarde = pavarde;

                Console.WriteLine("Amzius: ");
                int amzius = Convert.ToInt32(Console.ReadLine());
                darbuotojas.Amzius = amzius;

                Console.WriteLine("Lytis:");
                string lytis = Console.ReadLine();
                darbuotojas.Lytis = lytis;

                Console.WriteLine("Profesija: ");
                string profesija = Console.ReadLine();
                darbuotojas.Profesija = profesija;

                Console.WriteLine("Atlyginimas: ");
                double atlyginimas = Convert.ToDouble(Console.ReadLine());
                darbuotojas.Atlyginimas = atlyginimas;

                Console.WriteLine("Darbo valandos: ");
                int darboValandos = Convert.ToInt32(Console.ReadLine());
                darbuotojas.DarboValandos = darboValandos;

                Console.WriteLine("Valandos Ikainis: ");
                double valandosIkainis = Convert.ToDouble(Console.ReadLine());
                darbuotojas.ValandosIkainis = valandosIkainis;



                return darbuotojas;
        }

        static void IsvestiDarbuotoja(Darbuotojas darbuotojas1)
        {
            Console.WriteLine("Vardas: " + darbuotojas1.Vardas);
            Console.WriteLine("Pavarde: " + darbuotojas1.Pavarde);
            Console.WriteLine("Amzius: " + darbuotojas1.Amzius);
            Console.WriteLine("Lytis: " + darbuotojas1.Lytis);
            Console.WriteLine("Profesija: " + darbuotojas1.Profesija);
            Console.WriteLine("Atlyginimas: " + darbuotojas1.Atlyginimas);
            Console.WriteLine("Darbo valandos: " + darbuotojas1.DarboValandos);
            Console.WriteLine("Valandos ikainis: " + darbuotojas1.ValandosIkainis);

            
        }    


            
    }
        










    
}
        

    



