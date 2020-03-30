namespace Bulbi_dex
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.BtnEvolution = new System.Windows.Forms.Button();
            this.BtnPokemon = new System.Windows.Forms.Button();
            this.BtnImages = new System.Windows.Forms.Button();
            this.BtnType = new System.Windows.Forms.Button();
            this.BtnGeneration = new System.Windows.Forms.Button();
            this.LblMenu = new System.Windows.Forms.Label();
            this.PtbImg = new System.Windows.Forms.PictureBox();
            this.usc_AnnGen = new Bulbi_dex.Panel.USC_AnneeGeneration();
            this.usc_Evol = new Bulbi_dex.Panel.USC_Evolutions();
            this.usc_Img = new Bulbi_dex.Panel.USC_Images();
            this.usc_Pkm = new Bulbi_dex.Panel.USC_Pokemon();
            this.usc_Types = new Bulbi_dex.Panel.USC_Types();
            this.PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.Color.Red;
            this.PnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlMenu.Controls.Add(this.BtnQuit);
            this.PnlMenu.Controls.Add(this.BtnEvolution);
            this.PnlMenu.Controls.Add(this.BtnPokemon);
            this.PnlMenu.Controls.Add(this.BtnImages);
            this.PnlMenu.Controls.Add(this.BtnType);
            this.PnlMenu.Controls.Add(this.BtnGeneration);
            this.PnlMenu.Controls.Add(this.LblMenu);
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(200, 527);
            this.PnlMenu.TabIndex = 1;
            this.PnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMenu_Paint);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(32, 17);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(75, 23);
            this.BtnQuit.TabIndex = 10;
            this.BtnQuit.Text = "Quitter";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // BtnEvolution
            // 
            this.BtnEvolution.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnEvolution.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEvolution.FlatAppearance.BorderSize = 2;
            this.BtnEvolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEvolution.Font = new System.Drawing.Font("Scheherazade", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEvolution.ForeColor = System.Drawing.Color.Black;
            this.BtnEvolution.Location = new System.Drawing.Point(42, 451);
            this.BtnEvolution.Name = "BtnEvolution";
            this.BtnEvolution.Size = new System.Drawing.Size(157, 55);
            this.BtnEvolution.TabIndex = 9;
            this.BtnEvolution.Text = "Évolutions";
            this.BtnEvolution.UseVisualStyleBackColor = false;
            this.BtnEvolution.Click += new System.EventHandler(this.BtnEvolution_Click);
            // 
            // BtnPokemon
            // 
            this.BtnPokemon.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnPokemon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnPokemon.FlatAppearance.BorderSize = 2;
            this.BtnPokemon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPokemon.Font = new System.Drawing.Font("Scheherazade", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPokemon.ForeColor = System.Drawing.Color.Black;
            this.BtnPokemon.Location = new System.Drawing.Point(42, 376);
            this.BtnPokemon.Name = "BtnPokemon";
            this.BtnPokemon.Size = new System.Drawing.Size(157, 55);
            this.BtnPokemon.TabIndex = 8;
            this.BtnPokemon.Text = "Pokemon";
            this.BtnPokemon.UseVisualStyleBackColor = false;
            this.BtnPokemon.Click += new System.EventHandler(this.BtnPokemon_Click);
            // 
            // BtnImages
            // 
            this.BtnImages.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnImages.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnImages.FlatAppearance.BorderSize = 2;
            this.BtnImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImages.Font = new System.Drawing.Font("Scheherazade", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImages.ForeColor = System.Drawing.Color.Black;
            this.BtnImages.Location = new System.Drawing.Point(42, 297);
            this.BtnImages.Name = "BtnImages";
            this.BtnImages.Size = new System.Drawing.Size(157, 55);
            this.BtnImages.TabIndex = 6;
            this.BtnImages.Text = "Images";
            this.BtnImages.UseVisualStyleBackColor = false;
            this.BtnImages.Click += new System.EventHandler(this.BtnImages_Click);
            // 
            // BtnType
            // 
            this.BtnType.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnType.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnType.FlatAppearance.BorderSize = 2;
            this.BtnType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnType.Font = new System.Drawing.Font("Scheherazade", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnType.ForeColor = System.Drawing.Color.Black;
            this.BtnType.Location = new System.Drawing.Point(42, 218);
            this.BtnType.Name = "BtnType";
            this.BtnType.Size = new System.Drawing.Size(157, 55);
            this.BtnType.TabIndex = 5;
            this.BtnType.Text = "Types";
            this.BtnType.UseVisualStyleBackColor = false;
            this.BtnType.Click += new System.EventHandler(this.BtnType_Click);
            // 
            // BtnGeneration
            // 
            this.BtnGeneration.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnGeneration.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGeneration.FlatAppearance.BorderSize = 2;
            this.BtnGeneration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeneration.Font = new System.Drawing.Font("Scheherazade", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeneration.ForeColor = System.Drawing.Color.Black;
            this.BtnGeneration.Location = new System.Drawing.Point(42, 141);
            this.BtnGeneration.Name = "BtnGeneration";
            this.BtnGeneration.Size = new System.Drawing.Size(157, 55);
            this.BtnGeneration.TabIndex = 4;
            this.BtnGeneration.Text = "Générations";
            this.BtnGeneration.UseVisualStyleBackColor = false;
            this.BtnGeneration.Click += new System.EventHandler(this.BtnGeneration_Click);
            // 
            // LblMenu
            // 
            this.LblMenu.AutoSize = true;
            this.LblMenu.Font = new System.Drawing.Font("Mongolian Baiti", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenu.Location = new System.Drawing.Point(-1, 68);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(200, 19);
            this.LblMenu.TabIndex = 2;
            this.LblMenu.Text = "Choisir l\'action à faire:";
            // 
            // PtbImg
            // 
            this.PtbImg.BackColor = System.Drawing.Color.White;
            this.PtbImg.BackgroundImage = global::Bulbi_dex.Properties.Resources.artworkpkdxb;
            this.PtbImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PtbImg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PtbImg.InitialImage = null;
            this.PtbImg.Location = new System.Drawing.Point(199, 0);
            this.PtbImg.Name = "PtbImg";
            this.PtbImg.Size = new System.Drawing.Size(600, 145);
            this.PtbImg.TabIndex = 0;
            this.PtbImg.TabStop = false;
            // 
            // usc_AnnGen
            // 
            this.usc_AnnGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.usc_AnnGen.Location = new System.Drawing.Point(199, 142);
            this.usc_AnnGen.Name = "usc_AnnGen";
            this.usc_AnnGen.Size = new System.Drawing.Size(600, 385);
            this.usc_AnnGen.TabIndex = 2;
            // 
            // usc_Evol
            // 
            this.usc_Evol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.usc_Evol.Location = new System.Drawing.Point(201, 145);
            this.usc_Evol.Name = "usc_Evol";
            this.usc_Evol.Size = new System.Drawing.Size(600, 385);
            this.usc_Evol.TabIndex = 3;
            // 
            // usc_Img
            // 
            this.usc_Img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.usc_Img.Location = new System.Drawing.Point(199, 142);
            this.usc_Img.Name = "usc_Img";
            this.usc_Img.Size = new System.Drawing.Size(600, 385);
            this.usc_Img.TabIndex = 4;
            // 
            // usc_Pkm
            // 
            this.usc_Pkm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.usc_Pkm.Location = new System.Drawing.Point(200, 143);
            this.usc_Pkm.Name = "usc_Pkm";
            this.usc_Pkm.Size = new System.Drawing.Size(600, 385);
            this.usc_Pkm.TabIndex = 5;
            // 
            // usc_Types
            // 
            this.usc_Types.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.usc_Types.Location = new System.Drawing.Point(199, 143);
            this.usc_Types.Name = "usc_Types";
            this.usc_Types.Size = new System.Drawing.Size(600, 385);
            this.usc_Types.TabIndex = 6;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.usc_AnnGen);
            this.Controls.Add(this.PnlMenu);
            this.Controls.Add(this.PtbImg);
            this.Controls.Add(this.usc_Types);
            this.Controls.Add(this.usc_Pkm);
            this.Controls.Add(this.usc_Img);
            this.Controls.Add(this.usc_Evol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Bulbi-Dex";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlMenu.ResumeLayout(false);
            this.PnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PtbImg;
        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.Button BtnEvolution;
        private System.Windows.Forms.Button BtnPokemon;
        private System.Windows.Forms.Button BtnImages;
        private System.Windows.Forms.Button BtnType;
        private System.Windows.Forms.Button BtnGeneration;
        private System.Windows.Forms.Button BtnQuit;
        private Panel.USC_AnneeGeneration usc_AnnGen;
        private Panel.USC_Evolutions usc_Evol;
        private Panel.USC_Images usc_Img;
        private Panel.USC_Pokemon usc_Pkm;
        private Panel.USC_Types usc_Types;
    }
}

