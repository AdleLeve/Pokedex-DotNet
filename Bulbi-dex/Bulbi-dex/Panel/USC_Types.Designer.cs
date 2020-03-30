namespace Bulbi_dex.Panel
{
    partial class USC_Types
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
            this.cbxGenTypes = new System.Windows.Forms.ComboBox();
            this.TbxTypes = new System.Windows.Forms.TextBox();
            this.LbxType = new System.Windows.Forms.ListBox();
            this.BtnTypesValid = new System.Windows.Forms.Button();
            this.PnlTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTypes
            // 
            this.PnlTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlTypes.Controls.Add(this.cbxGenTypes);
            this.PnlTypes.Controls.Add(this.TbxTypes);
            this.PnlTypes.Controls.Add(this.LbxType);
            this.PnlTypes.Controls.Add(this.BtnTypesValid);
            this.PnlTypes.Location = new System.Drawing.Point(3, 14);
            this.PnlTypes.Name = "PnlTypes";
            this.PnlTypes.Size = new System.Drawing.Size(582, 169);
            this.PnlTypes.TabIndex = 11;
            // 
            // cbxGenTypes
            // 
            this.cbxGenTypes.FormattingEnabled = true;
            this.cbxGenTypes.Location = new System.Drawing.Point(3, 65);
            this.cbxGenTypes.Name = "cbxGenTypes";
            this.cbxGenTypes.Size = new System.Drawing.Size(121, 21);
            this.cbxGenTypes.TabIndex = 12;
            // 
            // TbxTypes
            // 
            this.TbxTypes.Location = new System.Drawing.Point(3, 35);
            this.TbxTypes.Name = "TbxTypes";
            this.TbxTypes.Size = new System.Drawing.Size(139, 20);
            this.TbxTypes.TabIndex = 4;
            // 
            // LbxType
            // 
            this.LbxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LbxType.FormattingEnabled = true;
            this.LbxType.Location = new System.Drawing.Point(237, 6);
            this.LbxType.Name = "LbxType";
            this.LbxType.Size = new System.Drawing.Size(149, 160);
            this.LbxType.TabIndex = 3;
            // 
            // BtnTypesValid
            // 
            this.BtnTypesValid.BackColor = System.Drawing.Color.White;
            this.BtnTypesValid.Font = new System.Drawing.Font("Noto Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTypesValid.Location = new System.Drawing.Point(21, 92);
            this.BtnTypesValid.Name = "BtnTypesValid";
            this.BtnTypesValid.Size = new System.Drawing.Size(83, 28);
            this.BtnTypesValid.TabIndex = 2;
            this.BtnTypesValid.Text = "Valider";
            this.BtnTypesValid.UseVisualStyleBackColor = false;
            this.BtnTypesValid.Click += new System.EventHandler(this.BtnTypesValid_Click);
            // 
            // USC_Types
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.PnlTypes);
            this.Name = "USC_Types";
            this.Size = new System.Drawing.Size(600, 385);
            this.Load += new System.EventHandler(this.USC_Types_Load);
            this.PnlTypes.ResumeLayout(false);
            this.PnlTypes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTypes;
        private System.Windows.Forms.ListBox LbxType;
        private System.Windows.Forms.Button BtnTypesValid;
        private System.Windows.Forms.TextBox TbxTypes;
        private System.Windows.Forms.ComboBox cbxGenTypes;
    }
}
