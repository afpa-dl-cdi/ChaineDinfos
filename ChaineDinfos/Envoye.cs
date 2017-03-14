using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaineDinfos
{
    /// <summary>
    /// un envoyé est un journaliste de terrain.
    /// Aucune autre classe ne pourra héritée de cette classe
    /// </summary>
    sealed class Envoye : Journaliste
    {
        /// <summary>
        /// constructeur générique
        /// </summary>
        /// <param name="prenom"></param>
        public Envoye(string prenom) : base(prenom)
        {
            // A définir
        }

        /// <summary>
        /// constructeur permettant de construire un envoyé avec une mission de type reportage
        /// </summary>
        /// <param name="mission"></param>
        public Envoye (Reportage mission)
        {
            // A définir
        }

        /// <summary>
        /// Zone d'affectation
        /// </summary>
        public string LieuDAffectation { get; set; }

        /// <summary>
        /// Décrit le poste de l'envoyé
        /// </summary>
        public Poste PosteDeLEnvoye { get; set; }

        /// <summary>
        /// Filme un reportage
        /// </summary>
        /// <returns>Reportage</returns>
        public Reportage Filmer()
        {
            Console.WriteLine("Je filme pour {0}", chaineTV );
            Reportage reportage = new Reportage();
            reportage.sujetDuReportage = "Final de pétanque 2017";
            return reportage;
        }

        /// <summary>
        /// Rédige un reportage
        /// </summary>
        /// <param name="texteduSujet"></param>
        /// <param name="dateDuSujet"></param>
        /// <param name="titreDuSujet"></param>
        /// <returns>Reportage</returns>
        public override Reportage Rediger(string texteduSujet, DateTime dateDuSujet, string titreDuSujet)
        {
            Console.WriteLine("je rédige un reportage");
            Reportage reportage = new Reportage();
            reportage.sujetDuReportage = "un sujet";
            return reportage;
        }

    }
}
