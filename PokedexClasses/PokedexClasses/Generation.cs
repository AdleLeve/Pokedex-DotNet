using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexClasses
{
    public class Generation
    {
        // Declaration Attributs
        private int numero;
        private String libelle;
        private Annee annee;

        /// <summary>
        /// Constructeur vide de la classe Generation
        /// </summary>
        public Generation()
        {
            this.numero = 0;
            this.libelle = null;
            this.annee = null;
        }

        /// <summary>
        /// Constructeur plein de la classe Generation
        /// </summary>
        /// <param name="num">int</param>
        /// <param name="lib">String</param>
        /// <param name="an">Annee</param>
        public Generation(int num, String lib, Annee an)
        {
            this.numero = num;
            this.libelle = lib;
            this.annee = an;
        }

		/// <summary>
		/// Renvoie un Entier representant le numero de Generation de l'objet selectionne
		/// </summary>
		/// <returns>int</returns>
		public int GetNumGeneration()
		{
			return this.numero;
		}

		/// <summary>
		/// Definis ou redefinis le numero de l'objet Generation selectionne
		/// </summary>
		/// <param name="num">int</param>
		public void SetNumGenration(int num)
		{
			this.numero = num;
		}

		/// <summary>
		/// Renvoie une Chaine representant le libelle de la Generation de l'objet Generation selectionne
		/// </summary>
		/// <returns>String</returns>
		public String GetLibGeneration()
		{
			return this.libelle;
		}

		/**
		 * definis ou redefinis le libelle de l'objet Generation selectionne
		 * @param lib Chaine
		 */
		public void SetLibGeneration(String lib)
		{
			this.libelle = lib;
		}

		/// <summary>
		///  Renvoie un objet Annnee representant l'annee de la Generation de l'objet Generation selectionne
		/// </summary>
		/// <returns>Annee</returns>
		public Annee GetAnneeGeneration()
		{
			return this.annee;
		}

		/// <summary>
		/// Definit ou redefinit un objet Annnee representant l'annee de la Generation de l'objet Generation selectionne
		/// </summary>
		/// <param name="lAnnee">Annee</param>
		public void SetAnneeGeneration(Annee lAnnee)
		{
			this.annee = lAnnee;
		}
	}
}
