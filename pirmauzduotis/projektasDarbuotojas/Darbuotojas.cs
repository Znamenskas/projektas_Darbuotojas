using System;
namespace projektasDarbuotojas
{
    public class Darbuotojas
    {

        // 1.Klases kintamieji
        private string vardas;
        private string pavarde;
        private int amzius;
        private string lytis;
        private string profesija;
        private double atlyginimas;
        private int darboValandos;
        private double valandosIkainis;

        // Konstruktoriai

        public Darbuotojas(string vardas, string pavarde, int amzius, string lytis, string profesija, double atlyginimas, int darboValandos, double valandosIkainis)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.amzius = amzius;
            this.lytis = lytis;
            this.profesija = profesija;
            this.atlyginimas = atlyginimas;
            this.darboValandos = darboValandos;
            this.valandosIkainis = valandosIkainis;
        }
        // Tuscias KONSTRUKTORIUS

        public Darbuotojas()
        {

        }

        // GALI BUTI DAR KONSTRUKTORIU JEIGU JU REIKIA.

        // GETERIAI SETERIAI.

        public string Vardas
        {
            get { return vardas; }
            set { vardas = value; }
        }
        public string Pavarde
        {
            get { return pavarde; }
            set { pavarde = value; }
        }
        public int Amzius
        {
            get { return amzius; }
            set { amzius = value; }
        }
        public string Lytis
        {
            get { return lytis; }
            set { lytis = value; }
        }
        public string Profesija
        {
            get { return profesija; }
            set { profesija = value; }
        }
        public double Atlyginimas
        {
            get { return atlyginimas; }
            set { atlyginimas = value; }
        }
        public int DarboValandos
        {
            get { return darboValandos; }
            set { darboValandos = value; }
        }
        public double ValandosIkainis
        {
            get { return valandosIkainis; }
            set { valandosIkainis = value; }
        }

    }

}
