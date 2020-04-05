namespace Bulbi_dex.Panel
{
    partial class USC_Evolutions
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlTypes = new System.Windows.Forms.Panel();
            this.BtnTypeEvolutionValid = new System.Windows.Forms.Button();
            this.dtgEvolutions = new System.Windows.Forms.DataGridView();
            this.cbxSurEvol = new System.Windows.Forms.ComboBox();
            this.cbxSousEvol = new System.Windows.Forms.ComboBox();
            this.lblPkmSurText = new System.Windows.Forms.Label();
            this.lblPkmSousText = new System.Windows.Forms.Label();
            this.lblLibTypeEvoText = new System.Windows.Forms.Label();
            this.lblTypeEvolEvolText = new System.Windows.Forms.Label();
            this.cbxTypeEvolution = new System.Windows.Forms.ComboBox();
            this.TbxNomTypeEvol = new System.Windows.Forms.TextBox();
            this.LbxTypeEvol = new System.Windows.Forms.ListBox();
            this.BtnEvolutionValid = new System.Windows.Forms.Button();
            this.PnlTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEvolutions)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTypes
            // 
            this.PnlTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlTypes.Controls.Add(this.BtnTypeEvolutionValid);
            this.PnlTypes.Controls.Add(this.dtgEvolutions);
            this.PnlTypes.Controls.Add(this.cbxSurEvol);
            this.PnlTypes.Controls.Add(this.cbxSousEvol);
            this.PnlTypes.Controls.Add(this.lblPkmSurText);
            this.PnlTypes.Controls.Add(this.lblPkmSousText);
            this.PnlTypes.Controls.Add(this.lblLibTypeEvoText);
            this.PnlTypes.Controls.Add(this.lblTypeEvolEvolText);
            this.PnlTypes.Controls.Add(this.cbxTypeEvolution);
            this.PnlTypes.Controls.Add(this.TbxNomTypeEvol);
            this.PnlTypes.Controls.Add(this.LbxTypeEvol);
            this.PnlTypes.Controls.Add(this.BtnEvolutionValid);
            this.PnlTypes.Location = new System.Drawing.Point(3, 4);
            this.PnlTypes.Name = "PnlTypes";
            this.PnlTypes.Size = new System.Drawing.Size(594, 376);
            this.PnlTypes.TabIndex = 14;
            // 
            // BtnTypeEvolutionValid
            // 
            this.BtnTypeEvolutionValid.BackColor = System.Drawing.Color.White;
            this.BtnTypeEvolutionValid.Font = new System.Drawing.Font("Noto Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTypeEvolutionValid.Location = new System.Drawing.Point(6, 52);
            this.BtnTypeEvolutionValid.Name = "BtnTypeEvolutionValid";
            this.BtnTypeEvolutionValid.Size = new System.Drawing.Size(83, 28);
            this.BtnTypeEvolutionValid.TabIndex = 30;
            this.BtnTypeEvolutionValid.Text = "Valider";
            this.BtnTypeEvolutionValid.UseVisualStyleBackColor = false;
            this.BtnTypeEvolutionValid.Click += new System.EventHandler(this.BtnTypeEvolutionValid_Click);
            // 
            // dtgEvolutions
            // 
            this.dtgEvolutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEvolutions.Location = new System.Drawing.Point(95, 188);
            this.dtgEvolutions.Name = "dtgEvolutions";
            this.dtgEvolutions.Size = new System.Drawing.Size(484, 183);
            this.dtgEvolutions.TabIndex = 29;
            // 
            // cbxSurEvol
            // 
            this.cbxSurEvol.FormattingEnabled = true;
            this.cbxSurEvol.Location = new System.Drawing.Point(205, 128);
            this.cbxSurEvol.Name = "cbxSurEvol";
            this.cbxSurEvol.Size = new System.Drawing.Size(170, 21);
            this.cbxSurEvol.TabIndex = 28;
            // 
            // cbxSousEvol
            // 
            this.cbxSousEvol.FormattingEnabled = true;
            this.cbxSousEvol.Location = new System.Drawing.Point(3, 128);
            this.cbxSousEvol.Name = "cbxSousEvol";
            this.cbxSousEvol.Size = new System.Drawing.Size(170, 21);
            this.cbxSousEvol.TabIndex = 27;
            // 
            // lblPkmSurText
            // 
            this.lblPkmSurText.AutoSize = true;
            this.lblPkmSurText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkmSurText.Location = new System.Drawing.Point(205, 108);
            this.lblPkmSurText.Name = "lblPkmSurText";
            this.lblPkmSurText.Size = new System.Drawing.Size(184, 17);
            this.lblPkmSurText.TabIndex = 26;
            this.lblPkmSurText.Text = "Choisir le Pokemon Evolué :";
            // 
            // lblPkmSousText
            // 
            this.lblPkmSousText.AutoSize = true;
            this.lblPkmSousText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkmSousText.Location = new System.Drawing.Point(3, 108);
            this.lblPkmSousText.Name = "lblPkmSousText";
            this.lblPkmSousText.Size = new System.Drawing.Size(196, 17);
            this.lblPkmSousText.TabIndex = 20;
            this.lblPkmSousText.Text = "Choisir le Pokemon Evoluant :";
            // 
            // lblLibTypeEvoText
            // 
            this.lblLibTypeEvoText.AutoSize = true;
            this.lblLibTypeEvoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibTypeEvoText.Location = new System.Drawing.Point(3, 6);
            this.lblLibTypeEvoText.Name = "lblLibTypeEvoText";
            this.lblLibTypeEvoText.Size = new System.Drawing.Size(376, 17);
            this.lblLibTypeEvoText.TabIndex = 17;
            this.lblLibTypeEvoText.Text = "Inscrire le libelle du Type d\'Evolution : (30 caractères max)";
            // 
            // lblTypeEvolEvolText
            // 
            this.lblTypeEvolEvolText.AutoSize = true;
            this.lblTypeEvolEvolText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeEvolEvolText.Location = new System.Drawing.Point(3, 162);
            this.lblTypeEvolEvolText.Name = "lblTypeEvolEvolText";
            this.lblTypeEvolEvolText.Size = new System.Drawing.Size(188, 17);
            this.lblTypeEvolEvolText.TabIndex = 16;
            this.lblTypeEvolEvolText.Text = "Choisir un Type d\'Evolution :";
            // 
            // cbxTypeEvolution
            // 
            this.cbxTypeEvolution.FormattingEnabled = true;
            this.cbxTypeEvolution.Location = new System.Drawing.Point(197, 161);
            this.cbxTypeEvolution.Name = "cbxTypeEvolution";
            this.cbxTypeEvolution.Size = new System.Drawing.Size(170, 21);
            this.cbxTypeEvolution.TabIndex = 12;
            // 
            // TbxNomTypeEvol
            // 
            this.TbxNomTypeEvol.Location = new System.Drawing.Point(3, 26);
            this.TbxNomTypeEvol.Name = "TbxNomTypeEvol";
            this.TbxNomTypeEvol.Size = new System.Drawing.Size(255, 20);
            this.TbxNomTypeEvol.TabIndex = 4;
            // 
            // LbxTypeEvol
            // 
            this.LbxTypeEvol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LbxTypeEvol.FormattingEnabled = true;
            this.LbxTypeEvol.Location = new System.Drawing.Point(397, 3);
            this.LbxTypeEvol.Name = "LbxTypeEvol";
            this.LbxTypeEvol.Size = new System.Drawing.Size(192, 160);
            this.LbxTypeEvol.TabIndex = 3;
            // 
            // BtnEvolutionValid
            // 
            this.BtnEvolutionValid.BackColor = System.Drawing.Color.White;
            this.BtnEvolutionValid.Font = new System.Drawing.Font("Noto Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEvolutionValid.Location = new System.Drawing.Point(6, 210);
            this.BtnEvolutionValid.Name = "BtnEvolutionValid";
            this.BtnEvolutionValid.Size = new System.Drawing.Size(83, 28);
            this.BtnEvolutionValid.TabIndex = 2;
            this.BtnEvolutionValid.Text = "Valider";
            this.BtnEvolutionValid.UseVisualStyleBackColor = false;
            this.BtnEvolutionValid.Click += new System.EventHandler(this.BtnEvolutionValid_Click);
            // 
            // USC_Evolutions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.PnlTypes);
            this.Name = "USC_Evolutions";
            this.Size = new System.Drawing.Size(600, 385);
            this.Load += new System.EventHandler(this.USC_Evolutions_Load);
            this.PnlTypes.ResumeLayout(false);
            this.PnlTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEvolutions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTypes;
        private System.Windows.Forms.ComboBox cbxSurEvol;
        private System.Windows.Forms.ComboBox cbxSousEvol;
        private System.Windows.Forms.Label lblPkmSurText;
        private System.Windows.Forms.Label lblPkmSousText;
        private System.Windows.Forms.Label lblLibTypeEvoText;
        private System.Windows.Forms.Label lblTypeEvolEvolText;
        private System.Windows.Forms.ComboBox cbxTypeEvolution;
        private System.Windows.Forms.TextBox TbxNomTypeEvol;
        private System.Windows.Forms.ListBox LbxTypeEvol;
        private System.Windows.Forms.Button BtnEvolutionValid;
        private System.Windows.Forms.DataGridView dtgEvolutions;
        private System.Windows.Forms.Button BtnTypeEvolutionValid;
    }
}
