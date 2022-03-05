using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizsgautvonalterv
{
    class Vizsga_Gepjarmu
    {
        private string rendszam;
        private string marka;
        private string tipus;
        private string tulaj_neve;
        private double fogyasztas;

        public string Rendszam { get => rendszam; set => rendszam = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string Tulaj_neve { get => tulaj_neve; set => tulaj_neve = value; }
        public double Fogyasztas { get => fogyasztas; set => fogyasztas = value; }

        public Vizsga_Gepjarmu(string rendszam, string marka, string tipus, string tulaj_neve, double fogyasztas)
        {
            Rendszam = rendszam;
            Marka = marka;
            Tipus = tipus;
            Tulaj_neve = tulaj_neve;
            Fogyasztas = fogyasztas;
        }
    }
}
