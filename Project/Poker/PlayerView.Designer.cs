namespace Droid_Game.Poker
{
    partial class PlayerView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cardView1 = new Droid_Game.CardView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cardView2 = new Droid_Game.CardView();
            this.labelCombinaison = new System.Windows.Forms.Label();
            this.labelSolde = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelVictory = new System.Windows.Forms.Label();
            this.labelWinLose = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.cardView1);
            this.panel1.Location = new System.Drawing.Point(191, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 150);
            this.panel1.TabIndex = 2;
            // 
            // cardView1
            // 
            this.cardView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cardView1.BackColor = System.Drawing.Color.Gainsboro;
            this.cardView1.Location = new System.Drawing.Point(0, 0);
            this.cardView1.Name = "cardView1";
            this.cardView1.Size = new System.Drawing.Size(100, 150);
            this.cardView1.TabIndex = 0;
            this.cardView1.Visible = false;
            this.cardView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerView_Focus);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.cardView2);
            this.panel2.Location = new System.Drawing.Point(297, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 150);
            this.panel2.TabIndex = 3;
            // 
            // cardView2
            // 
            this.cardView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cardView2.BackColor = System.Drawing.Color.Gainsboro;
            this.cardView2.Location = new System.Drawing.Point(0, 0);
            this.cardView2.Name = "cardView2";
            this.cardView2.Size = new System.Drawing.Size(100, 150);
            this.cardView2.TabIndex = 1;
            this.cardView2.Visible = false;
            this.cardView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerView_Focus);
            // 
            // labelCombinaison
            // 
            this.labelCombinaison.AutoSize = true;
            this.labelCombinaison.BackColor = System.Drawing.Color.Transparent;
            this.labelCombinaison.Location = new System.Drawing.Point(7, 45);
            this.labelCombinaison.Name = "labelCombinaison";
            this.labelCombinaison.Size = new System.Drawing.Size(16, 13);
            this.labelCombinaison.TabIndex = 4;
            this.labelCombinaison.Text = "---";
            this.labelCombinaison.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerView_Focus);
            // 
            // labelSolde
            // 
            this.labelSolde.AutoSize = true;
            this.labelSolde.BackColor = System.Drawing.Color.Transparent;
            this.labelSolde.Location = new System.Drawing.Point(7, 71);
            this.labelSolde.Name = "labelSolde";
            this.labelSolde.Size = new System.Drawing.Size(43, 13);
            this.labelSolde.TabIndex = 5;
            this.labelSolde.Text = "Solde : ";
            this.labelSolde.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerView_Focus);
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(6, 10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(179, 19);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "PLAYER NAME";
            this.labelName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerView_Focus);
            // 
            // labelVictory
            // 
            this.labelVictory.AutoSize = true;
            this.labelVictory.BackColor = System.Drawing.Color.Transparent;
            this.labelVictory.Location = new System.Drawing.Point(7, 98);
            this.labelVictory.Name = "labelVictory";
            this.labelVictory.Size = new System.Drawing.Size(106, 13);
            this.labelVictory.TabIndex = 7;
            this.labelVictory.Text = "Have best hand : 0%";
            this.labelVictory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerView_Focus);
            // 
            // labelWinLose
            // 
            this.labelWinLose.AutoSize = true;
            this.labelWinLose.BackColor = System.Drawing.Color.Transparent;
            this.labelWinLose.Location = new System.Drawing.Point(7, 125);
            this.labelWinLose.Name = "labelWinLose";
            this.labelWinLose.Size = new System.Drawing.Size(52, 13);
            this.labelWinLose.TabIndex = 8;
            this.labelWinLose.Text = "Win : 0 %";
            // 
            // PlayerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.labelWinLose);
            this.Controls.Add(this.labelVictory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSolde);
            this.Controls.Add(this.labelCombinaison);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PlayerView";
            this.Size = new System.Drawing.Size(400, 157);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerView_Focus);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CardView cardView1;
        private CardView cardView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCombinaison;
        private System.Windows.Forms.Label labelSolde;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelVictory;
        private System.Windows.Forms.Label labelWinLose;
    }
}
