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

            // SUSIKURIU PAPYLDOMA FUNKCIJA IR NUSKAITYTI VIENA DARBUOTOJO OBJEKTA IR JI GRAZINTI.
        static Darbuotojas NuskaitytiDarbuotojas()
            {
                Darbuotojas darbuotojas = new Darbuotojas();
                Console.WriteLine("Ivesti Darbuotoja: ");
                string pavadinimas = Console.ReadLine();
                darbuotojas.Vardas = pavadinimas;

                return darbuotojas;
            }

        static void IsvestiDarbuotoja(Darbuotojas darbuotojas)
            {
                Console.WriteLine("Vardas: " + darbuotojas.Vardas);
                Console.WriteLine("Pavarde: " + darbuotojas.Pavarde);
                Console.WriteLine("Amzius: " + darbuotojas.Amzius);
                Console.WriteLine("Lytis: " + darbuotojas.Lytis);
                Console.WriteLine("Profesija: " + darbuotojas.Profesija);
                Console.WriteLine("Atlyginimas: " + darbuotojas.Atlyginimas);
                Console.WriteLine("Darbo valandos: " + darbuotojas.DarboValandos);
                Console.WriteLine("Valandos ikainis: " + darbuotojas.ValandosIkainis);

                Console.WriteLine("_ _ _ _ _ _ _ _ _ _  _ _ _ _ _ _ _ _");
            }    


            // sukuriu tuscia objekta Darbuotojas
            Darbuotojas darbuotojas = new Darbuotojas();

            // Bandau isvesti i konsole.
            //Console.WriteLine(darbuotojas.ToString());

            // Sukuriu pilna objekta Darbuotojas

            Darbuotojas darbuotojas2 = new Darbuotojas("Vilandas", "Znamenskas", 54, "Vyras", "Programuotojas", 1920, 160, 12);

            // Isvedu pilna objekta i Darbuotojas i konsole.
           // Console.WriteLine(darbuotojas2.ToString());

            // Gaunu po viena objekto Darbuotojas duomeni ir ji isvedu i konsole.

            Console.WriteLine("Vardas:" + darbuotojas2.Vardas);
            Console.WriteLine("Pavarde:" + darbuotojas2.Pavarde);
            Console.WriteLine("Amzius:" + darbuotojas2.Amzius);
            Console.WriteLine("Lytis:" + darbuotojas2.Lytis);
            Console.WriteLine("Profesija:" + darbuotojas2.Profesija);
            Console.WriteLine("Atlyginimas:" + darbuotojas2.Atlyginimas);
            Console.WriteLine("Darbo valandos:" + darbuotojas2.DarboValandos);
            Console.WriteLine("Valandos ikainis:" + darbuotojas2.ValandosIkainis);
        }
        










    }
}
        

    



