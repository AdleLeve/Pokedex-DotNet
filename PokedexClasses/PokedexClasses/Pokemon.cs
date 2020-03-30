using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexClasses
{
    public class Pokemon
    {
		// Declaration Attributs
		private String num_pokedex_mondial;
		private String nom_pokemon;
		private String description_pokedex_pokemon;
		private bool particularite_legendaire_pkm;
		private Images image;
		private Generation generation;

		/// <summary>
		/// Constructeur Plein de la classe Pokemon
		/// </summary>
		/// <param name="num">String</param>
		/// <param name="nom">String</param>
		/// <param name="desc">String</param>
		/// <param name="plpkm">Boolean</param>
		/// <param name="img">Images</param>
		/// <param name="gen">Generation</param>
		public Pokemon(String num, String nom, String desc,
				bool plpkm, Images img, Generation gen)
		{
			this.num_pokedex_mondial = num;
			this.nom_pokemon = nom;
			this.description_pokedex_pokemon = desc;
			this.particularite_legendaire_pkm = plpkm;
			this.image = img;
			this.generation = gen;
		}

		/// <summary>
		/// Constructeur Vide de la classe Pokemon
		/// </summary>
		public Pokemon()
		{
			this.num_pokedex_mondial = null;
			this.nom_pokemon = null;
			this.description_pokedex_pokemon = null;
			this.particularite_legendaire_pkm = false; 
			this.image = null;
			this.generation = null;
		}

		/// <summary>
		/// Renvoie le numero dans le pokedex mondial de l'objet Pokemon cible
		/// </summary>
		/// <returns></returns>
		public String GetNumPokedexMondialPkm()
		{
			return this.num_pokedex_mondial;
		}

		/// <summary>
		/// Modifie le numero dans le pokedex mondial de l'objet Pokemon cible
		/// </summary>
		/// <param name="num">String</param>
		public void SetNumPokedexMondialPkm(String num)
		{
			this.num_pokedex_mondial = num;
		}

		/// <summary>
		/// Renvoie le nom de l'objet Pokemon cible
		/// </summary>
		/// <returns>String</returns>
		public String GetNomPokemon()
		{
			return this.nom_pokemon;
		}

		/// <summary>
		/// Modifie le nom de l'objet Pokemon cible
		/// </summary>
		/// <param name="nom">String</param>
		public void SetNomPokemon(String nom)
		{
			this.nom_pokemon = nom;
		}

		/// <summary>
		/// Renvoie la Chaine representant la description de l'objet Pokemon cible
		/// </summary>
		/// <returns>String</returns>
		public String GetDescPokemon()
		{
			return this.description_pokedex_pokemon;
		}

		/// <summary>
		/// Modifie la Chaine representant la description de l'objet Pokemon cible
		/// </summary>
		/// <param name="desc">String</param>
		public void SetDescPokemon(String desc)
		{
			this.description_pokedex_pokemon = desc;
		}

		/// <summary>
		/// Renvoie le Boolean representant si l'objet Pokemon cible est vrai => "Legendaire" ou faux => "Normal"
		/// </summary>
		/// <returns>Boolean</returns>
		public Boolean GetParticulariteLegendairePokemon()
		{
			return this.particularite_legendaire_pkm;
		}

		/// <summary>
		/// Modifie le Boolean representant si l'objet Pokemon cible est vrai => "Legendaire" ou faux => "Normal"
		/// </summary>
		/// <param name="plpkm">Boolean</param>
		public void SetParticulariteLegendairePokemon(Boolean plpkm)
		{
			this.particularite_legendaire_pkm = plpkm;
		}

		/// <summary>
		/// Renvoie l'Objet Images assigne a l'objet Pokemon cible
		/// </summary>
		/// <returns>Images</returns>
		public Images GetImagesPokemon()
		{
			return this.image;
		}

		/// <summary>
		/// Modifie l'Objet Images assigne a l'objet Pokemon cible
		/// </summary>
		/// <param name="img">Images</param>
		public void SetImagesPokemon(Images img)
		{
			this.image = img;
		}

		/// <summary>
		/// Renvoie l'Objet Generation assigne a l'objet Pokemon cible
		/// </summary>
		/// <returns>Generation</returns>
		public Generation GetGenerationPkm()
		{
			return this.generation;
		}

		/// <summary>
		/// Modifie l'Objet Generation assigne a l'objet Pokemon cible
		/// </summary>
		/// <param name="generation">Generation</param>
		public void SetGenerationPkm(Generation generation)
		{
			this.generation = generation;
		}
	}
}
