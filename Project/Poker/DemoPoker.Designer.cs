namespace Droid_Game
{
    partial class DemoPoker
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRelaunch = new System.Windows.Forms.Button();
            this.playerView2 = new Droid_Game.Poker.PlayerView();
            this.playerView1 = new Droid_Game.Poker.PlayerView();
            this.benchmark1 = new Droid_Game.Poker.Benchmark();
            this.SuspendLayout();
            // 
            // buttonRelaunch
            // 
            this.buttonRelaunch.Location = new System.Drawing.Point(12, 26);
            this.buttonRelaunch.Name = "buttonRelaunch";
            this.buttonRelaunch.Size = new System.Drawing.Size(75, 69);
            this.buttonRelaunch.TabIndex = 3;
            this.buttonRelaunch.Text = "Relaunch";
            this.buttonRelaunch.UseVisualStyleBackColor = true;
            this.buttonRelaunch.Click += new System.EventHandler(this.buttonRelaunch_Click);
            // 
            // playerView2
            // 
            this.playerView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.playerView2.Location = new System.Drawing.Point(418, 174);
            this.playerView2.Name = "playerView2";
            this.playerView2.Player = null;
            this.playerView2.Size = new System.Drawing.Size(400, 157);
            this.playerView2.TabIndex = 2;
            // 
            // playerView1
            // 
            this.playerView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.playerView1.Location = new System.Drawing.Point(12, 174);
            this.playerView1.Name = "playerView1";
            this.playerView1.Player = null;
            this.playerView1.Size = new System.Drawing.Size(400, 157);
            this.playerView1.TabIndex = 1;
            // 
            // benchmark1
            // 
            this.benchmark1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.benchmark1.Location = new System.Drawing.Point(160, 12);
            this.benchmark1.Name = "benchmark1";
            this.benchmark1.Size = new System.Drawing.Size(532, 156);
            this.benchmark1.TabIndex = 0;
            // 
            // DemoPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(826, 337);
            this.Controls.Add(this.buttonRelaunch);
            this.Controls.Add(this.playerView2);
            this.Controls.Add(this.playerView1);
            this.Controls.Add(this.benchmark1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DemoPoker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poker";
            this.ResumeLayout(false);

        }

        #endregion

        private Poker.Benchmark benchmark1;
        private Poker.PlayerView playerView1;
        private Poker.PlayerView playerView2;
        private System.Windows.Forms.Button buttonRelaunch;
    }
}

