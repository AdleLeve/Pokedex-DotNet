using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexClasses
{
    public class Images
    {
		// Declarations Attributs
		private int id;
		private String url;
		private String extension;

		/// <summary>
		/// Constructeur Complet de la classe Images
		/// </summary>
		/// <param name="lId">int</param>
		/// <param name="lUrl">String</param>
		/// <param name="ext">String</param>
		public Images(int lId, String lUrl, String ext)
		{
			this.id = lId;
			this.url = lUrl;
			this.extension = ext;
		}

		/// <summary>
		/// Constructeur Vide de la classe Images
		/// </summary>
		public Images()
		{
			this.id = 0; // On met 0 car un objet s'il n'est pas complet ne sera pas enregistre en memoire 
			this.url = null;
			this.extension = null;
		}

		/// <summary>
		/// Retourne l'id de la classe Images
		/// </summary>
		/// <returns>int</returns>
		public int GetId()
		{
			return this.id;
		}

		/// <summary>
		/// Modifie ou Insert l'Entier id de l'Image
		/// </summary>
		/// <param name="lId">int</param>
		public void SetId(int lId)
		{
			this.id = lId;
		}

		/// <summary>
		/// Retourne l'extension de la classe Images
		/// </summary>
		/// <returns>String</returns>
		public String GetExtension()
		{
			return this.extension;
		}

		/// <summary>
		/// Modifie ou Insert la chaine extension de l'Image
		/// </summary>
		/// <param name="ext">String</param>
		public void SetExtension(String ext)
		{
			this.extension = ext;
		}

		/// <summary>
		/// Retourne l'Url de la classe Images
		/// </summary>
		/// <returns>String</returns>
		public String GetUrl()
		{
			return this.url;
		}

		/// <summary>
		/// Modifie ou Insert la chaine url de l'Image
		/// </summary>
		/// <param name="lUrl">String</param>
		public void SetUrl(String lUrl)
		{
			this.url = lUrl;
		}

		/// <summary>
		/// Retourne la chaine representant l'Url Complete selectionnee de la classe Image
		/// </summary>
		/// <returns>String</returns>
		public String GetUrlComplete()
		{
			return this.url + this.extension;
		}
	}
}
