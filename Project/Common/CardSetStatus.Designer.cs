namespace Droid_Game
{
    partial class CardSetStatus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnTrefle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCarreau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCoeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPique = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTrefle,
            this.ColumnCarreau,
            this.ColumnCoeur,
            this.ColumnPique});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(324, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnTrefle
            // 
            this.ColumnTrefle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTrefle.HeaderText = "TREFLE";
            this.ColumnTrefle.Name = "ColumnTrefle";
            // 
            // ColumnCarreau
            // 
            this.ColumnCarreau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCarreau.HeaderText = "CARREAU";
            this.ColumnCarreau.Name = "ColumnCarreau";
            // 
            // ColumnCoeur
            // 
            this.ColumnCoeur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCoeur.HeaderText = "COEUR";
            this.ColumnCoeur.Name = "ColumnCoeur";
            // 
            // ColumnPique
            // 
            this.ColumnPique.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPique.HeaderText = "PIQUE";
            this.ColumnPique.Name = "ColumnPique";
            // 
            // CardSetStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "CardSetStatus";
            this.Size = new System.Drawing.Size(324, 365);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTrefle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCarreau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCoeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPique;
    }
}
