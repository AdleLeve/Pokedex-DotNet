using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bulbi_dex.Controller
{
    class DBMySqlOutils
    {
        #region objets globaux
        #region pour la connexion
        public static MySqlConnection gObjetConnection = new MySqlConnection();
        public static MySqlCommand command;
        #endregion
        #endregion

        #region Mes procédures

        #region Outils Connections
        /// <summary>
        /// Permet d'obtenir un Objet MySqlConnection representant la connexion a la base de donnee
        /// </summary>
        /// <returns>MySqlConnection</returns>
        public static MySqlConnection GetDBConnection()
        {
            // Creation de l'objet de type MySqlConnection a partir de la chaine de Connection
            MySqlConnection conn = new MySqlConnection(DBConst.connString);

            // retour de l'objet de type MySqlConnection
            return conn;
        }

        /// <summary>
        /// Permet d'ouvrir une connection vers la base de donnees 
        /// </summary>
        public static void MaConnexion()
        {
            // recuperation des parametres de connection a la BDD dans l'objet gObjetConnection de type MySqlConnection
            gObjetConnection = GetDBConnection();

            try
            {
                // Tentative de connexion a la base de donnee
                gObjetConnection.Open();

//                Console.WriteLine("Ouverture Base de donnee");
 //               MessageBox.Show("Ouverture Base de donnee");
            } catch (Exception e)
            {
                // Affichage du message d'erreur
//                Console.WriteLine("Erreur : " + e.Message);
                MessageBox.Show("Erreur : " + e.Message);
            }

//            Console.ReadKey();
        }

        /// <summary>
        /// Permet de fermer la connection vers la base de donnees
        /// </summary>
        public static void MaDeconnexion()
        {
            try
            {
                // Tentative de Fermeture a la base de donnee
                gObjetConnection.Close();
            } catch (Exception e)
            {
                // Affichage du message d'erreur
                MessageBox.Show("Erreur : " + e.Message);
            }
            
//            Console.ReadKey();
        }
        #endregion

        #region Outils executions de requetes
        /// <summary>
        /// Permet de lancer une requete de modification, d'insertion passee en parametre dans la base de donner et retourner un 
        /// entier specifiant si l'operation a marche ou non
        /// </summary>
        /// <param name="StrRequete">String</param>
        /// <returns>int</returns>
        public static int ExecuteNonQuery(String StrRequete)
        {
            MaConnexion();

            int entier;
            try
            {
                command = new MySqlCommand(StrRequete, gObjetConnection);
                entier = command.ExecuteNonQuery();
            }
            catch (Exception probleme)
            {
                MessageBox.Show("Impossible de se connecter au serveur de base de données." + probleme.Message);
                entier = 0;
            }
            
            MaDeconnexion();
            
            return entier;
        }

        /// <summary>
        /// Permet de lancer une requete de selection passee en parametre dans la base de donner et retourner un 
        /// Objet contenant le resultat de l'operation
        /// </summary>
        /// <param name="StrRequete">String</param>
        /// <returns>Object</returns>
        public static Object ExecuteScalar(String StrRequete)
        {
            // Ouvre la connection a la BDD
            MaConnexion();

            Object obj;
            try
            {
                command = new MySqlCommand(StrRequete, gObjetConnection);
                obj = command.ExecuteScalar();
            }
            catch (Exception probleme)
            {
                MessageBox.Show("Impossible de se connecter au serveur de base de données." + probleme.Message);
//                Console.WriteLine("Impossible de se connecter au serveur de base de données." + probleme.Message);
                obj = null;
            }
            // Ferme la connection a la BDD
            MaDeconnexion();

            return obj;
        }

        /// <summary>
        /// Permet de lancer une requete de selection passee en parametre dans la base de donner et retourner un 
        /// Objet MySqlDataReader contenant les resultats multiples de l'operation
        /// </summary>
        /// <param name="StrRequete">String</param>
        /// <returns>MySqlDataReader</returns>
        public static MySqlDataReader ExecuteReader(String StrRequete)
        {
            // Ouvre la connection a la BDD
            MaConnexion();
            
            MySqlDataReader Sdr;
            
            try
            {
                command = new MySqlCommand(StrRequete, gObjetConnection);
                Sdr = command.ExecuteReader();
            }
            catch (Exception probleme)
            {
                MessageBox.Show("Impossible de se connecter au serveur de base de données." + probleme.Message);
                Sdr = null;
            }
            // On ne ferme pas la connection a la BDD afin de pouvoir traiter les donnees recuperer par d'autres moyens par la suite
            //MaDeconnexion();

            return Sdr;
        }
        #endregion

        #endregion
    }
}
