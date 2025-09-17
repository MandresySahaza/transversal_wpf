using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadWatchMada.Models
{
    public class Signalement
    {
        public int Id { get; set; }
        public string NomSignaleur { get; set; }
        public string PrenomSignaleur { get; set; }
        public DateTime DateSignalement { get; set; }
        public string Statut { get; set; }
        public string Categorie { get; set; }
        public string Localisation { get; set; }
    }
}
