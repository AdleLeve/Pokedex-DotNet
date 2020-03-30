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

        private void BtnImgValid_Click(object sender, EventArgs e)
        {
            if (OutilsPkdx.VerifFormatPkm(mtbNumPkm.Text, TbxNomImg.Text, rtbDescText.Text) == true)
            {
                Generation gen = OutilsPkdx.RecupGenCbx(int.Parse(cbxGenPkm.SelectedValue.ToString()), DBConst.lstSelectGen);

                Images img = OutilsPkdx.RecupImgCbx(int.Parse(cbxUrlImg.SelectedValue.ToString()), DBConst.lstSelectImg);

                OutilsPkdx.CreatPokemon(mtbNumPkm.Text.ToString(), TbxNomImg.Text.ToString(), rtbDescText.Text.ToString(),
                    img, OutilsPkdx.GetValRadButton(rdbLegendaireTrue), gen,DBConst.lstSelectPkm);

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
            // Remplissage de la ListBox Pokemon
            RemplissLstBoxPkm(LbxPkm, DBConst.lstSelectPkm);

            // Remplissage de la Cbx Images
            OutilsPkdx.RemplisCbxUrlComp(cbxUrlImg);

            // Remplissage de la Cbx Generations
            OutilsPkdx.RemplisCbxGen(cbxGenPkm);

            // Instanciation du mode de Taille de la PictureBox
            ptbSelectPkm.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void CbxExtImg_SelectedValueChanged(object sender, EventArgs e)
        {
            OutilsPkdx.AffImgSelectedValue(LbxPkm, ptbSelectPkm);
        }
    }
}
