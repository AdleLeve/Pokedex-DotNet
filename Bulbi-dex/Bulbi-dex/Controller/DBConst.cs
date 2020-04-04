using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PokedexClasses;

namespace Bulbi_dex.Controller
{
    public class DBConst
    {
        // Constantes de connexions
        private const string host = "127.0.0.1";
        private const int port = 3308;
        private const string bdd = "pokedex";
        private const string username = "root";
        private const string password = "";

        // Chaine de Connexion
        public static String connString = "Server=" + host + ";Database=" + bdd + ";port="
            + port + ";User Id=" + username + ";password=" + password;


        public static List<UserControl> lstUSC = new List<UserControl>();
        public static List<Button> lstBtn = new List<Button>();

        public static List<Annee> lstSelectAnnee = new List<Annee>();
        public static List<Generation> lstSelectGen = new List<Generation>();
        public static List<Types> lstSelectType = new List<Types>();
        public static List<Types> lstSelectTypeLBX = new List<Types>();
        public static List<Images> lstSelectImg = new List<Images>();
        public static List<Pokemon> lstSelectPkm = new List<Pokemon>();
        public static List<AvoirType> lstSelectAvoirType = new List<AvoirType>();
        public static List<TypeEvolution> lstSelectTypeEvo = new List<TypeEvolution>();
        public static List<Evolution> lstSelectEvo = new List<Evolution>();


        public static String[] tabExtImg = { ".png", ".jgp", ".jpeg", ".gif" };
    }
}
