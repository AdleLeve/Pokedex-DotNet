using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexClasses
{
    public class Types
	{
		// Declaration atributs
		private int id;
		private String libelle;
		private Generation generation;

		/// <summary>
		/// Constructeur Plein de la classe Types
		/// </summary>
		/// <param name="id">int</param>
		/// <param name="lib">String</param>
		/// <param name="lGen">Generation</param>
		public Types(int id, String lib, Generation lGen)
		{
			this.id = id;
			this.libelle = lib;
			this.generation = lGen;
		}

		/// <summary>
		/// Constructeur Vide de la classe Types
		/// </summary>
		public Types()
		{
			this.id = 0;
			this.libelle = null;
			this.generation = null;
		}

		/// <summary>
		/// Retourne l'Entier representant l'id de la classe Types
		/// </summary>
		/// <returns>int</returns>
		public int GetIdType()
		{
			return this.id;
		}

		/// <summary>
		/// Modifie l'Entier representant l'id de la classe Types
		/// </summary>
		/// <param name="id">int</param>
		public void SetIdType(int id)
		{
			this.id = id;
		}

		/// <summary>
		/// Permet de rentrer et ou modifier une chaine contenant le libelle du Types selectionne
		/// </summary>
		/// <param name="lib">int</param>
		public void SetLibType(String lib)
		{
			this.libelle = lib;
		}

		/// <summary>
		/// Renvoie une chaine contenant le libelle du Types selectionne
		/// </summary>
		/// <returns>String</returns>
		public String GetLibType()
		{
			return this.libelle;
		}

		/// <summary>
		/// Permet de rentrer et ou modifier l'objet Generation representant la Generation d'apparition du Types selectionne
		/// </summary>
		/// <param name="gen">Generation</param>
		public void SetGenType(Generation gen)
		{
			this.generation = gen;
		}

		/// <summary>
		/// Renvoie l'objet Generation representant la Generation d'apparition du Types selectionne
		/// </summary>
		/// <returns>Generation</returns>
		public Generation GetGenType()
		{
			return this.generation;
		}
	}
}
