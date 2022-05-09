
namespace projetppe
{
    partial class Frmlisteproduits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btndatagridproduit = new System.Windows.Forms.DataGridView();
            this.fdfff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ffff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fffff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Administrateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suspendu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnrafraichir = new System.Windows.Forms.Button();
            this.btnproduit = new System.Windows.Forms.TextBox();
            this.btnproduit1 = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btndatagridproduit)).BeginInit();
            this.SuspendLayout();
            // 
            // btndatagridproduit
            // 
            this.btndatagridproduit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.btndatagridproduit.BackgroundColor = System.Drawing.Color.DimGray;
            this.btndatagridproduit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.btndatagridproduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.btndatagridproduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fdfff,
            this.ffff,
            this.dataGridViewTextBoxColumn1,
            this.fffff,
            this.Administrateur,
            this.Suspendu});
            this.btndatagridproduit.Location = new System.Drawing.Point(2, 3);
            this.btndatagridproduit.Name = "btndatagridproduit";
            this.btndatagridproduit.RowHeadersWidth = 82;
            this.btndatagridproduit.RowTemplate.Height = 25;
            this.btndatagridproduit.Size = new System.Drawing.Size(883, 315);
            this.btndatagridproduit.TabIndex = 3;
            // 
            // fdfff
            // 
            this.fdfff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fdfff.HeaderText = "ID";
            this.fdfff.MinimumWidth = 10;
            this.fdfff.Name = "fdfff";
            // 
            // ffff
            // 
            this.ffff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ffff.HeaderText = "Nom";
            this.ffff.MinimumWidth = 10;
            this.ffff.Name = "ffff";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Prénom";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // fffff
            // 
            this.fffff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fffff.HeaderText = "Résponsable";
            this.fffff.MinimumWidth = 10;
            this.fffff.Name = "fffff";
            // 
            // Administrateur
            // 
            this.Administrateur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Administrateur.HeaderText = "Administrateur";
            this.Administrateur.MinimumWidth = 10;
            this.Administrateur.Name = "Administrateur";
            // 
            // Suspendu
            // 
            this.Suspendu.HeaderText = "Suspendu";
            this.Suspendu.Name = "Suspendu";
            // 
            // btnrafraichir
            // 
            this.btnrafraichir.BackColor = System.Drawing.Color.Silver;
            this.btnrafraichir.FlatAppearance.BorderSize = 0;
            this.btnrafraichir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrafraichir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnrafraichir.Location = new System.Drawing.Point(18, 571);
            this.btnrafraichir.Name = "btnrafraichir";
            this.btnrafraichir.Size = new System.Drawing.Size(108, 41);
            this.btnrafraichir.TabIndex = 11;
            this.btnrafraichir.Text = "Rafraîchir";
            this.btnrafraichir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnrafraichir.UseVisualStyleBackColor = false;
            this.btnrafraichir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnproduit
            // 
            this.btnproduit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnproduit.Location = new System.Drawing.Point(162, 581);
            this.btnproduit.Name = "btnproduit";
            this.btnproduit.Size = new System.Drawing.Size(126, 23);
            this.btnproduit.TabIndex = 12;
            // 
            // btnproduit1
            // 
            this.btnproduit1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnproduit1.Location = new System.Drawing.Point(346, 581);
            this.btnproduit1.Name = "btnproduit1";
            this.btnproduit1.Size = new System.Drawing.Size(126, 23);
            this.btnproduit1.TabIndex = 13;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Silver;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnexit.Location = new System.Drawing.Point(758, 571);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(108, 41);
            this.btnexit.TabIndex = 14;
            this.btnexit.Text = "Exit";
            this.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnexit.UseVisualStyleBackColor = false;
            // 
            // Frmlisteproduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 624);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnproduit1);
            this.Controls.Add(this.btnproduit);
            this.Controls.Add(this.btnrafraichir);
            this.Controls.Add(this.btndatagridproduit);
            this.Name = "Frmlisteproduits";
            this.Text = "Frmlisteproduits";
            ((System.ComponentModel.ISupportInitialize)(this.btndatagridproduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView btndatagridproduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn fdfff;
        private System.Windows.Forms.DataGridViewTextBoxColumn ffff;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fffff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Administrateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suspendu;
        private System.Windows.Forms.Button btnrafraichir;
        private System.Windows.Forms.TextBox btnproduit;
        private System.Windows.Forms.TextBox btnproduit1;
        private System.Windows.Forms.Button btnexit;
    }
}