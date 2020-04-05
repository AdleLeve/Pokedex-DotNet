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
            this.pnlAvoirType = new System.Windows.Forms.Panel();
            this.ckbTypes2 = new System.Windows.Forms.CheckBox();
            this.ckbTypes1 = new System.Windows.Forms.CheckBox();
            this.lblTypesPkmSelect2 = new System.Windows.Forms.Label();
            this.lblTypesPkmSelect1 = new System.Windows.Forms.Label();
            this.BtnAjoutType = new System.Windows.Forms.Button();
            this.btnSuppAvoirType = new System.Windows.Forms.Button();
            this.cbxType2 = new System.Windows.Forms.ComboBox();
            this.cbxType1 = new System.Windows.Forms.ComboBox();
            this.lblATText = new System.Windows.Forms.Label();
            this.rdb2AV = new System.Windows.Forms.RadioButton();
            this.rdb1AV = new System.Windows.Forms.RadioButton();
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
            this.BtnPkmValid = new System.Windows.Forms.Button();
            this.PnlTypes.SuspendLayout();
            this.pnlAvoirType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSelectPkm)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTypes
            // 
            this.PnlTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlTypes.Controls.Add(this.pnlAvoirType);
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
            this.PnlTypes.Controls.Add(this.BtnPkmValid);
            this.PnlTypes.Location = new System.Drawing.Point(2, 3);
            this.PnlTypes.Name = "PnlTypes";
            this.PnlTypes.Size = new System.Drawing.Size(594, 376);
            this.PnlTypes.TabIndex = 13;
            // 
            // pnlAvoirType
            // 
            this.pnlAvoirType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAvoirType.Controls.Add(this.ckbTypes2);
            this.pnlAvoirType.Controls.Add(this.ckbTypes1);
            this.pnlAvoirType.Controls.Add(this.lblTypesPkmSelect2);
            this.pnlAvoirType.Controls.Add(this.lblTypesPkmSelect1);
            this.pnlAvoirType.Controls.Add(this.BtnAjoutType);
            this.pnlAvoirType.Controls.Add(this.btnSuppAvoirType);
            this.pnlAvoirType.Controls.Add(this.cbxType2);
            this.pnlAvoirType.Controls.Add(this.cbxType1);
            this.pnlAvoirType.Controls.Add(this.lblATText);
            this.pnlAvoirType.Controls.Add(this.rdb2AV);
            this.pnlAvoirType.Controls.Add(this.rdb1AV);
            this.pnlAvoirType.Location = new System.Drawing.Point(182, 210);
            this.pnlAvoirType.Name = "pnlAvoirType";
            this.pnlAvoirType.Size = new System.Drawing.Size(407, 142);
            this.pnlAvoirType.TabIndex = 25;
            // 
            // ckbTypes2
            // 
            this.ckbTypes2.AutoSize = true;
            this.ckbTypes2.Location = new System.Drawing.Point(299, 34);
            this.ckbTypes2.Name = "ckbTypes2";
            this.ckbTypes2.Size = new System.Drawing.Size(93, 30);
            this.ckbTypes2.TabIndex = 29;
            this.ckbTypes2.Text = "Selectionner\r\ntype ci-dessus";
            this.ckbTypes2.UseVisualStyleBackColor = true;
            this.ckbTypes2.CheckedChanged += new System.EventHandler(this.CkbTypes2_CheckedChanged);
            // 
            // ckbTypes1
            // 
            this.ckbTypes1.AutoSize = true;
            this.ckbTypes1.Location = new System.Drawing.Point(199, 33);
            this.ckbTypes1.Name = "ckbTypes1";
            this.ckbTypes1.Size = new System.Drawing.Size(93, 30);
            this.ckbTypes1.TabIndex = 28;
            this.ckbTypes1.Text = "Selectionner\r\ntype ci-dessus";
            this.ckbTypes1.UseVisualStyleBackColor = true;
            this.ckbTypes1.CheckedChanged += new System.EventHandler(this.CkbTypes1_CheckedChanged);
            // 
            // lblTypesPkmSelect2
            // 
            this.lblTypesPkmSelect2.AutoSize = true;
            this.lblTypesPkmSelect2.Location = new System.Drawing.Point(300, 10);
            this.lblTypesPkmSelect2.Name = "lblTypesPkmSelect2";
            this.lblTypesPkmSelect2.Size = new System.Drawing.Size(35, 13);
            this.lblTypesPkmSelect2.TabIndex = 27;
            this.lblTypesPkmSelect2.Text = "label1";
            // 
            // lblTypesPkmSelect1
            // 
            this.lblTypesPkmSelect1.AutoSize = true;
            this.lblTypesPkmSelect1.Location = new System.Drawing.Point(200, 10);
            this.lblTypesPkmSelect1.Name = "lblTypesPkmSelect1";
            this.lblTypesPkmSelect1.Size = new System.Drawing.Size(35, 13);
            this.lblTypesPkmSelect1.TabIndex = 26;
            this.lblTypesPkmSelect1.Text = "label1";
            // 
            // BtnAjoutType
            // 
            this.BtnAjoutType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjoutType.Location = new System.Drawing.Point(211, 106);
            this.BtnAjoutType.Name = "BtnAjoutType";
            this.BtnAjoutType.Size = new System.Drawing.Size(112, 23);
            this.BtnAjoutType.TabIndex = 6;
            this.BtnAjoutType.Text = "Ajouter type";
            this.BtnAjoutType.UseVisualStyleBackColor = true;
            this.BtnAjoutType.Click += new System.EventHandler(this.BtnAjoutType_Click);
            // 
            // btnSuppAvoirType
            // 
            this.btnSuppAvoirType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppAvoirType.Location = new System.Drawing.Point(41, 104);
            this.btnSuppAvoirType.Name = "btnSuppAvoirType";
            this.btnSuppAvoirType.Size = new System.Drawing.Size(115, 23);
            this.btnSuppAvoirType.TabIndex = 5;
            this.btnSuppAvoirType.Text = "Supprimer type(s)";
            this.btnSuppAvoirType.UseVisualStyleBackColor = true;
            this.btnSuppAvoirType.Click += new System.EventHandler(this.BtnSuppAvoirType_Click);
            // 
            // cbxType2
            // 
            this.cbxType2.FormattingEnabled = true;
            this.cbxType2.Location = new System.Drawing.Point(167, 72);
            this.cbxType2.Name = "cbxType2";
            this.cbxType2.Size = new System.Drawing.Size(156, 21);
            this.cbxType2.TabIndex = 4;
            // 
            // cbxType1
            // 
            this.cbxType1.FormattingEnabled = true;
            this.cbxType1.Location = new System.Drawing.Point(3, 72);
            this.cbxType1.Name = "cbxType1";
            this.cbxType1.Size = new System.Drawing.Size(153, 21);
            this.cbxType1.TabIndex = 3;
            // 
            // lblATText
            // 
            this.lblATText.AutoSize = true;
            this.lblATText.Location = new System.Drawing.Point(10, 9);
            this.lblATText.Name = "lblATText";
            this.lblATText.Size = new System.Drawing.Size(156, 13);
            this.lblATText.TabIndex = 2;
            this.lblATText.Text = "Nombre de types du Pokemon :";
            // 
            // rdb2AV
            // 
            this.rdb2AV.AutoSize = true;
            this.rdb2AV.Location = new System.Drawing.Point(50, 32);
            this.rdb2AV.Name = "rdb2AV";
            this.rdb2AV.Size = new System.Drawing.Size(31, 17);
            this.rdb2AV.TabIndex = 1;
            this.rdb2AV.Text = "2";
            this.rdb2AV.UseVisualStyleBackColor = true;
            // 
            // rdb1AV
            // 
            this.rdb1AV.AutoSize = true;
            this.rdb1AV.Checked = true;
            this.rdb1AV.Location = new System.Drawing.Point(13, 32);
            this.rdb1AV.Name = "rdb1AV";
            this.rdb1AV.Size = new System.Drawing.Size(31, 17);
            this.rdb1AV.TabIndex = 0;
            this.rdb1AV.TabStop = true;
            this.rdb1AV.Text = "1";
            this.rdb1AV.UseVisualStyleBackColor = true;
            this.rdb1AV.CheckedChanged += new System.EventHandler(this.Rdb1AV_CheckedChanged);
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
            this.ptbSelectPkm.Location = new System.Drawing.Point(435, 16);
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
            this.cbxUrlImg.SelectionChangeCommitted += new System.EventHandler(this.CbxUrlImg_SelectionChangeCommitted);
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
            this.LbxPkm.SelectedValueChanged += new System.EventHandler(this.LbxPkm_SelectedValueChanged);
            // 
            // BtnPkmValid
            // 
            this.BtnPkmValid.BackColor = System.Drawing.Color.White;
            this.BtnPkmValid.Font = new System.Drawing.Font("Noto Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPkmValid.Location = new System.Drawing.Point(3, 339);
            this.BtnPkmValid.Name = "BtnPkmValid";
            this.BtnPkmValid.Size = new System.Drawing.Size(83, 28);
            this.BtnPkmValid.TabIndex = 2;
            this.BtnPkmValid.Text = "Valider";
            this.BtnPkmValid.UseVisualStyleBackColor = false;
            this.BtnPkmValid.Click += new System.EventHandler(this.BtnPkmValid_Click);
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
            this.pnlAvoirType.ResumeLayout(false);
            this.pnlAvoirType.PerformLayout();
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
        private System.Windows.Forms.Button BtnPkmValid;
        private System.Windows.Forms.Label lblNomText;
        private System.Windows.Forms.MaskedTextBox mtbNumPkm;
        private System.Windows.Forms.Label lblDescText;
        private System.Windows.Forms.RichTextBox rtbDescText;
        private System.Windows.Forms.RadioButton rdbLegendaireFalse;
        private System.Windows.Forms.RadioButton rdbLegendaireTrue;
        private System.Windows.Forms.Label lblGenText;
        private System.Windows.Forms.ComboBox cbxGenPkm;
        private System.Windows.Forms.Panel pnlAvoirType;
        private System.Windows.Forms.ComboBox cbxType2;
        private System.Windows.Forms.ComboBox cbxType1;
        private System.Windows.Forms.Label lblATText;
        private System.Windows.Forms.RadioButton rdb2AV;
        private System.Windows.Forms.RadioButton rdb1AV;
        private System.Windows.Forms.Label lblTypesPkmSelect1;
        private System.Windows.Forms.Button BtnAjoutType;
        private System.Windows.Forms.Button btnSuppAvoirType;
        private System.Windows.Forms.CheckBox ckbTypes2;
        private System.Windows.Forms.CheckBox ckbTypes1;
        private System.Windows.Forms.Label lblTypesPkmSelect2;
    }
}
