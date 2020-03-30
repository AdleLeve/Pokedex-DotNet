using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexClasses
{
	public class AvoirType
    {
		// Declaration Attributs
		private Pokemon pokemon;
		private Types type;

		/// <summary>
		/// Constructeur Plein de la classe AvoirType
		/// </summary>
		/// <param name="pkm"></param>
		/// <param name="t"></param>
		public AvoirType(Pokemon pkm, Types t)
		{
			this.pokemon = pkm;
			this.type = t;
		}

		/// <summary>
		/// Constructeur Vide de la classe AvoirType
		/// </summary>
		public AvoirType()
		{
			this.pokemon = null;
			this.type = null;
		}

		/// <summary>
		/// Renvois l'Objet Pokemon correspondant à la correspondance d'AvoirType cible
		/// </summary>
		/// <returns>Pokemon</returns>
		public Pokemon GetPkmAvoirType()
		{
			return this.pokemon;
		}

		/// <summary>
		/// Insert ou Modifie l'Objet Pokemon correspondant à la correspondance d'AvoirType cible
		/// </summary>
		/// <param name="pkm">Pokemon</param>
		public void SetPkmAvoirType(Pokemon pkm)
		{
			this.pokemon = pkm;
		}

		/// <summary>
		/// Renvois l'Objet Types correspondant à la correspondance d'AvoirType cible
		/// </summary>
		/// <returns>Types</returns>
		public Types GetTypeAvoirType()
		{
			return this.type;
		}

		/// <summary>
		/// Insert ou Modifie l'Objet Types correspondant à la correspondance d'AvoirType cible
		/// </summary>
		/// <param name="t">Types</param>
		public void SetTypeAvoirType(Types t)
		{
			this.type = t;
		}
	}
}
