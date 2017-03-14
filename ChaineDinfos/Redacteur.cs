using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaineDinfos
{
    /// <summary>
    /// Un rédacteur est une sorte de journaliste avec ses propres spécialisations
    /// </summary>
    class Redacteur : Journaliste
    {
        /// <summary>
        /// Rédiger un reportage
        /// </summary>
        /// <param name="texteduSujet"></param>
        /// <param name="dateDuSujet"></param>
        /// <param name="titreDuSujet"></param>
        /// <returns></returns>
        public override Reportage Rediger(string texteduSujet, DateTime dateDuSujet, string titreDuSujet)
        {
            //A définir et retourner reportage
            Reportage reportage = new Reportage();
            return reportage;
        }
    }
}
