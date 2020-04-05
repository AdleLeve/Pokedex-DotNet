using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokedexClasses;
using Bulbi_dex.Controller;

namespace Bulbi_dex.Panel
{
    public partial class USC_AnneeGeneration : UserControl
    {
        private void RemplissLstBoxAnnee(ListBox lbx, List<Annee> lstAn)
        {
            // Supprime le contenu de la listeBox
            lbx.Items.Clear();
            
            lbx.Items.Add("****** Annees ******");

            foreach (Annee annee in lstAn)
            {
                lbx.Items.Add(annee.GetNumAnnee().ToString());
            }

 //           MessageBox.Show("remplissage finis", "informations", MessageBoxButtons.OK);
        }

        private void RemplissLstBoxGen(ListBox lbx, List<Generation> lst)
        {
            // Supprime le contenu de la listeBox
            lbx.Items.Clear();

            lbx.Items.Add("****** Generation ******");

            foreach (Generation g in lst)
            {
                lbx.Items.Add(g.GetLibGeneration());
            }

 //           MessageBox.Show("remplissage finis", "informations", MessageBoxButtons.OK);
        }

        public USC_AnneeGeneration()
        {
            InitializeComponent();
        }

        private void USC_AnneeGeneration_Load(object sender, EventArgs e)
        {
            
            // Remplissage de la ListBox Annees
            RemplissLstBoxAnnee(LbxAnnees, DBConst.lstSelectAnnee);

            // Remplissage de la ListBox Generation
            RemplissLstBoxGen(LbxGen, DBConst.lstSelectGen);

            // Remplissage de la Cbx
            OutilsPkdx.RemplisCbxAnnee(CbxAnnGen);
        }

        private void BtnAnneeValid_Click(object sender, EventArgs e)
        {
            if (OutilsPkdx.VerifFormatAnnee(MtbAnnee.Text) == true)
            {
                OutilsPkdx.CreatAnnee(MtbAnnee.Text, DBConst.lstSelectAnnee);

                // On recupere les Annees dans la liste pour
                DBConst.lstSelectAnnee = OutilsPkdx.RecupAnnee();

                // Remplissage de la ListBox
                RemplissLstBoxAnnee(LbxAnnees, DBConst.lstSelectAnnee);

                // Remplissage de la Cbx
                OutilsPkdx.RemplisCbxAnnee(CbxAnnGen);

                MessageBox.Show("Insertion année réussie", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("format Année invalide ou année déjà présente", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGenValid_Click(object sender, EventArgs e)
        {
            if (OutilsPkdx.VerifFormatGen(MtbNumGen.Text) == true)
            {
                Annee an = OutilsPkdx.ConvertAnnee(CbxAnnGen.SelectedValue.ToString(), DBConst.lstSelectAnnee);

                OutilsPkdx.CreatGen(int.Parse(MtbNumGen.Text), an, DBConst.lstSelectGen);

                // On recupere les Generations dans la liste pour
                DBConst.lstSelectGen = OutilsPkdx.RecupGeneration();

                // Remplissage de la ListBox
                RemplissLstBoxGen(LbxGen, DBConst.lstSelectGen);

                MessageBox.Show("Insertion année réussie", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("format Année invalide ou année déjà présente", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("validation Génération", "validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
