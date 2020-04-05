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
    public partial class USC_Evolutions : UserControl
    {
        private void RemplissLstBoxTypeEvo(ListBox lbx, List<TypeEvolution> lst)
        {
            // Declarations Objets 
//            Pokemon pSous = new Pokemon();
//            Pokemon pSur = new Pokemon();

            // Supprime le contenu de la listeBox
            lbx.Items.Clear();

            lbx.Items.Add("****** Type d'Evolution ******");

//            MessageBox.Show("Il y a : " + lst.Count + " Objets dans la liste", "Information TypeEvolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            foreach (TypeEvolution te in lst)
            {
//                pSous = OutilsPkdx.ConvertPokemon(te.)

                lbx.Items.Add(te.GetLibelleTypeEvol());
            }

        }

        public USC_Evolutions()
        {
            InitializeComponent();
        }

        private void USC_Evolutions_Load(object sender, EventArgs e)
        {
            // Remplissage de la ListBox TypeEvolution
            RemplissLstBoxTypeEvo(LbxTypeEvol, DBConst.lstSelectTypeEvo);

            // Remplissage de la Cbx Pokemon sous Evolution
            OutilsPkdx.RemplisCbxPokemon(cbxSousEvol);

            // Remplissage de la Cbx Pokemon sur Evolution
            OutilsPkdx.RemplisCbxPokemon(cbxSurEvol);

            // Remplissage de la Cbx TypeEvolution
            OutilsPkdx.RemplisCbxTypeEvo(cbxTypeEvolution);

            // Remplissage de la Dtg 
            OutilsPkdx.RemplisDtgEvo(dtgEvolutions);
        }

        private void BtnTypeEvolutionValid_Click(object sender, EventArgs e)
        {
            if (OutilsPkdx.VerifFormatTypeEvol(TbxNomTypeEvol.Text, DBConst.lstSelectTypeEvo) == true)
            {
                // Creation de l'objet 'TypeEvolution' a partir du libelle donne par l'utilisateur a partir du TextBox fait pour et insertion a la BDD
                OutilsPkdx.CreatTypeEvolution(TbxNomTypeEvol.Text, DBConst.lstSelectTypeEvo);

                // Actualisation de la ListBox
                RemplissLstBoxTypeEvo(LbxTypeEvol, DBConst.lstSelectTypeEvo);

                MessageBox.Show("Insertion TypeEvolution réussie", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("format TypeEvolution invalide ou TypeEvolution déjà présente", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("validation TypeEvolution", "validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEvolutionValid_Click(object sender, EventArgs e)
        {
            // Recuperation du Pokemon 'evoluant'
            Pokemon evoluant = OutilsPkdx.ConvertPokemon(cbxSousEvol.SelectedValue.ToString());

            // Recuperation du Pokemon 'evolue'
            Pokemon evolue = OutilsPkdx.ConvertPokemon(cbxSurEvol.SelectedValue.ToString());

//            MessageBox.Show("Evolant : " + cbxSousEvol.SelectedValue.ToString() + " /nEvolué : " + cbxSurEvol.SelectedValue.ToString(), "évolué/évoluant", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            MessageBox.Show("Evolant : " + evoluant.GetNomPokemon() + " /nEvolué : " + evolue.GetNomPokemon(), "évolué/évoluant", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Control du format du futur libelle de l'objet 'Evolution'
            if (OutilsPkdx.VerifFormatEvol(evoluant, evolue, DBConst.lstSelectEvo) == true)
            {
                // Recuperation de l'objet 'TypeEvolution'
                TypeEvolution typeEvolution = OutilsPkdx.ConvertTypeEvo(int.Parse(cbxTypeEvolution.SelectedValue.ToString()), null, DBConst.lstSelectTypeEvo);

                // Creation de l'objet 'Evolution' a partir des parametres recuperes par les Cbx et insertion a la BDD
                OutilsPkdx.CreatEvolution(evoluant, evolue, typeEvolution, DBConst.lstSelectEvo);

                // On recupere les Pokemon dans la liste pour
                DBConst.lstSelectPkm = OutilsPkdx.RecupPokemon();

                // Actualisation de la DataGridView
                OutilsPkdx.RemplisDtgEvo(dtgEvolutions);

                MessageBox.Show("Insertion Evolution réussie", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("format Evolution invalide ou Evolution déjà présente", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("validation Evolution", "validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
