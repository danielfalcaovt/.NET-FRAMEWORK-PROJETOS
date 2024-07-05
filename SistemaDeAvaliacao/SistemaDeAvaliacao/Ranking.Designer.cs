namespace SistemaDeAvaliacao
{
    partial class Ranking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ranking));
            txtRanking = new TextBox();
            txtVencedor = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtRanking
            // 
            txtRanking.Enabled = false;
            txtRanking.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRanking.Location = new Point(233, 47);
            txtRanking.Multiline = true;
            txtRanking.Name = "txtRanking";
            txtRanking.ReadOnly = true;
            txtRanking.Size = new Size(311, 336);
            txtRanking.TabIndex = 0;
            txtRanking.TextAlign = HorizontalAlignment.Center;
            // 
            // txtVencedor
            // 
            txtVencedor.AutoSize = true;
            txtVencedor.BackColor = Color.Transparent;
            txtVencedor.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVencedor.ForeColor = Color.White;
            txtVencedor.ImageAlign = ContentAlignment.MiddleRight;
            txtVencedor.Location = new Point(55, 180);
            txtVencedor.Name = "txtVencedor";
            txtVencedor.Size = new Size(0, 38);
            txtVencedor.TabIndex = 2;
            txtVencedor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(78, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 37);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Ranking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(181, 150, 231);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(txtVencedor);
            Controls.Add(txtRanking);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Ranking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ranking";
            Load += Ranking_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRanking;
        private Label txtVencedor;
        private PictureBox pictureBox1;
    }
}