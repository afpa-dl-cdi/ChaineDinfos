using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaineDinfos
{
    abstract class Journaliste
    {
        /* ---------------------------------------
         *            ACCESSEURS                   |
         *---------------------------------------- */
        /// <summary>
        /// prénom du journaliste
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Nom du journaliste
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Theme du journaliste
        /// <example>
        /// journaliste sportif
        /// </example>
        /// </summary>
        public string Theme { get; set; }



        /* ---------------------------------------
         *            METHODES                   |
         *---------------------------------------- */
        /// <summary>
        /// Rédige un article avec la précision de la date et du texte du sujet
        /// </summary>
        /// <param name="texteduSujet"></param>
        /// <param name="dateDuSujet"></param>
        /// /// <param name="titreDuSujet"></param>
        /// <returns></returns>
        public abstract Reportage Rediger(string texteduSujet, DateTime dateDuSujet, string titreDuSujet);


        /* ---------------------------------------
         *            CONSTRUCTEURS                   |
         *---------------------------------------- */

        public Journaliste(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

    }
}
