using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokedexClasses;
using System.Windows.Forms;
using Bulbi_dex.Controller;

namespace Bulbi_dex.Panel
{
    public partial class USC_Types : UserControl
    {
        private void RemplissLstBoxTypes(ListBox lbx, List<Types> lst)
        {
            // Supprime le contenu de la listeBox
            lbx.Items.Clear();

            lbx.Items.Add("****** Types ******");

            foreach (Types t in lst)
            {
                lbx.Items.Add(t.GetLibType().ToString());
            }

//            MessageBox.Show("remplissage finis", "informations", MessageBoxButtons.OK);
        }

        public USC_Types()
        {
            InitializeComponent();
        }

        private void USC_Types_Load(object sender, EventArgs e)
        {
            // Remplissage de la ListBox Types
            RemplissLstBoxTypes(LbxType, DBConst.lstSelectType);

            // Remplissage de la Cbx
            OutilsPkdx.RemplisCbxGen(cbxGenTypes);
        }

        private void BtnTypesValid_Click(object sender, EventArgs e)
        {
            if (OutilsPkdx.VerifFormatTypes(TbxTypes.Text) == true)
            {
                Generation gen = OutilsPkdx.ConvertGen(cbxGenTypes.SelectedValue.ToString(), DBConst.lstSelectGen);

                OutilsPkdx.CreatType(TbxTypes.Text, gen, DBConst.lstSelectType);

                // On recupere les Types dans la liste pour
                DBConst.lstSelectType = OutilsPkdx.RecupTypes();

                // Remplissage de la ListBox
                RemplissLstBoxTypes(LbxType, DBConst.lstSelectType);

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
