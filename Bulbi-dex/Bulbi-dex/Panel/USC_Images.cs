using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bulbi_dex.Controller;
using PokedexClasses;

namespace Bulbi_dex.Panel
{
    public partial class USC_Images : UserControl
    {
        private void RemplissLstBoxImg(ListBox lbx, List<Images> lst)
        {
            // Supprime le contenu de la listeBox
            lbx.Items.Clear();

            lbx.Items.Add("****** Images ******");

            foreach (Images i in lst)
            {
                lbx.Items.Add(i.GetUrlComplete());
            }

//            MessageBox.Show("remplissage finis", "informations", MessageBoxButtons.OK);
        }

        public USC_Images()
        {
            InitializeComponent();
        }

        private void USC_Images_Load(object sender, EventArgs e)
        {
            // Remplissage de la ListBox Images
            RemplissLstBoxImg(LbxImg, DBConst.lstSelectImg);

            // Remplissage de la DataGridView Image/Pokemon
            OutilsPkdx.RemplisDtgImg(dtgPkmImg);

            // Remplissage de la Cbx
            OutilsPkdx.RemplisCbxImg(cbxExtImg);

            // Instanciation du mode de Taille de la PictureBox
            ptbSelectImg.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void BtnImgValid_Click(object sender, EventArgs e)
        {
            if (OutilsPkdx.VerifFormatImg(TbxUrlImg.Text, cbxExtImg.SelectedValue.ToString()) == true)
            {
                OutilsPkdx.CreatImages(TbxUrlImg.Text, cbxExtImg.SelectedValue.ToString(), DBConst.lstSelectImg);

                // On recupere les Images dans la liste pour
                DBConst.lstSelectImg = OutilsPkdx.RecupImages();

                // Remplissage de la ListBox
                RemplissLstBoxImg(LbxImg, DBConst.lstSelectImg);

                // Remplissage de la DataGridView
                OutilsPkdx.RemplisDtgImg(dtgPkmImg);

                MessageBox.Show("Insertion Images réussie", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("format Images invalide ou année déjà présente", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("validation Images", "validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LbxImg_SelectedValueChanged(object sender, EventArgs e)
        {
//            MessageBox.Show("Lbx 0 = " + LbxImg.GetSelected(0).ToString(), "Verification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OutilsPkdx.AffImgSelectedValue(LbxImg, ptbSelectImg);
        }

        private void DtgPkmImg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OutilsPkdx.AffImgSelectedValue(dtgPkmImg, ptbSelectImg);
        }

        private void DtgPkmImg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OutilsPkdx.AffImgSelectedValue(dtgPkmImg, ptbSelectImg);
        }
    }
}
