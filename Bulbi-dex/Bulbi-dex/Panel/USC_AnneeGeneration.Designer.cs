namespace Bulbi_dex.Panel
{
    partial class USC_AnneeGeneration
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
            this.PnlGen = new System.Windows.Forms.Panel();
            this.LbxGen = new System.Windows.Forms.ListBox();
            this.CbxAnnGen = new System.Windows.Forms.ComboBox();
            this.MtbNumGen = new System.Windows.Forms.MaskedTextBox();
            this.BtnGenValid = new System.Windows.Forms.Button();
            this.PnlAnnee = new System.Windows.Forms.Panel();
            this.LbxAnnees = new System.Windows.Forms.ListBox();
            this.MtbAnnee = new System.Windows.Forms.MaskedTextBox();
            this.BtnAnneeValid = new System.Windows.Forms.Button();
            this.PnlGen.SuspendLayout();
            this.PnlAnnee.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlGen
            // 
            this.PnlGen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlGen.Controls.Add(this.LbxGen);
            this.PnlGen.Controls.Add(this.CbxAnnGen);
            this.PnlGen.Controls.Add(this.MtbNumGen);
            this.PnlGen.Controls.Add(this.BtnGenValid);
            this.PnlGen.Location = new System.Drawing.Point(9, 182);
            this.PnlGen.Name = "PnlGen";
            this.PnlGen.Size = new System.Drawing.Size(581, 197);
            this.PnlGen.TabIndex = 11;
            // 
            // LbxGen
            // 
            this.LbxGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LbxGen.FormattingEnabled = true;
            this.LbxGen.Location = new System.Drawing.Point(237, 6);
            this.LbxGen.Name = "LbxGen";
            this.LbxGen.Size = new System.Drawing.Size(149, 186);
            this.LbxGen.TabIndex = 6;
            // 
            // CbxAnnGen
            // 
            this.CbxAnnGen.Font = new System.Drawing.Font("Noto Serif", 12F, System.Drawing.FontStyle.Bold);
            this.CbxAnnGen.FormattingEnabled = true;
            this.CbxAnnGen.Location = new System.Drawing.Point(3, 53);
            this.CbxAnnGen.Name = "CbxAnnGen";
            this.CbxAnnGen.Size = new System.Drawing.Size(68, 30);
            this.CbxAnnGen.TabIndex = 4;
            // 
            // MtbNumGen
            // 
            this.MtbNumGen.BackColor = System.Drawing.Color.White;
            this.MtbNumGen.Font = new System.Drawing.Font("Noto Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbNumGen.Location = new System.Drawing.Point(13, 18);
            this.MtbNumGen.Mask = "99";
            this.MtbNumGen.Name = "MtbNumGen";
            this.MtbNumGen.Size = new System.Drawing.Size(46, 29);
            this.MtbNumGen.TabIndex = 7;
            // 
            // BtnGenValid
            // 
            this.BtnGenValid.BackColor = System.Drawing.Color.White;
            this.BtnGenValid.Font = new System.Drawing.Font("Noto Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenValid.Location = new System.Drawing.Point(77, 19);
            this.BtnGenValid.Name = "BtnGenValid";
            this.BtnGenValid.Size = new System.Drawing.Size(83, 28);
            this.BtnGenValid.TabIndex = 5;
            this.BtnGenValid.Text = "Valider";
            this.BtnGenValid.UseVisualStyleBackColor = false;
            this.BtnGenValid.Click += new System.EventHandler(this.BtnGenValid_Click);
            // 
            // PnlAnnee
            // 
            this.PnlAnnee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlAnnee.Controls.Add(this.LbxAnnees);
            this.PnlAnnee.Controls.Add(this.MtbAnnee);
            this.PnlAnnee.Controls.Add(this.BtnAnneeValid);
            this.PnlAnnee.Location = new System.Drawing.Point(9, 6);
            this.PnlAnnee.Name = "PnlAnnee";
            this.PnlAnnee.Size = new System.Drawing.Size(582, 169);
            this.PnlAnnee.TabIndex = 10;
            // 
            // LbxAnnees
            // 
            this.LbxAnnees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LbxAnnees.FormattingEnabled = true;
            this.LbxAnnees.Location = new System.Drawing.Point(237, 6);
            this.LbxAnnees.Name = "LbxAnnees";
            this.LbxAnnees.Size = new System.Drawing.Size(149, 160);
            this.LbxAnnees.TabIndex = 3;
            // 
            // MtbAnnee
            // 
            this.MtbAnnee.BackColor = System.Drawing.Color.White;
            this.MtbAnnee.Font = new System.Drawing.Font("Noto Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbAnnee.Location = new System.Drawing.Point(3, 43);
            this.MtbAnnee.Mask = "0000";
            this.MtbAnnee.Name = "MtbAnnee";
            this.MtbAnnee.Size = new System.Drawing.Size(68, 29);
            this.MtbAnnee.TabIndex = 1;
            this.MtbAnnee.ValidatingType = typeof(System.DateTime);
            // 
            // BtnAnneeValid
            // 
            this.BtnAnneeValid.BackColor = System.Drawing.Color.White;
            this.BtnAnneeValid.Font = new System.Drawing.Font("Noto Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnneeValid.Location = new System.Drawing.Point(77, 44);
            this.BtnAnneeValid.Name = "BtnAnneeValid";
            this.BtnAnneeValid.Size = new System.Drawing.Size(83, 28);
            this.BtnAnneeValid.TabIndex = 2;
            this.BtnAnneeValid.Text = "Valider";
            this.BtnAnneeValid.UseVisualStyleBackColor = false;
            this.BtnAnneeValid.Click += new System.EventHandler(this.BtnAnneeValid_Click);
            // 
            // USC_AnneeGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.PnlGen);
            this.Controls.Add(this.PnlAnnee);
            this.Name = "USC_AnneeGeneration";
            this.Size = new System.Drawing.Size(600, 385);
            this.Load += new System.EventHandler(this.USC_AnneeGeneration_Load);
            this.PnlGen.ResumeLayout(false);
            this.PnlGen.PerformLayout();
            this.PnlAnnee.ResumeLayout(false);
            this.PnlAnnee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlGen;
        private System.Windows.Forms.ListBox LbxGen;
        private System.Windows.Forms.ComboBox CbxAnnGen;
        private System.Windows.Forms.MaskedTextBox MtbNumGen;
        private System.Windows.Forms.Button BtnGenValid;
        private System.Windows.Forms.Panel PnlAnnee;
        private System.Windows.Forms.ListBox LbxAnnees;
        private System.Windows.Forms.MaskedTextBox MtbAnnee;
        private System.Windows.Forms.Button BtnAnneeValid;
    }
}
