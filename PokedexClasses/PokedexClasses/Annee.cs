using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexClasses
{
    public class Annee
    {
        // Declaration Attributs
        private String numAnnee;

        /// <summary>
        /// Constructeur vide de la classe Annee
        /// </summary>
        public Annee ()
        {
            this.numAnnee = null;
        }

        /// <summary>
        /// Constructeur plein de la classe Annee
        /// </summary>
        /// <param name="num">String</param>
        public Annee (String num)
        {
            this.numAnnee = num;
        }

        /// <summary>
        /// Retourne la chaine representant l'annee selectionnee
        /// </summary>
        /// <returns></returns>
        public String GetNumAnnee ()
        {
            return this.numAnnee;
        }

        /// <summary>
        /// rentre ou modifie le numero de l'annee selectionnee
        /// </summary>
        /// <param name="num">String</param>
        public void SetNumAnnee (String num)
        {
            this.numAnnee = num;
        }
    }
}
