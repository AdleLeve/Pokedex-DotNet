using System;
using System.Drawing;
using System.Data;
using System.Collections.Generic;
using PokedexClasses;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Linq;

namespace Bulbi_dex.Controller
{
    public class OutilsPkdx
    {
        #region Outils crees pour le bon fonctionnement du reste
        /// <summary>
        /// Methode testant si une Chaine passee en parametre est un Entier renvoi 
        /// un Booleen notifiant si oui ou non la Chaine est un Entier
        /// </summary>
        /// <param name="machaine">String</param>
        /// <returns>Boolean</returns>
        public static Boolean IsInteger(String machaine)
        {
            Boolean isInteger;

            try
            {
                int i = int.Parse(machaine);
                Console.WriteLine("La Chaine : " + i + " est un entier");
                isInteger = true;
            }
            catch
            {
                isInteger = false;
                Console.WriteLine("La Chaine : " + machaine + " n'est pas un entier");
            }

            return isInteger;
        }

        /// <summary>
        /// Methode permettant de renvoyer la valeur Booleenne representant l'Entier (Bit) passer en parametre
        /// </summary>
        /// <param name="bit">int</param>
        /// <returns>Boolean</returns>
        public static Boolean PassBitABool(int bit)
        {
            if (bit == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Methode permettant de renvoyer la valeur Entiere (Bit) representant le Booleen passer en parametre
        /// </summary>
        /// <param name="bl">Boolean</param>
        /// <returns>int</returns>
        public static int PassBoolABit(Boolean bl)
        {
            if (bl == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        
        /// <summary>
        /// Permet de passer la visibilite de tout les UserControl de la liste passee en parametre a false
        /// </summary>
        /// <param name="LstUsc">List UserControl</param>
        public static void VisibiliteUSC(List<UserControl> LstUsc)
        {
            foreach (UserControl usc in LstUsc)
            {
                usc.Hide();
            }
        }

        /// <summary>
        /// Permet de passer la visibilite de tout les UserControl de la liste passee en parametre a false mais de passer celle de UserControl passe en parametre a true
        /// </summary>
        /// <param name="LstUsc">List UserControl</param>
        /// <param name="uscTrue">UserControl</param>
        public static void VisibiliteUSC(List<UserControl> LstUsc, UserControl uscTrue)
        {
            foreach (UserControl usc in LstUsc)
            {
                usc.Hide();
            }

            uscTrue.Show();
        }

        /// <summary>
        /// Permet de mettre tout les boutons de la List Button passee en parametre a la meme couleur
        /// </summary>
        /// <param name="LstBtn">List Button</param>
        public static void ColorBtn(List<Button> LstBtn)
        {
            foreach (Button btn in LstBtn)
            {
                btn.BackColor = Color.ForestGreen;
            }
        }

        /// <summary>
        /// Permet de mettre tout les boutons de la List Button passee en parametre a la meme couleur et mettre dans une autre couleur le Button passe en parametre
        /// </summary>
        /// <param name="LstBtn">List Button</param>
        /// <param name="button">Button</param>
        public static void ColorBtn(List<Button> LstBtn, Button button)
        {
            foreach (Button btn in LstBtn)
            {
                btn.BackColor = Color.ForestGreen;
            }

            button.BackColor = Color.FromArgb(255, 192, 192);
        }

        /// <summary>
        /// Permet de retourner la valeur Booleenne d'un RadioButtion (Selement 2 RadioButton) a partir de celui qui represente la valeur true 
        /// </summary>
        /// <param name="rdbTrue">RadioButton</param>
        /// <returns>bool</returns>
        public static bool GetValRadButton(RadioButton rdbTrue)
        {
            if (rdbTrue.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*       public static String FormeDescription (String desc)
               {
                   // Declarations et instanciation(s) des Objets necessaires
                   String[] tabDesc;
                   String descFormat = "";
                   String caractAjout = "\'";


                   tabDesc = desc.Split('\'');

                   for (int i = 0; i < tabDesc.Length; i++)
                   {
                       if (i == 0)
                       {
                           descFormat = tabDesc[i];
                       }
                       else
                       {
                           descFormat += caractAjout + tabDesc[i];
                       }
                   }

                   MessageBox.Show(descFormat, "Test mise en forme Description");
                   return descFormat;
               } */

        #region verifications
        /// <summary>
        /// Permet de verifier le format des informations rentrees par l'utilisateur afin de creer un objet Annee
        /// </summary>
        /// <param name="annee">String</param>
        /// <returns>bool</returns>
        public static bool VerifFormatAnnee(String annee)
        {
            try
            {
                Int32 an = Int32.Parse(annee);
                
                if (an >= 1980)
                {
                    foreach (Annee a in DBConst.lstSelectAnnee)
                    {
                        if (a.GetNumAnnee() == annee)
                        {
                            return false;
                        }
                    } 
                    return true;
                }
                else
                {
                    return false;
                }

            } catch
            {
                return false;
            }
        }

        /// <summary>
        /// Permet de verifier le format des informations rentrees par l'utilisateur afin de creer un objet Generation
        /// </summary>
        /// <param name="gen">String</param>
        /// <returns>bool</returns>
        public static bool VerifFormatGen(String gen)
        {
            try
            {
                Int16 ge = Int16.Parse(gen);

                if (ge >= 1 && ge <= 99)
                {
                    foreach (Generation g in DBConst.lstSelectGen)
                    {
                        if (g.GetNumGeneration() == ge)
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Permet de verifier le format des informations rentrees par l'utilisateur afin de creer un objet Types
        /// </summary>
        /// <param name="libType">String</param>
        /// <returns>bool</returns>
        public static bool VerifFormatTypes(String libType)
        {
            if (libType.Length <= 15 && libType.Length >= 3)
            {
                foreach (Types t in DBConst.lstSelectType)
                {
                    if (t.GetLibType().Equals(libType))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Permet de verifier le format des informations rentrees par l'utilisateur afin de creer un objet Images
        /// </summary>
        /// <param name="url">String</param>
        /// <param name="ext">String</param>
        /// <returns>bool</returns>
        public static bool VerifFormatImg(String url, String ext)
        {
            if (url.Length <= 50 && url.Length >= 5)
            {
                foreach (Images i in DBConst.lstSelectImg)
                {
                    if (i.GetUrlComplete().Equals(url + ext))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Permet de verifier le format des informations rentrees par l'utilisateur afin de creer un objet Pokemon
        /// </summary>
        /// <param name="num">String</param>
        /// <param name="nom">String</param>
        /// <param name="desc">String</param>
        /// <returns>bool</returns>
        public static bool VerifFormatPkm(String num, String nom, String desc)
        {
            if (IsInteger(num) == true && num.Length == 3 && nom.Length >= 3 
                && nom.Length <=  20 && desc.Length <= 400)
            {
                foreach (Pokemon p in DBConst.lstSelectPkm)
                {
                    if (p.GetNumPokedexMondialPkm().Equals(num))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Renvois si le format du libelle est correcte ou non, a ppartir du libelle et de la liste passee en parametre
        /// </summary>
        /// <param name="libelle">String</param>
        /// <param name="lst">List TypeEvolution</param>
        /// <returns>bool</returns>
        public static bool VerifFormatTypeEvol(String libelle, List<TypeEvolution> lst)
        {
            if (IsInteger(libelle) == false && libelle.Length >= 3 && libelle.Length <= 30)
            {
                foreach (TypeEvolution te in lst)
                {
                    if (te.GetLibelleTypeEvol().Equals(libelle))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Renvois si le format du libelle est correcte ou non, a partir des Pokemon et de la liste passee en parametre
        /// </summary>
        /// <param name="sousEvo">Pokemon</param>
        /// <param name="surEvo">Pokemon</param>
        /// <param name="lst">List Evolution</param>
        /// <returns>List Evolution</returns>
        public static bool VerifFormatEvol(Pokemon sousEvo, Pokemon surEvo, List<Evolution> lst)
        {
            if (sousEvo.Equals(surEvo) == false)
            {
                string lib = sousEvo.GetNumPokedexMondialPkm() + "/" + surEvo.GetNumPokedexMondialPkm();
                
                foreach (Evolution e in lst)
                {
                    if (e.GetLibelleEvolution().Equals(lib))
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                MessageBox.Show("Le pokemon évolué ne doit pas être le même que celui évoluant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /*        public static bool VerifFormatAvoirType(Pokemon pkm, Types type)
                {
                    foreach (AvoirType at in DBConst.lstSelectAvoirType)
                    {
                        if (at.GetPkmAvoirType().GetNumPokedexMondialPkm().Equals(pkm.GetNumPokedexMondialPkm()) == true && at.GetTypeAvoirType().GetIdType().Equals(type.GetIdType()) == true
                            && VerifInsertionSup2AvoirType(pkm.GetNumPokedexMondialPkm()) == true)
                        {
                            return false;
                        }
                    }
                    return true;
                } */

        #endregion
        #endregion

        #region Methodes et Procedures communiquant avec les tables de la BDD
        #region Annee
        /// <summary>
        /// Permet de recuperer les donnees de la table Annees de la BDD
        /// </summary>
        /// <returns>List<Annee></returns>
        public static List<Annee> RecupAnnee()
        {
            List<Annee> lstAnnee = new List<Annee>();

            String requete = "CALL PROC_Select_Annee_ordreA()";

            //Connexion a la BDD
//           DBMySqlOutils.MaConnexion();
            try
            {
                MySqlDataReader sdrListe = DBMySqlOutils.ExecuteReader(requete);
                
                while (sdrListe.Read())
                {
                    Annee annee = new Annee(sdrListe["num"].ToString());
                    lstAnnee.Add(annee);
                }
                sdrListe.Close();

                // Fermeture de la BDD
                DBMySqlOutils.MaDeconnexion();

//                MessageBox.Show("recuperation Annee reussie", "informations", MessageBoxButtons.OK);
            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + probleme.Message);
//                Console.WriteLine("L'erreur suivante a été rencontré : " + probleme.Message);
            }

            return lstAnnee;
        }

        /// <summary>
        /// Permet de creer un Objet Annee a l'aide des parametres passes, de l'ajouter a la liste de type Annee passee en parametre et de l'ajouter a la BDD
        /// </summary>
        /// <param name="numAnnee">String</param>
        /// <param name="lst">List Annee</param>
        /// <returns>Annee</returns>
        public static Annee CreatAnnee (String numAnnee, List<Annee> lst)
        {
            Annee annee = new Annee();
            int insertion; // variable insertion

            try
            {
                // Instanciation de la variable annee
                annee = new Annee(numAnnee);

                Console.WriteLine("test passage 1" + numAnnee.Length);
                // ajout de cette variable a la liste
                lst.Add(annee);

                string requete = "CALL PROC_Insert_annee('" + numAnnee + "')";
                
                // insertion BDD
                insertion = DBMySqlOutils.ExecuteNonQuery(requete);
                
                if (insertion == 1)
                {
                    Console.WriteLine("Insertion de l'objet Anneee " + numAnnee + " réussie");
                } else
                {
                    Console.WriteLine("L'insertion de l'objet Anneee " + numAnnee + " a échouée");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + probleme.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
//              Console.WriteLine("L'erreur suivante a été rencontré : " + probleme.Message);
            }

            return annee;
        }

        /// <summary>
        /// Permet de remplir la ComboBox passee en parametre a partir du numero de la table Annee dans la BDD
        /// </summary>
        /// <param name="cbx">ComboBox</param>
        public static void RemplisCbxAnnee(ComboBox cbx)
        {
            #region remplissage cbx
            string strReq = "CALL PROC_Select_Annee_ordreA ()";
            try
            {
                MySqlDataReader mdrListe = DBMySqlOutils.ExecuteReader(strReq);
                DataTable dt = new DataTable();
                dt.Load(mdrListe);
                cbx.DataSource = dt;
                cbx.DisplayMember = "num";
                cbx.ValueMember = "num";
                mdrListe.Close();
                cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            } catch (MySqlException e)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + e.Message);
            }

            // Deconnection a la BD
            DBMySqlOutils.MaDeconnexion();
            #endregion
        }

        /// <summary>
        /// Permet de recuperer les donnees de la table Annee de la BDD
        /// </summary>
        /// <param name="numAnnee">string</param>
        /// <param name="lst">List Annee</param>
        /// <returns>Annee</returns>
        public static Annee ConvertAnnee(string numAnnee, List<Annee> lst)
        {
            foreach (Annee a in lst)
            {
                if (a.GetNumAnnee().Equals(numAnnee))
                {
                    return a;
                }
            }
            Annee an = new Annee();

            return an;
        }
        #endregion

        #region Generation
        /// <summary>
        /// Permet de recuperer les donnees de la table Generation de la BDD
        /// </summary>
        /// <returns>List Generation</returns>
        public static List<Generation> RecupGeneration()
        {
            List<Generation> lstGen = new List<Generation>();

            String requete = "CALL PROC_Select_Generation_ordreA()";
            
            try
            {
                MySqlDataReader sdrListe = DBMySqlOutils.ExecuteReader(requete);
                
                Annee an = new Annee();

                while (sdrListe.Read())
                {
                    an = ConvertAnnee(sdrListe["annee"].ToString(), DBConst.lstSelectAnnee);

                    Generation gen = new Generation(int.Parse(sdrListe["num"].ToString()), sdrListe["lib"].ToString(), an);

                    lstGen.Add(gen);
                }
                sdrListe.Close();

                // Fermeture de la BDD
                DBMySqlOutils.MaDeconnexion();

//                MessageBox.Show("recuperation Generation reussie", "informations", MessageBoxButtons.OK);
            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + probleme.Message);
                //                Console.WriteLine("L'erreur suivante a été rencontré : " + probleme.Message);
            }

            return lstGen;
        }

        /// <summary>
        /// Permet de creer un Objet Generation a l'aide des parametres passes, de l'ajouter a la liste de type Annee passee en parametre et de l'ajouter a la BDD
        /// </summary>
        /// <param name="numGen">int</param>
        /// <param name="lst">List Generation</param>
        /// <returns>Generation</returns>
        public static Generation CreatGen(int numGen, Annee annee, List<Generation> lst)
        {
            Generation generation = new Generation();
            int insertion; // variable insertion

            try
            {
                // declaration et instanciation d'une variable chaine contenant le libelle de Generation
                String libGen = numGen + "G";

                // Instanciation de la variable annee
                generation = new Generation(numGen, libGen, annee);
                
                // ajout de cette variable a la liste
                lst.Add(generation);

                string requete = "CALL PROC_Insert_Generation (" + numGen + ", '" + libGen + "', '" + annee.GetNumAnnee() + "')";

                // insertion BDD
                insertion = DBMySqlOutils.ExecuteNonQuery(requete);

                if (insertion == 1)
                {
                    Console.WriteLine("Insertion de l'objet Geneation " + numGen + " réussie");
                }
                else
                {
                    Console.WriteLine("L'insertion de l'objet Generation " + numGen + " a échouée");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + probleme.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return generation;
        }

        /// <summary>
        /// Permet de remplir la ComboBox passee en parametre, a partir de la BDD avec l'Url complete des Images comme valeur visible et recuperable
        /// </summary>
        /// <param name="cbx"></param>
        public static void RemplisCbxGen(ComboBox cbx)
        {
            #region remplissage cbx
            string strReq = "CALL PROC_Select_Generation_ordreA ()";
            try
            {
                MySqlDataReader mdrListe = DBMySqlOutils.ExecuteReader(strReq);
                DataTable dt = new DataTable();
                dt.Load(mdrListe);
                cbx.DataSource = dt;
                cbx.DisplayMember = "lib";
                cbx.ValueMember = "lib";
                mdrListe.Close();
                cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + e.Message + " RemplisCbxGen");
            }

            // Deconnection a la BD
            DBMySqlOutils.MaDeconnexion();
            #endregion
        }

        /// <summary>
        ///  Permet de recuperer l'Objet Generation correspondant a l'entier passe en parametre a partir de la liste de la classe Geneartion passee en parametre
        /// </summary>
        /// <param name="numGen">int</param>
        /// <param name="lst">List Generation</param>
        /// <returns></returns>
        public static Generation ConvertGen(int numGen, List<Generation> lst)
        {
            try
            {
                foreach (Generation g in lst)
                {
                    if (numGen == g.GetNumGeneration())
                    {
                        return g;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception : " + e.Message, "Error");
            }

            Generation gen = new Generation();

            return gen;
        }

        /// <summary>
        /// Permet de recuperer l'Objet Generation correspondant a la Chaine passee en parametre a partir de la liste de la classe Geneartion passee en parametre
        /// </summary>
        /// <param name="libGen">String</param>
        /// <param name="lst">List Generation</param>
        /// <returns></returns>
        public static Generation ConvertGen(string libGen, List<Generation> lst)
        {
            Generation gen = new Generation();

            try
            {
                foreach (Generation g in lst)
                {
                    if (libGen == g.GetLibGeneration())
                    {
                        return g;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception : " + e.Message, "Error");
            }

            return gen;
        }
        #endregion

        #region Types
        /// <summary>
        /// Permet de recuprer le Types a partir de son numero
        /// </summary>
        /// <param name="idType">int</param>
        /// <param name="libTypes">String</param>
        /// <returns>Types</returns>
        public static Types ConvertTypes(int idType, String libTypes, List<Types> lst)
        {
            Types tp = new Types();

            if (idType > 0)
            {
                foreach (Types t in lst)
                {
                    if (t.GetIdType() == idType)
                    {
                        MessageBox.Show("Types TROUVE : " + t.GetLibType());
                        return t;
                    }
                }
            } else
            {
                if (libTypes != null)
                {
                    foreach (Types t in lst)
                    {
                        if (t.GetLibType().Equals(libTypes) == true)
                        {
                            return t;
                        } 
                    }
                } else
                {

                }
            }

            return tp;
        }

        /// <summary>
        /// Permet de recuperer les donnees de la table Generation de la BDD
        /// </summary>
        /// <returns>List Generation</returns>
        public static List<Types> RecupTypes()
        {
            List<Types> lstType = new List<Types>();

            String requete = "CALL PROC_Select_Type_ordreACode()";

            try
            {
                MySqlDataReader sdrListe = DBMySqlOutils.ExecuteReader(requete);

                Generation gen = new Generation();

                while (sdrListe.Read())
                {
                    gen = ConvertGen(sdrListe["gen"].ToString(), DBConst.lstSelectGen);

                    Types type = new Types(int.Parse(sdrListe["code"].ToString()), sdrListe["lib"].ToString(), gen);

                    lstType.Add(type);
                }
                sdrListe.Close();

                // Fermeture de la BDD
                DBMySqlOutils.MaDeconnexion();

//                MessageBox.Show("recuperation Types reussie", "informations", MessageBoxButtons.OK);
            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + probleme.Message);
                //                Console.WriteLine("L'erreur suivante a été rencontré : " + probleme.Message);
            }

            return lstType;
        }

        /// <summary>
        /// Permet de creer un Objet Type a l'aide des parametres passes, de l'ajouter a la liste de type Annee passee en parametre et de l'ajouter a la BDD
        /// </summary>
        /// <param name="libType">String</param>
        /// <param name="lst">List Generation</param>
        /// <returns>Generation</returns>
        public static Types CreatType(string libType, Generation gen, List<Types> lst)
        {
            Types type = new Types();
            int insertion; // variable insertion

            try
            {
                // declaration et instanciation d'une variable chaine contenant le libelle de Generation
                int idType;

                List<int> lstId = new List<int>();

                // On ajoute touts les id de la liste typeListe a lstId
                foreach (Types tp in DBConst.lstSelectType)
                {
                    lstId.Add(tp.GetIdType());
                }

                if (lstId.Count() > 0)
                    idType = lstId.Max() + 1;
                else
                    idType = 1;

                // Instanciation de la variable annee
                type = new Types(idType, libType.ToUpper(), gen);

                // ajout de cette variable a la liste
                lst.Add(type);

                string requete = "CALL PROC_Insert_Type(" + idType + ", '" + libType.ToUpper() + "', " + gen.GetNumGeneration() + ")";

                // insertion BDD
                insertion = DBMySqlOutils.ExecuteNonQuery(requete);

                if (insertion == 1)
                {
                    Console.WriteLine("Insertion de l'objet Geneation " + libType.ToUpper() + " réussie");
                }
                else
                {
                    Console.WriteLine("L'insertion de l'objet Generation " + libType.ToUpper() + " a échouée");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + probleme.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return type;
        }

        /// <summary>
        /// Permet de remplir les ComboBox de Types a partir de la BDD avec le libelle comme valeur visible et le code comme valeur recuperable
        /// </summary>
        /// <param name="cbx">ComboBox</param>
        public static void RemplisCbxType(ComboBox cbx)
        {
            #region remplissage cbx
            string strReq = "CALL PROC_Select_Type_Cbx ()";
            try
            {
                MySqlDataReader mdrListe = DBMySqlOutils.ExecuteReader(strReq);
                DataTable dt = new DataTable();
                dt.Load(mdrListe);
                cbx.DataSource = dt;
                cbx.DisplayMember = "lib";
                cbx.ValueMember = "code";
                mdrListe.Close();
                cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + e.Message);
            }

            // Deconnection a la BD
            DBMySqlOutils.MaDeconnexion();
            #endregion
        }
        #endregion

        #region Images
        /// <summary>
        /// Permet de recuperer les donnees de la table Image de la BDD
        /// </summary>
        /// <returns>List Images</returns>
        public static List<Images> RecupImages()
        {
            List<Images> lstImg = new List<Images>();

            String requete = "CALL PROC_Select_Image_ordreId()";

            try
            {
                MySqlDataReader sdrListe = DBMySqlOutils.ExecuteReader(requete);

                Images img = new Images();

                while (sdrListe.Read())
                {
//                    MessageBox.Show(int.Parse(sdrListe["id"].ToString()) + " / " + sdrListe["url"].ToString() + " / " + sdrListe["ext"].ToString(), "informations", MessageBoxButtons.OK);

                    img = new Images(int.Parse(sdrListe["id"].ToString()), sdrListe["url"].ToString(), sdrListe["ext"].ToString());

                    lstImg.Add(img);
                }
                sdrListe.Close();

                // Fermeture de la BDD
                DBMySqlOutils.MaDeconnexion();

//                MessageBox.Show("recuperation Types reussie", "informations", MessageBoxButtons.OK);
            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + probleme.Message);
            }

            return lstImg;
        }

        /// <summary>
        /// Permet de creer un Objet Images a l'aide des parametres passes, de l'ajouter a la liste de type Images passee en parametre et de l'ajouter a la BDD
        /// </summary>
        /// <param name="urlImg">string</param>
        /// <param name="extImg">string</param>
        /// <param name="lst">List Images</param>
        /// <returns>Images</returns>
        public static Images CreatImages(string urlImg, string extImg, List<Images> lst)
        {
            Images img = new Images();
            int insertion; // variable insertion

            try
            {
                // declaration et instanciation d'une variable chaine contenant le libelle de Generation
                int idImg;

                List<int> lstId = new List<int>();

                // On ajoute touts les id de la liste lstSelectImg a lstId
                foreach (Images i in DBConst.lstSelectImg)
                {
                    lstId.Add(i.GetId());
                }

                if (lstId.Count() > 0)
                    idImg = lstId.Max() + 1;
                else
                    idImg = 1;

                // Instanciation de la variable img
                img = new Images(idImg, urlImg, extImg);

                // ajout de cette variable a la liste
                lst.Add(img);

                string requete = "CALL PROC_Insert_Image(" + idImg + ", '" + urlImg + "', '" + extImg + "')";

                // insertion BDD
                insertion = DBMySqlOutils.ExecuteNonQuery(requete);

                if (insertion == 1)
                {
                    Console.WriteLine("Insertion de l'objet Images " + urlImg + extImg+ " réussie");
                }
                else
                {
                    Console.WriteLine("L'insertion de l'objet Images " + urlImg + extImg + " a échouée");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + probleme.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return img;
        }

        /// <summary>
        /// Permet de remplir les ComboBox d'extension d'images a partir de la liste de Chaine de caractere 'DBConst.tabExtImg'
        /// </summary>
        /// <param name="cbx">ComboBox</param>
        public static void RemplisCbxImg(ComboBox cbx)
        {
            #region remplissage cbx
            try
            {
                cbx.DataSource = DBConst.tabExtImg;
                cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + e.Message);
            }

            // Deconnection a la BD
            DBMySqlOutils.MaDeconnexion();
            #endregion
        }

        /// <summary>
        /// Permet de remplir les ComboBox de la classe Images a partir de la BDD avec l'Url complete comme valeur visible et recuperable
        /// </summary>
        /// <param name="cbx">ComboBox</param>
        public static void RemplisCbxUrlComp(ComboBox cbx)
        {
            #region remplissage cbx
            string requete = "CALL PROC_Select_cbx_img ()";
            try
            {
                MySqlDataReader mdrListe = DBMySqlOutils.ExecuteReader(requete);
                DataTable dt = new DataTable();
                cbx.DisplayMember = "url";
                cbx.ValueMember = "url";
                dt.Load(mdrListe);
                cbx.DataSource = dt;
                mdrListe.Close();
                cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + e.Message + " RemplisCbxUrlComp");
            }

            // Deconnection a la BD
            DBMySqlOutils.MaDeconnexion();
            #endregion
        }

        /// <summary>
        /// Permet de recuperer les donnees de la table Image de la BDD
        /// </summary>
        /// <returns>List Images</returns>
        public static void RemplisDtgImg(DataGridView dtg)
        {

            try
            {
                #region Creation de la grille
                // On efface la collection
                dtg.Rows.Clear();
                // On empêche l'écriture sur les cellules
                dtg.ReadOnly = true;
                // On affiche les Entêtes des 6 colonnes
                dtg.RowHeadersVisible = false;
                dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtg.ColumnCount = 3;
                // On nomme les colonnes
                dtg.Columns[0].Name = "Num Pkdx Mondial";
                dtg.Columns[1].Name = "Nom Pokemon";
                dtg.Columns[2].Name = "Addresse Url Image";
                #endregion

                #region Execution de la requete
                string MtrRequete = "CALL PROC_Select_cbx_pkm_img_B ()";
                MySqlDataReader MdrListe;
                MdrListe = DBMySqlOutils.ExecuteReader(MtrRequete);
                while (MdrListe.Read())
                {
                    dtg.Rows.Add(MdrListe["numPkdx"].ToString(), MdrListe["nomPkm"].ToString(), MdrListe["url"].ToString());
                }
                MdrListe.Close();
                DBMySqlOutils.MaDeconnexion();
                #endregion

                #region Mise en forme de la grille
                dtg.Refresh();
                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                #endregion

            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + probleme.Message);
            }
        }

        /// <summary>
        /// Permet d'afficher l'image correspondant à l'Url selectionnee de la ListBox passee en parametre dans la PictureBox passee en parametre
        /// </summary>
        /// <param name="source">ListBox</param>
        /// <param name="ptb">PictureBox</param>
        /// <param name="introLbx">string</param>
        public static void AffImgSelectedValue (ListBox source, PictureBox ptb)
        {
//            MessageBox.Show("Valeur selectionnee : " + source.SelectedItem.ToString(), "Verification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (source.GetSelected(0) == false) // On verifie que la valeur selectionnee ne soit pas l'entete de la ListBox
            {
                try
                {
                    // Recuperation de l'Url complete dans une variable de type String
                    string urlComp = source.SelectedItem.ToString();

                    // Chargement de l'image dans la PictureBox
                    ptb.Load(urlComp);
                }
                catch (Exception e)
                {
                    MessageBox.Show("L'erreur suivante a été rencontré : " + e.Message + " / AffImgSelectedValue");
                }
            }
        }

        /// <summary>
        /// Permet d'afficher l'image correspondant à l'Url correspondant a la ligne selectionnee de la DataGridView passee en parametre dans la PictureBox passee en parametre
        /// </summary>
        /// <param name="source">DataGridView</param>
        /// <param name="ptb">PictureBox</param>
        public static void AffImgSelectedValue(DataGridView source, PictureBox ptb)
        {
            // declaration d'une variable string contenant l'addresse url stockée dans la Cellulle d'index 2 de la ligne selectionnee par l'utilisateur
            string urlComp = source.SelectedCells[2].Value.ToString();

            try
            {
                // Chargement de l'image dans la PictureBox
                ptb.Load(urlComp);

//                MessageBox.Show("Url selectionnee = " + urlComp, "Verification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + e.Message + " / AffImgSelectedValue");
            }
            
        }

        /// <summary>
        /// Permet d'afficher l'image correspondant à l'Url correspondant a la ligne selectionnee de la ComboBox passee en parametre dans la PictureBox passee en parametre
        /// </summary>
        /// <param name="source">ComboBox</param>
        /// <param name="ptb">PictureBox</param>
        public static void AffImgSelectedValue(ComboBox source, PictureBox ptb)
        {
            // declaration d'une variable string contenant l'addresse url stockée dans la Cellulle d'index 2 de la ligne selectionnee par l'utilisateur
            string urlComp = source.SelectedValue.ToString();
            try
            {
                // Chargement de l'image dans la PictureBox
                ptb.Load(urlComp);
            }
            catch (Exception e)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + e.Message + " / AffImgSelectedValue");
            }
        }
        
        /// <summary>
        /// Permet de recuperer un objet Images a partir d'une chaine representant l'Url Complete
        /// </summary>
        /// <param name="urlComp"></param>
        /// <param name="lst"></param>
        /// <returns></returns>
        public static Images ConvertImg(string urlComp, List<Images> lst)
        {
            Images img = new Images();
            MessageBox.Show("urlComp : " + urlComp, "urlComp");
            try
            {
                foreach (Images i in lst)
                {
                    if (urlComp.Equals(i.GetUrlComplete()))
                    {
                        return i;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception : " + e.Message, "Error");
            }

            return img;
        }
        #endregion

        #region Pokemon
        /// <summary>
        /// Permet de recuprer le pokemon a partir de son numero
        /// </summary>
        /// <param name="numPokemon">String</param>
        /// <returns></returns>
        public static Pokemon ConvertPokemon (String numPokemon)
        {
            Pokemon pkm = new Pokemon();

            foreach (Pokemon p in DBConst.lstSelectPkm)
            {
                if (p.GetNumPokedexMondialPkm().Equals(numPokemon))
                {
                    pkm = p;
                }
            }

            return pkm;
        }

        /// <summary>
        /// Permet de recuperer les donnees de la table Pokemon de la BDD
        /// </summary>
        /// <returns>List Pokemon</returns>
        public static List<Pokemon> RecupPokemon()
        {
            List<Pokemon> lstPkm = new List<Pokemon>();

            String requete = "CALL PROC_Select_Pkm_OrdrePkdx()";

            try
            {
                MySqlDataReader sdrListe = DBMySqlOutils.ExecuteReader(requete);

                Pokemon pkm = new Pokemon();
                Images img = new Images();
                Generation gen = new Generation();
                while (sdrListe.Read())
                {
                    int iI = int.Parse(sdrListe["url"].ToString());
                    foreach (Images i in DBConst.lstSelectImg)
                    {
                        if (iI == i.GetId())
                            img = i;
                    }
                    int nG = int.Parse(sdrListe["gen"].ToString());
                    
                    gen = ConvertGen(nG, DBConst.lstSelectGen);
                    
                    bool legendPkm = bool.Parse(sdrListe["legendaire"].ToString());
 //                   MessageBox.Show("leg : " + legendPkm.ToString());
                    pkm = new Pokemon(sdrListe["num"].ToString(), sdrListe["nom"].ToString(), sdrListe["descr"].ToString(), legendPkm, img, gen);

                    lstPkm.Add(pkm);
                }
                sdrListe.Close();

                // Fermeture de la BDD
                DBMySqlOutils.MaDeconnexion();

//                MessageBox.Show("recuperation Pokemon reussie", "informations", MessageBoxButtons.OK);
            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + probleme.Message + " / RecupPkm");
            }

            return lstPkm;
        }

        /// <summary>
        /// Permet de creer un Objet Pokemon a l'aide des parametres passes, de l'ajouter a la liste de type Pokemon passee en parametre et de l'ajouter a la BDD
        /// </summary>
        /// <param name="numPkm">string</param>
        /// <param name="nomPkm">string</param>
        /// <param name="descPkm">string</param>
        /// <param name="img">Images</param>
        /// <param name="legendaire">Boolean</param>
        /// <param name="gen">Generation</param>
        /// <param name="lst">List Pokemon</param>
        /// <returns>Pokemon</returns>
        public static Pokemon CreatPokemon(string numPkm, string nomPkm, string descPkm, Images img, Boolean legendaire, Generation gen, List<Pokemon> lst)
        {
            Pokemon pkm = new Pokemon();
            int insertion; // variable insertion

            try
            {
                // Instanciation de la variable pkm
                pkm = new Pokemon(numPkm, nomPkm, descPkm, legendaire, img, gen);

                // ajout de cette variable a la liste
                lst.Add(pkm);

                string requete = "CALL PROC_Insert_Pkm('" + numPkm + "', '" + nomPkm + "', \"" + descPkm + "\", " + img.GetId() + ", " + PassBoolABit(legendaire) + ", " + gen.GetNumGeneration() + ")";

                // insertion BDD
                insertion = DBMySqlOutils.ExecuteNonQuery(requete);

                if (insertion == 1)
                {
                    Console.WriteLine("Insertion de l'objet Pokemon " + numPkm + " / " + nomPkm + " réussie");
                }
                else
                {
                    Console.WriteLine("L'insertion de l'objet Pokemon " + numPkm + " / " + nomPkm + " a échouée");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + probleme.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return pkm;
        }

        /// <summary>
        /// Permet de remplir les ComboBox de Pokemon a partir de la BDD avec le libelle comme valeur visible et l'id comme valeur recuperable
        /// </summary>
        /// <param name="cbx">ComboBox</param>
        public static void RemplisCbxPokemon(ComboBox cbx)
        {
            #region remplissage cbx
            string requete = "CALL PROC_Select_Cbx_Pkm()";
            try
            {
                MySqlDataReader mdrListe = DBMySqlOutils.ExecuteReader(requete);
                DataTable dt = new DataTable();
                cbx.DisplayMember = "nom";
                cbx.ValueMember = "num";
                dt.Load(mdrListe);
                cbx.DataSource = dt;
                mdrListe.Close();
                cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + e.Message + " RemplisCbxPokemonComp");
            }

            // Deconnection a la BD
            DBMySqlOutils.MaDeconnexion();
            #endregion
        }
        #endregion

        #region AvoirType
        /// <summary>
        /// Permet de recuprer la relation AvoirType a partir du Pokemon et du Types
        /// </summary>
        /// <param name="pkm">Pokemon</param>
        /// <param name="t">Types</param>
        /// <returns>AvoirTypes</returns>
        public static AvoirType ConvertAvoirType(Pokemon pkm, Types t)
        {
            foreach (AvoirType at in DBConst.lstSelectAvoirType)
            {
                if (at.GetPkmAvoirType().Equals(pkm) == true && at.GetTypeAvoirType().Equals(t) == true)
                {
                    return at;
                }
            }
            AvoirType avtp = new AvoirType(); 
            
            return avtp;
        }

        /// <summary>
        /// Permet de recuperer les donnees de la table AvoirType de la BDD
        /// </summary>
        /// <returns>List AvoirType</returns>
        public static List<AvoirType> RecupAvoirType()
        {
            List<AvoirType> lstAT = new List<AvoirType>();

            String requete = "CALL PROC_Select_Avoir_Type_ordAPkm()";

            try
            {
                MySqlDataReader sdrListe = DBMySqlOutils.ExecuteReader(requete);

                AvoirType avoirType = new AvoirType();

                Pokemon pkm = new Pokemon();
                Types type = new Types();

                while (sdrListe.Read())
                {
                    string pk = sdrListe["num"].ToString();

                    pkm = ConvertPokemon(pk);

                    string tp = sdrListe["code"].ToString();
                    foreach (Types t in DBConst.lstSelectType)
                    {
                        if (tp.Equals(t.GetIdType().ToString()))
                        {
                            type = t;
                        }
                    }

                    avoirType = new AvoirType(pkm, type);

                    lstAT.Add(avoirType);
                }
                sdrListe.Close();

                // Fermeture de la BDD
                DBMySqlOutils.MaDeconnexion();

//                MessageBox.Show("recuperation AvoirType reussie", "informations", MessageBoxButtons.OK);
            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + probleme.Message);
            }

            return lstAT;
        }

        /// <summary>
        /// Permet de creer un Objet AvoirType a l'aide des parametres passes, de l'ajouter a la liste de type AvoirType passee en parametre et de l'ajouter a la BDD
        /// </summary>
        /// <param name="pokemon">Pokemon</param>
        /// <param name="type">Types</param>
        /// <param name="lst">List AvoirType</param>
        /// <returns></returns>
        public static AvoirType CreatAvoirType(Pokemon pokemon, Types type, List<AvoirType> lst)
        {
            AvoirType avTp = new AvoirType();
            int insertion; // variable insertion

            try
            {
                // Instanciation de la variable avTp
                avTp = new AvoirType(pokemon, type);

                // ajout de cette variable a la liste
                lst.Add(avTp);

                string requete = "CALL PROC_Insert_Avoir_Type ('" + pokemon.GetNumPokedexMondialPkm() + "', " + type.GetIdType() + ")";

                // insertion BDD
                insertion = DBMySqlOutils.ExecuteNonQuery(requete);

                if (insertion == 1)
                {
                    Console.WriteLine("Insertion de l'objet AvoirType " + pokemon.GetNumPokedexMondialPkm() + " / " + type.GetLibType() + " réussie");
                }
                else
                {
                    Console.WriteLine("L'insertion de l'objet AvoirType " + pokemon.GetNumPokedexMondialPkm() + " / " + type.GetLibType() + " a échouée");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + probleme.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return avTp;
        }

        /// <summary>
        /// Permet de Supprimmer un Objet AvoirType de la liste AvoirType passee en parametre et de la BDD
        /// </summary>
        /// <param name="pokemon">Pokemon</param>
        /// <param name="type">Types</param>
        /// <param name="lst">List AvoirType</param>
        /// <returns></returns>
        public static AvoirType DeleteAvoirType(AvoirType avoirType, List<AvoirType> lst)
        {
            int suppression; // variable insertion

            try
            {
                // Suppression de avoirType de la liste
                lst.Remove(avoirType);

                MessageBox.Show("La relation en suppression est : " + avoirType.GetPkmAvoirType().GetNumPokedexMondialPkm(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Preparation de la requete avec la procedure stockee
                string requete = "CALL PROC_Delete_Avoir_Type ('" + avoirType.GetPkmAvoirType().GetNumPokedexMondialPkm() + "', " + avoirType.GetTypeAvoirType().GetIdType() + ")";

                // insertion BDD
                suppression = DBMySqlOutils.ExecuteNonQuery(requete);

                if (suppression == 1)
                {
                    Console.WriteLine("La suppression de l'objet AvoirType " + avoirType.GetPkmAvoirType().GetNumPokedexMondialPkm() + " / " + avoirType.GetTypeAvoirType().GetLibType() + " réussie");
                }
                else
                {
                    Console.WriteLine("La suppression de l'objet AvoirType " + avoirType.GetPkmAvoirType().GetNumPokedexMondialPkm() + " / " + avoirType.GetTypeAvoirType().GetLibType() + " a échouée");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + probleme.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return avoirType;
        }
        
        /// <summary>
        /// Permet de verifier s'il est possible d'inserer un ou deux nouveau Types a un Pokemon
        /// </summary>
        /// <param name="numPkm">String</param>
        /// <param name="nbInsertions">int</param>
        /// <returns>bool</returns>
        public static bool VerifInsertionSup2AvoirType (String numPkm, int nbInsertions)
        {
            Pokemon pkm = ConvertPokemon(numPkm);

            try
            {
                string requete = "CALL PROC_Select_Count_Avoir_Type_Pkm ('" + pkm.GetNumPokedexMondialPkm() + "')";
                
                int entier = DBMySqlOutils.ExecuteNonQuery(requete);

                entier += nbInsertions;
                if (entier <= 2)
                {
                    return true;
                } else
                {
                    MessageBox.Show("Le Pokemon possederait plus de deux types si l'insertion se fait, il ne peut en avoir plus deux", "Impossibilite d'insertion");
                    return false;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + probleme.Message);
                return false;
            }
        }

        /// <summary>
        /// Permet de selectionner le Types d'une liste Box et de gerer graphiquement la visibilites et l'affichages de certains composants passes en parametres
        /// </summary>
        /// <param name="lbx">ListBox</param>
        /// <param name="lblType1">Label</param>
        /// <param name="lblType2">Label</param>
        /// <param name="ckbType1">CheckBox</param>
        /// <param name="ckbType2">CheckBox</param>
        /// <param name="btnAj">Button</param>
        /// <param name="lstAt">List AvoirType</param>
        /// <param name="lstTp">List Types</param>
        public static void SelectTypeLstBox (ListBox lbx, Label lblType1, Label lblType2, CheckBox ckbType1, 
            CheckBox ckbType2, Button btnAj, List<AvoirType> lstAt, List<Types> lstTp)
        {
            if (lbx.GetSelected(0) == false) // On verifie que la valeur selectionnee ne soit pas l'entete de la ListBox
            {
                try
                {
                    // Declaration Objets
                    AvoirType avoirType = new AvoirType();
                    Types type1 = new Types();
                    Types type2 = new Types();

                    // On vide la liste de Types
                    lstTp.Clear();

                    // Recuperation du Numero du pkm dans une variable de type String
                    string num = lbx.SelectedItem.ToString().Substring(0, 3);
//                    MessageBox.Show("Numéro Pokédex : " + num, "Numéro du Pokemon");

                    foreach (AvoirType avTp in lstAt)
                    {
                        if (avTp.GetPkmAvoirType().GetNumPokedexMondialPkm().Equals(num.ToString()))
                        {
                            if(type1.GetIdType() == 0)
                            {
                                type1 = avTp.GetTypeAvoirType();

                                lstTp.Add(type1);
                            }
                            else
                            {
                                type2 = avTp.GetTypeAvoirType();

                                lstTp.Add(type2);
                            }
                        }
                    }

                    if (lstTp.Count() == 1)
                    {
                        // On inscrit le libelle du Type dans le Label souhaite
                        lblType1.Text = type1.GetLibType().ToString();

                        // On ajuste les Visibiltes des Outils passes en parametre
                        lblType1.Visible = true;
                        ckbType1.Visible = true;
                        lblType2.Visible = false;
                        ckbType1.Visible = true;
                        ckbType2.Visible = false;
                        btnAj.Visible = true;
                    }
                    else
                    {
                        if (lstTp.Count() == 2)
                        {
                            // On inscrit les libelles des Types dans les Label souhaites
                            lblType1.Text = type1.GetLibType().ToString();
                            lblType2.Text = type2.GetLibType().ToString();
                            
                            // On ajuste les Visibiltes des Outils passes en parametre
                            lblType1.Visible = true;
                            ckbType1.Visible = true;
                            lblType2.Visible = true;
                            ckbType1.Visible = true;
                            ckbType2.Visible = true;
                            btnAj.Visible = true;
                        } else
                        {
                            // On inscrit le message text dans le Label souhaite
                            lblType1.Text = "Le pokemon ne possède aucun Types";
                            
                            // On ajuste les Visibiltes des Outils passes en parametre
                            lblType1.Visible = true;
                            ckbType1.Visible = false;
                            lblType2.Visible = false;
                            ckbType1.Visible = false;
                            ckbType2.Visible = false;
                            btnAj.Visible = true;

                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("L'erreur suivante a été rencontré : " + e.Message + " / SelectTypeLstBox");
                }
            } else
            {
                // On inscrit le message text dans le Label souhaite
                lblType1.Text = "Selection incorrecte";

                // On ajuste les Visibiltes des Outils passes en parametre
                lblType1.Visible = true;
                ckbType1.Visible = false;
                lblType2.Visible = false;
                ckbType1.Visible = false;
                ckbType2.Visible = false;
                btnAj.Visible = false;
            }
        }

        /// <summary>
        /// Permet de controller l'insertion d'un ou de deux objets AvoirTypes a partir de conditions determinees par les differents Objets passes en parmetres et d'effectuer les insertions 
        /// en appelant la methodes faites pour
        /// </summary>
        /// <param name="rdb1Types">RadioButton</param>
        /// <param name="numPkm">String</param>
        /// <param name="codeTypes1">int</param>
        /// <param name="codeTypes2">int</param>
        /// <param name="lst">List Types</param>
        public static void InsertionAvoirType(RadioButton rdb1Types, String numPkm, int codeTypes1, int codeTypes2, List<Types> lst)
        {
            Pokemon pkm = ConvertPokemon(numPkm);

            if(rdb1Types.Checked == true)
            {
                Types types1 = ConvertTypes(codeTypes1, null, lst);

                // Appel de la methode de Creation d'une relation AvoirType 
                CreatAvoirType(pkm, types1, DBConst.lstSelectAvoirType);
            } else
            {
                if (codeTypes1.Equals(codeTypes2))
                {
                    Types types1 = ConvertTypes(codeTypes1, null, lst);

                    MessageBox.Show("Les deux Types rentrés sont les mêmes le type : " + types1.GetLibType() + " seras quand même attribué une fois à : " + pkm.GetNomPokemon(), "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Appel de la methode de Creation d'une relation AvoirType 
                    CreatAvoirType(pkm, types1, DBConst.lstSelectAvoirType);
                }
                else
                {
                    // recuperation du premier Types a partir de son lib passe en parametre
                    Types types1 = ConvertTypes(codeTypes1, null, lst);

                    // recuperation du second Types a partir de son lib passe en parametre
                    Types types2 = ConvertTypes(codeTypes2, null, lst);

                    // Appel de la methode de Creation de la première relation AvoirType
                    CreatAvoirType(pkm, types1, DBConst.lstSelectAvoirType);

                    // Appel de la methode de Creation de la seconde relation AvoirType
                    CreatAvoirType(pkm, types2, DBConst.lstSelectAvoirType);
                }
            }
        }

        /// <summary>
        /// Permet de controller la suppression d'un ou de deux objets AvoirTypes a partir de conditions determinees par les differents Objets passes en parmetres et d'effectuer les suppressions 
        /// en appelant la methodes faites pour
        /// </summary>
        /// <param name="ckbLbl1">CheckBox</param>
        /// <param name="ckbLbl2">CheckBox</param>
        /// <param name="lblType1">Label</param>
        /// <param name="lblType2">Label</param>
        /// <param name="lbx">ListBox</param>
        /// <param name="lstAT">List AvoirType</param>
        /// <param name="BtnAjoutType">Button</param>
        public static void SuppressionAvoirType(CheckBox ckbLbl1, CheckBox ckbLbl2, Label lblType1, Label lblType2, ListBox lbx, List<AvoirType> lstAT, Button BtnAjoutType)
        {
            AvoirType avoirType1 = new AvoirType();
            AvoirType avoirType2 = new AvoirType();

            // Recuperation du Numero du pkm dans une variable de type String
            string numPkm = lbx.SelectedItem.ToString().Substring(0, 3);

            if (ckbLbl1.Checked == true && ckbLbl2.Checked == true)
            {
                Pokemon pkm = ConvertPokemon(lbx.SelectedItem.ToString().Substring(0,3));

                Types tp1 = ConvertTypes(0, lblType1.Text, DBConst.lstSelectType);
                Types tp2 = ConvertTypes(0, lblType2.Text, DBConst.lstSelectType);

                avoirType1 = ConvertAvoirType(pkm, tp1);
                avoirType2 = ConvertAvoirType(pkm, tp2);

                MessageBox.Show("AvoirType 1 : " + avoirType1.GetTypeAvoirType().GetLibType() + " / " + avoirType1.GetPkmAvoirType().GetNumPokedexMondialPkm(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("AvoirType 2 : " + avoirType2.GetTypeAvoirType().GetLibType() + " / " + avoirType2.GetPkmAvoirType().GetNumPokedexMondialPkm(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Appel de la methode de Suppression de la relation AvoirType avoirType1
                DeleteAvoirType(avoirType1, lstAT);

                // Appel de la methode de Suppression de la relation AvoirType avoirType2
                DeleteAvoirType(avoirType2, lstAT);

                // On enleve le coche des CheckBox et on reactualise la selection de la Lbx
                ckbLbl1.Checked = false;
                ckbLbl2.Checked = false;
                OutilsPkdx.SelectTypeLstBox(lbx, lblType1, lblType2, ckbLbl1, ckbLbl2, BtnAjoutType, lstAT, DBConst.lstSelectTypeLBX);
            }
            else
            {
                if (ckbLbl1.Checked == true)
                {
                    Pokemon pkm = ConvertPokemon(lbx.SelectedItem.ToString().Substring(0, 3));

                    MessageBox.Show("Pokemon : " + pkm.GetNomPokemon(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Types tp1 = ConvertTypes(0, lblType1.Text, DBConst.lstSelectType);

                    MessageBox.Show("Types 1 : " + tp1.GetLibType() + " / " + lblType1.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    avoirType1 = ConvertAvoirType(pkm, tp1);

//                    MessageBox.Show("AvoirType 1 : " + avoirType1.GetTypeAvoirType().GetLibType() + " / " + avoirType1.GetPkmAvoirType().GetNumPokedexMondialPkm(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Appel de la methode de Suppression de la relation AvoirType avoirType1
                    DeleteAvoirType(avoirType1, lstAT);

                    // On enleve le coche de la CheckBox conernée et on reactualise la selection de la Lbx
                    ckbLbl1.Checked = false;
                    OutilsPkdx.SelectTypeLstBox(lbx, lblType1, lblType2, ckbLbl1, ckbLbl2, BtnAjoutType, lstAT, DBConst.lstSelectTypeLBX);
                }
                else
                {
                    if(ckbLbl2.Checked == true)
                    {
                        Pokemon pkm = ConvertPokemon(lbx.SelectedItem.ToString().Substring(0, 3));

                        Types tp2 = ConvertTypes(0, lblType2.Text, DBConst.lstSelectType);

                        MessageBox.Show("Types 2 : " + tp2.GetLibType(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        avoirType2 = ConvertAvoirType(pkm, tp2);

                        MessageBox.Show("AvoirType 2 : " + avoirType2.GetTypeAvoirType().GetLibType() + " / " + avoirType2.GetPkmAvoirType().GetNumPokedexMondialPkm(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        // Appel de la methode de Suppression de la relation AvoirType avoirType2
                        DeleteAvoirType(avoirType2, lstAT);

                        // On enleve le coche de la CheckBox conernée et on reactualise la selection de la Lbx
                        ckbLbl2.Checked = false;
                        OutilsPkdx.SelectTypeLstBox(lbx, lblType1, lblType2, ckbLbl1, ckbLbl2, BtnAjoutType, lstAT, DBConst.lstSelectTypeLBX);
                    } else
                    {
                        // Bien que normalement les controles de l'IHM empeche ce genre de cas
                        MessageBox.Show("Aucun élèments sélectionné pour être suprrimé ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        #endregion

        #region TypeEvolution
        /// <summary>
        /// Permet de retourner l'Objet TypeEvolution correspondanta l'id ou au libelle passe en parametre, peut servir pour les cbx... ou dans le code pour recuperer l'objet TypeEvolution
        /// (si on a seulement l'id mettre 'null' pour le libelle et si on a seulement le libelle mettre 0 a l'id)
        /// </summary>
        /// <param name="idTypeEvo">int</param>
        /// <param name="libTypeEvo">string</param>
        /// <param name="lst">List TypeEvolution</param>
        /// <returns>TypeEvolution</returns>
        public static TypeEvolution ConvertTypeEvo(int idTypeEvo, string libTypeEvo, List<TypeEvolution> lst)
        {
            try
            {
                if (idTypeEvo > 0)
                {
                    foreach (TypeEvolution te in lst)
                    {
                        if (idTypeEvo == te.GetIdTypeEvol())
                        {
                            return te;
                        }
                    }
                } else
                {
                    if (libTypeEvo != null)
                    {
                        foreach (TypeEvolution te in lst)
                        {
                            if (libTypeEvo == te.GetLibelleTypeEvol())
                            {
                                return te;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception : " + e.Message, "Error");
            }
            
            TypeEvolution typeEvolution = new TypeEvolution();

            return typeEvolution;
        }

        /// <summary>
        /// Permet de suprimer les donnees d'une liste TypeEvolution passee en parametre et y inserer les donnees de la table TypeEvolution de la BDD
        /// </summary>
        /// <param name="lst">List TypeEvolution</param>
        public static void RecupTypeEvolution(List<TypeEvolution> lst)
        {
            // Preparation de la requete de recuperation
            String requete = "CALL PROC_Select_TypeEvol_OrdreA()";
            
            try
            {
                // Suprression des donnees de la liste
                lst.Clear();

                MySqlDataReader sdrListe = DBMySqlOutils.ExecuteReader(requete);

                TypeEvolution typeEvolution = new TypeEvolution();
                while (sdrListe.Read())
                {
                    
                    typeEvolution = new TypeEvolution(int.Parse(sdrListe["id"].ToString()), sdrListe["lib"].ToString());

                    lst.Add(typeEvolution);
                }
                sdrListe.Close();

                // Fermeture de la BDD
                DBMySqlOutils.MaDeconnexion();

 //               MessageBox.Show("recuperation TypeEvolution reussie", "informations", MessageBoxButtons.OK);
            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + probleme.Message + " / RecupTypeEvolution", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Permet de creer un Objet TypeEvolution a l'aide des parametres passes, de l'ajouter a la liste de type TypeEvolution passee en parametre et de l'ajouter a la BDD
        /// </summary>
        /// <param name="lib">string</param>
        /// <param name="lst">List TypeEvolution</param>
        /// <returns>TypeEvolution</returns>
        public static TypeEvolution CreatTypeEvolution(string lib, List<TypeEvolution> lst)
        {
            TypeEvolution typeEvolution = new TypeEvolution();
            int insertion; // variable insertion

            try
            {
                // declaration d'un entier et d'une liste d'entier afin de recuper l'id du Type d'Evolution que l'on vas inserer 
                int idTypeEvo;

                List<int> lstId = new List<int>();

                // On ajoute touts les id de la liste TypeEvolution a lstId
                foreach (TypeEvolution te in lst)
                {
                    lstId.Add(te.GetIdTypeEvol());
                }

                if (lstId.Count() > 0)
                    idTypeEvo = lstId.Max() + 1;
                else
                    idTypeEvo = 1;

                // Instanciation de la variable typeEvolution
                typeEvolution = new TypeEvolution(idTypeEvo, lib);

                // ajout de cette variable a la liste
                lst.Add(typeEvolution);

                string requete = "CALL PROC_Insert_TypeEvol(" + idTypeEvo + ", \"" + lib + "\")";

                // insertion BDD
                insertion = DBMySqlOutils.ExecuteNonQuery(requete);

                if (insertion == 1)
                {
                    Console.WriteLine("Insertion de l'objet TypeEvolution " + idTypeEvo + " / " + lib + " réussie");
                }
                else
                {
                    Console.WriteLine("L'insertion de l'objet TypeEvolution " + idTypeEvo + " / " + lib + " a échouée");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + probleme.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return typeEvolution;
        }

        /// <summary>
        /// Permet de remplir les ComboBox de TypeEvolution a partir de la BDD avec le libelle comme valeur visible et l'id comme valeur recuperable
        /// </summary>
        /// <param name="cbx">ComboBox</param>
        public static void RemplisCbxTypeEvo(ComboBox cbx)
        {
            #region remplissage cbx
            string requete = "CALL PROC_Select_TypeEvol_OrdreA()";
            try
            {
                MySqlDataReader mdrListe = DBMySqlOutils.ExecuteReader(requete);
                DataTable dt = new DataTable();
                cbx.DisplayMember = "lib";
                cbx.ValueMember = "id";
                dt.Load(mdrListe);
                cbx.DataSource = dt;
                mdrListe.Close();
                cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + e.Message + " RemplisCbxPokemonComp");
            }

            // Deconnection a la BD
            DBMySqlOutils.MaDeconnexion();
            #endregion
        }
        #endregion

        #region Evolution
        /// <summary>
        /// Permet de creer un Objet Evolution a l'aide des parametres passes, de l'ajouter a la liste de type Evolution passee en parametre et de l'ajouter a la BDD
        /// </summary>
        /// <param name="sousEvol">Pokemon</param>
        /// <param name="surEvol">Pokemon</param>
        /// <param name="typeEvolution">TypeEvolution</param>
        /// <param name="lst">List Evolution</param>
        /// <returns>Evolution</returns>
        public static Evolution CreatEvolution(Pokemon sousEvol, Pokemon surEvol, TypeEvolution typeEvolution, List<Evolution> lst)
        {
            Evolution evolution = new Evolution();
            int insertion; // variable insertion

            try
            {
                // declaration d'un entier et d'une liste d'entier afin de recuper l'id de l'Evolution que l'on vas inserer 
                int idEvo;
                // Declartion et instanciation de la chaine de caractere representant le libelle
                string lib = sousEvol.GetNumPokedexMondialPkm() + "/" + surEvol.GetNumPokedexMondialPkm();

                List<int> lstId = new List<int>();

                // On ajoute touts les id de la liste TypeEvolution a lstId
                foreach (Evolution e in lst)
                {
                    lstId.Add(e.GetIdEvolution());
                }

                if (lstId.Count() > 0)
                    idEvo = lstId.Max() + 1;
                else
                    idEvo = 1;

                // Instanciation de la variable evolution
                evolution = new Evolution(idEvo, lib, sousEvol, surEvol, typeEvolution);

                // ajout de cette variable a la liste
                lst.Add(evolution);

                string requete = "CALL PROC_Insert_Evolution(" + idEvo + ", '" + lib + "', '" + sousEvol.GetNumPokedexMondialPkm() + "', '" + surEvol.GetNumPokedexMondialPkm() + "', "
                    + typeEvolution.GetIdTypeEvol() + ")";

                // insertion BDD
                insertion = DBMySqlOutils.ExecuteNonQuery(requete);

                if (insertion == 1)
                {
                    Console.WriteLine("Insertion de l'objet Evolution " + idEvo + " / " + lib + " réussie");
                }
                else
                {
                    Console.WriteLine("L'insertion de l'objet Evolution " + idEvo + " / " + lib + " a échouée");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + probleme.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return evolution;
        }

        /// <summary>
        /// Permet de suprimer les donnees d'une liste Evolution passee en parametre et y inserer les donnees de la table Evolution de la BDD
        /// </summary>
        /// <param name="lst">List Evolution</param>
        public static void RecupEvolution(List<Evolution> lst)
        {
            // Preparation de la requete de recuperation
            String requete = "CALL PROC_Select_Evolution_ordASousEvol()";

            try
            {
                // Suprression des donnees de la liste
                lst.Clear();

                MySqlDataReader sdrListe = DBMySqlOutils.ExecuteReader(requete);

                Evolution evolution = new Evolution();
                while (sdrListe.Read())
                {
                    Pokemon sousEvo = new Pokemon();
                    Pokemon surEvo = new Pokemon();
                    TypeEvolution typeEvolution = new TypeEvolution();

                    string nPSous = sdrListe["sous_evol"].ToString();
                    string nPSur = sdrListe["sur_evol"].ToString();
                    string iTypeEvol = sdrListe["typeEvol"].ToString();

                    foreach (Pokemon p in DBConst.lstSelectPkm)
                    {
                        if (nPSous.Equals(p.GetNumPokedexMondialPkm()))
                            sousEvo = p;
                        if (nPSur.Equals(p.GetNumPokedexMondialPkm()))
                            surEvo = p;
                    }

                    foreach (TypeEvolution te in DBConst.lstSelectTypeEvo)
                    {
                        if (iTypeEvol.Equals(te.GetLibelleTypeEvol()))
                            typeEvolution = te;
                    }

                    evolution = new Evolution(int.Parse(sdrListe["id"].ToString()), sdrListe["lib"].ToString(), sousEvo, surEvo, typeEvolution);

                    lst.Add(evolution);
                }
                sdrListe.Close();

                // Fermeture de la BDD
                DBMySqlOutils.MaDeconnexion();

//                MessageBox.Show("Recuperation Evolution reussie", "informations", MessageBoxButtons.OK);
            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + probleme.Message + " / RecupTypeEvolution");
            }
        }

        /// <summary>
        /// Permet de recuperer les donnees de la table Evolution de la BDD
        /// </summary>
        /// <returns>List Images</returns>
        public static void RemplisDtgEvo(DataGridView dtg)
        {

            try
            {
                #region Creation de la grille
                // On efface la collection
                dtg.Rows.Clear();
                // On empêche l'écriture sur les cellules
                dtg.ReadOnly = true;
                // On affiche les Entêtes des 6 colonnes
                dtg.RowHeadersVisible = false;
                dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtg.ColumnCount = 4;
                // On nomme les colonnes
                dtg.Columns[0].Name = "Libelle Evolution";
                dtg.Columns[1].Name = "Pokemon Evoluant";
                dtg.Columns[2].Name = "Pokemon Evolue";
                dtg.Columns[3].Name = "Type d'Evolution";
                #endregion

                #region Execution de la requete
                string MtrRequete = "CALL PROC_Select_cbx_Evol_ordALib ()";
                MySqlDataReader MdrListe;
                MdrListe = DBMySqlOutils.ExecuteReader(MtrRequete);
                while (MdrListe.Read())
                {
                    dtg.Rows.Add(MdrListe["libEvol"].ToString(), MdrListe["sousEvol"].ToString(), MdrListe["surEvol"].ToString(), MdrListe["libType"].ToString());
                }
                MdrListe.Close();
                DBMySqlOutils.MaDeconnexion();
                #endregion

                #region Mise en forme de la grille
                dtg.Refresh();
                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                #endregion

            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + probleme.Message);
            }
        }
        #endregion
        #endregion
    }
}
