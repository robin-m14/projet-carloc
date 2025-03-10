using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVoituresApp // Assurez-vous que le namespace est bien défini
{
    public class Voiture
    {
        public string Marque { get; set; } = "";
        public string Modele { get; set; } = "";
        public string Annee { get; set; }
        public decimal Prix { get; set; }
        public string Etat { get; set; } = "";
        public int Kilometrage { get; set; }
        public string Carburant { get; set; } = "";
    }
}
