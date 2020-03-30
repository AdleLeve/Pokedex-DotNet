using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexClasses
{
	public class TypeEvolution
    {
		// Declaration Attributs
		private int idTypeEvol;
		private String libelleTypeEvol;

		/// <summary>
		/// Constructeur Plein de la classe TypeEvolution
		/// </summary>
		/// <param name="id">int</param>
		/// <param name="lib">String</param>
		public TypeEvolution(int id, String lib)
		{
			this.idTypeEvol = id;
			this.libelleTypeEvol = lib;
		}

		/// <summary>
		/// Constructeur Vide de la classe TypeEvolution
		/// </summary>
		public TypeEvolution()
		{
			this.idTypeEvol = 0;
			this.libelleTypeEvol = null;
		}

		/// <summary>
		/// Renvois un Entier representant l'id du Types d'Evolution selectionne
		/// </summary>
		/// <returns>int</returns>
		public int GetIdTypeEvol()
		{
			return this.idTypeEvol;
		}

		/// <summary>
		/// Modifie l'Entier idTypeEvol representant l'id du Types d'Evolution selectionne
		/// </summary>
		/// <param name="idTypeEvol">int</param>
		public void SetIdTypeEvol(int idTypeEvol)
		{
			this.idTypeEvol = idTypeEvol;
		}

		/// <summary>
		/// Renvois la Chaine du libelle du Types d'Evolution selectionnee
		/// </summary>
		/// <returns>String</returns>
		public String GetLibelleTypeEvol()
		{
			return this.libelleTypeEvol;
		}

		/// <summary>
		/// Modifie ou Insert la Chaine du libelle du Types d'Evolution selectionnee
		/// </summary>
		/// <param name="libelleTypeEvol">String</param>
		public void SetLibelleTypeEvol(String libelleTypeEvol)
		{
			this.libelleTypeEvol = libelleTypeEvol;
		}
	}
}
