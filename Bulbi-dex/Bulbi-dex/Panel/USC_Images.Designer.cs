namespace Bulbi_dex.Panel
{
    partial class USC_Images
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
            this.lblExtImgText = new System.Windows.Forms.Label();
            this.lblUrlText = new System.Windows.Forms.Label();
            this.ptbSelectImg = new System.Windows.Forms.PictureBox();
            this.dtgPkmImg = new System.Windows.Forms.DataGridView();
            this.cbxExtImg = new System.Windows.Forms.ComboBox();
            this.TbxUrlImg = new System.Windows.Forms.TextBox();
            this.LbxImg = new System.Windows.Forms.ListBox();
            this.BtnImgValid = new System.Windows.Forms.Button();
            this.PnlTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSelectImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPkmImg)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTypes
            // 
            this.PnlTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlTypes.Controls.Add(this.lblExtImgText);
            this.PnlTypes.Controls.Add(this.lblUrlText);
            this.PnlTypes.Controls.Add(this.ptbSelectImg);
            this.PnlTypes.Controls.Add(this.dtgPkmImg);
            this.PnlTypes.Controls.Add(this.cbxExtImg);
            this.PnlTypes.Controls.Add(this.TbxUrlImg);
            this.PnlTypes.Controls.Add(this.LbxImg);
            this.PnlTypes.Controls.Add(this.BtnImgValid);
            this.PnlTypes.Location = new System.Drawing.Point(3, 3);
            this.PnlTypes.Name = "PnlTypes";
            this.PnlTypes.Size = new System.Drawing.Size(594, 379);
            this.PnlTypes.TabIndex = 12;
            // 
            // lblExtImgText
            // 
            this.lblExtImgText.AutoSize = true;
            this.lblExtImgText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtImgText.Location = new System.Drawing.Point(3, 129);
            this.lblExtImgText.Name = "lblExtImgText";
            this.lblExtImgText.Size = new System.Drawing.Size(151, 17);
            this.lblExtImgText.TabIndex = 16;
            this.lblExtImgText.Text = "Choisir une extension :";
            // 
            // lblUrlText
            // 
            this.lblUrlText.AutoSize = true;
            this.lblUrlText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlText.Location = new System.Drawing.Point(3, 67);
            this.lblUrlText.Name = "lblUrlText";
            this.lblUrlText.Size = new System.Drawing.Size(213, 17);
            this.lblUrlText.TabIndex = 15;
            this.lblUrlText.Text = "Inscrire l\'adresse Url de l\'image :";
            // 
            // ptbSelectImg
            // 
            this.ptbSelectImg.Location = new System.Drawing.Point(435, 30);
            this.ptbSelectImg.Name = "ptbSelectImg";
            this.ptbSelectImg.Size = new System.Drawing.Size(154, 140);
            this.ptbSelectImg.TabIndex = 14;
            this.ptbSelectImg.TabStop = false;
            // 
            // dtgPkmImg
            // 
            this.dtgPkmImg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPkmImg.Location = new System.Drawing.Point(167, 196);
            this.dtgPkmImg.Name = "dtgPkmImg";
            this.dtgPkmImg.Size = new System.Drawing.Size(422, 178);
            this.dtgPkmImg.TabIndex = 13;
            this.dtgPkmImg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgPkmImg_CellClick);
            this.dtgPkmImg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgPkmImg_CellContentClick);
            // 
            // cbxExtImg
            // 
            this.cbxExtImg.FormattingEnabled = true;
            this.cbxExtImg.Location = new System.Drawing.Point(6, 149);
            this.cbxExtImg.Name = "cbxExtImg";
            this.cbxExtImg.Size = new System.Drawing.Size(121, 21);
            this.cbxExtImg.TabIndex = 12;
            // 
            // TbxUrlImg
            // 
            this.TbxUrlImg.Location = new System.Drawing.Point(6, 87);
            this.TbxUrlImg.Name = "TbxUrlImg";
            this.TbxUrlImg.Size = new System.Drawing.Size(210, 20);
            this.TbxUrlImg.TabIndex = 4;
            // 
            // LbxImg
            // 
            this.LbxImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LbxImg.FormattingEnabled = true;
            this.LbxImg.Location = new System.Drawing.Point(237, 30);
            this.LbxImg.Name = "LbxImg";
            this.LbxImg.Size = new System.Drawing.Size(192, 160);
            this.LbxImg.TabIndex = 3;
            this.LbxImg.SelectedValueChanged += new System.EventHandler(this.LbxImg_SelectedValueChanged);
            // 
            // BtnImgValid
            // 
            this.BtnImgValid.BackColor = System.Drawing.Color.White;
            this.BtnImgValid.Font = new System.Drawing.Font("Noto Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImgValid.Location = new System.Drawing.Point(24, 186);
            this.BtnImgValid.Name = "BtnImgValid";
            this.BtnImgValid.Size = new System.Drawing.Size(83, 28);
            this.BtnImgValid.TabIndex = 2;
            this.BtnImgValid.Text = "Valider";
            this.BtnImgValid.UseVisualStyleBackColor = false;
            this.BtnImgValid.Click += new System.EventHandler(this.BtnImgValid_Click);
            // 
            // USC_Images
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.PnlTypes);
            this.Name = "USC_Images";
            this.Size = new System.Drawing.Size(600, 385);
            this.Load += new System.EventHandler(this.USC_Images_Load);
            this.PnlTypes.ResumeLayout(false);
            this.PnlTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSelectImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPkmImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTypes;
        private System.Windows.Forms.ComboBox cbxExtImg;
        private System.Windows.Forms.TextBox TbxUrlImg;
        private System.Windows.Forms.ListBox LbxImg;
        private System.Windows.Forms.Button BtnImgValid;
        private System.Windows.Forms.PictureBox ptbSelectImg;
        private System.Windows.Forms.DataGridView dtgPkmImg;
        private System.Windows.Forms.Label lblExtImgText;
        private System.Windows.Forms.Label lblUrlText;
    }
}
