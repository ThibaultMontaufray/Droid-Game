namespace Droid_Game
{
    partial class CardView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardView));
            this.labelNb1 = new System.Windows.Forms.Label();
            this.labelNb2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imageListColor = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNb1
            // 
            this.labelNb1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNb1.Location = new System.Drawing.Point(25, 2);
            this.labelNb1.Name = "labelNb1";
            this.labelNb1.Size = new System.Drawing.Size(66, 18);
            this.labelNb1.TabIndex = 0;
            this.labelNb1.Text = "0";
            this.labelNb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNb2
            // 
            this.labelNb2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNb2.Location = new System.Drawing.Point(10, 130);
            this.labelNb2.Name = "labelNb2";
            this.labelNb2.Size = new System.Drawing.Size(65, 17);
            this.labelNb2.TabIndex = 1;
            this.labelNb2.Text = "0";
            this.labelNb2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(81, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // imageListColor
            // 
            this.imageListColor.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListColor.ImageStream")));
            this.imageListColor.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListColor.Images.SetKeyName(0, "pique");
            this.imageListColor.Images.SetKeyName(1, "carreau");
            this.imageListColor.Images.SetKeyName(2, "trefle");
            this.imageListColor.Images.SetKeyName(3, "coeur");
            this.imageListColor.Images.SetKeyName(4, "coeurR");
            this.imageListColor.Images.SetKeyName(5, "piqueR");
            this.imageListColor.Images.SetKeyName(6, "trefleR");
            // 
            // CardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelNb2);
            this.Controls.Add(this.labelNb1);
            this.Name = "CardView";
            this.Size = new System.Drawing.Size(100, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNb1;
        private System.Windows.Forms.Label labelNb2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList imageListColor;
    }
}
