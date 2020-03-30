using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexClasses
{
	public class Evolution
    {
		// Declaration Attributs
		private int idEvol;
		private String libelleEvolution;
		private Pokemon pkmSousEvolution;
		private Pokemon pkmSurEvolution;
		private TypeEvolution typeEvolution;

		/// <summary>
		/// Constructeur Plein de la classe Evolution
		/// </summary>
		/// <param name="libelle">String</param>
		/// <param name="sousEvolution">Pokemon</param>
		/// <param name="surEvolution">Pokemon</param>
		/// <param name="type">TypeEvolution</param>
		public Evolution(int id, String libelle, Pokemon sousEvolution,
				Pokemon surEvolution, TypeEvolution type)
		{
			this.idEvol = id;
			this.libelleEvolution = libelle;
			this.pkmSousEvolution = sousEvolution;
			this.pkmSurEvolution = surEvolution;
			this.typeEvolution = type;
		}

		/// <summary>
		/// Constructeur vide de la classe Evolution
		/// </summary>
		public Evolution()
		{
			this.idEvol = 0;
			this.libelleEvolution = null;
			this.pkmSousEvolution = null;
			this.pkmSurEvolution = null;
			this.typeEvolution = null;
		}

		/// <summary>
		/// Permet de retourner l'Id de l'Ecolution
		/// </summary>
		/// <returns>int</returns>
		public int GetIdEvolution()
		{
			return this.idEvol;
		}

		/// <summary>
		/// permet de modifier l'Id de l'Evolution
		/// </summary>
		/// <param name="id">int</param>
		public void SetIdEvolution(int id)
		{
			this.idEvol = id;
		}


		public String GetLibelleEvolution()
		{
			return this.libelleEvolution;
		}

		
		public void SetLibelleEvolution(String lib)
		{
			this.libelleEvolution = lib;
		}


		public TypeEvolution GetTypeEvolution()
		{
			return this.typeEvolution;
		}


		public void SetTypeEvolution(TypeEvolution type)
		{
			this.typeEvolution = type;
		}


		public Pokemon GetPkmSousEvolution()
		{
			return this.pkmSousEvolution;
		}


		public void SetPkmSousEvolution(Pokemon sousEvolution)
		{
			this.pkmSousEvolution = sousEvolution;
		}


		public Pokemon GetPkmSurEvolution()
		{
			return this.pkmSurEvolution;
		}


		public void SetPkmSurEvolution(Pokemon surEvolution)
		{
			this.pkmSurEvolution = surEvolution;
		}
	}
}
