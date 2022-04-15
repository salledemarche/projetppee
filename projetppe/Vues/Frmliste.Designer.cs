
namespace projetppe
{
    partial class Frmliste
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmliste));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fdfff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ffff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fffff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Administrateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suspendu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RdIdentifiant = new System.Windows.Forms.RadioButton();
            this.RdNom = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.connectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fdfff,
            this.ffff,
            this.dataGridViewTextBoxColumn1,
            this.fffff,
            this.Administrateur,
            this.Suspendu});
            this.dataGridView1.Location = new System.Drawing.Point(2, 146);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1627, 503);
            this.dataGridView1.TabIndex = 1;
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
            this.Suspendu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Suspendu.HeaderText = "Suspendu";
            this.Suspendu.MinimumWidth = 10;
            this.Suspendu.Name = "Suspendu";
            this.Suspendu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Suspendu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // RdIdentifiant
            // 
            this.RdIdentifiant.AutoSize = true;
            this.RdIdentifiant.Location = new System.Drawing.Point(58, 640);
            this.RdIdentifiant.Margin = new System.Windows.Forms.Padding(6);
            this.RdIdentifiant.Name = "RdIdentifiant";
            this.RdIdentifiant.Size = new System.Drawing.Size(154, 36);
            this.RdIdentifiant.TabIndex = 2;
            this.RdIdentifiant.TabStop = true;
            this.RdIdentifiant.Text = "Identifiant";
            this.RdIdentifiant.UseVisualStyleBackColor = true;
            this.RdIdentifiant.CheckedChanged += new System.EventHandler(this.RdIdentifiant_CheckedChanged);
            // 
            // RdNom
            // 
            this.RdNom.AutoSize = true;
            this.RdNom.Location = new System.Drawing.Point(58, 587);
            this.RdNom.Margin = new System.Windows.Forms.Padding(6);
            this.RdNom.Name = "RdNom";
            this.RdNom.Size = new System.Drawing.Size(98, 36);
            this.RdNom.TabIndex = 3;
            this.RdNom.TabStop = true;
            this.RdNom.Text = "Nom";
            this.RdNom.UseVisualStyleBackColor = true;
            this.RdNom.CheckedChanged += new System.EventHandler(this.RdNom_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 540);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Visualisation Par";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 703);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1595, 734);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // connectBindingSource
            // 
            this.connectBindingSource.DataSource = typeof(projetppe.Dal.Connect);
            // 
            // Frmliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 1442);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RdNom);
            this.Controls.Add(this.RdIdentifiant);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frmliste";
            this.Text = "Frmliste";
            this.Load += new System.EventHandler(this.Frmliste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton RdIdentifiant;
        private System.Windows.Forms.RadioButton RdNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fdfff;
        private System.Windows.Forms.DataGridViewTextBoxColumn ffff;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fffff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Administrateur;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Suspendu;
        private System.Windows.Forms.BindingSource connectBindingSource;
    }
}