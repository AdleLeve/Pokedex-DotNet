using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokedexClasses;
using Bulbi_dex.Controller;

namespace Bulbi_dex
{
    public partial class FrmPrincipal : Form
    {
        
        public FrmPrincipal()
        {
            InitializeComponent();

            // On ajoute les differents USC a lstUSC
            DBConst.lstUSC.Add(usc_AnnGen);
            DBConst.lstUSC.Add(usc_Types);
            DBConst.lstUSC.Add(usc_Img);
            DBConst.lstUSC.Add(usc_Pkm);
            DBConst.lstUSC.Add(usc_Evol);

            // On cache la visbilite des USC
            OutilsPkdx.VisibiliteUSC(DBConst.lstUSC);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // On ajoute les differents Btn a lstBtn
            DBConst.lstBtn.Add(BtnEvolution);
            DBConst.lstBtn.Add(BtnGeneration);
            DBConst.lstBtn.Add(BtnImages);
            DBConst.lstBtn.Add(BtnPokemon);
            DBConst.lstBtn.Add(BtnType);

            // On charge les couleurs des Bouttons
            OutilsPkdx.ColorBtn(DBConst.lstBtn);
        }

        private void PnlMenu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGeneration_Click(object sender, EventArgs e)
        {
            // On recupere les Annees dans la liste pour
            DBConst.lstSelectAnnee = OutilsPkdx.RecupAnnee();

            // On recupere les Generations dans la liste pour
            DBConst.lstSelectGen = OutilsPkdx.RecupGeneration();

            // On fait passer la visibilite de usc_AnnGen a true
            OutilsPkdx.VisibiliteUSC(DBConst.lstUSC, usc_AnnGen);

            // On change les couleurs des Bouttons
            OutilsPkdx.ColorBtn(DBConst.lstBtn, BtnGeneration);
        }

        private void BtnType_Click(object sender, EventArgs e)
        {
            // On recupere les Annees dans la liste pour
            DBConst.lstSelectType = OutilsPkdx.RecupTypes();

            // On recupere les Generations dans la liste pour
            DBConst.lstSelectGen = OutilsPkdx.RecupGeneration();

            // On fait passer la visibilite de usc_Types a true
            OutilsPkdx.VisibiliteUSC(DBConst.lstUSC, usc_Types);

            // On change les couleurs des Bouttons
            OutilsPkdx.ColorBtn(DBConst.lstBtn, BtnType);
        }

        private void BtnImages_Click(object sender, EventArgs e)
        {
            // On recupere les Images dans la liste pour
            DBConst.lstSelectImg = OutilsPkdx.RecupImages();

            // On fait passer la visibilite de usc_Img a true
            OutilsPkdx.VisibiliteUSC(DBConst.lstUSC, usc_Img);

            // On change les couleurs des Bouttons
            OutilsPkdx.ColorBtn(DBConst.lstBtn, BtnImages);
        }

        private void BtnPokemon_Click(object sender, EventArgs e)
        {
            // On fait passer la visibilite de usc_Pkm a true
            OutilsPkdx.VisibiliteUSC(DBConst.lstUSC, usc_Pkm);

            // On recupere les Pokemon dans la liste pour
            DBConst.lstSelectPkm = OutilsPkdx.RecupPokemon();

            // On change les couleurs des Bouttons
            OutilsPkdx.ColorBtn(DBConst.lstBtn, BtnPokemon);
        }

        private void BtnEvolution_Click(object sender, EventArgs e)
        {
            // On fait passer la visibilite de usc_Evol a true
            OutilsPkdx.VisibiliteUSC(DBConst.lstUSC, usc_Evol);

            // On change les couleurs des Bouttons
            OutilsPkdx.ColorBtn(DBConst.lstBtn, BtnEvolution);
        }
    }
}
