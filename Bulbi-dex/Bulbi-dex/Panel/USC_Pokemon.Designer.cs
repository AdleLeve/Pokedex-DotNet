namespace Bulbi_dex.Panel
{
    partial class USC_Pokemon
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
            this.lblGenText = new System.Windows.Forms.Label();
            this.cbxGenPkm = new System.Windows.Forms.ComboBox();
            this.rdbLegendaireFalse = new System.Windows.Forms.RadioButton();
            this.rdbLegendaireTrue = new System.Windows.Forms.RadioButton();
            this.lblDescText = new System.Windows.Forms.Label();
            this.rtbDescText = new System.Windows.Forms.RichTextBox();
            this.mtbNumPkm = new System.Windows.Forms.MaskedTextBox();
            this.lblNomText = new System.Windows.Forms.Label();
            this.lblUrlText = new System.Windows.Forms.Label();
            this.lblNumText = new System.Windows.Forms.Label();
            this.ptbSelectPkm = new System.Windows.Forms.PictureBox();
            this.cbxUrlImg = new System.Windows.Forms.ComboBox();
            this.TbxNomImg = new System.Windows.Forms.TextBox();
            this.LbxPkm = new System.Windows.Forms.ListBox();
            this.BtnImgValid = new System.Windows.Forms.Button();
            this.PnlTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSelectPkm)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTypes
            // 
            this.PnlTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlTypes.Controls.Add(this.lblGenText);
            this.PnlTypes.Controls.Add(this.cbxGenPkm);
            this.PnlTypes.Controls.Add(this.rdbLegendaireFalse);
            this.PnlTypes.Controls.Add(this.rdbLegendaireTrue);
            this.PnlTypes.Controls.Add(this.lblDescText);
            this.PnlTypes.Controls.Add(this.rtbDescText);
            this.PnlTypes.Controls.Add(this.mtbNumPkm);
            this.PnlTypes.Controls.Add(this.lblNomText);
            this.PnlTypes.Controls.Add(this.lblUrlText);
            this.PnlTypes.Controls.Add(this.lblNumText);
            this.PnlTypes.Controls.Add(this.ptbSelectPkm);
            this.PnlTypes.Controls.Add(this.cbxUrlImg);
            this.PnlTypes.Controls.Add(this.TbxNomImg);
            this.PnlTypes.Controls.Add(this.LbxPkm);
            this.PnlTypes.Controls.Add(this.BtnImgValid);
            this.PnlTypes.Location = new System.Drawing.Point(2, 3);
            this.PnlTypes.Name = "PnlTypes";
            this.PnlTypes.Size = new System.Drawing.Size(594, 376);
            this.PnlTypes.TabIndex = 13;
            // 
            // lblGenText
            // 
            this.lblGenText.AutoSize = true;
            this.lblGenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenText.Location = new System.Drawing.Point(3, 297);
            this.lblGenText.Name = "lblGenText";
            this.lblGenText.Size = new System.Drawing.Size(162, 17);
            this.lblGenText.TabIndex = 24;
            this.lblGenText.Text = "Choisir une Generation :";
            // 
            // cbxGenPkm
            // 
            this.cbxGenPkm.FormattingEnabled = true;
            this.cbxGenPkm.Location = new System.Drawing.Point(6, 317);
            this.cbxGenPkm.Name = "cbxGenPkm";
            this.cbxGenPkm.Size = new System.Drawing.Size(170, 21);
            this.cbxGenPkm.TabIndex = 23;
            // 
            // rdbLegendaireFalse
            // 
            this.rdbLegendaireFalse.AutoSize = true;
            this.rdbLegendaireFalse.Checked = true;
            this.rdbLegendaireFalse.Location = new System.Drawing.Point(6, 233);
            this.rdbLegendaireFalse.Name = "rdbLegendaireFalse";
            this.rdbLegendaireFalse.Size = new System.Drawing.Size(101, 17);
            this.rdbLegendaireFalse.TabIndex = 22;
            this.rdbLegendaireFalse.TabStop = true;
            this.rdbLegendaireFalse.Text = "Non Légendaire";
            this.rdbLegendaireFalse.UseVisualStyleBackColor = true;
            // 
            // rdbLegendaireTrue
            // 
            this.rdbLegendaireTrue.AutoSize = true;
            this.rdbLegendaireTrue.Location = new System.Drawing.Point(6, 210);
            this.rdbLegendaireTrue.Name = "rdbLegendaireTrue";
            this.rdbLegendaireTrue.Size = new System.Drawing.Size(78, 17);
            this.rdbLegendaireTrue.TabIndex = 21;
            this.rdbLegendaireTrue.Text = "Légendaire";
            this.rdbLegendaireTrue.UseVisualStyleBackColor = true;
            // 
            // lblDescText
            // 
            this.lblDescText.AutoSize = true;
            this.lblDescText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescText.Location = new System.Drawing.Point(3, 113);
            this.lblDescText.Name = "lblDescText";
            this.lblDescText.Size = new System.Drawing.Size(233, 17);
            this.lblDescText.TabIndex = 20;
            this.lblDescText.Text = "Inscrire la description du Pokemon :";
            // 
            // rtbDescText
            // 
            this.rtbDescText.Location = new System.Drawing.Point(3, 133);
            this.rtbDescText.Name = "rtbDescText";
            this.rtbDescText.Size = new System.Drawing.Size(221, 69);
            this.rtbDescText.TabIndex = 19;
            this.rtbDescText.Text = "";
            // 
            // mtbNumPkm
            // 
            this.mtbNumPkm.Location = new System.Drawing.Point(3, 42);
            this.mtbNumPkm.Mask = "999";
            this.mtbNumPkm.Name = "mtbNumPkm";
            this.mtbNumPkm.Size = new System.Drawing.Size(55, 20);
            this.mtbNumPkm.TabIndex = 18;
            // 
            // lblNomText
            // 
            this.lblNomText.AutoSize = true;
            this.lblNomText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomText.Location = new System.Drawing.Point(3, 68);
            this.lblNomText.Name = "lblNomText";
            this.lblNomText.Size = new System.Drawing.Size(191, 17);
            this.lblNomText.TabIndex = 17;
            this.lblNomText.Text = "Inscrire le nom du Pokemon :";
            // 
            // lblUrlText
            // 
            this.lblUrlText.AutoSize = true;
            this.lblUrlText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlText.Location = new System.Drawing.Point(3, 253);
            this.lblUrlText.Name = "lblUrlText";
            this.lblUrlText.Size = new System.Drawing.Size(109, 17);
            this.lblUrlText.TabIndex = 16;
            this.lblUrlText.Text = "Choisir une Url :";
            // 
            // lblNumText
            // 
            this.lblNumText.AutoSize = true;
            this.lblNumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumText.Location = new System.Drawing.Point(3, 5);
            this.lblNumText.Name = "lblNumText";
            this.lblNumText.Size = new System.Drawing.Size(156, 34);
            this.lblNumText.TabIndex = 15;
            this.lblNumText.Text = "Inscrire le numéro dans\r\nle Pokedex Mondial :";
            // 
            // ptbSelectPkm
            // 
            this.ptbSelectPkm.Location = new System.Drawing.Point(197, 231);
            this.ptbSelectPkm.Name = "ptbSelectPkm";
            this.ptbSelectPkm.Size = new System.Drawing.Size(154, 140);
            this.ptbSelectPkm.TabIndex = 14;
            this.ptbSelectPkm.TabStop = false;
            // 
            // cbxUrlImg
            // 
            this.cbxUrlImg.FormattingEnabled = true;
            this.cbxUrlImg.Location = new System.Drawing.Point(6, 273);
            this.cbxUrlImg.Name = "cbxUrlImg";
            this.cbxUrlImg.Size = new System.Drawing.Size(170, 21);
            this.cbxUrlImg.TabIndex = 12;
            this.cbxUrlImg.SelectedValueChanged += new System.EventHandler(this.CbxExtImg_SelectedValueChanged);
            // 
            // TbxNomImg
            // 
            this.TbxNomImg.Location = new System.Drawing.Point(3, 88);
            this.TbxNomImg.Name = "TbxNomImg";
            this.TbxNomImg.Size = new System.Drawing.Size(210, 20);
            this.TbxNomImg.TabIndex = 4;
            // 
            // LbxPkm
            // 
            this.LbxPkm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LbxPkm.FormattingEnabled = true;
            this.LbxPkm.Location = new System.Drawing.Point(239, 16);
            this.LbxPkm.Name = "LbxPkm";
            this.LbxPkm.Size = new System.Drawing.Size(192, 160);
            this.LbxPkm.TabIndex = 3;
            // 
            // BtnImgValid
            // 
            this.BtnImgValid.BackColor = System.Drawing.Color.White;
            this.BtnImgValid.Font = new System.Drawing.Font("Noto Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImgValid.Location = new System.Drawing.Point(3, 339);
            this.BtnImgValid.Name = "BtnImgValid";
            this.BtnImgValid.Size = new System.Drawing.Size(83, 28);
            this.BtnImgValid.TabIndex = 2;
            this.BtnImgValid.Text = "Valider";
            this.BtnImgValid.UseVisualStyleBackColor = false;
            this.BtnImgValid.Click += new System.EventHandler(this.BtnImgValid_Click);
            // 
            // USC_Pokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.PnlTypes);
            this.Name = "USC_Pokemon";
            this.Size = new System.Drawing.Size(600, 385);
            this.Load += new System.EventHandler(this.USC_Pokemon_Load);
            this.PnlTypes.ResumeLayout(false);
            this.PnlTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSelectPkm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTypes;
        private System.Windows.Forms.Label lblUrlText;
        private System.Windows.Forms.Label lblNumText;
        private System.Windows.Forms.PictureBox ptbSelectPkm;
        private System.Windows.Forms.ComboBox cbxUrlImg;
        private System.Windows.Forms.TextBox TbxNomImg;
        private System.Windows.Forms.ListBox LbxPkm;
        private System.Windows.Forms.Button BtnImgValid;
        private System.Windows.Forms.Label lblNomText;
        private System.Windows.Forms.MaskedTextBox mtbNumPkm;
        private System.Windows.Forms.Label lblDescText;
        private System.Windows.Forms.RichTextBox rtbDescText;
        private System.Windows.Forms.RadioButton rdbLegendaireFalse;
        private System.Windows.Forms.RadioButton rdbLegendaireTrue;
        private System.Windows.Forms.Label lblGenText;
        private System.Windows.Forms.ComboBox cbxGenPkm;
    }
}
