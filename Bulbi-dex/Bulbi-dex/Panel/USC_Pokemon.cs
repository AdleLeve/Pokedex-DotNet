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
    public partial class USC_Pokemon : UserControl
    {
        private void RemplissLstBoxPkm(ListBox lbx, List<Pokemon> lst)
        {
            // Supprime le contenu de la listeBox
            lbx.Items.Clear();

            lbx.Items.Add("****** Pokemon ******");

            foreach (Pokemon p in lst)
            {
                lbx.Items.Add(p.GetNumPokedexMondialPkm() + " / " + p.GetNomPokemon());
            }
//            MessageBox.Show("remplissage finis", "informations", MessageBoxButtons.OK);
        }

        public USC_Pokemon()
        {
            InitializeComponent();
        }

        private void BtnPkmValid_Click(object sender, EventArgs e)
        {
//            String desc = OutilsPkdx.FormeDescription(rtbDescText.Text);
            if (OutilsPkdx.VerifFormatPkm(mtbNumPkm.Text, TbxNomImg.Text, rtbDescText.Text) == true)
            {
                Generation gen = OutilsPkdx.ConvertGen(cbxGenPkm.SelectedValue.ToString(), DBConst.lstSelectGen);

                Images img = OutilsPkdx.ConvertImg(cbxUrlImg.SelectedValue.ToString(), DBConst.lstSelectImg);

                Pokemon p = OutilsPkdx.CreatPokemon(mtbNumPkm.Text.ToString(), TbxNomImg.Text.ToString(), rtbDescText.Text,
                    img, OutilsPkdx.GetValRadButton(rdbLegendaireTrue), gen,DBConst.lstSelectPkm);

                OutilsPkdx.InsertionAvoirType(rdb1AV, p.GetNumPokedexMondialPkm(), int.Parse(cbxType1.SelectedValue.ToString()),
                    int.Parse(cbxType2.SelectedValue.ToString()), DBConst.lstSelectType);

                // On recupere les Pokemon dans la liste pour
                DBConst.lstSelectPkm = OutilsPkdx.RecupPokemon();

                // Remplissage de la ListBox
                RemplissLstBoxPkm(LbxPkm, DBConst.lstSelectPkm);

                
                MessageBox.Show("Insertion Images réussie", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("format Images invalide ou année déjà présente", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("validation Images", "validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void USC_Pokemon_Load(object sender, EventArgs e)
        {
            // Instanciation de la visibilite des cbxType et de Checked Type
            rdb1AV.Checked = true;
            cbxType1.Visible = true;
            cbxType2.Visible = false;
            lblTypesPkmSelect1.Visible = false;
            lblTypesPkmSelect2.Visible = false;
            ckbTypes1.Visible = false;
            ckbTypes2.Visible = false;
            btnSuppAvoirType.Visible = false;
            BtnAjoutType.Visible = false;

            // Remplissage de la ListBox Pokemon
            RemplissLstBoxPkm(LbxPkm, DBConst.lstSelectPkm);

            // Remplissage de la Cbx Images
            OutilsPkdx.RemplisCbxUrlComp(cbxUrlImg);

            // Remplissage de la Cbx Generations
            OutilsPkdx.RemplisCbxGen(cbxGenPkm);

            // Remplissage de la Cbx Types 1
            OutilsPkdx.RemplisCbxType(cbxType1);

            // Remplissage de la Cbx Types 2
            OutilsPkdx.RemplisCbxType(cbxType2);

            // Instanciation du mode de Taille de la PictureBox
            ptbSelectPkm.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void CbxUrlImg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OutilsPkdx.AffImgSelectedValue(cbxUrlImg, ptbSelectPkm);
        }

        private void Rdb1AV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb1AV.Checked == true)
            {
                cbxType1.Visible = true;
                cbxType2.Visible = false;
            }
            else
            {
                cbxType1.Visible = true;
                cbxType2.Visible = true;
            }
        }

        private void LbxPkm_SelectedValueChanged(object sender, EventArgs e)
        {
            OutilsPkdx.SelectTypeLstBox(LbxPkm, lblTypesPkmSelect1, lblTypesPkmSelect2, ckbTypes1, ckbTypes2, BtnAjoutType, DBConst.lstSelectAvoirType, DBConst.lstSelectTypeLBX);
        }

        private void BtnSuppAvoirType_Click(object sender, EventArgs e)
        {
            int compt = 0;
            if (ckbTypes1.Checked == true)
            {
                compt += 1;
            }
            if (ckbTypes2.Checked == true)
            {
                compt += 1;
            }

            DialogResult result;
            result = MessageBox.Show("Êtes vous sûr de vouloir supprimer " + compt + " élèments", "Verification suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            { //Supprssion si Oui
                OutilsPkdx.SuppressionAvoirType(ckbTypes1, ckbTypes2, lblTypesPkmSelect1, lblTypesPkmSelect2, LbxPkm, DBConst.lstSelectAvoirType, BtnAjoutType);
            }
        }

        private void CkbTypes1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTypes1.Checked == false && ckbTypes2.Checked == false)
            {
                btnSuppAvoirType.Visible = false;
            } else
            {
                btnSuppAvoirType.Visible = true;
            }
        }

        private void CkbTypes2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTypes1.Checked == false && ckbTypes2.Checked == false)
            {
                btnSuppAvoirType.Visible = false;
            }
            else
            {
                btnSuppAvoirType.Visible = true;
            }
        }

        private void BtnAjoutType_Click(object sender, EventArgs e)
        {
            int compteur;
            if(rdb1AV.Checked == true)
            {
                compteur = 1;
            } else 
            {
                compteur = 2;
            }
            string numPkm = LbxPkm.SelectedItem.ToString().Substring(0, 3);
//            MessageBox.Show("Le Type est : " + cbxType1.SelectedValue.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (OutilsPkdx.VerifInsertionSup2AvoirType(numPkm, compteur) == true)
            {
                OutilsPkdx.InsertionAvoirType(rdb1AV, numPkm, int.Parse(cbxType1.SelectedValue.ToString()), int.Parse(cbxType2.SelectedValue.ToString()), DBConst.lstSelectType);
            }
            else
            {
                MessageBox.Show("Impossible de rentrer plus de 2 types", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
