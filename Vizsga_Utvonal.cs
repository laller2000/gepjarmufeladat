using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizsgautvonalterv
{
    class Vizsga_Utvonal
    {
        private int id;
        private string gepjarmuID;
        private string honnan;
        private string hova;
        private int km;

        public int Id { get => id; set => id = value; }
        public string GepjarmuID { get => gepjarmuID; set => gepjarmuID = value; }
        public string Honnan { get => honnan; set => honnan = value; }
        public string Hova { get => hova; set => hova = value; }
        public int Km { get => km; set => km = value; }

        public Vizsga_Utvonal(int id, string gepjarmuID, string honnan, string hova, int km)
        {
            Id = id;
            GepjarmuID = gepjarmuID;
            Honnan = honnan;
            Hova = hova;
            Km = km;
        }
    }
}
