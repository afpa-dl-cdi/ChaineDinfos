﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaineDinfos
{
    /// <summary>
    /// un envoyé est un journaliste de terrain.
    /// Aucune autre classe ne pourra hériter de cette classe
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
        /// Constructeur avec valeur par défaut
        /// </summary>
        /// <param name="joursDeLaMission"></param>
        public Envoye (int joursDeLaMission = 10)
        {
            Console.WriteLine("nombre de jours de la mission : {0}", joursDeLaMission);
        }

        /// <summary>
        /// Constructeur pour illustrer un appel par "étiquette"
        /// </summary>
        /// <param name="departementDeLaMission"></param>
        /// <param name="joursDeLaMission"></param>
        public Envoye(string departementDeLaMission, int joursDeLaMission = 10)
        {
            Console.WriteLine("département de la mission : {0}", departementDeLaMission);
            Console.WriteLine("nombre de jours de la mission : {0}", joursDeLaMission);
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
