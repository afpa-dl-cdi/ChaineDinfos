using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaineDinfos
{
    /// <summary>
    /// Classe abstraite permettant de définir la fonction générique du journaliste
    /// </summary>
    abstract class Journaliste
    {
        /* ---------------------------------------
         *            VARIABLES                    |
         *---------------------------------------- */
         /// <summary>
         /// Compteur du nombre d'instanciation de la classe journaliste
         /// </summary>
        static public int count;

        /// <summary>
        /// Titre de la chaine
        /// </summary>
        protected const string chaineTV = "RVNews";
        
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
        *            CONSTRUCTEURS                 |
        *---------------------------------------- */
        /// <summary>
        /// constructeur générique
        /// </summary>
        public Journaliste()
        {
            // ce constructeur pour l'instant n'exécute rien
            count++;
        }

        /// <summary>
        /// constructeur permettant de créer un journaliste avec son prénom
        /// </summary>
        /// <param name="prenom"></param>
        public Journaliste (string prenom)
        {
            Prenom = prenom;
        }

        /// <summary>
        /// constructeur permettant de créer un journaliste avec son nom et prénom 
        /// </summary>
        /// <param name="prenom"></param>
        /// <param name="nom"></param>
        public Journaliste (string prenom, string nom)
        {
            Prenom = nom;
            Nom = nom;
        }


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



    }
}
