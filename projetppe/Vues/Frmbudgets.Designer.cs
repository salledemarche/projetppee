
namespace projetppe
{
    partial class Frmbudgets
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
            this.btndatagridbudge = new System.Windows.Forms.DataGridView();
            this.fdfff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ffff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fffff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Administrateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suspendu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbllogin = new System.Windows.Forms.Label();
            this.btnbudget = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnvalider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btndatagridbudge)).BeginInit();
            this.SuspendLayout();
            // 
            // btndatagridbudge
            // 
            this.btndatagridbudge.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.btndatagridbudge.BackgroundColor = System.Drawing.Color.DimGray;
            this.btndatagridbudge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.btndatagridbudge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.btndatagridbudge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fdfff,
            this.ffff,
            this.dataGridViewTextBoxColumn1,
            this.fffff,
            this.Administrateur,
            this.Suspendu});
            this.btndatagridbudge.Location = new System.Drawing.Point(0, 3);
            this.btndatagridbudge.Name = "btndatagridbudge";
            this.btndatagridbudge.RowHeadersWidth = 82;
            this.btndatagridbudge.RowTemplate.Height = 25;
            this.btndatagridbudge.Size = new System.Drawing.Size(883, 315);
            this.btndatagridbudge.TabIndex = 2;
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
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbllogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lbllogin.Location = new System.Drawing.Point(12, 581);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(130, 20);
            this.lbllogin.TabIndex = 7;
            this.lbllogin.Text = "Nouveau  budget";
            // 
            // btnbudget
            // 
            this.btnbudget.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnbudget.Location = new System.Drawing.Point(148, 580);
            this.btnbudget.Name = "btnbudget";
            this.btnbudget.Size = new System.Drawing.Size(126, 23);
            this.btnbudget.TabIndex = 8;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnexit.Location = new System.Drawing.Point(763, 562);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(108, 41);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "Exit";
            this.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnconnexion_Click);
            // 
            // btnvalider
            // 
            this.btnvalider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnvalider.FlatAppearance.BorderSize = 0;
            this.btnvalider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvalider.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnvalider.Location = new System.Drawing.Point(635, 562);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(108, 41);
            this.btnvalider.TabIndex = 10;
            this.btnvalider.Text = "Valider";
            this.btnvalider.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnvalider.UseVisualStyleBackColor = false;
            // 
            // Frmbudgets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 610);
            this.Controls.Add(this.btnvalider);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnbudget);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.btndatagridbudge);
            this.Name = "Frmbudgets";
            this.Text = "Frmbudgets";
            ((System.ComponentModel.ISupportInitialize)(this.btndatagridbudge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView btndatagridbudge;
        private System.Windows.Forms.DataGridViewTextBoxColumn fdfff;
        private System.Windows.Forms.DataGridViewTextBoxColumn ffff;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fffff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Administrateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suspendu;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.TextBox btnbudget;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnvalider;
    }
}