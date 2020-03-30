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
        public static Int16 PassBitABool(Boolean bl)
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

        public static Boolean VerifNoDoulon(List<Object> lst, Object obj)
        {
            // declaration objets
            bool noDoublon = true;

            foreach (Object o in lst)
            {
                if (o == obj)
                    noDoublon = false;
            }

            return noDoublon;
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

        public static void ColorBtn(List<Button> LstBtn)
        {
            foreach (Button btn in LstBtn)
            {
                btn.BackColor = Color.ForestGreen;
            }
        }

        public static void ColorBtn(List<Button> LstBtn, Button button)
        {
            foreach (Button btn in LstBtn)
            {
                btn.BackColor = Color.ForestGreen;
            }

            button.BackColor = Color.FromArgb(255, 192, 192);
        }

        #region verifications
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

        public static Annee RecupAnneeCbx(string numAnnee, List<Annee> lst)
        {
            Annee an = new Annee();

            string message = ("numAnnee = " + numAnnee);
            MessageBox.Show(message, "Type Annee 1");

            foreach (Annee a in lst)
            {
                if (a.GetNumAnnee().Equals(numAnnee))
                {
                    return a;
                }
            }

            return an;
        }

        public static Generation RecupGenCbx(int numGen, List<Generation> lst)
        {
            Generation gen = new Generation();

            try
            {
                foreach (Generation g in lst)
                {
                    if (numGen == g.GetNumGeneration())
                    {
                        return g;
                    }
                }
            } catch (Exception e)
            {
                MessageBox.Show("Exception : " + e.Message, "Error");
            }
            
            return gen;
        }

        public static Images RecupImgCbx(int numGen, List<Images> lst)
        {
            Images img = new Images();

            try
            {
                foreach (Images i in lst)
                {
                    if (numGen == i.GetId())
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

        public static bool VerifFormatGen(String gen/*, string annee*/)
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
                    /*
                    foreach (Annee a in DBConst.lstSelectAnnee)
                    {
                        if (a.getNumAnnee().Equals(annee))
                            return true;
                    }
                    */
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

        public static bool GetValRadButton (RadioButton rdbTrue)
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

        public static bool VerifFormatAvoirType(Pokemon pkm, Types type)
        {
            foreach (AvoirType at in DBConst.lstSelectAvoirType)
            {
                if (at.GetPkmAvoirType().GetNumPokedexMondialPkm().Equals(pkm.GetNumPokedexMondialPkm()) == true && at.GetTypeAvoirType().GetIdType().Equals(type.GetIdType()) == true
                    && VerifInsertionSup2AvoirType(pkm) == true)
                {
                    return false;
                }
            }
            return true;
        }
        
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
                    foreach (Annee a in DBConst.lstSelectAnnee)
                    {
                        if (a.GetNumAnnee().Equals(sdrListe["annee"].ToString()) == true)
                            an = a;
                    }

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
                cbx.ValueMember = "num";
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

        #region Type
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
                    foreach (Generation g in DBConst.lstSelectGen)
                    {
                        if (g.GetNumGeneration().ToString().Equals(sdrListe["gen"].ToString()) == true)
                            gen = g;
                    }

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
        /*
        public static int recupMaxP1Types (List<Types> lst)
        {
            // declaration Liste int
            List<int> lstInt = new List<int>();

            foreach (Types t in lst)
            {
                lstInt.Add(t.getIdType());
            }

            if (lstInt.Count() > 0)
            {
                return lstInt.Max() + 1;
            }
            else
            {
                return 1;
            }
        }*/
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

                MessageBox.Show("recuperation Types reussie", "informations", MessageBoxButtons.OK);
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

        public static void RemplisCbxImg(ComboBox cbx)
        {
            #region remplissage cbx
            try
            {
/*                MySqlDataReader mdrListe = DBMySqlOutils.ExecuteReader(strReq);
                DataTable dt = new DataTable();
                dt.Load(mdrListe); */
                cbx.DataSource = DBConst.tabExtImg;
/*                cbx.DisplayMember = "lib";
                cbx.ValueMember = "num"; */
//                mdrListe.Close();
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

        public static void RemplisCbxUrlComp(ComboBox cbx)
        {
            #region remplissage cbx
            string requete = "CALL PROC_Select_cbx_img ()";
            try
            {
                MySqlDataReader mdrListe = DBMySqlOutils.ExecuteReader(requete);
                DataTable dt = new DataTable();
                dt.Load(mdrListe);
                cbx.DataSource = dt;
                cbx.DisplayMember = "url";
                cbx.ValueMember = "id";
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
                    MessageBox.Show("L'erreur suivante a été rencontré : " + e.Message);
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
                MessageBox.Show("L'erreur suivante a été rencontré : " + e.Message);
            }
            
        }
        #endregion

        #region Pokemon
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
                    foreach (Generation g in DBConst.lstSelectGen)
                    {
                        if (nG == g.GetNumGeneration())
                            gen = g;
                    }/*
                    MessageBox.Show("leg : " + sdrListe["legendaire"].ToString());

                    int leg = int.Parse(sdrListe["legendaire"].ToString());
                    */
                    bool legendPkm = bool.Parse(sdrListe["legendaire"].ToString());
 //                   MessageBox.Show("leg : " + legendPkm.ToString());
                    pkm = new Pokemon(sdrListe["num"].ToString(), sdrListe["nom"].ToString(), sdrListe["descr"].ToString(), legendPkm, img, gen);

                    lstPkm.Add(pkm);
                }
                sdrListe.Close();

                // Fermeture de la BDD
                DBMySqlOutils.MaDeconnexion();

                MessageBox.Show("recuperation Pokemon reussie", "informations", MessageBoxButtons.OK);
            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + probleme.Message);
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

                string requete = "CALL PROC_Insert_Pkm('" + numPkm + "', '" + nomPkm + "', '" + descPkm + "', " + img.GetId() + ", " + legendaire + ", " + gen.GetNumGeneration() + ")";

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

        #endregion

        #region AvoirType
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
                    foreach (Pokemon p in DBConst.lstSelectPkm)
                    {
                        if (pk == p.GetNumPokedexMondialPkm())
                            pkm = p;
                    }
                    int tp = int.Parse(sdrListe["code"].ToString());
                    foreach (Types t in DBConst.lstSelectType)
                    {
                        if (tp == t.GetIdType())
                            type = t;
                    }

                    avoirType = new AvoirType(pkm, type);

                    lstAT.Add(avoirType);
                }
                sdrListe.Close();

                // Fermeture de la BDD
                DBMySqlOutils.MaDeconnexion();

                MessageBox.Show("recuperation AvoirType reussie", "informations", MessageBoxButtons.OK);
            }
            catch (MySql.Data.MySqlClient.MySqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontré : " + probleme.Message);
            }

            return lstAT;
        }

        public static bool VerifInsertionSup2AvoirType (Pokemon pkm)
        {
            try
            {
                string requete = "CALL PROC_Select_Count_Avoir_Type_Pkm ('" + pkm.GetNumPokedexMondialPkm() + "')";
                
                int entier = DBMySqlOutils.ExecuteNonQuery(requete);

                if (entier < 2)
                {
                    return true;
                } else
                {
                    MessageBox.Show("Le Pokemon possede deja deux types il ne peut en avoir plus", "Impossibilite d'insertion");
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


        #endregion

        #region TypeEvolution

        #endregion

        #region Evolution

        #endregion
        #endregion
    }
}
