using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaineDinfos
{
    sealed class Envoye : Journaliste
    {
        /// <summary>
        /// Zone d'affectation
        /// </summary>
        public string LieuDAffectation { get; set; }

        /// <summary>
        /// Décrit le poste de l'envoyé
        /// </summary>
        public Poste PosteDeLEnvoye { get; set; }


        public Reportage Filmer()
        {
            Console.WriteLine("Je filme");
            Reportage reportage = new Reportage();
            reportage.sujetDuReportage = "Final de pétanque 2017";
            return reportage;
        }

        public override Reportage Rediger(string texteduSujet, DateTime dateDuSujet, string titreDuSujet)
        {
            Console.WriteLine("je rédige un reportage");
            Reportage reportage = new Reportage();
            reportage.sujetDuReportage = "un sujet";
            return reportage;
        }

         

    }
}
